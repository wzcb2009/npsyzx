using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
namespace Wzsckj.com.Common
{
    public class caiji
    {
        private static string getsrc(string str)
        {
            int num = Strings.InStr(str, "src=\"", CompareMethod.Binary);
            bool flag = num > 0;
            checked
            {
                string result;
                if (flag)
                {
                    str = Strings.Right(str, Strings.Len(str) - num - 4);
                    num = Strings.InStr(str, "\"", CompareMethod.Binary);
                    result = Strings.Left(str, num - 1);
                }
                else
                {
                    result = "";
                }
                return result;
            }
        }
        public static string caijiByUrl(string str, string url, string chargest, string path)
        {
            ArrayList arrayList = new ArrayList();
            Uri uri = new Uri(url);
            string text = uri.Scheme + "://" + uri.Host + "/";
            Regex regex = new Regex("(<)(.[^<]*)(src=)('|\"| )?(.[^'|\\s|\"]*)('|\"|\\s|>)(.[^>]*)(>)", RegexOptions.IgnoreCase);
            MatchCollection matchCollection = regex.Matches(str);
            IEnumerator enumerator = null;
            try
            {
                  enumerator = matchCollection.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Match match = (Match)enumerator.Current;
                    string text2 = match.Groups[0].Value.ToLower();
                    text2 = caiji.getsrc(text2);
                    bool flag = arrayList.IndexOf(text2) == -1;
                    if (flag)
                    {
                        arrayList.Add(text2);
                    }
                }
            }
            finally
            {
                
                bool flag = enumerator is IDisposable;
                if (flag)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            string str2 = string.Empty;
            WebClient webClient = new WebClient();
            int arg_EC_0 = 0;
            checked
            {
                int num = arrayList.Count - 1;
                int num2 = arg_EC_0;
                while (true)
                {
                    int arg_1A8_0 = num2;
                    int num3 = num;
                    if (arg_1A8_0 > num3)
                    {
                        break;
                    }
                    string str3 = arrayList[num2].ToString().Replace("http://", "").Replace("/", "_") + ".jpg";
                    string replacement = path + str3;
                    try
                    {
                        string @string = arrayList[num2].ToString();
                        bool flag = Strings.InStr(@string, "sinaimg.cn", CompareMethod.Binary) > 0;
                        if (flag)
                        {
                            str = Regex.Replace(str, arrayList[num2].ToString(), replacement, RegexOptions.IgnoreCase);
                        }
                    }
                    catch (Exception expr_178)
                    {
                        ProjectData.SetProjectError(expr_178);
                        Exception ex = expr_178;
                        str2 += ex.Message;
                        ProjectData.ClearProjectError();
                    }
                    num2++;
                }
                return str;
            }
        }
        public static string GetSourceTextByUrl(string url, string chargest)
        {
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Timeout = 20000;
            WebResponse response = webRequest.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(responseStream, Encoding.GetEncoding(chargest));
            return streamReader.ReadToEnd();
        }
    }
}
