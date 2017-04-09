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
    /// 对象名称：餐桌SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“餐桌类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“餐桌类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWTableDAL:DAL.Common.YWTableDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将餐桌（YWTable）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWTable">餐桌（YWTable）实例对象</param>
        public override int Insert(YWTable yWTable)
        {
            string sqlText = "INSERT INTO [YWTable]"
                           + "([Name],[TableTypeId],[StdCapacity],[MaxCapacity],[MinConsumption],[Photo],[Description],[OwnerUserName],[Others],[OrgId])"
                           + "VALUES"
                           + "(@Name,@TableTypeId,@StdCapacity,@MaxCapacity,@MinConsumption,@Photo,@Description,@OwnerUserName,@Others,@OrgId)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Name"           , SqlDbType.NVarChar , 50        ){ Value = yWTable.Name           },
                new SqlParameter("@TableTypeId"    , SqlDbType.Int      , 4         ){ Value = yWTable.TableTypeId    },
                new SqlParameter("@StdCapacity"    , SqlDbType.Int      , 4         ){ Value = yWTable.StdCapacity    },
                new SqlParameter("@MaxCapacity"    , SqlDbType.Int      , 4         ){ Value = yWTable.MaxCapacity    },
                new SqlParameter("@MinConsumption" , SqlDbType.Int      , 4         ){ Value = yWTable.MinConsumption },
                new SqlParameter("@Photo"          , SqlDbType.NVarChar , 50        ){ Value = yWTable.Photo          },
                new SqlParameter("@Description"    , SqlDbType.NText    , 1073741823){ Value = yWTable.Description    },
                new SqlParameter("@OwnerUserName"  , SqlDbType.NVarChar , 50        ){ Value = yWTable.OwnerUserName  },
                new SqlParameter("@Others"         , SqlDbType.NText    , 1073741823){ Value = yWTable.Others         },
                new SqlParameter("@OrgId"          , SqlDbType.Int      , 4         ){ Value = yWTable.Org            }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将餐桌（YWTable）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWTable">餐桌（YWTable）实例对象</param>
        public override int Update(YWTable yWTable)
        {
            string sqlText = "UPDATE [YWTable] SET "
                           + "[Name]=@Name,[TableTypeId]=@TableTypeId,[StdCapacity]=@StdCapacity,[MaxCapacity]=@MaxCapacity,[MinConsumption]=@MinConsumption,"
                           + "[Photo]=@Photo,[Description]=@Description,[OwnerUserName]=@OwnerUserName,[Others]=@Others,[OrgId]=@OrgId "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Name"           , SqlDbType.NVarChar , 50        ){ Value = yWTable.Name           },
                new SqlParameter("@TableTypeId"    , SqlDbType.Int      , 4         ){ Value = yWTable.TableTypeId    },
                new SqlParameter("@StdCapacity"    , SqlDbType.Int      , 4         ){ Value = yWTable.StdCapacity    },
                new SqlParameter("@MaxCapacity"    , SqlDbType.Int      , 4         ){ Value = yWTable.MaxCapacity    },
                new SqlParameter("@MinConsumption" , SqlDbType.Int      , 4         ){ Value = yWTable.MinConsumption },
                new SqlParameter("@Photo"          , SqlDbType.NVarChar , 50        ){ Value = yWTable.Photo          },
                new SqlParameter("@Description"    , SqlDbType.NText    , 1073741823){ Value = yWTable.Description    },
                new SqlParameter("@OwnerUserName"  , SqlDbType.NVarChar , 50        ){ Value = yWTable.OwnerUserName  },
                new SqlParameter("@Others"         , SqlDbType.NText    , 1073741823){ Value = yWTable.Others         },
                new SqlParameter("@OrgId"          , SqlDbType.Int      , 4         ){ Value = yWTable.Org            },
                new SqlParameter("@Id"             , SqlDbType.Int      , 4         ){ Value = yWTable.Id             }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据餐桌（YWTable）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">餐桌（YWTable）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YWTable] "
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
            string sqlText = "DELETE FROM [YWTable] "
                           + paramList.SqlString;
            
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, paramList.Parameters);
        }


        /// <summary>
        /// 根据餐桌（YWTable）的主键“编号（Id）”从数据库中获取餐桌（YWTable）的实例。
        /// 成功从数据库中取得记录返回新餐桌（YWTable）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">餐桌（YWTable）的主键“编号（Id）”</param>
        public override YWTable GetDataById(int id)
        {
            YWTable yWTable = null;
            string sqlText = "SELECT [Id],[Name],[TableTypeId],[StdCapacity],[MaxCapacity],[MinConsumption],[Photo],[Description],[OwnerUserName],[Others],[OrgId] "
                           + "FROM [YWTable] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWTable = new YWTable();
                ReadYWTableAllData(sqlDataReader,yWTable);
            }
            sqlDataReader.Close();
            return yWTable;
        }

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

    }
}
