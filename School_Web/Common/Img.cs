using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Diagnostics;
using System.Text.RegularExpressions;
namespace Wzsckj.com.Common
{
    public class Img
    {
        [DebuggerNonUserCode]
        public Img()
        {
        }
        public static ArrayList getImgUrl(string html, string regstr, string keyname)
        {
            ArrayList arrayList = new ArrayList();
            Regex regex = new Regex(regstr, RegexOptions.IgnoreCase);
            MatchCollection matchCollection = regex.Matches(html);
            bool flag;
            IEnumerator enumerator = null;
            try
            {
                  enumerator = matchCollection.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Match match = (Match)enumerator.Current;
                    arrayList.Add(match.Groups[keyname].Value.ToLower());
                }
            }
            finally
            {
                
                flag = (enumerator is IDisposable);
                if (flag)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            flag = (arrayList.Count > 0);
            ArrayList result;
            if (flag)
            {
                result = arrayList;
            }
            else
            {
                arrayList.Add("");
                result = arrayList;
            }
            return result;
        }
        public object FirstImageSrc(string str)
        {
            return Img.getImgUrl(str, "^<IMG[^>]+src=\\s*(?:'(?<src>[^']+)'|\"(?<src>[^\"]+)\"|(?<src>[^>\\s]+))\\s*[^>]*>", "src")[0];
        }
        public string GetImg(string str)
        {
            string result = "";
            Regex regex = new Regex("(<)(.[^<]*)(src=)('|\"| )?(.[^'|\\s|\"]*)(\\.)(jpg|gif|png|bmp|jpeg)('|\"|\\s|>)(.[^>]*)(>)", RegexOptions.IgnoreCase);
            MatchCollection matchCollection = regex.Matches(str);
            bool flag = matchCollection.Count > 0;
            if (flag)
            {
                result = matchCollection[0].Value;
            }
            return result;
        }
        public string getsrc(string str)
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
        public string getimage(string str)
        {
            string img = this.GetImg(str);
            return this.getsrc(img);
        }
    }
}
