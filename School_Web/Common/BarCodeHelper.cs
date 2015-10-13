using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
namespace Wzsckj.com.Common
{
    public class BarCodeHelper
    {
        private static readonly int[,] cPatterns;
        private const int cQuietWidth = 10;
        static BarCodeHelper()
        {
            // Note: this type is marked as 'beforefieldinit'.
            int[,] array = new int[107, 8];
            array[0, 0] = 2;
            array[0, 1] = 1;
            array[0, 2] = 2;
            array[0, 3] = 2;
            array[0, 4] = 2;
            array[0, 5] = 2;
            array[0, 6] = 0;
            array[0, 7] = 0;
            array[1, 0] = 2;
            array[1, 1] = 2;
            array[1, 2] = 2;
            array[1, 3] = 1;
            array[1, 4] = 2;
            array[1, 5] = 2;
            array[1, 6] = 0;
            array[1, 7] = 0;
            array[2, 0] = 2;
            array[2, 1] = 2;
            array[2, 2] = 2;
            array[2, 3] = 2;
            array[2, 4] = 2;
            array[2, 5] = 1;
            array[2, 6] = 0;
            array[2, 7] = 0;
            array[3, 0] = 1;
            array[3, 1] = 2;
            array[3, 2] = 1;
            array[3, 3] = 2;
            array[3, 4] = 2;
            array[3, 5] = 3;
            array[3, 6] = 0;
            array[3, 7] = 0;
            array[4, 0] = 1;
            array[4, 1] = 2;
            array[4, 2] = 1;
            array[4, 3] = 3;
            array[4, 4] = 2;
            array[4, 5] = 2;
            array[4, 6] = 0;
            array[4, 7] = 0;
            array[5, 0] = 1;
            array[5, 1] = 3;
            array[5, 2] = 1;
            array[5, 3] = 2;
            array[5, 4] = 2;
            array[5, 5] = 2;
            array[5, 6] = 0;
            array[5, 7] = 0;
            array[6, 0] = 1;
            array[6, 1] = 2;
            array[6, 2] = 2;
            array[6, 3] = 2;
            array[6, 4] = 1;
            array[6, 5] = 3;
            array[6, 6] = 0;
            array[6, 7] = 0;
            array[7, 0] = 1;
            array[7, 1] = 2;
            array[7, 2] = 2;
            array[7, 3] = 3;
            array[7, 4] = 1;
            array[7, 5] = 2;
            array[7, 6] = 0;
            array[7, 7] = 0;
            array[8, 0] = 1;
            array[8, 1] = 3;
            array[8, 2] = 2;
            array[8, 3] = 2;
            array[8, 4] = 1;
            array[8, 5] = 2;
            array[8, 6] = 0;
            array[8, 7] = 0;
            array[9, 0] = 2;
            array[9, 1] = 2;
            array[9, 2] = 1;
            array[9, 3] = 2;
            array[9, 4] = 1;
            array[9, 5] = 3;
            array[9, 6] = 0;
            array[9, 7] = 0;
            array[10, 0] = 2;
            array[10, 1] = 2;
            array[10, 2] = 1;
            array[10, 3] = 3;
            array[10, 4] = 1;
            array[10, 5] = 2;
            array[10, 6] = 0;
            array[10, 7] = 0;
            array[11, 0] = 2;
            array[11, 1] = 3;
            array[11, 2] = 1;
            array[11, 3] = 2;
            array[11, 4] = 1;
            array[11, 5] = 2;
            array[11, 6] = 0;
            array[11, 7] = 0;
            array[12, 0] = 1;
            array[12, 1] = 1;
            array[12, 2] = 2;
            array[12, 3] = 2;
            array[12, 4] = 3;
            array[12, 5] = 2;
            array[12, 6] = 0;
            array[12, 7] = 0;
            array[13, 0] = 1;
            array[13, 1] = 2;
            array[13, 2] = 2;
            array[13, 3] = 1;
            array[13, 4] = 3;
            array[13, 5] = 2;
            array[13, 6] = 0;
            array[13, 7] = 0;
            array[14, 0] = 1;
            array[14, 1] = 2;
            array[14, 2] = 2;
            array[14, 3] = 2;
            array[14, 4] = 3;
            array[14, 5] = 1;
            array[14, 6] = 0;
            array[14, 7] = 0;
            array[15, 0] = 1;
            array[15, 1] = 1;
            array[15, 2] = 3;
            array[15, 3] = 2;
            array[15, 4] = 2;
            array[15, 5] = 2;
            array[15, 6] = 0;
            array[15, 7] = 0;
            array[16, 0] = 1;
            array[16, 1] = 2;
            array[16, 2] = 3;
            array[16, 3] = 1;
            array[16, 4] = 2;
            array[16, 5] = 2;
            array[16, 6] = 0;
            array[16, 7] = 0;
            array[17, 0] = 1;
            array[17, 1] = 2;
            array[17, 2] = 3;
            array[17, 3] = 2;
            array[17, 4] = 2;
            array[17, 5] = 1;
            array[17, 6] = 0;
            array[17, 7] = 0;
            array[18, 0] = 2;
            array[18, 1] = 2;
            array[18, 2] = 3;
            array[18, 3] = 2;
            array[18, 4] = 1;
            array[18, 5] = 1;
            array[18, 6] = 0;
            array[18, 7] = 0;
            array[19, 0] = 2;
            array[19, 1] = 2;
            array[19, 2] = 1;
            array[19, 3] = 1;
            array[19, 4] = 3;
            array[19, 5] = 2;
            array[19, 6] = 0;
            array[19, 7] = 0;
            array[20, 0] = 2;
            array[20, 1] = 2;
            array[20, 2] = 1;
            array[20, 3] = 2;
            array[20, 4] = 3;
            array[20, 5] = 1;
            array[20, 6] = 0;
            array[20, 7] = 0;
            array[21, 0] = 2;
            array[21, 1] = 1;
            array[21, 2] = 3;
            array[21, 3] = 2;
            array[21, 4] = 1;
            array[21, 5] = 2;
            array[21, 6] = 0;
            array[21, 7] = 0;
            array[22, 0] = 2;
            array[22, 1] = 2;
            array[22, 2] = 3;
            array[22, 3] = 1;
            array[22, 4] = 1;
            array[22, 5] = 2;
            array[22, 6] = 0;
            array[22, 7] = 0;
            array[23, 0] = 3;
            array[23, 1] = 1;
            array[23, 2] = 2;
            array[23, 3] = 1;
            array[23, 4] = 3;
            array[23, 5] = 1;
            array[23, 6] = 0;
            array[23, 7] = 0;
            array[24, 0] = 3;
            array[24, 1] = 1;
            array[24, 2] = 1;
            array[24, 3] = 2;
            array[24, 4] = 2;
            array[24, 5] = 2;
            array[24, 6] = 0;
            array[24, 7] = 0;
            array[25, 0] = 3;
            array[25, 1] = 2;
            array[25, 2] = 1;
            array[25, 3] = 1;
            array[25, 4] = 2;
            array[25, 5] = 2;
            array[25, 6] = 0;
            array[25, 7] = 0;
            array[26, 0] = 3;
            array[26, 1] = 2;
            array[26, 2] = 1;
            array[26, 3] = 2;
            array[26, 4] = 2;
            array[26, 5] = 1;
            array[26, 6] = 0;
            array[26, 7] = 0;
            array[27, 0] = 3;
            array[27, 1] = 1;
            array[27, 2] = 2;
            array[27, 3] = 2;
            array[27, 4] = 1;
            array[27, 5] = 2;
            array[27, 6] = 0;
            array[27, 7] = 0;
            array[28, 0] = 3;
            array[28, 1] = 2;
            array[28, 2] = 2;
            array[28, 3] = 1;
            array[28, 4] = 1;
            array[28, 5] = 2;
            array[28, 6] = 0;
            array[28, 7] = 0;
            array[29, 0] = 3;
            array[29, 1] = 2;
            array[29, 2] = 2;
            array[29, 3] = 2;
            array[29, 4] = 1;
            array[29, 5] = 1;
            array[29, 6] = 0;
            array[29, 7] = 0;
            array[30, 0] = 2;
            array[30, 1] = 1;
            array[30, 2] = 2;
            array[30, 3] = 1;
            array[30, 4] = 2;
            array[30, 5] = 3;
            array[30, 6] = 0;
            array[30, 7] = 0;
            array[31, 0] = 2;
            array[31, 1] = 1;
            array[31, 2] = 2;
            array[31, 3] = 3;
            array[31, 4] = 2;
            array[31, 5] = 1;
            array[31, 6] = 0;
            array[31, 7] = 0;
            array[32, 0] = 2;
            array[32, 1] = 3;
            array[32, 2] = 2;
            array[32, 3] = 1;
            array[32, 4] = 2;
            array[32, 5] = 1;
            array[32, 6] = 0;
            array[32, 7] = 0;
            array[33, 0] = 1;
            array[33, 1] = 1;
            array[33, 2] = 1;
            array[33, 3] = 3;
            array[33, 4] = 2;
            array[33, 5] = 3;
            array[33, 6] = 0;
            array[33, 7] = 0;
            array[34, 0] = 1;
            array[34, 1] = 3;
            array[34, 2] = 1;
            array[34, 3] = 1;
            array[34, 4] = 2;
            array[34, 5] = 3;
            array[34, 6] = 0;
            array[34, 7] = 0;
            array[35, 0] = 1;
            array[35, 1] = 3;
            array[35, 2] = 1;
            array[35, 3] = 3;
            array[35, 4] = 2;
            array[35, 5] = 1;
            array[35, 6] = 0;
            array[35, 7] = 0;
            array[36, 0] = 1;
            array[36, 1] = 1;
            array[36, 2] = 2;
            array[36, 3] = 3;
            array[36, 4] = 1;
            array[36, 5] = 3;
            array[36, 6] = 0;
            array[36, 7] = 0;
            array[37, 0] = 1;
            array[37, 1] = 3;
            array[37, 2] = 2;
            array[37, 3] = 1;
            array[37, 4] = 1;
            array[37, 5] = 3;
            array[37, 6] = 0;
            array[37, 7] = 0;
            array[38, 0] = 1;
            array[38, 1] = 3;
            array[38, 2] = 2;
            array[38, 3] = 3;
            array[38, 4] = 1;
            array[38, 5] = 1;
            array[38, 6] = 0;
            array[38, 7] = 0;
            array[39, 0] = 2;
            array[39, 1] = 1;
            array[39, 2] = 1;
            array[39, 3] = 3;
            array[39, 4] = 1;
            array[39, 5] = 3;
            array[39, 6] = 0;
            array[39, 7] = 0;
            array[40, 0] = 2;
            array[40, 1] = 3;
            array[40, 2] = 1;
            array[40, 3] = 1;
            array[40, 4] = 1;
            array[40, 5] = 3;
            array[40, 6] = 0;
            array[40, 7] = 0;
            array[41, 0] = 2;
            array[41, 1] = 3;
            array[41, 2] = 1;
            array[41, 3] = 3;
            array[41, 4] = 1;
            array[41, 5] = 1;
            array[41, 6] = 0;
            array[41, 7] = 0;
            array[42, 0] = 1;
            array[42, 1] = 1;
            array[42, 2] = 2;
            array[42, 3] = 1;
            array[42, 4] = 3;
            array[42, 5] = 3;
            array[42, 6] = 0;
            array[42, 7] = 0;
            array[43, 0] = 1;
            array[43, 1] = 1;
            array[43, 2] = 2;
            array[43, 3] = 3;
            array[43, 4] = 3;
            array[43, 5] = 1;
            array[43, 6] = 0;
            array[43, 7] = 0;
            array[44, 0] = 1;
            array[44, 1] = 3;
            array[44, 2] = 2;
            array[44, 3] = 1;
            array[44, 4] = 3;
            array[44, 5] = 1;
            array[44, 6] = 0;
            array[44, 7] = 0;
            array[45, 0] = 1;
            array[45, 1] = 1;
            array[45, 2] = 3;
            array[45, 3] = 1;
            array[45, 4] = 2;
            array[45, 5] = 3;
            array[45, 6] = 0;
            array[45, 7] = 0;
            array[46, 0] = 1;
            array[46, 1] = 1;
            array[46, 2] = 3;
            array[46, 3] = 3;
            array[46, 4] = 2;
            array[46, 5] = 1;
            array[46, 6] = 0;
            array[46, 7] = 0;
            array[47, 0] = 1;
            array[47, 1] = 3;
            array[47, 2] = 3;
            array[47, 3] = 1;
            array[47, 4] = 2;
            array[47, 5] = 1;
            array[47, 6] = 0;
            array[47, 7] = 0;
            array[48, 0] = 3;
            array[48, 1] = 1;
            array[48, 2] = 3;
            array[48, 3] = 1;
            array[48, 4] = 2;
            array[48, 5] = 1;
            array[48, 6] = 0;
            array[48, 7] = 0;
            array[49, 0] = 2;
            array[49, 1] = 1;
            array[49, 2] = 1;
            array[49, 3] = 3;
            array[49, 4] = 3;
            array[49, 5] = 1;
            array[49, 6] = 0;
            array[49, 7] = 0;
            array[50, 0] = 2;
            array[50, 1] = 3;
            array[50, 2] = 1;
            array[50, 3] = 1;
            array[50, 4] = 3;
            array[50, 5] = 1;
            array[50, 6] = 0;
            array[50, 7] = 0;
            array[51, 0] = 2;
            array[51, 1] = 1;
            array[51, 2] = 3;
            array[51, 3] = 1;
            array[51, 4] = 1;
            array[51, 5] = 3;
            array[51, 6] = 0;
            array[51, 7] = 0;
            array[52, 0] = 2;
            array[52, 1] = 1;
            array[52, 2] = 3;
            array[52, 3] = 3;
            array[52, 4] = 1;
            array[52, 5] = 1;
            array[52, 6] = 0;
            array[52, 7] = 0;
            array[53, 0] = 2;
            array[53, 1] = 1;
            array[53, 2] = 3;
            array[53, 3] = 1;
            array[53, 4] = 3;
            array[53, 5] = 1;
            array[53, 6] = 0;
            array[53, 7] = 0;
            array[54, 0] = 3;
            array[54, 1] = 1;
            array[54, 2] = 1;
            array[54, 3] = 1;
            array[54, 4] = 2;
            array[54, 5] = 3;
            array[54, 6] = 0;
            array[54, 7] = 0;
            array[55, 0] = 3;
            array[55, 1] = 1;
            array[55, 2] = 1;
            array[55, 3] = 3;
            array[55, 4] = 2;
            array[55, 5] = 1;
            array[55, 6] = 0;
            array[55, 7] = 0;
            array[56, 0] = 3;
            array[56, 1] = 3;
            array[56, 2] = 1;
            array[56, 3] = 1;
            array[56, 4] = 2;
            array[56, 5] = 1;
            array[56, 6] = 0;
            array[56, 7] = 0;
            array[57, 0] = 3;
            array[57, 1] = 1;
            array[57, 2] = 2;
            array[57, 3] = 1;
            array[57, 4] = 1;
            array[57, 5] = 3;
            array[57, 6] = 0;
            array[57, 7] = 0;
            array[58, 0] = 3;
            array[58, 1] = 1;
            array[58, 2] = 2;
            array[58, 3] = 3;
            array[58, 4] = 1;
            array[58, 5] = 1;
            array[58, 6] = 0;
            array[58, 7] = 0;
            array[59, 0] = 3;
            array[59, 1] = 3;
            array[59, 2] = 2;
            array[59, 3] = 1;
            array[59, 4] = 1;
            array[59, 5] = 1;
            array[59, 6] = 0;
            array[59, 7] = 0;
            array[60, 0] = 3;
            array[60, 1] = 1;
            array[60, 2] = 4;
            array[60, 3] = 1;
            array[60, 4] = 1;
            array[60, 5] = 1;
            array[60, 6] = 0;
            array[60, 7] = 0;
            array[61, 0] = 2;
            array[61, 1] = 2;
            array[61, 2] = 1;
            array[61, 3] = 4;
            array[61, 4] = 1;
            array[61, 5] = 1;
            array[61, 6] = 0;
            array[61, 7] = 0;
            array[62, 0] = 4;
            array[62, 1] = 3;
            array[62, 2] = 1;
            array[62, 3] = 1;
            array[62, 4] = 1;
            array[62, 5] = 1;
            array[62, 6] = 0;
            array[62, 7] = 0;
            array[63, 0] = 1;
            array[63, 1] = 1;
            array[63, 2] = 1;
            array[63, 3] = 2;
            array[63, 4] = 2;
            array[63, 5] = 4;
            array[63, 6] = 0;
            array[63, 7] = 0;
            array[64, 0] = 1;
            array[64, 1] = 1;
            array[64, 2] = 1;
            array[64, 3] = 4;
            array[64, 4] = 2;
            array[64, 5] = 2;
            array[64, 6] = 0;
            array[64, 7] = 0;
            array[65, 0] = 1;
            array[65, 1] = 2;
            array[65, 2] = 1;
            array[65, 3] = 1;
            array[65, 4] = 2;
            array[65, 5] = 4;
            array[65, 6] = 0;
            array[65, 7] = 0;
            array[66, 0] = 1;
            array[66, 1] = 2;
            array[66, 2] = 1;
            array[66, 3] = 4;
            array[66, 4] = 2;
            array[66, 5] = 1;
            array[66, 6] = 0;
            array[66, 7] = 0;
            array[67, 0] = 1;
            array[67, 1] = 4;
            array[67, 2] = 1;
            array[67, 3] = 1;
            array[67, 4] = 2;
            array[67, 5] = 2;
            array[67, 6] = 0;
            array[67, 7] = 0;
            array[68, 0] = 1;
            array[68, 1] = 4;
            array[68, 2] = 1;
            array[68, 3] = 2;
            array[68, 4] = 2;
            array[68, 5] = 1;
            array[68, 6] = 0;
            array[68, 7] = 0;
            array[69, 0] = 1;
            array[69, 1] = 1;
            array[69, 2] = 2;
            array[69, 3] = 2;
            array[69, 4] = 1;
            array[69, 5] = 4;
            array[69, 6] = 0;
            array[69, 7] = 0;
            array[70, 0] = 1;
            array[70, 1] = 1;
            array[70, 2] = 2;
            array[70, 3] = 4;
            array[70, 4] = 1;
            array[70, 5] = 2;
            array[70, 6] = 0;
            array[70, 7] = 0;
            array[71, 0] = 1;
            array[71, 1] = 2;
            array[71, 2] = 2;
            array[71, 3] = 1;
            array[71, 4] = 1;
            array[71, 5] = 4;
            array[71, 6] = 0;
            array[71, 7] = 0;
            array[72, 0] = 1;
            array[72, 1] = 2;
            array[72, 2] = 2;
            array[72, 3] = 4;
            array[72, 4] = 1;
            array[72, 5] = 1;
            array[72, 6] = 0;
            array[72, 7] = 0;
            array[73, 0] = 1;
            array[73, 1] = 4;
            array[73, 2] = 2;
            array[73, 3] = 1;
            array[73, 4] = 1;
            array[73, 5] = 2;
            array[73, 6] = 0;
            array[73, 7] = 0;
            array[74, 0] = 1;
            array[74, 1] = 4;
            array[74, 2] = 2;
            array[74, 3] = 2;
            array[74, 4] = 1;
            array[74, 5] = 1;
            array[74, 6] = 0;
            array[74, 7] = 0;
            array[75, 0] = 2;
            array[75, 1] = 4;
            array[75, 2] = 1;
            array[75, 3] = 2;
            array[75, 4] = 1;
            array[75, 5] = 1;
            array[75, 6] = 0;
            array[75, 7] = 0;
            array[76, 0] = 2;
            array[76, 1] = 2;
            array[76, 2] = 1;
            array[76, 3] = 1;
            array[76, 4] = 1;
            array[76, 5] = 4;
            array[76, 6] = 0;
            array[76, 7] = 0;
            array[77, 0] = 4;
            array[77, 1] = 1;
            array[77, 2] = 3;
            array[77, 3] = 1;
            array[77, 4] = 1;
            array[77, 5] = 1;
            array[77, 6] = 0;
            array[77, 7] = 0;
            array[78, 0] = 2;
            array[78, 1] = 4;
            array[78, 2] = 1;
            array[78, 3] = 1;
            array[78, 4] = 1;
            array[78, 5] = 2;
            array[78, 6] = 0;
            array[78, 7] = 0;
            array[79, 0] = 1;
            array[79, 1] = 3;
            array[79, 2] = 4;
            array[79, 3] = 1;
            array[79, 4] = 1;
            array[79, 5] = 1;
            array[79, 6] = 0;
            array[79, 7] = 0;
            array[80, 0] = 1;
            array[80, 1] = 1;
            array[80, 2] = 1;
            array[80, 3] = 2;
            array[80, 4] = 4;
            array[80, 5] = 2;
            array[80, 6] = 0;
            array[80, 7] = 0;
            array[81, 0] = 1;
            array[81, 1] = 2;
            array[81, 2] = 1;
            array[81, 3] = 1;
            array[81, 4] = 4;
            array[81, 5] = 2;
            array[81, 6] = 0;
            array[81, 7] = 0;
            array[82, 0] = 1;
            array[82, 1] = 2;
            array[82, 2] = 1;
            array[82, 3] = 2;
            array[82, 4] = 4;
            array[82, 5] = 1;
            array[82, 6] = 0;
            array[82, 7] = 0;
            array[83, 0] = 1;
            array[83, 1] = 1;
            array[83, 2] = 4;
            array[83, 3] = 2;
            array[83, 4] = 1;
            array[83, 5] = 2;
            array[83, 6] = 0;
            array[83, 7] = 0;
            array[84, 0] = 1;
            array[84, 1] = 2;
            array[84, 2] = 4;
            array[84, 3] = 1;
            array[84, 4] = 1;
            array[84, 5] = 2;
            array[84, 6] = 0;
            array[84, 7] = 0;
            array[85, 0] = 1;
            array[85, 1] = 2;
            array[85, 2] = 4;
            array[85, 3] = 2;
            array[85, 4] = 1;
            array[85, 5] = 1;
            array[85, 6] = 0;
            array[85, 7] = 0;
            array[86, 0] = 4;
            array[86, 1] = 1;
            array[86, 2] = 1;
            array[86, 3] = 2;
            array[86, 4] = 1;
            array[86, 5] = 2;
            array[86, 6] = 0;
            array[86, 7] = 0;
            array[87, 0] = 4;
            array[87, 1] = 2;
            array[87, 2] = 1;
            array[87, 3] = 1;
            array[87, 4] = 1;
            array[87, 5] = 2;
            array[87, 6] = 0;
            array[87, 7] = 0;
            array[88, 0] = 4;
            array[88, 1] = 2;
            array[88, 2] = 1;
            array[88, 3] = 2;
            array[88, 4] = 1;
            array[88, 5] = 1;
            array[88, 6] = 0;
            array[88, 7] = 0;
            array[89, 0] = 2;
            array[89, 1] = 1;
            array[89, 2] = 2;
            array[89, 3] = 1;
            array[89, 4] = 4;
            array[89, 5] = 1;
            array[89, 6] = 0;
            array[89, 7] = 0;
            array[90, 0] = 2;
            array[90, 1] = 1;
            array[90, 2] = 4;
            array[90, 3] = 1;
            array[90, 4] = 2;
            array[90, 5] = 1;
            array[90, 6] = 0;
            array[90, 7] = 0;
            array[91, 0] = 4;
            array[91, 1] = 1;
            array[91, 2] = 2;
            array[91, 3] = 1;
            array[91, 4] = 2;
            array[91, 5] = 1;
            array[91, 6] = 0;
            array[91, 7] = 0;
            array[92, 0] = 1;
            array[92, 1] = 1;
            array[92, 2] = 1;
            array[92, 3] = 1;
            array[92, 4] = 4;
            array[92, 5] = 3;
            array[92, 6] = 0;
            array[92, 7] = 0;
            array[93, 0] = 1;
            array[93, 1] = 1;
            array[93, 2] = 1;
            array[93, 3] = 3;
            array[93, 4] = 4;
            array[93, 5] = 1;
            array[93, 6] = 0;
            array[93, 7] = 0;
            array[94, 0] = 1;
            array[94, 1] = 3;
            array[94, 2] = 1;
            array[94, 3] = 1;
            array[94, 4] = 4;
            array[94, 5] = 1;
            array[94, 6] = 0;
            array[94, 7] = 0;
            array[95, 0] = 1;
            array[95, 1] = 1;
            array[95, 2] = 4;
            array[95, 3] = 1;
            array[95, 4] = 1;
            array[95, 5] = 3;
            array[95, 6] = 0;
            array[95, 7] = 0;
            array[96, 0] = 1;
            array[96, 1] = 1;
            array[96, 2] = 4;
            array[96, 3] = 3;
            array[96, 4] = 1;
            array[96, 5] = 1;
            array[96, 6] = 0;
            array[96, 7] = 0;
            array[97, 0] = 4;
            array[97, 1] = 1;
            array[97, 2] = 1;
            array[97, 3] = 1;
            array[97, 4] = 1;
            array[97, 5] = 3;
            array[97, 6] = 0;
            array[97, 7] = 0;
            array[98, 0] = 4;
            array[98, 1] = 1;
            array[98, 2] = 1;
            array[98, 3] = 3;
            array[98, 4] = 1;
            array[98, 5] = 1;
            array[98, 6] = 0;
            array[98, 7] = 0;
            array[99, 0] = 1;
            array[99, 1] = 1;
            array[99, 2] = 3;
            array[99, 3] = 1;
            array[99, 4] = 4;
            array[99, 5] = 1;
            array[99, 6] = 0;
            array[99, 7] = 0;
            array[100, 0] = 1;
            array[100, 1] = 1;
            array[100, 2] = 4;
            array[100, 3] = 1;
            array[100, 4] = 3;
            array[100, 5] = 1;
            array[100, 6] = 0;
            array[100, 7] = 0;
            array[101, 0] = 3;
            array[101, 1] = 1;
            array[101, 2] = 1;
            array[101, 3] = 1;
            array[101, 4] = 4;
            array[101, 5] = 1;
            array[101, 6] = 0;
            array[101, 7] = 0;
            array[102, 0] = 4;
            array[102, 1] = 1;
            array[102, 2] = 1;
            array[102, 3] = 1;
            array[102, 4] = 3;
            array[102, 5] = 1;
            array[102, 6] = 0;
            array[102, 7] = 0;
            array[103, 0] = 2;
            array[103, 1] = 1;
            array[103, 2] = 1;
            array[103, 3] = 4;
            array[103, 4] = 1;
            array[103, 5] = 2;
            array[103, 6] = 0;
            array[103, 7] = 0;
            array[104, 0] = 2;
            array[104, 1] = 1;
            array[104, 2] = 1;
            array[104, 3] = 2;
            array[104, 4] = 1;
            array[104, 5] = 4;
            array[104, 6] = 0;
            array[104, 7] = 0;
            array[105, 0] = 2;
            array[105, 1] = 1;
            array[105, 2] = 1;
            array[105, 3] = 2;
            array[105, 4] = 3;
            array[105, 5] = 2;
            array[105, 6] = 0;
            array[105, 7] = 0;
            array[106, 0] = 2;
            array[106, 1] = 3;
            array[106, 2] = 3;
            array[106, 3] = 1;
            array[106, 4] = 1;
            array[106, 5] = 1;
            array[106, 6] = 2;
            array[106, 7] = 0;
            BarCodeHelper.cPatterns = array;
        }
        [DebuggerNonUserCode]
        public BarCodeHelper()
        {
        }
        public static string get39(string s, int width, int height)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add('A', "110101001011");
            hashtable.Add('B', "101101001011");
            hashtable.Add('C', "110110100101");
            hashtable.Add('D', "101011001011");
            hashtable.Add('E', "110101100101");
            hashtable.Add('F', "101101100101");
            hashtable.Add('G', "101010011011");
            hashtable.Add('H', "110101001101");
            hashtable.Add('I', "101101001101");
            hashtable.Add('J', "101011001101");
            hashtable.Add('K', "110101010011");
            hashtable.Add('L', "101101010011");
            hashtable.Add('M', "110110101001");
            hashtable.Add('N', "101011010011");
            hashtable.Add('O', "110101101001");
            hashtable.Add('P', "101101101001");
            hashtable.Add('Q', "101010110011");
            hashtable.Add('R', "110101011001");
            hashtable.Add('S', "101101011001");
            hashtable.Add('T', "101011011001");
            hashtable.Add('U', "110010101011");
            hashtable.Add('V', "100110101011");
            hashtable.Add('W', "110011010101");
            hashtable.Add('X', "100101101011");
            hashtable.Add('Y', "110010110101");
            hashtable.Add('Z', "100110110101");
            hashtable.Add('0', "101001101101");
            hashtable.Add('1', "110100101011");
            hashtable.Add('2', "101100101011");
            hashtable.Add('3', "110110010101");
            hashtable.Add('4', "101001101011");
            hashtable.Add('5', "110100110101");
            hashtable.Add('6', "101100110101");
            hashtable.Add('7', "101001011011");
            hashtable.Add('8', "110100101101");
            hashtable.Add('9', "101100101101");
            hashtable.Add('+', "100101001001");
            hashtable.Add('-', "100101011011");
            hashtable.Add('*', "100101101101");
            hashtable.Add('/', "100100101001");
            hashtable.Add('%', "101001001001");
            hashtable.Add('$', "100100100101");
            hashtable.Add('.', "110010101101");
            hashtable.Add(' ', "100110101101");
            s = s.ToUpper();
            string text = "";
            checked
            {
                string result;
                try
                {
                    string text2 = s;
                    int i = 0;
                    int length = text2.Length;
                    while (i < length)
                    {
                        char c = text2[i];
                        text += hashtable[c].ToString();
                        text += "0";
                        i++;
                    }
                }
                catch (Exception arg_3B5_0)
                {
                    ProjectData.SetProjectError(arg_3B5_0);
                    result = "存在不允许的字符！";
                    ProjectData.ClearProjectError();
                    return result;
                }
                string text3 = "";
                string text4 = text;
                int j = 0;
                int length2 = text4.Length;
                while (j < length2)
                {
                    char c2 = text4[j];
                    string text5 = (c2 == '0') ? "#FFFFFF" : "#000000";
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(height),
						"px;float:left;background:",
						text5,
						";\"></div>"
					});
                    j++;
                }
                text3 += "<div style=\"clear:both\"></div>";
                int length3 = hashtable['*'].ToString().Length;
                string text6 = s;
                int k = 0;
                int length4 = text6.Length;
                while (k < length4)
                {
                    char value = text6[k];
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"width:",
						Conversions.ToString(width * (length3 + 1)),
						"px;float:left;color:#000000;text-align:center;\">",
						Conversions.ToString(value),
						"</div>"
					});
                    k++;
                }
                text3 += "<div style=\"clear:both\"></div>";
                result = string.Concat(new string[]
				{
					"<div style=\"background:#FFFFFF;padding:5px;font-size:",
					Conversions.ToString(width * 10),
					"px;font-family:'楷体';\">",
					text3,
					"</div>"
				});
                return result;
            }
        }
        public static string getEAN13(string s, int width, int height)
        {
            int num = -1;
            bool flag = !Regex.IsMatch(s, "^\\d{12}$");
            if (flag)
            {
                bool flag2 = !Regex.IsMatch(s, "^\\d{13}$");
                if (flag2)
                {
                    string result = "存在不允许的字符！";
                    return result;
                }
                num = int.Parse(s[12].ToString());
                s = s.Substring(0, 12);
            }
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            checked
            {
                bool flag2;
                int arg_BC_0;
                int num5;
                do
                {
                    flag2 = (num4 % 2 == 0);
                    if (flag2)
                    {
                        num3 += int.Parse(s[num4].ToString());
                    }
                    else
                    {
                        num2 += int.Parse(s[num4].ToString());
                    }
                    num4++;
                    arg_BC_0 = num4;
                    num5 = 11;
                }
                while (arg_BC_0 <= num5);
                int num6 = (10 - (num2 * 3 + num3) % 10) % 10;
                flag2 = (num > 0 && num != num6);
                string result;
                if (flag2)
                {
                    result = "输入的校验码错误！";
                }
                else
                {
                    s = Conversions.ToString(unchecked(Conversions.ToDouble(s) + (double)num6));
                    string text = "";
                    text += "000000000101";
                    string text2 = BarCodeHelper.ean13type(s[0]);
                    int num7 = 1;
                    int arg_153_0;
                    do
                    {
                        text += BarCodeHelper.ean13(s[num7], text2[num7 - 1]);
                        num7++;
                        arg_153_0 = num7;
                        num5 = 6;
                    }
                    while (arg_153_0 <= num5);
                    text += "01010";
                    int num8 = 7;
                    int arg_18D_0;
                    do
                    {
                        text += BarCodeHelper.ean13(s[num8], 'C');
                        num8++;
                        arg_18D_0 = num8;
                        num5 = 12;
                    }
                    while (arg_18D_0 <= num5);
                    text += "101000000000";
                    string text3 = "";
                    int value = width * 5;
                    string text4 = text;
                    int i = 0;
                    int length = text4.Length;
                    while (i < length)
                    {
                        char c = text4[i];
                        string text5 = (c == '0') ? "#FFFFFF" : "#000000";
                        text3 = string.Concat(new string[]
						{
							text3,
							"<div style=\"width:",
							Conversions.ToString(width),
							"px;height:",
							Conversions.ToString(height),
							"px;float:left;background:",
							text5,
							";\"></div>"
						});
                        i++;
                    }
                    text3 += "<div style=\"clear:both\"></div>";
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;color:#000000;width:",
						Conversions.ToString(width * 9),
						"px;text-align:center;\">",
						Conversions.ToString(s[0]),
						"</div>"
					});
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(value),
						"px;background:#000000;\"></div>"
					});
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(value),
						"px;background:#FFFFFF;\"></div>"
					});
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(value),
						"px;background:#000000;\"></div>"
					});
                    int num9 = 1;
                    int arg_404_0;
                    do
                    {
                        text3 = string.Concat(new string[]
						{
							text3,
							"<div style=\"float:left;width:",
							Conversions.ToString(width * 7),
							"px;color:#000000;text-align:center;\">",
							Conversions.ToString(s[num9]),
							"</div>"
						});
                        num9++;
                        arg_404_0 = num9;
                        num5 = 6;
                    }
                    while (arg_404_0 <= num5);
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(value),
						"px;background:#FFFFFF;\"></div>"
					});
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(value),
						"px;background:#000000;\"></div>"
					});
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(value),
						"px;background:#FFFFFF;\"></div>"
					});
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(value),
						"px;background:#000000;\"></div>"
					});
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(value),
						"px;background:#FFFFFF;\"></div>"
					});
                    int num10 = 7;
                    int arg_5EE_0;
                    do
                    {
                        text3 = string.Concat(new string[]
						{
							text3,
							"<div style=\"float:left;width:",
							Conversions.ToString(width * 7),
							"px;color:#000000;text-align:center;\">",
							Conversions.ToString(s[num10]),
							"</div>"
						});
                        num10++;
                        arg_5EE_0 = num10;
                        num5 = 12;
                    }
                    while (arg_5EE_0 <= num5);
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(value),
						"px;background:#000000;\"></div>"
					});
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(value),
						"px;background:#FFFFFF;\"></div>"
					});
                    text3 = string.Concat(new string[]
					{
						text3,
						"<div style=\"float:left;width:",
						Conversions.ToString(width),
						"px;height:",
						Conversions.ToString(value),
						"px;background:#000000;\"></div>"
					});
                    text3 = text3 + "<div style=\"float:left;color:#000000;width:" + Conversions.ToString(width * 9) + "px;\"></div>";
                    text3 += "<div style=\"clear:both\"></div>";
                    result = string.Concat(new string[]
					{
						"<div style=\"background:#FFFFFF;padding:0px;font-size:",
						Conversions.ToString(width * 10),
						"px;font-family:'楷体';\">",
						text3,
						"</div>"
					});
                }
                return result;
            }
        }
        private static string ean13(char c, char type)
        {
            string result="";
            switch (type)
            {
                case 'A':
                    {
                        bool flag = true;
                        if (flag)
                        {
                            switch (c)
                            {
                                case '0':
                                    result = "0001101";
                                    break;
                                case '1':
                                    result = "0011001";
                                    break;
                                case '2':
                                    result = "0010011";
                                    break;
                                case '3':
                                    result = "0111101";
                                    break;
                                case '4':
                                    result = "0100011";
                                    break;
                                case '5':
                                    result = "0110001";
                                    break;
                                case '6':
                                    result = "0101111";
                                    break;
                                case '7':
                                    result = "0111011";
                                    break;
                                case '8':
                                    result = "0110111";
                                    break;
                                case '9':
                                    result = "0001011";
                                    break;
                                default:
                                    result = "Error!";
                                    break;
                            }
                        }
                        break;
                    }
                case 'B':
                    {
                        bool flag = true;
                        if (flag)
                        {
                            switch (c)
                            {
                                case '0':
                                    result = "0100111";
                                    break;
                                case '1':
                                    result = "0110011";
                                    break;
                                case '2':
                                    result = "0011011";
                                    break;
                                case '3':
                                    result = "0100001";
                                    break;
                                case '4':
                                    result = "0011101";
                                    break;
                                case '5':
                                    result = "0111001";
                                    break;
                                case '6':
                                    result = "0000101";
                                    break;
                                case '7':
                                    result = "0010001";
                                    break;
                                case '8':
                                    result = "0001001";
                                    break;
                                case '9':
                                    result = "0010111";
                                    break;
                                default:
                                    result = "Error!";
                                    break;
                            }
                        }
                        break;
                    }
                case 'C':
                    {
                        bool flag = true;
                        if (flag)
                        {
                            switch (c)
                            {
                                case '0':
                                    result = "1110010";
                                    break;
                                case '1':
                                    result = "1100110";
                                    break;
                                case '2':
                                    result = "1101100";
                                    break;
                                case '3':
                                    result = "1000010";
                                    break;
                                case '4':
                                    result = "1011100";
                                    break;
                                case '5':
                                    result = "1001110";
                                    break;
                                case '6':
                                    result = "1010000";
                                    break;
                                case '7':
                                    result = "1000100";
                                    break;
                                case '8':
                                    result = "1001000";
                                    break;
                                case '9':
                                    result = "1110100";
                                    break;
                                default:
                                    result = "Error!";
                                    break;
                            }
                        }
                        break;
                    }
                default:
                    result = "Error!";
                    break;
            }
            return result;
        }
        private static string ean13type(char c)
        {
            string result;
            switch (c)
            {
                case '0':
                    result = "AAAAAA";
                    break;
                case '1':
                    result = "AABABB";
                    break;
                case '2':
                    result = "AABBAB";
                    break;
                case '3':
                    result = "AABBBA";
                    break;
                case '4':
                    result = "ABAABB";
                    break;
                case '5':
                    result = "ABBAAB";
                    break;
                case '6':
                    result = "ABBBAA";
                    break;
                case '7':
                    result = "ABABAB";
                    break;
                case '8':
                    result = "ABABBA";
                    break;
                case '9':
                    result = "ABBABA";
                    break;
                default:
                    result = "Error!";
                    break;
            }
            return result;
        }
        public static Image MakeBarcodeImage(string InputData, int BarWeight, bool AddQuietZone)
        {
            Code128Content code128Content = new Code128Content(InputData);
            int[] codes = code128Content.Codes;
            int num = checked(((codes.Length - 3) * 11 + 35) * BarWeight);
            int num2 = Convert.ToInt32(Math.Ceiling((double)(Convert.ToSingle(num) * 0.15f)));
            checked
            {
                if (AddQuietZone)
                {
                    num += 20;
                }
                num2 += 30;
                Image image = new Bitmap(num, num2);
                Graphics graphics = Graphics.FromImage(image);
                try
                {
                    graphics.FillRectangle(Brushes.White, 0, 0, num, num2);
                    int num3 = AddQuietZone ? 10 : 0;
                    int arg_84_0 = 0;
                    int num4 = codes.Length - 1;
                    int num5 = arg_84_0;
                    while (true)
                    {
                        int arg_102_0 = num5;
                        int num6 = num4;
                        if (arg_102_0 > num6)
                        {
                            break;
                        }
                        int num7 = codes[num5];
                        int num8 = 0;
                        int arg_F1_0;
                        do
                        {
                            int num9 = BarCodeHelper.cPatterns[num7, num8] * BarWeight;
                            int num10 = BarCodeHelper.cPatterns[num7, num8 + 1] * BarWeight;
                            bool flag = num9 > 0;
                            if (flag)
                            {
                                graphics.FillRectangle(Brushes.Black, num3, 5, num9, num2 - 20);
                            }
                            num3 += num9 + num10;
                            num8 += 2;
                            arg_F1_0 = num8;
                            num6 = 7;
                        }
                        while (arg_F1_0 <= num6);
                        num5++;
                    }
                    Graphics arg_12F_0 = graphics;
                    Font arg_12F_2 = new Font("Arial", 9f);
                    Brush arg_12F_3 = Brushes.Black;
                    PointF point = new PointF(10f, (float)(num2 - 15));
                    arg_12F_0.DrawString(InputData, arg_12F_2, arg_12F_3, point);
                }
                finally
                {
                    bool flag = graphics != null;
                    if (flag)
                    {
                        ((IDisposable)graphics).Dispose();
                    }
                }
                return image;
            }
        }
    }
}
