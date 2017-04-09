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
    /// 对象名称：退菜SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“退菜类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“退菜类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2016-2-17 10:26:09
    /// </summary>
    public class YWFoodReturnDAL:DAL.Common.YWFoodReturnDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将退菜（YWFoodReturn）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFoodReturn">退菜（YWFoodReturn）实例对象</param>
        public override int Insert(YWFoodReturn yWFoodReturn)
        {
            string sqlText = "INSERT INTO [YWFoodReturn]"
                           + "([FoodId],[ReasonId],[Description],[ApplyTime],[ApplyUser],[ApproveTime],[ApproveUser])"
                           + "VALUES"
                           + "(@FoodId,@ReasonId,@Description,@ApplyTime,@ApplyUser,@ApproveTime,@ApproveUser)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@FoodId"        , SqlDbType.Int      , 4 ){ Value = yWFoodReturn.Food        },
                new SqlParameter("@ReasonId"      , SqlDbType.Int      , 4 ){ Value = yWFoodReturn.ReasonId    },
                new SqlParameter("@Description"   , SqlDbType.NVarChar , 50){ Value = yWFoodReturn.Description },
                new SqlParameter("@ApplyTime"     , SqlDbType.NVarChar , 50){ Value = yWFoodReturn.ApplyTime   },
                new SqlParameter("@ApplyUser"     , SqlDbType.NVarChar , 50){ Value = yWFoodReturn.ApplyUser   },
                new SqlParameter("@ApproveTime"   , SqlDbType.NVarChar , 50){ Value = yWFoodReturn.ApproveTime },
                new SqlParameter("@ApproveUser"   , SqlDbType.NVarChar , 50){ Value = yWFoodReturn.ApproveUser }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将退菜（YWFoodReturn）数据，根据主键“编码（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFoodReturn">退菜（YWFoodReturn）实例对象</param>
        public override int Update(YWFoodReturn yWFoodReturn)
        {
            string sqlText = "UPDATE [YWFoodReturn] SET "
                           + "[FoodId]=@FoodId,[ReasonId]=@ReasonId,[Description]=@Description,[ApplyTime]=@ApplyTime,[ApplyUser]=@ApplyUser,"
                           + "[ApproveTime]=@ApproveTime,[ApproveUser]=@ApproveUser "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@FoodId"        , SqlDbType.Int      , 4 ){ Value = yWFoodReturn.Food        },
                new SqlParameter("@ReasonId"      , SqlDbType.Int      , 4 ){ Value = yWFoodReturn.ReasonId    },
                new SqlParameter("@Description"   , SqlDbType.NVarChar , 50){ Value = yWFoodReturn.Description },
                new SqlParameter("@ApplyTime"     , SqlDbType.NVarChar , 50){ Value = yWFoodReturn.ApplyTime   },
                new SqlParameter("@ApplyUser"     , SqlDbType.NVarChar , 50){ Value = yWFoodReturn.ApplyUser   },
                new SqlParameter("@ApproveTime"   , SqlDbType.NVarChar , 50){ Value = yWFoodReturn.ApproveTime },
                new SqlParameter("@ApproveUser"   , SqlDbType.NVarChar , 50){ Value = yWFoodReturn.ApproveUser },
                new SqlParameter("@Id"            , SqlDbType.Int      , 4 ){ Value = yWFoodReturn.Id          }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据退菜（YWFoodReturn）的主键“编码（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">退菜（YWFoodReturn）的主键“编码（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YWFoodReturn] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据退菜（YWFoodReturn）的主键“编码（Id）”从数据库中获取退菜（YWFoodReturn）的实例。
        /// 成功从数据库中取得记录返回新退菜（YWFoodReturn）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">退菜（YWFoodReturn）的主键“编码（Id）”</param>
        public override YWFoodReturn GetDataById(int id)
        {
            YWFoodReturn yWFoodReturn = null;
            string sqlText = "SELECT [Id],[FoodId],[ReasonId],[Description],[ApplyTime],[ApplyUser],[ApproveTime],[ApproveUser] "
                           + "FROM [YWFoodReturn] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWFoodReturn = new YWFoodReturn();
                ReadYWFoodReturnAllData(sqlDataReader,yWFoodReturn);
            }
            sqlDataReader.Close();
            return yWFoodReturn;
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
