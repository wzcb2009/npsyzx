using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
namespace Wzsckj.com.Common
{
    public class OLEHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["AccessConnectionString"].ToString();
        }
        public static DataSet ExecuteDataSet(string cmdText, params OleDbParameter[] cmdParms)
        {
            return OLEHelper.ExecuteDataSet(OLEHelper.GetConnectionString(), cmdText, cmdParms);
        }
        public static DataSet ExecuteDataSet(string connString, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbConnection oleDbConnection = new OleDbConnection(connString);
            DataSet result;
            try
            {
                OLEHelper.PrepareCommand(oleDbCommand, oleDbConnection, null, CommandType.Text, cmdText, cmdParms);
                DataSet dataSet = new DataSet();
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(oleDbCommand);
                oleDbDataAdapter.Fill(dataSet);
                result = dataSet;
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
        public static int ExecuteNonQuery(string cmdText, params OleDbParameter[] cmdParms)
        {
            return OLEHelper.ExecuteNonQuery(OLEHelper.GetConnectionString(), cmdText, cmdParms);
        }
        public static int ExecuteNonQuery(string connString, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbConnection oleDbConnection = new OleDbConnection(connString);
            int result;
            try
            {
                OLEHelper.PrepareCommand(oleDbCommand, oleDbConnection, null, CommandType.Text, cmdText, cmdParms);
                int num = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Parameters.Clear();
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
        public static int ExecuteNonQuery(CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            return OLEHelper.ExecuteNonQuery(OLEHelper.GetConnectionString(), cmdType, cmdText, cmdParms);
        }
        public static int ExecuteNonQuery(string connString, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbConnection oleDbConnection = new OleDbConnection(connString);
            int result;
            try
            {
                OLEHelper.PrepareCommand(oleDbCommand, oleDbConnection, null, cmdType, cmdText, cmdParms);
                int num = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Parameters.Clear();
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
            OLEHelper.PrepareCommand(oleDbCommand, conn, null, cmdType, cmdText, cmdParms);
            int result = oleDbCommand.ExecuteNonQuery();
            oleDbCommand.Parameters.Clear();
            return result;
        }
        public static int ExecuteNonQuery(OleDbTransaction trans, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OLEHelper.PrepareCommand(oleDbCommand, trans.Connection, trans, cmdType, cmdText, cmdParms);
            int result = oleDbCommand.ExecuteNonQuery();
            oleDbCommand.Parameters.Clear();
            return result;
        }
        public static OleDbDataReader ExecuteReader(string cmdText, params OleDbParameter[] cmdParms)
        {
            return OLEHelper.ExecuteReader(OLEHelper.GetConnectionString(), cmdText, cmdParms);
        }
        public static OleDbDataReader ExecuteReader(string connString, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbConnection oleDbConnection = new OleDbConnection(connString);
            OleDbDataReader result;
            try
            {
                OLEHelper.PrepareCommand(oleDbCommand, oleDbConnection, null, CommandType.Text, cmdText, cmdParms);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.CloseConnection);
                result = oleDbDataReader;
            }
            catch (Exception arg_2A_0)
            {
                ProjectData.SetProjectError(arg_2A_0);
                oleDbConnection.Close();
                throw;
            }
            return result;
        }
        public static OleDbDataReader ExecuteReader(CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            return OLEHelper.ExecuteReader(OLEHelper.GetConnectionString(), cmdType, cmdText, cmdParms);
        }
        public static OleDbDataReader ExecuteReader(string connString, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbConnection oleDbConnection = new OleDbConnection(connString);
            OleDbDataReader result;
            try
            {
                OLEHelper.PrepareCommand(oleDbCommand, oleDbConnection, null, cmdType, cmdText, cmdParms);
                OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader(CommandBehavior.CloseConnection);
                result = oleDbDataReader;
            }
            catch (Exception arg_2A_0)
            {
                ProjectData.SetProjectError(arg_2A_0);
                oleDbConnection.Close();
                throw;
            }
            return result;
        }
        public static object ExecuteScalar(string cmdText, params OleDbParameter[] cmdParms)
        {
            return OLEHelper.ExecuteScalar(OLEHelper.GetConnectionString(), cmdText, cmdParms);
        }
        public static object ExecuteScalar(string connString, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbConnection oleDbConnection = new OleDbConnection(connString);
            object result;
            try
            {
                OLEHelper.PrepareCommand(oleDbCommand, oleDbConnection, null, CommandType.Text, cmdText, cmdParms);
                object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
                oleDbCommand.Parameters.Clear();
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
        public static object ExecuteScalar(CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            return OLEHelper.ExecuteScalar(cmdType, cmdText, cmdParms);
        }
        public static object ExecuteScalar(string connString, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OleDbConnection oleDbConnection = new OleDbConnection(connString);
            object result;
            try
            {
                OLEHelper.PrepareCommand(oleDbCommand, oleDbConnection, null, cmdType, cmdText, cmdParms);
                object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
                oleDbCommand.Parameters.Clear();
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
        public static object ExecuteScalar(OleDbConnection conn, CommandType cmdType, string cmdText, params OleDbParameter[] cmdParms)
        {
            OleDbCommand oleDbCommand = new OleDbCommand();
            OLEHelper.PrepareCommand(oleDbCommand, conn, null, cmdType, cmdText, cmdParms);
            object objectValue = RuntimeHelpers.GetObjectValue(oleDbCommand.ExecuteScalar());
            oleDbCommand.Parameters.Clear();
            return objectValue;
        }
        private static void PrepareCommand(OleDbCommand cmd, OleDbConnection conn, OleDbTransaction trans, CommandType cmdType, string cmdText, OleDbParameter[] cmdParms)
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
