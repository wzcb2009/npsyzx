using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Model;
using StringHandling;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Xml;
namespace Wzsckj.com.Common
{
    public class FileHelper
    {
        [DebuggerNonUserCode]
        public FileHelper()
        {
        }
        private void CreateFolder(string FolderPath)
        {
            bool flag = !Directory.Exists(FolderPath);
            if (flag)
            {
                Directory.CreateDirectory(FolderPath);
            }
        }
        private string GetFileExt(string FullPath)
        {
            bool flag = Operators.CompareString(FullPath, "", false) != 0;
            string result;
            if (flag)
            {
                result = FullPath.Substring(checked(FullPath.LastIndexOf('.') + 1)).ToLower();
            }
            else
            {
                result = "";
            }
            return result;
        }
        public static string file_size(int filelength)
        {
            bool flag = filelength > 1048576;
            string result;
            if (flag)
            {
                result = Conversions.ToString(Math.Round((double)filelength / 1048576.0, 2)) + "M";
            }
            else
            {
                flag = (filelength > 1024);
                if (flag)
                {
                    result = Conversions.ToString(Math.Round((double)filelength / 1024.0, 2)) + "K";
                }
                else
                {
                    result = Conversions.ToString(Math.Round(new decimal(filelength), 2)) + "B";
                }
            }
            return result;
        }
        public static string fileIcon(string ext)
        {
            bool flag = Operators.CompareString(ext, "ppt", false) == 0 || Operators.CompareString(ext, "pptx", false) == 0;
            string result;
            if (flag)
            {
                result = "powerpoint";
            }
            else
            {
                flag = (Operators.CompareString(ext, "pdf", false) == 0 || Operators.CompareString(ext, "zip", false) == 0);
                if (flag)
                {
                    result = ext;
                }
                else
                {
                    flag = (Operators.CompareString(ext, "doc", false) == 0 || Operators.CompareString(ext, "docx", false) == 0);
                    if (flag)
                    {
                        result = "word";
                    }
                    else
                    {
                        flag = (Operators.CompareString(ext, "xls", false) == 0 || Operators.CompareString(ext, "xlsx", false) == 0);
                        if (flag)
                        {
                            result = "excel";
                        }
                        else
                        {
                            flag = (Operators.CompareString(ext, "rar", false) == 0);
                            if (flag)
                            {
                                result = "zip";
                            }
                            else
                            {
                                result = "libreoffice";
                            }
                        }
                    }
                }
            }
            return result;
        }
        public static FileProperty upload(HttpPostedFile jpeg_image_upload, string uploadPath = "../upfiles")
        {
            FileProperty fileProperty = default(FileProperty);
            bool flag = jpeg_image_upload == null;
            checked
            {
                FileProperty result;
                if (flag)
                {
                    result = fileProperty;
                }
                else
                {
                    flag = (jpeg_image_upload.ContentLength == 0);
                    if (flag)
                    {
                        result = fileProperty;
                    }
                    else
                    {
                        string fileName = jpeg_image_upload.FileName;
                        int contentLength = jpeg_image_upload.ContentLength;
                        string text = fileName.Substring(fileName.LastIndexOf(".") + 1);
                        string text2 = Conversions.ToString(DateAndTime.Now);
                        VBMath.Randomize();
                        int value = (int)Math.Round((double)Conversion.Int(unchecked(99999f * VBMath.Rnd() + 10000f)));
                        string str = string.Concat(new string[]
						{
							Conversions.ToString(DateAndTime.Year(Conversions.ToDate(text2))),
							Conversions.ToString(DateAndTime.Month(Conversions.ToDate(text2))),
							Conversions.ToString(DateAndTime.Day(Conversions.ToDate(text2))),
							Conversions.ToString(DateAndTime.Hour(Conversions.ToDate(text2))),
							Conversions.ToString(DateAndTime.Minute(Conversions.ToDate(text2))),
							Conversions.ToString(DateAndTime.Second(Conversions.ToDate(text2))),
							Conversions.ToString(value)
						});
                        text2 = str + "." + text;
                        fileProperty.Ext = text;
                        fileProperty.Filename = fileName;
                        fileProperty.NewFilename = text2;
                        fileProperty.FileSize = jpeg_image_upload.ContentLength;
                        fileProperty.Path = uploadPath + "/" + text2;
                        jpeg_image_upload.SaveAs(HttpContext.Current.Server.MapPath(fileProperty.Path));
                        result = fileProperty;
                    }
                }
                return result;
            }
        }
        public static void File_DownloadExt(string FilePath, string title)
        {
            title += Path.GetExtension(FilePath);
            string text = HttpContext.Current.Server.MapPath(FilePath);
            FileInfo fileInfo = new FileInfo(text);
            bool flag = fileInfo.Exists;
            if (flag)
            {
                HttpContext.Current.Response.Clear();
                string extension = Path.GetExtension(FilePath);
                string text2 = title;
                flag = HttpContext.Current.Request.UserAgent.ToLower().Contains("msie");
                if (flag)
                {
                    text2 = StringHandling.String.ToHexString(text2);
                }
                FileDownHelper.DownLoadFile(text, text2, StringHandling.String.GetMimeType(extension));
            }
            else
            {
                HttpContext.Current.Response.Write("文件不存在. ");
            }
        }
        public static void File_Download(string FilePath, string title)
        {
            title += Path.GetExtension(FilePath);
            bool flag = File.Exists(FilePath);
            if (flag)
            {
                HttpContext.Current.Response.Clear();
                string extension = Path.GetExtension(FilePath);
                string text = title;
                flag = HttpContext.Current.Request.UserAgent.ToLower().Contains("msie");
                if (flag)
                {
                    text = StringHandling.String.ToHexString(text);
                }
                FileDownHelper.DownLoadFile(FilePath, text, StringHandling.String.GetMimeType(extension));
            }
            else
            {
                HttpContext.Current.Response.Write("文件不存在. ");
            }
        }
        public static void ToExcel(string filename, string tablestr)
        {
            HttpContext.Current.Response.Clear();
            HttpContext.Current.Response.Write("<style>td  { border:.5pt solid black; }</style>");
            HttpContext.Current.Response.Charset = "UTF-8";
            HttpContext.Current.Response.ContentEncoding = Encoding.Default;
            HttpContext.Current.Response.ContentType = "application/octet-stream";
            bool flag = !filename.Contains(".xls");
            if (flag)
            {
                filename += ".xls";
            }
            flag = (HttpContext.Current.Request.UserAgent.ToLower().IndexOf("msie") > -1);
            if (flag)
            {
                filename = HttpUtility.UrlEncode(filename);
            }
            flag = (HttpContext.Current.Request.UserAgent.ToLower().IndexOf("firefox") > -1);
            if (flag)
            {
                HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=\"" + filename + "\"");
            }
            else
            {
                HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + filename);
            }
            StringWriter stringWriter = new StringWriter();
            stringWriter.Write(tablestr);
            HttpContext.Current.Response.Write(stringWriter.ToString());
            HttpContext.Current.Response.End();
        }
        public static string VideoPlayerCK(FileList file, string ParentPath = "")
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = Operators.CompareString(SafeData.s_string(file.IndexImagePath), "", false) == 0;
            if (flag)
            {
                file.IndexImagePath = "images/video.jpg";
            }
            flag = file.Path.Contains("../");
            if (flag)
            {
                file.Path = file.Path.Replace("../", ParentPath);
            }
            else
            {
                file.Path = ParentPath + file.Path;
            }
            flag = file.IndexImagePath.Contains("../");
            if (flag)
            {
                file.IndexImagePath = file.IndexImagePath.Replace("../", ParentPath);
            }
            else
            {
                file.IndexImagePath = ParentPath + file.IndexImagePath;
            }
            stringBuilder.AppendLine("<div id=\"video\" style=\"z-index: 100;width:600px;height:400px;\"><div id=\"a1\"></div></div> ");
            stringBuilder.AppendLine("<script type=\"text/javascript\">");
            stringBuilder.AppendLine("var flashvars={");
            stringBuilder.AppendLine("f:      'http://jxxm.wzu.edu.cn/open/" + file.Path + "',");
            stringBuilder.AppendLine("c:0,");
            stringBuilder.AppendLine("b:1");
            stringBuilder.AppendLine("};");
            stringBuilder.AppendLine("var params={bgcolor:'#FFF',allowFullScreen:true,allowScriptAccess:'always'};");
            stringBuilder.AppendLine("CKobject.embedSWF('ckplayer/ckplayer.swf','a1','ckplayer_a1','990','600',flashvars,params);");
            stringBuilder.AppendLine("</script>   ");
            return stringBuilder.ToString();
        }
        public static string VideoPlayer(FileList file, string ParentPath = "", int width = 600, int height = 480)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = Operators.CompareString(SafeData.s_string(file.IndexImagePath), "", false) == 0;
            if (flag)
            {
                file.IndexImagePath = "images/video.jpg";
            }
            flag = file.Path.Contains("../");
            if (flag)
            {
                file.Path = file.Path.Replace("../", ParentPath);
            }
            else
            {
                file.Path = ParentPath + file.Path;
            }
            flag = file.IndexImagePath.Contains("../");
            if (flag)
            {
                file.IndexImagePath = file.IndexImagePath.Replace("../", ParentPath);
            }
            else
            {
                file.IndexImagePath = ParentPath + file.IndexImagePath;
            }
            flag = File.Exists(HttpContext.Current.Server.MapPath(file.Path.Replace(".mp4", ".flv")));
            if (flag)
            {
                file.Path = file.Path.Replace(".mp4", ".flv");
            }
            stringBuilder.AppendLine("    <center>\t<div id=\"mediaplayer" + Conversions.ToString(file.FileId) + "\"></div></center> ");
            stringBuilder.AppendLine("<script type=\"text/javascript\">");
            stringBuilder.AppendLine("jwplayer(\"mediaplayer" + Conversions.ToString(file.FileId) + "\").setup({");
            stringBuilder.AppendLine("file: \"" + file.Path + "\",");
            stringBuilder.AppendLine(" image: \"" + file.IndexImagePath + "\"");
            stringBuilder.AppendLine(string.Concat(new string[]
			{
				",'width':'",
				Conversions.ToString(width),
				"','height':'",
				Conversions.ToString(height),
				"'});"
			}));
            stringBuilder.AppendLine("</script>   ");
            return stringBuilder.ToString();
        }
        public static string CKPlayer(FileList file, string ParentPath = "", int width = 600, int height = 480)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = Operators.CompareString(SafeData.s_string(file.IndexImagePath), "", false) == 0;
            if (flag)
            {
                file.IndexImagePath = "images/video.jpg";
            }
            flag = file.Path.Contains("../");
            if (flag)
            {
                file.Path = file.Path.Replace("../", ParentPath);
            }
            else
            {
                file.Path = ParentPath + file.Path;
            }
            flag = file.IndexImagePath.Contains("../");
            if (flag)
            {
                file.IndexImagePath = file.IndexImagePath.Replace("../", ParentPath);
            }
            else
            {
                file.IndexImagePath = ParentPath + file.IndexImagePath;
            }
            stringBuilder.AppendLine(" <div id=\"a1" + Conversions.ToString(file.FileId) + "\"></div>");
            stringBuilder.AppendLine(" <script type=\"text/javascript\">");
            stringBuilder.AppendLine(" var flashvars" + Conversions.ToString(file.FileId) + " = {");
            stringBuilder.AppendLine(" f:      '" + file.Path + "',");
            stringBuilder.AppendLine(" c: 0,");
            stringBuilder.AppendLine(" loaded:  'loadedHandler'");
            stringBuilder.AppendLine(" };");
            stringBuilder.AppendLine(string.Concat(new string[]
			{
				"  var video",
				Conversions.ToString(file.FileId),
				" = ['",
				file.Path,
				"->video/mp4'];"
			}));
            stringBuilder.AppendLine(string.Concat(new string[]
			{
				" CKobject.embed('Plugins/ckplayer6.6/ckplayer/ckplayer.swf', 'a1",
				Conversions.ToString(file.FileId),
				"', 'ckplayer_a1",
				Conversions.ToString(file.FileId),
				"', '990', '480', false, flashvars",
				Conversions.ToString(file.FileId),
				", video",
				Conversions.ToString(file.FileId),
				");"
			}));
            stringBuilder.AppendLine(" </script>");
            return stringBuilder.ToString();
        }
        public static string CuPlayer(FileList file, string ParentPath = "", int width = 600, int height = 480)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = Operators.CompareString(SafeData.s_string(file.IndexImagePath), "", false) == 0;
            if (flag)
            {
                file.IndexImagePath = "images/video.jpg";
            }
            flag = file.Path.Contains("../");
            if (flag)
            {
                file.Path = file.Path.Replace("../", ParentPath);
            }
            else
            {
                file.Path = ParentPath + file.Path;
            }
            flag = file.IndexImagePath.Contains("../");
            if (flag)
            {
                file.IndexImagePath = file.IndexImagePath.Replace("../", ParentPath);
            }
            else
            {
                file.IndexImagePath = ParentPath + file.IndexImagePath;
            }
            stringBuilder.AppendLine(" <div class=\"video\" id=\"CuPlayer" + Conversions.ToString(file.FileId) + "\" ></div>");
            stringBuilder.AppendLine(" <script type=\"text/javascript\">");
            stringBuilder.AppendLine("  var vID = 'CuPlayer" + Conversions.ToString(file.FileId) + "';");
            stringBuilder.AppendLine("var vWidth = '100%'; //播放器宽度");
            stringBuilder.AppendLine("var vHeight = 400; //播放器高度");
            stringBuilder.AppendLine("var vFile = 'CuPlayer/CuSunV2set.xml'; //播放器配置文件[可以设广告参数]");
            stringBuilder.AppendLine("var vPlayer = 'CuPlayer/player.swf?v=2.5'; //播放器文件");
            stringBuilder.AppendLine("var vPic = '../" + file.IndexImagePath + "'; //视频缩略图");
            stringBuilder.AppendLine("var vCssurl = 'CuPlayer/images/mini.css'; //移动端CSS");
            stringBuilder.AppendLine("var vMp4url = '../" + file.Path + "';");
            stringBuilder.AppendLine(" </script>");
            return stringBuilder.ToString();
        }
        public static string VideoPlayer(DataTable dt, string parentpath = "")
        {
            bool flag = dt == null;
            string result;
            if (flag)
            {
                result = "";
            }
            else
            {
                flag = (dt.Rows.Count == 1);
                if (flag)
                {
                    FileList fileList = new FileList();
                    fileList = Mapper.ToEntity<FileList>(dt.Rows[0], fileList);
                    result = FileHelper.VideoPlayer(fileList, parentpath, 600, 480);
                }
                else
                {
                    flag = (dt.Rows.Count == 0);
                    if (flag)
                    {
                        result = "";
                    }
                    else
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.AppendLine("   <center> \t<div id=\"mediaplayer\"></div></center>");
                        stringBuilder.AppendLine("<script type=\"text/javascript\">");
                        stringBuilder.AppendLine("jwplayer(\"mediaplayer\").setup({");
                        StringBuilder stringBuilder2 = new StringBuilder();
                        IEnumerator enumerator = null;
                        try
                        {
                              enumerator = dt.Rows.GetEnumerator();
                            while (enumerator.MoveNext())
                            {
                                DataRow dataRow = (DataRow)enumerator.Current;
                                string text = SafeData.s_string(RuntimeHelpers.GetObjectValue(dataRow["IndexImagePath"]));
                                flag = (Operators.CompareString(text, "", false) == 0);
                                if (flag)
                                {
                                    text = parentpath + "images/video.jpg";
                                }
                                int num = Conversions.ToInteger(dataRow["fileid"]);
                                string text2 = Conversions.ToString(dataRow["title"]);
                                string text3 = Conversions.ToString(dataRow["path"]);
                                string text4 = Conversions.ToString(dataRow["content"]);
                                text3 = text3.Replace("../", parentpath);
                                stringBuilder2.AppendLine(string.Concat(new string[]
								{
									",{file:\"",
									text3,
									"\",image:\"",
									text,
									"\",title:\"",
									text2,
									"\",description:\"",
									text4,
									"\"}"
								}));
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
                        flag = (stringBuilder2.Length > 0);
                        if (flag)
                        {
                            stringBuilder2.Remove(0, 1);
                        }
                        stringBuilder.AppendLine(" playlist: [" + stringBuilder2.ToString() + "],");
                        stringBuilder.AppendLine(" listbar: {position:  'right', size: 280 },");
                        stringBuilder.AppendLine(" width: 700,");
                        stringBuilder.AppendLine("height: 240");
                        stringBuilder.AppendLine("});");
                        stringBuilder.AppendLine("</script>   ");
                        result = stringBuilder.ToString();
                    }
                }
            }
            return result;
        }
        public static string SwfPlayer(DataTable dt)
        {
            StringBuilder stringBuilder = new StringBuilder();
            IEnumerator enumerator = null;
            try
            {
                  enumerator = dt.Rows.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    DataRow dataRow = (DataRow)enumerator.Current;
                    string right = Strings.Replace(Conversions.ToString(dataRow["path"]), "../", "", 1, -1, CompareMethod.Binary);
                    stringBuilder.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" <div  class='flashpager'  id=\"swf", dataRow["fileid"]), "\"></div><script>swfobject.embedSWF(\""), right), "\", \"swf"), dataRow["fileid"]), "\", \"100%\", \"600\", \"9.0.0\", \"Plugins/swfobject/expressInstall.swf\");</script>")));
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
            return stringBuilder.ToString();
        }
        public static string Attachmentlist(DataTable dt)
        {
            StringBuilder stringBuilder = new StringBuilder();
            IEnumerator enumerator = null;
            try
            {
                  enumerator = dt.Rows.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    DataRow dataRow = (DataRow)enumerator.Current;
                    stringBuilder.AppendLine(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("<div id=\"file", dataRow["fileid"]), "\" class=\"media\"><a class=\"pull-left\" href=\"#\"><img class=\"media-object\"  src=\"file/images/"), Strings.Replace(Conversions.ToString(dataRow["ext"]), ".", "", 1, -1, CompareMethod.Binary)), ".jpg\"></a><div class=\"media-body\"><h4 class=\"media-heading\"><a class='title' title='下载文件'  href='file/filedown.aspx?fileid="), dataRow["fileid"]), "'>"), dataRow["title"]), "."), dataRow["ext"]), "</a></h4>上传时间："), dataRow["pubdate"]), " </div></div> ")));
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
            return stringBuilder.ToString();
        }
        public static object RSS(DataTable dt, RSS.Channel rssChannel)
        {
            HttpContext.Current.Response.ContentType = "text/xml";
            HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
            xmlTextWriter.WriteStartElement("rss");
            xmlTextWriter.WriteAttributeString("version", "2.0");
            xmlTextWriter.WriteStartElement("channel");
            xmlTextWriter.WriteElementString("title", rssChannel.title);
            xmlTextWriter.WriteElementString("link", rssChannel.link);
            xmlTextWriter.WriteElementString("description", rssChannel.description);
            IEnumerator enumerator = null;
            try
            {
                  enumerator = dt.Rows.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    DataRow dataRow = (DataRow)enumerator.Current;
                    xmlTextWriter.WriteStartElement("item");
                    xmlTextWriter.WriteElementString("title", dataRow["title"].ToString());
                    xmlTextWriter.WriteElementString("link", string.Format("http://myWebSite.com/webshow.aspx?id={0}", RuntimeHelpers.GetObjectValue(dataRow["ID"])));
                    xmlTextWriter.WriteElementString("description", dataRow["content"].ToString());
                    xmlTextWriter.WriteElementString("author", dataRow["author"].ToString());
                    xmlTextWriter.WriteElementString("pubDate", Conversions.ToDate(dataRow["pubdate"]).ToString("r"));
                    xmlTextWriter.WriteEndElement();
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
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            HttpContext.Current.Response.Write(stringWriter.ToString());
            xmlTextWriter.Close();
            object result= new object ();
            return result;
        }
        public static object JwPlayerRSS(DataTable dt, JwPlayer.Item rssChannel)
        {
            HttpContext.Current.Response.ContentType = "text/xml";
            HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
            StringWriter stringWriter = new StringWriter();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(stringWriter);
            xmlTextWriter.WriteStartElement("rss");
            xmlTextWriter.WriteAttributeString("version", "2.0");
            xmlTextWriter.WriteStartElement("channel");
            xmlTextWriter.WriteStartElement("item");
            xmlTextWriter.WriteElementString("title", rssChannel.title);
            xmlTextWriter.WriteElementString("description", rssChannel.description);
            xmlTextWriter.WriteElementString("jwplayer:image", rssChannel.image);
            IEnumerator enumerator = null;
            try
            {
                  enumerator = dt.Rows.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    DataRow dataRow = (DataRow)enumerator.Current;
                    xmlTextWriter.WriteStartElement("jwplayer:source");
                    xmlTextWriter.WriteAttributeString("file", Conversions.ToString(dataRow["path"]));
                    xmlTextWriter.WriteAttributeString("label", Conversions.ToString(dataRow["title"]));
                    xmlTextWriter.WriteEndElement();
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
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            xmlTextWriter.WriteEndElement();
            HttpContext.Current.Response.Write(stringWriter.ToString());
            xmlTextWriter.Close();
            object result = new object();
            return result;
        }
        public static string ImgsCarousel(DataTable dt)
        {
            bool flag = dt == null;
            checked
            {
                string result="";
                if (flag)
                {
                    result = "";
                }
                else
                {
                    flag = (dt.Rows.Count == 1);
                    if (flag)
                    {
                        FileList fileList = (FileList)Mapper.ToEntity(dt.Rows[0], typeof(FileList));
                        result = string.Concat(new string[]
						{
							" <div class=\"row-fluid\">   <ul class=\"thumbnails\">    <li class=\"span12\">    <div class=\"thumbnail\">    <img src=\"",
							fileList.Path,
							"\" alt=\"\"></div> </li>   <li class=\"span12\"><div>  <h3>",
							fileList.Title,
							"</h3>    <p>",
							fileList.Content,
							"</p>    </div>    </li>  </ul></div>"
						});
                    }
                    else
                    {
                        flag = (dt.Rows.Count > 1);
                        if (flag)
                        {
                            StringBuilder stringBuilder = new StringBuilder();
                            StringBuilder stringBuilder2 = new StringBuilder();
                            StringBuilder stringBuilder3 = new StringBuilder();
                            stringBuilder.AppendLine("<div id=\"myCarousel\" class=\"carousel slide\">");
                            stringBuilder2.AppendLine("<ol class=\"carousel-indicators\">");
                            stringBuilder3.AppendLine(" <div class=\"carousel-inner\">");
                            int num = 0;
                            IEnumerator enumerator = null;
                            try
                            {
                                  enumerator = dt.Rows.GetEnumerator();
                                while (enumerator.MoveNext())
                                {
                                    DataRow adaptedRow = (DataRow)enumerator.Current;
                                    FileList fileList = (FileList)Mapper.ToEntity(adaptedRow, typeof(FileList));
                                    flag = (num == 0);
                                    string text;
                                    if (flag)
                                    {
                                        text = "class=\"active\"";
                                    }
                                    else
                                    {
                                        text = "";
                                    }
                                    stringBuilder2.AppendLine(string.Concat(new string[]
									{
										"<li data-target=\"#myCarousel\" data-slide-to=\"",
										Conversions.ToString(num),
										"\" ",
										text,
										"></li>"
									}));
                                    stringBuilder3.AppendLine(string.Concat(new string[]
									{
										"<div class=\"item\">  <img src=\"",
										fileList.Path,
										"\"   alt=\"\">  <div class=\"carousel-caption\"><h4>",
										fileList.Title,
										" </h4><p> ",
										fileList.Content,
										" </p> </div></div>"
									}));
                                    num++;
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
                            stringBuilder3.AppendLine("</div>");
                            stringBuilder2.AppendLine("</ol>");
                            stringBuilder.AppendLine(stringBuilder2.ToString());
                            stringBuilder.AppendLine(stringBuilder3.ToString());
                            stringBuilder.AppendLine("<a class=\"carousel-control left\" href=\"#myCarousel\" data-slide=\"prev\">&lsaquo;</a>");
                            stringBuilder.AppendLine("<a class=\"carousel-control right\" href=\"#myCarousel\" data-slide=\"next\">&rsaquo;</a>");
                            stringBuilder.AppendLine("</div>");
                            result = stringBuilder.ToString();
                        }
                    }
                }
                return result;
            }
        }
        public static string files(DataTable dt, string parentpath)
        {
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            DataTable dataTable = dt.Clone();
            DataTable dataTable2 = dt.Clone();
            DataTable dataTable3 = dt.Clone();
            DataTable dataTable4 = dt.Clone();
            IEnumerator enumerator = null;
            try
            {
                  enumerator = dt.Rows.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    DataRow dataRow = (DataRow)enumerator.Current;
                    bool flag = Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(dataRow["ext"], "flv", false), Operators.CompareObjectEqual(dataRow["ext"], "mp4", false)));
                    if (flag)
                    {
                        dataTable.ImportRow(dataRow);
                    }
                    else
                    {
                        flag = Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectEqual(dataRow["ext"], "jpg", false), Operators.CompareObjectEqual(dataRow["ext"], "png", false)), Operators.CompareObjectEqual(dataRow["ext"], "gif", false)));
                        if (flag)
                        {
                            dataTable2.ImportRow(dataRow);
                        }
                        else
                        {
                            flag = Operators.ConditionalCompareObjectEqual(dataRow["ext"], "swf", false);
                            if (flag)
                            {
                                dataTable3.ImportRow(dataRow);
                            }
                            else
                            {
                                dataTable4.ImportRow(dataRow);
                            }
                        }
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
            stringBuilder.AppendLine(FileHelper.VideoPlayer(dataTable, parentpath));
            stringBuilder.AppendLine(FileHelper.SwfPlayer(dataTable3));
            stringBuilder.AppendLine(FileHelper.ImgsCarousel(dataTable2));
            stringBuilder.AppendLine(FileHelper.Attachmentlist(dataTable4));
            return stringBuilder.ToString();
        }
        public static string mp4Player(int fileid, string title, string path, string img)
        {
            StringBuilder stringBuilder = new StringBuilder();
            path = path.Replace("../", "");
            stringBuilder.AppendLine(" <div id=\"a1" + Conversions.ToString(fileid) + "\"></div>");
            stringBuilder.AppendLine(" <script type=\"text/javascript\">");
            stringBuilder.AppendLine(" var flashvars" + Conversions.ToString(fileid) + " = {");
            stringBuilder.AppendLine(" f:      '" + path + "',");
            stringBuilder.AppendLine(" c: 0,");
            stringBuilder.AppendLine(" loaded:  'loadedHandler'");
            stringBuilder.AppendLine(" };");
            stringBuilder.AppendLine(string.Concat(new string[]
			{
				"  var video",
				Conversions.ToString(fileid),
				" = ['",
				path,
				"->video/mp4'];"
			}));
            stringBuilder.AppendLine(string.Concat(new string[]
			{
				" CKobject.embed('Plugins/ckplayer6.6/ckplayer/ckplayer.swf', 'a1",
				Conversions.ToString(fileid),
				"', 'ckplayer_a1",
				Conversions.ToString(fileid),
				"', '600', '400', false, flashvars",
				Conversions.ToString(fileid),
				", video",
				Conversions.ToString(fileid),
				");"
			}));
            stringBuilder.AppendLine(" </script>");
            return stringBuilder.ToString();
        }
        public static string mp3Player(int fileid, string title, string path, string img)
        {
            StringBuilder stringBuilder = new StringBuilder();
            path = path.Replace("../", "");
            stringBuilder.Append(string.Concat(new string[]
			{
				"<object type='application/x-shockwave-flash' data='Plugins/15DewPlayer/dewplayer.swf?mp3=",
				path,
				"' width='200' height='20' id='dewplayer",
				Conversions.ToString(fileid),
				"'><param name='wmode' value='transparent' /><param name='movie' value='Plugins/15DewPlayer/dewplayer.swf?mp3=",
				path,
				"' /></object>"
			}));
            return stringBuilder.ToString();
        }
        public static string FlvPlayer(int fileid, string title, string path, string img)
        {
            StringBuilder stringBuilder = new StringBuilder();
            path = path.Replace("../", "");
            stringBuilder.AppendLine(string.Concat(new string[]
			{
				"   \t<div id=\"mediaplayer",
				Conversions.ToString(fileid),
				"\">",
				title,
				"</div>"
			}));
            stringBuilder.AppendLine("<script type=\"text/javascript\">");
            stringBuilder.AppendLine("jwplayer(\"mediaplayer" + Conversions.ToString(fileid) + "\").setup({");
            stringBuilder.AppendLine(" width: 400,");
            stringBuilder.AppendLine("height: 300,");
            stringBuilder.AppendLine("file: \"" + path + "\",");
            stringBuilder.AppendLine(" image: \"" + img + "\"");
            stringBuilder.AppendLine("});");
            stringBuilder.AppendLine("</script>   ");
            return stringBuilder.ToString();
        }
    }
}
