using Microsoft.VisualBasic.CompilerServices;
using StringHandling;
using System;
using System.IO;
using System.Text;
using System.Web;
namespace Wzsckj.com.Common
{
    public class FileDownHelper
    {
        public static string FileNameExtension(string FileName)
        {
            return Path.GetExtension(FileDownHelper.MapPathFile(FileName));
        }
        public static string MapPathFile(string FileName)
        {
            return HttpContext.Current.Server.MapPath(FileName);
        }
        public static void DownLoadold(string FileName)
        {
            string text = FileDownHelper.MapPathFile(FileName);
            bool flag = File.Exists(text);
            if (flag)
            {
                FileInfo fileInfo = new FileInfo(text);
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.ClearHeaders();
                HttpContext.Current.Response.Buffer = false;
                HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(Path.GetFileName(text), Encoding.UTF8));
                HttpContext.Current.Response.AppendHeader("Content-Length", fileInfo.Length.ToString());
                HttpContext.Current.Response.ContentType = "application/octet-stream";
                HttpContext.Current.Response.WriteFile(text);
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.End();
            }
        }
        public static void DownLoadold(string FilePath, string FileName)
        {
            bool flag = File.Exists(FilePath);
            if (flag)
            {
                FileInfo fileInfo = new FileInfo(FilePath);
                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.ClearHeaders();
                HttpContext.Current.Response.Buffer = false;
                HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(Path.GetFileName(FileName), Encoding.UTF8));
                HttpContext.Current.Response.AppendHeader("Content-Length", fileInfo.Length.ToString());
                HttpContext.Current.Response.ContentType = "application/octet-stream";
                HttpContext.Current.Response.WriteFile(FilePath);
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.End();
            }
        }
        public static void DownLoad(string FileName, string title)
        {
            string path = FileDownHelper.MapPathFile(FileName);
            long num = 204800L;
            checked
            {
                byte[] array = new byte[(int)(num - 1L) + 1];
                FileStream fileStream = null;
                try
                {
                    fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                    long num2 = fileStream.Length;
                    HttpContext.Current.Response.ContentType = "application/octet-stream";
                    bool flag = HttpContext.Current.Request.UserAgent.ToLower().IndexOf("msie") > -1;
                    if (flag)
                    {
                        FileName = StringHandling.String.ToHexString(FileName);
                    }
                    flag = (HttpContext.Current.Request.UserAgent.ToLower().IndexOf("firefox") > -1);
                    if (flag)
                    {
                        HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=\"" + FileName + "\"");
                    }
                    else
                    {
                        HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + FileName);
                    }
                    HttpContext.Current.Response.AddHeader("Content-Length", num2.ToString());
                    while (num2 > 0L)
                    {
                        flag = HttpContext.Current.Response.IsClientConnected;
                        if (flag)
                        {
                            int num3 = fileStream.Read(array, 0, Convert.ToInt32(num));
                            HttpContext.Current.Response.OutputStream.Write(array, 0, num3);
                            HttpContext.Current.Response.Flush();
                            HttpContext.Current.Response.Clear();
                            num2 -= unchecked((long)num3);
                        }
                        else
                        {
                            num2 = -1L;
                        }
                    }
                }
                catch (Exception expr_183)
                {
                    ProjectData.SetProjectError(expr_183);
                    Exception ex = expr_183;
                    HttpContext.Current.Response.Write("Error:" + ex.Message);
                    ProjectData.ClearProjectError();
                }
                finally
                {
                    bool flag = fileStream != null;
                    if (flag)
                    {
                        fileStream.Close();
                    }
                    HttpContext.Current.Response.Close();
                }
            }
        }
        public static void DownLoadFile(string filePath, string fileName, string ContentType)
        {
            long num = 204800L;
            checked
            {
                byte[] array = new byte[(int)(num - 1L) + 1];
                FileStream fileStream = null;
                try
                {
                    fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                    long num2 = fileStream.Length;
                    bool flag = HttpContext.Current.Request.UserAgent.ToLower().IndexOf("msie") > -1;
                    if (flag)
                    {
                        fileName = StringHandling.String.ToHexString(fileName);
                    }
                    HttpContext.Current.Response.ContentType = ContentType;
                    flag = (HttpContext.Current.Request.UserAgent.ToLower().IndexOf("firefox") > -1);
                    if (flag)
                    {
                        HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=\"" + fileName + "\"");
                    }
                    else
                    {
                        HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
                    }
                    HttpContext.Current.Response.AddHeader("Content-Length", num2.ToString());
                    while (num2 > 0L)
                    {
                        flag = HttpContext.Current.Response.IsClientConnected;
                        if (flag)
                        {
                            int num3 = fileStream.Read(array, 0, Convert.ToInt32(num));
                            HttpContext.Current.Response.OutputStream.Write(array, 0, num3);
                            HttpContext.Current.Response.Flush();
                            array = new byte[(int)(num - 1L) + 1];
                            num2 -= unchecked((long)num3);
                        }
                        else
                        {
                            num2 = -1L;
                        }
                    }
                }
                catch (Exception expr_171)
                {
                    ProjectData.SetProjectError(expr_171);
                    Exception ex = expr_171;
                    throw ex;
                }
                finally
                {
                    bool flag = fileStream != null;
                    if (flag)
                    {
                        fileStream.Close();
                    }
                    HttpContext.Current.Response.Close();
                }
            }
        }
    }
}
