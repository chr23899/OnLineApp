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
    /// 对象名称：出库业务逻辑类（业务逻辑层）
    /// 对象说明：出库管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWOutStoreBLL
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
        internal static DAL.Common.YWOutStoreDAL DataAccess
        {
            get
            {
                return DAL.Common.YWOutStoreDAL.Instance;
            }
        }


        /// <summary>
        /// 对出库（YWOutStore）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWOutStore">出库（YWOutStore）实例对象</param>
        public static void CheckValid(YWOutStore yWOutStore)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWOutStore.Material))
                throw new CustomException("“项目”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWOutStore.OutQuantity))
                throw new CustomException("“出库数量”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWOutStore.OutUnit))
                throw new CustomException("“出库单位”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWOutStore.OutTime))
                throw new CustomException("“出库时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWOutStore.ConfirmUser))
                throw new CustomException("“确认人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWOutStore.ConfirmOrg))
                throw new CustomException("“确认单位”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWOutStore.TakeUser))
                throw new CustomException("“领用人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWOutStore.TakeTime))
                throw new CustomException("“领用时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWOutStore.TakeOrg))
                throw new CustomException("“领用单位”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWOutStore.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWOutStore.OutUnit , 50))
                throw new CustomException("“出库单位”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWOutStore.OutTime , 50))
                throw new CustomException("“出库时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWOutStore.ConfirmUser , 50))
                throw new CustomException("“确认人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWOutStore.TakeUser , 50))
                throw new CustomException("“领用人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWOutStore.TakeTime , 50))
                throw new CustomException("“领用时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWOutStore.Notes, 50))
                throw new CustomException("“备注”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将出库（YWOutStore）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWOutStore">出库（YWOutStore）实例对象</param>
        public static int Insert(YWOutStore yWOutStore)
        {
            CheckValid(yWOutStore);
            return DataAccess.Insert(yWOutStore);
        }


        /// <summary>
        /// 将出库（YWOutStore）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWOutStore">出库（YWOutStore）实例对象</param>
        public static int Update(YWOutStore yWOutStore)
        {
            CheckValid(yWOutStore);
            return DataAccess.Update(yWOutStore);
        }


        /// <summary>
        /// 根据出库（YWOutStore）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">出库（YWOutStore）的主键“编号（Id）”</param>
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
        /// 根据出库（YWOutStore）的主键“编号（Id）”从数据库中获取出库（YWOutStore）的实例。
        /// 成功从数据库中取得记录返回新出库（YWOutStore）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">出库（YWOutStore）的主键“编号（Id）”</param>
        public static YWOutStore GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据出库（YWOutStore）的主键“编号（Id）”从数据库中获取出库（YWOutStore）的实例。
        /// 成功从数据库中取得记录返回新出库（YWOutStore）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">出库（YWOutStore）的主键“编号（Id）”</param>
        public static YWOutStore GetDataById(string id)
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

        //add by zy
        //根据ID检查记录是否已出库
        public static Boolean CheckRecordOutStoreOrNot(int iOutStoreId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT COUNT(*) FROM [YWOutStore] WHERE [Id] = @Id AND [OutTime]<>'' AND [OutTime]<>NULL ";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id", SqlDbType.Int, 4){ Value = iOutStoreId}
            };
            parameter.Parameters = parameters;

            if (Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter)) == 1)
                return true;
            else
                return false;
        }

        //add by zy
        //根据ID字符串检查记录中是否存在已出库的记录，并返回数量
        public static Boolean CheckExistsOrNotOutStoreRecord(string strOutStoreId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT COUNT(*) FROM [YWOutStore] WHERE [Id] IN (" + strOutStoreId + ") AND [OutTime]<>'' AND [OutTime]<>NULL ";

            if (Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter)) > 0)
                return true;
            else
                return false;
        }

        //add by zy
        //根据用户名获取我的出库记录列表
        public static PageData GetOutStoreListByUserName(string strUserName, string strType, string strDateNow, int iPageSize, int iCurPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWOutStore].[Id],[YWOutStore].[MaterialId],[YWMaterial].[Name] AS [MaterialName],[YWOutStore].[OutQuantity],[YWOutStore].[OutUnit],[YWOutStore].[OutTime],"
                                + "[PT_User1].[Nickname] AS [ConfirmUserName],[PT_User2].[Nickname] AS [TakeUserName],[YWOutStore].[TakeTime],"
                                + "[YWOutStore].[TakeOrgId],[PT_Org1].[OrgName] AS [TakeOrgName],"
                                + "[YWOutStore].[OrgId],[PT_Org3].[OrgName] AS [OrgName],"
                                + "[YWOutStore].[ConfirmOrgId],[PT_Org2].[OrgName] AS [ConfirmOrgName],[YWOutStore].[Notes] "
                                + "FROM [YWOutStore] "
                                + "LEFT JOIN [YWMaterial] ON [YWMaterial].[Id]=[YWOutStore].[MaterialId] "
                                + "LEFT JOIN [PT_User] AS [PT_User1] ON [YWOutStore].[ConfirmUserName]=[PT_User1].[UserName] "
                                + "LEFT JOIN [PT_User] AS [PT_User2] ON [YWOutStore].[TakeUserName]=[PT_User2].[UserName] "
                                + "LEFT JOIN [PT_Org] AS [PT_Org1] ON [YWOutStore].[TakeOrgId]=[PT_Org1].[Id] "
                                + "LEFT JOIN [PT_Org] AS [PT_Org2] ON [YWOutStore].[ConfirmOrgId]=[PT_Org2].[Id] "
                                + "LEFT JOIN [PT_Org] AS [PT_Org3] ON [YWOutStore].[OrgId]=[PT_Org3].[Id] "
                                + "WHERE [YWOutStore].[TakeUserName]=@TakeUserName ";
            SqlParameter[] parameters;
            switch (strType)
            {
                case "InApply":
                    parameter.SqlString += "AND ([YWOutStore].[OutTime] IS NULL OR [YWOutStore].[OutTime]='') ";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@TakeUserName" , SqlDbType.NVarChar , 50  ){ Value = strUserName  }
                    };
                    break;
                case "OutStoreToday":
                    parameter.SqlString += "AND [YWOutStore].[OutTime]=@OutTime ";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@TakeUserName" , SqlDbType.NVarChar , 50  ){ Value = strUserName  },
                        new SqlParameter("@OutTime"      , SqlDbType.NVarChar , 50  ){ Value = strDateNow   }
                    };
                    break;
                default:
                    parameters = new SqlParameter[] { };
                    break;
            }
            parameter.SqlString += "ORDER BY [YWOutStore].[OutTime]";

            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by zy
        //根据用户名获取所在饭店的出库记录列表
        public static PageData GetRestrauntOutStoreListByUserName(string strUserName, string strType, string strDateNow, int iPageSize, int iCurPage)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWOutStore].[Id],[YWOutStore].[MaterialId],[YWMaterial].[Name] AS [MaterialName],[YWOutStore].[OutQuantity],[YWOutStore].[OutUnit],[YWOutStore].[OutTime],"
                                + "[PT_User1].[Nickname] AS [ConfirmUserName],[PT_User2].[Nickname] AS [TakeUserName],[YWOutStore].[TakeTime],"
                                + "[YWOutStore].[TakeOrgId],[PT_Org1].[OrgName] AS [TakeOrgName],"
                                + "[YWOutStore].[OrgId],[PT_Org3].[OrgName] AS [OrgName],"
                                + "[YWOutStore].[ConfirmOrgId],[PT_Org2].[OrgName] AS [ConfirmOrgName],[YWOutStore].[Notes] "
                                + "FROM [YWOutStore] "
                                + "LEFT JOIN [YWMaterial] ON [YWMaterial].[Id]=[YWOutStore].[MaterialId] "
                                + "LEFT JOIN [PT_User] AS [PT_User1] ON [YWOutStore].[ConfirmUserName]=[PT_User1].[UserName] "
                                + "LEFT JOIN [PT_User] AS [PT_User2] ON [YWOutStore].[TakeUserName]=[PT_User2].[UserName] "
                                + "LEFT JOIN [PT_Org] AS [PT_Org1] ON [YWOutStore].[TakeOrgId]=[PT_Org1].[Id] "
                                + "LEFT JOIN [PT_Org] AS [PT_Org2] ON [YWOutStore].[ConfirmOrgId]=[PT_Org2].[Id] "
                                + "LEFT JOIN [PT_Org] AS [PT_Org3] ON [YWOutStore].[OrgId]=[PT_Org3].[Id] "
                                + "WHERE [YWOutStore].[OrgId]=@OrgId ";
            SqlParameter[] parameters;
            switch (strType)
            {
                case "InApply":
                    parameter.SqlString += "AND ([YWOutStore].[OutTime] IS NULL OR [YWOutStore].[OutTime]='') ";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@OrgId"    , SqlDbType.Int      , 4   ){ Value = iOrgId      }
                    };
                    break;
                case "OutStoreToday":
                    parameter.SqlString += "AND [YWOutStore].[OutTime]=@OutTime ";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@OrgId"    , SqlDbType.Int      , 4   ){ Value = iOrgId      },
                        new SqlParameter("@OutTime"  , SqlDbType.NVarChar , 50  ){ Value = strDateNow  }
                    };
                    break;
                default:
                    parameters = new SqlParameter[] { };
                    break;
            }
            parameter.SqlString += "ORDER BY [YWOutStore].[OutTime]";

            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据Id字符串获取需求列表数据
        public static DataTable GetOutStoreDataById(int strRequirementId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT * FROM [YWOutStore] "
                                + "WHERE [YWOutStore].[Id] = '" + strRequirementId + "' ";

            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by zy
        //获取系统所有出库记录列表
        public static PageData GetSystemOutStoreList(int iPageSize, int iCurPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWOutStore].[Id],[YWOutStore].[MaterialId],[YWMaterial].[Name] AS [MaterialName],[YWOutStore].[OutQuantity],[YWOutStore].[OutUnit],[YWOutStore].[OutTime],"
                                + "[PT_User1].[Nickname] AS [ConfirmUserName],[PT_User2].[Nickname] AS [TakeUserName],[YWOutStore].[TakeTime],"
                                + "[YWOutStore].[TakeOrgId],[PT_Org1].[OrgName] AS [TakeOrgName],"
                                + "[YWOutStore].[OrgId],[PT_Org3].[OrgName] AS [OrgName],"
                                + "[YWOutStore].[ConfirmOrgId],[PT_Org2].[OrgName] AS [ConfirmOrgName],[YWOutStore].[Notes] "
                                + "FROM [YWOutStore] "
                                + "LEFT JOIN [YWMaterial] ON [YWMaterial].[Id]=[YWOutStore].[MaterialId] "
                                + "LEFT JOIN [PT_User] AS [PT_User1] ON [YWOutStore].[ConfirmUserName]=[PT_User1].[UserName] "
                                + "LEFT JOIN [PT_User] AS [PT_User2] ON [YWOutStore].[TakeUserName]=[PT_User2].[UserName] "
                                + "LEFT JOIN [PT_Org] AS [PT_Org1] ON [YWOutStore].[TakeOrgId]=[PT_Org1].[Id] "
                                + "LEFT JOIN [PT_Org] AS [PT_Org2] ON [YWOutStore].[ConfirmOrgId]=[PT_Org2].[Id] "
                                + "LEFT JOIN [PT_Org] AS [PT_Org3] ON [YWOutStore].[OrgId]=[PT_Org3].[Id] ";

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by zy
        //根据Id修改出库数量
        public static int UpdateOutQuantityAndNotesById(int iOutStoreId, int iOutQuantity, string strNotes)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWOutStore] SET [OutQuantity]=@OutQuantity,[Notes]=@Notes WHERE [Id] =@Id ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OutQuantity"       , SqlDbType.Int      , 4         ){ Value = iOutQuantity          },
                new SqlParameter("@Notes"             , SqlDbType.NVarChar , 50        ){ Value = strNotes              },
                new SqlParameter("@Id"                , SqlDbType.Int      , 4         ){ Value = iOutStoreId           }
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.ExcuteSql(parameter);
        }

        //add by zy
        //根据Id更新出库信息
        public static void UpdateOutStoreInfoById(string strOutStoreId, string strConfirmUserName, int iOutQuantity, string strNotes, string strDateNow)
        {
            //获取确认人用户所属单位组织机构Id
            int iConfirmOrgId = PTUsersBLL.GetUserOrgId(strConfirmUserName);
            //检查点记录数
            int iCheckPoint = strOutStoreId.Split(',').Length;
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWOutStore] SET [OutQuantity]=@OutQuantity,[OutTime]=@OutTime,[ConfirmUserName]=@ConfirmUserName,[ConfirmOrgId]=@ConfirmOrgId,[Notes]=@Notes WHERE [Id] IN (" + strOutStoreId + ") ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OutQuantity"      , SqlDbType.Int           , 4          ){ Value = iOutQuantity         },
                new SqlParameter("@OutTime"          , SqlDbType.NVarChar      , 50         ){ Value = strDateNow           },
                new SqlParameter("@ConfirmUserName"  , SqlDbType.NVarChar      , 50         ){ Value = strConfirmUserName   },
                new SqlParameter("@ConfirmOrgId"     , SqlDbType.Int           , 4          ){ Value = iConfirmOrgId        },
                new SqlParameter("@Notes"            , SqlDbType.NVarChar      , 50         ){ Value = strNotes             }
            };
            parameter.Parameters = parameters;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        //add by zy
        //删除出库记录
        public static void DeleteOutStoreListById(string strOutStoreId)
        {
            //检查点记录数
            int iCheckPoint = strOutStoreId.Split(',').Length;
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "DELETE FROM [YWOutStore] WHERE [Id] IN (" + strOutStoreId + ") AND ([OutTime] IS NULL OR [OutTime]='' ) ";
            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }
    }
}
