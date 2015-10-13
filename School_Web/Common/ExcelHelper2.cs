using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NPOI.HSSF.UserModel;
using StringHandling;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Web;
namespace Wzsckj.com.Common
{
    public class ExcelHelper2
    {
        [DebuggerNonUserCode]
        public ExcelHelper2()
        {
        }
        private static Stream ExportDataSetToExcel(DataSet sourceDs, string sheetName)
        {
            HSSFWorkbook hSSFWorkbook = new HSSFWorkbook();
            MemoryStream memoryStream = new MemoryStream();
            string[] array = sheetName.Split(new char[]
			{
				','
			});
            int arg_2C_0 = 0;
            checked
            {
                int num = array.Length - 1;
                int num2 = arg_2C_0;
                while (true)
                {
                    int arg_1D5_0 = num2;
                    int num3 = num;
                    if (arg_1D5_0 > num3)
                    {
                        break;
                    }
                    HSSFSheet hSSFSheet = (HSSFSheet)hSSFWorkbook.CreateSheet(array[num2]);
                    HSSFRow hSSFRow = (HSSFRow)hSSFSheet.CreateRow(0);
                    IEnumerator enumerator=null ;
                    try
                    {
                          enumerator = sourceDs.Tables[num2].Columns.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            DataColumn dataColumn = (DataColumn)enumerator.Current;
                            hSSFRow.CreateCell(dataColumn.Ordinal).SetCellValue(dataColumn.ColumnName);
                        }
                    }
                    finally
                    {
                        
                        bool flag = enumerator is IDisposable;
                        if (flag)
                        {
                            (enumerator as IDisposable).Dispose();
                        }
                    }
                    int num4 = 1;
                    IEnumerator enumerator2 = null;
                    try
                    {
                          enumerator2 = sourceDs.Tables[num2].Rows.GetEnumerator();
                        while (enumerator2.MoveNext())
                        {
                            DataRow dataRow = (DataRow)enumerator2.Current;
                            HSSFRow hSSFRow2 = (HSSFRow)hSSFSheet.CreateRow(num4);
                            IEnumerator enumerator3 = null;
                            try
                            {
                                  enumerator3 = sourceDs.Tables[num2].Columns.GetEnumerator();
                                while (enumerator3.MoveNext())
                                {
                                    DataColumn dataColumn2 = (DataColumn)enumerator3.Current;
                                    hSSFRow2.CreateCell(dataColumn2.Ordinal).SetCellValue(dataRow[dataColumn2].ToString());
                                }
                            }
                            finally
                            {
                               
                                bool flag = enumerator3 is IDisposable;
                                if (flag)
                                {
                                    (enumerator3 as IDisposable).Dispose();
                                }
                            }
                            num4++;
                        }
                    }
                    finally
                    {
                        
                        bool flag = enumerator2 is IDisposable;
                        if (flag)
                        {
                            (enumerator2 as IDisposable).Dispose();
                        }
                    }
                    num2++;
                }
                hSSFWorkbook.Write(memoryStream);
                memoryStream.Flush();
                memoryStream.Position = 0L;
                hSSFWorkbook = null;
                return memoryStream;
            }
        }
        public static void ExportDataSetToExcel(DataSet sourceDs, string fileName, string sheetName)
        {
            MemoryStream memoryStream = ExcelHelper2.ExportDataSetToExcel(sourceDs, sheetName) as MemoryStream;
            HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename=" + fileName);
            HttpContext.Current.Response.BinaryWrite(memoryStream.ToArray());
            HttpContext.Current.Response.End();
            memoryStream.Close();
        }
        private static Stream ExportDataTableToExcel(DataTable sourceTable, string sheetName)
        {
            HSSFWorkbook hSSFWorkbook = new HSSFWorkbook();
            MemoryStream memoryStream = new MemoryStream();
            HSSFSheet hSSFSheet = (HSSFSheet)hSSFWorkbook.CreateSheet(sheetName);
            HSSFRow hSSFRow = (HSSFRow)hSSFSheet.CreateRow(0);
            IEnumerator enumerator = null;
            try
            {
                  enumerator = sourceTable.Columns.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    DataColumn dataColumn = (DataColumn)enumerator.Current;
                    hSSFRow.CreateCell(dataColumn.Ordinal).SetCellValue(dataColumn.ColumnName);
                }
            }
            finally
            {
                
                bool flag = enumerator is IDisposable;
                if (flag)
                {
                    (enumerator as IDisposable).Dispose();
                }
            }
            int num = 1;
            checked
            {
                IEnumerator enumerator2 = null;
                try
                {
                      enumerator2 = sourceTable.Rows.GetEnumerator();
                    while (enumerator2.MoveNext())
                    {
                        DataRow dataRow = (DataRow)enumerator2.Current;
                        HSSFRow hSSFRow2 = (HSSFRow)hSSFSheet.CreateRow(num);
                        IEnumerator enumerator3= null;
                        try
                        {
                              enumerator3 = sourceTable.Columns.GetEnumerator();
                            while (enumerator3.MoveNext())
                            {
                                DataColumn dataColumn2 = (DataColumn)enumerator3.Current;
                                hSSFRow2.CreateCell(dataColumn2.Ordinal).SetCellValue(dataRow[dataColumn2].ToString());
                            }
                        }
                        finally
                        {
                          
                            bool flag = enumerator3 is IDisposable;
                            if (flag)
                            {
                                (enumerator3 as IDisposable).Dispose();
                            }
                        }
                        num++;
                    }
                }
                finally
                {
                   
                    bool flag = enumerator2 is IDisposable;
                    if (flag)
                    {
                        (enumerator2 as IDisposable).Dispose();
                    }
                }
                hSSFWorkbook.Write(memoryStream);
                memoryStream.Flush();
                memoryStream.Position = 0L;
                hSSFSheet = null;
                hSSFWorkbook = null;
                return memoryStream;
            }
        }
        public static void ExportDataTableToExcel(DataTable sourceTable, string fileName, string sheetName)
        {
            MemoryStream memoryStream = ExcelHelper2.ExportDataTableToExcel(sourceTable, sheetName) as MemoryStream;
            string extension = Path.GetExtension(fileName);
            HttpContext.Current.Response.ContentType = StringHandling.String.GetMimeType(extension);
            bool flag = HttpContext.Current.Request.UserAgent.ToLower().Contains("msie");
            if (flag)
            {
                fileName = StringHandling.String.ToHexString(fileName);
            }
            HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename=" + fileName);
            HttpContext.Current.Response.BinaryWrite(memoryStream.ToArray());
            HttpContext.Current.Response.End();
            memoryStream.Close();
        }
        public static DataTable ImportDataTableFromExcel(Stream excelFileStream, string sheetName, int headerRowIndex)
        {
            HSSFWorkbook hSSFWorkbook = new HSSFWorkbook(excelFileStream);
            HSSFSheet hSSFSheet = (HSSFSheet)hSSFWorkbook.GetSheet(sheetName);
            DataTable dataTable = new DataTable();
            HSSFRow hSSFRow = (HSSFRow)hSSFSheet.GetRow(headerRowIndex);
            int lastCellNum = (int)hSSFRow.LastCellNum;
            int arg_3D_0 = (int)hSSFRow.FirstCellNum;
            checked
            {
                int num = lastCellNum - 1;
                int num2 = arg_3D_0;
                while (true)
                {
                    int arg_73_0 = num2;
                    int num3 = num;
                    if (arg_73_0 > num3)
                    {
                        break;
                    }
                    DataColumn column = new DataColumn(hSSFRow.GetCell(num2).StringCellValue);
                    dataTable.Columns.Add(column);
                    num2++;
                }
                int arg_85_0 = hSSFSheet.FirstRowNum + 1;
                int lastRowNum = hSSFSheet.LastRowNum;
                int num4 = arg_85_0;
                while (true)
                {
                    int arg_E9_0 = num4;
                    int num3 = lastRowNum;
                    if (arg_E9_0 > num3)
                    {
                        break;
                    }
                    HSSFRow hSSFRow2 = (HSSFRow)hSSFSheet.GetRow(num4);
                    DataRow dataRow = dataTable.NewRow();
                    int arg_AD_0 = (int)hSSFRow2.FirstCellNum;
                    int num5 = lastCellNum - 1;
                    int num6 = arg_AD_0;
                    while (true)
                    {
                        int arg_D8_0 = num6;
                        num3 = num5;
                        if (arg_D8_0 > num3)
                        {
                            break;
                        }
                        dataRow[num6] = hSSFRow2.GetCell(num6).ToString();
                        num6++;
                    }
                    num4++;
                }
                excelFileStream.Close();
                return dataTable;
            }
        }
        public static DataTable ImportDataTableFromExcel(string excelFilePath, string sheetName, int headerRowIndex)
        {
            FileStream fileStream = File.OpenRead(excelFilePath);
            DataTable result;
            try
            {
                result = ExcelHelper2.ImportDataTableFromExcel(fileStream, sheetName, headerRowIndex);
            }
            finally
            {
                bool flag = fileStream != null;
                if (flag)
                {
                    ((IDisposable)fileStream).Dispose();
                }
            }
            return result;
        }
        public static DataTable ImportDataTableFromExcel(Stream excelFileStream, int sheetIndex, int headerRowIndex)
        {
            HSSFWorkbook hSSFWorkbook = new HSSFWorkbook(excelFileStream);
            HSSFSheet hSSFSheet = (HSSFSheet)hSSFWorkbook.GetSheetAt(sheetIndex);
            DataTable dataTable = new DataTable();
            HSSFRow hSSFRow = (HSSFRow)hSSFSheet.GetRow(headerRowIndex);
            int num = (int)hSSFRow.LastCellNum;
            int arg_3D_0 = (int)hSSFRow.FirstCellNum;
            checked
            {
                int num2 = num - 1;
                int num3 = arg_3D_0;
                while (true)
                {
                    int arg_B1_0 = num3;
                    int num4 = num2;
                    if (arg_B1_0 > num4)
                    {
                        goto IL_B3;
                    }
                    bool flag = hSSFRow.GetCell(num3) == null || Operators.CompareString(hSSFRow.GetCell(num3).StringCellValue.Trim(), "", false) == 0;
                    if (flag)
                    {
                        break;
                    }
                    DataColumn column = new DataColumn(hSSFRow.GetCell(num3).StringCellValue);
                    dataTable.Columns.Add(column);
                    num3++;
                }
                num = num3 + 1;
            IL_B3:
                int arg_C3_0 = hSSFSheet.FirstRowNum + 1;
                int lastRowNum = hSSFSheet.LastRowNum;
                int num5 = arg_C3_0;
                while (true)
                {
                    int arg_173_0 = num5;
                    int num4 = lastRowNum;
                    if (arg_173_0 > num4)
                    {
                        break;
                    }
                    HSSFRow hSSFRow2 = (HSSFRow)hSSFSheet.GetRow(num5);
                    if (hSSFRow2 == null || hSSFRow2.GetCell(0) == null)
                    {
                        goto IL_10C;
                    }
                    if (Operators.CompareString(hSSFRow2.GetCell(0).ToString().Trim(), "", false) == 0)
                    {
                        goto IL_10C;
                    }
                    bool arg_10E_0 = false;
                IL_10D:
                    bool flag = arg_10E_0;
                    if (flag)
                    {
                        break;
                    }
                    DataRow dataRow = dataTable.NewRow();
                    int arg_12D_0 = (int)hSSFRow2.FirstCellNum;
                    int num6 = num - 1;
                    int num7 = arg_12D_0;
                    while (true)
                    {
                        int arg_153_0 = num7;
                        num4 = num6;
                        if (arg_153_0 > num4)
                        {
                            break;
                        }
                        dataRow[num7] = hSSFRow2.GetCell(num7);
                        num7++;
                    }
                    dataTable.Rows.Add(dataRow);
                    num5++;
                    continue;
                IL_10C:
                    arg_10E_0 = true;
                    goto IL_10D;
                }
                excelFileStream.Close();
                return dataTable;
            }
        }
        public static DataTable ImportDataTableFromExcel(string excelFilePath, int sheetIndex, int headerRowIndex)
        {
            FileStream fileStream = File.OpenRead(excelFilePath);
            DataTable result;
            try
            {
                result = ExcelHelper2.ImportDataTableFromExcel(fileStream, sheetIndex, headerRowIndex);
            }
            finally
            {
                bool flag = fileStream != null;
                if (flag)
                {
                    ((IDisposable)fileStream).Dispose();
                }
            }
            return result;
        }
        public static DataSet ImportDataSetFromExcel(Stream excelFileStream, int headerRowIndex)
        {
            DataSet dataSet = new DataSet();
            HSSFWorkbook hSSFWorkbook = new HSSFWorkbook(excelFileStream);
            int i = 0;
            int numberOfSheets = hSSFWorkbook.NumberOfSheets;
            checked
            {
                while (i < numberOfSheets)
                {
                    HSSFSheet hSSFSheet = (HSSFSheet)hSSFWorkbook.GetSheetAt(i);
                    DataTable dataTable = new DataTable();
                    HSSFRow hSSFRow = (HSSFRow)hSSFSheet.GetRow(headerRowIndex);
                    int num = (int)hSSFRow.LastCellNum;
                    int arg_59_0 = (int)hSSFRow.FirstCellNum;
                    int num2 = num - 1;
                    int num3 = arg_59_0;
                    while (true)
                    {
                        int arg_D1_0 = num3;
                        int num4 = num2;
                        if (arg_D1_0 > num4)
                        {
                            break;
                        }
                        bool flag = hSSFRow.GetCell(num3) == null || Operators.CompareString(hSSFRow.GetCell(num3).StringCellValue.Trim(), "", false) == 0;
                        if (flag)
                        {
                            goto Block_3;
                        }
                        DataColumn column = new DataColumn(hSSFRow.GetCell(num3).StringCellValue);
                        dataTable.Columns.Add(column);
                        num3++;
                    }
                IL_D3:
                    int arg_E5_0 = hSSFSheet.FirstRowNum + 1;
                    int lastRowNum = hSSFSheet.LastRowNum;
                    int num5 = arg_E5_0;
                    while (true)
                    {
                        int arg_1B2_0 = num5;
                        int num4 = lastRowNum;
                        if (arg_1B2_0 > num4)
                        {
                            break;
                        }
                        HSSFRow hSSFRow2 = (HSSFRow)hSSFSheet.GetRow(num5);
                        if (hSSFRow2 == null || hSSFRow2.GetCell(0) == null)
                        {
                            goto IL_12F;
                        }
                        if (Operators.CompareString(hSSFRow2.GetCell(0).ToString().Trim(), "", false) == 0)
                        {
                            goto IL_12F;
                        }
                        bool arg_131_0 = false;
                    IL_130:
                        bool flag = arg_131_0;
                        if (flag)
                        {
                            break;
                        }
                        DataRow dataRow = dataTable.NewRow();
                        int arg_151_0 = (int)hSSFRow2.FirstCellNum;
                        int num6 = num - 1;
                        int num7 = arg_151_0;
                        while (true)
                        {
                            int arg_192_0 = num7;
                            num4 = num6;
                            if (arg_192_0 > num4)
                            {
                                break;
                            }
                            flag = (hSSFRow2.GetCell(num7) != null);
                            if (flag)
                            {
                                dataRow[num7] = hSSFRow2.GetCell(num7).ToString();
                            }
                            num7++;
                        }
                        dataTable.Rows.Add(dataRow);
                        num5++;
                        continue;
                    IL_12F:
                        arg_131_0 = true;
                        goto IL_130;
                    }
                IL_1B7:
                    dataSet.Tables.Add(dataTable);
                    i++;
                    continue;
                    goto IL_1B7;
                Block_3:
                    num = num3 + 1;
                    goto IL_D3;
                }
                excelFileStream.Close();
                return dataSet;
            }
        }
        public static DataSet ImportDataSetFromExcel(string excelFilePath, int headerRowIndex)
        {
            FileStream fileStream = File.OpenRead(excelFilePath);
            DataSet result;
            try
            {
                result = ExcelHelper2.ImportDataSetFromExcel(fileStream, headerRowIndex);
            }
            finally
            {
                bool flag = fileStream != null;
                if (flag)
                {
                    ((IDisposable)fileStream).Dispose();
                }
            }
            return result;
        }
        public static string ConvertColumnIndexToColumnName(int index)
        {
            checked
            {
                index++;
                int num = 26;
                char[] array = new char[100];
                int num2 = 0;
                while (index > 0)
                {
                    int num3 = index % num;
                    bool flag = num3 == 0;
                    if (flag)
                    {
                        num3 = num;
                    }
                    num2++;
                    array[num2] = Strings.ChrW(num3 - 1 + 65);
                    index = (index - 1) % 26;
                }
                StringBuilder stringBuilder = new StringBuilder(num2);
                int num4 = num2 - 1;
                while (true)
                {
                    int arg_79_0 = num4;
                    int num5 = 0;
                    if (arg_79_0 < num5)
                    {
                        break;
                    }
                    stringBuilder.Append(array[num4]);
                    num4 += -1;
                }
                return stringBuilder.ToString();
            }
        }
        public static DateTime ConvertDate(string date)
        {
            DateTime result = default(DateTime);
            string[] array = date.Split(new char[]
			{
				'-'
			});
            int value = Convert.ToInt32(array[2]);
            int value2 = Convert.ToInt32(array[0]);
            int value3 = Convert.ToInt32(array[1]);
            string text = Convert.ToString(value);
            string text2 = Convert.ToString(value2);
            string text3 = Convert.ToString(value3);
            bool flag = text2.Length == 4;
            if (flag)
            {
                result = Convert.ToDateTime(date);
            }
            else
            {
                flag = (text.Length == 1);
                if (flag)
                {
                    text = "0" + text;
                }
                flag = (text2.Length == 1);
                if (flag)
                {
                    text2 = "0" + text2;
                }
                flag = (text3.Length == 1);
                if (flag)
                {
                    text3 = "0" + text3;
                }
                string value4 = string.Concat(new string[]
				{
					"20",
					text,
					"-",
					text2,
					"-",
					text3
				});
                result = Convert.ToDateTime(value4);
            }
            return result;
        }
    }
}
