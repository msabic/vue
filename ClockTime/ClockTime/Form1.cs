using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime(ref SYSTEMTIME st);
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Parse(DateTime.Now.ToString("hh:mm:ss.fff tt", System.Globalization.DateTimeFormatInfo.InvariantInfo));
            SYSTEMTIME st = new SYSTEMTIME();
            st.wYear = (short)time.Year; // must be short
            st.wMonth = (short)time.Month;
            st.wDay = (short)time.Day;
            st.wHour = (short)(time.Hour+1);
            st.wMinute = (short)time.Minute;
            st.wSecond = (short)time.Second;
            st.wMilliseconds = (short)time.Millisecond;

            SetSystemTime(ref st);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
