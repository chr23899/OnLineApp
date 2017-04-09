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
    /// 对象名称：基本角色信息业务逻辑类（业务逻辑层）
    /// 对象说明：管理支撑平台运行的基本角色信息，用于权限控制和分级授权。
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTRolesBLL
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
        internal static DAL.Common.PTRolesDAL DataAccess
        {
            get
            {
                return DAL.Common.PTRolesDAL.Instance;
            }
        }


        /// <summary>
        /// 对基本角色信息（PTRoles）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="pTRoles">基本角色信息（PTRoles）实例对象</param>
        public static void CheckValid(PTRoles pTRoles)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(pTRoles.RoleName))
                throw new CustomException("“角色名称”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTRoles.StateId))
                throw new CustomException("“状态”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(pTRoles.RoleName , 50))
                throw new CustomException("“角色名称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTRoles.GroupId , 50))
                throw new CustomException("“分组编号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTRoles.StateId , 50))
                throw new CustomException("“状态”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTRoles.Alternate1 , 50))
                throw new CustomException("“备用１”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTRoles.Alternate2 , 50))
                throw new CustomException("“备用２”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTRoles.Alternate3 , 50))
                throw new CustomException("“备用３”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTRoles.Alternate4 , 500))
                throw new CustomException("“备用４”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTRoles.Alternate5 , 500))
                throw new CustomException("“备用５”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将基本角色信息（PTRoles）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTRoles">基本角色信息（PTRoles）实例对象</param>
        public static int Insert(PTRoles pTRoles)
        {
            CheckValid(pTRoles);
            return DataAccess.Insert(pTRoles);
        }


        /// <summary>
        /// 将基本角色信息（PTRoles）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTRoles">基本角色信息（PTRoles）实例对象</param>
        public static int Update(PTRoles pTRoles)
        {
            CheckValid(pTRoles);
            return DataAccess.Update(pTRoles);
        }


        /// <summary>
        /// 根据基本角色信息（PTRoles）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">基本角色信息（PTRoles）的主键“编号（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据基本角色信息（PTRoles）的主键“编号（Id）”从数据库中获取基本角色信息（PTRoles）的实例。
        /// 成功从数据库中取得记录返回新基本角色信息（PTRoles）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基本角色信息（PTRoles）的主键“编号（Id）”</param>
        public static PTRoles GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据基本角色信息（PTRoles）的主键“编号（Id）”从数据库中获取基本角色信息（PTRoles）的实例。
        /// 成功从数据库中取得记录返回新基本角色信息（PTRoles）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基本角色信息（PTRoles）的主键“编号（Id）”</param>
        public static PTRoles GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }

        /// <summary>
        /// 从数据库中读取并返回所有基本角色信息（PTRoles）List列表。
        /// </summary>
        public static List<PTRoles> GetAllList()
        {
            return DataAccess.GetAllList();
        }
      


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        /// <summary>
        /// 通过传入的角色id组成的字符串 来删除角色
        /// </summary>
        /// <param name="strDelete"></param>
        /// <returns></returns>
        public static bool DeleteRolesByStr(string strDelete)
        {
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = " SELECT * FROM PT_UserLink WHERE RoleId IN(" + strDelete + ") "; 
            //查询数据
            DataTable dt = BLL.CommonToolsBLL.GetAllListByParams(parameter1);
            if (dt.Rows.Count > 0) 
                return false;  

            //构建多个查询条件
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = " DELETE FROM PT_ROLE WHERE Id IN(" + strDelete + ") ";

            //角色关联功能
            Parameter parameter3 = new Parameter();
            parameter3.SqlString = " DELETE FROM PT_RoleLink WHERE RoleId IN(" + strDelete + ") ";

            //角色关联用户
            Parameter parameter4 = new Parameter();
            parameter4.SqlString = " DELETE FROM PT_UserLink WHERE RoleId IN(" + strDelete + ") "; 

            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter2);
            parmList.Add(parameter3);
            parmList.Add(parameter4);
            CommonToolsBLL.ExcuteSqlWithTransaction(parmList);
            return true;
        }

        public static bool UpdateRoleLink(string strDelete, string strRoleId)
        {
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = " DELETE FROM PT_RoleLink WHERE RoleId = " + strRoleId + " ";
            //构建多个查询条件
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = " INSERT PT_RoleLink VALUES('" + strRoleId + "','01') ";
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);
            string[] lstr = strDelete.Split(',');
            foreach (string str in lstr)
            {
                //角色关联功能
                Parameter parameter = new Parameter();
                parameter.SqlString = " INSERT PT_RoleLink VALUES('" + strRoleId + "','" + str + "') ";
                parmList.Add(parameter);
            }
            CommonToolsBLL.ExcuteSqlWithTransaction(parmList);
            return true;
        }

        /// <summary>
        /// add by chr
        /// 根据角色类型获取角色数据列表
        /// </summary>
        /// <param name="strType">0-系统角色 1-业务角色</param>
        /// <returns></returns>
        public static DataTable GetRolesByType(string strType)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Id],[RoleName],[GroupId], [StateId],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] ";
            parameter.SqlString += " FROM [PT_ROLE] WHERE [GroupId] = @GroupId ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@GroupId"   , SqlDbType.NVarChar , 50 ){ Value = strType}, 
            }; 
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        /// <summary>
        /// add by chr
        /// 根据用户名strUserName来获取该用户所有的角色
        /// </summary>
        /// <param name="strUserName"></param> 
        /// <returns></returns>
        public static DataTable GetRolesByUserName(string strUserName)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [PT_UserLink].[Id] AS [LinkId], [PT_ROLE].[Id] AS [RoleId],[UserName],[RoleName] ,[StateId] ";
            parameter.SqlString += " FROM [PT_UserLink] LEFT JOIN  [PT_ROLE] ON  [PT_ROLE].[Id] = [PT_UserLink].[RoleId] WHERE [UserName] = @UserName ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName}, 
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        /// <summary>
        /// 公共方法：判断当前用户是否是超级管理员（用来做针对管理员的特殊处理）
        /// </summary>
        //public static bool IsAdmin(string strUserName)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [UserName]=@UserName AND [RoleId]=@RoleId";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
        //        new SqlParameter("@RoleId"   , SqlDbType.NVarChar , 50 ){ Value = "1"},
        //    };
        //    parameter.Parameters = parameters;

        //    if (BLL.UserLinkBLL.GetAllListByParams(parameter).Count != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}

        /// <summary>
        /// 公共方法：根据功能名称判断用户的操作权限
        /// </summary>
        //public static bool UserRoleCheck(string strUserName, string strPath)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = ",[PT_RoleLink],[PT_UserLink] WHERE [PT_FUNCTION].[Id]=[PT_RoleLink].[FunctionId] AND [PT_RoleLink].[RoleId]=[PT_UserLink].[RoleId] AND [PT_UserLink].[UserName]=@UserName AND [PT_FUNCTION].[FunctionPath]=@FunctionPath AND [PT_FUNCTION].[StateId] > '0' ORDER BY [Id] ";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
        //        new SqlParameter("@FunctionPath"   , SqlDbType.NVarChar , 50 ){ Value = strPath},
        //    };
        //    parameter.Parameters = parameters;
        //    if (BLL.PTFunctionsBLL.GetListByParams(parameter).Count != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}





    }
}
