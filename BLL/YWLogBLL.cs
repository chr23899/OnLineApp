using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using OnlineApp.COL;
using OnlineApp.DAL;
using OnlineApp.SFL;
using System.Data.SqlClient;

namespace OnlineApp.BLL
{
    /// <summary>
    /// 对象名称：日志业务逻辑类（业务逻辑层）
    /// 对象说明：业务操作日志
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2016-1-16 10:55:02
    /// </summary>
    public class YWLogBLL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要提供该类的基本业务逻辑。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 返回与本类相关联的数据访问类。通常本类需要访问自身关联的数据访问类，与数据库进行交互时，应优先使用该属性，
        /// 本类调用业务逻辑层其它业务逻辑类时，应当优先使用其它类中公开的方法，而不优先使用其它类中的DataAccess属性。
        /// </summary>
        internal static DAL.Common.YWLogDAL DataAccess
        {
            get
            {
                return DAL.Common.YWLogDAL.Instance;
            }
        }


        /// <summary>
        /// 对日志（YWLog）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWLog">日志（YWLog）实例对象</param>
        public static void CheckValid(YWLog yWLog)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWLog.YWType))
                throw new CustomException("“业务类别”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWLog.YWRecordId))
                throw new CustomException("“业务数据编号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWLog.Opr))
                throw new CustomException("“操作人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWLog.OprTime))
                throw new CustomException("“操作时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWLog.Description))
                throw new CustomException("“描述”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWLog.Opr.UserName.ToString() , 50))
                throw new CustomException("“操作人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWLog.Description , 50))
                throw new CustomException("“描述”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWLog.Backup1 , 50))
                throw new CustomException("“备用1”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWLog.Backup2 , 50))
                throw new CustomException("“备用2”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWLog.Backup3 , 50))
                throw new CustomException("“备用3”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWLog.Backup4 , 50))
                throw new CustomException("“备用4”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWLog.Backup5 , 50))
                throw new CustomException("“备用5”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWLog.Backup6 , 50))
                throw new CustomException("“备用6”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWLog.Backup7 , 50))
                throw new CustomException("“备用7”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWLog.Backup8 , 50))
                throw new CustomException("“备用8”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWLog.Backup9 , 50))
                throw new CustomException("“备用9”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWLog.Backup10 , 50))
                throw new CustomException("“备用10”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将日志（YWLog）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWLog">日志（YWLog）实例对象</param>
        public static int Insert(YWLog yWLog)
        {
            CheckValid(yWLog);
            return DataAccess.Insert(yWLog);
        }


        /// <summary>
        /// 将日志（YWLog）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWLog">日志（YWLog）实例对象</param>
        public static int Update(YWLog yWLog)
        {
            CheckValid(yWLog);
            return DataAccess.Update(yWLog);
        }


        /// <summary>
        /// 根据日志（YWLog）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">日志（YWLog）的主键“编号（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据日志（YWLog）的主键“编号（Id）”从数据库中获取日志（YWLog）的实例。
        /// 成功从数据库中取得记录返回新日志（YWLog）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">日志（YWLog）的主键“编号（Id）”</param>
        public static YWLog GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据日志（YWLog）的主键“编号（Id）”从数据库中获取日志（YWLog）的实例。
        /// 成功从数据库中取得记录返回新日志（YWLog）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">日志（YWLog）的主键“编号（Id）”</param>
        public static YWLog GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        /// <summary>
        /// add by zy
        /// 根据业务类型id、业务记录id，获取相应的日志记录，按时间排序
        /// </summary>
        /// <param name="iYWTypeId"></param>
        /// <param name="strRecordIdString"></param>
        /// <returns></returns>
        public static DataTable GetListByRecordId(int iYWTypeId, string strRecordIdString)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString =  "SELECT [YWLog].[Id],[YWDictionary].[Name] AS [YWTypeName],[PT_USER].[Nickname] AS [OprUserName],[YWLog].[OprTime],[YWLog].[Description] ";
            parameter.SqlString += "FROM [YWLog] ";
            parameter.SqlString += "LEFT JOIN [YWDictionary] ON [YWLog].[YWTypeId] = [YWDictionary].[Id] ";
            parameter.SqlString += "LEFT JOIN [PT_USER] ON [YWLog].[OprUserName] = [PT_USER].[UserName] ";
            parameter.SqlString += "WHERE [YWLog].[YWTypeId] = @YWTypeId AND [YWLog].[YWRecordId] IN (" + strRecordIdString + ") ORDER BY [YWLog].[OprTime] ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@YWTypeId" , SqlDbType.Int , 50 ){ Value = iYWTypeId},
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetAllListByParams(parameter);
         }

        /// <summary>
        /// add by zy
        /// 构建日志表单条记录Insert的Parameter对象，并返回（供事务模式使用）
        /// </summary>
        /// <param name="iYWTypeId"></param>
        /// <param name="iYWRecordId"></param>
        /// <param name="strUserName"></param>
        /// <param name="dtTime"></param>
        /// <param name="strDescription"></param>
        /// <returns></returns>
        public static Parameter GetSingleInsertParameter(int iYWTypeId, int iYWRecordId, string strUserName, DateTime dtTime, string strDescription)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "INSERT INTO [YWLog] ([YWTypeId],[YWRecordId],[OprUserName],[OprTime],[Description]) ";
            parameter.SqlString += " VALUES (@YWTypeId,@YWRecordId,@OprUserName,@OprTime,@Description)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@YWTypeId"         , SqlDbType.Int      , 50 ){ Value = iYWTypeId},
                new SqlParameter("@YWTableName"      , SqlDbType.NVarChar , 50 ){ Value = iYWRecordId},
                new SqlParameter("@OprUserName"      , SqlDbType.NVarChar , 50 ){ Value = strUserName},
                new SqlParameter("@OprTime"          , SqlDbType.DateTime , 50 ){ Value = dtTime},
                new SqlParameter("@Description"      , SqlDbType.NVarChar , 50 ){ Value = strDescription},
            };
            parameter.Parameters = parameters;

            return parameter;
        }

        /// <summary>
        /// add by zy
        /// 构建日志表单条记录Insert的Parameter对象，并返回（供事务模式使用）（YWRecordId由前一条执行语句中的业务表名通过函数获取）
        /// </summary>
        /// <param name="iYWTypeId"></param>
        /// <param name="strYWTableName"></param>
        /// <param name="strUserName"></param>
        /// <param name="dtTime"></param>
        /// <param name="strDescription"></param>
        /// <returns></returns>
        public static Parameter GetSingleInsertParameter(int iYWTypeId, string strYWTableName, string strUserName, DateTime dtTime, string strDescription)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "INSERT INTO [YWLog] ([YWTypeId],[YWRecordId],[OprUserName],[OprTime],[Description]) ";
            parameter.SqlString += " VALUES (@YWTypeId,CONVERT(INT,IDENT_CURRENT(@YWTableName)),@OprUserName,@OprTime,@Description)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@YWTypeId"         , SqlDbType.Int      , 50 ){ Value = iYWTypeId},
                new SqlParameter("@YWTableName"      , SqlDbType.NVarChar , 50 ){ Value = strYWTableName},
                new SqlParameter("@OprUserName"      , SqlDbType.NVarChar , 50 ){ Value = strUserName},
                new SqlParameter("@OprTime"          , SqlDbType.DateTime , 50 ){ Value = dtTime},
                new SqlParameter("@Description"      , SqlDbType.NVarChar , 50 ){ Value = strDescription},
            };
            parameter.Parameters = parameters;

            return parameter;
        }

        /// <summary>
        /// add by zy
        /// 构建日志表多条记录Insert的Parameter对象，并返回（供事务模式使用）
        /// </summary>
        /// <param name="iYWTypeId"></param>
        /// <param name="strRecordIdList">YWRecordId的StringList</param>
        /// <param name="strUserName"></param>
        /// <param name="dtTime"></param>
        /// <param name="strDescription"></param>
        /// <returns></returns>
        public static Parameter GetComplexInsertParameter(int iYWTypeId, string[] strRecordIdList, string strUserName, string strDateTimeNow, string strDescription)
        {
            //构建YWLog的Parameter对象
            Parameter parameter = new Parameter();
            parameter.SqlString = " INSERT INTO [YWLog] (YWTypeId, YWRecordId, OprUserName, OprTime, Description) VALUES ";
            for (int i = 0; i < strRecordIdList.Length; i++)
            {
                if (i != 0)
                {
                    parameter.SqlString += ",";
                }
                parameter.SqlString += "(" + iYWTypeId + "," + strRecordIdList[i] + ",'" + strUserName + "','" + strDateTimeNow + "', '" + strDescription + "') ";
            }

            return parameter;
        }

        /// <summary>
        /// add by zy
        /// 根据传入的业务类型Id以及业务记录Id字符串，构建多条日志删除的Parameter，并返回
        /// </summary>
        /// <param name="iYWTypeId"></param>
        /// <param name="strRecordIdString"></param>
        /// <returns></returns>
        public static Parameter GetComplexDeleteParameter(int iYWTypeId, string strRecordIdString)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = " DELETE FROM [YWLog] WHERE YWTypeId = @YWTypeId AND [YWRecordId] IN (" + strRecordIdString + ") ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@YWTypeId" , SqlDbType.Int , 50 ){ Value = iYWTypeId},
            };
            parameter.Parameters = parameters;

            return parameter;
        }
    }
}
