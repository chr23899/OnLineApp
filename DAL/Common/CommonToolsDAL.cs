using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using Chr.OnlineApp.COL;
using Chr.OnlineApp.SFL;

namespace Chr.OnlineApp.DAL.Common
{
    public abstract class CommonToolsDAL
    {
        //警告：仅用于缓存“卡片（YWCardDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static CommonToolsDAL commonTools;


        /// <summary>
        /// 获取“卡片（YWCardDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“卡片（YWCardDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static CommonToolsDAL Instance
        {
            get
            {
                if (commonTools == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            commonTools = new SqlServer.CommonToolsDAL();
                            break;

                        default:
                            commonTools = new SqlServer.CommonToolsDAL();
                            break;
                    }
                }
                return commonTools;
            }
        }
        /// <summary>
        /// 通用sql查询，返回datatable数据集
        /// </summary>
        public abstract DataTable GetAllListByParams(Parameter paramList);

        /// <summary>
        /// 通用sql查询，返回PageData分页数据集
        /// </summary>
        public abstract PageData GetPageListByParams(int pageSize, int curPage, Parameter paramList);

        /// <summary>
        /// 通用sql查询，返回PageData分页数据集，添加越界处理
        /// </summary>
        public abstract PageData GetPageListByParamsOutBound(int pageSize, int curPage, Parameter paramList);

        /// <summary>
        /// 通用sql查询，返回受影响的行数。
        /// </summary>
        public abstract int ExcuteSql(Parameter paramList);

        /// <summary>
        /// add by chr
        /// 通用sql查询，返回受影响的行数(使用事务方式处理)。
        /// </summary>
        public abstract void ExcuteSqlWithTransaction(List<Parameter> paramList);

        /// <summary>
        /// add by chr
        /// 通用sql查询，返回查询结果的第一行第一列对象。
        /// </summary>
        public abstract object ExcuteSqlReturnSingleObject(Parameter paramList);

        /// <summary>
        /// add by chr
        /// 通过事务方式执行多个SQL语句，不返回任何对象（其中第一条SQL执行结果与传入参数对比判断，结果为真才继续执行，否则回滚）。
        /// </summary>
        /// <param name="paramList">多个sql对象</param>
        /// <param name="iCheckPoint">检查点</param>
        public abstract void ExecuteNonQueryWithTransactionByCheckPoint(List<Parameter> paramList, int iCheckPoint);
    }
}
