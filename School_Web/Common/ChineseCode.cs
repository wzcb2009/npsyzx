using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace Wzsckj.com.Common
{
    public class ChineseCode
    {
        [DebuggerNonUserCode]
        public ChineseCode()
        {
        }
        public static string py(string mystr)
		{
            string strpy = "";
            try
            {
                int num2 = 2;
                int strAsc = Strings.Asc(mystr);
               
                if (strAsc>0)
                {
                     
                      bool flag2 = (Operators.CompareString(Strings.UCase(mystr), "Z", false) <= 0 & Operators.CompareString(Strings.UCase(mystr), "A", false) >= 0);
                      if (!flag2)
                      {
                          num2 = 105;
                          strpy = mystr;
                      }
                      else
                      {
                          num2 = 102;
                          strpy = Strings.UCase(Strings.Left(mystr, 1));
                      }
                }
                else
                {
                    num2 = 3;
                    strAsc = Strings.Asc(Strings.Left(mystr, 1));
                   
                    if (strAsc < Strings.Asc("啊"))
                    {
                        num2 = 4;
                        strpy = "0";
                    }
                    else if ((strAsc >= Strings.Asc("啊")) && (strAsc < Strings.Asc("芭")))
                    {
                        num2 = 8;
                        strpy = "A";
                    }
                    else if ((strAsc >= Strings.Asc("芭")) && (strAsc < Strings.Asc("擦")))
                    {
                        num2 = 12;
                        strpy = "B";
                    }
                    else if ((strAsc >= Strings.Asc("擦")) && (strAsc < Strings.Asc("搭")))
                    {
                        num2 = 16;
                        strpy = "C";
                    }
                    else if ((strAsc >= Strings.Asc("搭")) && (strAsc < Strings.Asc("蛾")))
                    {
                        num2 = 20;
                        strpy = "D";
                    }
                    else if ((strAsc >= Strings.Asc("蛾")) && (strAsc < Strings.Asc("发")))
                    {
                        num2 = 24;
                        strpy = "E";
                    }
                    else if ((strAsc >= Strings.Asc("发")) && (strAsc < Strings.Asc("噶")))
                    {
                        num2 = 28;
                        strpy = "F";
                    }
                    else if ((strAsc >= Strings.Asc("噶")) && (strAsc < Strings.Asc("哈")))
                    {
                        num2 = 32;
                        strpy = "G";
                    }
                    else if ((strAsc >= Strings.Asc("哈")) && (strAsc < Strings.Asc("击")))
                    {
                        num2 = 36;
                        strpy = "H";
                    }
                    else if ((strAsc >= Strings.Asc("击")) && (strAsc < Strings.Asc("喀")))
                    {
                        num2 = 40;
                        strpy = "J";
                    }
                    else if ((strAsc >= Strings.Asc("喀")) && (strAsc < Strings.Asc("垃")))
                    {
                        num2 = 44;
                        strpy = "K";
                    }
                    else if ((strAsc >= Strings.Asc("垃")) && (strAsc < Strings.Asc("妈")))
                    {
                        num2 = 48;
                        strpy = "L";
                    }
                    else if ((strAsc >= Strings.Asc("妈")) && (strAsc < Strings.Asc("拿")))
                    {
                        num2 = 52;
                        strpy = "M";
                    }
                    else if ((strAsc >= Strings.Asc("拿")) && (strAsc < Strings.Asc("哦")))
                    {
                        num2 = 56;
                        strpy = "N";
                    }
                    else if ((strAsc >= Strings.Asc("哦")) && (strAsc < Strings.Asc("啪")))
                    {
                        num2 = 60;
                        strpy = "O";
                    }
                    else if ((strAsc >= Strings.Asc("啪")) && (strAsc < Strings.Asc("期")))
                    {
                        num2 = 64;
                        strpy = "P";
                    }
                    else if ((strAsc >= Strings.Asc("期")) && (strAsc < Strings.Asc("然")))
                    {
                        num2 = 68;
                        strpy = "Q";
                    }
                    else if ((strAsc >= Strings.Asc("然"))  && (strAsc < Strings.Asc("撒")))
                    {
                        num2 = 72;
                        strpy = "R";
                    }
                    else if ((strAsc >= Strings.Asc("撒")) && (strAsc < Strings.Asc("塌")))
                    {
                        num2 = 76;
                        strpy = "S";
                    }
                    else if ((strAsc >= Strings.Asc("塌")) && (strAsc < Strings.Asc("挖")))
                    {
                        num2 = 80;
                        strpy = "T";
                    }
                    else if ((strAsc >= Strings.Asc("挖")) && (strAsc < Strings.Asc("昔")))
                    {
                        num2 = 84;
                        strpy = "W";
                    }
                    else if ((strAsc >= Strings.Asc("昔")) && (strAsc < Strings.Asc("压")))
                    {
                        num2 = 88;
                        strpy = "X";
                    }
                    else if ((strAsc >= Strings.Asc("压")) && (strAsc < Strings.Asc("匝")))
                    {
                        num2 = 92;
                        strpy = "Y";
                    }
                    else if ((strAsc >= Strings.Asc("匝")))
                    {
                        num2 = 96;
                        strpy = "Z";
                    }
                     
                   
                }

            }
            catch { }
            return strpy;
		}
        public object InitDictinary()
        {
            object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.Dictionary", ""));
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"a",
				-20319
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ai",
				-20317
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"an",
				-20304
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ang",
				-20295
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ao",
				-20292
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ba",
				-20283
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"bai",
				-20265
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ban",
				-20257
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"bang",
				-20242
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"bao",
				-20230
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"bei",
				-20051
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ben",
				-20036
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"beng",
				-20032
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"bi",
				-20026
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"bian",
				-20002
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"biao",
				-19990
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"bie",
				-19986
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"bin",
				-19982
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"bing",
				-19976
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"bo",
				-19805
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"bu",
				-19784
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ca",
				-19775
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cai",
				-19774
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"can",
				-19763
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cang",
				-19756
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cao",
				-19751
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ce",
				-19746
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ceng",
				-19741
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cha",
				-19739
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chai",
				-19728
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chan",
				-19725
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chang",
				-19715
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chao",
				-19540
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"che",
				-19531
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chen",
				-19525
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cheng",
				-19515
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chi",
				-19500
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chong",
				-19484
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chou",
				-19479
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chu",
				-19467
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chuai",
				-19289
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chuan",
				-19288
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chuang",
				-19281
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chui",
				-19275
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chun",
				-19270
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"chuo",
				-19263
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ci",
				-19261
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cong",
				-19249
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cou",
				-19243
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cu",
				-19242
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cuan",
				-19238
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cui",
				-19235
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cun",
				-19227
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"cuo",
				-19224
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"da",
				-19218
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"dai",
				-19212
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"dan",
				-19038
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"dang",
				-19023
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"dao",
				-19018
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"de",
				-19006
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"deng",
				-19003
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"di",
				-18996
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"dian",
				-18977
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"diao",
				-18961
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"die",
				-18952
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ding",
				-18783
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"diu",
				-18774
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"dong",
				-18773
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"dou",
				-18763
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"du",
				-18756
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"duan",
				-18741
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"dui",
				-18735
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"dun",
				-18731
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"duo",
				-18722
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"e",
				-18710
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"en",
				-18697
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"er",
				-18696
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"fa",
				-18526
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"fan",
				-18518
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"fang",
				-18501
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"fei",
				-18490
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"fen",
				-18478
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"feng",
				-18463
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"fo",
				-18448
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"fou",
				-18447
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"fu",
				-18446
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ga",
				-18239
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gai",
				-18237
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gan",
				-18231
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gang",
				-18220
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gao",
				-18211
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ge",
				-18201
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gei",
				-18184
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gen",
				-18183
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"geng",
				-18181
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gong",
				-18012
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gou",
				-17997
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gu",
				-17988
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gua",
				-17970
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"guai",
				-17964
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"guan",
				-17961
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"guang",
				-17950
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gui",
				-17947
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"gun",
				-17931
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"guo",
				-17928
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ha",
				-17922
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"hai",
				-17759
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"han",
				-17752
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"hang",
				-17733
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"hao",
				-17730
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"he",
				-17721
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"hei",
				-17703
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"hen",
				-17701
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"heng",
				-17697
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"hong",
				-17692
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"hou",
				-17683
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"hu",
				-17676
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"hua",
				-17496
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"huai",
				-17487
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"huan",
				-17482
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"huang",
				-17468
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"hui",
				-17454
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"hun",
				-17433
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"huo",
				-17427
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ji",
				-17417
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"jia",
				-17202
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"jian",
				-17185
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"jiang",
				-16983
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"jiao",
				-16970
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"jie",
				-16942
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"jin",
				-16915
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"jing",
				-16733
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"jiong",
				-16708
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"jiu",
				-16706
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ju",
				-16689
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"juan",
				-16664
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"jue",
				-16657
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"jun",
				-16647
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ka",
				-16474
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kai",
				-16470
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kan",
				-16465
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kang",
				-16459
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kao",
				-16452
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ke",
				-16448
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ken",
				-16433
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"keng",
				-16429
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kong",
				-16427
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kou",
				-16423
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ku",
				-16419
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kua",
				-16412
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kuai",
				-16407
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kuan",
				-16403
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kuang",
				-16401
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kui",
				-16393
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kun",
				-16220
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"kuo",
				-16216
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"la",
				-16212
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lai",
				-16205
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lan",
				-16202
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lang",
				-16187
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lao",
				-16180
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"le",
				-16171
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lei",
				-16169
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"leng",
				-16158
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"li",
				-16155
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lia",
				-15959
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lian",
				-15958
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"liang",
				-15944
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"liao",
				-15933
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lie",
				-15920
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lin",
				-15915
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ling",
				-15903
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"liu",
				-15889
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"long",
				-15878
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lou",
				-15707
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lu",
				-15701
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lv",
				-15681
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"luan",
				-15667
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lue",
				-15661
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"lun",
				-15659
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"luo",
				-15652
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ma",
				-15640
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"mai",
				-15631
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"man",
				-15625
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"mang",
				-15454
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"mao",
				-15448
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"me",
				-15436
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"mei",
				-15435
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"men",
				-15419
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"meng",
				-15416
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"mi",
				-15408
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"mian",
				-15394
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"miao",
				-15385
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"mie",
				-15377
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"min",
				-15375
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ming",
				-15369
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"miu",
				-15363
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"mo",
				-15362
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"mou",
				-15183
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"mu",
				-15180
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"na",
				-15165
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nai",
				-15158
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nan",
				-15153
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nang",
				-15150
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nao",
				-15149
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ne",
				-15144
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nei",
				-15143
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nen",
				-15141
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"neng",
				-15140
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ni",
				-15139
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nian",
				-15128
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"niang",
				-15121
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"niao",
				-15119
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nie",
				-15117
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nin",
				-15110
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ning",
				-15109
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"niu",
				-14941
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nong",
				-14937
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nu",
				-14933
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nv",
				-14930
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nuan",
				-14929
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nue",
				-14928
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"nuo",
				-14926
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"o",
				-14922
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ou",
				-14921
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pa",
				-14914
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pai",
				-14908
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pan",
				-14902
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pang",
				-14894
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pao",
				-14889
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pei",
				-14882
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pen",
				-14873
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"peng",
				-14871
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pi",
				-14857
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pian",
				-14678
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"piao",
				-14674
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pie",
				-14670
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pin",
				-14668
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ping",
				-14663
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"po",
				-14654
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"pu",
				-14645
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qi",
				-14630
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qia",
				-14594
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qian",
				-14429
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qiang",
				-14407
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qiao",
				-14399
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qie",
				-14384
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qin",
				-14379
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qing",
				-14368
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qiong",
				-14355
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qiu",
				-14353
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qu",
				-14345
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"quan",
				-14170
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"que",
				-14159
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"qun",
				-14151
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ran",
				-14149
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"rang",
				-14145
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"rao",
				-14140
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"re",
				-14137
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ren",
				-14135
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"reng",
				-14125
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ri",
				-14123
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"rong",
				-14122
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"rou",
				-14112
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ru",
				-14109
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ruan",
				-14099
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"rui",
				-14097
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"run",
				-14094
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ruo",
				-14092
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"sa",
				-14090
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"sai",
				-14087
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"san",
				-14083
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"sang",
				-13917
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"sao",
				-13914
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"se",
				-13910
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"sen",
				-13907
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"seng",
				-13906
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"sha",
				-13905
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shai",
				-13896
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shan",
				-13894
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shang",
				-13878
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shao",
				-13870
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"she",
				-13859
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shen",
				-13847
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"sheng",
				-13831
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shi",
				-13658
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shou",
				-13611
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shu",
				-13601
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shua",
				-13406
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shuai",
				-13404
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shuan",
				-13400
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shuang",
				-13398
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shui",
				-13395
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shun",
				-13391
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"shuo",
				-13387
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"si",
				-13383
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"song",
				-13367
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"sou",
				-13359
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"su",
				-13356
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"suan",
				-13343
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"sui",
				-13340
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"sun",
				-13329
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"suo",
				-13326
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ta",
				-13318
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tai",
				-13147
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tan",
				-13138
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tang",
				-13120
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tao",
				-13107
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"te",
				-13096
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"teng",
				-13095
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ti",
				-13091
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tian",
				-13076
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tiao",
				-13068
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tie",
				-13063
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ting",
				-13060
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tong",
				-12888
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tou",
				-12875
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tu",
				-12871
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tuan",
				-12860
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tui",
				-12858
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tun",
				-12852
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"tuo",
				-12849
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"wa",
				-12838
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"wai",
				-12831
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"wan",
				-12829
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"wang",
				-12812
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"wei",
				-12802
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"wen",
				-12607
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"weng",
				-12597
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"wo",
				-12594
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"wu",
				-12585
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xi",
				-12556
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xia",
				-12359
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xian",
				-12346
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xiang",
				-12320
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xiao",
				-12300
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xie",
				-12120
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xin",
				-12099
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xing",
				-12089
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xiong",
				-12074
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xiu",
				-12067
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xu",
				-12058
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xuan",
				-12039
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xue",
				-11867
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"xun",
				-11861
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ya",
				-11847
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"yan",
				-11831
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"yang",
				-11798
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"yao",
				-11781
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ye",
				-11604
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"yi",
				-11589
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"yin",
				-11536
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ying",
				-11358
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"yo",
				-11340
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"yong",
				-11339
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"you",
				-11324
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"yu",
				-11303
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"yuan",
				-11097
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"yue",
				-11077
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"yun",
				-11067
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"za",
				-11055
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zai",
				-11052
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zan",
				-11045
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zang",
				-11041
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zao",
				-11038
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"ze",
				-11024
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zei",
				-11020
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zen",
				-11019
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zeng",
				-11018
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zha",
				-11014
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhai",
				-10838
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhan",
				-10832
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhang",
				-10815
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhao",
				-10800
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhe",
				-10790
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhen",
				-10780
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zheng",
				-10764
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhi",
				-10587
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhong",
				-10544
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhou",
				-10533
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhu",
				-10519
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhua",
				-10331
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhuai",
				-10329
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhuan",
				-10328
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhuang",
				-10322
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhui",
				-10315
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhun",
				-10309
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zhuo",
				-10307
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zi",
				-10296
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zong",
				-10281
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zou",
				-10274
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zu",
				-10270
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zuan",
				-10262
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zui",
				-10260
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zun",
				-10256
			}, null, null, null, true);
            NewLateBinding.LateCall(objectValue, null, "Add", new object[]
			{
				"zuo",
				-10254
			}, null, null, null, true);
            object result=new object ();
            return result;
        }
        public static object C(string str)
        {
            object obj = "";
            long arg_11_0 = 1L;
            long num = (long)Strings.Len(str);
            long num2 = arg_11_0;
            checked
            {
                while (true)
                {
                    long arg_33_0 = num2;
                    long num3 = num;
                    if (arg_33_0 > num3)
                    {
                        break;
                    }
                    obj = Operators.ConcatenateObject(obj, ChineseCode.py(Strings.Mid(str, (int)num2, 1)));
                    num2 += 1L;
                }
                return obj;
            }
        }
    }
}
