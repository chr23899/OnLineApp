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
    /// 对象名称：基本组织机构业务逻辑类（业务逻辑层）
    /// 对象说明：管理支撑平台运行的基本组织机构信息，用于权限控制的关联，实现用户分组和数据隔离功能。
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTOrgBLL
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
        internal static DAL.Common.PTOrgDAL DataAccess
        {
            get
            {
                return DAL.Common.PTOrgDAL.Instance;
            }
        }


        /// <summary>
        /// 对基本组织机构（PTOrg）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="pTOrg">基本组织机构（PTOrg）实例对象</param>
        public static void CheckValid(PTOrg pTOrg)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(pTOrg.FatherId))
                throw new CustomException("“上级编号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTOrg.LevelId))
                throw new CustomException("“层级序号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTOrg.StateId))
                throw new CustomException("“状态”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(pTOrg.FatherId , 50))
                throw new CustomException("“上级编号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTOrg.LevelId , 50))
                throw new CustomException("“层级序号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTOrg.OrgName , 500))
                throw new CustomException("“机构名称”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTOrg.StateId , 50))
                throw new CustomException("“状态”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTOrg.Alternate1 , 50))
                throw new CustomException("“备用１”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTOrg.Alternate2 , 50))
                throw new CustomException("“备用２”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTOrg.Alternate3 , 50))
                throw new CustomException("“备用３”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTOrg.Alternate4 , 500))
                throw new CustomException("“备用４”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTOrg.Alternate5 , 500))
                throw new CustomException("“备用５”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将基本组织机构（PTOrg）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTOrg">基本组织机构（PTOrg）实例对象</param>
        public static int Insert(PTOrg pTOrg)
        {
            CheckValid(pTOrg);
            return DataAccess.Insert(pTOrg);
        }


        /// <summary>
        /// 将基本组织机构（PTOrg）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTOrg">基本组织机构（PTOrg）实例对象</param>
        public static int Update(PTOrg pTOrg)
        {
            CheckValid(pTOrg);
            return DataAccess.Update(pTOrg);
        }


        /// <summary>
        /// 根据基本组织机构（PTOrg）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">基本组织机构（PTOrg）的主键“编号（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据基本组织机构（PTOrg）的主键“编号（Id）”从数据库中获取基本组织机构（PTOrg）的实例。
        /// 成功从数据库中取得记录返回新基本组织机构（PTOrg）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基本组织机构（PTOrg）的主键“编号（Id）”</param>
        public static PTOrg GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据基本组织机构（PTOrg）的主键“编号（Id）”从数据库中获取基本组织机构（PTOrg）的实例。
        /// 成功从数据库中取得记录返回新基本组织机构（PTOrg）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基本组织机构（PTOrg）的主键“编号（Id）”</param>
        public static PTOrg GetDataById(string id)
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
        /// add by chr
        /// 公共方法: 通过机构Id获取机构的相关信息 返回DataRow
        /// </summary>
        /// <param name="strId"></param>
        /// <returns></returns>
        public static DataRow GetOrgRowById(string strId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT PT_ORG.Id,PT_ORG.FatherId,PT_ORG.OrgName,PT_ORG.LevelId,CONVERT(BIT,[PT_ORG].[StateId]) AS [StateId],PT_ORGFat.OrgName AS FatherName FROM PT_ORG "
                           + "LEFT JOIN PT_ORG AS PT_ORGFat ON PT_ORG.FatherId = PT_ORGFat.Id WHERE PT_ORG.Id = @Id ";
            SqlParameter[] parameters = 
            { 
                new SqlParameter("@Id"   , SqlDbType.NVarChar , 50 ){ Value = strId},
            };
            parameter.Parameters = parameters;
            //查询数据
            return BLL.CommonToolsBLL.GetAllListByParams(parameter).Rows[0];
        }

        /// <summary>
        /// add by chr
        /// 公共方法: 通过机构的主键Id 删除相关的机构信息(包括其子机构) 将被删除机构下的所有用户一并删除
        /// </summary>
        /// <param name="strId"></param>
        public static bool DeleteOrgById(string strId)
        {
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = " SELECT Id FROM PT_ORG WHERE Id = @Id  OR FatherId= @Id  ";
            SqlParameter[] parameters1 = 
            { 
                new SqlParameter("@Id"   , SqlDbType.Int , 4 ){ Value = strId},
            };
            parameter1.Parameters = parameters1;
            //查询数据
            DataTable dt = BLL.CommonToolsBLL.GetAllListByParams(parameter1);
            string DelStr = "";
            foreach (DataRow dr in dt.Rows)
            {
                DelStr += dr["Id"] + ",";
            }
            //被删除的机构字符串
            DelStr = DelStr.Substring(0, DelStr.Length - 1);

            //构建多个查询条件
            Parameter parameter4 = new Parameter();
            parameter4.SqlString = " SELECT * FROM PT_USER WHERE OrgId IN  (" + DelStr + ") ";
            DataTable dt_user = BLL.CommonToolsBLL.GetAllListByParams(parameter4);
            if (dt_user.Rows.Count > 0)
                return false;

            //构建多个查询条件
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = " DELETE FROM PT_USER WHERE OrgId IN  (" + DelStr + ") ";

             
            Parameter parameter3 = new Parameter();
            parameter3.SqlString = " DELETE FROM PT_ORG WHERE Id = @Id  OR FatherId= @Id  ";
            SqlParameter[] parameters3 = 
            { 
                new SqlParameter("@Id"   , SqlDbType.Int , 4 ){ Value = strId},
            };
            parameter3.Parameters = parameters3;

            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter2);
            parmList.Add(parameter3);
            CommonToolsBLL.ExcuteSqlWithTransaction(parmList);
            return true;

        }

        /// <summary>
        /// 公共方法：获取某一机构节点下一级的机构列表，不含已禁用的机构
        /// </summary>
        public static DataTable GetAllSubOrgById(string strFatherId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Id],[FatherId],[LevelId],[OrgName],[StateId],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5]"
                           + "FROM [PT_ORG] WHERE [FatherId]=@FatherId ";
            SqlParameter[] parameters = 
            { 
                new SqlParameter("@FatherId"   , SqlDbType.NVarChar , 50 ){ Value = strFatherId},
            };
            parameter.Parameters = parameters;
            //查询数据
            return BLL.CommonToolsBLL.GetAllListByParams(parameter);
        }

        /// <summary>
        /// 公共方法：获取某一机构所有下级子机构的列表（递归），返回机构格式的JSON
        /// </summary>
        public static string GetAllSubOrg(string strFatherId)
        {
            DataTable dtSubOrg = GetAllSubOrgById(strFatherId);
            string strResult = @"[";
            for (int i = 0; i < dtSubOrg.Rows.Count; i++)
            {
                if (i > 0)
                {
                    strResult += @",";
                }
                strResult += @"{";
                strResult += @"""label"":""" + dtSubOrg.Rows[i]["OrgName"].ToString() + @""",";
                strResult += @"""orgid"":""" + dtSubOrg.Rows[i]["Id"].ToString() + @"""";
                if (GetAllSubOrgById(dtSubOrg.Rows[i]["Id"].ToString()).Rows.Count > 0)
                {
                    strResult += @",""children"":" + GetAllSubOrg(dtSubOrg.Rows[i]["Id"].ToString());
                }
                strResult += @"}";
            }
            strResult += @"]";

            return strResult;
        }


        /// <summary>
        /// 公共方法：获取某一机构所有下级子机构的列表（递归），返回用逗号分隔的组织机构Id
        /// </summary>
        public static string GetAllSubOrgIdString(string strFatherId)
        {
            DataTable dtSubOrg = GetAllSubOrgById(strFatherId);
            string strResult = "";
            for (int i = 0; i < dtSubOrg.Rows.Count; i++)
            {
                if (i > 0)
                {
                    strResult += ",";
                }
                strResult += dtSubOrg.Rows[i]["Id"].ToString();
                if (GetAllSubOrgById(dtSubOrg.Rows[i]["Id"].ToString()).Rows.Count > 0)
                {
                    strResult += "," + GetAllSubOrgIdString(dtSubOrg.Rows[i]["Id"].ToString());
                }
            }

            return strResult;
        }

        //add by chr
        //获取系统中所有餐厅数据
        public static DataTable GetSystemRestaurantList()
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT * FROM PT_ORG WHERE FatherId = 2 "; 
            //查询数据
            return BLL.CommonToolsBLL.GetAllListByParams(parameter);
        }

        public static DataTable GetKitchenAndStoreList(string OrgId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT * FROM PT_ORG "
                               + " WHERE [PT_ORG].[FatherId] IN "
                               + " (SELECT [Id] FROM [PT_ORG] WHERE [OrgName] in ('厨房','仓库') AND [FatherId]= '" + OrgId + "') ";
            //查询数据
            return BLL.CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by zy
        //获取系统所有厨房信息
        public static PageData GetSystemKitchenList(int iPageSize, int iCurPage, string sOrgId, string sName)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [PT_ORG].[Id],[PT_ORG2].[FatherId] AS [OrgId],[PT_ORG].[LevelId],[PT_ORG].[OrgName], [PT_ORG3].[OrgName]  AS [FOrgName] ,CONVERT(BIT,[PT_ORG].[StateId]) AS [StateId] "
                                + "FROM [PT_ORG] "
                                + "LEFT JOIN  [PT_ORG] AS [PT_ORG2] ON [PT_ORG2].Id = [PT_ORG].[FatherId] "
                                + "LEFT JOIN  [PT_ORG] AS [PT_ORG3] ON [PT_ORG3].Id = [PT_ORG2].[FatherId] "
                                + "WHERE [PT_ORG].[FatherId] IN "
                                + "(SELECT [Id] FROM [PT_ORG] WHERE [OrgName]='厨房')";
            if (sOrgId.Trim() != "")
                parameter.SqlString += " AND [PT_ORG3].[Id] = " + sOrgId + " ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [PT_ORG].[OrgName] LIKE '%" + sName + "%' ";
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by zy
        //获取系统所有仓库信息
        public static PageData GetSystemStorehouseList(int iPageSize, int iCurPage, string sOrgId, string sName)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [PT_ORG].[Id],[PT_ORG2].[FatherId] AS [OrgId],[PT_ORG].[LevelId],[PT_ORG].[OrgName], [PT_ORG3].[OrgName]  AS [FOrgName] ,CONVERT(BIT,[PT_ORG].[StateId]) AS [StateId] "
                                + "FROM [PT_ORG] "
                                + "LEFT JOIN  [PT_ORG] AS [PT_ORG2] ON [PT_ORG2].Id = [PT_ORG].[FatherId] "
                                + "LEFT JOIN  [PT_ORG] AS [PT_ORG3] ON [PT_ORG3].Id = [PT_ORG2].[FatherId] "
                                + "WHERE [PT_ORG].[FatherId] IN "
                                + "(SELECT [Id] FROM [PT_ORG] WHERE [OrgName]='仓库')";
            if (sOrgId.Trim() != "")
                parameter.SqlString += " AND [PT_ORG3].[Id] = " + sOrgId + " ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [PT_ORG].[OrgName] LIKE '%" + sName + "%' ";
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by zy
        //根据餐厅组织机构Id获取餐厅的所有厨房信息
        public static PageData GetRestaurantKitchenListByOrgId(int iOrgId, int iPageSize, int iCurPage, string sName)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [PT_ORG].[Id],[PT_ORG].[FatherId],[PT_ORG].[LevelId],[PT_ORG].[OrgName],CONVERT(BIT,[PT_ORG].[StateId]) AS [StateId] "
                                + "FROM [PT_ORG] "
                                + "WHERE [PT_ORG].[FatherId] IN "
                                + "(SELECT [Id] FROM [PT_ORG] WHERE [FatherId]=@OrgId AND [OrgName]='厨房')";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [PT_ORG].[OrgName] LIKE '%" + sName + "%' ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrgId"     , SqlDbType.Int           , 50 ){ Value = iOrgId}
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }


        //add by zy
        //根据餐厅组织机构Id获取餐厅的所有仓库信息
        public static PageData GetRestaurantStorehouseListByOrgId(int iOrgId, int iPageSize, int iCurPage, string sName)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [PT_ORG].[Id],[PT_ORG].[FatherId],[PT_ORG].[LevelId],[PT_ORG].[OrgName],CONVERT(BIT,[PT_ORG].[StateId]) AS [StateId] "
                                + "FROM [PT_ORG] "
                                + "WHERE [PT_ORG].[FatherId] IN "
                                + "(SELECT [Id] FROM [PT_ORG] WHERE [FatherId]=@OrgId AND [OrgName]='仓库')";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [PT_ORG].[OrgName] LIKE '%" + sName + "%' ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrgId"     , SqlDbType.Int           , 50 ){ Value = iOrgId}
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        /// <summary>
        /// add by chr
        /// </summary>
        /// <param name="OrgId">当前机构</param>
        /// <param name="OrgName">要查找机构名称(1-厨房 2-仓库)</param>
        /// <returns></returns>
        public static int GetFatherIdByOrg(string OrgId, string OrgName)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT [Id] FROM [PT_ORG] WHERE [FatherId]=@OrgId AND [OrgName]=@OrgName ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"   , SqlDbType.NVarChar , 50 ){ Value = OrgId},
                new SqlParameter("@OrgName"   , SqlDbType.NVarChar , 50 ){ Value = OrgName}
            };
            parameter.Parameters = parameters;
            return Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }


        ///// <summary>
        ///// 根据查询条件，从数据库中读取并返回所有基本组织机构（PTOrg）List列表。
        ///// </summary>
        //public static List<PTOrg> GetAllListByParams(Parameter paramList)
        //{
        //    return DataAccess.GetAllListByParams(paramList);
        //}


        ///// <summary>
        ///// 根据查询条件，每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的基本组织机构（PTOrg）的列表及分页信息。
        ///// 该方法所获取的基本组织机构（PTOrg）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        ///// </summary>
        //public static PageData GetPageListByParams(int pageSize, int curPage, Parameter paramList)
        //{
        //    return DataAccess.GetPageListByParams(pageSize, curPage, paramList);
        //}


        ////根据机构编号获取下一层子机构列表
        //public static List<PTOrg> GetSubOrgListById(int iId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [FatherId]=@FatherId ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@FatherId"   , SqlDbType.Int , 50 ){ Value = iId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据机构id获取固定名称的下级机构
        //public static PTOrg GetSubOrgByName(int iId, string strOrgName)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [FatherId]=@FatherId AND [OrgName]=@OrgName ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@FatherId"   , SqlDbType.Int , 50 ){ Value = iId},
        //        new SqlParameter("@OrgName"   , SqlDbType.NVarChar , 50 ){ Value = strOrgName},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter)[0];
        //}

        ////根据机构id获取一个由自身id和所有下级id组成的条件字符串，用于IN查询（这是一个不太好理解的递归算法）
        //public static string GetAllOrgIdListByOrgId(int iOrgId)
        //{
        //    string strAllOrgIdList = "'" + iOrgId.ToString() + "'";
        //    List<PTOrg> pTOrgList = GetSubOrgListById(iOrgId);
        //    if(pTOrgList.Count != 0)
        //    {
        //        foreach (PTOrg pTOrg in pTOrgList)
        //        {
        //            strAllOrgIdList += ",";
        //            strAllOrgIdList += GetAllOrgIdListByOrgId(pTOrg.Id.Value);
        //        }
        //    }
            
        //    return strAllOrgIdList;
        //}


    }
}
