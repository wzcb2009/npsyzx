using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
namespace Wzsckj.com.Common
{
    public sealed class ExcelHelper
    {
        private ExcelHelper()
        {
        }
        public static DataTable ExecuteDataTable(string filePath, string sheetName)
        {
            DataTable dataTable = OleDbHelper.ExecuteDataTable(ExcelHelper.BuildConnectionString(filePath), CommandType.Text, string.Format("SELECT * FROM [{0}$]", sheetName));
            List<DataRow> list = new List<DataRow>();
            int arg_2F_0 = 0;
            checked
            {
                int num = dataTable.Rows.Count - 1;
                int num2 = arg_2F_0;
                while (true)
                {
                    int arg_E3_0 = num2;
                    int num3 = num;
                    if (arg_E3_0 > num3)
                    {
                        break;
                    }
                    bool flag = true;
                    int arg_48_0 = 0;
                    int num4 = dataTable.Columns.Count - 1;
                    int num5 = arg_48_0;
                    bool flag2;
                    while (true)
                    {
                        int arg_B9_0 = num5;
                        num3 = num4;
                        if (arg_B9_0 > num3)
                        {
                            break;
                        }
                        object objectValue = RuntimeHelpers.GetObjectValue(dataTable.Rows[num2][num5]);
                        flag2 = (objectValue == null || objectValue is DBNull);
                        if (!flag2)
                        {
                            string text = Convert.ToString(RuntimeHelpers.GetObjectValue(objectValue));
                            flag2 = string.IsNullOrEmpty(text.Trim());
                            if (!flag2)
                            {
                                goto IL_A3;
                            }
                        }
                        num5++;
                    }
                IL_BB:
                    flag2 = flag;
                    if (flag2)
                    {
                        list.Add(dataTable.Rows[num2]);
                    }
                    num2++;
                    continue;
                IL_A3:
                    flag = false;
                    goto IL_BB;
                }
                List<DataRow>.Enumerator enumerator = new List<DataRow>.Enumerator();
                try
                {
                     enumerator = list.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        DataRow current = enumerator.Current;
                        dataTable.Rows.Remove(current);
                    }
                }
                finally
                {
                   
                    ((IDisposable)enumerator).Dispose();
                }
                return dataTable;
            }
        }
        private static string BuildConnectionString(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            bool flag = !fileInfo.Exists;
            if (flag)
            {
                throw new IOException(string.Format("文件[{0}]不存在！", filePath));
            }
            flag = fileInfo.Extension.ToLower().Equals(".xls");
            string result;
            if (flag)
            {
                result = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'", filePath);
            }
            else
            {
                flag = fileInfo.Extension.ToLower().Equals(".xlsx");
                if (!flag)
                {
                    throw new Exception("文件类型必须是Excel!");
                }
                result = string.Format("Provider=Microsoft.ace.oledb.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'", filePath);
            }
            return result;
        }
    }
}
