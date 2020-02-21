using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.Win32;

namespace Source
{
    public class UpdateSystemTime
    {
        private static Timer _sysTimer;
        public struct SystemTime
        {
            public static Int32 Year;
            public static Int32 Month;
            public static Int32 Day;
            public static Int32 Hour;
            public static Int32 Minute;
            public static Int32 Second;
        } 
        private static SystemTime _systemTime = new SystemTime();

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime([In] ref SystemTime _systemTime);



        public static void StartUpdateSystemTime()
        {
            OputputNewSystemTimeInFirstStartFunction(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            _sysTimer = new Timer()
            { 
                Interval = 6000,
                AutoReset = true,
                Enabled = true,
            };
            _sysTimer.Elapsed += (s, e) =>
                OutputNewSystemTime(SystemTime.Year, SystemTime.Month, SystemTime.Day, SystemTime.Hour, SystemTime.Minute, SystemTime.Second);
        }



        private Int32 HourNotNull(Int32 hour)
        {
            if (hour <= 6)
            {
                hour = 17 + hour;
            }
            else if (hour == 0)
            {
                hour = 17;
            }
            else
            {
                hour = hour - 7;
            }
            return hour;
        }

        private static void OputputNewSystemTimeInFirstStartFunction(Int32 year, Int32 month, Int32 day, Int32 hour, Int32 minute, Int32 second)
        {
            SystemTime.Year = year;
            SystemTime.Month = month;
            SystemTime.Day = day;
            SystemTime.Hour = hour;
            SystemTime.Minute = minute;
            SystemTime.Second = second;
            SetSystemTime(ref _systemTime);
        }

        public static void OutputNewSystemTime(Int32 year, Int32 month, Int32 day, Int32 hour, Int32 minute, Int32 second)
        {
            DateTime dt = new DateTime(year, month, day, hour, minute, second);

            dt = dt.AddSeconds(1);

            SystemTime.Year = dt.Year;
            SystemTime.Month = dt.Month;
            SystemTime.Day = dt.Day;
            SystemTime.Hour = dt.Hour;
            SystemTime.Minute = dt.Minute;
            SystemTime.Second = dt.Second;
            SetSystemTime(ref _systemTime);

        }

    }
}
