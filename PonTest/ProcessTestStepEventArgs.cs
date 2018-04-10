using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PonTest
{
    public class ProcessTestStepEventArgs : EventArgs
    {
        public TestStepEvents TestStepEventId { get; set; }
        public long ElapsedTime { get; set; }
        public bool TestResult { get; set; }
        public string Reason { get; set; }
        public string TrueValue { get; set; }
    }

    public enum TestStepEvents
    {
        EVENT_RX_DMM_ADJUST = 0,
        EVENT_RX_CONTROL_OPTICAL_POWER_1 = 1,
        EVENT_RX_CONTROL_OPTICAL_POWER_2 = 2,
        EVENT_RX_CONTROL_OPTICAL_POWER_3 = 3,
        EVENT_ENABLE_ALARM = 4,
        EVENT_DISABLE_ALARM = 5,
        EVENT_ALARM_LAG = 6,
        EVENT_TX_OPTICAL_POWER = 7,
        EVENT_SENSITIVITY = 8,
        EVENT_TX_DMM_TX_POWER_ADJUST = 9,
        EVENT_DMM_TX_POWER = 10,
        EVENT_DMM_VCC = 11,
        EVENT_DMM_TEMPERATURE = 12,
        EVENT_DMM_BIAS = 13,
    }
}
