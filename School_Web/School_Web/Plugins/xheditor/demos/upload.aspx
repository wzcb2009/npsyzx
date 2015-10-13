<%@ Page Language="C#" AutoEventWireup="true" CodePage="65001" %>
<%@ Import namespace="System" %>
<%@ Import namespace="System.Collections" %>
<%@ Import namespace="System.Configuration" %>
<%@ Import namespace="System.Data" %>
<%@ Import namespace="System.Web" %>
<%@ Import namespace="System.Web.Security" %>
<%@ Import namespace="System.Web.UI" %>
<%@ Import namespace="System.Web.UI.HtmlControls" %>
<%@ Import namespace="System.Web.UI.WebControls" %>
<%@ Import namespace="System.Web.UI.WebControls.WebParts" %>
<%@ Import namespace="System.IO" %>


<script runat="server">
    /*
 * upload demo for c# .net 2.0
 * 
 * @requires xhEditor
 * @author Jediwolf<jediwolf@gmail.com>
 * @licence LGPL(http://www.opensource.org/licenses/lgpl-license.php)
 * 
 * @Version: 0.1.3 (build 100504)
 * 
 * 注1：本程序仅为演示用，请您务必根据自己需求进行相应修改，或者重开发
 * 注2：本程序将HTML5上传与普通POST上传转换为byte类型统一处理
 * 
 */

protected void Page_Load(object sender, EventArgs e)
{
    Response.Charset = "UTF-8";
    if (Session["username"] == "") {
        Response.Write("{'err':'错误','msg':'登录超时'}");
        Response.End();
    }
	// 初始化一大堆变量
	string inputname = "filedata";//表单文件域name
    string attachdir = "../../upfiles";     // 上传文件保存路径，结尾不要带/
    int dirtype = 1;                 // 1:按天存入目录 2:按月存入目录 3:按扩展名存目录  建议使用按天存
    int maxattachsize = 2097152;     // 最大上传大小，默认是2M
    string upext = "txt,rar,zip,jpg,jpeg,gif,png,swf,wmv,avi,wma,mp3,mid";    // 上传扩展名
    int msgtype = 2;                 //返回上传参数的格式：1，只返回url，2，返回参数数组
	string immediate = Request.QueryString["immediate"];//立即上传模式，仅为演示用
    byte[] file;                     // 统一转换为byte数组处理
    string localname = "";
    string disposition = Request.ServerVariables["HTTP_CONTENT_DISPOSITION"];

    string err = "";
    string msg = "''";
    
    if (disposition != null)
    {
        // HTML5上传
        file = Request.BinaryRead(Request.TotalBytes);
        localname = Regex.Match(disposition, "filename=\"(.+?)\"").Groups[1].Value;// 读取原始文件名
    }
    else 
    {        
        HttpFileCollection filecollection = Request.Files;
        HttpPostedFile postedfile = filecollection.Get(inputname);

        // 读取原始文件名
        localname = postedfile.FileName;
        // 初始化byte长度.
        file = new Byte[postedfile.ContentLength];
        
        // 转换为byte类型
        System.IO.Stream stream = postedfile.InputStream;
        stream.Read(file, 0, postedfile.ContentLength);
        stream.Close();

        filecollection = null;
    }
    
    if (file.Length == 0)err = "无数据提交";
    else
    {
        if (file.Length > maxattachsize)err = "文件大小超过" + maxattachsize + "字节";
        else
        {
            string attach_dir, attach_subdir, filename, extension, target;

            // 取上载文件后缀名
            extension = GetFileExt(localname);
            FileExtension[] fe = { FileExtension.GIF, FileExtension.JPG, FileExtension.PNG };
            if (FileValidation.IsAllowedExtension(file, fe) == false) {
                err = "上传文件扩展名必需为：" + upext;
            }
            //if (("," + upext + ",").IndexOf("," + extension + ",") < 0)err = "上传文件扩展名必需为：" + upext;
            else
            {
                switch (dirtype)
                {
                    case 2:
                        attach_subdir = "month_" + DateTime.Now.ToString("yyMM");
                        break;
                    case 3:
                        attach_subdir = "ext_" + extension;
                        break;
                    default:
                        attach_subdir = "day_" + DateTime.Now.ToString("yyMMdd");
                        break;
                }
                attach_dir = attachdir + "/" + attach_subdir + "/";

                // 生成随机文件名
                Random random = new Random(DateTime.Now.Millisecond);
                filename = DateTime.Now.ToString("yyyyMMddhhmmss") + random.Next(10000) + "." + extension;

                target = attach_dir + filename;
                try
                {
                    CreateFolder(Server.MapPath(attach_dir));

                    System.IO.FileStream fs = new System.IO.FileStream(Server.MapPath(target), System.IO.FileMode.Create, System.IO.FileAccess.Write);
                    fs.Write(file, 0, file.Length);
                    fs.Flush();
                    fs.Close();
                }
                catch (Exception ex)
                {
                    err = ex.Message.ToString();
                }

                // 立即模式判断
                if (immediate == "1") target = "!" + target;
                target = jsonString(target);
                if (msgtype == 1) msg = "'" + target + "'";
                else msg = "{'url':'" + target + "','localname':'" + jsonString(localname) + "','id':'1'}";
            }
        }
    }

    file = null;
    
    Response.Write("{'err':'" + jsonString(err) + "','msg':" + msg + "}");
}


string jsonString(string str) 
{
    str = str.Replace("\\", "\\\\");
    str = str.Replace("/", "\\/");
    str = str.Replace("'", "\\'");
    return str;
}


string GetFileExt(string FullPath) 
{
    if (FullPath != "")return FullPath.Substring(FullPath.LastIndexOf('.') + 1).ToLower();
    else return "";
}

void CreateFolder(string FolderPath)
{
    if (!System.IO.Directory.Exists(FolderPath))System.IO.Directory.CreateDirectory(FolderPath);
}
public enum FileExtension
{
    JPG = 255216,
    GIF = 7173,
    PNG = 13780,
    SWF = 6787,
    RAR = 8297,
    ZIP = 8075,
    _7Z = 55122

    // 255216 jpg;

    // 7173 gif;

    // 6677 bmp,

    // 13780 png;

    // 6787 swf

    // 7790 exe dll,

    // 8297 rar

    // 8075 zip

    // 55122 7z

    // 6063 xml

    // 6033 html

    // 239187 aspx

    // 117115 cs

    // 119105 js

    // 102100 txt

    // 255254 sql 

}

public class FileValidation
{
    public static bool IsAllowedExtension(byte[] imgArray, FileExtension[] fileEx)
    {
        MemoryStream ms = new MemoryStream(imgArray);
        System.IO.BinaryReader br = new System.IO.BinaryReader(ms);
        string fileclass = "";
        byte buffer;
        try
        {
            buffer = br.ReadByte();
            fileclass = buffer.ToString();
            buffer = br.ReadByte();
            fileclass += buffer.ToString();
        }
        catch
        {
        }
        br.Close();
        ms.Close();
        foreach (FileExtension fe in fileEx)
        {
            if (Int32.Parse(fileclass) == (int)fe)
                return true;
        }
        return false;
    }
}
   
</script>
