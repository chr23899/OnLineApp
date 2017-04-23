using System;
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
    /// 编写日期：2017/4/12 21:27:52
    /// </summary>
    public class YWCourseBLL
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
        internal static DAL.Common.YWCourseDAL DataAccess
        {
            get
            {
                return DAL.Common.YWCourseDAL.Instance;
            }
        }


        /// <summary>
        /// 对基础对象名称（YWCourse）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWCourse">基础对象名称（YWCourse）实例对象</param>
        public static void CheckValid(YWCourse yWCourse)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWCourse.CourseName))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWCourse.LinkBook))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWCourse.TeacherName))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWCourse.TeacherId))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWCourse.CreateTime))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWCourse.UpdateTime))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWCourse.UpdateUserName))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWCourse.UpdateUserId))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWCourse.Status))
                throw new CustomException("“”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWCourse.CourseName, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.LinkBook, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.TeacherName, 20))
                throw new CustomException("“”长度不能超过 20 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.Content, 500))
                throw new CustomException("“”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.Title, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.Span, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.Show, 10))
                throw new CustomException("“”长度不能超过 10 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.Pic, 500))
                throw new CustomException("“”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.UpdateUserName, 20))
                throw new CustomException("“”长度不能超过 20 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.Alternate1, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.Alternate2, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.Alternate3, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.Alternate4, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWCourse.Alternate5, 50))
                throw new CustomException("“”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }




        /// <summary>
        /// 将基础对象名称（YWCourse）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWCourse">基础对象名称（YWCourse）实例对象</param>
        public static int Insert(YWCourse yWCourse)
        {
            CheckValid(yWCourse);
            return DataAccess.Insert(yWCourse);
        }


        /// <summary>
        /// 将基础对象名称（YWCourse）数据，根据主键“（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWCourse">基础对象名称（YWCourse）实例对象</param>
        public static int Update(YWCourse yWCourse)
        {
            CheckValid(yWCourse);
            return DataAccess.Update(yWCourse);
        }


        /// <summary>
        /// 根据基础对象名称（YWCourse）的主键“（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">基础对象名称（YWCourse）的主键“（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据基础对象名称（YWCourse）的主键“（Id）”从数据库中获取基础对象名称（YWCourse）的实例。
        /// 成功从数据库中取得记录返回新基础对象名称（YWCourse）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基础对象名称（YWCourse）的主键“（Id）”</param>
        public static YWCourse GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据基础对象名称（YWCourse）的主键“（Id）”从数据库中获取基础对象名称（YWCourse）的实例。
        /// 成功从数据库中取得记录返回新基础对象名称（YWCourse）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基础对象名称（YWCourse）的主键“（Id）”</param>
        public static YWCourse GetDataById(string id)
        {
            if (!DataValid.IsInt(id))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// 从数据库中读取并返回所有基础对象名称（YWCourse）List列表。
        /// </summary>
        public static List<YWCourse> GetAllList()
        {
            return DataAccess.GetAllList();
        }
         
        #endregion EasyCode所生成的默认代码


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        /// <summary>
        /// 获取课程分页数据
        /// </summary>
        /// <param name="pageSize">页大小</param>
        /// <param name="curPage">当前页</param>
        /// <param name="teacherId">教师Id</param>
        /// <param name="teacherName">教师Name</param>
        /// <param name="content">描述</param>
        /// <param name="title">标题</param> 
        /// <returns>返回课程分页查询结果集</returns>
        public static PageData GetPageData(int pageSize, int curPage, string teacherId, string teacherName, string content, string title, string status)
        {
            //构建查询条件
            Parameter parameter = new Parameter();

            parameter.SqlString = "SELECT ta.[Id],[courseName],[linkBook],[teacherName],[teacherId],[content],[title],[span],[show],[courseNum],[pic],[createTime],[updateTime],"
                                   + "[updateUserName],[updateUserId],[status],ta.[Alternate1],ta.[Alternate2],ta.[Alternate3],ta.[Alternate4],ta.[Alternate5],ta.[support],ta.[oppose],ta.[share], tb.[Alternate2]  "
                                   + "[userPic] FROM [YW_Course] ta LEFT JOIN [PT_USER] tb ON [tb].[Id] = [ta].[teacherId] WHERE 1 = 1  ";
            List<SqlParameter> paramList = new List<SqlParameter>();
            if (teacherId != null && teacherId != "")
            {
                parameter.SqlString += " AND [ta].[teacherId] = @teacherId ";
                SqlParameter sqlParameter = new SqlParameter("@teacherId", SqlDbType.NVarChar, 50) { Value = teacherId };
                paramList.Add(sqlParameter);
            }
            if (teacherName != null && teacherName != "")
            {
                parameter.SqlString += " AND [ta].[teacherName] LIKE @teacherName ";
                SqlParameter sqlParameter = new SqlParameter("@teacherName", SqlDbType.NVarChar, 50) { Value = "%" + teacherName + "%" };
                paramList.Add(sqlParameter);
            }
            if (content != null && content != "")
            {
                parameter.SqlString += " AND [ta].[content] LIKE @content ";
                SqlParameter sqlParameter = new SqlParameter("@content", SqlDbType.NVarChar, 50) { Value = "%" + content + "%" };
                paramList.Add(sqlParameter);
            }
            if (title != null && title != "")
            {
                parameter.SqlString += " AND [ta].[title] LIKE @title ";
                SqlParameter sqlParameter = new SqlParameter("@title", SqlDbType.NVarChar, 50) { Value = "%" + title + "%" };
                paramList.Add(sqlParameter);
            }
            if (status != null && status != "")
            {
                parameter.SqlString += " AND [ta].[status] = @status ";
                SqlParameter sqlParameter = new SqlParameter("@status", SqlDbType.Int, 4) { Value = status };
                paramList.Add(sqlParameter);
            }
            parameter.SqlString += "  order by [ta].[createTime] desc ";
            parameter.Parameters = paramList.ToArray();

            return BLL.CommonToolsBLL.GetPageListByParamsOutBound(pageSize, curPage, parameter);
        }
         
    }
}
