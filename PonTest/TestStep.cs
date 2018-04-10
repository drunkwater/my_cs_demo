using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace PonTest
{
    class TestStep
    {
        //private TelnetClient telnetClient;
        private Stopwatch stopWatch;

        public TestStep()
        {
            stopWatch = new Stopwatch();
        }

        public event EventHandler<ProcessTestStepEventArgs> ProcessTestStepHandler;

        protected virtual void ProcessTestStepEvent(ProcessTestStepEventArgs e)
        {
            EventHandler<ProcessTestStepEventArgs> handler = ProcessTestStepHandler;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public bool ProcessTestStep()
        {
            stopWatch.Start();
            Thread.Sleep(1000);
            stopWatch.Stop();
            long time = stopWatch.ElapsedMilliseconds;

            Random rand = new Random();
            foreach (TestStepEvents eventId in Enum.GetValues(typeof(TestStepEvents)))
            {
                bool result = true;
                string trueValue = rand.Next(1024).ToString();
                ProcessTestStepEventArgs args = new ProcessTestStepEventArgs
                {
                    TestStepEventId = eventId,
                    ElapsedTime = stopWatch.ElapsedMilliseconds,
                    TestResult = result,
                    Reason = (result) ? "OK" : "Failure",
                    TrueValue = trueValue
                };

                ProcessTestStepEvent(args);
            }

            return true;
        }
    }
}
