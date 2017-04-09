using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using OnlineApp.COL;

namespace OnlineApp.SFL
{
    public class SqlHelper
    {
        private static SqlConnection GetNewConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["SqlServerConnString"];

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                throw new CustomException("系统无法与数据库建立连结，请您与系统管理员联系。", ExceptionType.Error, "错误信息：" + ex.Message);
            }
            return sqlConnection;
        }

        private static void PrepareCommand(SqlCommand sqlCommand, SqlParameter[] commandParms)
        {
            if (commandParms != null)
            {
                foreach (SqlParameter parameter in commandParms)
                {
                    if (parameter.Value == null)
                    {
                        parameter.Value = DBNull.Value;
                    }
                    sqlCommand.Parameters.Add(parameter);
                }
            }
        }

        /// <summary>
        /// 执行SQL语句，并返回一个SqlDataReader对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        /// <returns>SqlDataReader对象</returns>
        public static SqlDataReader ExecuteReader(string commandText, SqlParameter[] commandParm)
        {
            SqlConnection sqlConnection = GetNewConnection();
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParm);
            try
            {
                SqlDataReader dbDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return dbDataReader;
            }
            catch (Exception e)
            {
                sqlConnection.Close();
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\r\n错误信息：" + e.Message);
            }
        }



        /// <summary>
        /// 执行SQL语句，返回操作记录数。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        /// <param name="commandParm">参数</param>
        /// <returns>记录数</returns>
        public static int ExecuteNonQuery(string commandText, SqlParameter[] commandParm)
        {
            SqlConnection sqlConnection = GetNewConnection();
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParm);
            int rowCount = 0;
            try
            {
                rowCount = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                sqlConnection.Close();
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\r\n错误信息：" + e.Message);
            }
            return rowCount;
        }

        /// <summary>
        /// add by chr
        /// 通过事务方式执行多个SQL语句，不返回任何对象。
        /// </summary>
        /// <param name="paramList">多个SQL对象</param>
        public static void ExecuteNonQueryWithTransaction(List<Parameter> paramList)
        {
            SqlConnection sqlConnection = GetNewConnection();
            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Transaction = sqlTransaction;

            try
            {
                foreach (Parameter par in paramList)
                {
                    sqlCommand.CommandText = par.SqlString;
                    PrepareCommand(sqlCommand, par.Parameters);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                }
                sqlTransaction.Commit();
            }
            catch (Exception e)
            {
                sqlTransaction.Rollback();
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "\r\n错误信息：" + e.Message);
            }
            finally
            {
                sqlConnection.Close();
                sqlTransaction.Dispose();
                sqlConnection.Dispose();
            }
        }

        /// <summary>
        /// add by chr
        /// 通过事务方式执行多个SQL语句，不返回任何对象（其中第一条SQL执行结果与传入参数对比判断，结果为真才继续执行，否则回滚）。
        /// </summary>
        /// <param name="paramList">多个sql对象</param>
        /// <param name="iCheckPoint">检查点</param>
        public static void ExecuteNonQueryWithTransactionByCheckPoint(List<Parameter> paramList, int iCheckPoint)
        {
            SqlConnection sqlConnection = GetNewConnection();
            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Transaction = sqlTransaction;

            try
            {
                for (int i = 0; i < paramList.Count; i++)
                {
                    sqlCommand.CommandText = paramList[i].SqlString;
                    PrepareCommand(sqlCommand, paramList[i].Parameters);
                    //第一条sql执行结果与传入checkpoint数值对比
                    int j = sqlCommand.ExecuteNonQuery();
                    if (i == 0 && iCheckPoint != j)
                    {
                        throw new Exception();
                    }
                    sqlCommand.Parameters.Clear();
                }
                sqlTransaction.Commit();
            }
            catch (Exception e)
            {
                sqlTransaction.Rollback();
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "\r\n错误信息：" + e.Message);
            }
            finally
            {
                sqlConnection.Close();
                sqlTransaction.Dispose();
                sqlConnection.Dispose();
            }
        }


        /// <summary>
        /// add by chr
        /// 执行SQL语句，返回查询结果的第一行第一列对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        public static object ExecuteScalar(string commandText, SqlParameter[] commandParm)
        {
            SqlConnection sqlConnection = GetNewConnection();
            SqlCommand sqlCommand = new SqlCommand(commandText, sqlConnection);
            PrepareCommand(sqlCommand, commandParm);
            object obj;
            try
            {
                obj = sqlCommand.ExecuteScalar();
                sqlConnection.Close();
                sqlCommand.Parameters.Clear();
            }
            catch (Exception e)
            {
                sqlConnection.Close();
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\r\n错误信息：" + e.Message);
            }
            return obj;
        }

        /// <summary>
        /// 执行SQL语句，返回DataTable对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        public static DataTable ExecuteDataTableQuery(string commandText, SqlParameter[] commandParm)
        {
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(commandText, commandParm);

            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            return dt;
        }


        /// <summary>
        /// 执行SQL语句，返回PageData对象，添加越界处理
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        public static PageData ExecutePageDataQueryOutBound(string commandText, SqlParameter[] commandParm, int pageSize, int curPage)
        {
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(commandText, commandParm);

            DataTable dt = new DataTable();
            PageData pageData = new PageData();
            pageData.PageSize = pageSize;
            pageData.CurPage = curPage;
            pageData.RecordCount = 0;
            pageData.PageCount = 1;

            int first = (curPage - 1) * pageSize + 1;
            int last = curPage * pageSize;

            for (int i = 0; i < sqlDataReader.FieldCount; i++)
            {
                dt.Columns.Add(sqlDataReader.GetName(i), sqlDataReader.GetFieldType(i));
            }
            while (sqlDataReader.Read())
            {
                pageData.RecordCount++;
                if (pageData.RecordCount >= first && last >= pageData.RecordCount)
                {
                    DataRow dataRow = dt.NewRow();
                    for (int j = 0; j < sqlDataReader.FieldCount; j++)
                    {
                        dataRow[j] = sqlDataReader[j];
                    }
                    dt.Rows.Add(dataRow);
                }
            }
            sqlDataReader.Close();

            if (pageData.RecordCount > 0)
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));
            //当传入的当前页大于总页数时的处理
            if (curPage > pageData.PageCount)
            {
                pageData.RecordCount = 0;
                sqlDataReader = SFL.SqlHelper.ExecuteReader(commandText, commandParm);
                curPage = pageData.PageCount;
                pageData.CurPage = curPage;
                first = (curPage - 1) * pageSize + 1;
                last = curPage * pageSize;

                while (sqlDataReader.Read())
                {
                    pageData.RecordCount++;
                    if (pageData.RecordCount >= first && last >= pageData.RecordCount)
                    {
                        DataRow dataRow = dt.NewRow();
                        for (int j = 0; j < sqlDataReader.FieldCount; j++)
                        {
                            dataRow[j] = sqlDataReader[j];
                        }
                        dt.Rows.Add(dataRow);
                    }
                }
                sqlDataReader.Close();
            }
            pageData.PageList = dt;
            return pageData;
        }

        /// <summary>
        /// 执行SQL语句，返回PageData对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        public static PageData ExecutePageDataQuery(string commandText, SqlParameter[] commandParm, int pageSize, int curPage)
        {
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(commandText, commandParm);

            DataTable dt = new DataTable();
            PageData pageData = new PageData();
            pageData.PageSize = pageSize;
            pageData.CurPage = curPage;
            pageData.RecordCount = 0;
            pageData.PageCount = 1;

            int first = (curPage - 1) * pageSize + 1;
            int last = curPage * pageSize;

            for (int i = 0; i < sqlDataReader.FieldCount; i++)
            {
                dt.Columns.Add(sqlDataReader.GetName(i), sqlDataReader.GetFieldType(i));
            }
            while (sqlDataReader.Read())
            {
                pageData.RecordCount++;
                if (pageData.RecordCount >= first && last >= pageData.RecordCount)
                {
                    DataRow dataRow = dt.NewRow();
                    for (int j = 0; j < sqlDataReader.FieldCount; j++)
                    {
                        dataRow[j] = sqlDataReader[j];
                    }
                    dt.Rows.Add(dataRow);
                }
            }
            sqlDataReader.Close();

            if (pageData.RecordCount > 0)
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));
            
            pageData.PageList = dt;
            return pageData;
        }
    }
}
