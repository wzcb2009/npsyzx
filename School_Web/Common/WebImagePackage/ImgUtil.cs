using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace Wzsckj.com.Common.WebImagePackage
{
    public sealed class ImgUtil
    {
        private ImgUtil()
        {
        }
        public static Bitmap IsImg(string FileName)
        {
            bool flag = string.IsNullOrEmpty(FileName);
            Bitmap result;
            if (flag)
            {
                result = null;
            }
            else
            {
                try
                {
                    Bitmap bitmap = (Bitmap)Image.FromFile(FileName);
                    result = bitmap;
                }
                catch (Exception expr_25)
                {
                      
                    result = null;
                    
                }
            }
            return result;
        }
        public static Bitmap IsImg(Stream FileStream)
        {
            bool flag = FileStream == null;
            Bitmap result;
            if (flag)
            {
                result = null;
            }
            else
            {
                try
                {
                    Bitmap bitmap = (Bitmap)Image.FromStream(FileStream);
                    result = bitmap;
                }
                catch (ArgumentException expr_23)
                {
                    //ProjectData.SetProjectError(expr_23);
                    result = null;
                   // ProjectData.ClearProjectError();
                }
            }
            return result;
        }
    }
}
