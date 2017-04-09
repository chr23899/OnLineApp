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
    /// 对象名称：还款业务逻辑类（业务逻辑层）
    /// 对象说明：还款管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWPayBackBLL
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
        internal static DAL.Common.YWPayBackDAL DataAccess
        {
            get
            {
                return DAL.Common.YWPayBackDAL.Instance;
            }
        }


        /// <summary>
        /// 对还款（YWPayBack）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWPayBack">还款（YWPayBack）实例对象</param>
        public static void CheckValid(YWPayBack yWPayBack)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWPayBack.PrePay))
                throw new CustomException("“关联预支”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPayBack.ReturnAmount))
                throw new CustomException("“还款金额”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPayBack.ReturnTime))
                throw new CustomException("“还款时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPayBack.ReturnUser))
                throw new CustomException("“还款人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPayBack.ReceiveUser))
                throw new CustomException("“收款人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWPayBack.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWPayBack.ReturnTime , 50))
                throw new CustomException("“还款时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPayBack.ReturnUser , 50))
                throw new CustomException("“还款人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPayBack.ReceiveUser , 50))
                throw new CustomException("“收款人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWPayBack.Notes , 50))
                throw new CustomException("“备注”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将还款（YWPayBack）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPayBack">还款（YWPayBack）实例对象</param>
        public static int Insert(YWPayBack yWPayBack)
        {
            CheckValid(yWPayBack);
            return DataAccess.Insert(yWPayBack);
        }


        /// <summary>
        /// 将还款（YWPayBack）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPayBack">还款（YWPayBack）实例对象</param>
        public static int Update(YWPayBack yWPayBack)
        {
            CheckValid(yWPayBack);
            return DataAccess.Update(yWPayBack);
        }


        /// <summary>
        /// 根据还款（YWPayBack）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">还款（YWPayBack）的主键“编号（Id）”</param>
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
        /// 根据还款（YWPayBack）的主键“编号（Id）”从数据库中获取还款（YWPayBack）的实例。
        /// 成功从数据库中取得记录返回新还款（YWPayBack）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">还款（YWPayBack）的主键“编号（Id）”</param>
        public static YWPayBack GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据还款（YWPayBack）的主键“编号（Id）”从数据库中获取还款（YWPayBack）的实例。
        /// 成功从数据库中取得记录返回新还款（YWPayBack）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">还款（YWPayBack）的主键“编号（Id）”</param>
        public static YWPayBack GetDataById(string id)
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
        //获取系统所有还款记录列表
        public static PageData GetSystemPayBackList(int iPageSize, int iCurPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWPayBack].[Id],[YWPayBack].[PrePayId],[YWPayBack].[ReturnAmount],[YWPayBack].[ReturnTime],"
                                + "[PT_User1].[NickName] AS [ReturnUserName],[PT_User2].[NickName] AS [ReceiveUserName],[YWPayBack].[Notes],[PT_Org].[OrgName] "
                                + "FROM [YWPayBack] "
                                + "LEFT JOIN [PT_User] AS [PT_User1] ON [YWPayBack].[ReturnUserName]=[PT_User1].[UserName] "
                                + "LEFT JOIN [PT_User] AS [PT_User2] ON [YWPayBack].[ReceiveUserName]=[PT_User2].[UserName] "
                                + "LEFT JOIN [PT_Org] ON [YWPayBack].[OrgId]=[PT_Org].[Id] ";

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }


        //add by chr
        //根据预支记录ID完成还款
        public static void InsertPayBackDataByPrePayId(int iPrePayId, double douReturnAmount, string strConfirmUserName, string strNotes, string strDateNow)
        {
            //获取预支记录对象
            YWPrePay ywPrePay = YWPrePayBLL.GetDataById(iPrePayId);
            //根据还款额判断状态是否要更新为部分归还
            int iStateId;
            if (ywPrePay.LentAmount > douReturnAmount)
            {
                iStateId = CodeDictionary.LentState["部分归还"];
            }
            else
            {
                iStateId = CodeDictionary.LentState["还款完成"];
            }

            //构建Parameter
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWPrePay] "
                                 + "SET [ConfirmUserName]=@ConfirmUserName,[ReturnAmount]=@ReturnAmount,Notes=@Notes,[StateId]=@ToStateId "
                                 + "WHERE [Id]=@Id AND [StateId]=@FromStateId ";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@ConfirmUserName"   , SqlDbType.NVarChar , 50        ){ Value = strConfirmUserName                  },
                new SqlParameter("@ReturnAmount"      , SqlDbType.Int      , 4         ){ Value = douReturnAmount                     },
                new SqlParameter("@Notes"             , SqlDbType.NVarChar , 50        ){ Value = strNotes                            },
                new SqlParameter("@FromStateId"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.LentState["已借出"]  },
                new SqlParameter("@ToStateId"         , SqlDbType.Int      , 4         ){ Value = iStateId                            },
                new SqlParameter("@Id"                , SqlDbType.Int      , 4         ){ Value = iPrePayId                           }
            };
            parameter1.Parameters = parameters1;

            //构建Parameter
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = "INSERT INTO [YWPayBack] "
                                 + "([PrePayId],[ReturnAmount],[ReturnTime],[ReturnUserName],[ReceiveUserName],[Notes],[OrgId]) "
                                 + "VALUES "
                                 + "(@PrePayId,@ReturnAmount,@ReturnTime,@ReturnUserName,@ReceiveUserName,@Notes,@OrgId)";
            SqlParameter[] parameters2 = 
            {
                new SqlParameter("@PrePayId"            , SqlDbType.Int      , 4         ){ Value = iPrePayId                           },
                new SqlParameter("@ReturnAmount"        , SqlDbType.Decimal  , 9         ){ Value = douReturnAmount                     },
                new SqlParameter("@ReturnTime"          , SqlDbType.NVarChar , 50        ){ Value = strDateNow                          },
                new SqlParameter("@ReturnUserName"      , SqlDbType.NVarChar , 50        ){ Value = ywPrePay.BorrowUser                 },
                new SqlParameter("@ReceiveUserName"     , SqlDbType.NVarChar , 50        ){ Value = strConfirmUserName                  },
                new SqlParameter("@Notes"               , SqlDbType.NVarChar , 50        ){ Value = strNotes                            },
                new SqlParameter("@OrgId"               , SqlDbType.Int      , 4         ){ Value = ywPrePay.Org                        }
            };
            parameter2.Parameters = parameters2;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);

            CommonToolsBLL.ExcuteSqlWithTransaction(parmList);
        }
    }
}
