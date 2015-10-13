using System;
namespace Wzsckj.com.Common
{
    public sealed class Code128Code
    {
        public enum CodeSetAllowed
        {
            CodeA,
            CodeB,
            CodeAorB
        }
        private const int cSHIFT = 98;
        private const int cCODEA = 101;
        private const int cCODEB = 100;
        private const int cSTARTA = 103;
        private const int cSTARTB = 104;
        private const int cSTOP = 106;
        private Code128Code()
        {
        }
        public static int[] CodesForChar(int CharAscii, int LookAheadAscii, ref CodeSet CurrCodeSet)
        {
            int num = -1;
            bool flag = !Code128Code.CharCompatibleWithCodeset(CharAscii, CurrCodeSet);
            bool flag2;
            if (flag)
            {
                flag2 = (LookAheadAscii != -1 && !Code128Code.CharCompatibleWithCodeset(LookAheadAscii, CurrCodeSet));
                if (flag2)
                {
                    switch ((int )CurrCodeSet)
                    {
                        case 0:
                            num = 100;
                            CurrCodeSet = CodeSet.CodeB;
                            break;
                        case 1:
                            num = 101;
                            CurrCodeSet = CodeSet.CodeA;
                            break;
                    }
                }
                else
                {
                    num = 98;
                }
            }
            flag2 = (num != -1);
            int[] result;
            if (flag2)
            {
                result = new int[]
				{
					num,
					Code128Code.CodeValueForChar(CharAscii)
				};
            }
            else
            {
                result = new int[]
				{
					Code128Code.CodeValueForChar(CharAscii)
				};
            }
            return result;
        }
        public static Code128Code.CodeSetAllowed CodesetAllowedForChar(int CharAscii)
        {
            bool flag = CharAscii >= 32 && CharAscii <= 95;
            Code128Code.CodeSetAllowed result;
            if (flag)
            {
                result = Code128Code.CodeSetAllowed.CodeAorB;
            }
            else
            {
                result = ((CharAscii < 32) ? Code128Code.CodeSetAllowed.CodeA : Code128Code.CodeSetAllowed.CodeB);
            }
            return result;
        }
        public static bool CharCompatibleWithCodeset(int CharAscii, CodeSet currcs)
        {
            Code128Code.CodeSetAllowed codeSetAllowed = Code128Code.CodesetAllowedForChar(CharAscii);
            int arg_23_0;
            if (codeSetAllowed != Code128Code.CodeSetAllowed.CodeAorB && (codeSetAllowed != Code128Code.CodeSetAllowed.CodeA || currcs != CodeSet.CodeA))
            {
                if (codeSetAllowed != Code128Code.CodeSetAllowed.CodeB || currcs != CodeSet.CodeB)
                {
                    arg_23_0 = 0;
                    return arg_23_0 != 0;
                }
            }
            arg_23_0 = 1;
            return arg_23_0 != 0;
        }
        public static int CodeValueForChar(int CharAscii)
        {
            return checked((CharAscii >= 32) ? (CharAscii - 32) : (CharAscii + 64));
        }
        public static int StartCodeForCodeSet(CodeSet cs)
        {
            return (cs == CodeSet.CodeA) ? 103 : 104;
        }
        public static int StopCode()
        {
            return 106;
        }
    }
}
