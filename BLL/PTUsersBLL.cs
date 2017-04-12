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
    /// 对象名称：基本用户信息业务逻辑类（业务逻辑层）
    /// 对象说明：管理支撑平台运行的基本用户信息，用于实现登录，快速注册和权限控制。
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTUsersBLL
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
        internal static DAL.Common.PTUsersDAL DataAccess
        {
            get
            {
                return DAL.Common.PTUsersDAL.Instance;
            }
        }


        /// <summary>
        /// 对基本用户信息（PTUsers）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="pTUsers">基本用户信息（PTUsers）实例对象</param>
        public static void CheckValid(PTUsers pTUsers)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(pTUsers.UserName))
                throw new CustomException("“用户名”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTUsers.Password))
                throw new CustomException("“密码”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTUsers.OrgId))
                throw new CustomException("“机构编号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTUsers.Nickname))
                throw new CustomException("“昵称”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTUsers.StateId))
                throw new CustomException("“状态”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(pTUsers.UserName , 50))
                throw new CustomException("“用户名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTUsers.Password , 50))
                throw new CustomException("“密码”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTUsers.Nickname , 50))
                throw new CustomException("“昵称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTUsers.StateId , 50))
                throw new CustomException("“状态”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTUsers.Alternate1 , 50))
                throw new CustomException("“备用１”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            

            if (DataValid.IsOutLength(pTUsers.Alternate3 , 50))
                throw new CustomException("“备用３”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTUsers.Alternate4 , 500))
                throw new CustomException("“备用４”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTUsers.Alternate5 , 500))
                throw new CustomException("“备用５”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将基本用户信息（PTUsers）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTUsers">基本用户信息（PTUsers）实例对象</param>
        public static int Insert(PTUsers pTUsers)
        {
            CheckValid(pTUsers);
            return DataAccess.Insert(pTUsers);
        }


        /// <summary>
        /// 将基本用户信息（PTUsers）数据，根据主键“用户名（UserName）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTUsers">基本用户信息（PTUsers）实例对象</param>
        public static int Update(PTUsers pTUsers)
        {
            CheckValid(pTUsers);
            return DataAccess.Update(pTUsers);
        }


        /// <summary>
        /// 根据基本用户信息（PTUsers）的主键“用户名（UserName）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="userName">基本用户信息（PTUsers）的主键“用户名（UserName）”</param>
        public static int Delete(string userName)
        {
            return DataAccess.Delete(userName);
        }


        /// <summary>
        /// 根据基本用户信息（PTUsers）的主键“用户名（UserName）”从数据库中获取基本用户信息（PTUsers）的实例。
        /// 成功从数据库中取得记录返回新基本用户信息（PTUsers）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="userName">基本用户信息（PTUsers）的主键“用户名（UserName）”</param>
        public static PTUsers GetDataByUserName(string userName)
        {
            return DataAccess.GetDataByUserName(userName);
        }


       

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍
         
        /// <summary>
        /// 根据基本用户信息（PTUsers）的主键“用户名（UserName）”从数据库中获取基本用户信息（PTUsers）的实例。
        /// 成功从数据库中取得记录返回新基本用户信息（PTUsers）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="userName">基本用户信息（PTUsers）的主键“用户名（UserName）”</param>
        public static DataTable GetDataTableByUserName(string userName)
        {
           // return DataAccess.GetDataByUserName(userName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT [PT_USER].[Id],[PT_USER].[UserName],[PT_USER].[Password],[PT_USER].[OrgId],[PT_ORG].[OrgName], "
                + " [PT_USER].[Nickname],[PT_USER].[StateId],[PT_USER].[Alternate1],[PT_USER].[Alternate2], "
                + " [PT_USER].[Alternate3],[PT_USER].[Alternate4],[PT_USER].[Alternate5] "
                + " FROM [PT_USER] LEFT JOIN [PT_ORG] ON [PT_USER].[OrgId] = [PT_ORG].[Id] "
                + " WHERE [PT_USER].[UserName]=@UserName ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = userName},
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetAllListByParams(parameter);
        }


        //获取所有用户列表的分页数据(查询条件：姓名关键字，机构名关键字，角色名关键字，手机号)
        public static PageData GetPageData(int pageSize, int curPage, string strNickname, string strOrgName, string strRoleId, string strMobile)
        {
            //构建查询条件
            Parameter parameter = new Parameter();

            parameter.SqlString = "SELECT DISTINCT [PT_USER].[Id],[PT_USER].[UserName],[PT_USER].[Password],[PT_USER].[OrgId],[PT_ORG].[OrgName], [PT_USER].[Nickname], CONVERT( BIT, [PT_USER].[StateId]) AS [StateId], [PT_USER].[Alternate1],[PT_USER].[Alternate2],[PT_USER].[Alternate3],[PT_USER].[Alternate4],[PT_USER].[Alternate5] "
                           + ", [PT_USER].[Balance], [PT_USER].[ValidityDT], [PT_USER].[Position], [PT_USER].[Company], [PT_USER].[Tel], [PT_USER].[QQ], [PT_USER].[WeChat], [PT_USER].[Email], [PT_USER].[HomePage], [PT_USER].[Type], [PT_USER].[Layer], [PT_USER].[Note] "
                           + "FROM [PT_USER], [PT_ORG], [PT_UserLink] "
                           + "WHERE [PT_USER].[OrgId]=[PT_ORG].[Id] AND [PT_USER].[UserName]=[PT_UserLink].[UserName]";
            List<SqlParameter> paramList = new List<SqlParameter>();
            if (strNickname != null && strNickname != "")
            { 
                parameter.SqlString += " AND [PT_USER].[Nickname] LIKE @Nickname ";
                SqlParameter sqlParameter = new SqlParameter("@Nickname", SqlDbType.NVarChar, 50) { Value = "%" + strNickname + "%" };
                paramList.Add(sqlParameter);
            }
            if (strOrgName != null && strOrgName != "")
            {
                parameter.SqlString += " AND [PT_ORG].[OrgName] LIKE @OrgName ";
                SqlParameter sqlParameter = new SqlParameter("@OrgName", SqlDbType.NVarChar, 50) { Value = "%" + strOrgName + "%" };
                paramList.Add(sqlParameter);
            }
            if (strRoleId != null && strRoleId != "")
            {
                parameter.SqlString += " AND [PT_UserLink].[RoleId] = @RoleId ";
                SqlParameter sqlParameter = new SqlParameter("@RoleId", SqlDbType.NVarChar, 50) { Value = strRoleId};
                paramList.Add(sqlParameter);
            }
            if (strMobile != null && strMobile != "")
            {
                parameter.SqlString += " AND [PT_USER].[Alternate1] = @Mobile ";
                SqlParameter sqlParameter = new SqlParameter("@Mobile", SqlDbType.NVarChar, 50) { Value = strMobile };
                paramList.Add(sqlParameter);
            }
            parameter.Parameters = paramList.ToArray();

            return BLL.CommonToolsBLL.GetPageListByParamsOutBound(pageSize, curPage, parameter);
        }


        /// <summary>
        /// add by chr
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public static int GetUserOrgId(string strUserName)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT [OrgId] FROM [PT_USER] WHERE [UserName]=@UserName ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
            };
            parameter.Parameters = parameters;
            return Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }

        /// <summary>
        /// add by chr
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public static DataTable GetUserByTel(string strTel)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT [OrgId] FROM [PT_USER] WHERE [Alternate1]=@Alternate1 ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Alternate1"   , SqlDbType.NVarChar , 50 ){ Value = strTel},
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        /// <summary>
        /// add by chr
        /// 根据功能id和组织机构id，获取相应的用户列表
        /// </summary>
        /// <param name="strFunctionId"></param>
        /// <param name="iOrgId"></param>
        /// <returns></returns>
        public static DataTable GetUserNameByFunctionIdAndOrgId(string strFunctionId, int iOrgId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT DISTINCT [PT_User].[UserName] FROM [PT_User],[PT_UserLink],[PT_RoleLink] ";
            parameter.SqlString += "WHERE [PT_RoleLink].[FunctionId]=@FunctionId AND [PT_User].[OrgId]=@OrgId AND [PT_UserLink].[RoleId] = [PT_RoleLink].[RoleId] AND [PT_User].[UserName] = [PT_UserLink].[UserName] ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@FunctionId"   , SqlDbType.NVarChar , 50 ){ Value = strFunctionId},
                new SqlParameter("@OrgId"        , SqlDbType.Int      , 50 ){ Value = iOrgId},
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        /// <summary>
        /// add by chr
        /// 根据用户名获取本单位的所有已启用的用户列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetUserListByUserName(string strUserName)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWPerson].[UserName],[PT_User].[Nickname],[YWPerson].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [YWPerson] "
                                + "LEFT JOIN [PT_ORG] ON [YWPerson].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [PT_User] ON [YWPerson].[UserName]=[PT_User].[UserName] "
                                + "WHERE [YWPerson].[OrgId]=@OrgId AND [PT_User].[StateId]=1";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"        , SqlDbType.Int      , 50 ){ Value = iOrgId}
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        /// <summary>
        /// add by chr
        /// 根据用户名获取本餐厅可用的餐桌负责人列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTableDutyUserList(string strUserName)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWPerson].[UserName],[PT_User].[Nickname],[YWPerson].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [YWPerson] "
                                + "LEFT JOIN [PT_ORG] ON [YWPerson].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [PT_User] ON [YWPerson].[UserName]=[PT_User].[UserName] "
                                + "INNER JOIN [PT_UserLink] ON [YWPerson].[UserName]=[PT_UserLink].[UserName] "
                                + "WHERE [YWPerson].[OrgId]=@OrgId AND [PT_User].[StateId]=1 AND [PT_UserLink].[RoleId]=@RoleId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"        , SqlDbType.Int      , 50 ){ Value = iOrgId},
                new SqlParameter("@RoleId"       , SqlDbType.Int      , 50 ){ Value = CodeDictionary.UserRole["一般用户（初始默认）"]}
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        /// <summary>
        /// add by chr
        /// 根据用户名获取本餐厅可用的餐桌负责人列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTableDutyUserListByOrgId(string strOrgId)
        {
            int iOrgId = Convert.ToInt32(strOrgId);
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWPerson].[UserName],[PT_User].[Nickname],[YWPerson].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [YWPerson] "
                                + "LEFT JOIN [PT_ORG] ON [YWPerson].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [PT_User] ON [YWPerson].[UserName]=[PT_User].[UserName] "
                                + "INNER JOIN [PT_UserLink] ON [YWPerson].[UserName]=[PT_UserLink].[UserName] "
                                + "WHERE [YWPerson].[OrgId]=@OrgId AND [PT_User].[StateId]=1 AND [PT_UserLink].[RoleId]=@RoleId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"        , SqlDbType.Int      , 50 ){ Value = iOrgId},
                new SqlParameter("@RoleId"       , SqlDbType.Int      , 50 ){ Value = CodeDictionary.UserRole["一般用户（初始默认）"]}
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        /// <summary>
        /// add by chr
        /// 根据餐厅组织机构Id获取获取餐厅所有用户列表
        /// </summary>
        /// <returns></returns>
        public static DataTable GetRestaurantUserListByOrgId(int iOrgId)
        {
            string strAllSubOrgId = PTOrgBLL.GetAllSubOrgIdString(iOrgId.ToString());
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [PT_User].[UserName],[PT_User].[Nickname],[PT_User].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [PT_User] "
                                + "LEFT JOIN [PT_ORG] ON [PT_User].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [PT_User].[OrgId] IN (" + strAllSubOrgId + (strAllSubOrgId.Trim() == "" ? "" : ",") + iOrgId.ToString() + ") AND [PT_User].[StateId]=1";
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        /// <summary>
        /// add by chr
        /// 通过用户名将用户的所有信息进行删除
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static void DeleteUser(string userName)
        { 
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = " DELETE FROM PT_UserLink WHERE UserName = @UserName";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = userName}, 
            };
            parameter1.Parameters = parameters1;
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = " DELETE  FROM PT_USER WHERE UserName= @UserName";
            SqlParameter[] parameters2 = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = userName}, 
            };
            parameter2.Parameters = parameters2;
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);
            CommonToolsBLL.ExcuteSqlWithTransaction(parmList); 
        }

        //根据机构id获取其包含的所有用户列表
        //public static List<PTUsers> GetUserListByOrgId(string strOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId] IN (" +  PTOrgBLL.GetAllOrgIdListByOrgId(Convert.ToInt32(strOrgId)) +  ") ORDER BY [Id]";
        //    SqlParameter[] parameters = null;
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        //根据用户名修改密码
        //public static void ChangePasswordByUserName(string strUserName, string strOldPassword, string strNewPassword)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId] IN (" + PTOrgBLL.GetAllOrgIdListByOrgId(Convert.ToInt32(strOrgId)) + ") ORDER BY [Id]";
        //    SqlParameter[] parameters = null;
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}
        

    }
}
