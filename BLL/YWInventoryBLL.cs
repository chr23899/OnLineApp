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
    /// 对象名称：盘存记录业务逻辑类（业务逻辑层）
    /// 对象说明：盘存记录管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWInventoryBLL
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
        internal static DAL.Common.YWInventoryDAL DataAccess
        {
            get
            {
                return DAL.Common.YWInventoryDAL.Instance;
            }
        }


        /// <summary>
        /// 对盘存记录（YWInventory）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWInventory">盘存记录（YWInventory）实例对象</param>
        public static void CheckValid(YWInventory yWInventory)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWInventory.Material))
                throw new CustomException("“项目”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInventory.TotalStorge))
                throw new CustomException("“库存总数”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInventory.ActualTotal))
                throw new CustomException("“实际总数”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInventory.Match))
                throw new CustomException("“是否对应”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInventory.InventoryUser))
                throw new CustomException("“盘存人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInventory.InventoryTime))
                throw new CustomException("“盘存时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInventory.InventoryOrg))
                throw new CustomException("“盘存单位”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWInventory.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度

            if (DataValid.IsOutLength(yWInventory.InventoryUser , 50))
                throw new CustomException("“盘存人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWInventory.InventoryTime , 50))
                throw new CustomException("“盘存时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWInventory.UpdateConfirmUser , 50))
                throw new CustomException("“修正确认人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWInventory.UpdateTime , 50))
                throw new CustomException("“修正时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将盘存记录（YWInventory）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWInventory">盘存记录（YWInventory）实例对象</param>
        public static int Insert(YWInventory yWInventory)
        {
            CheckValid(yWInventory);
            return DataAccess.Insert(yWInventory);
        }


        /// <summary>
        /// 将盘存记录（YWInventory）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWInventory">盘存记录（YWInventory）实例对象</param>
        public static int Update(YWInventory yWInventory)
        {
            CheckValid(yWInventory);
            return DataAccess.Update(yWInventory);
        }


        /// <summary>
        /// 根据盘存记录（YWInventory）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">盘存记录（YWInventory）的主键“编号（Id）”</param>
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
        /// 根据盘存记录（YWInventory）的主键“编号（Id）”从数据库中获取盘存记录（YWInventory）的实例。
        /// 成功从数据库中取得记录返回新盘存记录（YWInventory）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">盘存记录（YWInventory）的主键“编号（Id）”</param>
        public static YWInventory GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据盘存记录（YWInventory）的主键“编号（Id）”从数据库中获取盘存记录（YWInventory）的实例。
        /// 成功从数据库中取得记录返回新盘存记录（YWInventory）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">盘存记录（YWInventory）的主键“编号（Id）”</param>
        public static YWInventory GetDataById(string id)
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
        //根据用户名获取待修正的盘存记录
        public static PageData GetWaitUpdateInventoryListByUserName(int pageSize, int curPage, string strUserName)
        {
            //获取所属饭店的组织机构Id
            int iResOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWInventory].[Id],[YWInventory].[MaterialId],[YWMaterial].[Name] AS [MaterialName],[YWMaterial].[MaterialTypeId],"
                                + "[YWDictionary].[Name] AS [MaterialTypeName],[YWMaterial].[StdUnit],[YWInventory].[TotalStorge],[YWInventory].[ActualTotal],"
                                + "[YWInventory].[Match],[YWInventory].[InventoryUserName],[YWInventory].[InventoryTime],[YWInventory].[UpdateValue],"
                                + "[YWInventory].[UpdateConfirmUserName],[YWInventory].[UpdateTime],[YWInventory].[InventoryOrgId],[YWInventory].[OrgId] "
                                + "FROM [YWInventory] "
                                + "LEFT JOIN [YWMaterial] ON [YWInventory].[MaterialId]=[YWMaterial].[Id] "
                                + "LEFT JOIN [YWDictionary] ON [YWMaterial].[MaterialTypeId]=[YWDictionary].[Id] "
                                + "WHERE [YWInventory].[Match]=0 AND [YWInventory].[OrgId]=@OrgId AND ([YWInventory].[UpdateTime] IS NULL OR [YWInventory].[UpdateTime]='')";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"        , SqlDbType.Int      , 4         ){ Value = iResOrgId             }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }

        //add by chr
        //根据Id字符串获取需求列表数据
        public static DataTable GetInventoryDataById(int iInventoryId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT * FROM [YWInventory] "
                                + "WHERE [YWInventory].[Id] = '" + iInventoryId + "' ";

            return CommonToolsBLL.GetAllListByParams(parameter);
        }


        //add by chr
        //获取系统所有盘存记录列表
        public static PageData GetSystemInventoryList(int pageSize, int curPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWInventory].[Id],[YWInventory].[MaterialId],[YWMaterial].[Name] AS [MaterialName],[YWMaterial].[MaterialTypeId],"
                                + "[YWDictionary].[Name] AS [MaterialTypeName],[YWMaterial].[StdUnit],[YWInventory].[TotalStorge],[YWInventory].[ActualTotal],"
                                + "[YWInventory].[Match],[PT_USER1].[NickName] AS [InventoryUserName],[YWInventory].[InventoryTime],[YWInventory].[UpdateValue],"
                                + "[PT_USER2].[NickName] AS [UpdateConfirmUserName],[YWInventory].[UpdateTime],[YWInventory].[InventoryOrgId],[YWInventory].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [YWInventory] "
                                + "LEFT JOIN [YWMaterial] ON [YWInventory].[MaterialId]=[YWMaterial].[Id] "
                                + "LEFT JOIN [YWDictionary] ON [YWMaterial].[MaterialTypeId]=[YWDictionary].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWMaterial].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWInventory].[InventoryUserName] = [PT_USER1].UserName "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWInventory].[UpdateConfirmUserName] = [PT_USER2].UserName ";
            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }

        //add by chr
        //根据盘存记录ID完成修正
        public static void UpdateInventoryListById(string strInventoryId, string strUpdateUser, string strUpdateTime)
        {
            //检查点记录数
            int iCheckPoint = strInventoryId.Split(',').Length;
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWInventory] SET [UpdateConfirmUserName]=@UpdateConfirmUserName, [UpdateTime]=@UpdateTime WHERE [Id] IN (" + strInventoryId + ") ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UpdateConfirmUserName"     , SqlDbType.NVarChar      , 50         ){ Value = strUpdateUser   },
                new SqlParameter("@UpdateTime"                , SqlDbType.NVarChar      , 50         ){ Value = strUpdateTime   }
            };
            parameter.Parameters = parameters;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }
    }
}
