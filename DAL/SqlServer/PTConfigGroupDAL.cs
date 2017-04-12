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
    /// 对象名称：配置分组（码表）SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“配置分组（码表）类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“配置分组（码表）类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：chr
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTConfigGroupDAL:DAL.Common.PTConfigGroupDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将配置分组（码表）（PTConfigGroup）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTConfigGroup">配置分组（码表）（PTConfigGroup）实例对象</param>
        public override int Insert(PTConfigGroup pTConfigGroup)
        {
            string sqlText = "INSERT INTO [PT_CONFIGGROUP]"
                           + "([Name],[Description],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5])"
                           + "VALUES"
                           + "(@Name,@Description,@Alternate1,@Alternate2,@Alternate3,@Alternate4,@Alternate5)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Name"        , SqlDbType.NVarChar , 50 ){ Value = pTConfigGroup.Name        },
                new SqlParameter("@Description" , SqlDbType.NVarChar , 500){ Value = pTConfigGroup.Description },
                new SqlParameter("@Alternate1"  , SqlDbType.NVarChar , 50 ){ Value = pTConfigGroup.Alternate1  },
                new SqlParameter("@Alternate2"  , SqlDbType.NVarChar , 50 ){ Value = pTConfigGroup.Alternate2  },
                new SqlParameter("@Alternate3"  , SqlDbType.NVarChar , 50 ){ Value = pTConfigGroup.Alternate3  },
                new SqlParameter("@Alternate4"  , SqlDbType.NVarChar , 500){ Value = pTConfigGroup.Alternate4  },
                new SqlParameter("@Alternate5"  , SqlDbType.NVarChar , 500){ Value = pTConfigGroup.Alternate5  }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将配置分组（码表）（PTConfigGroup）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTConfigGroup">配置分组（码表）（PTConfigGroup）实例对象</param>
        public override int Update(PTConfigGroup pTConfigGroup)
        {
            string sqlText = "UPDATE [PT_CONFIGGROUP] SET "
                           + "[Name]=@Name,[Description]=@Description,[Alternate1]=@Alternate1,[Alternate2]=@Alternate2,[Alternate3]=@Alternate3,"
                           + "[Alternate4]=@Alternate4,[Alternate5]=@Alternate5 "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Name"        , SqlDbType.NVarChar , 50 ){ Value = pTConfigGroup.Name        },
                new SqlParameter("@Description" , SqlDbType.NVarChar , 500){ Value = pTConfigGroup.Description },
                new SqlParameter("@Alternate1"  , SqlDbType.NVarChar , 50 ){ Value = pTConfigGroup.Alternate1  },
                new SqlParameter("@Alternate2"  , SqlDbType.NVarChar , 50 ){ Value = pTConfigGroup.Alternate2  },
                new SqlParameter("@Alternate3"  , SqlDbType.NVarChar , 50 ){ Value = pTConfigGroup.Alternate3  },
                new SqlParameter("@Alternate4"  , SqlDbType.NVarChar , 500){ Value = pTConfigGroup.Alternate4  },
                new SqlParameter("@Alternate5"  , SqlDbType.NVarChar , 500){ Value = pTConfigGroup.Alternate5  },
                new SqlParameter("@Id"          , SqlDbType.Int      , 4  ){ Value = pTConfigGroup.Id          }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据配置分组（码表）（PTConfigGroup）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">配置分组（码表）（PTConfigGroup）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [PT_CONFIGGROUP] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据配置分组（码表）（PTConfigGroup）的主键“编号（Id）”从数据库中获取配置分组（码表）（PTConfigGroup）的实例。
        /// 成功从数据库中取得记录返回新配置分组（码表）（PTConfigGroup）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">配置分组（码表）（PTConfigGroup）的主键“编号（Id）”</param>
        public override PTConfigGroup GetDataById(int id)
        {
            PTConfigGroup pTConfigGroup = null;
            string sqlText = "SELECT [Id],[Name],[Description],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] "
                           + "FROM [PT_CONFIGGROUP] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                pTConfigGroup = new PTConfigGroup();
                ReadPTConfigGroupAllData(sqlDataReader,pTConfigGroup);
            }
            sqlDataReader.Close();
            return pTConfigGroup;
        }

        /// <summary>
        /// 从数据库中读取并返回所有配置分组（PTConfigGroup）List列表。
        /// </summary>
        public override List<PTConfigGroup> GetAllList()
        {
            string sqlText = "SELECT [Id],[Name],[Description],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] "
                           + "FROM [PT_CONFIGGROUP]";
            List<PTConfigGroup> list = new List<PTConfigGroup>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                PTConfigGroup pTConfigGroup = new PTConfigGroup();
                ReadPTConfigGroupAllData(sqlDataReader, pTConfigGroup);
                list.Add(pTConfigGroup);
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
