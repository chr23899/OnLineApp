using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using OnlineApp.COL;
using OnlineApp.SFL;

namespace OnlineApp.DAL.SqlServer
{
    public class CommonToolsDAL:DAL.Common.CommonToolsDAL
    {
        /// <summary>
        /// 通用sql查询，返回datatable数据集
        /// </summary>
        public override DataTable GetAllListByParams(Parameter paramList)
        {
            if (paramList.SqlString == "")
            {
                return null;
            }

            return SFL.SqlHelper.ExecuteDataTableQuery(paramList.SqlString, paramList.Parameters);
        }

        /// <summary>
        /// 通用sql查询，返回PageData分页数据集
        /// </summary>
        public override PageData GetPageListByParams(int pageSize, int curPage, Parameter paramList)
        {
            if (paramList.SqlString == "")
            {
                return null;
            }

            return SFL.SqlHelper.ExecutePageDataQuery(paramList.SqlString, paramList.Parameters, pageSize, curPage);
        }

        /// <summary>
        /// 通用sql查询，返回PageData分页数据集，添加越界处理
        /// </summary>
        public override PageData GetPageListByParamsOutBound(int pageSize, int curPage, Parameter paramList)
        {
            if (paramList.SqlString == "")
            {
                return null;
            }

            return SFL.SqlHelper.ExecutePageDataQueryOutBound(paramList.SqlString, paramList.Parameters, pageSize, curPage);
        }

        /// <summary>
        /// 通用sql查询，返回受影响的行数。
        /// </summary>
        public override int ExcuteSql(Parameter paramList)
        {
            if (paramList.SqlString == "")
            {
                return 0;
            }
            return SFL.SqlHelper.ExecuteNonQuery(paramList.SqlString, paramList.Parameters);
        }

        /// <summary>
        /// add by chr
        /// 通用sql查询，不返回结果(使用事务方式处理,支持多脚本同时查询)。
        /// </summary>
        public override void ExcuteSqlWithTransaction(List<Parameter> paramList)
        {
            SFL.SqlHelper.ExecuteNonQueryWithTransaction(paramList);
        }

        /// <summary>
        /// add by chr
        /// 通过事务方式执行多个SQL语句，不返回任何对象（其中第一条SQL执行结果与传入参数对比判断，结果为真才继续执行，否则回滚）。
        /// </summary>
        /// <param name="paramList">多个sql对象</param>
        /// <param name="iCheckPoint">检查点</param>
        public override void ExecuteNonQueryWithTransactionByCheckPoint(List<Parameter> paramList, int iCheckPoint)
        {
            SFL.SqlHelper.ExecuteNonQueryWithTransactionByCheckPoint(paramList, iCheckPoint);
        }


        /// <summary>
        /// add by chr
        /// 通用sql查询，返回查询结果的第一行第一列对象。
        /// </summary>
        public override object ExcuteSqlReturnSingleObject(Parameter paramList)
        {
            if (paramList.SqlString == "")
            {
                return 0;
            }
            return SFL.SqlHelper.ExecuteScalar(paramList.SqlString, paramList.Parameters);
        }
    }
}
