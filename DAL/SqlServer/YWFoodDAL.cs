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
    /// 对象名称：菜品SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“菜品类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“菜品类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWFoodDAL:DAL.Common.YWFoodDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将菜品（YWFood）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFood">菜品（YWFood）实例对象</param>
        public override int Insert(YWFood yWFood)
        {
            string sqlText = "INSERT INTO [YWFood]"
                           + "([ProductId],[ConsumeId],[SpecialRequirement],[OrderTime],[PreparedTime],[OutPutTime],[OnTableTime],[CheckoutTime],[MakeStateId],[OrderStateId],[CheckStateId],[OrgId])"
                           + "VALUES"
                           + "(@ProductId,@ConsumeId,@SpecialRequirement,@OrderTime,@PreparedTime,@OutPutTime,@OnTableTime,@CheckoutTime,@MakeStateId,@OrderStateId,@CheckStateId,@OrgId)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ProductId"          , SqlDbType.Int      , 4         ){ Value = yWFood.Product            },
                new SqlParameter("@ConsumeId"          , SqlDbType.Int      , 4         ){ Value = yWFood.Consume            },
                new SqlParameter("@SpecialRequirement" , SqlDbType.NText    , 1073741823){ Value = yWFood.SpecialRequirement },
                new SqlParameter("@OrderTime"          , SqlDbType.NVarChar , 50        ){ Value = yWFood.OrderTime          },
                new SqlParameter("@PreparedTime"       , SqlDbType.NVarChar , 50        ){ Value = yWFood.PreparedTime       },
                new SqlParameter("@OutPutTime"         , SqlDbType.NVarChar , 50        ){ Value = yWFood.OutPutTime         },
                new SqlParameter("@OnTableTime"        , SqlDbType.NVarChar , 50        ){ Value = yWFood.OnTableTime        },
                new SqlParameter("@CheckoutTime"       , SqlDbType.NVarChar , 50        ){ Value = yWFood.CheckoutTime       },
                new SqlParameter("@MakeStateId"        , SqlDbType.Int      , 4         ){ Value = yWFood.MakeState          },
                new SqlParameter("@OrderStateId"       , SqlDbType.Int      , 4         ){ Value = yWFood.OrderState         },
                new SqlParameter("@CheckStateId"       , SqlDbType.Int      , 4         ){ Value = yWFood.CheckState         },
                new SqlParameter("@OrgId"              , SqlDbType.Int      , 4         ){ Value = yWFood.Org                } 
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将菜品（YWFood）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFood">菜品（YWFood）实例对象</param>
        public override int Update(YWFood yWFood)
        {
            string sqlText = "UPDATE [YWFood] SET "
                           + "[ProductId]=@ProductId,[ConsumeId]=@ConsumeId,[SpecialRequirement]=@SpecialRequirement,[OrderTime]=@OrderTime,"
                           + "[PreparedTime]=@PreparedTime,[OutPutTime]=@OutPutTime,[OnTableTime]=@OnTableTime,[CheckoutTime]=@CheckoutTime,[MakeStateId]=@MakeStateId,[OrderStateId]=@OrderStateId,[CheckStateId]=@CheckStateId,[OrgId]=@OrgId "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ProductId"          , SqlDbType.Int      , 4         ){ Value = yWFood.Product            },
                new SqlParameter("@ConsumeId"          , SqlDbType.Int      , 4         ){ Value = yWFood.Consume            },
                new SqlParameter("@SpecialRequirement" , SqlDbType.NText    , 1073741823){ Value = yWFood.SpecialRequirement },
                new SqlParameter("@OrderTime"          , SqlDbType.NVarChar , 50        ){ Value = yWFood.OrderTime          },
                new SqlParameter("@PreparedTime"       , SqlDbType.NVarChar , 50        ){ Value = yWFood.PreparedTime       },
                new SqlParameter("@OutPutTime"         , SqlDbType.NVarChar , 50        ){ Value = yWFood.OutPutTime         },
                new SqlParameter("@OnTableTime"        , SqlDbType.NVarChar , 50        ){ Value = yWFood.OnTableTime        },
                new SqlParameter("@CheckoutTime"       , SqlDbType.NVarChar , 50        ){ Value = yWFood.CheckoutTime       },
                new SqlParameter("@MakeStateId"        , SqlDbType.Int      , 4         ){ Value = yWFood.MakeState          },
                new SqlParameter("@OrderStateId"       , SqlDbType.Int      , 4         ){ Value = yWFood.OrderState         },
                new SqlParameter("@CheckStateId"       , SqlDbType.Int      , 4         ){ Value = yWFood.CheckState         },
                new SqlParameter("@OrgId"              , SqlDbType.Int      , 4         ){ Value = yWFood.Org                },
                new SqlParameter("@Id"                 , SqlDbType.Int      , 4         ){ Value = yWFood.Id                 }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据菜品（YWFood）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">菜品（YWFood）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YWFood] "
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
            string sqlText = "DELETE FROM [YWFood] "
                           + paramList.SqlString;
            
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, paramList.Parameters);
        }

        /// <summary>
        /// 根据菜品（YWFood）的主键“编号（Id）”从数据库中获取菜品（YWFood）的实例。
        /// 成功从数据库中取得记录返回新菜品（YWFood）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">菜品（YWFood）的主键“编号（Id）”</param>
        public override YWFood GetDataById(int id)
        {
            YWFood yWFood = null;
            string sqlText = "SELECT [Id],[ProductId],[ConsumeId],[SpecialRequirement],[OrderTime],[PreparedTime],[OutPutTime],[OnTableTime],[CheckoutTime],[MakeStateId],[OrderStateId],[CheckStateId],[OrgId] "
                           + "FROM [YWFood] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWFood = new YWFood();
                ReadYWFoodAllData(sqlDataReader,yWFood);
            }
            sqlDataReader.Close();
            return yWFood;
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


    }
}
