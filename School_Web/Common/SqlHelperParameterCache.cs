using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
namespace Wzsckj.com.Common
{
    public sealed class SqlHelperParameterCache
    {
        private static Hashtable paramCache = Hashtable.Synchronized(new Hashtable());
        private SqlHelperParameterCache()
        {
        }
        private static SqlParameter[] DiscoverSpParameterSet(SqlConnection connection, string spName, bool includeReturnValueParameter)
        {
            bool flag = connection == null;
            if (flag)
            {
                throw new ArgumentNullException("connection");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            SqlCommand sqlCommand = new SqlCommand(spName, connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            connection.Open();
            SqlCommandBuilder.DeriveParameters(sqlCommand);
            connection.Close();
            flag = !includeReturnValueParameter;
            if (flag)
            {
                sqlCommand.Parameters.RemoveAt(0);
            }
            checked
            {
                SqlParameter[] array = new SqlParameter[sqlCommand.Parameters.Count - 1 + 1];
                sqlCommand.Parameters.CopyTo(array, 0);
                SqlParameter[] array2 = array;
                for (int i = 0; i < array2.Length; i++)
                {
                    SqlParameter sqlParameter = array2[i];
                    sqlParameter.Value = DBNull.Value;
                }
                return array;
            }
        }
        private static SqlParameter[] CloneParameters(SqlParameter[] originalParameters)
        {
            checked
            {
                SqlParameter[] array = new SqlParameter[originalParameters.Length - 1 + 1];
                int i = 0;
                int num = originalParameters.Length;
                while (i < num)
                {
                    array[i] = (SqlParameter)((ICloneable)originalParameters[i]).Clone();
                    i++;
                }
                return array;
            }
        }
        public static void CacheParameterSet(string connectionString, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = connectionString == null || connectionString.Length == 0;
            if (flag)
            {
                throw new ArgumentNullException("connectionString");
            }
            flag = (commandText == null || commandText.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("commandText");
            }
            string key = connectionString + ":" + commandText;
            SqlHelperParameterCache.paramCache[key] = commandParameters;
        }
        public static SqlParameter[] GetCachedParameterSet(string connectionString, string commandText)
        {
            bool flag = connectionString == null || connectionString.Length == 0;
            if (flag)
            {
                throw new ArgumentNullException("connectionString");
            }
            flag = (commandText == null || commandText.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("commandText");
            }
            string key = connectionString + ":" + commandText;
            SqlParameter[] array = SqlHelperParameterCache.paramCache[key] as SqlParameter[];
            flag = (array == null);
            SqlParameter[] result;
            if (flag)
            {
                result = null;
            }
            else
            {
                result = SqlHelperParameterCache.CloneParameters(array);
            }
            return result;
        }
        public static SqlParameter[] GetSpParameterSet(string connectionString, string spName)
        {
            return SqlHelperParameterCache.GetSpParameterSet(connectionString, spName, false);
        }
        public static SqlParameter[] GetSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
        {
            bool flag = connectionString == null || connectionString.Length == 0;
            if (flag)
            {
                throw new ArgumentNullException("connectionString");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlParameter[] spParameterSetInternal;
            try
            {
                spParameterSetInternal = SqlHelperParameterCache.GetSpParameterSetInternal(sqlConnection, spName, includeReturnValueParameter);
            }
            finally
            {
                flag = (sqlConnection != null);
                if (flag)
                {
                    ((IDisposable)sqlConnection).Dispose();
                }
            }
            return spParameterSetInternal;
        }
        internal static SqlParameter[] GetSpParameterSet(SqlConnection connection, string spName)
        {
            return SqlHelperParameterCache.GetSpParameterSet(connection, spName, false);
        }
        internal static SqlParameter[] GetSpParameterSet(SqlConnection connection, string spName, bool includeReturnValueParameter)
        {
            bool flag = connection == null;
            if (flag)
            {
                throw new ArgumentNullException("connection");
            }
            SqlConnection sqlConnection = (SqlConnection)((ICloneable)connection).Clone();
            SqlParameter[] spParameterSetInternal;
            try
            {
                spParameterSetInternal = SqlHelperParameterCache.GetSpParameterSetInternal(sqlConnection, spName, includeReturnValueParameter);
            }
            finally
            {
                flag = (sqlConnection != null);
                if (flag)
                {
                    ((IDisposable)sqlConnection).Dispose();
                }
            }
            return spParameterSetInternal;
        }
        private static SqlParameter[] GetSpParameterSetInternal(SqlConnection connection, string spName, bool includeReturnValueParameter)
        {
            bool flag = connection == null;
            if (flag)
            {
                throw new ArgumentNullException("connection");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            string key = Conversions.ToString(Operators.ConcatenateObject(connection.ConnectionString + ":" + spName, Interaction.IIf(includeReturnValueParameter, ":include ReturnValue Parameter", "")));
            SqlParameter[] array = SqlHelperParameterCache.paramCache[key] as SqlParameter[];
            flag = (array == null);
            if (flag)
            {
                SqlParameter[] array2 = SqlHelperParameterCache.DiscoverSpParameterSet(connection, spName, includeReturnValueParameter);
                SqlHelperParameterCache.paramCache[key] = array2;
                array = array2;
            }
            return SqlHelperParameterCache.CloneParameters(array);
        }
    }
}
