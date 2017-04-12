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
    /// 对象名称：优惠券SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“优惠券类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“优惠券类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：chr
    /// 编写日期：2016-4-16 16:34:11
    /// </summary>
    public class YWCouponsDAL:DAL.Common.YWCouponsDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将优惠券（YWCoupons）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWCoupons">优惠券（YWCoupons）实例对象</param>
        public override int Insert(YWCoupons yWCoupons)
        {
            string sqlText = "INSERT INTO [YWCoupons]"
                           + "([ConsumeId],[CouponsTypeId],[Cnt],[TicketNo],[Amount])"
                           + "VALUES"
                           + "(@ConsumeId,@CouponsTypeId,@Cnt,@TicketNo,@Amount)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ConsumeId"     , SqlDbType.Int      , 4 ){ Value = yWCoupons.ConsumeId   },
                new SqlParameter("@CouponsTypeId" , SqlDbType.Int      , 4 ){ Value = yWCoupons.CouponsType },
                new SqlParameter("@Cnt"           , SqlDbType.Int      , 4 ){ Value = yWCoupons.Cnt            },
                new SqlParameter("@TicketNo"      , SqlDbType.NVarChar , 50){ Value = yWCoupons.TicketNo       },
                new SqlParameter("@Amount"        , SqlDbType.Decimal  , 9 ){ Value = yWCoupons.Amount         }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将优惠券（YWCoupons）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWCoupons">优惠券（YWCoupons）实例对象</param>
        public override int Update(YWCoupons yWCoupons)
        {
            string sqlText = "UPDATE [YWCoupons] SET "
                           + "[ConsumeId]=@ConsumeId,[CouponsTypeId]=@CouponsTypeId,[Cnt]=@Cnt,[TicketNo]=@TicketNo,[Amount]=@Amount "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ConsumeId"     , SqlDbType.Int      , 4 ){ Value = yWCoupons.ConsumeId   },
                new SqlParameter("@CouponsTypeId" , SqlDbType.Int      , 4 ){ Value = yWCoupons.CouponsType },
                new SqlParameter("@Cnt"           , SqlDbType.Int      , 4 ){ Value = yWCoupons.Cnt            },
                new SqlParameter("@TicketNo"      , SqlDbType.NVarChar , 50){ Value = yWCoupons.TicketNo       },
                new SqlParameter("@Amount"        , SqlDbType.Decimal  , 9 ){ Value = yWCoupons.Amount         },
                new SqlParameter("@Id"            , SqlDbType.Int      , 4 ){ Value = yWCoupons.Id             }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据优惠券（YWCoupons）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">优惠券（YWCoupons）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YWCoupons] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据优惠券（YWCoupons）的主键“编号（Id）”从数据库中获取优惠券（YWCoupons）的实例。
        /// 成功从数据库中取得记录返回新优惠券（YWCoupons）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">优惠券（YWCoupons）的主键“编号（Id）”</param>
        public override YWCoupons GetDataById(int id)
        {
            YWCoupons yWCoupons = null;
            string sqlText = "SELECT [Id],[ConsumeId],[CouponsTypeId],[Cnt],[TicketNo],[Amount] "
                           + "FROM [YWCoupons] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWCoupons = new YWCoupons();
                ReadYWCouponsAllData(sqlDataReader,yWCoupons);
            }
            sqlDataReader.Close();
            return yWCoupons;
        }



        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
