using System;
using System.Data;
using System.Data.OracleClient;
using System.Runtime.CompilerServices;
namespace Wzsckj.com.Common
{
    public class OrcaleHelper
    {
        private static string m_connectionString;
        public static string ConnectionString
        {
            set
            {
                OrcaleHelper.m_connectionString = value;
            }
        }
        public OrcaleHelper(string connectionString)
        {
            OrcaleHelper.m_connectionString = connectionString;
        }
        public static DataTable ExecuteDataTable(string commandText)
        {
            return OrcaleHelper.ExecuteDataTable(commandText, CommandType.Text, null);
        }
        public static DataTable ExecuteDataTable(string commandText, CommandType commandType)
        {
            return OrcaleHelper.ExecuteDataTable(commandText, commandType, null);
        }
        public static DataTable ExecuteDataTable(string commandText, CommandType commandType, params OracleParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            OracleConnection oracleConnection = new OracleConnection(OrcaleHelper.m_connectionString);
            checked
            {
                try
                {
                    OracleCommand oracleCommand = new OracleCommand(commandText, oracleConnection);
                    try
                    {
                        oracleCommand.CommandType = commandType;
                        bool flag = parameters != null;
                        if (flag)
                        {
                            for (int i = 0; i < parameters.Length; i++)
                            {
                                OracleParameter value = parameters[i];
                                oracleCommand.Parameters.Add(value);
                            }
                        }
                        OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(oracleCommand);
                        oracleDataAdapter.Fill(dataTable);
                    }
                    finally
                    {
                        bool flag = oracleCommand != null;
                        if (flag)
                        {
                            ((IDisposable)oracleCommand).Dispose();
                        }
                    }
                }
                finally
                {
                    bool flag = oracleConnection != null;
                    if (flag)
                    {
                        ((IDisposable)oracleConnection).Dispose();
                    }
                }
                return dataTable;
            }
        }
        public static OracleDataReader ExecuteReader(string commandText)
        {
            return OrcaleHelper.ExecuteReader(commandText, CommandType.Text, null);
        }
        public static OracleDataReader ExecuteReader(string commandText, CommandType commandType)
        {
            return OrcaleHelper.ExecuteReader(commandText, commandType, null);
        }
        public static OracleDataReader ExecuteReader(string commandText, CommandType commandType, OracleCommand[] parameters)
        {
            OracleConnection oracleConnection = new OracleConnection(OrcaleHelper.m_connectionString);
            OracleCommand oracleCommand = new OracleCommand(commandText, oracleConnection);
            bool flag = parameters != null;
            checked
            {
                if (flag)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        OracleCommand value = parameters[i];
                        oracleCommand.Parameters.Add(value);
                    }
                }
                oracleConnection.Open();
                return oracleCommand.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }
        public static object ExecuteScalar(string commandText)
        {
            return OrcaleHelper.ExecuteScalar(commandText, CommandType.Text, null);
        }
        public static object ExecuteScalar(string commandText, CommandType commandType)
        {
            return OrcaleHelper.ExecuteScalar(commandText, commandType, null);
        }
        public static object ExecuteScalar(string commandText, CommandType commandType, OracleParameter[] parameters)
        {
            object result = null;
            OracleConnection oracleConnection = new OracleConnection(OrcaleHelper.m_connectionString);
            checked
            {
                try
                {
                    OracleCommand oracleCommand = new OracleCommand(commandText, oracleConnection);
                    try
                    {
                        oracleCommand.CommandType = commandType;
                        bool flag = parameters != null;
                        if (flag)
                        {
                            for (int i = 0; i < parameters.Length; i++)
                            {
                                OracleParameter value = parameters[i];
                                oracleCommand.Parameters.Add(value);
                            }
                        }
                        oracleConnection.Open();
                        result = RuntimeHelpers.GetObjectValue(oracleCommand.ExecuteScalar());
                    }
                    finally
                    {
                        bool flag = oracleCommand != null;
                        if (flag)
                        {
                            ((IDisposable)oracleCommand).Dispose();
                        }
                    }
                }
                finally
                {
                    bool flag = oracleConnection != null;
                    if (flag)
                    {
                        ((IDisposable)oracleConnection).Dispose();
                    }
                }
                return result;
            }
        }
        public static int ExecuteNonQuery(string commandText)
        {
            return OrcaleHelper.ExecuteNonQuery(commandText, CommandType.Text, null);
        }
        public static int ExecuteNonQuery(string commandText, CommandType commandType)
        {
            return OrcaleHelper.ExecuteNonQuery(commandText, commandType, null);
        }
        public static int ExecuteNonQuery(string commandText, CommandType commandType, OracleParameter[] parameters)
        {
            int result = 0;
            OracleConnection oracleConnection = new OracleConnection(OrcaleHelper.m_connectionString);
            checked
            {
                try
                {
                    OracleCommand oracleCommand = new OracleCommand(commandText, oracleConnection);
                    try
                    {
                        oracleCommand.CommandType = commandType;
                        bool flag = parameters != null;
                        if (flag)
                        {
                            for (int i = 0; i < parameters.Length; i++)
                            {
                                OracleParameter value = parameters[i];
                                oracleCommand.Parameters.Add(value);
                            }
                        }
                        oracleConnection.Open();
                        result = oracleCommand.ExecuteNonQuery();
                    }
                    finally
                    {
                        bool flag = oracleCommand != null;
                        if (flag)
                        {
                            ((IDisposable)oracleCommand).Dispose();
                        }
                    }
                }
                finally
                {
                    bool flag = oracleConnection != null;
                    if (flag)
                    {
                        ((IDisposable)oracleConnection).Dispose();
                    }
                }
                return result;
            }
        }
    }
}
