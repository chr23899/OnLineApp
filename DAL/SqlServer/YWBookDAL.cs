using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using Chr.OnlineApp.COL;
using Chr.OnlineApp.SFL;

namespace Chr.OnlineApp.DAL.SqlServer
{
    /// <summary>
    /// 对象名称：预订SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“预订类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“预订类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWBookDAL:DAL.Common.YWBookDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将预订（YWBook）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWBook">预订（YWBook）实例对象</param>
        public override int Insert(YWBook yWBook)
        {
            string sqlText = "INSERT INTO [YWBook]"
                           + "([BookTableId],[BookTime],[CustomerName],[CustomerPhone],[ReachNumber],[ReachTime],[ConsumeTimeBlockId],[OrderUserName],[OrderTime],"
                           + "[BookOff],[BookStateId],[OrgId])"
                           + "VALUES"
                           + "(@BookTableId,@BookTime,@CustomerName,@CustomerPhone,@ReachNumber,@ReachTime,@ConsumeTimeBlockId,@OrderUserName,@OrderTime,"
                           + "@BookOff,@BookStateId,@OrgId)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@BookTableId"        , SqlDbType.Int      , 4         ){ Value = yWBook.BookTable           },
                new SqlParameter("@BookTime"           , SqlDbType.NVarChar , 50        ){ Value = yWBook.BookTime            },
                new SqlParameter("@CustomerName"       , SqlDbType.NVarChar , 50        ){ Value = yWBook.CustomerName        },
                new SqlParameter("@CustomerPhone"      , SqlDbType.NVarChar , 50        ){ Value = yWBook.CustomerPhone       },
                new SqlParameter("@ReachNumber"        , SqlDbType.Int      , 4         ){ Value = yWBook.ReachNumber         },
                new SqlParameter("@ReachTime"          , SqlDbType.NVarChar , 50        ){ Value = yWBook.ReachTime           },
                new SqlParameter("@ConsumeTimeBlockId" , SqlDbType.Int      , 4         ){ Value = yWBook.ConsumeTimeBlock    },
                new SqlParameter("@OrderUserName"      , SqlDbType.NVarChar , 50        ){ Value = yWBook.OrderUser           },
                new SqlParameter("@OrderTime"          , SqlDbType.NVarChar , 50        ){ Value = yWBook.OrderTime           },
                new SqlParameter("@BookOff"            , SqlDbType.Decimal  , 9         ){ Value = yWBook.BookOff             },
                new SqlParameter("@BookStateId"        , SqlDbType.Int      , 4         ){ Value = yWBook.BookState           },
                new SqlParameter("@OrgId"              , SqlDbType.Int      , 4         ){ Value = yWBook.Org                 }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将预订（YWBook）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWBook">预订（YWBook）实例对象</param>
        public override int Update(YWBook yWBook)
        {
            string sqlText = "UPDATE [YWBook] SET "
                           + "[BookTableId]=@BookTableId,[BookTime]=@BookTime,[CustomerName]=@CustomerName,[CustomerPhone]=@CustomerPhone,"
                           + "[ReachNumber]=@ReachNumber,[ReachTime]=@ReachTime,[ConsumeTimeBlockId]=@ConsumeTimeBlockId,[OrderUserName]=@OrderUserName,[OrderTime]=@OrderTime,"
                           + "[BookOff]=@BookOff,[BookStateId]=@BookStateId,[OrgId]=@OrgId "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@BookTableId"        , SqlDbType.Int      , 4         ){ Value = yWBook.BookTable           },
                new SqlParameter("@BookTime"           , SqlDbType.NVarChar , 50        ){ Value = yWBook.BookTime            },
                new SqlParameter("@CustomerName"       , SqlDbType.NVarChar , 50        ){ Value = yWBook.CustomerName        },
                new SqlParameter("@CustomerPhone"      , SqlDbType.NVarChar , 50        ){ Value = yWBook.CustomerPhone       },
                new SqlParameter("@ReachNumber"        , SqlDbType.Int      , 4         ){ Value = yWBook.ReachNumber         },
                new SqlParameter("@ReachTime"          , SqlDbType.NVarChar , 50        ){ Value = yWBook.ReachTime           },
                new SqlParameter("@ConsumeTimeBlockId" , SqlDbType.Int      , 4         ){ Value = yWBook.ConsumeTimeBlock    },
                new SqlParameter("@OrderUserName"      , SqlDbType.NVarChar , 50        ){ Value = yWBook.OrderUser           },
                new SqlParameter("@OrderTime"          , SqlDbType.NVarChar , 50        ){ Value = yWBook.OrderTime           },
                new SqlParameter("@BookOff"            , SqlDbType.Decimal  , 9         ){ Value = yWBook.BookOff             },
                new SqlParameter("@BookStateId"        , SqlDbType.Int      , 4         ){ Value = yWBook.BookState           },
                new SqlParameter("@OrgId"              , SqlDbType.Int      , 4         ){ Value = yWBook.Org                 },
                new SqlParameter("@Id"                 , SqlDbType.Int      , 4         ){ Value = yWBook.Id                  }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据预订（YWBook）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">预订（YWBook）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YWBook] "
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
            string sqlText = "DELETE FROM [YWBook] "
                           + paramList.SqlString;

            return SFL.SqlHelper.ExecuteNonQuery(sqlText, paramList.Parameters);
        }


        /// <summary>
        /// 根据预订（YWBook）的主键“编号（Id）”从数据库中获取预订（YWBook）的实例。
        /// 成功从数据库中取得记录返回新预订（YWBook）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">预订（YWBook）的主键“编号（Id）”</param>
        public override YWBook GetDataById(int id)
        {
            YWBook yWBook = null;
            string sqlText = "SELECT [Id],[BookTableId],[BookTime],[CustomerName],[CustomerPhone],[ReachNumber],[ReachTime],[ConsumeTimeBlockId],[OrderUserName],"
                           + "[OrderTime],[BookOff],[BookStateId],[OrgId] "
                           + "FROM [YWBook] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWBook = new YWBook();
                ReadYWBookAllData(sqlDataReader,yWBook);
            }
            sqlDataReader.Close();
            return yWBook;
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


    }
}
