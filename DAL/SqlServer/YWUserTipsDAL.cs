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
    /// 对象名称：用户提示SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“用户提示类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“用户提示类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2016-1-25 16:42:49
    /// </summary>
    public class YWUserTipsDAL:DAL.Common.YWUserTipsDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将用户提示（YWUserTips）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWUserTips">用户提示（YWUserTips）实例对象</param>
        public override int Insert(YWUserTips yWUserTips)
        {
            string sqlText = "INSERT INTO [YWUserTips]"
                           + "([UserName],[Tips1],[Tips2],[Tips3],[Tips4],[Tips5],[Tips6],[Tips7],[Tips8],[Tips9],[Tips10],[Tips11],[Tips12],[Tips13],[Tips14],[Tips15],[Tips16],[Tips17],"
                           + "[Tips18],[Tips19],[Tips20])"
                           + "VALUES"
                           + "(@UserName,@Tips1,@Tips2,@Tips3,@Tips4,@Tips5,@Tips6,@Tips7,@Tips8,@Tips9,@Tips10,@Tips11,@Tips12,@Tips13,@Tips14,@Tips15,@Tips16,@Tips17,"
                           + "@Tips18,@Tips19,@Tips20)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName" , SqlDbType.NVarChar , 50){ Value = yWUserTips.UserName },
                new SqlParameter("@Tips1"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips1    },
                new SqlParameter("@Tips2"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips2    },
                new SqlParameter("@Tips3"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips3    },
                new SqlParameter("@Tips4"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips4    },
                new SqlParameter("@Tips5"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips5    },
                new SqlParameter("@Tips6"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips6    },
                new SqlParameter("@Tips7"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips7    },
                new SqlParameter("@Tips8"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips8    },
                new SqlParameter("@Tips9"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips9    },
                new SqlParameter("@Tips10"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips10   },
                new SqlParameter("@Tips11"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips11   },
                new SqlParameter("@Tips12"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips12   },
                new SqlParameter("@Tips13"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips13   },
                new SqlParameter("@Tips14"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips14   },
                new SqlParameter("@Tips15"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips15   },
                new SqlParameter("@Tips16"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips16   },
                new SqlParameter("@Tips17"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips17   },
                new SqlParameter("@Tips18"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips18   },
                new SqlParameter("@Tips19"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips19   },
                new SqlParameter("@Tips20"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips20   }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将用户提示（YWUserTips）数据，根据主键“用户名（UserName）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWUserTips">用户提示（YWUserTips）实例对象</param>
        public override int Update(YWUserTips yWUserTips)
        {
            string sqlText = "UPDATE [YWUserTips] SET "
                           + "[Tips1]=@Tips1,[Tips2]=@Tips2,[Tips3]=@Tips3,[Tips4]=@Tips4,[Tips5]=@Tips5,[Tips6]=@Tips6,[Tips7]=@Tips7,[Tips8]=@Tips8,[Tips9]=@Tips9,"
                           + "[Tips10]=@Tips10,[Tips11]=@Tips11,[Tips12]=@Tips12,[Tips13]=@Tips13,[Tips14]=@Tips14,[Tips15]=@Tips15,[Tips16]=@Tips16,[Tips17]=@Tips17,"
                           + "[Tips18]=@Tips18,[Tips19]=@Tips19,[Tips20]=@Tips20 "
                           + "WHERE [UserName]=@UserName";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Tips1"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips1    },
                new SqlParameter("@Tips2"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips2    },
                new SqlParameter("@Tips3"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips3    },
                new SqlParameter("@Tips4"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips4    },
                new SqlParameter("@Tips5"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips5    },
                new SqlParameter("@Tips6"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips6    },
                new SqlParameter("@Tips7"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips7    },
                new SqlParameter("@Tips8"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips8    },
                new SqlParameter("@Tips9"    , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips9    },
                new SqlParameter("@Tips10"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips10   },
                new SqlParameter("@Tips11"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips11   },
                new SqlParameter("@Tips12"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips12   },
                new SqlParameter("@Tips13"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips13   },
                new SqlParameter("@Tips14"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips14   },
                new SqlParameter("@Tips15"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips15   },
                new SqlParameter("@Tips16"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips16   },
                new SqlParameter("@Tips17"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips17   },
                new SqlParameter("@Tips18"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips18   },
                new SqlParameter("@Tips19"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips19   },
                new SqlParameter("@Tips20"   , SqlDbType.Int      , 4 ){ Value = yWUserTips.Tips20   },
                new SqlParameter("@UserName" , SqlDbType.NVarChar , 50){ Value = yWUserTips.UserName }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据用户提示（YWUserTips）的主键“用户名（UserName）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="userName">用户提示（YWUserTips）的主键“用户名（UserName）”</param>
        public override int Delete(string userName)
        {
            string sqlText = "DELETE FROM [YWUserTips] "
                           + "WHERE [UserName]=@UserName";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName" , SqlDbType.NVarChar , 50){ Value = userName }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据用户提示（YWUserTips）的主键“用户名（UserName）”从数据库中获取用户提示（YWUserTips）的实例。
        /// 成功从数据库中取得记录返回新用户提示（YWUserTips）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="userName">用户提示（YWUserTips）的主键“用户名（UserName）”</param>
        public override YWUserTips GetDataByUserName(string userName)
        {
            YWUserTips yWUserTips = null;
            string sqlText = "SELECT [UserName],[Tips1],[Tips2],[Tips3],[Tips4],[Tips5],[Tips6],[Tips7],[Tips8],[Tips9],[Tips10],[Tips11],[Tips12],[Tips13],[Tips14],[Tips15],[Tips16],[Tips17],"
                           + "[Tips18],[Tips19],[Tips20] "
                           + "FROM [YWUserTips] "
                           + "WHERE [UserName]=@UserName";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName" , SqlDbType.NVarChar , 50){ Value = userName }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWUserTips = new YWUserTips();
                ReadYWUserTipsAllData(sqlDataReader,yWUserTips);
            }
            sqlDataReader.Close();
            return yWUserTips;
        }


        /// <summary>
        /// 从数据库中读取并返回所有用户提示（YWUserTips）List列表。
        /// </summary>
        public override List<YWUserTips> GetAllList()
        {
            string sqlText = "SELECT [UserName],[Tips1],[Tips2],[Tips3],[Tips4],[Tips5],[Tips6],[Tips7],[Tips8],[Tips9],[Tips10],[Tips11],[Tips12],[Tips13],[Tips14],[Tips15],[Tips16],[Tips17],"
                           + "[Tips18],[Tips19],[Tips20] "
                           + "FROM [YWUserTips]";
            List<YWUserTips> list = new List<YWUserTips>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                YWUserTips yWUserTips = new YWUserTips();
                ReadYWUserTipsAllData(sqlDataReader, yWUserTips);
                list.Add(yWUserTips);
            }
            sqlDataReader.Close();
            return list;
        }



        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
