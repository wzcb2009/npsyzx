using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Wzsckj.com.Common.WebImagePackage
{
    public sealed class ImgCmpsFactory
    {
        private ImgCmpsFactory()
        {
        }
        public static Bitmap cmpsImgByWidth(Bitmap oldImg, int width)
        {
            int height = checked((int)Math.Round(Math.Truncate(unchecked((double)oldImg.Height * ((double)width / (double)oldImg.Width)))));
            Bitmap result;
            try
            {
                Bitmap resizeImageByRealSize = ImgCmpsFactory.getResizeImageByRealSize(oldImg, width, height);
                result = resizeImageByRealSize;
            }
            catch (Exception arg_31_0)
            {
                //ProjectData.SetProjectError(arg_31_0);
                result = null;
              //  ProjectData.ClearProjectError();
            }
            return result;
        }
        public static Bitmap cmpsImgByHeight(Bitmap oldImg, int height)
        {
            int width = checked((int)Math.Round(Math.Truncate(unchecked((double)oldImg.Width * ((double)height / (double)oldImg.Height)))));
            Bitmap result;
            try
            {
                Bitmap resizeImageByRealSize = ImgCmpsFactory.getResizeImageByRealSize(oldImg, width, height);
                result = resizeImageByRealSize;
            }
            catch (Exception arg_31_0)
            {
             //   ProjectData.SetProjectError(arg_31_0);
                result = null;
                //ProjectData.ClearProjectError();
            }
            return result;
        }
        private static Bitmap getResizeImageByRealSize(Bitmap oldImg, int width, int height)
        {
            bool flag = oldImg == null;
            Bitmap result;
            if (flag)
            {
                result = null;
            }
            else
            {
                try
                {
                    Bitmap bitmap = new Bitmap(width, height);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    graphics.InterpolationMode = InterpolationMode.High;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.Clear(Color.Transparent);
                    Graphics arg_67_0 = graphics;
                    Rectangle rectangle = new Rectangle(0, 0, width, height);
                    Rectangle arg_67_2 = rectangle;
                    Rectangle srcRect = new Rectangle(0, 0, oldImg.Width, oldImg.Height);
                    arg_67_0.DrawImage(oldImg, arg_67_2, srcRect, GraphicsUnit.Pixel);
                    result = bitmap;
                }
                catch (Exception expr_73)
                {
                    //ProjectData.SetProjectError(expr_73);
                    result = null;
                   // ProjectData.ClearProjectError();
                }
            }
            return result;
        }
    }
}
