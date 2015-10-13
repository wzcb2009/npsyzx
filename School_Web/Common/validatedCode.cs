using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Web;
namespace Wzsckj.com.Common
{
    public class validatedCode
    {
        private int m_length;
        private int m_fontSize;
        private int m_padding;
        private bool m_chaos;
        private Color m_chaosColor;
        private Color m_backgroundColor;
        private Color[] m_colors;
        private string[] m_fonts;
        private string m_codeSerial;
        private const double PI = 3.14159265358979;
        private const double PI2 = 6.28318530717959;
        public int Length
        {
            get
            {
                return this.m_length;
            }
            set
            {
                this.m_length = value;
            }
        }
        public int FontSize
        {
            get
            {
                return this.m_fontSize;
            }
            set
            {
                this.m_fontSize = value;
            }
        }
        public int Padding
        {
            get
            {
                return this.m_padding;
            }
            set
            {
                this.m_padding = value;
            }
        }
        public bool Chaos
        {
            get
            {
                return this.m_chaos;
            }
            set
            {
                this.m_chaos = value;
            }
        }
        public Color ChaosColor
        {
            get
            {
                return this.m_chaosColor;
            }
            set
            {
                this.m_chaosColor = value;
            }
        }
        public Color BackgroundColor
        {
            get
            {
                return this.m_backgroundColor;
            }
            set
            {
                this.m_backgroundColor = value;
            }
        }
        public Color[] Colors
        {
            get
            {
                return this.m_colors;
            }
            set
            {
                this.m_colors = value;
            }
        }
        public string[] Fonts
        {
            get
            {
                return this.m_fonts;
            }
            set
            {
                this.m_fonts = value;
            }
        }
        public string CodeSerial
        {
            get
            {
                return this.m_codeSerial;
            }
            set
            {
                this.m_codeSerial = value;
            }
        }
        public validatedCode()
        {
            this.m_length = 4;
            this.m_fontSize = 40;
            this.m_padding = 2;
            this.m_chaos = true;
            this.m_chaosColor = Color.LightGray;
            this.m_backgroundColor = Color.White;
            this.m_colors = new Color[]
			{
				Color.Black,
				Color.Red,
				Color.DarkBlue,
				Color.Green,
				Color.Orange,
				Color.Brown,
				Color.DarkCyan,
				Color.Purple
			};
            this.m_fonts = new string[]
			{
				"Arial",
				"Georgia"
			};
            this.m_codeSerial = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
        }
        public Bitmap TwistImage(Bitmap srcBmp, bool bXDir, double dMultValue, double dPhase)
        {
            Bitmap bitmap = new Bitmap(srcBmp.Width, srcBmp.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, bitmap.Width, bitmap.Height);
            graphics.Dispose();
            double num = bXDir ? ((double)bitmap.Height) : ((double)bitmap.Width);
            int arg_5F_0 = 0;
            checked
            {
                int num2 = bitmap.Width - 1;
                int num3 = arg_5F_0;
                while (true)
                {
                    int arg_150_0 = num3;
                    int num4 = num2;
                    if (arg_150_0 > num4)
                    {
                        break;
                    }
                    int arg_71_0 = 0;
                    int num5 = bitmap.Height - 1;
                    int num6 = arg_71_0;
                    while (true)
                    {
                        int arg_13C_0 = num6;
                        num4 = num5;
                        if (arg_13C_0 > num4)
                        {
                            break;
                        }
                        double num8;
                        unchecked
                        {
                            double num7 = bXDir ? (6.28318530717959 * (double)num6 / num) : (6.28318530717959 * (double)num3 / num);
                            num7 += dPhase;
                            num8 = Math.Sin(num7);
                        }
                        int num9 = bXDir ? (num3 + (int)Math.Round(unchecked(num8 * dMultValue))) : num3;
                        int num10 = bXDir ? num6 : (num6 + (int)Math.Round(unchecked(num8 * dMultValue)));
                        Color pixel = srcBmp.GetPixel(num3, num6);
                        bool flag = num9 >= 0 && num9 < bitmap.Width && num10 >= 0 && num10 < bitmap.Height;
                        if (flag)
                        {
                            bitmap.SetPixel(num9, num10, pixel);
                        }
                        num6++;
                    }
                    num3++;
                }
                return bitmap;
            }
        }
        public Bitmap CreateImageCode(string code)
        {
            int fontSize = this.FontSize;
            checked
            {
                int num = fontSize + this.Padding;
                int width = code.Length * num + 4 + this.Padding * 2;
                int num2 = fontSize * 2 + this.Padding;
                Bitmap bitmap = new Bitmap(width, num2);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.Clear(this.BackgroundColor);
                Random random = new Random();
                bool flag = this.Chaos;
                if (flag)
                {
                    Pen pen = new Pen(this.ChaosColor, 0f);
                    int num3 = this.Length * 10;
                    int arg_90_0 = 0;
                    int num4 = num3 - 1;
                    int num5 = arg_90_0;
                    while (true)
                    {
                        int arg_D3_0 = num5;
                        int num6 = num4;
                        if (arg_D3_0 > num6)
                        {
                            break;
                        }
                        int x = random.Next(bitmap.Width);
                        int y = random.Next(bitmap.Height);
                        graphics.DrawRectangle(pen, x, y, 1, 1);
                        num5++;
                    }
                }
                int num7 = num2 - this.FontSize - this.Padding * 2;
                int num8 = (int)Math.Round((double)num7 / 4.0);
                int num9 = num8;
                int num10 = num8 * 2;
                int arg_120_0 = 0;
                int num11 = code.Length - 1;
                int num12 = arg_120_0;
                while (true)
                {
                    int arg_1BE_0 = num12;
                    int num6 = num11;
                    if (arg_1BE_0 > num6)
                    {
                        break;
                    }
                    int num13 = random.Next(this.Colors.Length - 1);
                    int num14 = random.Next(this.Fonts.Length - 1);
                    Font font = new Font(this.Fonts[num14], (float)fontSize, FontStyle.Bold);
                    Brush brush = new SolidBrush(this.Colors[num13]);
                    flag = (num12 % 2 == 1);
                    int num15;
                    if (flag)
                    {
                        num15 = num10;
                    }
                    else
                    {
                        num15 = num9;
                    }
                    int num16 = num12 * num;
                    graphics.DrawString(code.Substring(num12, 1), font, brush, (float)num16, (float)num15);
                    num12++;
                }
                graphics.DrawRectangle(new Pen(Color.Gainsboro, 0f), 0, 0, bitmap.Width - 1, bitmap.Height - 1);
                graphics.Dispose();
                return this.TwistImage(bitmap, true, 8.0, 4.0);
            }
        }
        public void CreateImageOnPage(string code, HttpContext context)
        {
            MemoryStream memoryStream = new MemoryStream();
            Bitmap bitmap = this.CreateImageCode(code);
            bitmap.Save(memoryStream, ImageFormat.Jpeg);
            context.Response.ClearContent();
            context.Response.ContentType = "image/Jpeg";
            context.Response.BinaryWrite(memoryStream.GetBuffer());
            memoryStream.Close();
            bitmap.Dispose();
        }
        public string CreateVerifyCode(int codeLen)
        {
            bool flag = codeLen == 0;
            if (flag)
            {
                codeLen = this.Length;
            }
            string[] array = this.CodeSerial.Split(new char[]
			{
				','
			});
            string text = "";
            Random random = new Random();
            int arg_45_0 = 0;
            checked
            {
                int num = codeLen - 1;
                int num2 = arg_45_0;
                while (true)
                {
                    int arg_71_0 = num2;
                    int num3 = num;
                    if (arg_71_0 > num3)
                    {
                        break;
                    }
                    int num4 = random.Next(0, array.Length - 1);
                    text += array[num4];
                    num2++;
                }
                return text;
            }
        }
        public string CreateVerifyCode()
        {
            return this.CreateVerifyCode(0);
        }
    }
}
