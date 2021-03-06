﻿using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Text;
namespace Wzsckj.com.Common
{
    public class ChineseCode2
    {
        protected string _CnTxt;
        protected string _EnTxt;
        public string CnTxt
        {
            get
            {
                return this._CnTxt;
            }
            set
            {
                this._CnTxt = value;
            }
        }
        public string EnTxt
        {
            get
            {
                return this._EnTxt;
            }
            set
            {
                this._EnTxt = value;
            }
        }
        public ChineseCode2()
        {
        }
        public ChineseCode2(string txt)
        {
            this._CnTxt = txt;
            this._EnTxt = this.IndexCode(this._CnTxt);
        }
        public string IndexCode(string IndexTxt)
        {
            string text = null;
            int arg_0D_0 = 0;
            checked
            {
                int num = IndexTxt.Length - 1;
                int num2 = arg_0D_0;
                while (true)
                {
                    int arg_30_0 = num2;
                    int num3 = num;
                    if (arg_30_0 > num3)
                    {
                        break;
                    }
                    text += this.GetOneIndex(IndexTxt.Substring(num2, 1));
                    num2++;
                }
                return text;
            }
        }
        private string GetOneIndex(string OneIndexTxt)
        {
            bool flag = Strings.Asc(Convert.ToChar(OneIndexTxt)) >= 0 && Strings.Asc(Convert.ToChar(OneIndexTxt)) < 256;
            string result;
            if (flag)
            {
                result = OneIndexTxt;
            }
            else
            {
                Encoding encoding = Encoding.GetEncoding("gb2312");
                byte[] bytes = Encoding.Unicode.GetBytes(OneIndexTxt);
                byte[] array = Encoding.Convert(Encoding.Unicode, encoding, bytes);
                result = this.GetX(Convert.ToInt32(checked(string.Format("{0:D2}", (int)(Convert.ToInt16(array[0]) - 160)) + string.Format("{0:D2}", (int)(Convert.ToInt16(array[1]) - 160)))));
            }
            return result;
        }
        private string GetX(int GBCode)
        {
            bool flag = GBCode >= 1601 && GBCode < 1637;
            checked
            {
                string result;
                if (flag)
                {
                    result = "a";
                }
                else
                {
                    flag = (GBCode >= 1637 && GBCode < 1833);
                    if (flag)
                    {
                        result = "b";
                    }
                    else
                    {
                        flag = (GBCode >= 1833 && GBCode < 2078);
                        if (flag)
                        {
                            result = "c";
                        }
                        else
                        {
                            flag = (GBCode >= 2078 && GBCode < 2274);
                            if (flag)
                            {
                                result = "d";
                            }
                            else
                            {
                                flag = (GBCode >= 2274 && GBCode < 2302);
                                if (flag)
                                {
                                    result = "e";
                                }
                                else
                                {
                                    flag = (GBCode >= 2302 && GBCode < 2433);
                                    if (flag)
                                    {
                                        result = "f";
                                    }
                                    else
                                    {
                                        flag = (GBCode >= 2433 && GBCode < 2594);
                                        if (flag)
                                        {
                                            result = "g";
                                        }
                                        else
                                        {
                                            flag = (GBCode >= 2594 && GBCode < 2787);
                                            if (flag)
                                            {
                                                result = "h";
                                            }
                                            else
                                            {
                                                flag = (GBCode >= 2787 && GBCode < 3106);
                                                if (flag)
                                                {
                                                    result = "j";
                                                }
                                                else
                                                {
                                                    flag = (GBCode >= 3106 && GBCode < 3212);
                                                    if (flag)
                                                    {
                                                        result = "k";
                                                    }
                                                    else
                                                    {
                                                        flag = (GBCode >= 3212 && GBCode < 3472);
                                                        if (flag)
                                                        {
                                                            result = "l";
                                                        }
                                                        else
                                                        {
                                                            flag = (GBCode >= 3472 && GBCode < 3635);
                                                            if (flag)
                                                            {
                                                                result = "m";
                                                            }
                                                            else
                                                            {
                                                                flag = (GBCode >= 3635 && GBCode < 3722);
                                                                if (flag)
                                                                {
                                                                    result = "n";
                                                                }
                                                                else
                                                                {
                                                                    flag = (GBCode >= 3722 && GBCode < 3730);
                                                                    if (flag)
                                                                    {
                                                                        result = "o";
                                                                    }
                                                                    else
                                                                    {
                                                                        flag = (GBCode >= 3730 && GBCode < 3858);
                                                                        if (flag)
                                                                        {
                                                                            result = "p";
                                                                        }
                                                                        else
                                                                        {
                                                                            flag = (GBCode >= 3858 && GBCode < 4027);
                                                                            if (flag)
                                                                            {
                                                                                result = "q";
                                                                            }
                                                                            else
                                                                            {
                                                                                flag = (GBCode >= 4027 && GBCode < 4086);
                                                                                if (flag)
                                                                                {
                                                                                    result = "r";
                                                                                }
                                                                                else
                                                                                {
                                                                                    flag = (GBCode >= 4086 && GBCode < 4390);
                                                                                    if (flag)
                                                                                    {
                                                                                        result = "s";
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        flag = (GBCode >= 4390 && GBCode < 4558);
                                                                                        if (flag)
                                                                                        {
                                                                                            result = "t";
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            flag = (GBCode >= 4558 && GBCode < 4684);
                                                                                            if (flag)
                                                                                            {
                                                                                                result = "w";
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                flag = (GBCode >= 4684 && GBCode < 4925);
                                                                                                if (flag)
                                                                                                {
                                                                                                    result = "x";
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    flag = (GBCode >= 4925 && GBCode < 5249);
                                                                                                    if (flag)
                                                                                                    {
                                                                                                        result = "y";
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        flag = (GBCode >= 5249 && GBCode <= 5589);
                                                                                                        if (flag)
                                                                                                        {
                                                                                                            result = "z";
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            flag = (GBCode >= 5601 && GBCode <= 8794);
                                                                                                            if (flag)
                                                                                                            {
                                                                                                                string text = "cjwgnspgcenegypbtwxzdxykygtpjnmjqmbsgzscyjsyyfpggbzgydywjkgaljswkbjqhyjwpdzlsgmrybywwccgznkydgttngjeyekzydcjnmcylqlypyqbqrpzslwbdgkjfyxjwcltbncxjjjjcxdtqsqzycdxxhgckbphffsspybgmxjbbyglbhlssmzmpjhsojnghdzcdklgjhsgqzhxqgkezzwymcscjnyetxadzpmdssmzjjqjyzcjjfwqjbdzbjgdnzcbwhgxhqkmwfbpbqdtjjzkqhylcgxfptyjyyzpsjlfchmqshgmmxsxjpkdcmbbqbefsjwhwwgckpylqbgldlcctnmaeddksjngkcsgxlhzaybdbtsdkdylhgymylcxpycjndqjwxqxfyyfjlejbzrwccqhqcsbzkymgplbmcrqcflnymyqmsqtrbcjthztqfrxchxmcjcjlxqgjmshzkbswxemdlckfsydsglycjjssjnqbjctyhbftdcyjdgwyghqfrxwckqkxebpdjpxjqsrmebwgjlbjslyysmdxlclqkxlhtjrjjmbjhxhwywcbhtrxxglhjhfbmgykldyxzpplggpmtcbbajjzyljtyanjgbjflqgdzyqcaxbkclecjsznslyzhlxlzcghbxzhznytdsbcjkdlzayffydlabbgqszkggldndnyskjshdlxxbcghxyggdjmmzngmmccgwzszxsjbznmlzdthcqydbdllscddnlkjyhjsycjlkohqasdhnhcsgaehdaashtcplcpqybsdmpjlpcjaqlcdhjjasprchngjnlhlyyqyhwzpnccgwwmzffjqqqqxxaclbhkdjxdgmmydjxzllsygxgkjrywzwyclzmcsjzldbndcfcxyhlschycjqppqagmnyxpfrkssbjlyxyjjglnscmhcwwmnzjjlhmhchsyppttxrycsxbyhcsmxjsxnbwgpxxtaybgajcxlypdccwqocwkccsbnhcpdyznbcyytyckskybsqkkytqqxfcwchcwkelcqbsqyjqcclmthsywhmktlkjlychwheqjhtjhppqpqscfymmcmgbmhglgsllysdllljpchmjhwljcyhzjxhdxjlhxrswlwzjcbxmhzqxsdzpmgfcsglsdymjshxpjxomyqknmyblrthbcftpmgyxlchlhlzylxgsssscclsldclepbhshxyyfhbmgdfycnjqwlqhjjcywjztejjdhfblqxtqkwhdchqxagtlxljxmsljhdzkzjecxjcjnmbbjcsfywkbjzghysdcpqyrsljpclpwxsdwejbjcbcnaytmgmbapclyqbclzxcbnmsggfnzjjbzsfqyndxhpcqkzczwalsbccjxpozgwkybsgxfcfcdkhjbstlqfsgdslqwzkxtmhsbgzhjcrglyjbpmljsxlcjqqhzmjczydjwbmjklddpmjegxyhylxhlqyqhkycwcjmyhxnatjhyccxzpcqlbzwwwtwbqcmlbmynjcccxbbsnzzljpljxyztzlgcldcklyrzzgqtgjhhgjljaxfgfjzslcfdqzlclgjdjcsnclljpjqdcclcjxmyzftsxgcgsbrzxjqqcczhgyjdjqqlzxjyldlbcyamcstylbdjbyregklzdzhldszchznwczcllwjqjjjkdgjcolbbzppglghtgzcygezmycnqcycyhbhgxkamtxyxnbskyzzgjzlqjdfcjxdygjqjjpmgwgjjjpkjsbgbmmcjssclpqpdxcdyykypcjddyygywchjrtgcnyqldkljczzgzccjgdyksgpzmdlcphnjafyzdjcnmwescsglbtzcgmsdllyxqsxsbljsbbsgghfjlwpmzjnlyywdqshzxtyywhmcyhywdbxbtlmswyyfsbjcbdxxlhjhfpsxzqhfzmqcztqcxzxrdkdjhnnyzqqfnqdmmgnydxmjgdhcdycbffallztdltfkmxqzdngeqdbdczjdxbzgsqqddjcmbkxffxmkdmcsychzcmljdjynhprsjmkmpcklgdbqtfzswtfgglyplljzhgjjgypzltcsmcnbtjbhfkdhbyzgkpbbymtdlsxsbnpdkleycjnycdykzddhqgsdzsctarlltkzlgecllkjljjaqnbdggghfjtzqjsecshalqfmmgjnlyjbbtmlycxdcjpldlpcqdhsycbzsckbzmsljflhrbjsnbrgjhxpdgdjybzgdlgcsezgxlblgyxtwmabchecmwyjyzlljjshlgndjlslygkdzpzxjyyzlpcxszfgwyydlyhcljscmbjhblyjlycblydpdqysxktbytdkdxjypcnrjmfdjgklccjbctbjddbblblcdqrppxjcglzcshltoljnmdddlngkaqakgjgyhheznmshrphqqjchgmfprxcjgdychghlyrzqlcngjnzsqdkqjymszswlcfqjqxgbggxmdjwlmcrnfkkfsyyljbmqammmycctbshcptxxzzsmphfshmclmldjfyqxsdyjdjjzzhqpdszglssjbckbxyqzjsgpsxjzqznqtbdkwxjkhhgflbcsmdldgdzdblzkycqnncsybzbfglzzxswmsccmqnjqsbdqsjtxxmbldxcclzshzcxrqjgjylxzfjphymzqqydfqjjlcznzjcdgzygcdxmzysctlkphtxhtlbjxjlxscdqccbbqjfqzfsltjbtkqbsxjjljchczdbzjdczjccprnlqcgpfczlclcxzdmxmphgsgzgszzqjxlwtjpfsyaslcjbtckwcwmytcsjjljcqlwzmalbxyfbpnlschtgjwejjxxglljstgshjqlzfkcgnndszfdeqfhbsaqdgylbxmmygszldydjmjjrgbjgkgdhgkblgkbdmbylxwcxyttybkmrjjzxqjbhlmhmjjzmqasldcyxyqdlqcafywyxqhz";
                                                                                                                string text2 = GBCode.ToString();
                                                                                                                int num = (int)((Convert.ToInt16(text2.Substring(0, 2)) - 56) * 94 + Convert.ToInt16(text2.Substring(text2.Length - 2, 2)));
                                                                                                                result = text.Substring(num - 1, 1);
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                result = " ";
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return result;
            }
        }
        public string GetSpell(string x)
        {
            int[] array = new int[]
			{
				-20319,
				-20317,
				-20304,
				-20295,
				-20292,
				-20283,
				-20265,
				-20257,
				-20242,
				-20230,
				-20051,
				-20036,
				-20032,
				-20026,
				-20002,
				-19990,
				-19986,
				-19982,
				-19976,
				-19805,
				-19784,
				-19775,
				-19774,
				-19763,
				-19756,
				-19751,
				-19746,
				-19741,
				-19739,
				-19728,
				-19725,
				-19715,
				-19540,
				-19531,
				-19525,
				-19515,
				-19500,
				-19484,
				-19479,
				-19467,
				-19289,
				-19288,
				-19281,
				-19275,
				-19270,
				-19263,
				-19261,
				-19249,
				-19243,
				-19242,
				-19238,
				-19235,
				-19227,
				-19224,
				-19218,
				-19212,
				-19038,
				-19023,
				-19018,
				-19006,
				-19003,
				-18996,
				-18977,
				-18961,
				-18952,
				-18783,
				-18774,
				-18773,
				-18763,
				-18756,
				-18741,
				-18735,
				-18731,
				-18722,
				-18710,
				-18697,
				-18696,
				-18526,
				-18518,
				-18501,
				-18490,
				-18478,
				-18463,
				-18448,
				-18447,
				-18446,
				-18239,
				-18237,
				-18231,
				-18220,
				-18211,
				-18201,
				-18184,
				-18183,
				-18181,
				-18012,
				-17997,
				-17988,
				-17970,
				-17964,
				-17961,
				-17950,
				-17947,
				-17931,
				-17928,
				-17922,
				-17759,
				-17752,
				-17733,
				-17730,
				-17721,
				-17703,
				-17701,
				-17697,
				-17692,
				-17683,
				-17676,
				-17496,
				-17487,
				-17482,
				-17468,
				-17454,
				-17433,
				-17427,
				-17417,
				-17202,
				-17185,
				-16983,
				-16970,
				-16942,
				-16915,
				-16733,
				-16708,
				-16706,
				-16689,
				-16664,
				-16657,
				-16647,
				-16474,
				-16470,
				-16465,
				-16459,
				-16452,
				-16448,
				-16433,
				-16429,
				-16427,
				-16423,
				-16419,
				-16412,
				-16407,
				-16403,
				-16401,
				-16393,
				-16220,
				-16216,
				-16212,
				-16205,
				-16202,
				-16187,
				-16180,
				-16171,
				-16169,
				-16158,
				-16155,
				-15959,
				-15958,
				-15944,
				-15933,
				-15920,
				-15915,
				-15903,
				-15889,
				-15878,
				-15707,
				-15701,
				-15681,
				-15667,
				-15661,
				-15659,
				-15652,
				-15640,
				-15631,
				-15625,
				-15454,
				-15448,
				-15436,
				-15435,
				-15419,
				-15416,
				-15408,
				-15394,
				-15385,
				-15377,
				-15375,
				-15369,
				-15363,
				-15362,
				-15183,
				-15180,
				-15165,
				-15158,
				-15153,
				-15150,
				-15149,
				-15144,
				-15143,
				-15141,
				-15140,
				-15139,
				-15128,
				-15121,
				-15119,
				-15117,
				-15110,
				-15109,
				-14941,
				-14937,
				-14933,
				-14930,
				-14929,
				-14928,
				-14926,
				-14922,
				-14921,
				-14914,
				-14908,
				-14902,
				-14894,
				-14889,
				-14882,
				-14873,
				-14871,
				-14857,
				-14678,
				-14674,
				-14670,
				-14668,
				-14663,
				-14654,
				-14645,
				-14630,
				-14594,
				-14429,
				-14407,
				-14399,
				-14384,
				-14379,
				-14368,
				-14355,
				-14353,
				-14345,
				-14170,
				-14159,
				-14151,
				-14149,
				-14145,
				-14140,
				-14137,
				-14135,
				-14125,
				-14123,
				-14122,
				-14112,
				-14109,
				-14099,
				-14097,
				-14094,
				-14092,
				-14090,
				-14087,
				-14083,
				-13917,
				-13914,
				-13910,
				-13907,
				-13906,
				-13905,
				-13896,
				-13894,
				-13878,
				-13870,
				-13859,
				-13847,
				-13831,
				-13658,
				-13611,
				-13601,
				-13406,
				-13404,
				-13400,
				-13398,
				-13395,
				-13391,
				-13387,
				-13383,
				-13367,
				-13359,
				-13356,
				-13343,
				-13340,
				-13329,
				-13326,
				-13318,
				-13147,
				-13138,
				-13120,
				-13107,
				-13096,
				-13095,
				-13091,
				-13076,
				-13068,
				-13063,
				-13060,
				-12888,
				-12875,
				-12871,
				-12860,
				-12858,
				-12852,
				-12849,
				-12838,
				-12831,
				-12829,
				-12812,
				-12802,
				-12607,
				-12597,
				-12594,
				-12585,
				-12556,
				-12359,
				-12346,
				-12320,
				-12300,
				-12120,
				-12099,
				-12089,
				-12074,
				-12067,
				-12058,
				-12039,
				-11867,
				-11861,
				-11847,
				-11831,
				-11798,
				-11781,
				-11604,
				-11589,
				-11536,
				-11358,
				-11340,
				-11339,
				-11324,
				-11303,
				-11097,
				-11077,
				-11067,
				-11055,
				-11052,
				-11045,
				-11041,
				-11038,
				-11024,
				-11020,
				-11019,
				-11018,
				-11014,
				-10838,
				-10832,
				-10815,
				-10800,
				-10790,
				-10780,
				-10764,
				-10587,
				-10544,
				-10533,
				-10519,
				-10331,
				-10329,
				-10328,
				-10322,
				-10315,
				-10309,
				-10307,
				-10296,
				-10281,
				-10274,
				-10270,
				-10262,
				-10260,
				-10256,
				-10254
			};
            string[] array2 = new string[]
			{
				"a",
				"ai",
				"an",
				"ang",
				"ao",
				"ba",
				"bai",
				"ban",
				"bang",
				"bao",
				"bei",
				"ben",
				"beng",
				"bi",
				"bian",
				"biao",
				"bie",
				"bin",
				"bing",
				"bo",
				"bu",
				"ca",
				"cai",
				"can",
				"cang",
				"cao",
				"ce",
				"ceng",
				"cha",
				"chai",
				"chan",
				"chang",
				"chao",
				"che",
				"chen",
				"cheng",
				"chi",
				"chong",
				"chou",
				"chu",
				"chuai",
				"chuan",
				"chuang",
				"chui",
				"chun",
				"chuo",
				"ci",
				"cong",
				"cou",
				"cu",
				"cuan",
				"cui",
				"cun",
				"cuo",
				"da",
				"dai",
				"dan",
				"dang",
				"dao",
				"de",
				"deng",
				"di",
				"dian",
				"diao",
				"die",
				"ding",
				"diu",
				"dong",
				"dou",
				"du",
				"duan",
				"dui",
				"dun",
				"duo",
				"e",
				"en",
				"er",
				"fa",
				"fan",
				"fang",
				"fei",
				"fen",
				"feng",
				"fo",
				"fou",
				"fu",
				"ga",
				"gai",
				"gan",
				"gang",
				"gao",
				"ge",
				"gei",
				"gen",
				"geng",
				"gong",
				"gou",
				"gu",
				"gua",
				"guai",
				"guan",
				"guang",
				"gui",
				"gun",
				"guo",
				"ha",
				"hai",
				"han",
				"hang",
				"hao",
				"he",
				"hei",
				"hen",
				"heng",
				"hong",
				"hou",
				"hu",
				"hua",
				"huai",
				"huan",
				"huang",
				"hui",
				"hun",
				"huo",
				"ji",
				"jia",
				"jian",
				"jiang",
				"jiao",
				"jie",
				"jin",
				"jing",
				"jiong",
				"jiu",
				"ju",
				"juan",
				"jue",
				"jun",
				"ka",
				"kai",
				"kan",
				"kang",
				"kao",
				"ke",
				"ken",
				"keng",
				"kong",
				"kou",
				"ku",
				"kua",
				"kuai",
				"kuan",
				"kuang",
				"kui",
				"kun",
				"kuo",
				"la",
				"lai",
				"lan",
				"lang",
				"lao",
				"le",
				"lei",
				"leng",
				"li",
				"lia",
				"lian",
				"liang",
				"liao",
				"lie",
				"lin",
				"ling",
				"liu",
				"long",
				"lou",
				"lu",
				"lv",
				"luan",
				"lue",
				"lun",
				"luo",
				"ma",
				"mai",
				"man",
				"mang",
				"mao",
				"me",
				"mei",
				"men",
				"meng",
				"mi",
				"mian",
				"miao",
				"mie",
				"min",
				"ming",
				"miu",
				"mo",
				"mou",
				"mu",
				"na",
				"nai",
				"nan",
				"nang",
				"nao",
				"ne",
				"nei",
				"nen",
				"neng",
				"ni",
				"nian",
				"niang",
				"niao",
				"nie",
				"nin",
				"ning",
				"niu",
				"nong",
				"nu",
				"nv",
				"nuan",
				"nue",
				"nuo",
				"o",
				"ou",
				"pa",
				"pai",
				"pan",
				"pang",
				"pao",
				"pei",
				"pen",
				"peng",
				"pi",
				"pian",
				"piao",
				"pie",
				"pin",
				"ping",
				"po",
				"pu",
				"qi",
				"qia",
				"qian",
				"qiang",
				"qiao",
				"qie",
				"qin",
				"qing",
				"qiong",
				"qiu",
				"qu",
				"quan",
				"que",
				"qun",
				"ran",
				"rang",
				"rao",
				"re",
				"ren",
				"reng",
				"ri",
				"rong",
				"rou",
				"ru",
				"ruan",
				"rui",
				"run",
				"ruo",
				"sa",
				"sai",
				"san",
				"sang",
				"sao",
				"se",
				"sen",
				"seng",
				"sha",
				"shai",
				"shan",
				"shang",
				"shao",
				"she",
				"shen",
				"sheng",
				"shi",
				"shou",
				"shu",
				"shua",
				"shuai",
				"shuan",
				"shuang",
				"shui",
				"shun",
				"shuo",
				"si",
				"song",
				"sou",
				"su",
				"suan",
				"sui",
				"sun",
				"suo",
				"ta",
				"tai",
				"tan",
				"tang",
				"tao",
				"te",
				"teng",
				"ti",
				"tian",
				"tiao",
				"tie",
				"ting",
				"tong",
				"tou",
				"tu",
				"tuan",
				"tui",
				"tun",
				"tuo",
				"wa",
				"wai",
				"wan",
				"wang",
				"wei",
				"wen",
				"weng",
				"wo",
				"wu",
				"xi",
				"xia",
				"xian",
				"xiang",
				"xiao",
				"xie",
				"xin",
				"xing",
				"xiong",
				"xiu",
				"xu",
				"xuan",
				"xue",
				"xun",
				"ya",
				"yan",
				"yang",
				"yao",
				"ye",
				"yi",
				"yin",
				"ying",
				"yo",
				"yong",
				"you",
				"yu",
				"yuan",
				"yue",
				"yun",
				"za",
				"zai",
				"zan",
				"zang",
				"zao",
				"ze",
				"zei",
				"zen",
				"zeng",
				"zha",
				"zhai",
				"zhan",
				"zhang",
				"zhao",
				"zhe",
				"zhen",
				"zheng",
				"zhi",
				"zhong",
				"zhou",
				"zhu",
				"zhua",
				"zhuai",
				"zhuan",
				"zhuang",
				"zhui",
				"zhun",
				"zhuo",
				"zi",
				"zong",
				"zou",
				"zu",
				"zuan",
				"zui",
				"zun",
				"zuo"
			};
            byte[] array3 = new byte[2];
            string text = "";
            char[] array4 = x.ToCharArray();
            int arg_26EF_0 = 0;
            checked
            {
                int num = array4.Length - 1;
                int num2 = arg_26EF_0;
                while (true)
                {
                    int arg_279B_0 = num2;
                    int num3 = num;
                    if (arg_279B_0 > num3)
                    {
                        break;
                    }
                    array3 = Encoding.Default.GetBytes(array4[num2].ToString());
                    bool flag = array3[0] <= 160 && array3[0] >= 0;
                    if (flag)
                    {
                        text += Conversions.ToString(array4[num2]);
                    }
                    else
                    {
                        int num4 = array.Length - 1;
                        while (true)
                        {
                            int arg_2789_0 = num4;
                            num3 = 0;
                            if (arg_2789_0 < num3)
                            {
                                goto IL_278B;
                            }
                            flag = (array[num4] <= (int)array3[0] * 256 + (int)array3[1] - 65536);
                            if (flag)
                            {
                                break;
                            }
                            num4 += -1;
                        }
                        text += array2[num4];
                    }
                IL_278B:
                    num2++;
                }
                return text;
            }
        }
    }
}
