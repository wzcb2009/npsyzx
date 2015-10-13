using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;
namespace Wzsckj.com.Common
{
    public class Code39
    {
        public enum Code39Model
        {
            Code39Normal,
            Code39FullAscII
        }
        private Hashtable m_Code39;
        private byte m_Magnify;
        private int m_Height;
        private Font m_ViewFont;
        public byte Magnify
        {
            get
            {
                return this.m_Magnify;
            }
            set
            {
                this.m_Magnify = value;
            }
        }
        public int Height
        {
            get
            {
                return this.m_Height;
            }
            set
            {
                this.m_Height = value;
            }
        }
        public Font ViewFont
        {
            get
            {
                return this.m_ViewFont;
            }
            set
            {
                this.m_ViewFont = value;
            }
        }
        public Code39()
        {
            this.m_Code39 = new Hashtable();
            this.m_Magnify = 0;
            this.m_Height = 40;
            this.m_ViewFont = null;
            this.m_Code39.Add("A", "1101010010110");
            this.m_Code39.Add("B", "1011010010110");
            this.m_Code39.Add("C", "1101101001010");
            this.m_Code39.Add("D", "1010110010110");
            this.m_Code39.Add("E", "1101011001010");
            this.m_Code39.Add("F", "1011011001010");
            this.m_Code39.Add("G", "1010100110110");
            this.m_Code39.Add("H", "1101010011010");
            this.m_Code39.Add("I", "1011010011010");
            this.m_Code39.Add("J", "1010110011010");
            this.m_Code39.Add("K", "1101010100110");
            this.m_Code39.Add("L", "1011010100110");
            this.m_Code39.Add("M", "1101101010010");
            this.m_Code39.Add("N", "1010110100110");
            this.m_Code39.Add("O", "1101011010010");
            this.m_Code39.Add("P", "1011011010010");
            this.m_Code39.Add("Q", "1010101100110");
            this.m_Code39.Add("R", "1101010110010");
            this.m_Code39.Add("S", "1011010110010");
            this.m_Code39.Add("T", "1010110110010");
            this.m_Code39.Add("U", "1100101010110");
            this.m_Code39.Add("V", "1001101010110");
            this.m_Code39.Add("W", "1100110101010");
            this.m_Code39.Add("X", "1001011010110");
            this.m_Code39.Add("Y", "1100101101010");
            this.m_Code39.Add("Z", "1001101101010");
            this.m_Code39.Add("0", "1010011011010");
            this.m_Code39.Add("1", "1101001010110");
            this.m_Code39.Add("2", "1011001010110");
            this.m_Code39.Add("3", "1101100101010");
            this.m_Code39.Add("4", "1010011010110");
            this.m_Code39.Add("5", "1101001101010");
            this.m_Code39.Add("6", "1011001101010");
            this.m_Code39.Add("7", "1010010110110");
            this.m_Code39.Add("8", "1101001011010");
            this.m_Code39.Add("9", "1011001011010");
            this.m_Code39.Add("+", "1001010010010");
            this.m_Code39.Add("-", "1001010110110");
            this.m_Code39.Add("*", "1001011011010");
            this.m_Code39.Add("/", "1001001010010");
            this.m_Code39.Add("%", "1010010010010");
            this.m_Code39.Add("$", "1001001001010");
            this.m_Code39.Add(".", "1100101011010");
            this.m_Code39.Add(" ", "1001101011010");
        }
        public Bitmap GetCodeImage(string p_Text, Code39.Code39Model p_Model, bool p_StarChar)
        {
            string text = "";
            string text2 = "";
            bool flag = p_Model == Code39.Code39Model.Code39Normal;
            checked
            {
                char[] array;
                if (flag)
                {
                    text = p_Text.ToUpper();
                }
                else
                {
                    array = p_Text.ToCharArray();
                    for (int num = 0; num != array.Length; num++)
                    {
                        flag = (array[num] >= 'a' && array[num] <= 'z');
                        if (flag)
                        {
                            text = text + "+" + array[num].ToString().ToUpper();
                        }
                        else
                        {
                            text += array[num].ToString();
                        }
                    }
                }
                array = text.ToCharArray();
                if (p_StarChar)
                {
                    text2 = Conversions.ToString(Operators.AddObject(text2, this.m_Code39["*"]));
                }
                for (int num = 0; num != array.Length; num++)
                {
                    flag = (p_StarChar && array[num] == '*');
                    if (flag)
                    {
                        throw new Exception("带有起始符号不能出现*");
                    }
                    object objectValue = RuntimeHelpers.GetObjectValue(this.m_Code39[array[num].ToString()]);
                    flag = (objectValue == null);
                    if (flag)
                    {
                        throw new Exception("不可用的字符" + array[num].ToString());
                    }
                    text2 += objectValue.ToString();
                }
                if (p_StarChar)
                {
                    text2 = Conversions.ToString(Operators.AddObject(text2, this.m_Code39["*"]));
                }
                Bitmap image = this.GetImage(text2);
                this.GetViewImage(image, p_Text);
                return image;
            }
        }
        private Bitmap GetImage(string p_Text)
        {
            char[] array = p_Text.ToCharArray();
            checked
            {
                Bitmap bitmap = new Bitmap(array.Length * (int)(this.m_Magnify + 1), this.m_Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                Graphics arg_45_0 = graphics;
                Brush arg_45_1 = Brushes.White;
                Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                arg_45_0.FillRectangle(arg_45_1, rect);
                int num = 0;
                for (int num2 = 0; num2 != array.Length; num2++)
                {
                    int num3 = (int)(this.m_Magnify + 1);
                    bool flag = array[num2] == '1';
                    if (flag)
                    {
                        Graphics arg_84_0 = graphics;
                        Brush arg_84_1 = Brushes.Black;
                        rect = new Rectangle(num, 0, num3, this.m_Height);
                        arg_84_0.FillRectangle(arg_84_1, rect);
                    }
                    else
                    {
                        Graphics arg_A7_0 = graphics;
                        Brush arg_A7_1 = Brushes.White;
                        rect = new Rectangle(num, 0, num3, this.m_Height);
                        arg_A7_0.FillRectangle(arg_A7_1, rect);
                    }
                    num += num3;
                }
                graphics.Dispose();
                return bitmap;
            }
        }
        private void GetViewImage(Bitmap p_CodeImage, string p_Text)
        {
            bool flag = this.m_ViewFont == null;
            checked
            {
                if (!flag)
                {
                    Graphics graphics = Graphics.FromImage(p_CodeImage);
                    SizeF sizeF = graphics.MeasureString(p_Text, this.m_ViewFont);
                    flag = (sizeF.Width > (float)p_CodeImage.Width || sizeF.Height > (float)(p_CodeImage.Height - 20));
                    if (flag)
                    {
                        graphics.Dispose();
                    }
                    else
                    {
                        int num = p_CodeImage.Height - (int)Math.Round(Math.Truncate((double)sizeF.Height));
                        Graphics arg_AE_0 = graphics;
                        Brush arg_AE_1 = Brushes.White;
                        Rectangle rect = new Rectangle(0, num, p_CodeImage.Width, (int)Math.Round(Math.Truncate((double)sizeF.Height)));
                        arg_AE_0.FillRectangle(arg_AE_1, rect);
                        int num2 = (p_CodeImage.Width - (int)Math.Round(Math.Truncate((double)sizeF.Width))) / 2;
                        graphics.DrawString(p_Text, this.m_ViewFont, Brushes.Black, (float)num2, (float)num);
                        graphics.Dispose();
                    }
                }
            }
        }
    }
}
