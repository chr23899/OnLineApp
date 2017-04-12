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
    /// 对象名称：入库记录业务逻辑类（业务逻辑层）
    /// 对象说明：入库记录管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWInStoreBLL
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
        internal static DAL.Common.YWInStoreDAL DataAccess
        {
            get
            {
                return DAL.Common.YWInStoreDAL.Instance;
            }
        }


        /// <summary>
        /// 对入库记录（YWInStore）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWInStore">入库记录（YWInStore）实例对象</param>
        public static void CheckValid(YWInStore yWInStore)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWInStore.Material))
                throw new CustomException("“项目”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInStore.StorageQuantity))
                throw new CustomException("“入库数量”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInStore.StorageUnit))
                throw new CustomException("“入库单位”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInStore.StorageTime))
                throw new CustomException("“入库时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInStore.ConfirmUser))
                throw new CustomException("“确认人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInStore.BuyUser))
                throw new CustomException("“购买人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInStore.BuyTime))
                throw new CustomException("“购买时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInStore.BelongOrg))
                throw new CustomException("“货物归属”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInStore.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWInStore.StorageUnit , 50))
                throw new CustomException("“入库单位”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWInStore.StorageTime , 50))
                throw new CustomException("“入库时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWInStore.ConfirmUser , 50))
                throw new CustomException("“确认人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWInStore.BuyUser , 50))
                throw new CustomException("“购买人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWInStore.BuyTime , 50))
                throw new CustomException("“购买时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWInStore.Notes, 50))
                throw new CustomException("“备注”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将入库记录（YWInStore）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWInStore">入库记录（YWInStore）实例对象</param>
        public static int Insert(YWInStore yWInStore)
        {
            CheckValid(yWInStore);
            return DataAccess.Insert(yWInStore);
        }


        /// <summary>
        /// 将入库记录（YWInStore）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWInStore">入库记录（YWInStore）实例对象</param>
        public static int Update(YWInStore yWInStore)
        {
            CheckValid(yWInStore);
            return DataAccess.Update(yWInStore);
        }


        /// <summary>
        /// 根据入库记录（YWInStore）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">入库记录（YWInStore）的主键“编号（Id）”</param>
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
        /// 根据入库记录（YWInStore）的主键“编号（Id）”从数据库中获取入库记录（YWInStore）的实例。
        /// 成功从数据库中取得记录返回新入库记录（YWInStore）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">入库记录（YWInStore）的主键“编号（Id）”</param>
        public static YWInStore GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据入库记录（YWInStore）的主键“编号（Id）”从数据库中获取入库记录（YWInStore）的实例。
        /// 成功从数据库中取得记录返回新入库记录（YWInStore）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">入库记录（YWInStore）的主键“编号（Id）”</param>
        public static YWInStore GetDataById(string id)
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

        public static PageData GetSystemInStoreList(int iPageSize, int iCurPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWBuying].[Id],[YWMaterial].[Name] AS [MaterialName],[YWBuying].[BuyQuantity],[YWBuying].[BuyQuantityUnit],"
                                + "[YWBuying].[BuyWeight],[YWBuying].[BuyWeightUnit],[PT_USER1].[Nickname] AS [BuyUserName],[YWBuying].[BuyTime],"
                                + "[YWBuying].[BuyPrice],[YWDictionary].[Name] AS [BuyStateName],[PT_ORG].[OrgName],[YWBuying].[RequirementList],"
                                + "[PT_USER2].[Nickname] AS [BalanceUserName] "
                                + "FROM [YWBuying] "
                                + "LEFT JOIN [YWMaterial] ON [YWBuying].[MaterialId]=[YWMaterial].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWBuying].[BuyUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [YWDictionary] ON [YWBuying].[BuyStateId]=[YWDictionary].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWBuying].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWBuying].[BalanceUserName]=[PT_USER2].[UserName] ";
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据待入库的购买记录完成入库
        public static void InsertInStoreDataByBuyingData(int iBuyingId, string strUserName, int iStorageQuantity, string strNotes, string strDateTimeNow)
        {
            //根据购买记录Id获取对应的需求记录Id字符串
            string strRequirementIdString = YWBuyingBLL.GetRequirementIdStringByBuyingId(iBuyingId.ToString());
            //获取用户所属的组织机构id
            int iResOrgId = PTUsersBLL.GetUserOrgId(strUserName);

            //构建查询条件(更新对应的购买记录状态为已入库)
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWBuying] SET [BuyStateId]=@ToStateId WHERE [Id]=@Id AND [BuyStateId]=@FromStateId";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@FromStateId"   , SqlDbType.Int     , 4      ){ Value = CodeDictionary.BuyingState["已购买"]  },
                new SqlParameter("@ToStateId"     , SqlDbType.Int     , 4      ){ Value = CodeDictionary.BuyingState["已入库"]  },
                new SqlParameter("@Id"            , SqlDbType.Int     , 4      ){ Value = iBuyingId                             }
            };
            parameter1.Parameters = parameters1;

            //构建查询条件(根据Buying记录中的信息，结合传入参数，插入InStore记录)
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = "INSERT INTO [YWInStore] "
                                + "([MaterialId],[StorageQuantity],[StorageUnit],[StorageTime],[ConfirmUserName],[BuyUserName],[BuyTime],[BuyingId],[BelongOrgId],[OrgId],[Notes]) "
                                + "SELECT [YWBuying].[MaterialId],@StorageQuantity AS [StorageQuantity],[YWBuying].[BuyQuantityUnit] AS [StorageUnit],"
                                + "@DateTimeNow AS [StorageTime],@ConfirmUserName AS [ConfirmUserName],[YWBuying].[BuyUserName] AS [BuyUserName],"
                                + "[YWBuying].[BuyTime],[YWBuying].[Id] AS [BuyingId],@BelongOrgId AS [BelongOrgId],[YWBuying].[OrgId],@Notes AS [Notes] "
                                + "FROM [YWBuying] "
                                + "WHERE Id=@Id";
            SqlParameter[] parameters2 = 
            {
                new SqlParameter("@StorageQuantity"   , SqlDbType.Int     , 4      ){ Value = iStorageQuantity  },
                new SqlParameter("@DateTimeNow"       , SqlDbType.NChar   , 50     ){ Value = strDateTimeNow    },
                new SqlParameter("@BelongOrgId"       , SqlDbType.Int     , 4      ){ Value = iResOrgId         },
                new SqlParameter("@ConfirmUserName"   , SqlDbType.NChar   , 50     ){ Value = strUserName       },
                new SqlParameter("@Notes"             , SqlDbType.NChar   , 50     ){ Value = strNotes          },
                new SqlParameter("@Id"                , SqlDbType.Int     , 4      ){ Value = iBuyingId         }
            };
            parameter2.Parameters = parameters2;

            //构建查询条件(更新对应的需求记录状态为已入库)
            Parameter parameter3 = new Parameter();
            parameter3.SqlString = "UPDATE [YWRequirement] SET [RequirementStateId]=@ToStateId WHERE [Id] IN (" + strRequirementIdString + ") AND [RequirementStateId]=@FromStateId";
            SqlParameter[] parameters3 = 
            {
                new SqlParameter("@FromStateId"   , SqlDbType.Int     , 4      ){ Value = CodeDictionary.RequirementState["已购买"]  },
                new SqlParameter("@ToStateId"     , SqlDbType.Int     , 4      ){ Value = CodeDictionary.RequirementState["已入库"]  }
            };
            parameter3.Parameters = parameters3;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);
            parmList.Add(parameter3);
            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList,1);
        }

        //add by chr
        //根据购买记录的信息插入入库记录（多条）
        public static void InsertInStoreDataByBuyingId(string strBuyingId, string strUserName, string strDateTimeNow)
        {
            //检查点记录数
            int iCheckPoint = strBuyingId.Split(',').Length;
            //根据购买记录Id获取对应的需求记录Id字符串
            string strRequirementIdString = YWBuyingBLL.GetRequirementIdStringByBuyingId(strBuyingId);
            //获取用户所属的组织机构id
            int iResOrgId = PTUsersBLL.GetUserOrgId(strUserName);

            //构建查询条件(更新对应的购买记录状态为已入库)
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWBuying] SET [BuyStateId]=@ToStateId WHERE [Id] IN (" + strBuyingId + ") AND [BuyStateId]=@FromStateId";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@FromStateId"   , SqlDbType.Int     , 4      ){ Value = CodeDictionary.BuyingState["已购买"]  },
                new SqlParameter("@ToStateId"     , SqlDbType.Int     , 4      ){ Value = CodeDictionary.BuyingState["已入库"]  }
            };
            parameter1.Parameters = parameters1;

            //构建查询条件(根据Buying记录中的信息，结合传入参数，插入InStore记录)
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = "INSERT INTO [YWInStore] "
                                + "([MaterialId],[StorageQuantity],[StorageUnit],[StorageTime],[ConfirmUserName],[BuyUserName],[BuyTime],[BuyingId],[BelongOrgId],[OrgId],[Notes]) "
                                + "SELECT [YWBuying].[MaterialId],[YWBuying].[BuyQuantity] AS [StorageQuantity],[YWBuying].[BuyQuantityUnit] AS [StorageUnit],"
                                + "@DateTimeNow AS [StorageTime],@ConfirmUserName AS [ConfirmUserName],[YWBuying].[BuyUserName] AS [BuyUserName],"
                                + "[YWBuying].[BuyTime],[YWBuying].[Id] AS [BuyingId],@BelongOrgId AS [BelongOrgId],[YWBuying].[OrgId],'' AS [Notes] "
                                + "FROM [YWBuying] "
                                + "WHERE Id IN (" + strBuyingId + ")";
            SqlParameter[] parameters2 = 
            {
                new SqlParameter("@DateTimeNow"       , SqlDbType.NChar   , 50     ){ Value = strDateTimeNow },
                new SqlParameter("@BelongOrgId"       , SqlDbType.Int     , 4      ){ Value = iResOrgId      },
                new SqlParameter("@ConfirmUserName"   , SqlDbType.NChar   , 50     ){ Value = strUserName    }
            };
            parameter2.Parameters = parameters2;

            //构建查询条件(更新对应的需求记录状态为已入库)
            Parameter parameter3 = new Parameter();
            parameter3.SqlString = "UPDATE [YWRequirement] SET [RequirementStateId]=@ToStateId WHERE [Id] IN (" + strRequirementIdString + ") AND [RequirementStateId]=@FromStateId";
            SqlParameter[] parameters3 = 
            {
                new SqlParameter("@FromStateId"   , SqlDbType.Int     , 4      ){ Value = CodeDictionary.RequirementState["已购买"]  },
                new SqlParameter("@ToStateId"     , SqlDbType.Int     , 4      ){ Value = CodeDictionary.RequirementState["已入库"]  }
            };
            parameter3.Parameters = parameters3;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);
            parmList.Add(parameter3);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        ////根据餐厅机构编号和收货单位获取收货记录列表（已完成，仅显示7天内的）
        //public static List<YWInStore> GetListByRestaurantOrgIdBelongOrgId(int iRestaurantOrgId, int iBelongOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId AND [BelongOrgId]=@BelongOrgId AND [BuyTime] > @BuyTime ORDER BY [Id] DESC";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iRestaurantOrgId},
        //        new SqlParameter("@BelongOrgId"   , SqlDbType.Int , 50 ){ Value = iBelongOrgId},
        //        new SqlParameter("@BuyTime"   , SqlDbType.NVarChar , 50 ){ Value = DateTime.Now.AddDays(-7).ToString()},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据关联的购买记录编号获取入库记录列表
        //public static List<YWInStore> GetListByBuyingId(int iBuyingId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [BuyingId]=@BuyingId ORDER BY [Id] DESC";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@BuyingId"   , SqlDbType.Int , 50 ){ Value = iBuyingId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}


    }
}
