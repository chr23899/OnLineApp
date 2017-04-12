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
    /// 对象名称：餐桌业务逻辑类（业务逻辑层）
    /// 对象说明：餐桌管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWTableBLL
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
        internal static DAL.Common.YWTableDAL DataAccess
        {
            get
            {
                return DAL.Common.YWTableDAL.Instance;
            }
        }


        /// <summary>
        /// 对餐桌（YWTable）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWTable">餐桌（YWTable）实例对象</param>
        public static void CheckValid(YWTable yWTable)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWTable.Name))
                throw new CustomException("“名称”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWTable.TableTypeId))
                throw new CustomException("“餐桌类别”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWTable.StdCapacity))
                throw new CustomException("“标准人数”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWTable.MaxCapacity))
                throw new CustomException("“最大容量”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWTable.MinConsumption))
                throw new CustomException("“最低消费”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWTable.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWTable.Name , 50))
                throw new CustomException("“名称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWTable.Photo , 50))
                throw new CustomException("“照片”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWTable.OwnerUserName, 50))
                throw new CustomException("“负责人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将餐桌（YWTable）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWTable">餐桌（YWTable）实例对象</param>
        public static int Insert(YWTable yWTable)
        {
            CheckValid(yWTable);
            return DataAccess.Insert(yWTable);
        }


        /// <summary>
        /// 将餐桌（YWTable）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWTable">餐桌（YWTable）实例对象</param>
        public static int Update(YWTable yWTable)
        {
            CheckValid(yWTable);
            return DataAccess.Update(yWTable);
        }


        /// <summary>
        /// 根据餐桌（YWTable）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">餐桌（YWTable）的主键“编号（Id）”</param>
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
        /// 根据餐桌（YWTable）的主键“编号（Id）”从数据库中获取餐桌（YWTable）的实例。
        /// 成功从数据库中取得记录返回新餐桌（YWTable）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">餐桌（YWTable）的主键“编号（Id）”</param>
        public static YWTable GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据餐桌（YWTable）的主键“编号（Id）”从数据库中获取餐桌（YWTable）的实例。
        /// 成功从数据库中取得记录返回新餐桌（YWTable）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">餐桌（YWTable）的主键“编号（Id）”</param>
        public static YWTable GetDataById(string id)
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
        //根据用户名获取可预订的餐桌列表
        public static PageData GetCanBeBookedTableListByUserName(string strUserName, string strBookTime, int iConsumeTimeBlockId, int iReachNumber, int iTableTypeId, int iPageSize, int iCurPage)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);

            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWTable].[Id],[YWTable].[Name],[YWDictionary].[Name] AS [TableType],[YWTable].[StdCapacity],[YWTable].[MaxCapacity],[YWTable].[MinConsumption],"
                                + "[YWTable].[Photo],[YWTable].[Description],[PT_USER].[NickName] AS [OwnerUserName],[YWTable].[Others],[PT_ORG].[OrgName] AS [Org] "
                                + "FROM [YWTable] "
                                + "LEFT JOIN [YWDictionary] ON [YWTable].[TableTypeId] = [YWDictionary].[Id] "
                                + "LEFT JOIN [PT_USER] ON [YWTable].[OwnerUserName] = [PT_USER].[UserName] "
                                + "LEFT JOIN [PT_ORG] ON [YWTable].[OrgId] = [PT_ORG].[Id] "
                                + "WHERE [YWTable].[TableTypeId] = @TableTypeId AND [YWTable].[MaxCapacity] >= @ReachNumber AND [YWTable].[OrgId] = @OrgId "
                                + "AND [YWTable].[Id] NOT IN "
                                + "(SELECT [ConsumeTableId] FROM [YWConsume] WHERE [ConsumeTime]=@BookTime AND [ConsumeTimeBlockId]=@ConsumeTimeBlockId AND [OrgId]=@OrgId AND [ConsumeStateId]<>@ConsumeStateId) "
                                + "AND [YWTable].[Id] NOT IN "
                                + "(SELECT [BookTableId] FROM [YWBook] WHERE [BookTime] = @BookTime AND [ConsumeTimeBlockId] = @ConsumeTimeBlockId AND [OrgId]=@OrgId) "
                                + "ORDER BY [YWTable].[StdCapacity] ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TableTypeId"        , SqlDbType.Int           , 50 ){ Value = iTableTypeId},
                new SqlParameter("@ReachNumber"        , SqlDbType.Int           , 50 ){ Value = iReachNumber},
                new SqlParameter("@OrgId"              , SqlDbType.Int           , 50 ){ Value = iOrgId},
                new SqlParameter("@BookTime"           , SqlDbType.NVarChar      , 50 ){ Value = strBookTime},
                new SqlParameter("@ConsumeStateId"     , SqlDbType.Int           , 50 ){ Value = CodeDictionary.ConsumeState["已关桌"]},
                new SqlParameter("@ConsumeTimeBlockId" , SqlDbType.Int           , 50 ){ Value = iConsumeTimeBlockId}
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据用户名获取本店可开桌的餐桌列表，验证失败返回错误信息（参数：用户名）
        public static PageData GetCanBeOpenedTableListByUserName(string strUserName, int iReachNumber, int iPageSize, int iCurPage, string strDateNow)
        {
            //获取用户所处的组织机构
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);

            //获取当前饭店，在当前时间所处的消费时间段Id
            int iConsumeTimeBlockId = YWDictionaryBLL.GetConsumeTimeBlockIdByDateTimeNow(iOrgId.ToString());

            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWTable].[Id],[YWTable].[Name],[YWDictionary].[Name] AS [TableType],[YWTable].[StdCapacity],[YWTable].[MaxCapacity],[YWTable].[MinConsumption],"
                                + "[YWTable].[Photo],[YWTable].[Description],[PT_USER].[NickName] AS [OwnerUserName],[YWTable].[Others],[PT_ORG].[OrgName] AS [Org] "
                                + "FROM [YWTable] "
                                + "LEFT JOIN [YWDictionary] ON [YWTable].[TableTypeId] = [YWDictionary].[Id] "
                                + "LEFT JOIN [PT_USER] ON [YWTable].[OwnerUserName] = [PT_USER].[UserName] "
                                + "LEFT JOIN [PT_ORG] ON [YWTable].[OrgId] = [PT_ORG].[Id] "
                                + "WHERE [YWTable].[OrgId] = @OrgId AND [YWTable].[MaxCapacity] >= @ReachNumber "
                                + "AND [YWTable].[Id] NOT IN "
                                + "(SELECT [ConsumeTableId] FROM [YWConsume] WHERE [ConsumeTime]=@OpenTime AND [ConsumeTimeBlockId]=@ConsumeTimeBlockId AND [OrgId]=@OrgId AND [ConsumeStateId]<>@ConsumeStateId) "
                                + "AND [YWTable].[Id] NOT IN "
                                + "(SELECT [BookTableId] FROM [YWBook] WHERE [BookTime]=@OpenTime AND [ConsumeTimeBlockId]=@ConsumeTimeBlockId AND [OrgId]=@OrgId) "
                                + "ORDER BY [YWTable].[StdCapacity] ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ReachNumber"        , SqlDbType.Int           , 4  ){ Value = iReachNumber                         },
                new SqlParameter("@OrgId"              , SqlDbType.Int           , 4  ){ Value = iOrgId                               },
                new SqlParameter("@OpenTime"           , SqlDbType.NVarChar      , 50 ){ Value = strDateNow                           },
                new SqlParameter("@ConsumeStateId"     , SqlDbType.Int           , 4  ){ Value = CodeDictionary.ConsumeState["已关桌"]},
                new SqlParameter("@ConsumeTimeBlockId" , SqlDbType.Int           , 4  ){ Value = iConsumeTimeBlockId                  }
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //获取系统所有餐桌信息
        public static PageData GetSystemTableList(int iPageSize, int iCurPage, string sOrgId, string sName, string sTableTypeId, string sOwnerUserName)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWTable].[Id],[YWTable].[Name],[YWTable].[TableTypeId],[YWDictionary].[Name] AS [TableTypeName],"
                                + "[YWTable].[StdCapacity],[YWTable].[MaxCapacity],[YWTable].[MinConsumption],[YWTable].[Photo],"
                                + "[YWTable].[Description],[PT_USER].[NickName] AS [OwnerUserName],[YWTable].[Others],[YWTable].[OrgId],[PT_ORG].[OrgName]  "
                                + "FROM [YWTable] "
                                + "LEFT JOIN [YWDictionary] ON [YWDictionary].[Id]=[YWTable].[TableTypeId] "
                                + "LEFT JOIN [PT_USER] ON [PT_USER].[UserName]=[YWTable].[OwnerUserName] "
                                + "LEFT JOIN [PT_ORG] ON [PT_ORG].[Id]=[YWTable].[OrgId] "
                                + "WHERE 1=1 ";
            if (sOrgId.Trim() != "")
                parameter.SqlString += " AND [YWTable].[OrgId] = '" + sOrgId + "' ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [YWTable].[Name] LIKE '%" + sName + "%' ";
            if (sTableTypeId.Trim() != "")
                parameter.SqlString += " AND [YWTable].[TableTypeId] =" + sTableTypeId + " ";
            if (sOwnerUserName.Trim() != "")
                parameter.SqlString += " AND [YWTable].[OwnerUserName] = '" + sOwnerUserName + "'  ";
            parameter.SqlString += "ORDER BY [YWTable].[TableTypeId]";
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //获取餐厅所有餐桌信息
        public static PageData GetRestaurantTableListByOrgId(int iOrgId, int iPageSize, int iCurPage, string sName, string sTableTypeId, string sOwnerUserName)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWTable].[Id],[YWTable].[Name],[YWTable].[TableTypeId],[YWDictionary].[Name] AS [TableTypeName],"
                                + "[YWTable].[StdCapacity],[YWTable].[MaxCapacity],[YWTable].[MinConsumption],[YWTable].[Photo],"
                                + "[YWTable].[Description],[PT_USER].[NickName] AS [OwnerUserName],[YWTable].[Others],[YWTable].[OrgId] "
                                + "FROM [YWTable] "
                                + "LEFT JOIN [YWDictionary] ON [YWDictionary].[Id]=[YWTable].[TableTypeId] "
                                + "LEFT JOIN [PT_USER] ON [PT_USER].[UserName]=[YWTable].[OwnerUserName] "
                                + "WHERE [YWTable].[OrgId]=@OrgId ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [YWTable].[Name] LIKE '%" + sName + "%' ";
            if (sTableTypeId.Trim() != "")
                parameter.SqlString += " AND [YWTable].[TableTypeId] =" + sTableTypeId + " ";
            if (sOwnerUserName.Trim() != "")
                parameter.SqlString += " AND [YWTable].[OwnerUserName] = '" + sOwnerUserName + "'  ";
            parameter.SqlString += "ORDER BY [YWTable].[TableTypeId]";
            SqlParameter[] parameters =
            {
                    new SqlParameter("@OrgId"    , SqlDbType.Int      , 4   ){ Value = iOrgId      }
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }


        ////根据餐厅机构编号获取餐桌列表
        //public static List<YWTable> GetAllListByOrgId(int iOrgId)
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

        ////根据餐厅机构编号获取餐桌列表分页
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



    }
}
