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
    /// 对象名称：消费SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“消费类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“消费类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWConsumeDAL:DAL.Common.YWConsumeDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将消费（YWConsume）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWConsume">消费（YWConsume）实例对象</param>
        public override int Insert(YWConsume yWConsume)
        {
            string sqlText = "INSERT INTO [YWConsume]"
                           + "([ConsumeTableId],[FromBookId],[ConsumeTime],[ConsumeTimeBlockId],[ActualNumber],[WelcomeOwnerUserName],[ServiceOwnerUserName],"
                           + "[TotalPrice],[PriceOff],[Discount],[ActualTotalPrice],[ConsumeStateId],[OrgId],[IsMember],[MemberCardNo],[ServiceNo],[Payment])"
                           + "VALUES"
                           + "(@ConsumeTableId,@FromBookId,@ConsumeTime,@ConsumeTimeBlockId,@ActualNumber,@WelcomeOwnerUserName,@ServiceOwnerUserName,"
                           + "@TotalPrice,@PriceOff,@Discount,@ActualTotalPrice,@ConsumeStateId,@OrgId,@IsMember,@MemberCardNo,@ServiceNo,@Payment)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ConsumeTableId"       , SqlDbType.Int      , 4         ){ Value = yWConsume.ConsumeTable          },
                new SqlParameter("@FromBookId"           , SqlDbType.Int      , 4         ){ Value = yWConsume.FromBook              },
                new SqlParameter("@ConsumeTime"          , SqlDbType.NVarChar , 50        ){ Value = yWConsume.ConsumeTime           },
                new SqlParameter("@ConsumeTimeBlockId"   , SqlDbType.Int      , 4         ){ Value = yWConsume.ConsumeTimeBlock      },
                new SqlParameter("@ActualNumber"         , SqlDbType.Int      , 4         ){ Value = yWConsume.ActualNumber          },
                new SqlParameter("@WelcomeOwnerUserName" , SqlDbType.NVarChar , 50        ){ Value = yWConsume.WelcomeOwner          },
                new SqlParameter("@ServiceOwnerUserName" , SqlDbType.NVarChar , 50        ){ Value = yWConsume.ServiceOwner          },
                new SqlParameter("@TotalPrice"           , SqlDbType.Decimal  , 9         ){ Value = yWConsume.TotalPrice            },
                new SqlParameter("@PriceOff"             , SqlDbType.Decimal  , 9         ){ Value = yWConsume.PriceOff              },
                new SqlParameter("@Discount"             , SqlDbType.Decimal  , 9         ){ Value = yWConsume.Discount              },
                new SqlParameter("@ActualTotalPrice"     , SqlDbType.Decimal  , 9         ){ Value = yWConsume.ActualTotalPrice      },
                new SqlParameter("@ConsumeStateId"       , SqlDbType.Int      , 4         ){ Value = yWConsume.ConsumeState          },
                new SqlParameter("@OrgId"                , SqlDbType.Int      , 4         ){ Value = yWConsume.Org                   },
                new SqlParameter("@IsMember"             , SqlDbType.Int      , 4         ){ Value = yWConsume.IsMember              },
                new SqlParameter("@MemberCardNo"         , SqlDbType.NVarChar , 50        ){ Value = yWConsume.MemberCardNo          },
                new SqlParameter("@ServiceNo"            , SqlDbType.NVarChar , 50        ){ Value = yWConsume.ServiceNo             },
                new SqlParameter("@Payment"              , SqlDbType.Int      , 4         ){ Value = yWConsume.Payment               }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将消费（YWConsume）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWConsume">消费（YWConsume）实例对象</param>
        public override int Update(YWConsume yWConsume)
        {
            string sqlText = "UPDATE [YWConsume] SET "
                           + "[ConsumeTableId]=@ConsumeTableId,[FromBookId]=@FromBookId,[ConsumeTime]=@ConsumeTime,[ConsumeTimeBlockId]=@ConsumeTimeBlockId,"
                           + "[ActualNumber]=@ActualNumber,[WelcomeOwnerUserName]=@WelcomeOwnerUserName,[ServiceOwnerUserName]=@ServiceOwnerUserName,[TotalPrice]=@TotalPrice,"
                           + "[PriceOff]=@PriceOff,[Discount]=@Discount,[ActualTotalPrice]=@ActualTotalPrice,[ConsumeStateId]=@ConsumeStateId,[OrgId]=@OrgId,"
                           + "[IsMember]=@IsMember,[MemberCardNo]=@MemberCardNo,[ServiceNo]=@ServiceNo,[Payment]=@Payment "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ConsumeTableId"       , SqlDbType.Int      , 4         ){ Value = yWConsume.ConsumeTable          },
                new SqlParameter("@FromBookId"           , SqlDbType.Int      , 4         ){ Value = (yWConsume.FromBook==null)?0:yWConsume.FromBook           },
                new SqlParameter("@ConsumeTime"          , SqlDbType.NVarChar , 50        ){ Value = yWConsume.ConsumeTime           },
                new SqlParameter("@ConsumeTimeBlockId"   , SqlDbType.Int      , 4         ){ Value = yWConsume.ConsumeTimeBlock      },
                new SqlParameter("@ActualNumber"         , SqlDbType.Int      , 4         ){ Value = yWConsume.ActualNumber          },
                new SqlParameter("@WelcomeOwnerUserName" , SqlDbType.NVarChar , 50        ){ Value = yWConsume.WelcomeOwner          },
                new SqlParameter("@ServiceOwnerUserName" , SqlDbType.NVarChar , 50        ){ Value = yWConsume.ServiceOwner          },
                new SqlParameter("@TotalPrice"           , SqlDbType.Decimal  , 9         ){ Value = yWConsume.TotalPrice            },
                new SqlParameter("@PriceOff"             , SqlDbType.Decimal  , 9         ){ Value = yWConsume.PriceOff              },
                new SqlParameter("@Discount"             , SqlDbType.Decimal  , 9         ){ Value = yWConsume.Discount              },
                new SqlParameter("@ActualTotalPrice"     , SqlDbType.Decimal  , 9         ){ Value = yWConsume.ActualTotalPrice      },
                new SqlParameter("@ConsumeStateId"       , SqlDbType.Int      , 4         ){ Value = yWConsume.ConsumeState          },
                new SqlParameter("@OrgId"                , SqlDbType.Int      , 4         ){ Value = yWConsume.Org                   },
                new SqlParameter("@IsMember"             , SqlDbType.Int      , 4         ){ Value = yWConsume.IsMember              },
                new SqlParameter("@MemberCardNo"         , SqlDbType.NVarChar , 50        ){ Value = yWConsume.MemberCardNo          },
                new SqlParameter("@ServiceNo"            , SqlDbType.NVarChar , 50        ){ Value = yWConsume.ServiceNo             },
                new SqlParameter("@Payment"              , SqlDbType.Int      , 4         ){ Value = yWConsume.Payment               },
                new SqlParameter("@Id"                   , SqlDbType.Int      , 4         ){ Value = yWConsume.Id                    }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据消费（YWConsume）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">消费（YWConsume）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YWConsume] "
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
            string sqlText = "DELETE FROM [YWConsume] "
                           + paramList.SqlString;
           
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, paramList.Parameters);
        }


        /// <summary>
        /// 根据消费（YWConsume）的主键“编号（Id）”从数据库中获取消费（YWConsume）的实例。
        /// 成功从数据库中取得记录返回新消费（YWConsume）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">消费（YWConsume）的主键“编号（Id）”</param>
        public override YWConsume GetDataById(int id)
        {
            YWConsume yWConsume = null;
            string sqlText = "SELECT [Id],[ConsumeTableId],[FromBookId],[ConsumeTime],[ConsumeTimeBlockId],[ActualNumber],[WelcomeOwnerUserName],[ServiceOwnerUserName],"
                           + "[TotalPrice],[PriceOff],[Discount],[ActualTotalPrice],[ConsumeStateId],[OrgId],[IsMember],[MemberCardNo],[ServiceNo],[Payment] "
                           + "FROM [YWConsume] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWConsume = new YWConsume();
                ReadYWConsumeAllData(sqlDataReader,yWConsume);
            }
            sqlDataReader.Close();
            return yWConsume;
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍



    }
}
