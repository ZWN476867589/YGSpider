﻿using System;
using System.Text;
using System.Net;
using System.IO;

namespace YGSpider.Business.UtilTools
{
    public static class NetHelper
    {
        public static string GetByUrl(string Url)
        {
            string result = "";
            if (!String.IsNullOrWhiteSpace(Url))
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);
                    request.Method = "GET";
                    request.Host = "api.1yyg.com";
                    request.Referer = @"http://www.1yyg.com/lottery/i100.html";
                    request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                    request.KeepAlive = true;
                    request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/45.0.2454.101 Safari/537.36";
                    using (WebResponse wr = request.GetResponse())
                    {
                        Stream st = wr.GetResponseStream();
                        StreamReader sr = new StreamReader(st, Encoding.UTF8);
                        result = sr.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    LoggerHelper.WriteLog(Url, ex, DateTime.Now);
                }
            }
            return result;
        }
    }
}
