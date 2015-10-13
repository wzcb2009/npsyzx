using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Globalization;
namespace Wzsckj.com.Common
{
    public class TimeParser
    {
        [DebuggerNonUserCode]
        public TimeParser()
        {
        }
        public static int SecondToMinute(int Second)
        {
            return Convert.ToInt32(Math.Ceiling(double.Parse(decimal.Divide(new decimal(Second), new decimal(60L)).ToString())));
        }
        public static int GetMonthLastDate(int year, int month)
        {
            DateTime dateTime = new DateTime(year, month, new GregorianCalendar().GetDaysInMonth(year, month));
            return dateTime.Day;
        }
        public static string DateDiff(DateTime DateTime1, DateTime DateTime2)
        {
            string result = null;
            try
            {
                TimeSpan timeSpan = DateTime2 - DateTime1;
                bool flag = timeSpan.Days >= 1;
                if (flag)
                {
                    result = DateTime1.Month.ToString() + "月" + DateTime1.Day.ToString() + "日";
                }
                else
                {
                    flag = (timeSpan.Hours > 1);
                    if (flag)
                    {
                        result = timeSpan.Hours.ToString() + "小时前";
                    }
                    else
                    {
                        result = timeSpan.Minutes.ToString() + "分钟前";
                    }
                }
            }
            catch (Exception arg_9E_0)
            {
                ProjectData.SetProjectError(arg_9E_0);
                ProjectData.ClearProjectError();
            }
            return result;
        }
        public static string GetWhenSendTime(DateTime BlogTime, DateTime NowTime)
        {
            DateTime d = BlogTime;
            bool flag = (NowTime - d).TotalMinutes > 1440.0;
            string result;
            if (flag)
            {
                result = d.ToString("yyyy年MM月dd日 HH:mm");
            }
            else
            {
                flag = ((NowTime - d).TotalMinutes > 60.0);
                if (flag)
                {
                    result = Math.Floor((NowTime - d).TotalMinutes / 60.0).ToString() + "小时" + (Math.Floor((NowTime - d).TotalMinutes) % 60.0).ToString() + "分钟前";
                }
                else
                {
                    flag = (Math.Floor((NowTime - d).TotalMinutes) % 60.0 <= 0.0);
                    if (flag)
                    {
                        result = "刚刚更新";
                    }
                    else
                    {
                        result = (Math.Floor((NowTime - d).TotalMinutes) % 60.0).ToString() + "分钟前";
                    }
                }
            }
            return result;
        }
    }
}
