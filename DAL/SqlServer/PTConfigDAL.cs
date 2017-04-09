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
    /// 对象名称：配置设置SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“配置设置类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“配置设置类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTConfigDAL:DAL.Common.PTConfigDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将配置设置（PTConfig）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTConfig">配置设置（PTConfig）实例对象</param>
        public override int Insert(PTConfig pTConfig)
        {
            string sqlText = "INSERT INTO [PT_CONFIG]"
                           + "([Id],[Name],[TypeId],[GroupId],[DefaultValue],[Notes],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5])"
                           + "VALUES"
                           + "(@Id,@Name,@TypeId,@GroupId,@DefaultValue,@Notes,@Alternate1,@Alternate2,@Alternate3,@Alternate4,@Alternate5)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id"           , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Id           },
                new SqlParameter("@Name"         , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Name         },
                new SqlParameter("@TypeId"       , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Type         },
                new SqlParameter("@GroupId"      , SqlDbType.Int      , 4  ){ Value = pTConfig.GroupId      },
                new SqlParameter("@DefaultValue" , SqlDbType.NVarChar , 50 ){ Value = pTConfig.DefaultValue },
                new SqlParameter("@Notes"        , SqlDbType.NVarChar , 500){ Value = pTConfig.Notes        },
                new SqlParameter("@Alternate1"   , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Alternate1   },
                new SqlParameter("@Alternate2"   , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Alternate2   },
                new SqlParameter("@Alternate3"   , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Alternate3   },
                new SqlParameter("@Alternate4"   , SqlDbType.NVarChar , 500){ Value = pTConfig.Alternate4   },
                new SqlParameter("@Alternate5"   , SqlDbType.NVarChar , 500){ Value = pTConfig.Alternate5   }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将配置设置（PTConfig）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTConfig">配置设置（PTConfig）实例对象</param>
        public override int Update(PTConfig pTConfig)
        {
            string sqlText = "UPDATE [PT_CONFIG] SET "
                           + "[Name]=@Name,[TypeId]=@TypeId,[GroupId]=@GroupId,[DefaultValue]=@DefaultValue,[Notes]=@Notes,[Alternate1]=@Alternate1,"
                           + "[Alternate2]=@Alternate2,[Alternate3]=@Alternate3,[Alternate4]=@Alternate4,[Alternate5]=@Alternate5 "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Name"         , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Name         },
                new SqlParameter("@TypeId"       , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Type         },
                new SqlParameter("@GroupId"      , SqlDbType.Int      , 4  ){ Value = pTConfig.GroupId      },
                new SqlParameter("@DefaultValue" , SqlDbType.NVarChar , 50 ){ Value = pTConfig.DefaultValue },
                new SqlParameter("@Notes"        , SqlDbType.NVarChar , 500){ Value = pTConfig.Notes        },
                new SqlParameter("@Alternate1"   , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Alternate1   },
                new SqlParameter("@Alternate2"   , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Alternate2   },
                new SqlParameter("@Alternate3"   , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Alternate3   },
                new SqlParameter("@Alternate4"   , SqlDbType.NVarChar , 500){ Value = pTConfig.Alternate4   },
                new SqlParameter("@Alternate5"   , SqlDbType.NVarChar , 500){ Value = pTConfig.Alternate5   },
                new SqlParameter("@Id"           , SqlDbType.NVarChar , 50 ){ Value = pTConfig.Id           }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据配置设置（PTConfig）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">配置设置（PTConfig）的主键“编号（Id）”</param>
        public override int Delete(string id)
        {
            string sqlText = "DELETE FROM [PT_CONFIG] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.NVarChar , 50){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据配置设置（PTConfig）的主键“编号（Id）”从数据库中获取配置设置（PTConfig）的实例。
        /// 成功从数据库中取得记录返回新配置设置（PTConfig）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">配置设置（PTConfig）的主键“编号（Id）”</param>
        public override PTConfig GetDataById(string id)
        {
            PTConfig pTConfig = null;
            string sqlText = "SELECT [Id],[Name],[TypeId],[GroupId],[DefaultValue],[Notes],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] "
                           + "FROM [PT_CONFIG] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.NVarChar , 50){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                pTConfig = new PTConfig();
                ReadPTConfigAllData(sqlDataReader,pTConfig);
            }
            sqlDataReader.Close();
            return pTConfig;
        }


        /// <summary>
        /// 从数据库中读取并返回所有配置项（PTConfig）List列表。
        /// </summary>
        public override List<PTConfig> GetAllList()
        {
            string sqlText = "SELECT [Id],[Name],[TypeId],[GroupId],[DefaultValue],[Notes],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] "
                           + "FROM [PT_CONFIG]";
            List<PTConfig> list = new List<PTConfig>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                PTConfig configGroup = new PTConfig();
                ReadPTConfigAllData(sqlDataReader, configGroup);
                list.Add(configGroup);
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
