﻿using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using Chr.OnlineApp.COL;
using Chr.OnlineApp.DAL;
using Chr.OnlineApp.SFL;
using System.Data.SqlClient;

namespace Chr.OnlineApp.BLL
{
    /// <summary>
    /// 对象名称：基础对象名称业务逻辑类（业务逻辑层）
    /// 对象说明：该类的功能描述与摘要说明。
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：陈焕然
    /// 编写日期：2017/4/13 23:52:54
    /// </summary>
    public class YWCommentBLL
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
        internal static DAL.Common.YWCommentDAL DataAccess
        {
            get
            {
                return DAL.Common.YWCommentDAL.Instance;
            }
        }


        /// <summary>
        /// 对基础对象名称（YWComment）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWComment">基础对象名称（YWComment）实例对象</param>
        public static void CheckValid(YWComment yWComment)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWComment.PlanId))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.PlanName))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.CourseId))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.CourseName))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.CreateUserName))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.CreateUserId))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.UpdateUserName))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.UpdateUserId))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.CreateTime))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.UpdateTime))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.Status))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.Support))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWComment.Oppose))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWComment.PlanName, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWComment.CourseName, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWComment.CreateUserName, 20))
                throw new CustomException("“”长度不能超过 20 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWComment.UpdateUserName, 20))
                throw new CustomException("“”长度不能超过 20 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWComment.Content, 500))
                throw new CustomException("“”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWComment.Alternate1, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWComment.Alternate2, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWComment.Alternate3, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWComment.Alternate4, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWComment.Alternate5, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将基础对象名称（YWComment）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWComment">基础对象名称（YWComment）实例对象</param>
        public static int Insert(YWComment yWComment)
        {
            CheckValid(yWComment);
            return DataAccess.Insert(yWComment);
        }


        /// <summary>
        /// 将基础对象名称（YWComment）数据，根据主键“（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWComment">基础对象名称（YWComment）实例对象</param>
        public static int Update(YWComment yWComment)
        {
            CheckValid(yWComment);
            return DataAccess.Update(yWComment);
        }


        /// <summary>
        /// 根据基础对象名称（YWComment）的主键“（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">基础对象名称（YWComment）的主键“（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据基础对象名称（YWComment）的主键“（Id）”从数据库中获取基础对象名称（YWComment）的实例。
        /// 成功从数据库中取得记录返回新基础对象名称（YWComment）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基础对象名称（YWComment）的主键“（Id）”</param>
        public static YWComment GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据基础对象名称（YWComment）的主键“（Id）”从数据库中获取基础对象名称（YWComment）的实例。
        /// 成功从数据库中取得记录返回新基础对象名称（YWComment）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基础对象名称（YWComment）的主键“（Id）”</param>
        public static YWComment GetDataById(string id)
        {
            if (!DataValid.IsInt(id))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// 从数据库中读取并返回所有基础对象名称（YWComment）List列表。
        /// </summary>
        public static List<YWComment> GetAllList()
        {
            return DataAccess.GetAllList();
        }

         

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        /// <summary>
        /// 获取评论列表内容
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="curPage"></param>
        /// <param name="createUserId"></param>
        /// <param name="createUserName"></param>
        /// <param name="courseId"></param>
        /// <param name="courseName"></param>
        /// <param name="studentId"></param>
        /// <param name="studentName"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static PageData GetPageData(int pageSize, int curPage, string createUserId, string createUserName, string courseId, string courseName, string studentId, string studentName, string status)
        {
            //构建查询条件
            Parameter parameter = new Parameter();

            parameter.SqlString = "SELECT [Id],[planId],[planName],[courseId],[courseName],[createUserName],[createUserId],[updateUserName],[updateUserId],[content],[createTime],[updateTime],"
                                   + " [status],[support],[oppose],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] FROM [YW_Comment] WHERE 1 = 1 ";
            List<SqlParameter> paramList = new List<SqlParameter>();
            if (createUserId != null && createUserId != "")
            {
                parameter.SqlString += " AND [YW_Comment].[createUserId] = @createUserId ";
                SqlParameter sqlParameter = new SqlParameter("@createUserId", SqlDbType.NVarChar, 50) { Value = createUserId };
                paramList.Add(sqlParameter);
            }
            if (createUserName != null && createUserName != "")
            {
                parameter.SqlString += " AND [YW_Comment].[createUserName] LIKE @createUserName ";
                SqlParameter sqlParameter = new SqlParameter("@createUserName", SqlDbType.NVarChar, 50) { Value = "%" + createUserName + "%" };
                paramList.Add(sqlParameter);
            }
            if (courseId != null && courseId != "")
            {
                parameter.SqlString += " AND [YW_Comment].[courseId] = @courseId ";
                SqlParameter sqlParameter = new SqlParameter("@courseId", SqlDbType.NVarChar, 50) { Value = courseId };
                paramList.Add(sqlParameter);
            }
            if (courseName != null && courseName != "")
            {
                parameter.SqlString += " AND [YW_Comment].[courseName] LIKE @courseName ";
                SqlParameter sqlParameter = new SqlParameter("@courseName", SqlDbType.NVarChar, 50) { Value = "%" + courseName + "%" };
                paramList.Add(sqlParameter);
            }
            if (studentId != null && studentId != "")
            {
                parameter.SqlString += " AND [YW_Comment].[studentId] = @studentId ";
                SqlParameter sqlParameter = new SqlParameter("@studentId", SqlDbType.NVarChar, 50) { Value = studentId };
                paramList.Add(sqlParameter);
            }
            if (studentName != null && studentName != "")
            {
                parameter.SqlString += " AND [YW_Comment].[studentName] LIKE @studentName ";
                SqlParameter sqlParameter = new SqlParameter("@studentName", SqlDbType.NVarChar, 50) { Value = "%" + studentName + "%" };
                paramList.Add(sqlParameter);
            }
            if (status != null && status != "")
            {
                parameter.SqlString += " AND [YW_Comment].[status] = @status ";
                SqlParameter sqlParameter = new SqlParameter("@status", SqlDbType.Int, 4) { Value = status };
                paramList.Add(sqlParameter);
            }
            parameter.SqlString += "  order by [createTime] desc ";
            parameter.Parameters = paramList.ToArray();

            return BLL.CommonToolsBLL.GetPageListByParamsOutBound(pageSize, curPage, parameter);
        }
          



    }
}
