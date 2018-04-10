using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace PonTest
{
    class TelnetClient
    {
        private readonly System.Net.Sockets.TcpClient socket;
        private readonly System.Net.Sockets.NetworkStream stream;

        public TelnetClient(string hostName, int port)
        {
            try
            {
                this.socket = new System.Net.Sockets.TcpClient(hostName, port);
                System.Threading.AutoResetEvent are = new System.Threading.AutoResetEvent(false);
                are.WaitOne(20);
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to Connect " + e.Message);
                return;
            }

            stream = this.socket.GetStream();
        }

        public int ReceiveTimeout
        {
            get
            {
                return this.socket.ReceiveTimeout;
            }
            set
            {
                this.socket.ReceiveTimeout = value;
            }
        }

        public bool Connected
        {
            get
            {
                return this.socket.Connected;
            }
        }

        public int Available
        {
            get
            {
                return this.socket.Available;
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                this.Close();
                this.stream.Dispose();
            }
        }


        public string Read(TimeSpan timeout)
        {
            if (!this.Connected)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            this.ReceiveTimeout = (int)timeout.TotalMilliseconds;
            DateTime endInitialTimeout = DateTime.Now.Add(timeout);
            DateTime rollingTimeout = ExtendRollingTimeout(timeout);
            do
            {
                if (this.RetrieveAndParseResponse(sb))
                {
                    rollingTimeout = ExtendRollingTimeout(timeout);
                }
            }
            while ( this.IsResponseAnticipated(IsInitialResponseReceived(sb), endInitialTimeout, rollingTimeout) );
            if (IsRollingTimeoutExpired(rollingTimeout))
            {
                System.Diagnostics.Debug.Print("RollingTimeout exceeded {0}", DateTime.Now.ToString("ss:fff"));
            }

            return sb.ToString();
        }

        public int ReadByte()
        {
            return this.stream.ReadByte();
        }

        public void WriteByte(byte value)
        {
            this.stream.WriteByte(value);
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            this.stream.Write(buffer, offset, count);
        }

        public void Write(string command)
        {
            byte[] buffer = ConvertStringToByteArray(command);
            this.stream.Write(buffer, 0, buffer.Length);
        }

        public void Close()
        {
            this.socket.Close();
        }

        private static byte[] ConvertStringToByteArray(string command)
        {
            byte[] buffer = System.Text.ASCIIEncoding.ASCII.GetBytes(command.Replace("\0xFF", "\0xFF\0xFF"));
            return buffer;
        }

        internal enum Options
        {
            SuppressGoAhead = 3
        }

        internal enum Commands
        {
            Will = 251,
            Wont = 252,
            Do = 253,
            Dont = 254,
            InterpretAsCommand = 255
        }

        private bool IsResponsePending
        {
            get
            {
                return this.socket.Available > 0;
            }
        }

        private static DateTime ExtendRollingTimeout(TimeSpan timeout)
        {
            return DateTime.Now.Add(TimeSpan.FromMilliseconds(timeout.TotalMilliseconds / 100));
        }

        private static bool IsWaitForIncrementalResponse(DateTime rollingTimeout)
        {
            bool result = DateTime.Now < rollingTimeout;
            System.Threading.Thread.Sleep(1);
            return result;
        }

        private static bool IsWaitForInitialResponse(DateTime endInitialTimeout, bool isInitialResponseReceived)
        {
            return !isInitialResponseReceived && DateTime.Now < endInitialTimeout;
        }

        private static bool IsRollingTimeoutExpired(DateTime rollingTimeout)
        {
            return DateTime.Now >= rollingTimeout;
        }

        private static bool IsInitialResponseReceived(StringBuilder sb)
        {
            return sb.Length > 0;
        }

        private bool RetrieveAndParseResponse(StringBuilder sb)
        {
            if (this.IsResponsePending)
            {
                int input = this.stream.ReadByte();
                switch (input)
                {
                    case -1:
                        break;
                    case (int)Commands.InterpretAsCommand:
                        // interpret as command
                        int inputVerb = this.stream.ReadByte();
                        if (inputVerb == -1)
                        {
                            break;
                        }

                        switch (inputVerb)
                        {
                            case (int)Commands.InterpretAsCommand:
                                // literal IAC = 255 escaped, so append char 255 to string
                                sb.Append(inputVerb);
                                break;
                            case (int)Commands.Do:
                            case (int)Commands.Dont:
                            case (int)Commands.Will:
                            case (int)Commands.Wont:
                                this.ReplyToCommand(inputVerb);
                                break;
                            default:
                                break;
                        }

                        break;
                    default:
                        sb.Append((char)input);
                        break;
                }

                return true;
            }

            return false;
        }

        private void ReplyToCommand(int inputVerb)
        {
            // reply to all commands with "WONT", unless it is SGA (suppress go ahead)
            int inputOption = this.stream.ReadByte();
            if (inputOption != -1)
            {
                this.stream.WriteByte((byte)Commands.InterpretAsCommand);
                if (inputOption == (int)Options.SuppressGoAhead)
                {
                    this.stream.WriteByte(inputVerb == (int)Commands.Do ? (byte)Commands.Will : (byte)Commands.Do);
                }
                else
                {
                    this.stream.WriteByte(inputVerb == (int)Commands.Do ? (byte)Commands.Wont : (byte)Commands.Dont);
                }

                this.stream.WriteByte((byte)inputOption);
            }
        }

        private bool IsResponseAnticipated(bool isInitialResponseReceived, DateTime endInitialTimeout, DateTime rollingTimeout)
        {
            return this.IsResponsePending || IsWaitForInitialResponse(endInitialTimeout, isInitialResponseReceived) ||
           IsWaitForIncrementalResponse(rollingTimeout);
        }

    }
}
