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
    /// 对象名称：采购记录业务逻辑类（业务逻辑层）
    /// 对象说明：采购记录管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWBuyingBLL
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
        internal static DAL.Common.YWBuyingDAL DataAccess
        {
            get
            {
                return DAL.Common.YWBuyingDAL.Instance;
            }
        }


        /// <summary>
        /// 对采购记录（YWBuying）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWBuying">采购记录（YWBuying）实例对象</param>
        public static void CheckValid(YWBuying yWBuying)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWBuying.Material))
                throw new CustomException("“关联需求”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBuying.BuyUser))
                throw new CustomException("“购买人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBuying.BuyTime))
                throw new CustomException("“购买时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBuying.BuyPrice))
                throw new CustomException("“购买总价”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBuying.BuyState))
                throw new CustomException("“购买记录状态”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBuying.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWBuying.BuyQuantityUnit , 50))
                throw new CustomException("“购买数量单位”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWBuying.BuyWeightUnit , 50))
                throw new CustomException("“购买重量单位”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWBuying.BuyUser , 50))
                throw new CustomException("“购买人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWBuying.BuyTime , 50))
                throw new CustomException("“购买时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWBuying.RequirementList , 50))
                throw new CustomException("“对应需求”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWBuying.BalanceUser, 50))
                throw new CustomException("“结算人”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将采购记录（YWBuying）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWBuying">采购记录（YWBuying）实例对象</param>
        public static int Insert(YWBuying yWBuying)
        {
            CheckValid(yWBuying);
            return DataAccess.Insert(yWBuying);
        }


        /// <summary>
        /// 将采购记录（YWBuying）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWBuying">采购记录（YWBuying）实例对象</param>
        public static int Update(YWBuying yWBuying)
        {
            CheckValid(yWBuying);
            return DataAccess.Update(yWBuying);
        }


        /// <summary>
        /// 根据采购记录（YWBuying）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">采购记录（YWBuying）的主键“编号（Id）”</param>
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
        /// 根据采购记录（YWBuying）的主键“编号（Id）”从数据库中获取采购记录（YWBuying）的实例。
        /// 成功从数据库中取得记录返回新采购记录（YWBuying）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">采购记录（YWBuying）的主键“编号（Id）”</param>
        public static YWBuying GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据采购记录（YWBuying）的主键“编号（Id）”从数据库中获取采购记录（YWBuying）的实例。
        /// 成功从数据库中取得记录返回新采购记录（YWBuying）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">采购记录（YWBuying）的主键“编号（Id）”</param>
        public static YWBuying GetDataById(string id)
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
        //根据购买记录Id获取拼接的需求Id字符串
        public static string GetRequirementIdStringByBuyingId(string strBuyingId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT DISTINCT STUFF((SELECT ',' + [RequirementList] from [YWBuying] WHERE [Id] IN (" + strBuyingId + ") AND [Id] = [YWBuying].[Id] for xml path('')) , 1 , 1 , '') FROM [YWBuying]";
            return CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter).ToString();
        }

        //add by chr
        //获取系统所有购买记录列表
        public static PageData GetSystemBuyingList(int iPageSize, int iCurPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWBuying].[Id],[YWMaterial].[Name] AS [Material],[YWMaterial].[ShortName],[YWBuying].[BuyQuantity],[YWBuying].[BuyQuantityUnit],[YWBuying].[BuyWeight],"
                                + "[YWBuying].[BuyWeightUnit],[PT_USER1].[Nickname] AS [BuyUser],[YWBuying].[BuyTime],[YWBuying].[BuyPrice],[YWDictionary].[Name] AS [BuyState], "
                                + "[PT_ORG].[OrgName],[YWBuying].[RequirementList],[PT_USER2].[Nickname] AS [BalanceUser] "
                                + "FROM [YWBuying] "
                                + "LEFT JOIN [YWMaterial] ON [YWBuying].[MaterialId]=[YWMaterial].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWBuying].[BuyUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [YWDictionary] ON [YWBuying].[BuyStateId]=[YWDictionary].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWBuying].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWBuying].[BalanceUserName]=[PT_USER2].[UserName]";
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据物料ID获取所有待入库的购买记录
        public static PageData GetBuyingListByMaterialId(string strUserName, int iMaterialId, int iPageSize, int iCurPage)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWBuying].[Id],[YWMaterial].[Name] AS [Material],[YWMaterial].[ShortName],[YWBuying].[BuyQuantity],[YWBuying].[BuyQuantityUnit],[YWBuying].[BuyWeight],"
                                + "[YWBuying].[BuyWeightUnit],[PT_USER1].[Nickname] AS [BuyUser],[YWBuying].[BuyTime],[YWBuying].[BuyPrice],[YWDictionary].[Name] AS [BuyState], "
                                + "[PT_ORG].[OrgName],[YWBuying].[RequirementList],[PT_USER2].[Nickname] AS [BalanceUser] "
                                + "FROM [YWBuying] "
                                + "LEFT JOIN [YWMaterial] ON [YWBuying].[MaterialId]=[YWMaterial].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWBuying].[BuyUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [YWDictionary] ON [YWBuying].[BuyStateId]=[YWDictionary].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWBuying].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWBuying].[BalanceUserName]=[PT_USER2].[UserName] "
                                + "WHERE [YWBuying].[OrgId]=@OrgId AND [YWBuying].[MaterialId]=@MaterialId AND [YWBuying].[BuyStateId]=@BuyStateId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"         , SqlDbType.Int      , 4      ){ Value = iOrgId                                  },
                new SqlParameter("@MaterialId"    , SqlDbType.Int      , 4      ){ Value = iMaterialId                             },
                new SqlParameter("@BuyStateId"    , SqlDbType.Int      , 4      ){ Value = CodeDictionary.BuyingState["已购买"]    }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据购买人获取所有待入库的购买记录
        public static PageData GetBuyingListByUserNameAndState(string strUserName, int iBuyStateId, int iPageSize, int iCurPage)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWBuying].[Id],[YWMaterial].[Name] AS [Material],[YWMaterial].[ShortName],[YWBuying].[BuyQuantity],[YWBuying].[BuyQuantityUnit],[YWBuying].[BuyWeight],"
                                + "[YWBuying].[BuyWeightUnit],[PT_USER1].[Nickname] AS [BuyUser],[YWBuying].[BuyTime],[YWBuying].[BuyPrice],[YWDictionary].[Name] AS [BuyState], "
                                + "[PT_ORG].[OrgName],[YWBuying].[RequirementList],[PT_USER2].[Nickname] AS [BalanceUser] "
                                + "FROM [YWBuying] "
                                + "LEFT JOIN [YWMaterial] ON [YWBuying].[MaterialId]=[YWMaterial].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWBuying].[BuyUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [YWDictionary] ON [YWBuying].[BuyStateId]=[YWDictionary].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWBuying].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWBuying].[BalanceUserName]=[PT_USER2].[UserName] "
                                + "WHERE [YWBuying].[OrgId]=@OrgId AND [YWBuying].[BuyUserName]=@BuyUserName AND [YWBuying].[BuyStateId]=@BuyStateId ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"         , SqlDbType.Int     , 4      ){ Value = iOrgId         },
                new SqlParameter("@BuyUserName"   , SqlDbType.NChar   , 50     ){ Value = strUserName    },
                new SqlParameter("@BuyStateId"    , SqlDbType.Int     , 4      ){ Value = iBuyStateId    }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据Id获取购买记录明细
        //public static DataTable GetBuyingRecordById(int iBuyingId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = "SELECT [YWBuying].[Id],[YWMaterial].[Name] AS [Material],[YWBuying].[BuyQuantity],[YWBuying].[BuyQuantityUnit],[YWBuying].[BuyWeight],"
        //                        + "[YWBuying].[BuyWeightUnit],[PT_USER].[Nickname] AS [BuyUser],[YWBuying].[BuyTime],[YWBuying].[BuyPrice],[YWDictionary].[Name] AS [BuyState], "
        //                        + "[PT_ORG].[OrgName],[YWBuying].[Backup1],[YWBuying].[Backup2] "
        //                        + "FROM [YWBuying] "
        //                        + "LEFT JOIN [YWMaterial] ON [YWBuying].[MaterialId]=[YWMaterial].[Id] "
        //                        + "LEFT JOIN [PT_USER] ON [YWBuying].[BuyUserName]=[PT_USER].[UserName] "
        //                        + "LEFT JOIN [YWDictionary] ON [YWBuying].[BuyStateId]=[YWDictionary].[Id] "
        //                        + "LEFT JOIN [PT_ORG] ON [YWBuying].[OrgId]=[PT_ORG].[Id] "
        //                        + "WHERE [YWBuying].[Id]=@Id ";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@Id", SqlDbType.Int, 4){ Value = iBuyingId }
        //    };
        //    parameter.Parameters = parameters;
        //    return CommonToolsBLL.GetAllListByParams(parameter);
        //}

        //add by chr
        //根据用户名获取待入库的物料
        public static PageData GetBuyingMaterialList(string strUserName, int iPageSize, int iCurPage)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWMaterial].[Id],[YWMaterial].[Name],[YWMaterial].[ShortName],[YWMaterial].[MaterialTypeId],[YWDictionary].[Name] AS [MaterialTypeName],[YWBuying].[BuyQuantityUnit],"
                                + "COUNT(*) AS [Cnt],SUM([YWBuying].[BuyQuantity]) AS [BuyQuantity],SUM([YWBuying].[BuyPrice]) AS [BuyPrice] "
                                + "FROM [YWBuying] "
                                + "LEFT JOIN [YWMaterial] ON [YWBuying].[MaterialId]=[YWMaterial].[Id] "
                                + "LEFT JOIN [YWDictionary] ON [YWMaterial].[MaterialTypeId]=[YWDictionary].[Id] "
                                + "WHERE [YWBuying].[OrgId]=@OrgId AND [YWBuying].[BuyStateId]=@BuyStateId "
                                + "GROUP BY [YWMaterial].[Id],[YWMaterial].[Name],[YWMaterial].[ShortName],[YWMaterial].[MaterialTypeId],[YWDictionary].[Name],[YWBuying].[BuyQuantityUnit] ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"         , SqlDbType.Int   , 4      ){ Value = iOrgId                                  },
                new SqlParameter("@BuyStateId"    , SqlDbType.Int   , 4      ){ Value = CodeDictionary.BuyingState["已购买"]    }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据用户名获取所有待入库任务的采购员列表
        public static PageData GetBuyUserList(string strUserName, int iPageSize, int iCurPage)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [PT_User].[OrgId],[PT_ORG].[OrgName],[A].[BuyUserName],[PT_User].[NickName],[Cnt],[BuyPrice] "
                                + "FROM "
                                + "("
                                + "SELECT [BuyUserName],COUNT(*) AS [Cnt],SUM([BuyPrice]) AS [BuyPrice] "
                                + "FROM [YWBuying] "
                                + "WHERE [OrgId]=@OrgId AND [BuyStateId]=@BuyStateId "
                                + "GROUP BY [BuyUserName]"
                                + ") [A] "
                                + "LEFT JOIN [PT_User] ON [PT_User].[UserName]=[A].[BuyUserName] "
                                + "LEFT JOIN [PT_ORG] ON [PT_ORG].[Id]=[PT_User].[OrgId] ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"         , SqlDbType.Int   , 4      ){ Value = iOrgId                                  },
                new SqlParameter("@BuyStateId"    , SqlDbType.Int   , 4      ){ Value = CodeDictionary.BuyingState["已购买"]    }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据待结算的购买记录完成结算（单条）
        public static int UpdateBuyStateIdBySingleId(int iBuyingId, string strUserName, double douBuyPrice)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWBuying] SET [BuyStateId]=@BuyStateId,[BuyPrice]=@BuyPrice,[BalanceUserName]=@BalanceUserName WHERE [Id]=@BuyingId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@BuyStateId"      , SqlDbType.Int      , 4         ){ Value = CodeDictionary.BuyingState["已结算"]   },
                new SqlParameter("@BuyPrice"        , SqlDbType.Decimal  , 9         ){ Value = douBuyPrice                            },
                new SqlParameter("@BalanceUserName" , SqlDbType.NChar    , 50        ){ Value = strUserName                            },
                new SqlParameter("@BuyingId"        , SqlDbType.Int      , 4         ){ Value = iBuyingId                              }  
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.ExcuteSql(parameter);
        }

        //add by chr
        //根据待结算的购买记录完成结算（多条）
        public static void UpdateBuyStateIdByMultiId(string strBuyingId, string strUserName)
        {
            //检查点记录数
            int iCheckPoint = strBuyingId.Split(',').Length;
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWBuying] SET [BuyStateId]=@BuyStateId,[BalanceUserName]=@BalanceUserName WHERE [Id] IN (" + strBuyingId + ")";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@BuyStateId"      , SqlDbType.Int      , 4         ){ Value = CodeDictionary.BuyingState["已结算"]   },
                new SqlParameter("@BalanceUserName" , SqlDbType.NChar    , 50        ){ Value = strUserName                            }
            };
            parameter.Parameters = parameters;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        ////根据餐厅编号、物料编号和状态ID获取对应的所有采购记录
        //public static List<YWBuying> GetAllListByRestaurantOrgIdMaterialId(int iRestaurantOrgId, int iMaterialId, string strBuyStateIds)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [MaterialId]=@MaterialId AND [BuyStateId] IN (" + strBuyStateIds + ") AND [OrgId]=@OrgId ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@MaterialId"   , SqlDbType.Int , 50 ){ Value = iMaterialId},
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iRestaurantOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据采购人员用户名和状态ID获取对应的所有采购记录
        //public static List<YWBuying> GetAllListByBuyUserBuyState(string strUserName, string strBuyStateIds)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [BuyUserName]=@BuyUserName AND [BuyStateId] IN (" + strBuyStateIds + ") ORDER BY [BuyStateId],[Id] DESC";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@BuyUserName"   , SqlDbType.VarChar , 50 ){ Value = strUserName},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据多个购买记录编号获取对应的所有采购记录
        //public static List<YWBuying> GetAllListByBuyingIds(string strBuyingIds)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [Id] IN (" + strBuyingIds + ") ORDER BY [BuyStateId],[Id] DESC";
        //    SqlParameter[] parameters = null;
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据餐厅机构编号获取所有采购记录
        //public static List<YWBuying> GetAllListByOrgId(int iOrgId)
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

        ////根据餐厅机构编号和采购记录状态编号，获取参与采购的人员单位列表（合并同类）
        //public static DataTable GetDistinctBuyerOrgListByRestaurantOrgIdStateId(int iRestaurantOrgId, string strStateIds)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = "SELECT DISTINCT [PT_ORG].[Id], [PT_ORG].[OrgName] ";
        //    parameter.SqlString += "FROM [YWBuying] INNER JOIN [PT_USER] ON [YWBuying].[BuyUserName] = [PT_USER].[UserName] INNER JOIN [PT_ORG] ON [PT_USER].[OrgId] = [PT_ORG].[Id] ";
        //    parameter.SqlString += "WHERE [YWBuying].[BuyStateId] IN (" + strStateIds + ") AND [YWBuying].[OrgId] = @OrgId ";
        //    parameter.SqlString += "";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iRestaurantOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return BLL.CommonToolsBLL.GetDataTableByParams(parameter);
        //}

        ////根据餐厅机构编号、采购记录状态编号和采购人员所在单位编号，获取参与采购的人员列表（合并同类）
        //public static DataTable GetDistinctBuyerListByRestaurantOrgIdBuyerOrgIdStateId(int iRestaurantOrgId, int iBuyerOrgId, string strStateIds)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = "SELECT DISTINCT [PT_USER].[UserName], [PT_USER].[Nickname], [PT_USER].[Alternate2] ";
        //    parameter.SqlString += "FROM [YWBuying] INNER JOIN [PT_USER] ON [YWBuying].[BuyUserName] = [PT_USER].[UserName] ";
        //    parameter.SqlString += "WHERE [YWBuying].[BuyStateId] IN (" + strStateIds + ") AND [YWBuying].[OrgId] = @RestaurantOrgId AND [PT_USER].[OrgId] = @BuyerOrgId ";
        //    parameter.SqlString += "";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@RestaurantOrgId"   , SqlDbType.Int , 50 ){ Value = iRestaurantOrgId},
        //        new SqlParameter("@BuyerOrgId"   , SqlDbType.Int , 50 ){ Value = iBuyerOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return BLL.CommonToolsBLL.GetDataTableByParams(parameter);
        //}

        ////根据餐厅机构编号和采购记录状态编号，获取采购记录涉及的物料类别列表（合并同类）
        //public static DataTable GetDistinctMaterialTypeListByRestaurantOrgIdStateId(int iRestaurantOrgId, string strStateIds)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = "SELECT DISTINCT [YWDictionary].[Id], [YWDictionary].[Name] ";
        //    parameter.SqlString += "FROM [YWBuying] INNER JOIN [YWMaterial] ON [YWBuying].[MaterialId] = [YWMaterial].[Id] INNER JOIN [YWDictionary] ON [YWMaterial].[MaterialTypeId] = [YWDictionary].[Id] ";
        //    parameter.SqlString += "WHERE [YWBuying].[BuyStateId] IN (" + strStateIds + ") AND [YWBuying].[OrgId] = @OrgId ";
        //    parameter.SqlString += "";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iRestaurantOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return BLL.CommonToolsBLL.GetDataTableByParams(parameter);
        //}

        ////根据餐厅机构编号、采购记录状态编号和采购物料所属类别编号，获取采购记录涉及的物料列表（合并同类）
        //public static DataTable GetDistinctMaterialListByRestaurantOrgIdBuyerOrgIdStateId(int iRestaurantOrgId, int iMaterialTypeId, string strStateIds)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = "SELECT DISTINCT [YWMaterial].[Id], [YWMaterial].[Name], [YWMaterial].[Backup1] ";
        //    parameter.SqlString += "FROM [YWBuying] INNER JOIN [YWMaterial] ON [YWBuying].[MaterialId] = [YWMaterial].[Id] ";
        //    parameter.SqlString += "WHERE [YWBuying].[BuyStateId] IN (" + strStateIds + ") AND [YWBuying].[OrgId] = @RestaurantOrgId AND [YWMaterial].[MaterialTypeId] = @MaterialTypeId ";
        //    parameter.SqlString += "";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@RestaurantOrgId"   , SqlDbType.Int , 50 ){ Value = iRestaurantOrgId},
        //        new SqlParameter("@MaterialTypeId"   , SqlDbType.Int , 50 ){ Value = iMaterialTypeId},
        //    };
        //    parameter.Parameters = parameters;

        //    return BLL.CommonToolsBLL.GetDataTableByParams(parameter);
        //}

    }
}
