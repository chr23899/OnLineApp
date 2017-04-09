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
    /// 对象名称：预支业务逻辑类（业务逻辑层）
    /// 对象说明：预支管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWPrePayBLL
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
        internal static DAL.Common.YWPrePayDAL DataAccess
        {
            get
            {
                return DAL.Common.YWPrePayDAL.Instance;
            }
        }


        /// <summary>
        /// 对预支（YWPrePay）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWPrePay">预支（YWPrePay）实例对象</param>
        public static void CheckValid(YWPrePay yWPrePay)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWPrePay.LentType))
                throw new CustomException("“借款类型”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPrePay.LentCause))
                throw new CustomException("“借款原因”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPrePay.LentAmount))
                throw new CustomException("“预支金额”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPrePay.LentTime))
                throw new CustomException("“预支时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPrePay.AboutReturnTime))
                throw new CustomException("“预计归还时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPrePay.BorrowUser))
                throw new CustomException("“预支人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPrePay.ConfirmUser))
                throw new CustomException("“批准人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPrePay.PayUser))
                throw new CustomException("“付款人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPrePay.ReturnAmount))
                throw new CustomException("“已还金额”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPrePay.State))
                throw new CustomException("“状态”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPrePay.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWPrePay.LentTime , 50))
                throw new CustomException("“预支时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPrePay.AboutReturnTime , 50))
                throw new CustomException("“预计归还时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPrePay.BorrowUser , 50))
                throw new CustomException("“预支人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPrePay.ConfirmUser , 50))
                throw new CustomException("“批准人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPrePay.PayUser , 50))
                throw new CustomException("“付款人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPrePay.Notes , 50))
                throw new CustomException("“备注”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将预支（YWPrePay）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPrePay">预支（YWPrePay）实例对象</param>
        public static int Insert(YWPrePay yWPrePay)
        {
            CheckValid(yWPrePay);
            return DataAccess.Insert(yWPrePay);
        }


        /// <summary>
        /// 将预支（YWPrePay）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPrePay">预支（YWPrePay）实例对象</param>
        public static int Update(YWPrePay yWPrePay)
        {
            CheckValid(yWPrePay);
            return DataAccess.Update(yWPrePay);
        }


        /// <summary>
        /// 根据预支（YWPrePay）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">预支（YWPrePay）的主键“编号（Id）”</param>
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
        /// 根据预支（YWPrePay）的主键“编号（Id）”从数据库中获取预支（YWPrePay）的实例。
        /// 成功从数据库中取得记录返回新预支（YWPrePay）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">预支（YWPrePay）的主键“编号（Id）”</param>
        public static YWPrePay GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据预支（YWPrePay）的主键“编号（Id）”从数据库中获取预支（YWPrePay）的实例。
        /// 成功从数据库中取得记录返回新预支（YWPrePay）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">预支（YWPrePay）的主键“编号（Id）”</param>
        public static YWPrePay GetDataById(string id)
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
        //检查用户是否存在未归还的预支记录
        public static Boolean CheckIsExistNotReturnedPrePayList(string strUserName)
        {
            //获取所属饭店的组织机构Id
            int iResOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT COUNT(*) FROM [YWPrePay] WHERE [YWPrePay].[OrgId]=@OrgId AND [YWPrePay].[BorrowUserName]=@BorrowUserName AND [YWPrePay].[StateId]<>@StateId ";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"            , SqlDbType.Int      , 4         ){ Value = iResOrgId                            },
                new SqlParameter("@BorrowUserName"   , SqlDbType.NVarChar , 50        ){ Value = strUserName                          },
                new SqlParameter("@StateId"          , SqlDbType.Int      , 4         ){ Value = CodeDictionary.LentState["还款完成"] }
            };
            parameter.Parameters = parameters;

            if (Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter)) > 0)
                return true;
            else
                return false;
        }

        //add by chr
        //获取系统所有预支记录列表
        public static PageData GetSystemPrePayList(int pageSize, int curPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWPrePay].[Id],[YWPrePay].[LentTypeId],[YWDictionary1].[Name] AS [LentTypeName],[YWPrePay].[LentCauseId],"
                                + "[YWDictionary2].[Name] AS [LentCauseName],[YWPrePay].[LentAmount],[YWPrePay].[LentTime],[YWPrePay].[AboutReturnTime],"
                                + "[PT_USER1].[NickName] AS [BorrowUserName],[PT_USER2].[NickName] AS [ConfirmUserName],[PT_USER3].[NickName] AS [PayUserName],"
                                + "[YWPrePay].[ReturnAmount],[YWPrePay].[StateId],[YWDictionary1].[Name] AS [StateName],[YWPrePay].[Notes],[YWPrePay].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [YWPrePay] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWPrePay].[LentTypeId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWPrePay].[LentCauseId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWPrePay].[StateId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWPrePay].[BorrowUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWPrePay].[ConfirmUserName]=[PT_USER2].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER3] ON [YWPrePay].[PayUserName]=[PT_USER3].[UserName] "
                                + "LEFT JOIN [PT_ORG] ON [YWPrePay].[OrgId]=[PT_ORG].[Id] ";
          
            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }

        //add by chr
        //根据用户名获取我的预支列表
        public static PageData GetMyPrePayListByUserName(int pageSize, int curPage, string strUserName, string strType)
        {
            //获取所属饭店的组织机构Id
            int iResOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //状态Id
            int iStateId;
            switch (strType)
            {
                case "InApply":
                    iStateId = CodeDictionary.LentState["申请中"];
                    break;
                case "LentOut":
                    iStateId = CodeDictionary.LentState["已借出"];
                    break;
                case "ReturnPart":
                    iStateId = CodeDictionary.LentState["部分归还"];
                    break;
                default:
                    iStateId = 0;
                    break;
            }
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWPrePay].[Id],[YWPrePay].[LentTypeId],[YWDictionary1].[Name] AS [LentTypeName],[YWPrePay].[LentCauseId],"
                                + "[YWDictionary2].[Name] AS [LentCauseName],[YWPrePay].[LentAmount],[YWPrePay].[LentTime],[YWPrePay].[AboutReturnTime],"
                                + "[PT_USER1].[NickName] AS [BorrowUserName],[PT_USER2].[NickName] AS [ConfirmUserName],[PT_USER3].[NickName] AS [PayUserName],"
                                + "[YWPrePay].[ReturnAmount],[YWPrePay].[StateId],[YWDictionary1].[Name] AS [StateName],[YWPrePay].[Notes],[YWPrePay].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [YWPrePay] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWPrePay].[LentTypeId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWPrePay].[LentCauseId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWPrePay].[StateId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWPrePay].[BorrowUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWPrePay].[ConfirmUserName]=[PT_USER2].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER3] ON [YWPrePay].[PayUserName]=[PT_USER3].[UserName] "
                                + "LEFT JOIN [PT_ORG] ON [YWPrePay].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWPrePay].[OrgId]=@OrgId AND [YWPrePay].[BorrowUserName]=@UserName AND [YWPrePay].[StateId]=@StateId ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"      , SqlDbType.Int        , 4         ){ Value = iResOrgId             },
                new SqlParameter("@UserName"   , SqlDbType.NVarChar   , 50        ){ Value = strUserName           },
                new SqlParameter("@StateId"    , SqlDbType.Int        , 4         ){ Value = iStateId              }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }


        //add by chr
        //根据用户名获取饭店预支列表
        public static PageData GetPrePayListByUserName(int pageSize, int curPage, string strUserName, string strType, string strDateNow)
        {
            //获取所属饭店的组织机构Id
            int iResOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWPrePay].[Id],[YWPrePay].[LentTypeId],[YWDictionary1].[Name] AS [LentTypeName],[YWPrePay].[LentCauseId],"
                                + "[YWDictionary2].[Name] AS [LentCauseName],[YWPrePay].[LentAmount],[YWPrePay].[LentTime],[YWPrePay].[AboutReturnTime],"
                                + "[PT_USER1].[NickName] AS [BorrowUserName],[PT_USER2].[NickName] AS [ConfirmUserName],[PT_USER3].[NickName] AS [PayUserName],"
                                + "[YWPrePay].[ReturnAmount],[YWPrePay].[StateId],[YWDictionary1].[Name] AS [StateName],[YWPrePay].[Notes],[YWPrePay].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [YWPrePay] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWPrePay].[LentTypeId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWPrePay].[LentCauseId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWPrePay].[StateId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWPrePay].[BorrowUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWPrePay].[ConfirmUserName]=[PT_USER2].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER3] ON [YWPrePay].[PayUserName]=[PT_USER3].[UserName] "
                                + "LEFT JOIN [PT_ORG] ON [YWPrePay].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWPrePay].[OrgId]=@OrgId AND [YWPrePay].[StateId]=@StateId ";
            //状态Id
            int iStateId;
            switch (strType)
            {
                case "InApply":
                    iStateId = CodeDictionary.LentState["申请中"];
                    break;
                case "TodayLentOut":
                    iStateId = CodeDictionary.LentState["已借出"];
                    parameter.SqlString += "AND [YWPrePay].[LentTime]='" + strDateNow + "'";
                    break;
                default:
                    iStateId = 0;
                    break;
            }
            
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"      , SqlDbType.Int        , 4         ){ Value = iResOrgId             },
                new SqlParameter("@StateId"    , SqlDbType.Int        , 4         ){ Value = iStateId              }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }

        //add by chr
        //根据用户名获取饭店预支列表
        public static PageData GetWaitReturnPrePayListByUserName(int pageSize, int curPage, string strUserName)
        {
            //获取所属饭店的组织机构Id
            int iResOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWPrePay].[Id],[YWPrePay].[LentTypeId],[YWDictionary1].[Name] AS [LentTypeName],[YWPrePay].[LentCauseId],"
                                + "[YWDictionary2].[Name] AS [LentCauseName],[YWPrePay].[LentAmount],[YWPrePay].[LentTime],[YWPrePay].[AboutReturnTime],"
                                + "[PT_USER1].[NickName] AS [BorrowUserName],[PT_USER2].[NickName] AS [ConfirmUserName],[PT_USER3].[NickName] AS [PayUserName],"
                                + "[YWPrePay].[ReturnAmount],[YWPrePay].[StateId],[YWDictionary1].[Name] AS [StateName],[YWPrePay].[Notes],[YWPrePay].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [YWPrePay] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWPrePay].[LentTypeId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWPrePay].[LentCauseId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWPrePay].[StateId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWPrePay].[BorrowUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWPrePay].[ConfirmUserName]=[PT_USER2].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER3] ON [YWPrePay].[PayUserName]=[PT_USER3].[UserName] "
                                + "LEFT JOIN [PT_ORG] ON [YWPrePay].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWPrePay].[OrgId]=@OrgId AND [YWPrePay].[StateId] IN (@StateId1, @StateId2) ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"      , SqlDbType.Int        , 4         ){ Value = iResOrgId                             },
                new SqlParameter("@StateId1"   , SqlDbType.Int        , 4         ){ Value = CodeDictionary.LentState["已借出"]    },
                new SqlParameter("@StateId2"   , SqlDbType.Int        , 4         ){ Value = CodeDictionary.LentState["部分归还"]  }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetPageListByParams(pageSize, curPage, parameter);
        }


        //add by chr
        //根据预支记录ID完成付款
        public static int CompleteLentOutById(string strPrePayId, string strUserName, string strLentAmount, string strNotes, string strDateNow)
        {
            //构建Parameter
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWPrePay] "
                                + "SET [LentAmount]=@LentAmount,[LentTime]=@LentTime,[PayUserName]=@PayUserName,Notes=@Notes,[StateId]=@ToStateId "
                                + "WHERE [Id]=@Id AND [StateId]=@FromStateId ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@LentAmount"        , SqlDbType.Decimal  , 9         ){ Value = Convert.ToDouble(strLentAmount)     },
                new SqlParameter("@LentTime"          , SqlDbType.NVarChar , 50        ){ Value = strDateNow                          },
                new SqlParameter("@PayUserName"       , SqlDbType.NVarChar , 50        ){ Value = strUserName                         },
                new SqlParameter("@Notes"             , SqlDbType.NVarChar , 50        ){ Value = strNotes                            },
                new SqlParameter("@FromStateId"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.LentState["申请中"]  },
                new SqlParameter("@ToStateId"         , SqlDbType.Int      , 4         ){ Value = CodeDictionary.LentState["已借出"]  },
                new SqlParameter("@Id"                , SqlDbType.Int      , 4         ){ Value = Convert.ToInt32(strPrePayId)        }
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.ExcuteSql(parameter);
        }


        //add by chr
        //删除预支记录
        public static void DeletePrePayDataById(string strPrePayId)
        {
            //检查点记录数
            int iCheckPoint = strPrePayId.Split(',').Length;
            Parameter parameter = new Parameter();
            parameter.SqlString = "DELETE FROM [YWPrePay] WHERE [Id] IN (" + strPrePayId + ") ";

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);
            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }


        ////根据餐厅机构编号获取预支列表
        //public static List<YWPrePay> GetAllListByOrgId(int iOrgId)
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



    }
}
