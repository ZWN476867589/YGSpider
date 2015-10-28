using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace YGSpider.Business.UtilTools
{
    public static class LoggerHelper
    {
        public static string loggerName = Environment.CurrentDirectory + "/log" + DateTime.Now.ToShortDateString() + ".log";
        public static bool WriteLog(string info)
        {
            try
            {
                if (!File.Exists(loggerName))
                {
                    File.CreateText(loggerName).Close();
                }
                File.AppendAllText("Time:"+DateTime.Now.ToString()+" "+loggerName, info);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool WriteLog(string info, Exception ex, DateTime time)
        {
            try
            {
                if (!File.Exists(loggerName))
                {
                    File.CreateText(loggerName).Close();
                }
                string logInfo = "time:" + time.ToString()+"info:" + info + ";Exception:" + ex.Message ;
                File.AppendAllText(logInfo, info);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }
    }
}
