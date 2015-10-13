using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.CompilerServices;
namespace Wzsckj.com.Common
{
    public class OleDbHelper
    {
        private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());
        [DebuggerNonUserCode]
        public OleDbHelper()
        {
        }
        public static int ExecuteNonQuery(string connString, CommandType cmdType, string cmdText)
        {
            return OleDbHelper.ExecuteNonQuery(connString, cmdType, cmdText, null);
        }
        public static int ExecuteNonQuery(OleDbConnection conn, CommandType cmdType, string cmdText)
        {
            return OleDbHelper.ExecuteNonQuery(conn, cmdType, cmdText, null);
        }
        public static int ExecuteNonQuery(OleDbTransaction trans, CommandType cmdType, string cmdText)
        {
            return OleDbHelper.ExecuteNonQuery(trans, cmdType, cmdText, null);
        }
        public static int ExecuteNonQuery(string connString, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbConnection oleDbConnection = new OleDbConnection(connString);
            int result;
            try
            {
                OleDbHelper.PrepareCommand(oleDbCommand, oleDbConnection, null, cmdType, cmdText, cmdParms);
                int num = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Parameters.Clear();
                bool flag = oleDbConnection.State == ConnectionState.Open;
                if (flag)
                {
                    oleDbConnection.Close();
                }
                result = num;
            }
            finally
            {
                bool flag = oleDbConnection != null;
                if (flag)
                {
                    ((IDisposable)oleDbConnection).Dispose();
                }
            }
            return result;
        }
        public static int ExecuteNonQuery(OleDbConnection conn, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbHelper.PrepareCommand(oleDbCommand, conn, null, cmdType, cmdText, cmdParms);
            int result = oleDbCommand.ExecuteNonQuery();
            oleDbCommand.Parameters.Clear();
            bool flag = conn.State == ConnectionState.Open;
            if (flag)
            {
                conn.Close();
            }
            return result;
        }
        public static int ExecuteNonQuery(OleDbTransaction trans, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbHelper.PrepareCommand(oleDbCommand, trans.Connection, trans, cmdType, cmdText, cmdParms);
            int result = oleDbCommand.ExecuteNonQuery();
            oleDbCommand.Parameters.Clear();
            bool flag = oleDbCommand.Connection.State == ConnectionState.Open;
            if (flag)
            {
                oleDbCommand.Connection.Close();
            }
            return result;
        }
        public static OleDbDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText)
        {
            return OleDbHelper.ExecuteReader(connectionString, commandType, commandText, null);
        }
        public static OleDbDataReader ExecuteReader(string connString, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbConnection oleDbConnection = new OleDbConnection(connString);
            OleDbDataReader result;
            try
            {
                OleDbHelper.PrepareCommand(oleDbCommand, oleDbConnection, null, cmdType, cmdText, cmdParms);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.CloseConnection);
                oleDbCommand.Parameters.Clear();
                bool flag = oleDbConnection.State == ConnectionState.Open;
                if (flag)
                {
                    oleDbConnection.Close();
                }
                result = oleDbDataReader;
            }
            catch (Exception arg_4D_0)
            {
                ProjectData.SetProjectError(arg_4D_0);
                oleDbConnection.Close();
                throw;
            }
            return result;
        }
        public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText)
        {
            return OleDbHelper.ExecuteDataset(connectionString, commandType, commandText, null);
        }
        public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
        {
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            DataSet result;
            try
            {
                oleDbConnection.Open();
                result = OleDbHelper.ExecuteDataset(oleDbConnection, commandType, commandText, commandParameters);
            }
            finally
            {
                bool flag = oleDbConnection != null;
                if (flag)
                {
                    ((IDisposable)oleDbConnection).Dispose();
                }
            }
            return result;
        }
        public static DataSet ExecuteDataset(OleDbConnection connection, CommandType commandType, string commandText)
        {
            return OleDbHelper.ExecuteDataset(connection, commandType, commandText, null);
        }
        public static DataSet ExecuteDataset(OleDbConnection connection, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbHelper.PrepareCommand(oleDbCommand, connection, null, commandType, commandText, commandParameters);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
            DataSet dataSet = new DataSet();
            oleDbDataAdapter.Fill(dataSet);
            oleDbCommand.Parameters.Clear();
            bool flag = oleDbCommand.Connection.State == ConnectionState.Open;
            if (flag)
            {
                oleDbCommand.Connection.Close();
            }
            return dataSet;
        }
        public static DataTable ExecuteDataTable(string connectionString, CommandType commandType, string commandText)
        {
            return OleDbHelper.ExecuteDataTable(connectionString, commandType, commandText, null);
        }
        public static DataTable ExecuteDataTable(string connectionString, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
        {
            OleDbConnection oleDbConnection = new OleDbConnection(connectionString);
            DataTable result;
            try
            {
                oleDbConnection.Open();
                result = OleDbHelper.ExecuteDataTable(oleDbConnection, commandType, commandText, commandParameters);
            }
            finally
            {
                bool flag = oleDbConnection != null;
                if (flag)
                {
                    ((IDisposable)oleDbConnection).Dispose();
                }
            }
            return result;
        }
        public static DataTable ExecuteDataTable(OleDbConnection connection, CommandType commandType, string commandText)
        {
            return OleDbHelper.ExecuteDataTable(connection, commandType, commandText, null);
        }
        public static DataTable ExecuteDataTable(OleDbConnection connection, CommandType commandType, string commandText, params OleDbParameter[] commandParameters)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbHelper.PrepareCommand(oleDbCommand, connection, null, commandType, commandText, commandParameters);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
            DataSet dataSet = new DataSet();
            oleDbDataAdapter.Fill(dataSet);
            oleDbCommand.Parameters.Clear();
            bool flag = oleDbCommand.Connection.State == ConnectionState.Open;
            if (flag)
            {
                oleDbCommand.Connection.Close();
            }
            return dataSet.Tables[0];
        }
        public static object ExecuteScalar(string connString, CommandType cmdType, string cmdText)
        {
            return OleDbHelper.ExecuteScalar(connString, cmdType, cmdText, null);
        }
        public static object ExecuteScalar(string connString, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbConnection oleDbConnection = new OleDbConnection(connString);
            object result;
            try
            {
                OleDbHelper.PrepareCommand(oleDbCommand, oleDbConnection, null, cmdType, cmdText, cmdParms);
                object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
                oleDbCommand.Parameters.Clear();
                bool flag = oleDbConnection.State == ConnectionState.Open;
                if (flag)
                {
                    oleDbConnection.Close();
                }
                result = objectValue;
            }
            finally
            {
                bool flag = oleDbConnection != null;
                if (flag)
                {
                    ((IDisposable)oleDbConnection).Dispose();
                }
            }
            return result;
        }
        public static object ExecuteScalar(OleDbConnection conn, CommandType cmdType, string cmdText)
        {
            return OleDbHelper.ExecuteScalar(conn, cmdType, cmdText, null);
        }
        public static object ExecuteScalar(OleDbConnection conn, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbHelper.PrepareCommand(oleDbCommand, conn, null, cmdType, cmdText, cmdParms);
            object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
            oleDbCommand.Parameters.Clear();
            bool flag = conn.State == ConnectionState.Open;
            if (flag)
            {
                conn.Close();
            }
            return objectValue;
        }
        public static void CacheParameters(string cacheKey, params OleDbParameter[] cmdParms)
        {
            OleDbHelper.parmCache[cacheKey] = cmdParms;
        }
        public static OleDbParameter[] GetCachedParameters(string cacheKey)
        {
            OleDbParameter[] array = (OleDbParameter[])OleDbHelper.parmCache[cacheKey];
            bool flag = array == null;
            checked
            {
                OleDbParameter[] result;
                if (flag)
                {
                    result = null;
                }
                else
                {
                    OleDbParameter[] array2 = new OleDbParameter[array.Length - 1 + 1];
                    int i = 0;
                    int num = array.Length;
                    while (i < num)
                    {
                        array2[i] = (OleDbParameter)((ICloneable)array[i]).Clone();
                        i++;
                    }
                    result = array2;
                }
                return result;
            }
        }
        public static void PrepareCommand(OleDbCommand cmd, OleDbConnection conn, OleDbTransaction trans, CommandType cmdType, string cmdText, OleDbParameter[] cmdParms)
        {
            bool flag = conn.State != ConnectionState.Open;
            if (flag)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            flag = (trans != null);
            if (flag)
            {
                cmd.Transaction = trans;
            }
            cmd.CommandType = cmdType;
            flag = (cmdParms != null);
            checked
            {
                if (flag)
                {
                    for (int i = 0; i < cmdParms.Length; i++)
                    {
                        OleDbParameter value = cmdParms[i];
                        cmd.Parameters.Add(value);
                    }
                }
            }
        }
    }
}
