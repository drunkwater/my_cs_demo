using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Timers;

namespace PonTest
{
    public partial class PonTest : Form
    {
        private static string DoTestTimeStamp = String.Empty;
        public static void WriteLogs(string content)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (!string.IsNullOrEmpty(path))
            {
                path = AppDomain.CurrentDomain.BaseDirectory + "TestLog";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = path + "\\" + DateTime.Now.ToString("yyyyMMdd");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string customized = String.Format("{0}_{1}_{2}", DoTestTimeStamp, StrProductModel, StrSerialNumber);
                path = path + "\\" + customized + ".txt";
                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }
                if (File.Exists(path))
                {
                    StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default);
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "->" + content);
                    sw.Close();
                }
            }
        }

        public PonTest()
        {
            InitializeComponent();

            this.toolStripStatusCurrentDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            this.timerStatusCurrentDate.Start();

            LoadAppConfig();
            BindTestStepData();
        }

        private static UInt32 passCounter = 0;
        private static UInt32 failCounter = 0;
        private static long AllElapsedTime = 0;

        struct RowData
        {
            public string Temperature;
            public string Voltage;
            public string TestItem;
            public string Target;
            public string Max;
            public string Min;
            public string TrueValue;
            public string DA_AD_C;
            public string Result;
            public double Spend;
            public string Comments;
            public RowData(string temperature, string voltage, string testItem, string target, string max, string min, string trueValue,
                            string da_ad_c, string result, double spend, string comments)
            {
                this.Temperature = temperature;
                this.Voltage = voltage;
                this.TestItem = testItem;
                this.Target = target;
                this.Max = max;
                this.Min = min;
                this.TrueValue = trueValue;
                this.DA_AD_C = da_ad_c;
                this.Result = result;
                this.Spend = spend;
                this.Comments = comments;
            }
        };

        private List<RowData> testDataRowsList = new List<RowData>(32);
        private void BindTestStepData()
        {
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_RX_DMM_ADJUST, new RowData("25", "3.3", "接收DMM校准", "-28.00", "-28.00", "-28.00", "-28.00", "", "OK", 0.0, "接收DMM校准完成") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_RX_CONTROL_OPTICAL_POWER_1, new RowData("25", "3.3", "接收监控光功率1", "-12.00", "-11.00", "-13.00", "-12.06", "", "OK", 0.0, "接收监控光功率1") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_RX_CONTROL_OPTICAL_POWER_2, new RowData("25", "3.3", "接收监控光功率2", "-22.00", "-21.00", "-24.00", "-22.37", "", "OK", 0.0, "接收监控光功率2") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_RX_CONTROL_OPTICAL_POWER_3, new RowData("25", "3.3", "接收监控光功率3", "-28.00 ", "-26.00", "-31.00", "-28.28", "", "OK", 0.0, "接收监控光功率3") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_ENABLE_ALARM, new RowData("25", "3.3", "告警", "-36.00", "", "-36.00", "-36.00", "", "OK", 0.0, "OK") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_DISABLE_ALARM, new RowData("25", "3.3", "去告警", "-29.00", "-29.00", "", "-29.00", "", "OK", 0.0, "OK") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_ALARM_LAG, new RowData("25", "3.3", "告警迟滞", "", "10.00", "0.00", "7.00", "", "OK", 0.0, "OK") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_TX_OPTICAL_POWER, new RowData("25", "3.3", "发射光功率 ", "1.50 ", "3.00 ", "1.20", "1.36", "", "OK", 0.0, "OK") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_SENSITIVITY, new RowData("25", "3.3", "灵敏度", "-28.00", "-28.00", "", "-28.00", "", "OK", 0.0, "OK") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_TX_DMM_TX_POWER_ADJUST, new RowData("25", "3.3", "DMM之TX Power校准", "-28.00", "-28.00", "", "-28.00", "", "OK", 0.0, "DMM之TX Power校准完成") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_DMM_TX_POWER, new RowData("25", "3.3", "DMM之TX Power", "-28.00", "-28.00", "", "1.44", "", "OK", 0.0, "正常") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_DMM_VCC, new RowData("25", "3.3", "DMM之VCC", "3.30", "3.50", "3.10", "3.34", "", "OK", 0.0, "正常") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_DMM_TEMPERATURE, new RowData("25", "3.3", "DMM之温度", " 40.00", "60.00", "10.00", "28.68", "", "OK", 0.0, "正常") );
            testDataRowsList.Insert( (int)TestStepEvents.EVENT_DMM_BIAS, new RowData("25", "3.3", "DMM之Bias", "15.00", "30.00", "2.00", "16.56", "", "OK", 0.0, "正常") );
        }

        static string StrWorkSheetNumber = "WS-2018-01-240001";
        static string StrProductModel = "BOSA-GPON-0001";
        static string StrBatchNumber = "2018-01-24-4321";
        static string StrTestcontroler = "test123456";
        static string StrSerialNumber = String.Empty;
        private void LoadAppConfig()
        {
            this.richTextBoxWorkSheetNumber.Text = StrWorkSheetNumber;
            this.richTextBoxProductModel.Text = StrProductModel;
            this.richTextBoxBatchNumber.Text = StrBatchNumber;
            this.richTextBoxTestcontroler.Text = StrTestcontroler;
            this.richTextBoxSerialNumber.Text = StrSerialNumber;
            this.richTextBoxWorkSheetNumber.Text = StrWorkSheetNumber;

            this.checkBoxC25.Checked = true;
            this.checkBoxV3p3.Checked = true;

            SetToolStripStatusCurrentText("加载配置成功");
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox _textbox = (RichTextBox)sender;
            Int32 length = _textbox.Text.Length;
            Console.WriteLine(_textbox.Text);
            switch (_textbox.Name)
            {
                case "richTextBoxWorkSheetNumber":
                    Console.WriteLine(this.richTextBoxWorkSheetNumber.Text);
                    break;
                case "richTextBoxProductModel":
                    Console.WriteLine(this.richTextBoxProductModel.Text);
                    break;
                case "richTextBoxBatchNumber":
                    Console.WriteLine(this.richTextBoxBatchNumber.Text);
                    break;
                case "richTextBoxTestcontroler":
                    Console.WriteLine(this.richTextBoxTestcontroler.Text);
                    break;
                case "richTextBoxSerialNumber":
                    if (8 != length)
                    {
                        break;
                    }
                    Console.WriteLine(this.richTextBoxSerialNumber.Text);
                    ClearDataGridViewTestResult();
                    StrSerialNumber = this.richTextBoxSerialNumber.Text;
                    DoTestTimeStamp = DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss");
                    if (true)
                    {
                        TestStep test = new TestStep();
                        test.ProcessTestStepHandler += new EventHandler<ProcessTestStepEventArgs>(ProcessTestStep);
                        test.ProcessTestStep();
                        SetToolStripStatusCurrentText("测试进行中");
                    }
                    else
                    {
                        //SetToolStripStatusCurrentText("尝试连接设备失败，请检查配置和网线！");
                    }
                    break;
                default:
                    Console.WriteLine("richTextBox Error name!");
                    break;
            }
        }

        private void SetToolStripStatusCurrentText(string show)
        {
            this.toolStripStatusCurrentText.Text = show;
        }

        private void TimerStatusCurrentDate_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusCurrentDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void ToolStripMenuItemAutoTest_Click(object sender, EventArgs e)
        {
            SetToolStripStatusCurrentText(this.toolStripMenuItemAutoTest.Text);
            Console.WriteLine("auto test");
        }

        private static bool toggle = false;
        private void ToolStripMenuItemPauseTest_Click(object sender, EventArgs e)
        {
            SetToolStripStatusCurrentText(this.toolStripMenuItemPauseTest.Text);
            toggle = !toggle;
            this.toolStripMenuItemPauseTest.Text = toggle ? "继续调测" : "暂停调测";
            if (toggle)
            {
                Console.WriteLine("pause");
            }
            else
            {
                Console.WriteLine("continue");
            }
        }

        private void ToolStripMenuItemPmodelSelect_Click(object sender, EventArgs e)
        {
            SetToolStripStatusCurrentText(this.toolStripMenuItemPmodelSelect.Text);
            Console.WriteLine("model");
        }

        private void ToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            AboutBoxPonTest about = new AboutBoxPonTest();
            about.ShowDialog();
        }

        private void ToolStripMenuItemExitPonTest_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            System.Environment.Exit(0);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if (this.tabPageTestResult == current)
            {
                Console.WriteLine("TabPage=" + current.Name);
            }
            else if (this.tabPageTestItemSelect == current)
            {
                Console.WriteLine("TabPage=" + current.Name);
            }
            else
            {
                Console.WriteLine("Invalid TabPage name: " + current.Name);
            }
        }

        private void ClearDataGridViewTestResult()
        {
            if (this.dataGridViewTestResult.DataSource != null)
            {
                DataTable dt = (DataTable)this.dataGridViewTestResult.DataSource;
                dt.Rows.Clear();
                this.dataGridViewTestResult.DataSource = dt;
            }
            else
            {
                this.dataGridViewTestResult.Rows.Clear();
            }
        }

        private void CheckBoxC25_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox _checkBox = (CheckBox)sender;
            //Console.WriteLine(_checkBox.Name + "," + _checkBox.Checked);
        }

        private void CheckBoxV3p3_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox _checkBox = (CheckBox)sender;
            //Console.WriteLine(_checkBox.Name + "," + _checkBox.Checked);
        }

        private void ProcessTestStepClean(bool last)
        {
            if (last)
            {
                passCounter++;
                this.labelPass.Text = "PASS";
                this.labelPass.ForeColor = Color.Green;
            }
            else
            {
                this.labelPass.Text = "FAIL";
                this.labelPass.ForeColor = Color.Red;
                failCounter++;
            }

            string count = String.Format("成功{0},失败{1}", passCounter, failCounter);
            string conclusion = String.Format("所有测试项目已完成，耗时{0}秒", AllElapsedTime);
            labelTestCounter.Text = count;
            SetToolStripStatusCurrentText(conclusion);
            WriteLogs(string.Format("{0}:{1}", count, conclusion));
            AllElapsedTime = 0;
        }

        private void ProcessTestStep(object sender, ProcessTestStepEventArgs e)
        {
            TestStepEvents testStepEventId = e.TestStepEventId;
            RowData list = testDataRowsList[ (int)testStepEventId ];
            list.TrueValue = e.TrueValue;
            list.Spend = e.ElapsedTime / 1000;
            if (!e.TestResult)
            {
                list.Result = "FAIL";
                list.Comments = e.Reason;
            }

            object[] row = {
                list.Temperature,
                list.Voltage,
                list.TestItem,
                list.Target,
                list.Max,
                list.Min,
                list.TrueValue,
                list.DA_AD_C,
                list.Result,
                list.Spend,
                list.Comments};
            dataGridViewTestResult.Rows.Add(row);

            WriteLogs(string.Format("{0}:{1}", System.Reflection.MethodBase.GetCurrentMethod().Name, testStepEventId));
            AllElapsedTime += e.ElapsedTime;

            if ( e.TestResult )
            {
                if (TestStepEvents.EVENT_DMM_BIAS == testStepEventId)
                {
                    ProcessTestStepClean(true);
                }
            }
            else
            {
                ProcessTestStepClean(false);
            }
        }
    }
}
