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
    /// 对象名称：预订业务逻辑类（业务逻辑层）
    /// 对象说明：预订管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWBookBLL
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
        internal static DAL.Common.YWBookDAL DataAccess
        {
            get
            {
                return DAL.Common.YWBookDAL.Instance;
            }
        }


        /// <summary>
        /// 对预订（YWBook）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWBook">预订（YWBook）实例对象</param>
        public static void CheckValid(YWBook yWBook)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWBook.BookTable))
                throw new CustomException("“座位”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBook.BookTime))
                throw new CustomException("“预订时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBook.CustomerPhone))
                throw new CustomException("“客户电话”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBook.ReachNumber))
                throw new CustomException("“预计人数”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBook.ReachTime))
                throw new CustomException("“预计到店时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBook.ConsumeTimeBlock))
                throw new CustomException("“消费时间段”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBook.OrderUser))
                throw new CustomException("“接单人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBook.OrderTime))
                throw new CustomException("“接单时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBook.BookOff))
                throw new CustomException("“预订折扣”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBook.BookState))
                throw new CustomException("“预定状态”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWBook.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWBook.BookTime , 50))
                throw new CustomException("“预订时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWBook.CustomerName , 50))
                throw new CustomException("“客户姓名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWBook.CustomerPhone , 50))
                throw new CustomException("“客户电话”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWBook.ReachTime , 50))
                throw new CustomException("“预计到店时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWBook.OrderUser , 50))
                throw new CustomException("“接单人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWBook.OrderTime , 50))
                throw new CustomException("“接单时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将预订（YWBook）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWBook">预订（YWBook）实例对象</param>
        public static int Insert(YWBook yWBook)
        {
            CheckValid(yWBook);
            return DataAccess.Insert(yWBook);
        }


        /// <summary>
        /// 将预订（YWBook）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWBook">预订（YWBook）实例对象</param>
        public static int Update(YWBook yWBook)
        {
            CheckValid(yWBook);
            return DataAccess.Update(yWBook);
        }


        /// <summary>
        /// 根据预订（YWBook）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">预订（YWBook）的主键“编号（Id）”</param>
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
        /// 根据预订（YWBook）的主键“编号（Id）”从数据库中获取预订（YWBook）的实例。
        /// 成功从数据库中取得记录返回新预订（YWBook）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">预订（YWBook）的主键“编号（Id）”</param>
        public static YWBook GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据预订（YWBook）的主键“编号（Id）”从数据库中获取预订（YWBook）的实例。
        /// 成功从数据库中取得记录返回新预订（YWBook）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">预订（YWBook）的主键“编号（Id）”</param>
        public static YWBook GetDataById(string id)
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
        //根据Id获取预定记录当前状态
        public static int GetBookSateById(int iBookId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [BookStateId] FROM [YWBook] WHERE [Id]=@BookId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@BookId"          , SqlDbType.Int      , 4         ){ Value = iBookId     }
            };
            parameter.Parameters = parameters;
            return Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }

        //add by chr
        //获取系统所有预定记录列表
        public static PageData GetSystemBookList(int iPageSize, int iCurPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWBook].[Id],[YWTable].[Name] AS [TableName],[YWBook].[BookTime],[YWBook].[CustomerName],[YWBook].[CustomerPhone],"
                                + "[YWBook].[ReachNumber],[YWBook].[ReachTime],[YWDictionary1].[Name] AS [ConsumeTimeBlock],[PT_USER].[Nickname] AS [OrderUserName],"
                                + "[YWBook].[OrderTime],[YWBook].[BookOff],[YWDictionary2].[Name] AS [BookStateName],[PT_ORG].[OrgName] AS [OrgName] "
                                + "FROM [YWBook] "
                                + "LEFT JOIN [YWTable] ON [YWBook].[BookTableId] = [YWTable].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWBook].[ConsumeTimeBlockId] = [YWDictionary1].[Id] "
                                + "LEFT JOIN [PT_USER] ON [YWBook].[OrderUserName] = [PT_USER].[UserName] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWBook].[BookStateId] = [YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWBook].[OrgId] = [PT_ORG].[Id] ";
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据用户名获取本店预定列表数据
        public static PageData GetBookListByUserName(string strBookingType, string strUserName, string strDateTimeNow, int iPageSize, int iCurPage)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWBook].[Id],[YWTable].[Name] AS [TableName],[YWBook].[BookTime],[YWBook].[CustomerName],[YWBook].[CustomerPhone],"
                                + "[YWBook].[ReachNumber],[YWBook].[ReachTime],[YWDictionary1].[Name] AS [ConsumeTimeBlock],[PT_USER].[Nickname] AS [OrderUserName],"
                                + "[YWBook].[OrderTime],[YWBook].[BookOff],[YWDictionary2].[Name] AS [BookStateName],[PT_ORG].[OrgName] AS [OrgName] "
                                + "FROM [YWBook] "
                                + "LEFT JOIN [YWTable] ON [YWBook].[BookTableId] = [YWTable].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWBook].[ConsumeTimeBlockId] = [YWDictionary1].[Id] "
                                + "LEFT JOIN [PT_USER] ON [YWBook].[OrderUserName] = [PT_USER].[UserName] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWBook].[BookStateId] = [YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWBook].[OrgId] = [PT_ORG].[Id] "
                                + "WHERE [YWBook].[OrgId] = @OrgId ";
            switch (strBookingType)
            {
                case "All":
                    parameter.SqlString += "AND [YWBook].[BookTime] + ' ' + [YWDictionary1].[Backup3] >= @DateTimeNow ";
                    break;
                case "Current":
                    parameter.SqlString += "AND (@DateTimeNow BETWEEN [YWBook].[BookTime] + ' ' + [YWDictionary1].[Backup2] AND [YWBook].[BookTime] + ' ' + [YWDictionary1].[Backup3]) ";
                    break;
                case "Mine":
                    parameter.SqlString += "AND [YWBook].[BookTime] + ' ' + [YWDictionary1].[Backup3] >= @DateTimeNow AND [YWBook].[OrderUserName] = @UserName ";
                    break;
            }
            parameter.SqlString += "AND [YWBook].[BookStateId] IN (@State1, @State2) ";
            parameter.SqlString += "ORDER BY [YWBook].[BookTime] + ' ' + [YWBook].[ReachTime]";

            SqlParameter[] parameters;
            if (strBookingType == "All" || strBookingType == "Current")
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@OrgId"        , SqlDbType.Int      , 4  ){ Value = iOrgId                            },
                    new SqlParameter("@DateTimeNow"  , SqlDbType.NVarChar , 50 ){ Value = strDateTimeNow                    },
                    new SqlParameter("@State1"       , SqlDbType.Int      , 4  ){ Value = CodeDictionary.BookState["已预订"]},
                    new SqlParameter("@State2"       , SqlDbType.Int      , 4  ){ Value = CodeDictionary.BookState["已到店"]}
                };
            }
            else
            {
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@OrgId"        , SqlDbType.Int      , 4  ){ Value = iOrgId                            },
                    new SqlParameter("@DateTimeNow"  , SqlDbType.NVarChar , 50 ){ Value = strDateTimeNow                    },
                    new SqlParameter("@State1"       , SqlDbType.Int      , 4  ){ Value = CodeDictionary.BookState["已预订"]},
                    new SqlParameter("@State2"       , SqlDbType.Int      , 4  ){ Value = CodeDictionary.BookState["已到店"]},
                    new SqlParameter("@UserName"     , SqlDbType.NVarChar , 50 ){ Value = strUserName                       }
                };
            }
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //检查是否存在重复预定记录
        public static Boolean CheckBookDataDuplicate(int iBookTableId, string strBookTime, int iConsumeTimeBlockId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT COUNT(*) FROM [YWBook] WHERE [BookTableId] = @BookTableId AND [BookTime] = @BookTime AND [ConsumeTimeBlockId] = @ConsumeTimeBlockId ";
 
            SqlParameter[] parameters = 
            {
                new SqlParameter("@BookTableId"        , SqlDbType.Int      , 4         ){ Value = iBookTableId             },
                new SqlParameter("@BookTime"           , SqlDbType.NVarChar , 50        ){ Value = strBookTime              },
                new SqlParameter("@ConsumeTimeBlockId" , SqlDbType.Int      , 4         ){ Value = iConsumeTimeBlockId      }
            };
            parameter.Parameters = parameters;

          if(Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter)) > 0)
              return true;
          else
              return false;
        }

        //add by chr
        //根据预订单ID，把预订单状态设置为已到店
        public static void UpdateBookStateIdById(string strBookId)
        {
            //检查点记录数
            int iCheckPoint = strBookId.Split(',').Length;
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWBook] SET [BookStateId] = @BookStateId WHERE [Id] IN (" + strBookId + ") ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@BookStateId"     , SqlDbType.Int     , 4         ){ Value = CodeDictionary.BookState["已到店"]   }
            };
            parameter.Parameters = parameters;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }
    }
}
