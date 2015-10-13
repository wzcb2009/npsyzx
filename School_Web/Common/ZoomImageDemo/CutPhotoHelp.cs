using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace Wzsckj.com.Common.ZoomImageDemo
{
    public class CutPhotoHelp
    {
        [DebuggerNonUserCode]
        public CutPhotoHelp()
        {
        }
        public static string SaveCutPic(string pPath, string pSavedPath, int pPartStartPointX, int pPartStartPointY, int pPartWidth, int pPartHeight, int pOrigStartPointX, int pOrigStartPointY, int imageWidth, int imageHeight)
        {
            Image image = Image.FromFile(pPath);
            string result;
            try
            {
                bool flag = image.Width == imageWidth && image.Height == imageHeight;
                if (flag)
                {
                    result = CutPhotoHelp.SaveCutPic(pPath, pSavedPath, pPartStartPointX, pPartStartPointY, pPartWidth, pPartHeight, pOrigStartPointX, pOrigStartPointY);
                }
                else
                {
                    string text = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                    string text2 = pSavedPath + "\\" + text;
                    Bitmap bitmap = CutPhotoHelp.MakeThumbnail(image, imageWidth, imageHeight);
                    Bitmap bitmap2 = new Bitmap(pPartWidth, pPartHeight);
                    Graphics graphics = Graphics.FromImage(bitmap2);
                    Point point = new Point(pPartStartPointX, pPartStartPointY);
                    Point arg_A9_1 = point;
                    Size size = new Size(pPartWidth, pPartHeight);
                    Rectangle destRect = new Rectangle(arg_A9_1, size);
                    point = new Point(pOrigStartPointX, pOrigStartPointY);
                    Point arg_CD_1 = point;
                    size = new Size(pPartWidth, pPartHeight);
                    Rectangle srcRect = new Rectangle(arg_CD_1, size);
                    Graphics graphics2 = Graphics.FromImage(bitmap2);
                    graphics2.Clear(Color.White);
                    graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics2.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.DrawImage(bitmap, destRect, srcRect, GraphicsUnit.Pixel);
                    graphics2.Dispose();
                    image.Dispose();
                    flag = File.Exists(text2);
                    if (flag)
                    {
                        File.SetAttributes(text2, FileAttributes.Normal);
                        File.Delete(text2);
                    }
                    bitmap2.Save(text2, ImageFormat.Jpeg);
                    bitmap2.Dispose();
                    bitmap.Dispose();
                    result = text;
                }
            }
            finally
            {
                bool flag = image != null;
                if (flag)
                {
                    ((IDisposable)image).Dispose();
                }
            }
            return result;
        }
        public static Bitmap MakeThumbnail(Image fromImg, int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            int width2 = fromImg.Width;
            int height2 = fromImg.Height;
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.InterpolationMode = InterpolationMode.High;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.Clear(Color.Transparent);
            Graphics arg_5B_0 = graphics;
            Rectangle rectangle = new Rectangle(0, 0, width, height);
            Rectangle arg_5B_2 = rectangle;
            Rectangle srcRect = new Rectangle(0, 0, width2, height2);
            arg_5B_0.DrawImage(fromImg, arg_5B_2, srcRect, GraphicsUnit.Pixel);
            return bitmap;
        }
        public static string SaveCutPic(string pPath, string pSavedPath, int pPartStartPointX, int pPartStartPointY, int pPartWidth, int pPartHeight, int pOrigStartPointX, int pOrigStartPointY)
        {
            string text = DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            string text2 = pSavedPath + "\\" + text;
            Image image = Image.FromFile(pPath);
            try
            {
                Bitmap bitmap = new Bitmap(pPartWidth, pPartHeight);
                Graphics graphics = Graphics.FromImage(bitmap);
                Point point = new Point(pPartStartPointX, pPartStartPointY);
                Point arg_65_1 = point;
                Size size = new Size(pPartWidth, pPartHeight);
                Rectangle destRect = new Rectangle(arg_65_1, size);
                point = new Point(pOrigStartPointX, pOrigStartPointY);
                Point arg_89_1 = point;
                size = new Size(pPartWidth, pPartHeight);
                Rectangle srcRect = new Rectangle(arg_89_1, size);
                Graphics graphics2 = Graphics.FromImage(bitmap);
                graphics2.Clear(Color.White);
                graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics2.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);
                graphics2.Dispose();
                image.Dispose();
                bool flag = File.Exists(text2);
                if (flag)
                {
                    File.SetAttributes(text2, FileAttributes.Normal);
                    File.Delete(text2);
                }
                bitmap.Save(text2, ImageFormat.Jpeg);
                bitmap.Dispose();
            }
            finally
            {
                bool flag = image != null;
                if (flag)
                {
                    ((IDisposable)image).Dispose();
                }
            }
            return text;
        }
    }
}
