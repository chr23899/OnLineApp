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
    /// 对象名称：系统功能列表业务逻辑类（业务逻辑层）
    /// 对象说明：管理系统所有的可授权功能，及其相应的说明描述，用于分角色授权。
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTFunctionsBLL
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
        internal static DAL.Common.PTFunctionsDAL DataAccess
        {
            get
            {
                return DAL.Common.PTFunctionsDAL.Instance;
            }
        }


        /// <summary>
        /// 对系统功能列表（PTFunctions）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="pTFunctions">系统功能列表（PTFunctions）实例对象</param>
        public static void CheckValid(PTFunctions pTFunctions)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(pTFunctions.Id))
                throw new CustomException("“编号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTFunctions.FatherNumber))
                throw new CustomException("“上级编号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTFunctions.FunctionName))
                throw new CustomException("“功能名称”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTFunctions.StateId))
                throw new CustomException("“状态”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(pTFunctions.Id , 50))
                throw new CustomException("“编号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTFunctions.FatherNumber , 50))
                throw new CustomException("“上级编号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTFunctions.FunctionName , 50))
                throw new CustomException("“功能名称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTFunctions.FunctionTypeId , 50))
                throw new CustomException("“功能类型”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTFunctions.FunctionPath , 50))
                throw new CustomException("“路径”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTFunctions.Description , 500))
                throw new CustomException("“功能描述”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTFunctions.StateId , 50))
                throw new CustomException("“状态”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTFunctions.Alternate1 , 50))
                throw new CustomException("“备用１”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTFunctions.Alternate2 , 50))
                throw new CustomException("“备用２”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTFunctions.Alternate3 , 50))
                throw new CustomException("“备用３”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTFunctions.Alternate4 , 500))
                throw new CustomException("“备用４”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTFunctions.Alternate5 , 500))
                throw new CustomException("“备用５”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将系统功能列表（PTFunctions）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTFunctions">系统功能列表（PTFunctions）实例对象</param>
        public static int Insert(PTFunctions pTFunctions)
        {
            CheckValid(pTFunctions);
            return DataAccess.Insert(pTFunctions);
        }


        /// <summary>
        /// 将系统功能列表（PTFunctions）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTFunctions">系统功能列表（PTFunctions）实例对象</param>
        public static int Update(PTFunctions pTFunctions)
        {
            CheckValid(pTFunctions);
            return DataAccess.Update(pTFunctions);
        }


        /// <summary>
        /// 根据系统功能列表（PTFunctions）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">系统功能列表（PTFunctions）的主键“编号（Id）”</param>
        public static int Delete(string id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据系统功能列表（PTFunctions）的主键“编号（Id）”从数据库中获取系统功能列表（PTFunctions）的实例。
        /// 成功从数据库中取得记录返回新系统功能列表（PTFunctions）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">系统功能列表（PTFunctions）的主键“编号（Id）”</param>
        public static PTFunctions GetDataById(string id)
        {
            return DataAccess.GetDataById(id);
        }




        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        //临时方法，获取所有function分页数据
        public static PageData GetAllFunction(int pageSize, int curPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Id],[FatherNumber],[FunctionName],[FunctionTypeId],[FunctionPath],[Description],[StateId],[Alternate1],[Alternate2],[Alternate3],"
                           + "[Alternate4],[Alternate5] "
                           + "FROM [PT_FUNCTION] ORDER BY [Id]";
            SqlParameter[] parameters = null;
            parameter.Parameters = parameters;
            //查询数据
            return BLL.CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }



        /// <summary>
        /// 公共方法：获取某一功能节点下一级子功能的列表，不含已禁用的功能，筛选用户权限
        /// </summary>
        public static DataTable GetSubFunctionActiveByUserName(string strUserName, string strFunctionId ,string strTypeIds)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT DISTINCT [PT_FUNCTION].[Id],[PT_FUNCTION].[FatherNumber],[PT_FUNCTION].[FunctionName],[PT_FUNCTION].[FunctionTypeId],[PT_FUNCTION].[FunctionPath],[PT_FUNCTION].[Description],[PT_FUNCTION].[StateId],[PT_FUNCTION].[Alternate1],[PT_FUNCTION].[Alternate2],[PT_FUNCTION].[Alternate3],"
                           + "[PT_FUNCTION].[Alternate4],[PT_FUNCTION].[Alternate5] "
                           + "FROM [PT_FUNCTION],[PT_RoleLink],[PT_UserLink] "
                           + "WHERE [PT_FUNCTION].[Id]=[PT_RoleLink].[FunctionId] AND [PT_RoleLink].[RoleId]=[PT_UserLink].[RoleId] AND [PT_UserLink].[UserName]=@UserName AND [PT_FUNCTION].[FatherNumber]=@FatherNumber AND [PT_FUNCTION].[StateId] > '0'  AND [PT_FUNCTION].[FunctionTypeId] IN (" + strTypeIds + @") ORDER BY [PT_FUNCTION].[Id] ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
                new SqlParameter("@FatherNumber"   , SqlDbType.NVarChar , 50 ){ Value = strFunctionId},
            };
            parameter.Parameters = parameters;
            //查询数据
            return BLL.CommonToolsBLL.GetAllListByParams(parameter);
        }

        /// <summary>
        /// 公共方法：获取某一功能节点所有下级子功能的列表（递归），返回菜单格式的JSON
        /// </summary>
        public static string GetAllSubMenuByUserName(string strUserName, string strFunctionId, string strTypeIds)
        {
            DataTable dtSubFunction = GetSubFunctionActiveByUserName(strUserName, strFunctionId, strTypeIds);
            string strResult = @"[";
            for (int i = 0; i < dtSubFunction.Rows.Count; i++)
            {
                if (i > 0)
                {
                    strResult += @",";
                }
                strResult += @"{";
                strResult += @"""text"":""" + dtSubFunction.Rows[i]["FunctionName"].ToString() + @""",";
                strResult += @"""sref"":""" + ((dtSubFunction.Rows[i]["FunctionPath"] != null) ? dtSubFunction.Rows[i]["FunctionPath"].ToString() : "#") + @""",";
                strResult += @"""icon"":""" + dtSubFunction.Rows[i]["Alternate1"].ToString() + @"""";
                if (GetSubFunctionByUserName(strUserName, dtSubFunction.Rows[i]["Id"].ToString(), strTypeIds).Rows.Count > 0)
                {
                    strResult += @",""submenu"":" + GetAllSubMenuByUserName(strUserName, dtSubFunction.Rows[i]["Id"].ToString(), strTypeIds);
                }
                strResult += @"}";
            }
            strResult += @"]";

            return strResult;
        }
        /// <summary>
        /// 公共方法：获取某一功能节点下一级子功能的列表，包含已禁用的功能，筛选用户权限
        /// </summary>
        public static DataTable GetSubFunctionByUserName(string strUserName, string strFunctionId, string strTypeIds)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT DISTINCT [PT_FUNCTION].[Id],[PT_FUNCTION].[FatherNumber],[PT_FUNCTION].[FunctionName],[PT_FUNCTION].[FunctionTypeId],[PT_FUNCTION].[FunctionPath],[PT_FUNCTION].[Description], CONVERT( BIT, [PT_FUNCTION].[StateId]) AS [StateId] ,[PT_FUNCTION].[Alternate1],[PT_FUNCTION].[Alternate2],[PT_FUNCTION].[Alternate3],"
                           + "[PT_FUNCTION].[Alternate4],[PT_FUNCTION].[Alternate5] "
                           + "FROM [PT_FUNCTION],[PT_RoleLink],[PT_UserLink] "
                           + "WHERE [PT_FUNCTION].[Id]=[PT_RoleLink].[FunctionId] AND [PT_RoleLink].[RoleId]=[PT_UserLink].[RoleId] AND [PT_UserLink].[UserName]=@UserName AND [PT_FUNCTION].[FatherNumber]=@FatherNumber AND [PT_FUNCTION].[FunctionTypeId] IN (" + strTypeIds + @") ORDER BY [PT_FUNCTION].[Id] ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
                new SqlParameter("@FatherNumber"   , SqlDbType.NVarChar , 50 ){ Value = strFunctionId},
            };
            parameter.Parameters = parameters;
            //查询数据
            return BLL.CommonToolsBLL.GetAllListByParams(parameter);
        }

        /// <summary>
        /// 公共方法：获取某一功能节点所有下级子功能的列表（递归），返回功能树格式的JSON，筛选用户权限，用于角色功能授权
        /// </summary>
        public static string GetAllSubFunctonByUserName(string strUserName, string strFunctionId, string strTypeIds)
        {
            DataTable dtSubFunction = GetSubFunctionByUserName(strUserName, strFunctionId, strTypeIds);
            string strResult = @"[";
            for (int i = 0; i < dtSubFunction.Rows.Count; i++)
            {
                if (i > 0)
                {
                    strResult += @",";
                }
                strResult += @"{";
                strResult += @"""item"":" + CommonToolsBLL.DataRowToJson(dtSubFunction.Rows[i]) + @",";
                strResult += @"""children"":" + GetAllSubFunctonByUserName(strUserName, dtSubFunction.Rows[i]["Id"].ToString(), strTypeIds);
                strResult += @"}";
            }
            strResult += @"]";

            return strResult;
        }

        /// <summary>
        /// 公共方法：获取某一功能节点下一级子功能的列表，包含已禁用的功能，不筛选用户权限
        /// </summary>
        public static DataTable GetSubFunction(string strFunctionId, string strTypeIds)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT DISTINCT [PT_FUNCTION].[Id],[PT_FUNCTION].[FatherNumber],[PT_FUNCTION].[FunctionName],[PT_FUNCTION].[FunctionTypeId],[PT_FUNCTION].[FunctionPath],[PT_FUNCTION].[Description], CONVERT( BIT, [PT_FUNCTION].[StateId]) AS [StateId] ,[PT_FUNCTION].[Alternate1],[PT_FUNCTION].[Alternate2],[PT_FUNCTION].[Alternate3],"
                           + "[PT_FUNCTION].[Alternate4],[PT_FUNCTION].[Alternate5] "
                           + "FROM [PT_FUNCTION] "
                           + "WHERE  [PT_FUNCTION].[FatherNumber]=@FatherNumber AND [PT_FUNCTION].[FunctionTypeId] IN (" + strTypeIds + @") ORDER BY [PT_FUNCTION].[Id] ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@FatherNumber"   , SqlDbType.NVarChar , 50 ){ Value = strFunctionId},
            };
            parameter.Parameters = parameters;
            //查询数据
            return BLL.CommonToolsBLL.GetAllListByParams(parameter);
        }


        /// <summary>
        /// 公共方法：获取某一功能节点所有下级子功能的列表（递归），返回功能树格式的JSON，筛选用户权限，用于系统维护-功能管理
        /// </summary>
        public static string GetAllSubFuncton(string strFunctionId, string strTypeIds)
        {
            DataTable dtSubFunction = GetSubFunction(strFunctionId, strTypeIds);
            string strResult = @"[";
            for (int i = 0; i < dtSubFunction.Rows.Count; i++)
            {
                if (i > 0)
                {
                    strResult += @",";
                }
                strResult += @"{";
                strResult += @"""item"":" + CommonToolsBLL.DataRowToJson(dtSubFunction.Rows[i]) + @",";
                strResult += @"""children"":" + GetAllSubFuncton(dtSubFunction.Rows[i]["Id"].ToString(), strTypeIds);
                strResult += @"}";
            }
            strResult += @"]";

            return strResult;
        }

         /// <summary>
        /// 公共方法：结合角色，获取某一功能节点下一级子功能的列表，包含已禁用的功能，不筛选用户权限 如果该角色没有此功能权限则把角色ID置为0
        /// </summary>
        public static DataTable GetSubFunctionByRole(string strFunctionId, string strTypeIds, string roleId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT CONVERT( BIT,( CASE WHEN [RoleId] IS NULL THEN  0 ELSE 1 END ))AS [RoleId],Id, [FatherNumber],[FunctionName],[FunctionTypeId],[FunctionPath],[Description],CONVERT( BIT,[StateId]) AS [StateId],[Alternate1]  "
                           + " FROM ( SELECT [RoleId] ,[FunctionId] FROM [PT_RoleLink] WHERE [RoleId] = '" + roleId + "') AS [pTRoleLink] RIGHT  JOIN [PT_FUNCTION] ON [pTRoleLink].[FunctionId] = [PT_FUNCTION].[Id] "
                           + "WHERE  [PT_FUNCTION].[FatherNumber]=@FatherNumber AND [PT_FUNCTION].[FunctionTypeId] IN (" + strTypeIds + @") ORDER BY [PT_FUNCTION].[Id] ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@FatherNumber"   , SqlDbType.NVarChar , 50 ){ Value = strFunctionId},
            };
            parameter.Parameters = parameters;
            //查询数据
            return BLL.CommonToolsBLL.GetAllListByParams(parameter);
        }


        /// <summary>
        /// 公共方法：获取某一功能节点所有下级子功能的列表（递归），返回功能树格式的JSON，筛选用户权限，用于系统维护-功能管理
        /// </summary>
        public static string GetAllSubFunctonByRole(string strFunctionId, string strTypeIds, string roleId)
        {
            DataTable dtSubFunction = GetSubFunctionByRole(strFunctionId, strTypeIds, roleId);
            string strResult = @"[";
            for (int i = 0; i < dtSubFunction.Rows.Count; i++)
            {
                if (i > 0)
                {
                    strResult += @",";
                }
                strResult += @"{";
                strResult += @"""item"":" + CommonToolsBLL.DataRowToJson(dtSubFunction.Rows[i]) + @",";
                strResult += @"""children"":" + GetAllSubFunctonByRole(dtSubFunction.Rows[i]["Id"].ToString(), strTypeIds, roleId);
                strResult += @"}";
            }
            strResult += @"]";

            return strResult;
        }
    }
}
