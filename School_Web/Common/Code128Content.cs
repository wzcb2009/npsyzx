using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Text;
namespace Wzsckj.com.Common
{
    public class Code128Content
    {
        private int[] mCodeList;
        public int[] Codes
        {
            get
            {
                return this.mCodeList;
            }
        }
        public Code128Content(string AsciiData)
        {
            this.mCodeList = this.StringToCode128(AsciiData);
        }
        private int[] StringToCode128(string AsciiData)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(AsciiData);
            Code128Code.CodeSetAllowed csa = (bytes.Length > 0) ? Code128Code.CodesetAllowedForChar((int)bytes[0]) : Code128Code.CodeSetAllowed.CodeAorB;
            Code128Code.CodeSetAllowed csa2 = (bytes.Length > 0) ? Code128Code.CodesetAllowedForChar((int)bytes[1]) : Code128Code.CodeSetAllowed.CodeAorB;
            CodeSet bestStartSet = this.GetBestStartSet(csa, csa2);
            checked
            {
                ArrayList arrayList = new ArrayList(bytes.Length + 3);
                arrayList.Add(Code128Code.StartCodeForCodeSet(bestStartSet));
                int arg_63_0 = 0;
                int num = bytes.Length - 1;
                int num2 = arg_63_0;
                while (true)
                {
                    int arg_A2_0 = num2;
                    int num3 = num;
                    if (arg_A2_0 > num3)
                    {
                        break;
                    }
                    int charAscii = (int)bytes[num2];
                    int lookAheadAscii = (bytes.Length > num2 + 1) ? ((int)bytes[num2 + 1]) : -1;
                    arrayList.AddRange(Code128Code.CodesForChar(charAscii, lookAheadAscii, ref bestStartSet));
                    num2++;
                }
                int num4 = Conversions.ToInteger(arrayList[0]);
                int arg_BC_0 = 1;
                int num5 = arrayList.Count - 1;
                int num6 = arg_BC_0;
                while (true)
                {
                    int arg_E2_0 = num6;
                    int num3 = num5;
                    if (arg_E2_0 > num3)
                    {
                        break;
                    }
                    num4 += num6 * Conversions.ToInteger(arrayList[num6]);
                    num6++;
                }
                arrayList.Add(num4 % 103);
                arrayList.Add(Code128Code.StopCode());
                return arrayList.ToArray(typeof(int)) as int[];
            }
        }
        private CodeSet GetBestStartSet(Code128Code.CodeSetAllowed csa1, Code128Code.CodeSetAllowed csa2)
        {
            int num = 0;
            checked
            {
                num += ((csa1 == Code128Code.CodeSetAllowed.CodeA) ? 1 : 0);
                num += ((csa1 == Code128Code.CodeSetAllowed.CodeB) ? -1 : 0);
                num += ((csa2 == Code128Code.CodeSetAllowed.CodeA) ? 1 : 0);
                num += ((csa2 == Code128Code.CodeSetAllowed.CodeB) ? -1 : 0);
                return (num > 0) ? CodeSet.CodeA : CodeSet.CodeB;
            }
        }
    }
}
