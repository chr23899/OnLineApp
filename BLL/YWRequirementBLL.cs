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
    /// 对象名称：需求业务逻辑类（业务逻辑层）
    /// 对象说明：采购需求管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWRequirementBLL
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
        internal static DAL.Common.YWRequirementDAL DataAccess
        {
            get
            {
                return DAL.Common.YWRequirementDAL.Instance;
            }
        }


        /// <summary>
        /// 对需求（YWRequirement）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWRequirement">需求（YWRequirement）实例对象</param>
        public static void CheckValid(YWRequirement yWRequirement)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWRequirement.Material))
                throw new CustomException("“项目”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRequirement.EstimateMode))
                throw new CustomException("“计量方式”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRequirement.SourceOrg))
                throw new CustomException("“来源”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRequirement.ProposeUser))
                throw new CustomException("“提出人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRequirement.ProposeTime))
                throw new CustomException("“提出时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRequirement.RequirementState))
                throw new CustomException("“需求单状态”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRequirement.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWRequirement.QuantityUnit , 50))
                throw new CustomException("“数量单位”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWRequirement.WeightUnit , 50))
                throw new CustomException("“重量单位”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWRequirement.ProposeUser , 50))
                throw new CustomException("“提出人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWRequirement.ProposeTime , 50))
                throw new CustomException("“提出时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWRequirement.SpecialRequirement , 50))
                throw new CustomException("“特殊要求”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWRequirement.ReceiveUser , 50))
                throw new CustomException("“接收人”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWRequirement.ReceiveTime , 50))
                throw new CustomException("“接收时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将需求（YWRequirement）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWRequirement">需求（YWRequirement）实例对象</param>
        public static int Insert(YWRequirement yWRequirement)
        {
            CheckValid(yWRequirement);
            return DataAccess.Insert(yWRequirement);
        }


        /// <summary>
        /// 将需求（YWRequirement）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWRequirement">需求（YWRequirement）实例对象</param>
        public static int Update(YWRequirement yWRequirement)
        {
            CheckValid(yWRequirement);
            return DataAccess.Update(yWRequirement);
        }


        /// <summary>
        /// 根据需求（YWRequirement）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">需求（YWRequirement）的主键“编号（Id）”</param>
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
        /// 根据需求（YWRequirement）的主键“编号（Id）”从数据库中获取需求（YWRequirement）的实例。
        /// 成功从数据库中取得记录返回新需求（YWRequirement）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">需求（YWRequirement）的主键“编号（Id）”</param>
        public static YWRequirement GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据需求（YWRequirement）的主键“编号（Id）”从数据库中获取需求（YWRequirement）的实例。
        /// 成功从数据库中取得记录返回新需求（YWRequirement）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">需求（YWRequirement）的主键“编号（Id）”</param>
        public static YWRequirement GetDataById(string id)
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
        //根据提出人用户名、需求类型获取需求列表
        public static PageData GetPageDataTableByUserNameAndRequirementType(int pageSize, int curPage, string strUserName, string strRequirementType)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWRequirement].[Id],[YWMaterial].[Name] AS [MaterialName],[YWDictionary1].[Name] AS [EstimateModeName],[YWRequirement].[Quantity], "
                                + "[YWRequirement].[QuantityUnit],[YWRequirement].[Weight],[YWRequirement].[WeightUnit],[YWRequirement].[SourceOrgId], "
                                + "[PT_USER1].[NickName] AS [ProposeUserName],[YWRequirement].[ProposeTime],[YWDictionary2].[Name] AS [RequirementStateName], "
                                + "[YWRequirement].[OrgId],[YWRequirement].[SpecialRequirement],[PT_USER2].[NickName] AS [ReceiveUserName],[YWRequirement].[ReceiveTime] "
                                + "FROM [YWRequirement] "
                                + "LEFT JOIN [YWMaterial] ON [YWRequirement].[MaterialId] = [YWMaterial].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWRequirement].[EstimateModeId] = [YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWRequirement].[RequirementStateId] = [YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWRequirement].[ProposeUserName] = [PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWRequirement].[ReceiveUserName] = [PT_USER2].[UserName] ";
            SqlParameter[] parameters;
            switch (strRequirementType)
            {
                case "Draft":
                    parameter.SqlString += " WHERE [YWRequirement].[ProposeUserName]=@ProposeUserName AND [YWRequirement].[RequirementStateId] = @State1 ORDER BY [YWRequirement].[RequirementStateId],[YWRequirement].[Id] DESC";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ProposeUserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName                            },
                        new SqlParameter("@State1"            , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["草稿"]}
                    };
                    break;
                case "InProcess":
                    parameter.SqlString += " WHERE [YWRequirement].[ProposeUserName]=@ProposeUserName AND [YWRequirement].[RequirementStateId] IN (@State1, @State2, @State3) ORDER BY [YWRequirement].[RequirementStateId],[YWRequirement].[Id] DESC";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ProposeUserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName                              },
                        new SqlParameter("@State1"            , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["已下单"]},
                        new SqlParameter("@State2"            , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["处理中"]},
                        new SqlParameter("@State3"            , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["已购买"]}
                    };
                    break;
                case "Finish":
                    parameter.SqlString += " WHERE [YWRequirement].[ProposeUserName]=@ProposeUserName AND [YWRequirement].[RequirementStateId] = @State1 ORDER BY [YWRequirement].[RequirementStateId],[YWRequirement].[Id] DESC";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@ProposeUserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName                              },
                        new SqlParameter("@State1"            , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["已入库"]}
                    };
                    break;
                default:
                    parameters = new SqlParameter[]{};
                    break;
            }
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }

        //add by zy
        //根据提出人用户名、需求类型获取需求列表
        public static PageData GetDataTableByMaterialIdAndReceiptor(int pageSize, int curPage, int iMaterialId, string strReceiveUserName)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWRequirement].[Id],[YWMaterial].[Name] AS [MaterialName],[YWDictionary1].[Name] AS [EstimateModeName],[YWRequirement].[Quantity],"
                                + "[YWRequirement].[QuantityUnit],[YWRequirement].[Weight],[YWRequirement].[WeightUnit],[YWRequirement].[SourceOrgId],[PT_ORG1].[OrgName] AS [SourceOrgName],"
                                + "[PT_USER1].[NickName] AS [ProposeUserName],[YWRequirement].[ProposeTime],[YWDictionary2].[Name] AS [RequirementStateName],"
                                + "[YWRequirement].[OrgId],[PT_ORG2].[OrgName] AS [OrgName],[YWRequirement].[SpecialRequirement],[PT_USER2].[NickName] AS [ReceiveUserName],[YWRequirement].[ReceiveTime] "
                                + "FROM [YWRequirement] "
                                + "LEFT JOIN [YWMaterial] ON [YWRequirement].[MaterialId] = [YWMaterial].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWRequirement].[EstimateModeId] = [YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWRequirement].[RequirementStateId] = [YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWRequirement].[ProposeUserName] = [PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWRequirement].[ReceiveUserName] = [PT_USER2].[UserName] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG1] ON [YWRequirement].[SourceOrgId] = [PT_ORG1].[Id] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG2] ON [YWRequirement].[OrgId] = [PT_ORG2].[Id] "
                                + "WHERE [YWRequirement].[MaterialId]=@MaterialId AND [YWRequirement].[ReceiveUserName]=@ReceiveUserName "
                                + "ORDER BY [RequirementStateName],[Id] DESC";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@MaterialId"        , SqlDbType.Int      , 4  ){ Value = iMaterialId            },
                new SqlParameter("@ReceiveUserName"   , SqlDbType.NVarChar , 50 ){ Value = strReceiveUserName     }
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }

        //add by zy
        //根据组织机构、领取人、需求类型获取需求分组汇总数据
        public static PageData GetGroupListByUserNameAndRequirementType(int pageSize, int curPage, string strUserName, string strRequirementType)
        {
            int iOrgId = Convert.ToInt32(YWPersonBLL.GetUserRestaurantOrgId(strUserName));

            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWMaterial].[MaterialTypeId],[YWMaterial].[Id],[YWMaterial].[Name] AS [MaterialName],[A].[RequirementStateId],[YWDictionary].[Name] AS [RequirementStateName],"
                                + "[A].[ReceiveUserName],[PT_USER].[NickName] AS [ReceiptorName],[A].[QuantityUnit],[A].[RequirementCnt],[A].[SumQuantity] "
                                + "FROM "
                                + "("
                                + "SELECT [YWRequirement].[MaterialId],[YWRequirement].[RequirementStateId],[YWRequirement].[ReceiveUserName],[YWRequirement].[QuantityUnit],COUNT(*) AS RequirementCnt,SUM([YWRequirement].[Quantity]) AS [SumQuantity] "
                                + "FROM [YWRequirement] ";
            SqlParameter[] parameters;
            switch (strRequirementType)
            {
                case "All":
                    parameter.SqlString += "WHERE [YWRequirement].[OrgId]=@OrgId AND [YWRequirement].[RequirementStateId] IN (@State1, @State2, @State3) ";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@OrgId"   , SqlDbType.Int , 4 ){ Value = iOrgId                                   },
                        new SqlParameter("@State1"  , SqlDbType.Int , 4 ){ Value = CodeDictionary.RequirementState["已下单"]},
                        new SqlParameter("@State2"  , SqlDbType.Int , 4 ){ Value = CodeDictionary.RequirementState["处理中"]},
                        new SqlParameter("@State3"  , SqlDbType.Int , 4 ){ Value = CodeDictionary.RequirementState["已购买"]}
                    };
                    break;
                case "Mine":
                    parameter.SqlString += "WHERE [YWRequirement].[OrgId]=@OrgId AND [YWRequirement].[ReceiveUserName]=@ReceiveUserName AND [YWRequirement].[RequirementStateId] IN (@State1, @State2, @State3) ";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@OrgId"          , SqlDbType.Int      , 4  ){ Value = iOrgId                                   },
                        new SqlParameter("@ReceiveUserName", SqlDbType.NVarChar , 50 ){ Value = strUserName                              },
                        new SqlParameter("@State1"         , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["已下单"]},
                        new SqlParameter("@State2"         , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["处理中"]},
                        new SqlParameter("@State3"         , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["已购买"]}
                    };
                    break;
                case "Active":
                    parameter.SqlString += "WHERE [YWRequirement].[OrgId]=@OrgId AND [YWRequirement].[ReceiveUserName]='' AND [YWRequirement].[RequirementStateId]=@State1 ";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@OrgId"   , SqlDbType.Int , 4 ){ Value = iOrgId                                   },
                        new SqlParameter("@State1"  , SqlDbType.Int , 4 ){ Value = CodeDictionary.RequirementState["已下单"]}
                    };
                    break;
                default:
                    parameters = new SqlParameter[]
                    {
                    };
                    break;
            }
            parameter.SqlString += "GROUP BY [YWRequirement].[MaterialId],[YWRequirement].[RequirementStateId],[YWRequirement].[ReceiveUserName],[YWRequirement].[QuantityUnit] ";
            parameter.SqlString += ") A ";
            parameter.SqlString += "LEFT JOIN [YWMaterial] ON [A].[MaterialId]=[YWMaterial].[Id] ";
            parameter.SqlString += "LEFT JOIN [YWDictionary] ON [A].[RequirementStateId]=[YWDictionary].[Id] ";
            parameter.SqlString += "LEFT JOIN [PT_USER] ON [A].[ReceiveUserName]=[PT_USER].[UserName] ";
            parameter.SqlString += "ORDER BY [A].[RequirementStateId],[YWMaterial].[MaterialTypeId] ";
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }

        //add by zy
        //根据Id字符串获取需求列表数据
        public static DataTable GetRequirementListById(string strRequirementId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWRequirement].[Id],[YWMaterial].[Name] AS [MaterialName],[YWDictionary1].[Name] AS [EstimateModeName],[YWRequirement].[Quantity],"
                                + "[YWRequirement].[QuantityUnit],[YWRequirement].[Weight],[YWRequirement].[WeightUnit],[YWRequirement].[SourceOrgId],[PT_ORG1].[OrgName] AS [SourceOrgName],"
                                + "[PT_USER1].[NickName] AS [ProposeUserName],[YWRequirement].[ProposeTime],[YWDictionary2].[Name] AS [RequirementStateName],"
                                + "[YWRequirement].[OrgId],[PT_ORG2].[OrgName] AS [OrgName],[YWRequirement].[SpecialRequirement],[PT_USER2].[NickName] AS [ReceiveUserName],[YWRequirement].[ReceiveTime] "
                                + "FROM [YWRequirement] "
                                + "LEFT JOIN [YWMaterial] ON [YWRequirement].[MaterialId] = [YWMaterial].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWRequirement].[EstimateModeId] = [YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWRequirement].[RequirementStateId] = [YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWRequirement].[ProposeUserName] = [PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWRequirement].[ReceiveUserName] = [PT_USER2].[UserName] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG1] ON [YWRequirement].[SourceOrgId] = [PT_ORG1].[Id] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG2] ON [YWRequirement].[OrgId] = [PT_ORG2].[Id] "
                                + "WHERE [YWRequirement].[Id] IN (" + strRequirementId + ") "
                                + "ORDER BY [RequirementStateName],[Id] DESC";

            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by chr
        //根据Id字符串获取需求列表数据
        public static DataTable GetRequirementDataById(int strRequirementId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT * FROM [YWRequirement] " 
                                + "WHERE [YWRequirement].[Id] = '" + strRequirementId + "' ";

            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by zy
        //根据分组列表的信息获取需求列表的明细数据
        public static PageData GetRequirementListByGroupInfo(int pageSize, int curPage, string strUserName, int iRequirementStateId, int iMaterialId, string strReceiveUserName)
        {
            int iOrgId = Convert.ToInt32(YWPersonBLL.GetUserRestaurantOrgId(strUserName));
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWRequirement].[Id],[YWMaterial].[Name] AS [MaterialName],[YWDictionary1].[Name] AS [EstimateModeName],[YWRequirement].[Quantity],"
                                + "[YWRequirement].[QuantityUnit],[YWRequirement].[Weight],[YWRequirement].[WeightUnit],[YWRequirement].[SourceOrgId],[PT_ORG1].[OrgName] AS [SourceOrgName],"
                                + "[PT_USER1].[NickName] AS [ProposeUserName],[YWRequirement].[ProposeTime],[YWDictionary2].[Name] AS [RequirementStateName],"
                                + "[YWRequirement].[OrgId],[PT_ORG2].[OrgName] AS [OrgName],[YWRequirement].[SpecialRequirement],[PT_USER2].[NickName] AS [ReceiveUserName],[YWRequirement].[ReceiveTime] "
                                + "FROM [YWRequirement] "
                                + "LEFT JOIN [YWMaterial] ON [YWRequirement].[MaterialId] = [YWMaterial].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWRequirement].[EstimateModeId] = [YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWRequirement].[RequirementStateId] = [YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWRequirement].[ProposeUserName] = [PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWRequirement].[ReceiveUserName] = [PT_USER2].[UserName] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG1] ON [YWRequirement].[SourceOrgId] = [PT_ORG1].[Id] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG2] ON [YWRequirement].[OrgId] = [PT_ORG2].[Id] "
                                + "WHERE [YWRequirement].[OrgId]=@OrgId AND [YWRequirement].[RequirementStateId]=@RequirementStateId AND [YWRequirement].[MaterialId]=@MaterialId AND [YWRequirement].[ReceiveUserName]=@ReceiveUserName ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"                , SqlDbType.Int   , 4  ){ Value = iOrgId                                                },
                new SqlParameter("@RequirementStateId"   , SqlDbType.Int   , 4  ){ Value = iRequirementStateId                                   },
                new SqlParameter("@MaterialId"           , SqlDbType.Int   , 4  ){ Value = iMaterialId                                           },
                new SqlParameter("@ReceiveUserName"      , SqlDbType.NChar , 50 ){ Value = (strReceiveUserName == null) ? "" : strReceiveUserName}
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }

        //add by zy
        //根据提出人用户名、需求类型获取需求列表
        public static PageData GetSystemRequirementList(int pageSize, int curPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWRequirement].[Id],[YWMaterial].[Name] AS [MaterialName],[YWDictionary1].[Name] AS [EstimateModeName],[YWRequirement].[Quantity], "
                                + "[YWRequirement].[QuantityUnit],[YWRequirement].[Weight],[YWRequirement].[WeightUnit],[YWRequirement].[SourceOrgId], [PT_ORG1].[OrgName] AS [SourceOrgName], "
                                + "[PT_USER1].[NickName] AS [ProposeUserName],[YWRequirement].[ProposeTime],[YWDictionary2].[Name] AS [RequirementStateName], "
                                + "[YWRequirement].[OrgId],[PT_ORG2].[OrgName] AS [OrgName],[YWRequirement].[SpecialRequirement],[PT_USER2].[NickName] AS [ReceiveUserName],[YWRequirement].[ReceiveTime] "
                                + "FROM [YWRequirement] "
                                + "LEFT JOIN [YWMaterial] ON [YWRequirement].[MaterialId] = [YWMaterial].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWRequirement].[EstimateModeId] = [YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWRequirement].[RequirementStateId] = [YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWRequirement].[ProposeUserName] = [PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWRequirement].[ReceiveUserName] = [PT_USER2].[UserName] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG1] ON [YWRequirement].[SourceOrgId] = [PT_ORG1].[Id] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG2] ON [YWRequirement].[OrgId] = [PT_ORG2].[Id] ";
            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }

        //add by zy
        //根据RequirementId查找需求列表，并根据领取人用户名和领取时间更新对应需求列表
        public static void UpdateRequirementListByRequirementId(string strRequirementId, string strReceiveUserName, string strDateTimeNow)
        {
            //检查点记录数
            string[] listId = strRequirementId.Split(',');
            int iCheckPoint = listId.Length;

            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWRequirement] SET [RequirementStateId] = @ToState, [ReceiveUserName] = @ReceiveUserName, [ReceiveTime] = @ReceiveTime "
                                 + "WHERE [Id] IN (" + strRequirementId + ") AND [ReceiveUserName] = '' AND [RequirementStateId] = @FromState ";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@FromState"         , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["已下单"]      },
                new SqlParameter("@ToState"           , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["处理中"]      },
                new SqlParameter("@ReceiveUserName"   , SqlDbType.NVarChar , 50 ){ Value = strReceiveUserName                             },
                new SqlParameter("@ReceiveTime"       , SqlDbType.NVarChar , 50 ){ Value = strDateTimeNow                                 }
            };
            parameter1.Parameters = parameters1;

            //构建YWLog的Parameter对象
            Parameter parameter2 = YWLogBLL.GetComplexInsertParameter(CodeDictionary.YWTableType["需求日志"], listId, strReceiveUserName, strDateTimeNow, "任务领用");

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        //add by zy
        //根据RequirementId、Receiptor查找需求列表，并将领取人用户名和领取时间更新为空
        public static void UpdateRequirementListByRequirementIdAndReceiptor(string strRequirementId, string strReceiveUserName, string strDateTimeNow)
        {
            //检查点记录数
            string[] listId = strRequirementId.Split(',');
            int iCheckPoint = listId.Length;

            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWRequirement] SET [RequirementStateId] = @ToState, [ReceiveUserName] = '', [ReceiveTime] = '' "
                                 + "WHERE [Id] IN (" + strRequirementId + ") AND [ReceiveUserName] = @ReceiveUserName AND [RequirementStateId] = @FromState ";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@FromState"        , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["处理中"]},
                new SqlParameter("@ToState"          , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["已下单"]},
                new SqlParameter("@ReceiveUserName"  , SqlDbType.NVarChar , 50 ){ Value = strReceiveUserName                       }
            };
            parameter1.Parameters = parameters1;

            //构建YWLog的Parameter对象
            Parameter parameter2 = YWLogBLL.GetComplexInsertParameter(CodeDictionary.YWTableType["需求日志"], listId, strReceiveUserName, strDateTimeNow, "取消领用");

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);

        }

        //add by zy
        //根据RequirementId查找需求记录，并将RequirementState字段更新为32，必须为33的记录
        public static void UpdateRequirementStateByIdTo32(string strRequirementId, string strUserName, string strDateTimeNow)
        {
            string[] listId = strRequirementId.Split(',');
            int iCheckPoint = listId.Length;
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWRequirement] SET [RequirementStateId] = @RequirementStateId "
                                 + "WHERE [Id] IN (" + strRequirementId + ") AND [RequirementStateId] = @State1 ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@RequirementStateId"   , SqlDbType.Int , 4 ){ Value = CodeDictionary.RequirementState["草稿"]  },
                new SqlParameter("@State1"               , SqlDbType.Int , 4 ){ Value = CodeDictionary.RequirementState["已下单"]}
            };
            parameter1.Parameters = parameters;

            //构建YWLog的Parameter对象
            Parameter parameter2 = YWLogBLL.GetComplexInsertParameter(CodeDictionary.YWTableType["需求日志"], listId, strUserName, strDateTimeNow, "撤销需求");

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        //add by zy
        //根据RequirementId查找需求记录，并将RequirementState字段更新为33，必须为32的记录
        public static void UpdateRequirementStateByIdTo33(string strRequirementId, string strUserName, string strDateTimeNow)
        {
            string[] listId = strRequirementId.Split(',');
            int iCheckPoint = listId.Length;
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWRequirement] SET [RequirementStateId] = @RequirementStateId "
                                 + "WHERE [Id] IN (" + strRequirementId + ") AND [RequirementStateId] = @State1 ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@RequirementStateId"   , SqlDbType.Int , 4 ){ Value = CodeDictionary.RequirementState["已下单"]},
                new SqlParameter("@State1"               , SqlDbType.Int , 4 ){ Value = CodeDictionary.RequirementState["草稿"]  }
            };
            parameter1.Parameters = parameters;

            //构建YWLog的Parameter对象
            Parameter parameter2 = YWLogBLL.GetComplexInsertParameter(CodeDictionary.YWTableType["需求日志"], listId, strUserName, strDateTimeNow, "发布需求");

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        //add by zy
        //根据RequirementId查找RequirementStateId=32的需求记录，并删除
        public static void DeleteRequirementDataById(string strRequirementId)
        {
            string[] listId = strRequirementId.Split(',');
            //检查点记录数
            int iCheckPoint = listId.Length;

            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "DELETE FROM [YWRequirement] WHERE [Id] IN (" + strRequirementId + ") AND [RequirementStateId] = @State1 ";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@State1" , SqlDbType.Int , 4 ){ Value = CodeDictionary.RequirementState["草稿"]}
            };
            parameter1.Parameters = parameters1;

            //构建查询条件
            Parameter parameter2 = YWLogBLL.GetComplexDeleteParameter(CodeDictionary.YWTableType["需求日志"], strRequirementId);

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        //add by zy
        //根据参数插入新增的需求记录
        public static void InsertRequirementData(int iMaterialId, int iQuantity, string strUserName, string strSpecialRequirement, int iRequirementState, string strDateTimeNow)
        {
            DateTime datetimeCurrent = DateTime.Now;
            //构建YWRequirement的Parameter对象
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "INSERT INTO [YWRequirement]"
                                 + "([MaterialId],[EstimateModeId],[Quantity],[QuantityUnit],[Weight],[WeightUnit],[SourceOrgId],[ProposeUserName],[ProposeTime],"
                                 + "[RequirementStateId],[OrgId],[SpecialRequirement],[ReceiveUserName],[ReceiveTime])"
                                 + "VALUES"
                                 + "(@MaterialId,@EstimateModeId,@Quantity,@QuantityUnit,@Weight,@WeightUnit,@SourceOrgId,@ProposeUserName,@ProposeTime,"
                                 + "@RequirementStateId,@OrgId,@SpecialRequirement,@ReceiveUserName,@ReceiveTime)";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@MaterialId"          , SqlDbType.Int      , 4         ){ Value = iMaterialId                                        },
                new SqlParameter("@EstimateModeId"      , SqlDbType.Int      , 4         ){ Value = CodeDictionary.EstimateMode["按数量"]              },
                new SqlParameter("@Quantity"            , SqlDbType.Decimal  , 9         ){ Value = iQuantity                                          },
                new SqlParameter("@QuantityUnit"        , SqlDbType.NVarChar , 50        ){ Value = YWMaterialBLL.GetStdUnitByMaterialId(iMaterialId)  },
                new SqlParameter("@Weight"              , SqlDbType.Decimal  , 9         ){ Value = 0                                                  },//目前先填默认值
                new SqlParameter("@WeightUnit"          , SqlDbType.NVarChar , 50        ){ Value = ""                                                 },//目前先填默认值
                new SqlParameter("@SourceOrgId"         , SqlDbType.Int      , 4         ){ Value = PTUsersBLL.GetUserOrgId(strUserName)               },
                new SqlParameter("@ProposeUserName"     , SqlDbType.NVarChar , 50        ){ Value = strUserName                                        },
                new SqlParameter("@ProposeTime"         , SqlDbType.NVarChar , 50        ){ Value = strDateTimeNow                                     },
                new SqlParameter("@RequirementStateId"  , SqlDbType.Int      , 4         ){ Value = iRequirementState                                  },
                new SqlParameter("@OrgId"               , SqlDbType.Int      , 4         ){ Value = YWPersonBLL.GetUserRestaurantOrgId(strUserName)    },
                new SqlParameter("@SpecialRequirement"  , SqlDbType.NVarChar , 50        ){ Value = strSpecialRequirement                              },
                new SqlParameter("@ReceiveUserName"     , SqlDbType.NVarChar , 50        ){ Value = ""                                                 },//目前先填默认值
                new SqlParameter("@ReceiveTime"         , SqlDbType.NVarChar , 50        ){ Value = ""                                                 }//目前先填默认值
            };
            parameter1.Parameters = parameters1;

            //构建YWLog的Parameter对象，根据YWRequirement表的前一条Insert记录Id，SET日志表的业务Id
            Parameter parameter2 = YWLogBLL.GetSingleInsertParameter(CodeDictionary.YWTableType["需求日志"], "YWRequirement", strUserName, datetimeCurrent, "新增需求");

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, 1);
        }


        //add by zy
        //根据参数更新YWRequirement并插入YWBuying记录，必须为33,34状态的需求记录才允许更新
        public static void UpdateRequirementListAndInsertBuyingRecord(string strRequirementId, string strUserName, int iMaterialId, int iQuantity, double dPrice, string strDateTimeNow)
        {
            //根据需要更新的id字符串获取更新操作的检查点数值
            string[] listId = strRequirementId.Split(',');
            //检查点记录数
            int iCheckPoint = listId.Length;   

            //构建YWRequirement的Parameter对象
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWRequirement] SET [RequirementStateId]=@RequirementStateId,[ReceiveUserName]=@ReceiveUserName WHERE [Id] IN (" + strRequirementId + ") AND RequirementStateId IN (@State1, @State2) ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ReceiveUserName"      , SqlDbType.NVarChar , 50 ){ Value = strUserName                              },
                new SqlParameter("@RequirementStateId"   , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["已购买"]},
                new SqlParameter("@State1"               , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["已下单"]},
                new SqlParameter("@State2"               , SqlDbType.Int      , 4  ){ Value = CodeDictionary.RequirementState["处理中"]},
            };
            parameter1.Parameters = parameters;

            //构建YWBuying的Parameter对象
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = "INSERT INTO [YWBuying] ([MaterialId], [BuyQuantity], [BuyQuantityUnit], [BuyWeight], [BuyWeightUnit], [BuyUserName], [BuyTime], [BuyPrice], [BuyStateId], [OrgId], [RequirementList]) ";
            parameter2.SqlString += "VALUES (@materialid, @buyquantity, @buyquantityunit, @buyweight, @buyweightunit, @buyusername, @buytime, @buyprice, @buystateid, @orgid, @RequirementList) ";
            SqlParameter[] parameters2 = 
            {
                new SqlParameter("@materialid"         , SqlDbType.Int      , 4  ){ Value = iMaterialId                                        },
                new SqlParameter("@buyquantity"        , SqlDbType.Int      , 4  ){ Value = iQuantity                                          },
                new SqlParameter("@buyquantityunit"    , SqlDbType.NVarChar , 50 ){ Value = YWMaterialBLL.GetStdUnitByMaterialId(iMaterialId)  },
                new SqlParameter("@buyweight"          , SqlDbType.Int      , 4  ){ Value = 0                                                  },//目前先填默认值
                new SqlParameter("@buyweightunit"      , SqlDbType.NVarChar , 50 ){ Value = ""                                                 },//目前先填默认值
                new SqlParameter("@buyusername"        , SqlDbType.NVarChar , 50 ){ Value = strUserName                                        },
                new SqlParameter("@buytime"            , SqlDbType.NVarChar , 50 ){ Value = strDateTimeNow                                     },
                new SqlParameter("@buyprice"           , SqlDbType.Int      , 4  ){ Value = dPrice                                             },
                new SqlParameter("@buystateid"         , SqlDbType.Int      , 4  ){ Value = CodeDictionary.BuyingState["已购买"]               },
                new SqlParameter("@orgid"              , SqlDbType.Int      , 4  ){ Value = YWMaterialBLL.GetOrgIdByMaterialId(iMaterialId)    },
                new SqlParameter("@RequirementList"    , SqlDbType.NVarChar , 50 ){ Value = strRequirementId                                   }
            };
            parameter2.Parameters = parameters2;

            //构建YWLog的Parameter对象，根据YWRequirement表的前一条Insert记录Id，SET日志表的业务Id
            Parameter parameter3 = YWLogBLL.GetComplexInsertParameter(CodeDictionary.YWTableType["需求日志"], listId, strUserName, strDateTimeNow, "购买成功");

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);
            parmList.Add(parameter3);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }


        ////根据餐厅机构编号获取采购需求列表
        //public static List<YWRequirement> GetAllListByOrgId(int iOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId ORDER BY [RequirementStateId] DESC,[Id] DESC ";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}
        ////根据餐厅机构编号获取采购需求列表分页
        //public static PageData GetPageDataByOrgId(int pageSize, int curPage, int iOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId ORDER BY [RequirementStateId] DESC,[Id] DESC ";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetPageListByParams(pageSize, curPage, parameter);
        //}

        ////根据餐厅机构编号和原料编号获取采购需求列表
        //public static List<YWRequirement> GetAllListByOrgIdMaterialId(int iOrgId, int iMaterialId, string strState)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId AND [MaterialId]=@MaterialId AND [RequirementStateId] IN (" + strState + ") ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //        new SqlParameter("@MaterialId"   , SqlDbType.Int , 50 ){ Value = iMaterialId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}
        ////根据餐厅机构编号、原料编号和购买者姓名获取采购需求列表
        //public static List<YWRequirement> GetAllListByOrgIdMaterialIdBuyer(int iOrgId, int iMaterialId, string strState, string strBuyer)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId AND [MaterialId]=@MaterialId AND [RequirementStateId] IN (" + strState + ") AND [Backup2]=@Backup2 ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //        new SqlParameter("@MaterialId"   , SqlDbType.Int , 50 ){ Value = iMaterialId},
        //        new SqlParameter("@Backup2"   , SqlDbType.NVarChar , 50 ){ Value = strBuyer},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}
        ////根据多个需求编号获取采购需求列表
        //public static List<YWRequirement> GetAllListByRequirementIds(string strRequirementIds)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [Id] IN (" + strRequirementIds + ")  ORDER BY [Id]";
        //    SqlParameter[] parameters = null;
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}
        ////根据餐厅机构编号和提出人用户名获取采购需求列表（已完成的需求仅显示10天内的）
        //public static List<YWRequirement> GetAllListByOrgIdUserName(int iOrgId, string strUserName)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId AND [ProposeUserName]=@ProposeUserName AND ([RequirementStateId] IN ('32','33','34') OR ([RequirementStateId] = '35' AND CAST([ProposeTime] AS datetime) > @ProposeTime)) ORDER BY [RequirementStateId],[Id] DESC";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //        new SqlParameter("@ProposeUserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
        //        new SqlParameter("@ProposeTime"   , SqlDbType.DateTime , 50 ){ Value = DateTime.Now.AddDays(-7)},
        //    };

        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}
        ////根据餐厅机构编号和提出人用户名获取采购需求列表（今日）
        //public static List<YWRequirement> GetTodayListByOrgIdUserName(int iOrgId, string strUserName)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId AND [ProposeUserName]=@ProposeUserName AND [RequirementStateId] IN ('33','34','35') AND [ProposeTime] LIKE '" + DateTime.Now.ToShortDateString() + "%' ORDER BY [RequirementStateId],[Id] DESC";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //        new SqlParameter("@ProposeUserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
                
        //    };
           
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}
        ////根据餐厅机构编号和提出人用户名获取采购需求列表（往日未完成）
        //public static List<YWRequirement> GetOldListByOrgIdUserName(int iOrgId, string strUserName)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId AND [ProposeUserName]=@ProposeUserName AND [RequirementStateId] IN ('33','34') AND CAST([ProposeTime] AS datetime) < @ProposeTime ORDER BY [RequirementStateId],[Id] DESC";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //        new SqlParameter("@ProposeUserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
        //        new SqlParameter("@ProposeTime"   , SqlDbType.DateTime , 50 ){ Value = DateTime.Now},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}
        ////根据餐厅机构编号和提出人用户名获取采购需求列表（草稿）
        //public static List<YWRequirement> GetDraftListByOrgIdUserName(int iOrgId, string strUserName)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId AND [ProposeUserName]=@ProposeUserName AND [RequirementStateId] = '32' ORDER BY [Id] DESC";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //        new SqlParameter("@ProposeUserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
        //        new SqlParameter("@ProposeTime"   , SqlDbType.NVarChar , 50 ){ Value = DateTime.Now.ToString()},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}
        ////根据餐厅机构编号和提出人用户名获取采购需求列表（未完成）
        //public static List<YWRequirement> GetInProcessListByOrgIdUserName(int iOrgId, string strUserName)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId AND [ProposeUserName]=@ProposeUserName AND [RequirementStateId] IN ('33','34','35') ORDER BY [RequirementStateId],[Id] DESC";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //        new SqlParameter("@ProposeUserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据餐厅机构编号和提出人用户名获取采购需求列表（已完成，仅显示7天内的）
        //public static List<YWRequirement> GetFinishListByOrgIdUserName(int iOrgId, string strUserName)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId AND [ProposeUserName]=@ProposeUserName AND [RequirementStateId] = '36' AND CAST([ProposeTime] AS datetime) > @ProposeTime ORDER BY [Id] DESC";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //        new SqlParameter("@ProposeUserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
        //        new SqlParameter("@ProposeTime"   , SqlDbType.DateTime , 50 ){ Value = DateTime.Now.AddDays(-7)},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据餐厅机构编号获取采购需求列表（合并同类）
        //public static DataTable GetDistinctListByRestaurantOrgIdStateId(int iOrgId, string strStateId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = "SELECT SUM([YWRequirement].[Quantity]) AS [TotalQuantity], SUM([YWRequirement].[Weight]) AS [TotalWeight], COUNT([YWRequirement].[MaterialId]) AS  [TotalRequirement], [YWRequirement].[MaterialId], [YWMaterial].[Name], [YWMaterial].[StdUnit], [YWMaterial].[ShortName], [YWRequirement].[Backup2] ";
        //    parameter.SqlString += "FROM [YWRequirement] INNER JOIN  [YWMaterial] ON [YWRequirement].[MaterialId] = [YWMaterial].[Id] ";
        //    parameter.SqlString += "WHERE [YWRequirement].[RequirementStateId] IN (" + strStateId + ") AND [YWRequirement].[OrgId] = @OrgId ";
        //    parameter.SqlString += "GROUP BY [YWRequirement].[MaterialId], [YWMaterial].[Name], [YWMaterial].[StdUnit], [YWMaterial].[ShortName], [YWRequirement].[Backup2] ";
        //    parameter.SqlString += "ORDER BY [YWRequirement].[Backup2] DESC";
        //    parameter.SqlString += "";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return BLL.CommonToolsBLL.GetDataTableByParams(parameter);
        //}
        ////根据餐厅机构编号和采购用户名获取采购需求列表（合并同类）
        //public static DataTable GetDistinctListByRestaurantOrgIdStateIdNickname(int iOrgId, string strStateId, string strNickname)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = "SELECT SUM([YWRequirement].[Quantity]) AS [TotalQuantity], SUM([YWRequirement].[Weight]) AS [TotalWeight], COUNT([YWRequirement].[MaterialId]) AS  [TotalRequirement], [YWRequirement].[MaterialId], [YWMaterial].[Name], [YWMaterial].[StdUnit], [YWMaterial].[ShortName], [YWRequirement].[Backup2] ";
        //    parameter.SqlString += "FROM [YWRequirement] INNER JOIN  [YWMaterial] ON [YWRequirement].[MaterialId] = [YWMaterial].[Id] ";
        //    parameter.SqlString += "WHERE [YWRequirement].[RequirementStateId] IN (" + strStateId + ") AND [YWRequirement].[OrgId] = @OrgId  AND [YWRequirement].[Backup2] = @Backup2 ";
        //    parameter.SqlString += "GROUP BY [YWRequirement].[MaterialId], [YWMaterial].[Name], [YWMaterial].[StdUnit], [YWMaterial].[ShortName], [YWRequirement].[Backup2] ";
        //    parameter.SqlString += "ORDER BY [YWRequirement].[Backup2] DESC";
        //    parameter.SqlString += "";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //        new SqlParameter("@Backup2"   , SqlDbType.VarChar , 50 ){ Value = strNickname},
        //    };
        //    parameter.Parameters = parameters;

        //    return BLL.CommonToolsBLL.GetDataTableByParams(parameter);
        //}

        
    }
}
