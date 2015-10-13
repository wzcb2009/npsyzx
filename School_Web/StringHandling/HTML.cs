using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Web;
namespace StringHandling
{
    public class HTML
    {
        [DebuggerNonUserCode]
        public HTML()
        {
        }
        public static string ToHtml(string mystr)
        {
            bool flag = Operators.CompareString(mystr, "", false) == 0;
            string result;
            if (flag)
            {
                result = "&nbsp;";
            }
            else
            {
                mystr = mystr.Replace("  ", "&nbsp;&nbsp;&nbsp;&nbsp;");
                mystr = mystr.Replace("\n\r", "<br>");
                mystr = mystr.Replace("\n", "<br>");
                mystr = mystr.Replace("\t", "\u3000\u3000");
                result = mystr;
            }
            return result;
        }
        public static string ReplaceSpecficChar(string StrSource)
        {
            StrSource = Strings.Replace(StrSource, "<", "&lt;", 1, -1, CompareMethod.Binary);
            StrSource = Strings.Replace(StrSource, ">", "&gt;", 1, -1, CompareMethod.Binary);
            StrSource = Strings.Replace(StrSource, "'", "&apos;", 1, -1, CompareMethod.Binary);
            StrSource = Strings.Replace(StrSource, "\"", "&\"", 1, -1, CompareMethod.Binary);
            StrSource = Strings.Replace(StrSource, "&", "&&", 1, -1, CompareMethod.Binary);
            return StrSource;
        }
        public static string NoHTML(string Htmlstring)
        {
            Htmlstring = Regex.Replace(Htmlstring, "<script[^>]*?>.*?</script>", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "<(.[^>]*)>", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "([\\r\\n])[\\s]+", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "-->", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "<!--.*", "", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "&(quot|#34);", "\"", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "&(amp|#38);", "&", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "&(lt|#60);", "<", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "&(gt|#62);", ">", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "&(nbsp|#160);", "   ", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "&(iexcl|#161);", "¡", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "&(cent|#162);", "¢", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "&(pound|#163);", "£", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "&(copy|#169);", "©", RegexOptions.IgnoreCase);
            Htmlstring = Regex.Replace(Htmlstring, "&#(\\d+);", "", RegexOptions.IgnoreCase);
            Htmlstring.Replace("<", "");
            Htmlstring.Replace(">", "");
            Htmlstring.Replace("\r\n", "");
            Htmlstring = HttpContext.Current.Server.HtmlEncode(Htmlstring).Trim();
            return Htmlstring;
        }
        public static string getImagePath(string str)
        {
            string img = HTML.GetImg(str);
            return HTML.getsrc(img);
        }
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
        private static string GetImg(string str)
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
        public string GetImgSrc(string str)
        {
            string result = "";
            Regex regex = new Regex("('|\"| )?(.[^'| |\"]*)(\\.)(jpg|gif|png|bmp|jpeg)('|\"| |>)?", RegexOptions.IgnoreCase);
            MatchCollection matchCollection = regex.Matches(HTML.GetImg(str));
            bool flag = matchCollection.Count > 0;
            if (flag)
            {
                result = matchCollection[0].Value;
            }
            return result;
        }
        public string GettopImgSrc(string str)
        {
            string result = "";
            Regex regex = new Regex("^<img\\s+[^>]*[^src]*\\s*src\\s*=\\s*(?<url>\\S+)[^>]*>", RegexOptions.IgnoreCase);
            MatchCollection matchCollection = regex.Matches(HTML.GetImg(str));
            bool flag = matchCollection.Count > 0;
            if (flag)
            {
                result = matchCollection[0].Value;
            }
            return result;
        }
    }
}
