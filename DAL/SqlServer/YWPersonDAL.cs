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
    /// 对象名称：人员SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“人员类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“人员类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWPersonDAL:DAL.Common.YWPersonDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将人员（YWPerson）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPerson">人员（YWPerson）实例对象</param>
        public override int Insert(YWPerson yWPerson)
        {
            string sqlText = "INSERT INTO [YWPerson]"
                           + "([UserName],[Name],[Sex],[Birth],[EntryTime],[Phone],[IDCardId],[Score],[OrgId])"
                           + "VALUES"
                           + "(@UserName,@Name,@Sex,@Birth,@EntryTime,@Phone,@IDCardId,@Score,@OrgId)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"         , SqlDbType.NVarChar , 50        ){ Value = yWPerson.UserName          },
                new SqlParameter("@Name"             , SqlDbType.NVarChar , 50        ){ Value = yWPerson.Name              },
                new SqlParameter("@Sex"              , SqlDbType.NVarChar , 50        ){ Value = yWPerson.Sex               },
                new SqlParameter("@Birth"            , SqlDbType.NVarChar , 50        ){ Value = yWPerson.Birth             },
                new SqlParameter("@EntryTime"        , SqlDbType.NVarChar , 50        ){ Value = yWPerson.EntryTime         },
                new SqlParameter("@Phone"            , SqlDbType.NVarChar , 50        ){ Value = yWPerson.Phone             },
                new SqlParameter("@IDCardId"         , SqlDbType.NVarChar , 50        ){ Value = yWPerson.IDCardId          },
                new SqlParameter("@Score"            , SqlDbType.Int      , 4         ){ Value = yWPerson.Score             },
                new SqlParameter("@OrgId"            , SqlDbType.Int      , 4         ){ Value = yWPerson.Org               }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将人员（YWPerson）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPerson">人员（YWPerson）实例对象</param>
        public override int Update(YWPerson yWPerson)
        {
            string sqlText = "UPDATE [YWPerson] SET "
                           + "[UserName]=@UserName,[Name]=@Name,[Sex]=@Sex,[Birth]=@Birth,[EntryTime]=@EntryTime,[Phone]=@Phone,"
                           + "[IDCardId]=@IDCardId,[Score]=@Score,[OrgId]=@OrgId "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"         , SqlDbType.NVarChar , 50        ){ Value = yWPerson.UserName          },
                new SqlParameter("@Name"             , SqlDbType.NVarChar , 50        ){ Value = yWPerson.Name              },
                new SqlParameter("@Sex"              , SqlDbType.NVarChar , 50        ){ Value = yWPerson.Sex               },
                new SqlParameter("@Birth"            , SqlDbType.NVarChar , 50        ){ Value = yWPerson.Birth             },
                new SqlParameter("@EntryTime"        , SqlDbType.NVarChar , 50        ){ Value = yWPerson.EntryTime         },
                new SqlParameter("@Phone"            , SqlDbType.NVarChar , 50        ){ Value = yWPerson.Phone             },
                new SqlParameter("@IDCardId"         , SqlDbType.NVarChar , 50        ){ Value = yWPerson.IDCardId          },
                new SqlParameter("@Score"            , SqlDbType.Int      , 4         ){ Value = yWPerson.Score             },
                new SqlParameter("@OrgId"            , SqlDbType.Int      , 4         ){ Value = yWPerson.Org               },
                new SqlParameter("@Id"               , SqlDbType.Int      , 4         ){ Value = yWPerson.Id                }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据人员（YWPerson）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">人员（YWPerson）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YWPerson] "
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
            string sqlText = "DELETE FROM [YWPerson] "
                           + paramList.SqlString;
            
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, paramList.Parameters);
        }


        /// <summary>
        /// 根据人员（YWPerson）的主键“编号（Id）”从数据库中获取人员（YWPerson）的实例。
        /// 成功从数据库中取得记录返回新人员（YWPerson）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">人员（YWPerson）的主键“编号（Id）”</param>
        public override YWPerson GetDataById(int id)
        {
            YWPerson yWPerson = null;
            string sqlText = "SELECT [Id],[UserName],[Name],[Sex],[Birth],[EntryTime],[Phone],[IDCardId],[Score],[OrgId] "
                           + "FROM [YWPerson] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWPerson = new YWPerson();
                ReadYWPersonAllData(sqlDataReader,yWPerson);
            }
            sqlDataReader.Close();
            return yWPerson;
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


    }
}
