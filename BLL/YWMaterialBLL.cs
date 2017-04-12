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
    /// 对象名称：原料业务逻辑类（业务逻辑层）
    /// 对象说明：原料管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWMaterialBLL
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
        internal static DAL.Common.YWMaterialDAL DataAccess
        {
            get
            {
                return DAL.Common.YWMaterialDAL.Instance;
            }
        }


        /// <summary>
        /// 对原料（YWMaterial）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWMaterial">原料（YWMaterial）实例对象</param>
        public static void CheckValid(YWMaterial yWMaterial)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWMaterial.Name))
                throw new CustomException("“名称”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWMaterial.ShortName))
                throw new CustomException("“简称”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWMaterial.MaterialType))
                throw new CustomException("“原料类别”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWMaterial.StdUnit))
                throw new CustomException("“标准单位”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWMaterial.BelongType))
                throw new CustomException("“原料归属”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWMaterial.MinStorage))
                throw new CustomException("“最小存储量”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWMaterial.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWMaterial.InventoryCycle))
                throw new CustomException("“存储周期”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWMaterial.Name , 50))
                throw new CustomException("“名称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWMaterial.ShortName , 50))
                throw new CustomException("“简称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWMaterial.StdUnit , 50))
                throw new CustomException("“标准单位”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWMaterial.StorageRules , 50))
                throw new CustomException("“存放要求”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将原料（YWMaterial）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWMaterial">原料（YWMaterial）实例对象</param>
        public static int Insert(YWMaterial yWMaterial)
        {
            CheckValid(yWMaterial);
            return DataAccess.Insert(yWMaterial);
        }


        /// <summary>
        /// 将原料（YWMaterial）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWMaterial">原料（YWMaterial）实例对象</param>
        public static int Update(YWMaterial yWMaterial)
        {
            CheckValid(yWMaterial);
            return DataAccess.Update(yWMaterial);
        }


        /// <summary>
        /// 根据原料（YWMaterial）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">原料（YWMaterial）的主键“编号（Id）”</param>
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
        /// 根据原料（YWMaterial）的主键“编号（Id）”从数据库中获取原料（YWMaterial）的实例。
        /// 成功从数据库中取得记录返回新原料（YWMaterial）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">原料（YWMaterial）的主键“编号（Id）”</param>
        public static YWMaterial GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据原料（YWMaterial）的主键“编号（Id）”从数据库中获取原料（YWMaterial）的实例。
        /// 成功从数据库中取得记录返回新原料（YWMaterial）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">原料（YWMaterial）的主键“编号（Id）”</param>
        public static YWMaterial GetDataById(string id)
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

        //add by chr
        //获取系统所有物料信息
        public static PageData GetSystemMaterialList(int pageSize, int curPage, string sOrgId, string sName, string sMaterialTypeId, string sBelongTypeId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWMaterial].[Id],[YWMaterial].[Name],[YWMaterial].[ShortName],[YWMaterial].[MaterialTypeId],[YWDictionary1].[Name] AS [MaterialTypeName],"
                                + "[YWMaterial].[StdUnit],[YWMaterial].[BelongTypeId],[YWDictionary2].[Name] AS [BelongTypeName],[YWMaterial].[StorageRules],[YWMaterial].[OtherUnits],"
                                + "[YWMaterial].[MinStorage],[YWMaterial].[OrgId],[PT_ORG].[OrgName],[YWMaterial].[InventoryCycle] "
                                + "FROM [YWMaterial] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWMaterial].[MaterialTypeId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWMaterial].[BelongTypeId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWMaterial].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE 1=1 ";
            if (sOrgId.Trim() != "")
                parameter.SqlString += " AND [YWMaterial].[OrgId] = '" + sOrgId + "' ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [YWMaterial].[Name] LIKE '%" + sName + "%' ";
            if (sMaterialTypeId.Trim() != "")
                parameter.SqlString += " AND [YWMaterial].[MaterialTypeId] =" + sMaterialTypeId + " ";
            if (sBelongTypeId.Trim() != "")
                parameter.SqlString += " AND [YWMaterial].[BelongTypeId] = '" + sBelongTypeId + "'  ";
            parameter.SqlString += "ORDER BY [YWMaterial].[ShortName]";
            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }

        //add by chr
        //根据餐厅组织机构Id获取餐厅的所有物料信息
        public static PageData GetRestaurantMaterialListByOrgId(int pageSize, int curPage, int iOrgId, string sName, string sMaterialTypeId, string sBelongTypeId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWMaterial].[Id],[YWMaterial].[Name],[YWMaterial].[ShortName],[YWMaterial].[MaterialTypeId],[YWDictionary1].[Name] AS [MaterialTypeName],"
                                + "[YWMaterial].[StdUnit],[YWMaterial].[BelongTypeId],[YWDictionary2].[Name] AS [BelongTypeName],[YWMaterial].[StorageRules],[YWMaterial].[OtherUnits],"
                                + "[YWMaterial].[MinStorage],[YWMaterial].[OrgId],[PT_ORG].[OrgName],[YWMaterial].[InventoryCycle] "
                                + "FROM [YWMaterial] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWMaterial].[MaterialTypeId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWMaterial].[BelongTypeId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWMaterial].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWMaterial].[OrgId]=@OrgId ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [YWMaterial].[Name] LIKE '%" + sName + "%' ";
            if (sMaterialTypeId.Trim() != "")
                parameter.SqlString += " AND [YWMaterial].[MaterialTypeId] =" + sMaterialTypeId + " ";
            if (sBelongTypeId.Trim() != "")
                parameter.SqlString += " AND [YWMaterial].[BelongTypeId] = '" + sBelongTypeId + "'  ";
            parameter.SqlString += "ORDER BY [YWMaterial].[ShortName]";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId", SqlDbType.Int , 4 ){ Value = iOrgId}
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }

        //add by chr
        //根据餐厅组织机构Id获取餐厅的所有物料信息 不进行分页
        public static DataTable GetAllMaterialByOrgId(int iOrgId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWMaterial].[Id],[YWMaterial].[Name],[YWMaterial].[ShortName],[YWMaterial].[MaterialTypeId],[YWDictionary1].[Name] AS [MaterialTypeName],"
                                + "[YWMaterial].[StdUnit],[YWMaterial].[BelongTypeId],[YWDictionary2].[Name] AS [BelongTypeName],[YWMaterial].[StorageRules],[YWMaterial].[OtherUnits],"
                                + "[YWMaterial].[MinStorage],[YWMaterial].[OrgId],[PT_ORG].[OrgName],[YWMaterial].[InventoryCycle] "
                                + "FROM [YWMaterial] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWMaterial].[MaterialTypeId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWMaterial].[BelongTypeId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWMaterial].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWMaterial].[OrgId]=@OrgId "
                                + "ORDER BY [YWMaterial].[ShortName]";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId", SqlDbType.Int , 4 ){ Value = iOrgId}
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by chr
        //根据Id获取物料基本信息
        public static DataTable GetMaterialDataById(int iId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWMaterial].[Id],[YWMaterial].[Name],[YWMaterial].[ShortName],[YWMaterial].[MaterialTypeId],[YWDictionary1].[Name] AS [MaterialTypeName],"
                                + "[YWMaterial].[StdUnit],[YWMaterial].[BelongTypeId],[YWDictionary2].[Name] AS [BelongTypeName],[YWMaterial].[StorageRules],[YWMaterial].[OtherUnits],"
                                + "[YWMaterial].[MinStorage],[YWMaterial].[OrgId],[PT_ORG].[OrgName],[YWMaterial].[InventoryCycle] "
                                + "FROM [YWMaterial] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWMaterial].[MaterialTypeId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWMaterial].[BelongTypeId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWMaterial].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWMaterial].[Id]=@Id "
                                + "ORDER BY [YWMaterial].[ShortName]";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id", SqlDbType.Int , 4 ){ Value = iId}
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by chr
        //根据用户名获取待盘存物料列表
        public static PageData GetWaitInventoryMaterialListByUserName(int pageSize, int curPage, string strUserName)
        {
            //获取用户所属饭店下级机构的组织机构编码
            int iOrgId = PTUsersBLL.GetUserOrgId(strUserName);
            //获取用户所属饭店的组织机构编码
            int iResOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);

            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "SELECT [YWMaterial].[Id],[YWMaterial].[InventoryCycle],[A].[InventoryTime],[B].[StorageTime] "
                                 + "FROM [YWMaterial] "
                                 + "LEFT JOIN (SELECT [MaterialId],MAX([InventoryTime]) AS [InventoryTime] FROM [YWInventory] WHERE [InventoryOrgId]=@OrgId GROUP BY [MaterialId]) [A] ON [YWMaterial].[Id]=[A].[MaterialId] "
                                 + "LEFT JOIN (SELECT [MaterialId],MAX([StorageTime]) AS [StorageTime] FROM [YWInStore] WHERE [BelongOrgId]=@OrgId GROUP BY [MaterialId]) [B] ON [YWMaterial].[Id]=[B].[MaterialId] "
                                 + "WHERE [YWMaterial].[OrgId]=@ResOrgId AND [YWMaterial].[BelongTypeId]=@BelongTypeId AND [YWMaterial].[InventoryCycle] IS NOT NULL AND [YWMaterial].[InventoryCycle]<>0 "
                                 + "AND [YWMaterial].[Id] IN (SELECT [MaterialId] FROM [YWInStore] WHERE [OrgId]=@ResOrgId) ";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@OrgId"          , SqlDbType.Int , 4 ){ Value = iOrgId                                    },
                new SqlParameter("@ResOrgId"       , SqlDbType.Int , 4 ){ Value = iResOrgId                                 },
                new SqlParameter("@BelongTypeId"   , SqlDbType.Int , 4 ){ Value = CodeDictionary.MaterialBelongType["仓库"] }
            };
            parameter1.Parameters = parameters1;

            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter1);
            DateTime dtNow = DateTime.Now;
            string strMaterialId = "";

            foreach (DataRow dr in dt.Rows)
            {
                int iInventoryCycle = Convert.ToInt32(dr["InventoryCycle"]);
                DateTime dtLastDateTime;
                if (dr["InventoryTime"] != null && dr["InventoryTime"] != "")
                {
                    dtLastDateTime = Convert.ToDateTime(dr["InventoryTime"]);
                }
                else if (dr["StorageTime"] != null && dr["StorageTime"] != "")
                {
                    dtLastDateTime = Convert.ToDateTime(dr["StorageTime"]);
                }
                else
                {
                    break;
                }

                if (dtLastDateTime.AddDays(iInventoryCycle - 1) > dtNow)
                {
                    strMaterialId += dr["Id"].ToString() + ",";
                }
            }

            if (strMaterialId != "")
            {
                strMaterialId = strMaterialId.Substring(0, strMaterialId.Length - 1);
            }

            //构建查询条件
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = "SELECT [YWMaterial].[Id],[YWMaterial].[Name],[YWMaterial].[ShortName],[YWMaterial].[MaterialTypeId],[YWDictionary1].[Name] AS [MaterialTypeName],"
                                 + "[YWMaterial].[StdUnit],[YWMaterial].[BelongTypeId],[YWDictionary2].[Name] AS [BelongTypeName],[YWMaterial].[StorageRules],[YWMaterial].[OtherUnits],"
                                 + "[YWMaterial].[MinStorage],[YWMaterial].[OrgId],[PT_ORG].[OrgName],[YWMaterial].[InventoryCycle] "
                                 + "FROM [YWMaterial] "
                                 + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWMaterial].[MaterialTypeId]=[YWDictionary1].[Id] "
                                 + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWMaterial].[BelongTypeId]=[YWDictionary2].[Id] "
                                 + "LEFT JOIN [PT_ORG] ON [YWMaterial].[OrgId]=[PT_ORG].[Id] "
                                 + "WHERE [YWMaterial].[Id] IN (" + strMaterialId + ") ";
            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter2);
        }

        //add by chr
        //根据用户名获取本仓库内所有剩余物料
        public static DataTable GetRemainderMaterialListByUserName(string strUserName)
        {
            //获取用户所属饭店下级机构的组织机构编码
            int iOrgId = PTUsersBLL.GetUserOrgId(strUserName);
            //获取用户所属饭店的组织机构编码
            int iResOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);

            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWMaterial].[Id],[YWMaterial].[Name],[YWMaterial].[ShortName],[YWMaterial].[MaterialTypeId],[YWDictionary1].[Name] AS [MaterialTypeName], "
                                 + "[YWMaterial].[StdUnit],[YWMaterial].[BelongTypeId],[YWDictionary2].[Name] AS [BelongTypeName],[YWMaterial].[StorageRules],[YWMaterial].[OtherUnits],"
                                 + "[YWMaterial].[MinStorage],[YWMaterial].[OrgId],[PT_ORG].[OrgName],[YWMaterial].[InventoryCycle],[A].[InventoryTime],0 AS [InventoryCnt] "
                                 + "FROM [YWMaterial] "
                                 + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWMaterial].[MaterialTypeId]=[YWDictionary1].[Id] "
                                 + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWMaterial].[BelongTypeId]=[YWDictionary2].[Id] "
                                 + "LEFT JOIN [PT_ORG] ON [YWMaterial].[OrgId]=[PT_ORG].[Id] "
                                 + "LEFT JOIN (SELECT [MaterialId],MAX([InventoryTime]) AS [InventoryTime] FROM [YWInventory] WHERE [InventoryOrgId]=@OrgId GROUP BY [MaterialId]) [A] ON [YWMaterial].[Id]=[A].[MaterialId] "
                                 + "WHERE [YWMaterial].[OrgId]=@ResOrgId AND [YWMaterial].[BelongTypeId]=@BelongTypeId AND [YWMaterial].[InventoryCycle] IS NOT NULL AND [YWMaterial].[InventoryCycle]<>0 ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"          , SqlDbType.Int , 4 ){ Value = iOrgId                                    },
                new SqlParameter("@ResOrgId"       , SqlDbType.Int , 4 ){ Value = iResOrgId                                 },
                new SqlParameter("@BelongTypeId"   , SqlDbType.Int , 4 ){ Value = CodeDictionary.MaterialBelongType["仓库"] }
            };
            parameter.Parameters = parameters;
            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter);
            dt.Columns["InventoryCnt"].ReadOnly = false;

            Parameter parameter1 = new Parameter();
            Parameter parameter2 = new Parameter();   
            SqlParameter[] parametersPublic;
            int iInCnt, iOutCnt;
            DataTable dtResult = dt.Copy();
            dtResult.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                iInCnt = 0;
                iOutCnt = 0;
                if (dr["InventoryTime"].ToString() != "")
                {
                    parametersPublic = new SqlParameter[] 
                    { 
                        new SqlParameter("@MaterialId"      , SqlDbType.Int      , 4  ){ Value = Convert.ToInt32(dr["Id"])        },
                        new SqlParameter("@InventoryTime"   , SqlDbType.NVarChar , 50 ){ Value = dr["InventoryTime"].ToString()   }
                    };
                    parameter1.Parameters = parametersPublic;
                    parameter1.SqlString = "SELECT ISNULL(SUM([StorageQuantity]),0) AS [StorageQuantity] FROM [YWInStore] WHERE [MaterialId]=@MaterialId AND [StorageTime]>@InventoryTime ";
                    iInCnt = Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter1));
                    parameter2.Parameters = parametersPublic;
                    parameter2.SqlString = "SELECT ISNULL(SUM([OutQuantity]),0) AS [OutQuantity] FROM [YWOutStore] WHERE [MaterialId]=@MaterialId AND [OutTime]>@InventoryTime ";
                    iOutCnt = Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter2));
                }
                else
                {
                    parametersPublic = new SqlParameter[] 
                    { 
                        new SqlParameter("@MaterialId"      , SqlDbType.Int      , 4  ){ Value = Convert.ToInt32(dr["Id"])        }
                    };
                    parameter1.Parameters = parametersPublic;
                    parameter1.SqlString = "SELECT ISNULL(SUM([StorageQuantity]),0) AS [StorageQuantity] FROM [YWInStore] WHERE [MaterialId]=@MaterialId ";
                    iInCnt = Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter1));
                    parameter2.Parameters = parametersPublic;
                    parameter2.SqlString = "SELECT ISNULL(SUM([OutQuantity]),0) AS [OutQuantity] FROM [YWOutStore] WHERE [MaterialId]=@MaterialId ";
                    iOutCnt = Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter2));
                }
                //
                dr["InventoryCnt"] = Convert.ToInt32(dr["InventoryCnt"]) + iInCnt - iOutCnt;
                if (Convert.ToInt32(dr["InventoryCnt"]) > 0)
                {
                    dtResult.ImportRow(dr);
                }

            }

            return dtResult;
        }

        //add by chr
        public static int GetOrgIdByMaterialId(int iMaterialId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT [OrgId] FROM [YWMaterial] WHERE [Id]=@MaterialId ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@MaterialId"   , SqlDbType.Int , 50 ){ Value = iMaterialId},
            };
            parameter.Parameters = parameters;

            return Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }

        //add by chr
        public static string GetStdUnitByMaterialId(int iMaterialId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT [StdUnit] FROM [YWMaterial] WHERE [Id]=@MaterialId ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@MaterialId"   , SqlDbType.Int , 50 ){ Value = iMaterialId},
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter).ToString();
        }

        ////根据餐厅机构编号获取所有原料列表
        //public static List<YWMaterial> GetListByOrgId(int iOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据餐厅机构编号获取所有原料列表分页
        //public static PageData GetPageDataByOrgId(int pageSize, int curPage, int iOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetPageListByParams(pageSize, curPage, parameter);
        //}

        ////根据餐厅机构编号和原料归属编号获取原料列表
        //public static List<YWMaterial> GetListByOrgIdBelongOrgId(int iOrgId, int iBelongOrg)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId AND [BelongOrgId]=@BelongOrgId ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //        new SqlParameter("@BelongOrgId"   , SqlDbType.Int , 50 ){ Value = iBelongOrg},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        
    }
}
