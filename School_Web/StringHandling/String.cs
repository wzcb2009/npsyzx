using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
namespace StringHandling
{
    public class String
    {
        [DebuggerNonUserCode]
        public String()
        {
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
        public static string DateBetweenStr(DateTime sd, DateTime ed)
        {
            bool flag = DateTime.Compare(sd, DateTime.MinValue) != 0 & DateTime.Compare(ed, DateTime.MinValue) != 0;
            string result = "";
            if (flag)
            {
                result = string.Concat(new string[]
				{
					"   ( datediff(day,pubdate,'",
					Conversions.ToString(sd),
					"')<=0 and  datediff(day,pubdate,'",
					Conversions.ToString(ed),
					"')>=0) "
				});
            }
            else
            {
                flag = (DateTime.Compare(sd, DateTime.MinValue) != 0);
                if (flag)
                {
                    result = string.Concat(new string[]
					{
						"    ( datediff(day,pubdate,'",
						Conversions.ToString(sd),
						"')<=0 and  datediff(day,pubdate,'",
						Conversions.ToString(DateAndTime.Now),
						"')>=0) "
					});
                }
                else
                {
                    flag = (DateTime.Compare(ed, DateTime.MinValue) != 0);
                    if (flag)
                    {
                        result = "    (    datediff(day,pubdate,'" + Conversions.ToString(ed) + "')>=0) ";
                    }
                }
            }
            return result;
        }
        public static string DateBetweenStr(string sd, string ed)
        {
            bool flag = Operators.CompareString(sd, "", false) != 0 & Operators.CompareString(ed, "", false) != 0;
            string result = "";
            if (flag)
            {
                result = string.Concat(new string[]
				{
					"   ( datediff(day,pubdate,'",
					sd,
					"')<=0 and  datediff(day,pubdate,'",
					ed,
					"')>=0) "
				});
            }
            else
            {
                flag = (Operators.CompareString(sd, "", false) != 0);
                if (flag)
                {
                    result = string.Concat(new string[]
					{
						"    ( datediff(day,pubdate,'",
						sd,
						"')<=0 and  datediff(day,pubdate,'",
						Conversions.ToString(DateAndTime.Now),
						"')>=0) "
					});
                }
                else
                {
                    flag = (Operators.CompareString(ed, "", false) != 0);
                    if (flag)
                    {
                        result = "    (    datediff(day,pubdate,'" + ed + "')>=0) ";
                    }
                }
            }
            return result;
        }
        public static string TwoDateBetweenStr(string sd, string ed)
        {
            bool flag = Operators.CompareString(sd, "", false) != 0 & Operators.CompareString(ed, "", false) != 0;
            string result = "";
            if (flag)
            {
                result = string.Concat(new string[]
				{
					"   ( datediff(day,startdate,'",
					sd,
					"')<=0 and  datediff(day,enddate,'",
					ed,
					"')>=0) "
				});
            }
            else
            {
                flag = (Operators.CompareString(sd, "", false) != 0);
                if (flag)
                {
                    result = "    ( datediff(day,startdate,'" + sd + "')<=0  ) ";
                }
                else
                {
                    flag = (Operators.CompareString(ed, "", false) != 0);
                    if (flag)
                    {
                        result = "    (    datediff(day,enddate,'" + ed + "')>=0) ";
                    }
                }
            }
            return result;
        }
        public static string EndDateBetweenStr(string sd, string ed)
        {
            bool flag = Operators.CompareString(sd, "", false) != 0 & Operators.CompareString(ed, "", false) != 0;
            string result="";
            if (flag)
            {
                result = string.Concat(new string[]
				{
					"   ( datediff(day,enddate,'",
					sd,
					"')<=0 and  datediff(day,enddate,'",
					ed,
					"')>=0) "
				});
            }
            else
            {
                flag = (Operators.CompareString(sd, "", false) != 0);
                if (flag)
                {
                    result = "    datediff(day,enddate,'" + sd + "')<=0   ";
                }
                else
                {
                    flag = (Operators.CompareString(ed, "", false) != 0);
                    if (flag)
                    {
                        result = "       datediff(day,enddate,'" + ed + "')>=0  ";
                    }
                }
            }
            return result;
        }
        public static string GetString(string queryString)
        {
            string result = "";
            bool flag = !string.IsNullOrEmpty(queryString);
            if (flag)
            {
                result = queryString.ToString();
            }
            return result;
        }
        public static string SqlInsertEncode(string strFromText)
        {
            bool flag = !string.IsNullOrEmpty(strFromText) && Operators.CompareString(strFromText, "", false) != 0;
            if (flag)
            {
                strFromText = strFromText.Replace("!", "&#33;");
                strFromText = strFromText.Replace("$", "&#36;");
                strFromText = strFromText.Replace("*", "&#42;");
                strFromText = strFromText.Replace("(", "&#40;");
                strFromText = strFromText.Replace(")", "&#41;");
                strFromText = strFromText.Replace("-", "&#45;");
                strFromText = strFromText.Replace("+", "&#43;");
                strFromText = strFromText.Replace("|", "&#124;");
                strFromText = strFromText.Replace("\\", "&#92;");
                strFromText = strFromText.Replace("\"", "&#34;");
                strFromText = strFromText.Replace("'", "&#39;");
                strFromText = strFromText.Replace("<", "&#60;");
                strFromText = strFromText.Replace(" ", "&#32;");
                strFromText = strFromText.Replace(">", "&#62;");
                strFromText = strFromText.Replace(" ", "&#32;");
            }
            return strFromText;
        }
        public static bool SqlKeyWord(string strFromText)
        {
            bool flag = !string.IsNullOrEmpty(strFromText) && Operators.CompareString(strFromText, "", false) != 0;
            checked
            {
                bool result=false ;
                if (flag)
                {
                    string[] array = new string[]
					{
						";",
						"!",
						"@",
						"$",
						"*",
						"(",
						")",
						"-",
						"+",
						"=",
						"|",
						"\\",
						"/",
						":",
						"'",
						"<",
						">",
						"'"
					};
                    StringBuilder stringBuilder = new StringBuilder();
                    string[] array2 = array;
                    for (int i = 0; i < array2.Length; i++)
                    {
                        string value = array2[i];
                        flag = strFromText.Contains(value);
                        if (flag)
                        {
                            result = true;
                            break;
                        }
                    }
                }
                return result;
            }
        }
        public static string HtmlShowEncode(string strContent)
        {
            bool flag = !string.IsNullOrEmpty(strContent) && Operators.CompareString(strContent, "", false) != 0;
            if (flag)
            {
                strContent = strContent.Replace(" ", "&nbsp;");
                strContent = strContent.Replace("&#32;", "&nbsp;");
                strContent = strContent.Replace("\t", "&nbsp;&nbsp;");
                strContent = strContent.Replace("\r\n", "<br />");
            }
            return strContent;
        }
        public static string RandCode(int n)
        {
            char[] array = new char[]
			{
				'a',
				'b',
				'd',
				'c',
				'e',
				'f',
				'g',
				'h',
				'i',
				'j',
				'k',
				'l',
				'm',
				'n',
				'p',
				'r',
				'q',
				's',
				't',
				'u',
				'v',
				'w',
				'z',
				'y',
				'x',
				'0',
				'1',
				'2',
				'3',
				'4',
				'5',
				'6',
				'7',
				'8',
				'9',
				'A',
				'B',
				'C',
				'D',
				'E',
				'F',
				'G',
				'H',
				'I',
				'J',
				'K',
				'L',
				'M',
				'N',
				'Q',
				'P',
				'R',
				'T',
				'S',
				'V',
				'U',
				'W',
				'X',
				'Y',
				'Z'
			};
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random(DateTime.Now.Millisecond);
            int arg_1C8_0 = 0;
            checked
            {
                int num = n - 1;
                int num2 = arg_1C8_0;
                while (true)
                {
                    int arg_1F7_0 = num2;
                    int num3 = num;
                    if (arg_1F7_0 > num3)
                    {
                        break;
                    }
                    stringBuilder.Append(array[random.Next(0, array.Length)].ToString());
                    num2++;
                }
                return stringBuilder.ToString();
            }
        }
        public static string SqlQueryEncode(string strKeyWords)
        {
            bool flag = !string.IsNullOrEmpty(strKeyWords) && Operators.CompareString(strKeyWords, "", false) != 0;
            if (flag)
            {
                strKeyWords = strKeyWords.Replace("'", "");
                strKeyWords = strKeyWords.Replace("[", "[[]");
                strKeyWords = strKeyWords.Replace("_", "[_]");
                strKeyWords = strKeyWords.Replace("&", "[&]");
                strKeyWords = strKeyWords.Replace("#", "[#]");
                strKeyWords = strKeyWords.Replace("%", "[%]");
            }
            return strKeyWords;
        }
        public static string SqlQueryDecode(string strKeyWords)
        {
            bool flag = !string.IsNullOrEmpty(strKeyWords) && Operators.CompareString(strKeyWords, "", false) != 0;
            if (flag)
            {
                strKeyWords = strKeyWords.Replace("[[]", "[");
                strKeyWords = strKeyWords.Replace("[_]", "_");
                strKeyWords = strKeyWords.Replace("[&]", "&");
                strKeyWords = strKeyWords.Replace("[#]", "#");
                strKeyWords = strKeyWords.Replace("[%]", "%");
            }
            return strKeyWords;
        }
        public static string InitChineseUrl(string chineseUrl)
        {
            Uri uri = new Uri(chineseUrl);
            NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(uri.Query, Encoding.GetEncoding("utf-8"));
            string text = "";
            int arg_31_0 = 0;
            checked
            {
                int num = nameValueCollection.Count - 1;
                int num2 = arg_31_0;
                while (true)
                {
                    int arg_F1_0 = num2;
                    int num3 = num;
                    if (arg_F1_0 > num3)
                    {
                        break;
                    }
                    bool flag = Operators.CompareString(text.Trim(), string.Empty, false) == 0;
                    if (flag)
                    {
                        text = "?" + nameValueCollection.Keys[num2] + "=" + HttpUtility.UrlEncode(nameValueCollection[num2], Encoding.GetEncoding("GB2312"));
                    }
                    else
                    {
                        text = string.Concat(new string[]
						{
							text,
							"&",
							nameValueCollection.Keys[num2],
							"=",
							HttpUtility.UrlEncode(nameValueCollection[num2], Encoding.GetEncoding("GB2312"))
						});
                    }
                    num2++;
                }
                return chineseUrl.Split(new char[]
				{
					'?'
				})[0] + text;
            }
        }
        public static string ToHexString(string s)
        {
            char[] array = s.ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            int arg_16_0 = 0;
            checked
            {
                int num = array.Length - 1;
                int num2 = arg_16_0;
                while (true)
                {
                    int arg_58_0 = num2;
                    int num3 = num;
                    if (arg_58_0 > num3)
                    {
                        break;
                    }
                    bool flag = String.NeedToEncode(array[num2]);
                    bool flag2 = flag;
                    if (flag2)
                    {
                        string value = String.ToHexString(array[num2]);
                        stringBuilder.Append(value);
                    }
                    else
                    {
                        stringBuilder.Append(array[num2]);
                    }
                    num2++;
                }
                return stringBuilder.ToString();
            }
        }
        public static bool NeedToEncode(char chrs)
        {
            string text = "$-_.+!*'(),@=&";
            bool flag = chrs > '\u007f';
            bool result;
            if (flag)
            {
                result = true;
            }
            else
            {
                flag = (char.IsLetterOrDigit(chrs) || text.IndexOf(chrs) >= 0);
                result = !flag;
            }
            return result;
        }
        public static string ToHexString(char chr)
        {
            UTF8Encoding uTF8Encoding = new UTF8Encoding();
            byte[] bytes = uTF8Encoding.GetBytes(chr.ToString());
            StringBuilder stringBuilder = new StringBuilder();
            int arg_23_0 = 0;
            checked
            {
                int num = bytes.Length - 1;
                int num2 = arg_23_0;
                while (true)
                {
                    int arg_4D_0 = num2;
                    int num3 = num;
                    if (arg_4D_0 > num3)
                    {
                        break;
                    }
                    stringBuilder.AppendFormat("%{0}", Convert.ToString(bytes[num2], 16));
                    num2++;
                }
                return stringBuilder.ToString();
            }
        }
        public static string GetMimeType(string extension)
        {
            string result = string.Empty;
            extension = extension.ToLower();
            string left = extension;
            bool flag = Operators.CompareString(left, ".avi", false) == 0;
            if (flag)
            {
                result = "video/x-msvideo";
            }
            else
            {
                bool arg_8F_0;
                if (Operators.CompareString(left, ".bin", false) != 0 && Operators.CompareString(left, ".exe", false) != 0)
                {
                    if (Operators.CompareString(left, ".msi", false) != 0)
                    {
                        if (Operators.CompareString(left, ".dll", false) != 0)
                        {
                            if (Operators.CompareString(left, ".class", false) != 0)
                            {
                                arg_8F_0 = false;
                                goto IL_8E;
                            }
                        }
                    }
                }
                arg_8F_0 = true;
            IL_8E:
                flag = arg_8F_0;
                if (flag)
                {
                    result = "application/octet-stream";
                }
                else
                {
                    flag = (Operators.CompareString(left, ".csv", false) == 0);
                    if (flag)
                    {
                        result = "text/comma-separated-values";
                    }
                    else
                    {
                        bool arg_FF_0;
                        if (Operators.CompareString(left, ".html", false) != 0 && Operators.CompareString(left, ".htm", false) != 0)
                        {
                            if (Operators.CompareString(left, ".shtml", false) != 0)
                            {
                                arg_FF_0 = false;
                                goto IL_FE;
                            }
                        }
                        arg_FF_0 = true;
                    IL_FE:
                        flag = arg_FF_0;
                        if (flag)
                        {
                            result = "text/html";
                        }
                        else
                        {
                            flag = (Operators.CompareString(left, ".css", false) == 0);
                            if (flag)
                            {
                                result = "text/css";
                            }
                            else
                            {
                                flag = (Operators.CompareString(left, ".js", false) == 0);
                                if (flag)
                                {
                                    result = "text/javascript";
                                }
                                else
                                {
                                    bool arg_195_0;
                                    if (Operators.CompareString(left, ".doc", false) != 0 && Operators.CompareString(left, ".dot", false) != 0)
                                    {
                                        if (Operators.CompareString(left, ".docx", false) != 0)
                                        {
                                            arg_195_0 = false;
                                            goto IL_194;
                                        }
                                    }
                                    arg_195_0 = true;
                                IL_194:
                                    flag = arg_195_0;
                                    if (flag)
                                    {
                                        result = "application/msword";
                                    }
                                    else
                                    {
                                        bool arg_1DF_0;
                                        if (Operators.CompareString(left, ".xla", false) != 0 && Operators.CompareString(left, ".xls", false) != 0)
                                        {
                                            if (Operators.CompareString(left, ".xlsx", false) != 0)
                                            {
                                                arg_1DF_0 = false;
                                                goto IL_1DE;
                                            }
                                        }
                                        arg_1DF_0 = true;
                                    IL_1DE:
                                        flag = arg_1DF_0;
                                        if (flag)
                                        {
                                            result = "application/msexcel";
                                        }
                                        else
                                        {
                                            flag = (Operators.CompareString(left, ".ppt", false) == 0 || Operators.CompareString(left, ".pptx", false) == 0);
                                            if (flag)
                                            {
                                                result = "application/mspowerpoint";
                                            }
                                            else
                                            {
                                                flag = (Operators.CompareString(left, ".gz", false) == 0);
                                                if (flag)
                                                {
                                                    result = "application/gzip";
                                                }
                                                else
                                                {
                                                    flag = (Operators.CompareString(left, ".gif", false) == 0);
                                                    if (flag)
                                                    {
                                                        result = "image/gif";
                                                    }
                                                    else
                                                    {
                                                        flag = (Operators.CompareString(left, ".bmp", false) == 0);
                                                        if (flag)
                                                        {
                                                            result = "image/bmp";
                                                        }
                                                        else
                                                        {
                                                            bool arg_2E5_0;
                                                            if (Operators.CompareString(left, ".jpeg", false) != 0 && Operators.CompareString(left, ".jpg", false) != 0)
                                                            {
                                                                if (Operators.CompareString(left, ".jpe", false) != 0)
                                                                {
                                                                    if (Operators.CompareString(left, ".png", false) != 0)
                                                                    {
                                                                        arg_2E5_0 = false;
                                                                        goto IL_2E4;
                                                                    }
                                                                }
                                                            }
                                                            arg_2E5_0 = true;
                                                        IL_2E4:
                                                            flag = arg_2E5_0;
                                                            if (flag)
                                                            {
                                                                result = "image/jpeg";
                                                            }
                                                            else
                                                            {
                                                                bool arg_340_0;
                                                                if (Operators.CompareString(left, ".mpeg", false) != 0 && Operators.CompareString(left, ".mpg", false) != 0)
                                                                {
                                                                    if (Operators.CompareString(left, ".mpe", false) != 0)
                                                                    {
                                                                        if (Operators.CompareString(left, ".wmv", false) != 0)
                                                                        {
                                                                            arg_340_0 = false;
                                                                            goto IL_33F;
                                                                        }
                                                                    }
                                                                }
                                                                arg_340_0 = true;
                                                            IL_33F:
                                                                flag = arg_340_0;
                                                                if (flag)
                                                                {
                                                                    result = "video/mpeg";
                                                                }
                                                                else
                                                                {
                                                                    flag = (Operators.CompareString(left, ".mp3", false) == 0 || Operators.CompareString(left, ".wma", false) == 0);
                                                                    if (flag)
                                                                    {
                                                                        result = "audio/mpeg";
                                                                    }
                                                                    else
                                                                    {
                                                                        flag = (Operators.CompareString(left, ".pdf", false) == 0);
                                                                        if (flag)
                                                                        {
                                                                            result = "application/pdf";
                                                                        }
                                                                        else
                                                                        {
                                                                            flag = (Operators.CompareString(left, ".rar", false) == 0);
                                                                            if (flag)
                                                                            {
                                                                                result = "application/octet-stream";
                                                                            }
                                                                            else
                                                                            {
                                                                                flag = (Operators.CompareString(left, ".txt", false) == 0);
                                                                                if (flag)
                                                                                {
                                                                                    result = "text/plain";
                                                                                }
                                                                                else
                                                                                {
                                                                                    flag = (Operators.CompareString(left, ".7z", false) == 0 || Operators.CompareString(left, ".z", false) == 0);
                                                                                    if (flag)
                                                                                    {
                                                                                        result = "application/x-compress";
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        flag = (Operators.CompareString(left, ".zip", false) == 0);
                                                                                        if (flag)
                                                                                        {
                                                                                            result = "application/x-zip-compressed";
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            result = "application/octet-stream";
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        public static bool IsAllowFile(string Ext, string fileextlist)
        {
            Ext = Ext.Replace(".", "");
            bool flag = fileextlist.IndexOf(Ext) == -1;
            return !flag;
        }
        public static int truelen(string Str)
        {
            ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
            byte[] bytes = aSCIIEncoding.GetBytes(Str);
            int num = 0;
            int arg_19_0 = 0;
            checked
            {
                int num2 = bytes.Length - 1;
                int num3 = arg_19_0;
                while (true)
                {
                    int arg_3E_0 = num3;
                    int num4 = num2;
                    if (arg_3E_0 > num4)
                    {
                        break;
                    }
                    bool flag = bytes[num3] == 63;
                    if (flag)
                    {
                        num++;
                    }
                    num++;
                    num3++;
                }
                return num;
            }
        }
        public static string GetTopic(string str, short strlen)
        {
            string text = "";
            bool flag = Operators.CompareString(str, "", false) == 0;
            checked
            {
                string result;
                if (flag)
                {
                    result = "";
                }
                else
                {
                    str = Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(str, "&nbsp;", " ", 1, -1, CompareMethod.Binary), "&quot;", "\"", 1, -1, CompareMethod.Binary), "&gt;", ">", 1, -1, CompareMethod.Binary), "&lt;", "<", 1, -1, CompareMethod.Binary);
                    int num = Strings.Len(str);
                    int num2 = 0;
                    int arg_83_0 = 1;
                    int num3 = num;
                    int num4 = arg_83_0;
                    while (true)
                    {
                        int arg_E2_0 = num4;
                        int num5 = num3;
                        if (arg_E2_0 > num5)
                        {
                            goto IL_E4;
                        }
                        int num6 = Math.Abs(Strings.Asc(Strings.Mid(str, num4, 1)));
                        flag = (num6 > 255);
                        if (flag)
                        {
                            num2 += 2;
                        }
                        else
                        {
                            num2++;
                        }
                        flag = (num2 >= (int)strlen);
                        if (flag)
                        {
                            break;
                        }
                        text = str;
                        num4++;
                    }
                    text = Strings.Left(str, num4);
                IL_E4:
                    text = Strings.Replace(Strings.Replace(Strings.Replace(Strings.Replace(text, " ", "&nbsp;", 1, -1, CompareMethod.Binary), "\"", "&quot;", 1, -1, CompareMethod.Binary), ">", "&gt;", 1, -1, CompareMethod.Binary), "<", "&lt;", 1, -1, CompareMethod.Binary);
                    result = text;
                }
                return result;
            }
        }
        public static ArrayList ToArrayList(string in_str, string split_str)
        {
            ArrayList arrayList = new ArrayList();
            bool flag = Operators.CompareString(in_str, "", false) != 0;
            if (flag)
            {
                bool flag2 = Strings.InStr(in_str, split_str, CompareMethod.Binary) > 0;
                if (flag2)
                {
                    string[] array = in_str.Split(new char[]
					{
						Conversions.ToChar(split_str)
					});
                    short arg_54_0 = 0;
                    short num = checked((short)(array.Length - 1));
                    short num2 = arg_54_0;
                    while (true)
                    {
                        short arg_6E_0 = num2;
                        short num3 = num;
                        if (arg_6E_0 > num3)
                        {
                            break;
                        }
                        arrayList.Add(array[(int)num2]);
                        num2 += 1;
                    }
                }
                else
                {
                    arrayList.Add(in_str);
                }
            }
            return arrayList;
        }
        public string BigShortString(string str)
        {
            string text = "";
            int i = 0;
            int length = str.Length;
            checked
            {
                while (i < length)
                {
                    char value = str[i];
                    bool flag = Operators.CompareString(Conversions.ToString(value), "A", false) > 0 & Operators.CompareString(Conversions.ToString(value), "Z", false) < 0;
                    if (flag)
                    {
                        text += Conversions.ToString(value);
                    }
                    i++;
                }
                return text;
            }
        }
        public static string GetChineseFirstLetter(string chinese)
        {
            string text = "CJWGNSPGCGNESYPBTYYZDXYKYGTDJNNJQMBSGZSCYJSYYQPGKBZGYCYWJKGKLJSWKPJQHYTWDDZLSGMRYPYWWCCKZNKYDGTTNGJEYKKZYTCJNMCYLQLYPYQFQRPZSLWBTGKJFYXJWZLTBNCXJJJJZXDTTSQZYCDXXHGCKBPHFFSSWYBGMXLPBYLLLHLXSPZMYJHSOJNGHDZQYKLGJHSGQZHXQGKEZZWYSCSCJXYEYXADZPMDSSMZJZQJYZCDJZWQJBDZBXGZNZCPWHKXHQKMWFBPBYDTJZZKQHYLYGXFPTYJYYZPSZLFCHMQSHGMXXSXJJSDCSBBQBEFSJYHWWGZKPYLQBGLDLCCTNMAYDDKSSNGYCSGXLYZAYBNPTSDKDYLHGYMYLCXPYCJNDQJWXQXFYYFJLEJBZRXCCQWQQSBNKYMGPLBMJRQCFLNYMYQMSQTRBCJTHZTQFRXQHXMJJCJLXQGJMSHZKBSWYEMYLTXFSYDSGLYCJQXSJNQBSCTYHBFTDCYZDJWYGHQFRXWCKQKXEBPTLPXJZSRMEBWHJLBJSLYYSMDXLCLQKXLHXJRZJMFQHXHWYWSBHTRXXGLHQHFNMNYKLDYXZPWLGGTMTCFPAJJZYLJTYANJGBJPLQGDZYQYAXBKYSECJSZNSLYZHZXLZCGHPXZHZNYTDSBCJKDLZAYFMYDLEBBGQYZKXGLDNDNYSKJSHDLYXBCGHXYPKDJMMZNGMMCLGWZSZXZJFZNMLZZTHCSYDBDLLSCDDNLKJYKJSYCJLKOHQASDKNHCSGANHDAASHTCPLCPQYBSDMPJLPCJOQLCDHJJYSPRCHNWJNLHLYYQYYWZPTCZGWWMZFFJQQQQYXACLBHKDJXDGMMYDJXZLLSYGXGKJRYWZWYCLZMSSJZLDBYDCFCXYHLXCHYZJQSFQAGMNYXPFRKSSBJLYXYSYGLNSCMHCWWMNZJJLXXHCHSYDSTTXRYCYXBYHCSMXJSZNPWGPXXTAYBGAJCXLYSDCCWZOCWKCCSBNHCPDYZNFCYYTYCKXKYBSQKKYTQQXFCWCHCYKELZQBSQYJQCCLMTHSYWHMKTLKJLYCXWHEQQHTQHZPQSQSCFYMMDMGBWHWLGSSLYSDLMLXPTHMJHWLJZYHZJXHTXJLHXRSWLWZJCBXMHZQXSDZPMGFCSGLSXYMJSHXPJXWMYQKSMYPLRTHBXFTPMHYXLCHLHLZYLXGSSSSTCLSLDCLRPBHZHXYYFHBBGDMYCNQQWLQHJJZYWJZYEJJDHPBLQXTQKWHLCHQXAGTLXLJXMSLXHTZKZJECXJCJNMFBYCSFYWYBJZGNYSDZSQYRSLJPCLPWXSDWEJBJCBCNAYTWGMPAPCLYQPCLZXSBNMSGGFNZJJBZSFZYNDXHPLQKZCZWALSBCCJXJYZGWKYPSGXFZFCDKHJGXDLQFSGDSLQWZKXTMHSBGZMJZRGLYJBPMLMSXLZJQQHZYJCZYDJWBMJKLDDPMJEGXYHYLXHLQYQHKYCWCJMYYXNATJHYCCXZPCQLBZWWYTWBQCMLPMYRJCCCXFPZNZZLJPLXXYZTZLGDLDCKLYRZZGQTGJHHHJLJAXFGFJZSLCFDQZLCLGJDJCSNCLLJPJQDCCLCJXMYZFTSXGCGSBRZXJQQCTZHGYQTJQQLZXJYLYLBCYAMCSTYLPDJBYREGKLZYZHLYSZQLZNWCZCLLWJQJJJKDGJZOLBBZPPGLGHTGZXYGHZMYCNQSYCYHBHGXKAMTXYXNBSKYZZGJZLQJDFCJXDYGJQJJPMGWGJJJPKQSBGBMMCJSSCLPQPDXCDYYKYFCJDDYYGYWRHJRTGZNYQLDKLJSZZGZQZJGDYKSHPZMTLCPWNJAFYZDJCNMWESCYGLBTZCGMSSLLYXQSXSBSJSBBSGGHFJLWPMZJNLYYWDQSHZXTYYWHMCYHYWDBXBTLMSYYYFSXJCSDXXLHJHFSSXZQHFZMZCZTQCXZXRTTDJHNNYZQQMNQDMMGYYDXMJGDHCDYZBFFALLZTDLTFXMXQZDNGWQDBDCZJDXBZGSQQDDJCMBKZFFXMKDMDSYYSZCMLJDSYNSPRSKMKMPCKLGDBQTFZSWTFGGLYPLLJZHGJJGYPZLTCSMCNBTJBQFKTHBYZGKPBBYMTTSSXTBNPDKLEYCJNYCDYKZDDHQHSDZSCTARLLTKZLGECLLKJLQJAQNBDKKGHPJTZQKSECSHALQFMMGJNLYJBBTMLYZXDCJPLDLPCQDHZYCBZSCZBZMSLJFLKRZJSNFRGJHXPDHYJYBZGDLQCSEZGXLBLGYXTWMABCHECMWYJYZLLJJYHLGBDJLSLYGKDZPZXJYYZLWCXSZFGWYYDLYHCLJSCMBJHBLYZLYCBLYDPDQYSXQZBYTDKYXJYYCNRJMDJGKLCLJBCTBJDDBBLBLCZQRPXJCGLZCSHLTOLJNMDDDLNGKAQHQHJGYKHEZNMSHRPHQQJCHGMFPRXHJGDYCHGHLYRZQLCYQJNZSQTKQJYMSZSWLCFQQQXYFGGYPTQWLMCRNFKKFSYYLQBMQAMMMYXCTPSHCPTXXZZSMPHPSHMCLMLDQFYQXSZYJDJJZZHQPDSZGLSTJBCKBXYQZJSGPSXQZQZRQTBDKYXZKHHGFLBCSMDLDGDZDBLZYYCXNNCSYBZBFGLZZXSWMSCCMQNJQSBDQSJTXXMBLTXZCLZSHZCXRQJGJYLXZFJPHYMZQQYDFQJJLZZNZJCDGZYGCTXMZYSCTLKPHTXHTLBJXJLXSCDQXCBBTJFQZFSLTJBTKQBXXJJLJCHCZDBZJDCZJDCPRNPQCJPFCZLCLZXZDMXMPHJSGZGSZZQJYLWTJPFSYASMCJBTZKYCWMYTCSJJLJCQLWZMALBXYFBPNLSFHTGJWEJJXXGLLJSTGSHJQLZFKCGNNDSZFDEQFHBSAQTGLLBXMMYGSZLDYDQMJJRGBJTKGDHGKBLQKBDMBYLXWCXYTTYBKMRTJZXQJBHLMHMJJZMQASLDCYXYQDLQCAFYWYXQHZ";
            string text2 = "亍丌兀丐廿卅丕亘丞鬲孬噩丨禺丿匕乇夭爻卮氐囟胤馗毓睾鼗丶亟鼐乜乩亓芈孛啬嘏仄厍厝厣厥厮靥赝匚叵匦匮匾赜卦卣刂刈刎刭刳刿剀剌剞剡剜蒯剽劂劁劐劓冂罔亻仃仉仂仨仡仫仞伛仳伢佤仵伥伧伉伫佞佧攸佚佝佟佗伲伽佶佴侑侉侃侏佾佻侪佼侬侔俦俨俪俅俚俣俜俑俟俸倩偌俳倬倏倮倭俾倜倌倥倨偾偃偕偈偎偬偻傥傧傩傺僖儆僭僬僦僮儇儋仝氽佘佥俎龠汆籴兮巽黉馘冁夔勹匍訇匐凫夙兕亠兖亳衮袤亵脔裒禀嬴蠃羸冫冱冽冼凇冖冢冥讠讦讧讪讴讵讷诂诃诋诏诎诒诓诔诖诘诙诜诟诠诤诨诩诮诰诳诶诹诼诿谀谂谄谇谌谏谑谒谔谕谖谙谛谘谝谟谠谡谥谧谪谫谮谯谲谳谵谶卩卺阝阢阡阱阪阽阼陂陉陔陟陧陬陲陴隈隍隗隰邗邛邝邙邬邡邴邳邶邺邸邰郏郅邾郐郄郇郓郦郢郜郗郛郫郯郾鄄鄢鄞鄣鄱鄯鄹酃酆刍奂劢劬劭劾哿勐勖勰叟燮矍廴凵凼鬯厶弁畚巯坌垩垡塾墼壅壑圩圬圪圳圹圮圯坜圻坂坩垅坫垆坼坻坨坭坶坳垭垤垌垲埏垧垴垓垠埕埘埚埙埒垸埴埯埸埤埝堋堍埽埭堀堞堙塄堠塥塬墁墉墚墀馨鼙懿艹艽艿芏芊芨芄芎芑芗芙芫芸芾芰苈苊苣芘芷芮苋苌苁芩芴芡芪芟苄苎芤苡茉苷苤茏茇苜苴苒苘茌苻苓茑茚茆茔茕苠苕茜荑荛荜茈莒茼茴茱莛荞茯荏荇荃荟荀茗荠茭茺茳荦荥荨茛荩荬荪荭荮莰荸莳莴莠莪莓莜莅荼莶莩荽莸荻莘莞莨莺莼菁萁菥菘堇萘萋菝菽菖萜萸萑萆菔菟萏萃菸菹菪菅菀萦菰菡葜葑葚葙葳蒇蒈葺蒉葸萼葆葩葶蒌蒎萱葭蓁蓍蓐蓦蒽蓓蓊蒿蒺蓠蒡蒹蒴蒗蓥蓣蔌甍蔸蓰蔹蔟蔺蕖蔻蓿蓼蕙蕈蕨蕤蕞蕺瞢蕃蕲蕻薤薨薇薏蕹薮薜薅薹薷薰藓藁藜藿蘧蘅蘩蘖蘼廾弈夼奁耷奕奚奘匏尢尥尬尴扌扪抟抻拊拚拗拮挢拶挹捋捃掭揶捱捺掎掴捭掬掊捩掮掼揲揸揠揿揄揞揎摒揆掾摅摁搋搛搠搌搦搡摞撄摭撖摺撷撸撙撺擀擐擗擤擢攉攥攮弋忒甙弑卟叱叽叩叨叻吒吖吆呋呒呓呔呖呃吡呗呙吣吲咂咔呷呱呤咚咛咄呶呦咝哐咭哂咴哒咧咦哓哔呲咣哕咻咿哌哙哚哜咩咪咤哝哏哞唛哧唠哽唔哳唢唣唏唑唧唪啧喏喵啉啭啁啕唿啐唼唷啖啵啶啷唳唰啜喋嗒喃喱喹喈喁喟啾嗖喑啻嗟喽喾喔喙嗪嗷嗉嘟嗑嗫嗬嗔嗦嗝嗄嗯嗥嗲嗳嗌嗍嗨嗵嗤辔嘞嘈嘌嘁嘤嘣嗾嘀嘧嘭噘嘹噗嘬噍噢噙噜噌噔嚆噤噱噫噻噼嚅嚓嚯囔囗囝囡囵囫囹囿圄圊圉圜帏帙帔帑帱帻帼帷幄幔幛幞幡岌屺岍岐岖岈岘岙岑岚岜岵岢岽岬岫岱岣峁岷峄峒峤峋峥崂崃崧崦崮崤崞崆崛嵘崾崴崽嵬嵛嵯嵝嵫嵋嵊嵩嵴嶂嶙嶝豳嶷巅彳彷徂徇徉後徕徙徜徨徭徵徼衢彡犭犰犴犷犸狃狁狎狍狒狨狯狩狲狴狷猁狳猃狺狻猗猓猡猊猞猝猕猢猹猥猬猸猱獐獍獗獠獬獯獾舛夥飧夤夂饣饧饨饩饪饫饬饴饷饽馀馄馇馊馍馐馑馓馔馕庀庑庋庖庥庠庹庵庾庳赓廒廑廛廨廪膺忄忉忖忏怃忮怄忡忤忾怅怆忪忭忸怙怵怦怛怏怍怩怫怊怿怡恸恹恻恺恂恪恽悖悚悭悝悃悒悌悛惬悻悱惝惘惆惚悴愠愦愕愣惴愀愎愫慊慵憬憔憧憷懔懵忝隳闩闫闱闳闵闶闼闾阃阄阆阈阊阋阌阍阏阒阕阖阗阙阚丬爿戕氵汔汜汊沣沅沐沔沌汨汩汴汶沆沩泐泔沭泷泸泱泗沲泠泖泺泫泮沱泓泯泾洹洧洌浃浈洇洄洙洎洫浍洮洵洚浏浒浔洳涑浯涞涠浞涓涔浜浠浼浣渚淇淅淞渎涿淠渑淦淝淙渖涫渌涮渫湮湎湫溲湟溆湓湔渲渥湄滟溱溘滠漭滢溥溧溽溻溷滗溴滏溏滂溟潢潆潇漤漕滹漯漶潋潴漪漉漩澉澍澌潸潲潼潺濑濉澧澹澶濂濡濮濞濠濯瀚瀣瀛瀹瀵灏灞宀宄宕宓宥宸甯骞搴寤寮褰寰蹇謇辶迓迕迥迮迤迩迦迳迨逅逄逋逦逑逍逖逡逵逶逭逯遄遑遒遐遨遘遢遛暹遴遽邂邈邃邋彐彗彖彘尻咫屐屙孱屣屦羼弪弩弭艴弼鬻屮妁妃妍妩妪妣妗姊妫妞妤姒妲妯姗妾娅娆姝娈姣姘姹娌娉娲娴娑娣娓婀婧婊婕娼婢婵胬媪媛婷婺媾嫫媲嫒嫔媸嫠嫣嫱嫖嫦嫘嫜嬉嬗嬖嬲嬷孀尕尜孚孥孳孑孓孢驵驷驸驺驿驽骀骁骅骈骊骐骒骓骖骘骛骜骝骟骠骢骣骥骧纟纡纣纥纨纩纭纰纾绀绁绂绉绋绌绐绔绗绛绠绡绨绫绮绯绱绲缍绶绺绻绾缁缂缃缇缈缋缌缏缑缒缗缙缜缛缟缡缢缣缤缥缦缧缪缫缬缭缯缰缱缲缳缵幺畿巛甾邕玎玑玮玢玟珏珂珑玷玳珀珉珈珥珙顼琊珩珧珞玺珲琏琪瑛琦琥琨琰琮琬琛琚瑁瑜瑗瑕瑙瑷瑭瑾璜璎璀璁璇璋璞璨璩璐璧瓒璺韪韫韬杌杓杞杈杩枥枇杪杳枘枧杵枨枞枭枋杷杼柰栉柘栊柩枰栌柙枵柚枳柝栀柃枸柢栎柁柽栲栳桠桡桎桢桄桤梃栝桕桦桁桧桀栾桊桉栩梵梏桴桷梓桫棂楮棼椟椠棹椤棰椋椁楗棣椐楱椹楠楂楝榄楫榀榘楸椴槌榇榈槎榉楦楣楹榛榧榻榫榭槔榱槁槊槟榕槠榍槿樯槭樗樘橥槲橄樾檠橐橛樵檎橹樽樨橘橼檑檐檩檗檫猷獒殁殂殇殄殒殓殍殚殛殡殪轫轭轱轲轳轵轶轸轷轹轺轼轾辁辂辄辇辋辍辎辏辘辚軎戋戗戛戟戢戡戥戤戬臧瓯瓴瓿甏甑甓攴旮旯旰昊昙杲昃昕昀炅曷昝昴昱昶昵耆晟晔晁晏晖晡晗晷暄暌暧暝暾曛曜曦曩贲贳贶贻贽赀赅赆赈赉赇赍赕赙觇觊觋觌觎觏觐觑牮犟牝牦牯牾牿犄犋犍犏犒挈挲掰搿擘耄毪毳毽毵毹氅氇氆氍氕氘氙氚氡氩氤氪氲攵敕敫牍牒牖爰虢刖肟肜肓肼朊肽肱肫肭肴肷胧胨胩胪胛胂胄胙胍胗朐胝胫胱胴胭脍脎胲胼朕脒豚脶脞脬脘脲腈腌腓腴腙腚腱腠腩腼腽腭腧塍媵膈膂膑滕膣膪臌朦臊膻臁膦欤欷欹歃歆歙飑飒飓飕飙飚殳彀毂觳斐齑斓於旆旄旃旌旎旒旖炀炜炖炝炻烀炷炫炱烨烊焐焓焖焯焱煳煜煨煅煲煊煸煺熘熳熵熨熠燠燔燧燹爝爨灬焘煦熹戾戽扃扈扉礻祀祆祉祛祜祓祚祢祗祠祯祧祺禅禊禚禧禳忑忐怼恝恚恧恁恙恣悫愆愍慝憩憝懋懑戆肀聿沓泶淼矶矸砀砉砗砘砑斫砭砜砝砹砺砻砟砼砥砬砣砩硎硭硖硗砦硐硇硌硪碛碓碚碇碜碡碣碲碹碥磔磙磉磬磲礅磴礓礤礞礴龛黹黻黼盱眄眍盹眇眈眚眢眙眭眦眵眸睐睑睇睃睚睨睢睥睿瞍睽瞀瞌瞑瞟瞠瞰瞵瞽町畀畎畋畈畛畲畹疃罘罡罟詈罨罴罱罹羁罾盍盥蠲钅钆钇钋钊钌钍钏钐钔钗钕钚钛钜钣钤钫钪钭钬钯钰钲钴钶钷钸钹钺钼钽钿铄铈铉铊铋铌铍铎铐铑铒铕铖铗铙铘铛铞铟铠铢铤铥铧铨铪铩铫铮铯铳铴铵铷铹铼铽铿锃锂锆锇锉锊锍锎锏锒锓锔锕锖锘锛锝锞锟锢锪锫锩锬锱锲锴锶锷锸锼锾锿镂锵镄镅镆镉镌镎镏镒镓镔镖镗镘镙镛镞镟镝镡镢镤镥镦镧镨镩镪镫镬镯镱镲镳锺矧矬雉秕秭秣秫稆嵇稃稂稞稔稹稷穑黏馥穰皈皎皓皙皤瓞瓠甬鸠鸢鸨鸩鸪鸫鸬鸲鸱鸶鸸鸷鸹鸺鸾鹁鹂鹄鹆鹇鹈鹉鹋鹌鹎鹑鹕鹗鹚鹛鹜鹞鹣鹦鹧鹨鹩鹪鹫鹬鹱鹭鹳疒疔疖疠疝疬疣疳疴疸痄疱疰痃痂痖痍痣痨痦痤痫痧瘃痱痼痿瘐瘀瘅瘌瘗瘊瘥瘘瘕瘙瘛瘼瘢瘠癀瘭瘰瘿瘵癃瘾瘳癍癞癔癜癖癫癯翊竦穸穹窀窆窈窕窦窠窬窨窭窳衤衩衲衽衿袂裆袷袼裉裢裎裣裥裱褚裼裨裾裰褡褙褓褛褊褴褫褶襁襦疋胥皲皴矜耒耔耖耜耠耢耥耦耧耩耨耱耋耵聃聆聍聒聩聱覃顸颀颃颉颌颍颏颔颚颛颞颟颡颢颥颦虍虔虬虮虿虺虼虻蚨蚍蚋蚬蚝蚧蚣蚪蚓蚩蚶蛄蚵蛎蚰蚺蚱蚯蛉蛏蚴蛩蛱蛲蛭蛳蛐蜓蛞蛴蛟蛘蛑蜃蜇蛸蜈蜊蜍蜉蜣蜻蜞蜥蜮蜚蜾蝈蜴蜱蜩蜷蜿螂蜢蝽蝾蝻蝠蝰蝌蝮螋蝓蝣蝼蝤蝙蝥螓螯螨蟒蟆螈螅螭螗螃螫蟥螬螵螳蟋蟓螽蟑蟀蟊蟛蟪蟠蟮蠖蠓蟾蠊蠛蠡蠹蠼缶罂罄罅舐竺竽笈笃笄笕笊笫笏筇笸笪笙笮笱笠笥笤笳笾笞筘筚筅筵筌筝筠筮筻筢筲筱箐箦箧箸箬箝箨箅箪箜箢箫箴篑篁篌篝篚篥篦篪簌篾篼簏簖簋簟簪簦簸籁籀臾舁舂舄臬衄舡舢舣舭舯舨舫舸舻舳舴舾艄艉艋艏艚艟艨衾袅袈裘裟襞羝羟羧羯羰羲籼敉粑粝粜粞粢粲粼粽糁糇糌糍糈糅糗糨艮暨羿翎翕翥翡翦翩翮翳糸絷綦綮繇纛麸麴赳趄趔趑趱赧赭豇豉酊酐酎酏酤酢酡酰酩酯酽酾酲酴酹醌醅醐醍醑醢醣醪醭醮醯醵醴醺豕鹾趸跫踅蹙蹩趵趿趼趺跄跖跗跚跞跎跏跛跆跬跷跸跣跹跻跤踉跽踔踝踟踬踮踣踯踺蹀踹踵踽踱蹉蹁蹂蹑蹒蹊蹰蹶蹼蹯蹴躅躏躔躐躜躞豸貂貊貅貘貔斛觖觞觚觜觥觫觯訾謦靓雩雳雯霆霁霈霏霎霪霭霰霾龀龃龅龆龇龈龉龊龌黾鼋鼍隹隼隽雎雒瞿雠銎銮鋈錾鍪鏊鎏鐾鑫鱿鲂鲅鲆鲇鲈稣鲋鲎鲐鲑鲒鲔鲕鲚鲛鲞鲟鲠鲡鲢鲣鲥鲦鲧鲨鲩鲫鲭鲮鲰鲱鲲鲳鲴鲵鲶鲷鲺鲻鲼鲽鳄鳅鳆鳇鳊鳋鳌鳍鳎鳏鳐鳓鳔鳕鳗鳘鳙鳜鳝鳟鳢靼鞅鞑鞒鞔鞯鞫鞣鞲鞴骱骰骷鹘骶骺骼髁髀髅髂髋髌髑魅魃魇魉魈魍魑飨餍餮饕饔髟髡髦髯髫髻髭髹鬈鬏鬓鬟鬣麽麾縻麂麇麈麋麒鏖麝麟黛黜黝黠黟黢黩黧黥黪黯鼢鼬鼯鼹鼷鼽鼾齄";
            byte[] array = new byte[2];
            string text3 = "";
            int arg_26_0 = 0;
            checked
            {
                int num = chinese.Length - 1;
                int num2 = arg_26_0;
                while (true)
                {
                    int arg_60F_0 = num2;
                    int num3 = num;
                    if (arg_60F_0 > num3)
                    {
                        break;
                    }
                    array = Encoding.Default.GetBytes(chinese[num2].ToString());
                    bool flag = array[0] < 176;
                    if (flag)
                    {
                        text3 += Conversions.ToString(chinese[num2]);
                    }
                    else
                    {
                        flag = (array[0] >= 176 && array[0] <= 215);
                        if (flag)
                        {
                            bool flag2 = chinese[num2].ToString().CompareTo("匝") >= 0;
                            if (flag2)
                            {
                                text3 += "z";
                            }
                            else
                            {
                                flag2 = (chinese[num2].ToString().CompareTo("压") >= 0);
                                if (flag2)
                                {
                                    text3 += "y";
                                }
                                else
                                {
                                    flag2 = (chinese[num2].ToString().CompareTo("昔") >= 0);
                                    if (flag2)
                                    {
                                        text3 += "x";
                                    }
                                    else
                                    {
                                        flag2 = (chinese[num2].ToString().CompareTo("挖") >= 0);
                                        if (flag2)
                                        {
                                            text3 += "w";
                                        }
                                        else
                                        {
                                            flag2 = (chinese[num2].ToString().CompareTo("塌") >= 0);
                                            if (flag2)
                                            {
                                                text3 += "t";
                                            }
                                            else
                                            {
                                                flag2 = (chinese[num2].ToString().CompareTo("撒") >= 0);
                                                if (flag2)
                                                {
                                                    text3 += "s";
                                                }
                                                else
                                                {
                                                    flag2 = (chinese[num2].ToString().CompareTo("然") >= 0);
                                                    if (flag2)
                                                    {
                                                        text3 += "r";
                                                    }
                                                    else
                                                    {
                                                        flag2 = (chinese[num2].ToString().CompareTo("期") >= 0);
                                                        if (flag2)
                                                        {
                                                            text3 += "q";
                                                        }
                                                        else
                                                        {
                                                            flag2 = (chinese[num2].ToString().CompareTo("啪") >= 0);
                                                            if (flag2)
                                                            {
                                                                text3 += "p";
                                                            }
                                                            else
                                                            {
                                                                flag2 = (chinese[num2].ToString().CompareTo("哦") >= 0);
                                                                if (flag2)
                                                                {
                                                                    text3 += "o";
                                                                }
                                                                else
                                                                {
                                                                    flag2 = (chinese[num2].ToString().CompareTo("拿") >= 0);
                                                                    if (flag2)
                                                                    {
                                                                        text3 += "n";
                                                                    }
                                                                    else
                                                                    {
                                                                        flag2 = (chinese[num2].ToString().CompareTo("妈") >= 0);
                                                                        if (flag2)
                                                                        {
                                                                            text3 += "m";
                                                                        }
                                                                        else
                                                                        {
                                                                            flag2 = (chinese[num2].ToString().CompareTo("垃") >= 0);
                                                                            if (flag2)
                                                                            {
                                                                                text3 += "l";
                                                                            }
                                                                            else
                                                                            {
                                                                                flag2 = (chinese[num2].ToString().CompareTo("喀") >= 0);
                                                                                if (flag2)
                                                                                {
                                                                                    text3 += "k";
                                                                                }
                                                                                else
                                                                                {
                                                                                    flag2 = (chinese[num2].ToString().CompareTo("击") >= 0);
                                                                                    if (flag2)
                                                                                    {
                                                                                        text3 += "j";
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        flag2 = (chinese[num2].ToString().CompareTo("哈") >= 0);
                                                                                        if (flag2)
                                                                                        {
                                                                                            text3 += "h";
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            flag2 = (chinese[num2].ToString().CompareTo("噶") >= 0);
                                                                                            if (flag2)
                                                                                            {
                                                                                                text3 += "g";
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                flag2 = (chinese[num2].ToString().CompareTo("发") >= 0);
                                                                                                if (flag2)
                                                                                                {
                                                                                                    text3 += "f";
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    flag2 = (chinese[num2].ToString().CompareTo("蛾") >= 0);
                                                                                                    if (flag2)
                                                                                                    {
                                                                                                        text3 += "e";
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        flag2 = (chinese[num2].ToString().CompareTo("搭") >= 0);
                                                                                                        if (flag2)
                                                                                                        {
                                                                                                            text3 += "d";
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            flag2 = (chinese[num2].ToString().CompareTo("擦") >= 0);
                                                                                                            if (flag2)
                                                                                                            {
                                                                                                                text3 += "c";
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                flag2 = (chinese[num2].ToString().CompareTo("芭") >= 0);
                                                                                                                if (flag2)
                                                                                                                {
                                                                                                                    text3 += "b";
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    flag2 = (chinese[num2].ToString().CompareTo("啊") >= 0);
                                                                                                                    if (flag2)
                                                                                                                    {
                                                                                                                        text3 += "a";
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            bool flag2 = array[0] >= 215;
                            if (flag2)
                            {
                                text3 += text.Substring(text2.IndexOf(chinese[num2].ToString(), 0), 1);
                            }
                        }
                    }
                    num2++;
                }
                return text3.ToUpper();
            }
        }
        public static bool IsExitId(int Id, string str)
        {
            bool flag = Strings.Trim(str).Length > 0;
            checked
            {
                bool result=false ;
                if (flag)
                {
                    bool flag2 = Strings.InStr(str, ",", CompareMethod.Binary) > 0;
                    if (flag2)
                    {
                        string[] array = str.Split(new char[]
						{
							','
						});
                        int arg_46_0 = 0;
                        int num = array.Length - 1;
                        int num2 = arg_46_0;
                        while (true)
                        {
                            int arg_6E_0 = num2;
                            int num3 = num;
                            if (arg_6E_0 > num3)
                            {
                                goto Block_4;
                            }
                            flag2 = (Conversions.ToInteger(array[num2]) == Id);
                            if (flag2)
                            {
                                break;
                            }
                            num2++;
                        }
                        result = true;
                    Block_4: ;
                    }
                    else
                    {
                        flag2 = (Conversions.ToInteger(str) == Id);
                        if (flag2)
                        {
                            result = true;
                        }
                    }
                }
                return result;
            }
        }
        public static string gettitle(string title, int index)
        {
            bool flag = Operators.CompareString(title, "", false) != 0;
            string result = "";
            if (flag)
            {
                bool flag2 = title.Contains(",");
                if (flag2)
                {
                    string[] array = title.Split(new char[]
					{
						','
					});
                    flag2 = (index < array.Length);
                    if (flag2)
                    {
                        result = array[index];
                    }
                }
                else
                {
                    flag2 = (index == 0);
                    if (flag2)
                    {
                        result = title;
                    }
                }
            }
            return result;
        }
        public static string chnumstr(object num)
        {
            int num2 = Strings.Len(RuntimeHelpers.GetObjectValue(num));
            bool flag = Operators.ConditionalCompareObjectEqual(num, 1, false);
            string str="";
            if (flag)
            {
                str = "一";
            }
            else
            {
                flag = Operators.ConditionalCompareObjectEqual(num, 2, false);
                if (flag)
                {
                    str = "二";
                }
                else
                {
                    flag = Operators.ConditionalCompareObjectEqual(num, 3, false);
                    if (flag)
                    {
                        str = "三";
                    }
                    else
                    {
                        flag = Operators.ConditionalCompareObjectEqual(num, 4, false);
                        if (flag)
                        {
                            str = "四";
                        }
                        else
                        {
                            flag = Operators.ConditionalCompareObjectEqual(num, 5, false);
                            if (flag)
                            {
                                str = "五";
                            }
                            else
                            {
                                flag = Operators.ConditionalCompareObjectEqual(num, 6, false);
                                if (flag)
                                {
                                    str = "六";
                                }
                                else
                                {
                                    flag = Operators.ConditionalCompareObjectEqual(num, 7, false);
                                    if (flag)
                                    {
                                        str = "七";
                                    }
                                    else
                                    {
                                        flag = Operators.ConditionalCompareObjectEqual(num, 8, false);
                                        if (flag)
                                        {
                                            str = "八";
                                        }
                                        else
                                        {
                                            flag = Operators.ConditionalCompareObjectEqual(num, 9, false);
                                            if (flag)
                                            {
                                                str = "九";
                                            }
                                            else
                                            {
                                                flag = Operators.ConditionalCompareObjectEqual(num, 0, false);
                                                if (flag)
                                                {
                                                    str = "零";
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            string text="";
            text += str;
            return text;
        }
        public static string chnumstr2(object num)
        {
            int num2 = Strings.Len(RuntimeHelpers.GetObjectValue(num));
            bool flag = Operators.ConditionalCompareObjectEqual(num, 1, false);
            string str="";
            if (flag)
            {
                str = "一";
            }
            else
            {
                flag = Operators.ConditionalCompareObjectEqual(num, 2, false);
                if (flag)
                {
                    str = "二";
                }
                else
                {
                    flag = Operators.ConditionalCompareObjectEqual(num, 3, false);
                    if (flag)
                    {
                        str = "三";
                    }
                    else
                    {
                        flag = Operators.ConditionalCompareObjectEqual(num, 4, false);
                        if (flag)
                        {
                            str = "四";
                        }
                        else
                        {
                            flag = Operators.ConditionalCompareObjectEqual(num, 5, false);
                            if (flag)
                            {
                                str = "五";
                            }
                            else
                            {
                                flag = Operators.ConditionalCompareObjectEqual(num, 6, false);
                                if (flag)
                                {
                                    str = "六";
                                }
                                else
                                {
                                    flag = Operators.ConditionalCompareObjectEqual(num, 0, false);
                                    if (flag)
                                    {
                                        str = "日";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            string text="";
            text += str;
            return text;
        }
        public static string getAge(string strBirthday)
        {
            string text = "";
            bool flag = !string.IsNullOrEmpty(strBirthday);
            string result;
            if (flag)
            {
                try
                {
                    DateTime dateTime = Convert.ToDateTime(strBirthday);
                    flag = (DateTime.Now.Month >= dateTime.Month);
                    int num;
                    if (flag)
                    {
                        bool flag2 = DateTime.Now.Day >= dateTime.Day;
                        if (flag2)
                        {
                            num = 0;
                        }
                        else
                        {
                            num = 1;
                        }
                    }
                    else
                    {
                        num = 1;
                    }
                    text = checked(DateTime.Now.Year - dateTime.Year - num).ToString();
                }
                catch (Exception arg_93_0)
                {
                    ProjectData.SetProjectError(arg_93_0);
                    result = "Error";
                    ProjectData.ClearProjectError();
                    return result;
                }
            }
            else
            {
                text = "参数错误";
            }
            result = text;
            return result;
        }
        public static bool CheckIDCard(string Id)
        {
            bool flag = Id.Length == 18;
            bool result;
            if (flag)
            {
                bool flag2 = String.CheckIDCard18(Id);
                result = flag2;
            }
            else
            {
                flag = (Id.Length == 15);
                if (flag)
                {
                    bool flag3 = String.CheckIDCard15(Id);
                    result = flag3;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        private static bool CheckIDCard18(string Id)
        {
            long num = 0L;
            bool arg_55_0;
            if (long.TryParse(Id.Remove(17), out num) && (double)num >= Math.Pow(10.0, 16.0))
            {
                if (long.TryParse(Id.Replace('x', '0').Replace('X', '0'), out num))
                {
                    arg_55_0 = false;
                    goto IL_54;
                }
            }
            arg_55_0 = true;
        IL_54:
            bool flag = arg_55_0;
            checked
            {
                bool result;
                if (flag)
                {
                    result = false;
                }
                else
                {
                    string text = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
                    flag = (text.IndexOf(Id.Remove(2)) == -1);
                    if (flag)
                    {
                        result = false;
                    }
                    else
                    {
                        string s = Id.Substring(6, 8).Insert(6, "-").Insert(4, "-");
                        DateTime dateTime = default(DateTime);
                        flag = !DateTime.TryParse(s, out dateTime);
                        if (flag)
                        {
                            result = false;
                        }
                        else
                        {
                            string[] array = "1,0,x,9,8,7,6,5,4,3,2".Split(new char[]
							{
								','
							});
                            string[] array2 = "7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2".Split(new char[]
							{
								','
							});
                            char[] array3 = Id.Remove(17).ToCharArray();
                            int num2 = 0;
                            int num3 = 0;
                            int arg_146_0;
                            int num4;
                            do
                            {
                                num2 += int.Parse(array2[num3]) * int.Parse(array3[num3].ToString());
                                num3++;
                                arg_146_0 = num3;
                                num4 = 16;
                            }
                            while (arg_146_0 <= num4);
                            int num5 = -1;
                            Math.DivRem(num2, 11, out num5);
                            flag = (Operators.CompareString(array[num5], Id.Substring(17, 1).ToLower(), false) != 0);
                            result = !flag;
                        }
                    }
                }
                return result;
            }
        }
        private static bool CheckIDCard15(string Id)
        {
            long num = 0L;
            bool flag = !long.TryParse(Id, out num) || (double)num < Math.Pow(10.0, 14.0);
            bool result;
            if (flag)
            {
                result = false;
            }
            else
            {
                string text = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
                flag = (text.IndexOf(Id.Remove(2)) == -1);
                if (flag)
                {
                    result = false;
                }
                else
                {
                    string s = Id.Substring(6, 6).Insert(4, "-").Insert(2, "-");
                    DateTime dateTime = default(DateTime);
                    flag = !DateTime.TryParse(s, out dateTime);
                    result = !flag;
                }
            }
            return result;
        }
        public static string GetBrithdayFromIdCard(string IdCard)
        {
            string result = "1900-01-01";
            bool flag = IdCard.Length == 15;
            if (flag)
            {
                result = IdCard.Substring(6, 6).Insert(4, "-").Insert(2, "-");
            }
            else
            {
                flag = (IdCard.Length == 18);
                if (flag)
                {
                    result = IdCard.Substring(6, 8).Insert(6, "-").Insert(4, "-");
                }
            }
            return result;
        }
        public static string GetSexFromIdCard(string IdCard)
        {
            string text = "";
            bool flag = IdCard.Length == 15;
            checked
            {
                if (flag)
                {
                    text = IdCard.Substring(IdCard.Length - 3);
                }
                else
                {
                    flag = (IdCard.Length == 18);
                    if (flag)
                    {
                        text = IdCard.Substring(IdCard.Length - 4);
                        text = text.Substring(0, 3);
                    }
                }
                int a = int.Parse(text);
                int num;
                Math.DivRem(a, 2, out num);
                flag = (num == 0);
                string result;
                if (flag)
                {
                    result = "女";
                }
                else
                {
                    result = "男";
                }
                return result;
            }
        }
        public static string GetHrefStr(string s)
        {
            bool flag = s.Length == 0;
            string result;
            if (flag)
            {
                result = "";
            }
            else
            {
                flag = !s.Contains("http://");
                if (flag)
                {
                    s = "http://" + s;
                }
                result = string.Concat(new string[]
				{
					"<a href='",
					s,
					"' target=_blank title='",
					s,
					"'>打开</a>"
				});
            }
            return result;
        }
        public static string GetIPAddress()
        {
            string result = string.Empty;
            bool flag = HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null;
            if (flag)
            {
                bool flag2 = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null;
                if (flag2)
                {
                    result = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
                }
                else
                {
                    result = HttpContext.Current.Request.UserHostAddress;
                }
            }
            else
            {
                result = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
            }
            return result;
        }
    }
}
