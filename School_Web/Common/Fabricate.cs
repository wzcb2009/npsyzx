using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace Wzsckj.com.Common
{
    public class Fabricate
    {
        [DebuggerNonUserCode]
        public Fabricate()
        {
        }
        public static bool ReaderExists(Hashtable table, SqlDataReader reader, string columnName)
        {
            return table.Contains(columnName.ToLower()) && !Convert.IsDBNull(RuntimeHelpers.GetObjectValue(reader[columnName]));
        }
        public static T Fill<T>(SqlDataReader reader, Hashtable table)
        {
            T t = Activator.CreateInstance<T>();
            bool flag = table == null || table.Count == 0;
            if (flag)
            {
                table = Fabricate.FillTable(reader);
            }
            PropertyInfo[] properties = typeof(T).GetProperties();
            PropertyInfo[] array = properties;
            checked
            {
                for (int i = 0; i < array.Length; i++)
                {
                    PropertyInfo propertyInfo = array[i];
                    flag = Fabricate.ReaderExists(table, reader, propertyInfo.Name);
                    if (flag)
                    {
                        try
                        {
                            propertyInfo.SetValue(t, RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(reader[propertyInfo.Name]), propertyInfo.PropertyType)), null);
                        }
                        catch (Exception arg_8D_0)
                        {
                            ProjectData.SetProjectError(arg_8D_0);
                            propertyInfo.SetValue(t, RuntimeHelpers.GetObjectValue(Enum.Parse(propertyInfo.PropertyType, Convert.ToString(RuntimeHelpers.GetObjectValue(reader[propertyInfo.Name])))), null);
                            ProjectData.ClearProjectError();
                        }
                    }
                }
                return t;
            }
        }
        public static T Fill<T>(SqlDataReader reader)
        {
            bool flag = reader != null && !reader.IsClosed && reader.HasRows && reader.Read();
            T result;
            if (flag)
            {
                result = Fabricate.Fill<T>(reader, null);
            }
            else
            {
                result = default(T);
            }
            return result;
        }
        public static List<T> FillList<T>(SqlDataReader reader)
        {
            List<T> list = new List<T>();
            bool flag = reader != null && !reader.IsClosed && reader.HasRows;
            if (flag)
            {
                Hashtable table = Fabricate.FillTable(reader);
                while (reader.Read())
                {
                    list.Add(Fabricate.Fill<T>(reader, table));
                }
                reader.Close();
            }
            return list;
        }
        public static Hashtable FillTable(SqlDataReader reader)
        {
            Hashtable hashtable = new Hashtable();
            hashtable = new Hashtable();
            int fieldCount = reader.FieldCount;
            int arg_1A_0 = 0;
            checked
            {
                int num = fieldCount - 1;
                int num2 = arg_1A_0;
                while (true)
                {
                    int arg_3D_0 = num2;
                    int num3 = num;
                    if (arg_3D_0 > num3)
                    {
                        break;
                    }
                    hashtable.Add(reader.GetName(num2).ToLower(), null);
                    num2++;
                }
                return hashtable;
            }
        }
        public static List<T> GetList<T>(string ConnStr, CommandType commandType, string sqlText, params SqlParameter[] param)
        {
            SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(ConnStr, commandType, sqlText, param);
            List<T> result;
            try
            {
                result = Fabricate.FillList<T>(sqlDataReader);
            }
            finally
            {
                bool flag = sqlDataReader != null;
                if (flag)
                {
                    ((IDisposable)sqlDataReader).Dispose();
                }
            }
            return result;
        }
        public static T Get<T>(string ConnStr, CommandType commandType, string sqlText, params SqlParameter[] param)
        {
            SqlDataReader sqlDataReader = SqlHelper.ExecuteReader(ConnStr, commandType, sqlText, param);
            T result;
            try
            {
                result = Fabricate.Fill<T>(sqlDataReader);
            }
            finally
            {
                bool flag = sqlDataReader != null;
                if (flag)
                {
                    ((IDisposable)sqlDataReader).Dispose();
                }
            }
            return result;
        }
    }
}
