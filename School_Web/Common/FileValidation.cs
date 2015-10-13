using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Web;
namespace Wzsckj.com.Common
{
    public class FileValidation
    {
        [DebuggerNonUserCode]
        public FileValidation()
        {
        }
        public static bool IsAllowedExtension(HttpPostedFile fu, FileExtension[] fileEx)
        {
            int contentLength = fu.ContentLength;
            checked
            {
                byte[] buffer = new byte[contentLength - 1 + 1];
                fu.InputStream.Read(buffer, 0, contentLength);
                MemoryStream memoryStream = new MemoryStream(buffer);
                BinaryReader binaryReader = new BinaryReader(memoryStream);
                string text = "";
                try
                {
                    text = binaryReader.ReadByte().ToString();
                    text += binaryReader.ReadByte().ToString();
                }
                catch (Exception arg_62_0)
                {
                    ProjectData.SetProjectError(arg_62_0);
                    ProjectData.ClearProjectError();
                }
                binaryReader.Close();
                memoryStream.Close();
                bool result;
                for (int i = 0; i < fileEx.Length; i++)
                {
                    FileExtension fileExtension = fileEx[i];
                    bool flag = int.Parse(text) == (int)fileExtension;
                    if (flag)
                    {
                        result = true;
                        return result;
                    }
                }
                result = false;
                return result;
            }
        }
        public static int FileExtensionInt(HttpPostedFile fu)
        {
            int contentLength = fu.ContentLength;
            byte[] buffer = new byte[checked(contentLength - 1 + 1)];
            fu.InputStream.Read(buffer, 0, contentLength);
            MemoryStream memoryStream = new MemoryStream(buffer);
            BinaryReader binaryReader = new BinaryReader(memoryStream);
            string text = "";
            try
            {
                text = binaryReader.ReadByte().ToString();
                text += binaryReader.ReadByte().ToString();
            }
            catch (Exception arg_65_0)
            {
                ProjectData.SetProjectError(arg_65_0);
                ProjectData.ClearProjectError();
            }
            binaryReader.Close();
            memoryStream.Close();
            return Conversions.ToInteger(text);
        }
    }
}
