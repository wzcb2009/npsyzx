using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Xml;
namespace Wzsckj.com.Common
{
    public sealed class SqlHelper
    {
        private enum SqlConnectionOwnership
        {
            Internal,
            External
        }
        private SqlHelper()
        {
        }
        private static void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
        {
            bool flag = command == null;
            if (flag)
            {
                throw new ArgumentNullException("command");
            }
            flag = (commandParameters != null);
            checked
            {
                if (flag)
                {
                    for (int i = 0; i < commandParameters.Length; i++)
                    {
                        SqlParameter sqlParameter = commandParameters[i];
                        bool flag2 = sqlParameter != null;
                        if (flag2)
                        {
                            bool flag3 = (sqlParameter.Direction == ParameterDirection.InputOutput || sqlParameter.Direction == ParameterDirection.Input) && sqlParameter.Value == null;
                            if (flag3)
                            {
                                sqlParameter.Value = DBNull.Value;
                            }
                            command.Parameters.Add(sqlParameter);
                        }
                    }
                }
            }
        }
        private static void AssignParameterValues(SqlParameter[] commandParameters, DataRow dataRow)
        {
            bool flag = commandParameters == null || dataRow == null;
            checked
            {
                if (!flag)
                {
                    int num = 0;
                    for (int i = 0; i < commandParameters.Length; i++)
                    {
                        SqlParameter sqlParameter = commandParameters[i];
                        flag = (sqlParameter.ParameterName == null || sqlParameter.ParameterName.Length <= 1);
                        if (flag)
                        {
                            throw new Exception(string.Format("请提供参数{0}一个有效的名称{1}.", num, sqlParameter.ParameterName));
                        }
                        flag = (dataRow.Table.Columns.IndexOf(sqlParameter.ParameterName.Substring(1)) != -1);
                        if (flag)
                        {
                            sqlParameter.Value = RuntimeHelpers.GetObjectValue(dataRow[sqlParameter.ParameterName.Substring(1)]);
                        }
                        num++;
                    }
                }
            }
        }
        private static void AssignParameterValues(SqlParameter[] commandParameters, object[] parameterValues)
        {
            bool flag = commandParameters == null || parameterValues == null;
            checked
            {
                if (!flag)
                {
                    flag = (commandParameters.Length != parameterValues.Length);
                    if (flag)
                    {
                        throw new ArgumentException("参数值个数与参数不匹配.");
                    }
                    int i = 0;
                    int num = commandParameters.Length;
                    while (i < num)
                    {
                        flag = (parameterValues[i] is IDbDataParameter);
                        if (flag)
                        {
                            IDbDataParameter dbDataParameter = (IDbDataParameter)parameterValues[i];
                            flag = (dbDataParameter.Value == null);
                            if (flag)
                            {
                                commandParameters[i].Value = DBNull.Value;
                            }
                            else
                            {
                                commandParameters[i].Value = RuntimeHelpers.GetObjectValue(dbDataParameter.Value);
                            }
                        }
                        else
                        {
                            flag = (parameterValues[i] == null);
                            if (flag)
                            {
                                commandParameters[i].Value = DBNull.Value;
                            }
                            else
                            {
                                commandParameters[i].Value = RuntimeHelpers.GetObjectValue(parameterValues[i]);
                            }
                        }
                        i++;
                    }
                }
            }
        }
        private static void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters, ref bool mustCloseConnection)
        {
            bool flag = command == null;
            if (flag)
            {
                throw new ArgumentNullException("command");
            }
            flag = (commandText == null || commandText.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("commandText");
            }
            flag = (connection.State != ConnectionState.Open);
            if (flag)
            {
                mustCloseConnection = true;
                connection.Open();
            }
            else
            {
                mustCloseConnection = true;
            }
            command.Connection = connection;
            command.CommandText = commandText;
            flag = (transaction != null);
            bool flag2;
            if (flag)
            {
                flag2 = (transaction.Connection == null);
                if (flag2)
                {
                    throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
                }
                command.Transaction = transaction;
            }
            command.CommandType = commandType;
            flag2 = (commandParameters != null);
            if (flag2)
            {
                SqlHelper.AttachParameters(command, commandParameters);
            }
        }
        public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteNonQuery(connectionString, commandType, commandText, null);
        }
        public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = connectionString == null || connectionString.Length == 0;
            if (flag)
            {
                throw new ArgumentNullException("connectionString");
            }
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            int result;
            try
            {
                sqlConnection.Open();
                result = SqlHelper.ExecuteNonQuery(sqlConnection, commandType, commandText, commandParameters);
            }
            finally
            {
                flag = (sqlConnection != null);
                if (flag)
                {
                    ((IDisposable)sqlConnection).Dispose();
                }
            }
            return result;
        }
        public static int ExecuteNonQuery(string connectionString, string spName, params object[] parameterValues)
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
            flag = (parameterValues != null && parameterValues.Length > 0);
            int result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteNonQuery(connection, commandType, commandText, null);
        }
        public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = connection == null;
            if (flag)
            {
                throw new ArgumentNullException("connection");
            }
            SqlCommand sqlCommand = new SqlCommand();
            bool flag2 = true;
            SqlHelper.PrepareCommand(sqlCommand, connection, null, commandType, commandText, commandParameters, ref flag2);
            int result = sqlCommand.ExecuteNonQuery();
            sqlCommand.Parameters.Clear();
            flag = flag2;
            if (flag)
            {
                connection.Close();
            }
            return result;
        }
        public static int ExecuteNonQuery(SqlConnection connection, string spName, params object[] parameterValues)
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
            flag = (parameterValues != null && parameterValues.Length > 0);
            int result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteNonQuery(transaction, commandType, commandText, null);
        }
        public static int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            SqlCommand sqlCommand = new SqlCommand();
            bool flag2 = true;
            SqlHelper.PrepareCommand(sqlCommand, transaction.Connection, transaction, commandType, commandText, commandParameters, ref flag2);
            int result = sqlCommand.ExecuteNonQuery();
            sqlCommand.Parameters.Clear();
            return result;
        }
        public static int ExecuteNonQuery(SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (parameterValues != null && parameterValues.Length > 0);
            int result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteDataset(connectionString, commandType, commandText, null);
        }
        public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = connectionString == null || connectionString.Length == 0;
            if (flag)
            {
                throw new ArgumentNullException("connectionString");
            }
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            DataSet result;
            try
            {
                sqlConnection.Open();
                result = SqlHelper.ExecuteDataset(sqlConnection, commandType, commandText, commandParameters);
            }
            finally
            {
                flag = (sqlConnection != null);
                if (flag)
                {
                    ((IDisposable)sqlConnection).Dispose();
                }
            }
            return result;
        }
        public static DataSet ExecuteDataset(string connectionString, string spName, params object[] parameterValues)
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
            flag = (parameterValues != null && parameterValues.Length > 0);
            DataSet result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteDataset(connection, commandType, commandText, null);
        }
        public static DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = connection == null;
            if (flag)
            {
                throw new ArgumentNullException("connection");
            }
            SqlCommand sqlCommand = new SqlCommand();
            bool flag2 = true;
            SqlHelper.PrepareCommand(sqlCommand, connection, null, commandType, commandText, commandParameters, ref flag2);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet result;
            try
            {
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                sqlCommand.Parameters.Clear();
                flag = flag2;
                if (flag)
                {
                    connection.Close();
                }
                result = dataSet;
            }
            finally
            {
                flag = (sqlDataAdapter != null);
                if (flag)
                {
                    ((IDisposable)sqlDataAdapter).Dispose();
                }
            }
            return result;
        }
        public static DataSet ExecuteDataset(SqlConnection connection, string spName, params object[] parameterValues)
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
            flag = (parameterValues != null && parameterValues.Length > 0);
            DataSet result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static DataSet ExecuteDataset(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteDataset(transaction, commandType, commandText, null);
        }
        public static DataSet ExecuteDataset(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            SqlCommand sqlCommand = new SqlCommand();
            bool flag2 = true;
            SqlHelper.PrepareCommand(sqlCommand, transaction.Connection, transaction, commandType, commandText, commandParameters, ref flag2);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet result;
            try
            {
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                sqlCommand.Parameters.Clear();
                result = dataSet;
            }
            finally
            {
                flag = (sqlDataAdapter != null);
                if (flag)
                {
                    ((IDisposable)sqlDataAdapter).Dispose();
                }
            }
            return result;
        }
        public static DataSet ExecuteDataset(SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (parameterValues != null && parameterValues.Length > 0);
            DataSet result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        private static SqlDataReader ExecuteReader(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters, SqlHelper.SqlConnectionOwnership connectionOwnership)
        {
            bool flag = connection == null;
            if (flag)
            {
                throw new ArgumentNullException("connection");
            }
            bool flag2 = true;
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader result;
            try
            {
                SqlHelper.PrepareCommand(sqlCommand, connection, transaction, commandType, commandText, commandParameters, ref flag2);
                flag = (connectionOwnership == SqlHelper.SqlConnectionOwnership.External);
                SqlDataReader sqlDataReader;
                if (flag)
                {
                    sqlDataReader = sqlCommand.ExecuteReader();
                }
                else
                {
                    sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                }
                bool flag3 = true;
                IEnumerator enumerator = null;
                try
                {
                      enumerator = sqlCommand.Parameters.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        SqlParameter sqlParameter = (SqlParameter)enumerator.Current;
                        flag = (sqlParameter.Direction != ParameterDirection.Input);
                        if (flag)
                        {
                            flag3 = false;
                        }
                    }
                }
                finally
                {
                    
                    flag = (enumerator is IDisposable);
                    if (flag)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                flag = flag3;
                if (flag)
                {
                    sqlCommand.Parameters.Clear();
                }
                result = sqlDataReader;
            }
            catch (Exception arg_D4_0)
            {
                ProjectData.SetProjectError(arg_D4_0);
                flag = flag2;
                if (flag)
                {
                    connection.Close();
                }
                throw;
            }
            return result;
        }
        public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteReader(connectionString, commandType, commandText, null);
        }
        public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = connectionString == null || connectionString.Length == 0;
            if (flag)
            {
                throw new ArgumentNullException("connectionString");
            }
            SqlConnection sqlConnection = null;
            SqlDataReader result;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                result = SqlHelper.ExecuteReader(sqlConnection, null, commandType, commandText, commandParameters, SqlHelper.SqlConnectionOwnership.Internal);
            }
            catch (Exception arg_43_0)
            {
                ProjectData.SetProjectError(arg_43_0);
                flag = (sqlConnection != null);
                if (flag)
                {
                    sqlConnection.Close();
                }
                throw;
            }
            return result;
        }
        public static SqlDataReader ExecuteReader(string connectionString, string spName, params object[] parameterValues)
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
            flag = (parameterValues != null && parameterValues.Length > 0);
            SqlDataReader result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteReader(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteReader(connectionString, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteReader(connection, commandType, commandText, null);
        }
        public static SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            return SqlHelper.ExecuteReader(connection, null, commandType, commandText, commandParameters, SqlHelper.SqlConnectionOwnership.External);
        }
        public static SqlDataReader ExecuteReader(SqlConnection connection, string spName, params object[] parameterValues)
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
            flag = (parameterValues != null && parameterValues.Length > 0);
            SqlDataReader result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static SqlDataReader ExecuteReader(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteReader(transaction, commandType, commandText, null);
        }
        public static SqlDataReader ExecuteReader(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            return SqlHelper.ExecuteReader(transaction.Connection, transaction, commandType, commandText, commandParameters, SqlHelper.SqlConnectionOwnership.External);
        }
        public static SqlDataReader ExecuteReader(SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (parameterValues != null && parameterValues.Length > 0);
            SqlDataReader result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteReader(transaction, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteReader(transaction, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteScalar(connectionString, commandType, commandText, null);
        }
        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = connectionString == null || connectionString.Length == 0;
            if (flag)
            {
                throw new ArgumentNullException("connectionString");
            }
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            object result;
            try
            {
                sqlConnection.Open();
                result = SqlHelper.ExecuteScalar(sqlConnection, commandType, commandText, commandParameters);
            }
            finally
            {
                flag = (sqlConnection != null);
                if (flag)
                {
                    ((IDisposable)sqlConnection).Dispose();
                }
            }
            return result;
        }
        public static object ExecuteScalar(string connectionString, string spName, params object[] parameterValues)
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
            flag = (parameterValues != null && parameterValues.Length > 0);
            object result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteScalar(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteScalar(connectionString, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteScalar(connection, commandType, commandText, null);
        }
        public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = connection == null;
            if (flag)
            {
                throw new ArgumentNullException("connection");
            }
            SqlCommand sqlCommand = new SqlCommand();
            bool flag2 = true;
            SqlHelper.PrepareCommand(sqlCommand, connection, null, commandType, commandText, commandParameters, ref flag2);
            object objectValue = RuntimeHelpers.GetObjectValue(sqlCommand.ExecuteScalar());
            sqlCommand.Parameters.Clear();
            flag = flag2;
            if (flag)
            {
                connection.Close();
            }
            return objectValue;
        }
        public static object ExecuteScalar(SqlConnection connection, string spName, params object[] parameterValues)
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
            flag = (parameterValues != null && parameterValues.Length > 0);
            object result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteScalar(connection, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteScalar(connection, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static object ExecuteScalar(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteScalar(transaction, commandType, commandText, null);
        }
        public static object ExecuteScalar(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            SqlCommand sqlCommand = new SqlCommand();
            bool flag2 = true;
            SqlHelper.PrepareCommand(sqlCommand, transaction.Connection, transaction, commandType, commandText, commandParameters, ref flag2);
            object objectValue = RuntimeHelpers.GetObjectValue(sqlCommand.ExecuteScalar());
            sqlCommand.Parameters.Clear();
            return objectValue;
        }
        public static object ExecuteScalar(SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (parameterValues != null && parameterValues.Length > 0);
            object result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteScalar(transaction, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteScalar(transaction, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static XmlReader ExecuteXmlReader(SqlConnection connection, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteXmlReader(connection, commandType, commandText, null);
        }
        public static XmlReader ExecuteXmlReader(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = connection == null;
            if (flag)
            {
                throw new ArgumentNullException("connection");
            }
            bool flag2 = true;
            SqlCommand sqlCommand = new SqlCommand();
            XmlReader result;
            try
            {
                SqlHelper.PrepareCommand(sqlCommand, connection, null, commandType, commandText, commandParameters, ref flag2);
                XmlReader xmlReader = sqlCommand.ExecuteXmlReader();
                sqlCommand.Parameters.Clear();
                result = xmlReader;
            }
            catch (Exception arg_47_0)
            {
                ProjectData.SetProjectError(arg_47_0);
                flag = flag2;
                if (flag)
                {
                    connection.Close();
                }
                throw;
            }
            return result;
        }
        public static XmlReader ExecuteXmlReader(SqlConnection connection, string spName, params object[] parameterValues)
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
            flag = (parameterValues != null && parameterValues.Length > 0);
            XmlReader result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteXmlReader(connection, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteXmlReader(connection, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static XmlReader ExecuteXmlReader(SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return SqlHelper.ExecuteXmlReader(transaction, commandType, commandText, null);
        }
        public static XmlReader ExecuteXmlReader(SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            SqlCommand sqlCommand = new SqlCommand();
            bool flag2 = true;
            SqlHelper.PrepareCommand(sqlCommand, transaction.Connection, transaction, commandType, commandText, commandParameters, ref flag2);
            XmlReader result = sqlCommand.ExecuteXmlReader();
            sqlCommand.Parameters.Clear();
            return result;
        }
        public static XmlReader ExecuteXmlReader(SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (parameterValues != null && parameterValues.Length > 0);
            XmlReader result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                result = SqlHelper.ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static void FillDataset(string connectionString, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames)
        {
            bool flag = connectionString == null || connectionString.Length == 0;
            if (flag)
            {
                throw new ArgumentNullException("connectionString");
            }
            flag = (dataSet == null);
            if (flag)
            {
                throw new ArgumentNullException("dataSet");
            }
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                SqlHelper.FillDataset(sqlConnection, commandType, commandText, dataSet, tableNames);
            }
            finally
            {
                flag = (sqlConnection != null);
                if (flag)
                {
                    ((IDisposable)sqlConnection).Dispose();
                }
            }
        }
        public static void FillDataset(string connectionString, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames, params SqlParameter[] commandParameters)
        {
            bool flag = connectionString == null || connectionString.Length == 0;
            if (flag)
            {
                throw new ArgumentNullException("connectionString");
            }
            flag = (dataSet == null);
            if (flag)
            {
                throw new ArgumentNullException("dataSet");
            }
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                SqlHelper.FillDataset(sqlConnection, commandType, commandText, dataSet, tableNames, commandParameters);
            }
            finally
            {
                flag = (sqlConnection != null);
                if (flag)
                {
                    ((IDisposable)sqlConnection).Dispose();
                }
            }
        }
        public static void FillDataset(string connectionString, string spName, DataSet dataSet, string[] tableNames, params object[] parameterValues)
        {
            bool flag = connectionString == null || connectionString.Length == 0;
            if (flag)
            {
                throw new ArgumentNullException("connectionString");
            }
            flag = (dataSet == null);
            if (flag)
            {
                throw new ArgumentNullException("dataSet");
            }
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                SqlHelper.FillDataset(sqlConnection, spName, dataSet, tableNames, parameterValues);
            }
            finally
            {
                flag = (sqlConnection != null);
                if (flag)
                {
                    ((IDisposable)sqlConnection).Dispose();
                }
            }
        }
        public static void FillDataset(SqlConnection connection, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames)
        {
            SqlHelper.FillDataset(connection, commandType, commandText, dataSet, tableNames, null);
        }
        public static void FillDataset(SqlConnection connection, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames, params SqlParameter[] commandParameters)
        {
            SqlHelper.FillDataset(connection, null, commandType, commandText, dataSet, tableNames, commandParameters);
        }
        public static void FillDataset(SqlConnection connection, string spName, DataSet dataSet, string[] tableNames, params object[] parameterValues)
        {
            bool flag = connection == null;
            if (flag)
            {
                throw new ArgumentNullException("connection");
            }
            flag = (dataSet == null);
            if (flag)
            {
                throw new ArgumentNullException("dataSet");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (parameterValues != null && parameterValues.Length > 0);
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                SqlHelper.FillDataset(connection, CommandType.StoredProcedure, spName, dataSet, tableNames, spParameterSet);
            }
            else
            {
                SqlHelper.FillDataset(connection, CommandType.StoredProcedure, spName, dataSet, tableNames);
            }
        }
        public static void FillDataset(SqlTransaction transaction, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames)
        {
            SqlHelper.FillDataset(transaction, commandType, commandText, dataSet, tableNames, null);
        }
        public static void FillDataset(SqlTransaction transaction, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames, params SqlParameter[] commandParameters)
        {
            SqlHelper.FillDataset(transaction.Connection, transaction, commandType, commandText, dataSet, tableNames, commandParameters);
        }
        public static void FillDataset(SqlTransaction transaction, string spName, DataSet dataSet, string[] tableNames, params object[] parameterValues)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            flag = (dataSet == null);
            if (flag)
            {
                throw new ArgumentNullException("dataSet");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (parameterValues != null && parameterValues.Length > 0);
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, parameterValues);
                SqlHelper.FillDataset(transaction, CommandType.StoredProcedure, spName, dataSet, tableNames, spParameterSet);
            }
            else
            {
                SqlHelper.FillDataset(transaction, CommandType.StoredProcedure, spName, dataSet, tableNames);
            }
        }
        private static void FillDataset(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, DataSet dataSet, string[] tableNames, params SqlParameter[] commandParameters)
        {
            bool flag = connection == null;
            if (flag)
            {
                throw new ArgumentNullException("connection");
            }
            flag = (dataSet == null);
            if (flag)
            {
                throw new ArgumentNullException("dataSet");
            }
            SqlCommand sqlCommand = new SqlCommand();
            bool flag2 = true;
            SqlHelper.PrepareCommand(sqlCommand, connection, transaction, commandType, commandText, commandParameters, ref flag2);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            checked
            {
                try
                {
                    flag = (tableNames != null && tableNames.Length > 0);
                    if (flag)
                    {
                        string text = "Table";
                        int arg_73_0 = 0;
                        int num = tableNames.Length - 1;
                        int num2 = arg_73_0;
                        while (true)
                        {
                            int arg_DC_0 = num2;
                            int num3 = num;
                            if (arg_DC_0 > num3)
                            {
                                goto IL_DE;
                            }
                            flag = (tableNames[num2] == null || tableNames[num2].Length == 0);
                            if (flag)
                            {
                                break;
                            }
                            sqlDataAdapter.TableMappings.Add(text, tableNames[num2]);
                            text += (num2 + 1).ToString();
                            num2++;
                        }
                        throw new ArgumentException("The tableNames parameter must contain a list of tables, a value was provided as null or empty string.", "tableNames");
                    }
                IL_DE:
                    sqlDataAdapter.Fill(dataSet);
                    sqlCommand.Parameters.Clear();
                }
                finally
                {
                    flag = (sqlDataAdapter != null);
                    if (flag)
                    {
                        ((IDisposable)sqlDataAdapter).Dispose();
                    }
                }
                flag = flag2;
                if (flag)
                {
                    connection.Close();
                }
            }
        }
        public static void UpdateDataset(SqlCommand insertCommand, SqlCommand deleteCommand, SqlCommand updateCommand, DataSet dataSet, string tableName)
        {
            bool flag = insertCommand == null;
            if (flag)
            {
                throw new ArgumentNullException("insertCommand");
            }
            flag = (deleteCommand == null);
            if (flag)
            {
                throw new ArgumentNullException("deleteCommand");
            }
            flag = (updateCommand == null);
            if (flag)
            {
                throw new ArgumentNullException("updateCommand");
            }
            flag = (tableName == null || tableName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("tableName");
            }
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            try
            {
                sqlDataAdapter.UpdateCommand = updateCommand;
                sqlDataAdapter.InsertCommand = insertCommand;
                sqlDataAdapter.DeleteCommand = deleteCommand;
                sqlDataAdapter.Update(dataSet, tableName);
                dataSet.AcceptChanges();
            }
            finally
            {
                flag = (sqlDataAdapter != null);
                if (flag)
                {
                    ((IDisposable)sqlDataAdapter).Dispose();
                }
            }
        }
        public static SqlCommand CreateCommand(SqlConnection connection, string spName, params string[] sourceColumns)
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
            flag = (sourceColumns != null && sourceColumns.Length > 0);
            checked
            {
                if (flag)
                {
                    SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                    int arg_6E_0 = 0;
                    int num = sourceColumns.Length - 1;
                    int num2 = arg_6E_0;
                    while (true)
                    {
                        int arg_89_0 = num2;
                        int num3 = num;
                        if (arg_89_0 > num3)
                        {
                            break;
                        }
                        spParameterSet[num2].SourceColumn = sourceColumns[num2];
                        num2++;
                    }
                    SqlHelper.AttachParameters(sqlCommand, spParameterSet);
                }
                return sqlCommand;
            }
        }
        public static int ExecuteNonQueryTypedParams(string connectionString, string spName, DataRow dataRow)
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
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            int result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static int ExecuteNonQueryTypedParams(SqlConnection connection, string spName, DataRow dataRow)
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
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            int result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteNonQuery(connection, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static int ExecuteNonQueryTypedParams(SqlTransaction transaction, string spName, DataRow dataRow)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            int result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static DataSet ExecuteDatasetTypedParams(string connectionString, string spName, DataRow dataRow)
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
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            DataSet result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static DataSet ExecuteDatasetTypedParams(SqlConnection connection, string spName, DataRow dataRow)
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
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            DataSet result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteDataset(connection, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static DataSet ExecuteDatasetTypedParams(SqlTransaction transaction, string spName, DataRow dataRow)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            DataSet result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static SqlDataReader ExecuteReaderTypedParams(string connectionString, string spName, DataRow dataRow)
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
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            SqlDataReader result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteReader(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteReader(connectionString, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static SqlDataReader ExecuteReaderTypedParams(SqlConnection connection, string spName, DataRow dataRow)
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
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            SqlDataReader result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteReader(connection, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static SqlDataReader ExecuteReaderTypedParams(SqlTransaction transaction, string spName, DataRow dataRow)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            SqlDataReader result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteReader(transaction, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteReader(transaction, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static object ExecuteScalarTypedParams(string connectionString, string spName, DataRow dataRow)
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
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            object result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteScalar(connectionString, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteScalar(connectionString, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static object ExecuteScalarTypedParams(SqlConnection connection, string spName, DataRow dataRow)
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
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            object result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteScalar(connection, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteScalar(connection, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static object ExecuteScalarTypedParams(SqlTransaction transaction, string spName, DataRow dataRow)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            object result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteScalar(transaction, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteScalar(transaction, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static XmlReader ExecuteXmlReaderTypedParams(SqlConnection connection, string spName, DataRow dataRow)
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
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            XmlReader result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteXmlReader(connection, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteXmlReader(connection, CommandType.StoredProcedure, spName);
            }
            return result;
        }
        public static XmlReader ExecuteXmlReaderTypedParams(SqlTransaction transaction, string spName, DataRow dataRow)
        {
            bool flag = transaction == null;
            if (flag)
            {
                throw new ArgumentNullException("transaction");
            }
            flag = (transaction != null && transaction.Connection == null);
            if (flag)
            {
                throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
            }
            flag = (spName == null || spName.Length == 0);
            if (flag)
            {
                throw new ArgumentNullException("spName");
            }
            flag = (dataRow != null && dataRow.ItemArray.Length > 0);
            XmlReader result;
            if (flag)
            {
                SqlParameter[] spParameterSet = SqlHelperParameterCache.GetSpParameterSet(transaction.Connection, spName);
                SqlHelper.AssignParameterValues(spParameterSet, dataRow);
                result = SqlHelper.ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName, spParameterSet);
            }
            else
            {
                result = SqlHelper.ExecuteXmlReader(transaction, CommandType.StoredProcedure, spName);
            }
            return result;
        }
    }
}
