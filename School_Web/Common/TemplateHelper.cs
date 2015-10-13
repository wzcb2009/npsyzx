using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Text;
using System.Web;
namespace Wzsckj.com.Common
{
    public class TemplateHelper
    {
        public Encoding code;
        public string path;
        public string temp;
        public TemplateHelper(string FilePath, string TemplatePath)
        {
            this.code = Encoding.GetEncoding("gb2312");
            this.path = HttpContext.Current.Server.MapPath(FilePath);
            this.temp = HttpContext.Current.Server.MapPath(TemplatePath);
        }
        public string ReadHtmlFile(string temp)
        {
            StreamReader streamReader = null;
            string result = "";
            try
            {
                streamReader = new StreamReader(temp, this.code);
                result = streamReader.ReadToEnd();
            }
            catch (Exception expr_20)
            {
                ProjectData.SetProjectError(expr_20);
                Exception ex = expr_20;
                HttpContext.Current.Response.Write(ex.Message);
                HttpContext.Current.Response.End();
                ProjectData.ClearProjectError();
            }
            finally
            {
                streamReader.Dispose();
                streamReader.Close();
            }
            return result;
        }
        public bool WriteHtmlFile(string str, string htmlfilename)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(htmlfilename, false, this.code);
                streamWriter.Write(str);
                streamWriter.Flush();
            }
            catch (Exception expr_23)
            {
                ProjectData.SetProjectError(expr_23);
                Exception ex = expr_23;
                HttpContext.Current.Response.Write(ex.Message);
                HttpContext.Current.Response.End();
                ProjectData.ClearProjectError();
            }
            finally
            {
                streamWriter.Dispose();
                streamWriter.Close();
            }
            return true;
        }
        public static string GetNavigate(int totalRecord, int pageSize, int DistLen, int page, string QueryParameter, string scriptName, string extName)
        {
            string text = "";
            bool flag = totalRecord % pageSize != 0;
            checked
            {
                int num;
                if (flag)
                {
                    num = totalRecord / pageSize + 1;
                }
                else
                {
                    num = totalRecord / pageSize;
                }
                flag = (num < 1);
                string result;
                if (flag)
                {
                    result = text;
                }
                else
                {
                    text = text + "显示" + Conversions.ToString((page - 1) * pageSize + 1) + "━";
                    flag = (page >= num);
                    if (flag)
                    {
                        text = text + Conversions.ToString(totalRecord) + "条";
                    }
                    else
                    {
                        text = text + Conversions.ToString(page * pageSize) + "条";
                    }
                    text = string.Concat(new string[]
					{
						text,
						"共<B>",
						Conversions.ToString(totalRecord),
						"</B>条 ",
						Conversions.ToString(pageSize),
						"条/页"
					});
                    flag = (page > 1);
                    if (flag)
                    {
                        text = string.Concat(new string[]
						{
							text,
							"<a href=\"",
							scriptName,
							"1",
							extName,
							".",
							QueryParameter,
							"\"  > 首  页 </a>"
						});
                        text = string.Concat(new string[]
						{
							text,
							"<a href=\"",
							scriptName,
							Conversions.ToString(page - 1),
							extName,
							".",
							QueryParameter,
							"\" > 上一页 </a>"
						});
                    }
                    flag = (page < DistLen * 2);
                    bool flag2;
                    if (flag)
                    {
                        flag2 = (num > DistLen * 2);
                        int num2;
                        if (flag2)
                        {
                            num2 = DistLen * 2;
                        }
                        else
                        {
                            num2 = num;
                        }
                        int arg_1B4_0 = 1;
                        int num3 = num2;
                        int num4 = arg_1B4_0;
                        while (true)
                        {
                            int arg_25D_0 = num4;
                            int num5 = num3;
                            if (arg_25D_0 > num5)
                            {
                                break;
                            }
                            flag2 = (num4 == page);
                            if (flag2)
                            {
                                text = text + "<B>&nbsp;" + Conversions.ToString(page) + "</B>";
                            }
                            else
                            {
                                text = string.Concat(new string[]
								{
									text,
									"<a href=\"",
									scriptName,
									Conversions.ToString(num4),
									extName,
									".",
									QueryParameter,
									"\">&nbsp;",
									Conversions.ToString(num4),
									"</a>"
								});
                            }
                            num4++;
                        }
                    }
                    else
                    {
                        flag2 = (num > page + DistLen);
                        int num2;
                        if (flag2)
                        {
                            num2 = page + DistLen;
                        }
                        else
                        {
                            num2 = num;
                        }
                        int arg_284_0 = page - DistLen;
                        int num6 = num2;
                        int num7 = arg_284_0;
                        while (true)
                        {
                            int arg_32D_0 = num7;
                            int num5 = num6;
                            if (arg_32D_0 > num5)
                            {
                                break;
                            }
                            flag2 = (num7 == page);
                            if (flag2)
                            {
                                text = text + "<B>&nbsp;" + Conversions.ToString(page) + "</B>";
                            }
                            else
                            {
                                text = string.Concat(new string[]
								{
									text,
									"<a href=\"",
									scriptName,
									Conversions.ToString(num7),
									extName,
									".",
									QueryParameter,
									"\" >&nbsp;",
									Conversions.ToString(num7),
									"</a>"
								});
                            }
                            num7++;
                        }
                    }
                    flag2 = (page < num);
                    if (flag2)
                    {
                        text = string.Concat(new string[]
						{
							text,
							"<a href=\"",
							scriptName,
							Conversions.ToString(page + 1),
							extName,
							".",
							QueryParameter,
							"\" > 下一页 </a>"
						});
                        text = string.Concat(new string[]
						{
							text,
							"<a href=\"",
							scriptName,
							Conversions.ToString(num),
							extName,
							".",
							QueryParameter,
							"\" > 尾页 </a>"
						});
                    }
                    result = text;
                }
                return result;
            }
        }
    }
}
