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
    /// 对象名称：日志SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“日志类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“日志类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：chr
    /// 编写日期：2016-1-16 10:55:02
    /// </summary>
    public class YWLogDAL:DAL.Common.YWLogDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将日志（YWLog）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWLog">日志（YWLog）实例对象</param>
        public override int Insert(YWLog yWLog)
        {
            string sqlText = "INSERT INTO [YWLog]"
                           + "([YWTypeId],[YWRecordId],[OprUserName],[OprTime],[Description],[Backup1],[Backup2],[Backup3],[Backup4],[Backup5],[Backup6],[Backup7],[Backup8],"
                           + "[Backup9],[Backup10])"
                           + "VALUES"
                           + "(@YWTypeId,@YWRecordId,@OprUserName,@OprTime,@Description,@Backup1,@Backup2,@Backup3,@Backup4,@Backup5,@Backup6,@Backup7,@Backup8,"
                           + "@Backup9,@Backup10)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@YWTypeId"    , SqlDbType.Int      , 4 ){ Value = yWLog.YWType.Id    },
                new SqlParameter("@YWRecordId"  , SqlDbType.Int      , 4 ){ Value = yWLog.YWRecordId   },
                new SqlParameter("@OprUserName" , SqlDbType.NVarChar , 50){ Value = yWLog.Opr.UserName },
                new SqlParameter("@OprTime"     , SqlDbType.DateTime , 8 ){ Value = yWLog.OprTime      },
                new SqlParameter("@Description" , SqlDbType.NVarChar , 50){ Value = yWLog.Description  },
                new SqlParameter("@Backup1"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup1      },
                new SqlParameter("@Backup2"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup2      },
                new SqlParameter("@Backup3"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup3      },
                new SqlParameter("@Backup4"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup4      },
                new SqlParameter("@Backup5"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup5      },
                new SqlParameter("@Backup6"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup6      },
                new SqlParameter("@Backup7"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup7      },
                new SqlParameter("@Backup8"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup8      },
                new SqlParameter("@Backup9"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup9      },
                new SqlParameter("@Backup10"    , SqlDbType.NVarChar , 50){ Value = yWLog.Backup10     }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将日志（YWLog）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWLog">日志（YWLog）实例对象</param>
        public override int Update(YWLog yWLog)
        {
            string sqlText = "UPDATE [YWLog] SET "
                           + "[YWTypeId]=@YWTypeId,[YWRecordId]=@YWRecordId,[OprUserName]=@OprUserName,[OprTime]=@OprTime,[Description]=@Description,"
                           + "[Backup1]=@Backup1,[Backup2]=@Backup2,[Backup3]=@Backup3,[Backup4]=@Backup4,[Backup5]=@Backup5,[Backup6]=@Backup6,[Backup7]=@Backup7,[Backup8]=@Backup8,"
                           + "[Backup9]=@Backup9,[Backup10]=@Backup10 "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@YWTypeId"    , SqlDbType.Int      , 4 ){ Value = yWLog.YWType.Id    },
                new SqlParameter("@YWRecordId"  , SqlDbType.Int      , 4 ){ Value = yWLog.YWRecordId   },
                new SqlParameter("@OprUserName" , SqlDbType.NVarChar , 50){ Value = yWLog.Opr.UserName },
                new SqlParameter("@OprTime"     , SqlDbType.DateTime , 8 ){ Value = yWLog.OprTime      },
                new SqlParameter("@Description" , SqlDbType.NVarChar , 50){ Value = yWLog.Description  },
                new SqlParameter("@Backup1"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup1      },
                new SqlParameter("@Backup2"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup2      },
                new SqlParameter("@Backup3"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup3      },
                new SqlParameter("@Backup4"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup4      },
                new SqlParameter("@Backup5"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup5      },
                new SqlParameter("@Backup6"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup6      },
                new SqlParameter("@Backup7"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup7      },
                new SqlParameter("@Backup8"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup8      },
                new SqlParameter("@Backup9"     , SqlDbType.NVarChar , 50){ Value = yWLog.Backup9      },
                new SqlParameter("@Backup10"    , SqlDbType.NVarChar , 50){ Value = yWLog.Backup10     },
                new SqlParameter("@Id"          , SqlDbType.Int      , 4 ){ Value = yWLog.Id           }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据日志（YWLog）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">日志（YWLog）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YWLog] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据日志（YWLog）的主键“编号（Id）”从数据库中获取日志（YWLog）的实例。
        /// 成功从数据库中取得记录返回新日志（YWLog）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">日志（YWLog）的主键“编号（Id）”</param>
        public override YWLog GetDataById(int id)
        {
            YWLog yWLog = null;
            string sqlText = "SELECT [Id],[YWTypeId],[YWRecordId],[OprUserName],[OprTime],[Description],[Backup1],[Backup2],[Backup3],[Backup4],[Backup5],[Backup6],[Backup7],[Backup8],"
                           + "[Backup9],[Backup10] "
                           + "FROM [YWLog] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWLog = new YWLog();
                ReadYWLogAllData(sqlDataReader,yWLog);
            }
            sqlDataReader.Close();
            return yWLog;
        }



        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍




    }
}
