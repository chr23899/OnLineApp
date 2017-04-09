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
    /// 对象名称：人员业务逻辑类（业务逻辑层）
    /// 对象说明：餐厅人员管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWPersonBLL
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
        internal static DAL.Common.YWPersonDAL DataAccess
        {
            get
            {
                return DAL.Common.YWPersonDAL.Instance;
            }
        }


        /// <summary>
        /// 对人员（YWPerson）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWPerson">人员（YWPerson）实例对象</param>
        public static void CheckValid(YWPerson yWPerson)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWPerson.UserName))
                throw new CustomException("“用户名”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPerson.Name))
                throw new CustomException("“姓名”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPerson.Sex))
                throw new CustomException("“性别”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPerson.Score))
                throw new CustomException("“评分”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPerson.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWPerson.UserName , 50))
                throw new CustomException("“用户名”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPerson.Name , 50))
                throw new CustomException("“姓名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPerson.Sex , 50))
                throw new CustomException("“性别”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPerson.Birth , 50))
                throw new CustomException("“出生年月”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPerson.EntryTime , 50))
                throw new CustomException("“入职时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPerson.Phone , 50))
                throw new CustomException("“电话”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPerson.IDCardId , 50))
                throw new CustomException("“身份证号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将人员（YWPerson）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPerson">人员（YWPerson）实例对象</param>
        public static int Insert(YWPerson yWPerson)
        {
            CheckValid(yWPerson);
            return DataAccess.Insert(yWPerson);
        }


        /// <summary>
        /// 将人员（YWPerson）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPerson">人员（YWPerson）实例对象</param>
        public static int Update(YWPerson yWPerson)
        {
            CheckValid(yWPerson);
            return DataAccess.Update(yWPerson);
        }


        /// <summary>
        /// 根据人员（YWPerson）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">人员（YWPerson）的主键“编号（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据条件参数采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="paramList">条件参数</param>
        public static int DeleteByParams(Parameter paramList)
        {
            return DataAccess.DeleteByParams(paramList);
        }


        /// <summary>
        /// 根据人员（YWPerson）的主键“编号（Id）”从数据库中获取人员（YWPerson）的实例。
        /// 成功从数据库中取得记录返回新人员（YWPerson）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">人员（YWPerson）的主键“编号（Id）”</param>
        public static YWPerson GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据人员（YWPerson）的主键“编号（Id）”从数据库中获取人员（YWPerson）的实例。
        /// 成功从数据库中取得记录返回新人员（YWPerson）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">人员（YWPerson）的主键“编号（Id）”</param>
        public static YWPerson GetDataById(string id)
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
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public static int GetUserRestaurantOrgId(string strUserName)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT [OrgId] FROM [YWPerson] WHERE [UserName]=@UserName ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
            };
            parameter.Parameters = parameters;
            return Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }

        //add by zy
        //检查是否存在重复的工作人员记录
        public static Boolean CheckPersonDataDuplicate(string strUserName, int iOrgId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT COUNT(*) FROM [YWPerson] WHERE [UserName] = @UserName AND [OrgId] = @OrgId";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"           , SqlDbType.NVarChar , 50        ){ Value = strUserName              },
                new SqlParameter("@OrgId"              , SqlDbType.Int      , 4         ){ Value = iOrgId                   }
            };
            parameter.Parameters = parameters;

            if (Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter)) > 0)
                return true;
            else
                return false;
        }

        //add by zy
        //获取系统所有工作人员列表
        public static PageData GetSystemUserList(int iPageSize, int iCurPage, string sOrgId, string sName, string sPhone, string sIDCardId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWPerson].[Id],[YWPerson].[UserName],[YWPerson].[Name],[YWPerson].[Sex],[YWPerson].[Birth],[YWPerson].[EntryTime],"
                                + "[YWPerson].[Phone],[YWPerson].[IDCardId],[YWPerson].[Score],[YWPerson].[OrgId],[PT_Org].[OrgName] "
                                + "FROM [YWPerson] "
                                + "LEFT JOIN [PT_Org] ON [PT_Org].[Id]=[YWPerson].[OrgId] WHERE 1 = 1  ";
            if (sOrgId.Trim() != "")
                parameter.SqlString += " AND [YWPerson].[OrgId] = " + sOrgId + " ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [YWPerson].[Name] LIKE '%" + sName + "%' ";
            if (sPhone.Trim() != "")
                parameter.SqlString += " AND [YWPerson].[Phone] LIKE '%" + sPhone + "%' ";
            if (sIDCardId.Trim() != "")
                parameter.SqlString += " AND [YWPerson].[IDCardId] LIKE '%" + sIDCardId + "%'  ";
            parameter.SqlString += "ORDER BY [YWPerson].[OrgId]";
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by zy
        //根据餐厅组织机构Id获取餐厅的所有工作人员列表
        public static PageData GetRestaurantPersonListByOrgId(int iOrgId, int iPageSize, int iCurPage, string sName, string sPhone, string sIDCardId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Id],[UserName],[Name],[Sex],[Birth],[EntryTime],[Phone],[IDCardId],[Score],[OrgId] FROM [YWPerson] WHERE [OrgId]=@OrgId  ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [Name] LIKE '%" + sName + "%' ";
            if (sPhone.Trim() != "")
                parameter.SqlString += " AND [Phone] LIKE '%" + sPhone + "%' ";
            if (sIDCardId.Trim() != "")
                parameter.SqlString += " AND [IDCardId] LIKE '%" + sIDCardId + "%'  ";
            SqlParameter[] parameters =
            {
                    new SqlParameter("@OrgId"    , SqlDbType.Int      , 4   ){ Value = iOrgId      }
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        ////根据用户名获取当前用户的详细信息
        //public static YWPerson GetDataByUserName(string strUserName)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [UserNameUserName]=@UserNameUserName ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@UserNameUserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter)[0];
        //}

        ////根据餐厅机构代码获取人员列表
        //public static List<YWPerson> GetAllListByOrgId(int iOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.NVarChar , 50 ){ Value = iOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据餐厅机构代码获取人员列表分页
        //public static PageData GetPageDataByOrgId(int pageSize, int curPage, int iOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.NVarChar , 50 ){ Value = iOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetPageListByParams(pageSize, curPage, parameter);
        //}

    }
}
