using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
namespace Wzsckj.com.Common
{
    public class ImageThumbnail
    {
        [DebuggerNonUserCode]
        public ImageThumbnail()
        {
        }
        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
            int arg_0E_0 = 0;
            checked
            {
                int num = imageEncoders.Length - 1;
                int num2 = arg_0E_0;
                while (true)
                {
                    int arg_3B_0 = num2;
                    int num3 = num;
                    if (arg_3B_0 > num3)
                    {
                        goto Block_2;
                    }
                    bool flag = Operators.CompareString(imageEncoders[num2].MimeType, mimeType, false) == 0;
                    if (flag)
                    {
                        break;
                    }
                    num2++;
                }
                ImageCodecInfo result = imageEncoders[num2];
                return result;
            Block_2:
                result = null;
                return result;
            }
        }
        public static void Compress(Bitmap srcBitmap, Stream destStream, long level)
        {
            ImageCodecInfo encoderInfo = ImageThumbnail.GetEncoderInfo("image/jpeg");
            Encoder quality = Encoder.Quality;
            EncoderParameters encoderParameters = new EncoderParameters(1);
            EncoderParameter encoderParameter = new EncoderParameter(quality, level);
            encoderParameters.Param[0] = encoderParameter;
            srcBitmap.Save(destStream, encoderInfo, encoderParameters);
        }
        public static void Compress(Bitmap srcBitMap, string destFile, long level)
        {
            Stream stream = new FileStream(destFile, FileMode.Create);
            ImageThumbnail.Compress(srcBitMap, stream, level);
            stream.Close();
        }
        public static void Compress(Stream srcStream, string destFile, long level)
        {
            Bitmap bitmap = new Bitmap(srcStream);
            ImageThumbnail.Compress(bitmap, destFile, level);
            bitmap.Dispose();
        }
        public static void Compress(Image srcImg, string destFile, long level)
        {
            Bitmap bitmap = new Bitmap(srcImg);
            ImageThumbnail.Compress(bitmap, destFile, level);
            bitmap.Dispose();
        }
        public static void Compress(string srcFile, string destFile, long level)
        {
            Bitmap bitmap = new Bitmap(srcFile);
            ImageThumbnail.Compress(bitmap, destFile, level);
            bitmap.Dispose();
        }
        public static bool SmallPic(string PicPath, string NewPath, int intWidth)
        {
            bool result=false ;
            try
            {
                Bitmap bitmap = new Bitmap(PicPath);
                bool flag = bitmap.Width > intWidth;
                if (flag)
                {
                    double num = (double)bitmap.Width / (double)bitmap.Height;
                    int height = Convert.ToInt32(Convert.ToDouble(intWidth) / num);
                    Bitmap bitmap2 = new Bitmap(bitmap, intWidth, height);
                    bitmap.Dispose();
                    ImageThumbnail.SaveAsJPEG(bitmap2, NewPath, 100);
                    bitmap2.Dispose();
                    result = true;
                }
                else
                {
                    bitmap.Dispose();
                }
            }
            catch (Exception expr_68)
            {
                ProjectData.SetProjectError(expr_68);
                Exception ex = expr_68;
                throw ex;
            }
            finally
            {
            }
            return result;
        }
        public static bool SaveAsJPEG(Bitmap bmp, string FileName, int Qty)
        {
            bool result;
            try
            {
                EncoderParameters encoderParameters = new EncoderParameters(1);
                EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, (long)Qty);
                encoderParameters.Param[0] = encoderParameter;
                bmp.Save(FileName, ImageThumbnail.GetCodecInfo("image/jpeg"), encoderParameters);
                result = true;
            }
            catch (Exception arg_39_0)
            {
                ProjectData.SetProjectError(arg_39_0);
                result = false;
                ProjectData.ClearProjectError();
            }
            return result;
        }
        private static ImageCodecInfo GetCodecInfo(string mimeType)
        {
            ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
            ImageCodecInfo[] array = imageEncoders;
            checked
            {
                ImageCodecInfo result;
                for (int i = 0; i < array.Length; i++)
                {
                    ImageCodecInfo imageCodecInfo = array[i];
                    bool flag = Operators.CompareString(imageCodecInfo.MimeType, mimeType, false) == 0;
                    if (flag)
                    {
                        result = imageCodecInfo;
                        return result;
                    }
                }
                result = null;
                return result;
            }
        }
    }
}
