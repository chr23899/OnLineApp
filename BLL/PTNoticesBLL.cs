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
    /// 对象名称：提示消息业务逻辑类（业务逻辑层）
    /// 对象说明：管理用于输出给用户的各种类别的消息提示，可以定义机构，角色和用户作为对象范围
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTNoticesBLL
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
        internal static DAL.Common.PTNoticesDAL DataAccess
        {
            get
            {
                return DAL.Common.PTNoticesDAL.Instance;
            }
        }


        /// <summary>
        /// 对提示消息（Notices）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="notices">提示消息（Notices）实例对象</param>
        public static void CheckValid(PTNotices notices)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(notices.TypeId))
                throw new CustomException("“类别”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(notices.ReleaseTime))
                throw new CustomException("“发布时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(notices.ReadStatus))
                throw new CustomException("“已读状态”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(notices.Title))
                throw new CustomException("“标题”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(notices.TypeId, 50))
                throw new CustomException("“类别”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.OrgRange, 50))
                throw new CustomException("“机构范围”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.RoleScope, 50))
                throw new CustomException("“角色范围”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.UserRange, 50))
                throw new CustomException("“用户范围”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.Author, 50))
                throw new CustomException("“作者”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.ReleaseTime, 50))
                throw new CustomException("“发布时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.ReadStatus, 50))
                throw new CustomException("“已读状态”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.Title, 50))
                throw new CustomException("“标题”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.Content, 20000))
                throw new CustomException("“正文”长度不能超过 20000 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.Attachment, 50))
                throw new CustomException("“附件地址”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.PictureAddress, 50))
                throw new CustomException("“图片地址”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.Alternate1, 50))
                throw new CustomException("“备用１”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.Alternate2, 50))
                throw new CustomException("“备用２”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.Alternate3, 50))
                throw new CustomException("“备用３”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.Alternate4, 50))
                throw new CustomException("“备用４”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(notices.Alternate5, 50))
                throw new CustomException("“备用５”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将提示消息（Notices）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="notices">提示消息（Notices）实例对象</param>
        public static int Insert(PTNotices notices)
        {
            CheckValid(notices);
            return DataAccess.Insert(notices);
        }


        /// <summary>
        /// 将提示消息（Notices）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="notices">提示消息（Notices）实例对象</param>
        public static int Update(PTNotices notices)
        {
            CheckValid(notices);
            return DataAccess.Update(notices);
        }


        /// <summary>
        /// 根据提示消息（Notices）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">提示消息（Notices）的主键“编号（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据提示消息（Notices）的主键“编号（Id）”从数据库中获取提示消息（Notices）的实例。
        /// 成功从数据库中取得记录返回新提示消息（Notices）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">提示消息（Notices）的主键“编号（Id）”</param>
        public static PTNotices GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据提示消息（Notices）的主键“编号（Id）”从数据库中获取提示消息（Notices）的实例。
        /// 成功从数据库中取得记录返回新提示消息（Notices）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">提示消息（Notices）的主键“编号（Id）”</param>
        public static PTNotices GetDataById(string id)
        {
            if (!DataValid.IsInt(id))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


      

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍



        //获取所有用户列表的分页数据(查询条件：姓名关键字，机构名关键字，角色名关键字，手机号)
        public static PageData GetPageData(int pageSize, int curPage, string strKeyWord, string strTypeId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();

            parameter.SqlString = "SELECT PT_NOTICE.[Id],[TypeId] AS [TypeIdId], NoticeType.Name AS TypeIdName, [OrgRange],[RoleScope],[UserRange],[Author],[ReleaseTime], "
                           + " [ReadStatus],[Title],[Content],[Attachment],[PictureAddress] ,[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] "
                           + " FROM PT_NOTICE LEFT JOIN NoticeType ON  PT_NOTICE.TypeId = NoticeType.Id WHERE 1= 1 "; 
            List<SqlParameter> paramList = new List<SqlParameter>();
            if (strKeyWord != "")
            {
                parameter.SqlString += " AND [PT_NOTICE].[Title] LIKE @Title ";
                SqlParameter sqlParameter = new SqlParameter("@Title", SqlDbType.NVarChar, 50) { Value = "%" + strKeyWord + "%" };
                paramList.Add(sqlParameter);
            }
            if (strTypeId != "")
            {
                parameter.SqlString += " AND [PT_NOTICE].[TypeId] = @TypeId ";
                SqlParameter sqlParameter = new SqlParameter("@TypeId", SqlDbType.NVarChar, 50) { Value = strTypeId  };
                paramList.Add(sqlParameter);
            }
            parameter.SqlString += " ORDER BY ReleaseTime DESC ";
            parameter.Parameters = paramList.ToArray();

            return BLL.CommonToolsBLL.GetPageListByParamsOutBound(pageSize, curPage, parameter);
        }

        ///// <summary>
        ///// 根据查询条件，从数据库中读取并返回所有提示消息（Notices）List列表。
        ///// </summary>
        //public static List<Notices> GetAllListByParams(Parameter paramList)
        //{
        //    return DataAccess.GetAllListByParams(paramList);
        //}


        ///// <summary>
        ///// 根据查询条件，每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的提示消息（Notices）的列表及分页信息。
        ///// 该方法所获取的提示消息（Notices）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        ///// </summary>
        //public static PageData GetPageListByParams(int pageSize, int curPage, Parameter paramList)
        //{
        //    return DataAccess.GetPageListByParams(pageSize, curPage, paramList);
        //}


        //public static List<Notices> GetSliderNoticesList(string strTypeId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE  [TypeId] IN (" + strTypeId + ")   ORDER BY [ReleaseTime] DESC";
            


        //    return DataAccess.GetTopNListByParams(parameter, 5);
        //}

        //public static PageData GetNoticePageByType(int pageSize, int curPage, string strTypeId, string strKeyWord)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE  [TypeId] IN (" + strTypeId + ") AND ( [Title] LIKE @Title OR [Content] LIKE @Content )  ORDER BY [ReleaseTime] DESC";
        //    SqlParameter[] parameters = 
        //    {
                
                
        //        new SqlParameter("@Title"   , SqlDbType.NVarChar , 50 ){ Value = @"%" + strKeyWord + @"%"},
        //        new SqlParameter("@Content"   , SqlDbType.NVarChar , 50 ){ Value = @"%" + strKeyWord + @"%"},
                
        //    };
        //    parameter.Parameters = parameters;


        //    return DataAccess.GetPageListByParams(pageSize, curPage, parameter);
        //}

        //public static List<Notices> GetNoticeListByType(string strTypeId, string strKeyWord)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE  [TypeId] IN (" + strTypeId + ") AND ( [Title] LIKE @Title OR [Content] LIKE @Content )  ORDER BY [ReleaseTime] DESC";
        //    SqlParameter[] parameters = 
        //    {
                
                
        //        new SqlParameter("@Title"   , SqlDbType.NVarChar , 50 ){ Value = @"%" + strKeyWord + @"%"},
        //        new SqlParameter("@Content"   , SqlDbType.NVarChar , 50 ){ Value = @"%" + strKeyWord + @"%"},
                
        //    };
        //    parameter.Parameters = parameters;


        //    return DataAccess.GetAllListByParams(parameter);
        //}

    }
}
