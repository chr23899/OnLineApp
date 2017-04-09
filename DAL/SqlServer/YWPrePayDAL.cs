using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using OnlineApp.COL;
using OnlineApp.SFL;

namespace OnlineApp.DAL.SqlServer
{
    /// <summary>
    /// 对象名称：预支SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“预支类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“预支类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWPrePayDAL:DAL.Common.YWPrePayDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将预支（YWPrePay）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPrePay">预支（YWPrePay）实例对象</param>
        public override int Insert(YWPrePay yWPrePay)
        {
            string sqlText = "INSERT INTO [YWPrePay]"
                           + "([LentTypeId],[LentCauseId],[LentAmount],[LentTime],[AboutReturnTime],[BorrowUserName],[ConfirmUserName],[PayUserName],"
                           + "[ReturnAmount],[StateId],[Notes],[OrgId])"
                           + "VALUES"
                           + "(@LentTypeId,@LentCauseId,@LentAmount,@LentTime,@AboutReturnTime,@BorrowUserName,@ConfirmUserName,@PayUserName,"
                           + "@ReturnAmount,@StateId,@Notes,@OrgId)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@LentTypeId"          , SqlDbType.Int      , 4         ){ Value = yWPrePay.LentType             },
                new SqlParameter("@LentCauseId"         , SqlDbType.Int      , 4         ){ Value = yWPrePay.LentCause            },
                new SqlParameter("@LentAmount"          , SqlDbType.Decimal  , 9         ){ Value = yWPrePay.LentAmount           },
                new SqlParameter("@LentTime"            , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.LentTime             },
                new SqlParameter("@AboutReturnTime"     , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.AboutReturnTime      },
                new SqlParameter("@BorrowUserName"      , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.BorrowUser           },
                new SqlParameter("@ConfirmUserName"     , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.ConfirmUser          },
                new SqlParameter("@PayUserName"         , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.PayUser              },
                new SqlParameter("@ReturnAmount"        , SqlDbType.Decimal  , 9         ){ Value = yWPrePay.ReturnAmount         },
                new SqlParameter("@StateId"             , SqlDbType.Int      , 4         ){ Value = yWPrePay.State                },
                new SqlParameter("@Notes"               , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.Notes                },
                new SqlParameter("@OrgId"               , SqlDbType.Int      , 4         ){ Value = yWPrePay.Org                  }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将预支（YWPrePay）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPrePay">预支（YWPrePay）实例对象</param>
        public override int Update(YWPrePay yWPrePay)
        {
            string sqlText = "UPDATE [YWPrePay] SET "
                           + "[LentTypeId]=@LentTypeId,[LentCauseId]=@LentCauseId,[LentAmount]=@LentAmount,[LentTime]=@LentTime,"
                           + "[AboutReturnTime]=@AboutReturnTime,[BorrowUserName]=@BorrowUserName,[ConfirmUserName]=@ConfirmUserName,[PayUserName]=@PayUserName,"
                           + "[ReturnAmount]=@ReturnAmount,[StateId]=@StateId,[Notes]=@Notes,[OrgId]=@OrgId "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@LentTypeId"          , SqlDbType.Int      , 4         ){ Value = yWPrePay.LentType             },
                new SqlParameter("@LentCauseId"         , SqlDbType.Int      , 4         ){ Value = yWPrePay.LentCause            },
                new SqlParameter("@LentAmount"          , SqlDbType.Decimal  , 9         ){ Value = yWPrePay.LentAmount           },
                new SqlParameter("@LentTime"            , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.LentTime             },
                new SqlParameter("@AboutReturnTime"     , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.AboutReturnTime      },
                new SqlParameter("@BorrowUserName"      , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.BorrowUser           },
                new SqlParameter("@ConfirmUserName"     , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.ConfirmUser          },
                new SqlParameter("@PayUserName"         , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.PayUser              },
                new SqlParameter("@ReturnAmount"        , SqlDbType.Decimal  , 9         ){ Value = yWPrePay.ReturnAmount         },
                new SqlParameter("@StateId"             , SqlDbType.Int      , 4         ){ Value = yWPrePay.State                },
                new SqlParameter("@Notes"               , SqlDbType.NVarChar , 50        ){ Value = yWPrePay.Notes                },
                new SqlParameter("@OrgId"               , SqlDbType.Int      , 4         ){ Value = yWPrePay.Org                  },
                new SqlParameter("@Id"                  , SqlDbType.Int      , 4         ){ Value = yWPrePay.Id                   }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据预支（YWPrePay）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">预支（YWPrePay）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YWPrePay] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据条件参数采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="paramList">条件参数</param>
        public override int DeleteByParams(Parameter paramList)
        {
            if (paramList.SqlString == " WHERE")
            {
                return 0;
            }
            string sqlText = "DELETE FROM [YWPrePay] "
                           + paramList.SqlString;
           
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, paramList.Parameters);
        }


        /// <summary>
        /// 根据预支（YWPrePay）的主键“编号（Id）”从数据库中获取预支（YWPrePay）的实例。
        /// 成功从数据库中取得记录返回新预支（YWPrePay）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">预支（YWPrePay）的主键“编号（Id）”</param>
        public override YWPrePay GetDataById(int id)
        {
            YWPrePay yWPrePay = null;
            string sqlText = "SELECT [Id],[LentTypeId],[LentCauseId],[LentAmount],[LentTime],[AboutReturnTime],[BorrowUserName],[ConfirmUserName],[PayUserName],"
                           + "[ReturnAmount],[StateId],[Notes],[OrgId] "
                           + "FROM [YWPrePay] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWPrePay = new YWPrePay();
                ReadYWPrePayAllData(sqlDataReader,yWPrePay);
            }
            sqlDataReader.Close();
            return yWPrePay;
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

    }
}
