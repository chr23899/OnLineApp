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
    /// 对象名称：数据字典SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“数据字典类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“数据字典类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：chr
    /// 编写日期：2014-11-8 9:36:12
    /// </summary>
    public class YWDictionaryDAL:DAL.Common.YWDictionaryDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将数据字典（YWDictionary）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWDictionary">数据字典（YWDictionary）实例对象</param>
        public override int Insert(YWDictionary yWDictionary)
        {
            string sqlText = "INSERT INTO [YWDictionary]"
                           + "([DictionaryTypeId],[CodeId],[Name],[Description],[Backup1],[Backup2],[Backup3],[Backup4],[Backup5],[Backup6],[Backup7],[Backup8],[Backup9],"
                           + "[Backup10])"
                           + "VALUES"
                           + "(@DictionaryTypeId,@CodeId,@Name,@Description,@Backup1,@Backup2,@Backup3,@Backup4,@Backup5,@Backup6,@Backup7,@Backup8,@Backup9,"
                           + "@Backup10)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@DictionaryTypeId" , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.DictionaryType    },
                new SqlParameter("@CodeId"           , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.CodeId            },
                new SqlParameter("@Name"             , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Name              },
                new SqlParameter("@Description"      , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Description       },
                new SqlParameter("@Backup1"          , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Backup1           },
                new SqlParameter("@Backup2"          , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Backup2           },
                new SqlParameter("@Backup3"          , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Backup3           },
                new SqlParameter("@Backup4"          , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Backup4           },
                new SqlParameter("@Backup5"          , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Backup5           },
                new SqlParameter("@Backup6"          , SqlDbType.NVarChar , 500       ){ Value = yWDictionary.Backup6           },
                new SqlParameter("@Backup7"          , SqlDbType.NVarChar , 500       ){ Value = yWDictionary.Backup7           },
                new SqlParameter("@Backup8"          , SqlDbType.NVarChar , 500       ){ Value = yWDictionary.Backup8           },
                new SqlParameter("@Backup9"          , SqlDbType.NText    , 1073741823){ Value = yWDictionary.Backup9           },
                new SqlParameter("@Backup10"         , SqlDbType.NText    , 1073741823){ Value = yWDictionary.Backup10          }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将数据字典（YWDictionary）数据，根据主键“编码（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWDictionary">数据字典（YWDictionary）实例对象</param>
        public override int Update(YWDictionary yWDictionary)
        {
            string sqlText = "UPDATE [YWDictionary] SET "
                           + "[DictionaryTypeId]=@DictionaryTypeId,[CodeId]=@CodeId,[Name]=@Name,[Description]=@Description,[Backup1]=@Backup1,"
                           + "[Backup2]=@Backup2,[Backup3]=@Backup3,[Backup4]=@Backup4,[Backup5]=@Backup5,[Backup6]=@Backup6,[Backup7]=@Backup7,[Backup8]=@Backup8,[Backup9]=@Backup9,"
                           + "[Backup10]=@Backup10 "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@DictionaryTypeId" , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.DictionaryType    },
                new SqlParameter("@CodeId"           , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.CodeId            },
                new SqlParameter("@Name"             , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Name              },
                new SqlParameter("@Description"      , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Description       },
                new SqlParameter("@Backup1"          , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Backup1           },
                new SqlParameter("@Backup2"          , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Backup2           },
                new SqlParameter("@Backup3"          , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Backup3           },
                new SqlParameter("@Backup4"          , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Backup4           },
                new SqlParameter("@Backup5"          , SqlDbType.NVarChar , 50        ){ Value = yWDictionary.Backup5           },
                new SqlParameter("@Backup6"          , SqlDbType.NVarChar , 500       ){ Value = yWDictionary.Backup6           },
                new SqlParameter("@Backup7"          , SqlDbType.NVarChar , 500       ){ Value = yWDictionary.Backup7           },
                new SqlParameter("@Backup8"          , SqlDbType.NVarChar , 500       ){ Value = yWDictionary.Backup8           },
                new SqlParameter("@Backup9"          , SqlDbType.NText    , 1073741823){ Value = yWDictionary.Backup9           },
                new SqlParameter("@Backup10"         , SqlDbType.NText    , 1073741823){ Value = yWDictionary.Backup10          },
                new SqlParameter("@Id"               , SqlDbType.Int      , 4         ){ Value = yWDictionary.Id                }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据数据字典（YWDictionary）的主键“编码（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">数据字典（YWDictionary）的主键“编码（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YWDictionary] "
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
            string sqlText = "DELETE FROM [YWDictionary] "
                           + paramList.SqlString;

            return SFL.SqlHelper.ExecuteNonQuery(sqlText, paramList.Parameters);
        }


        /// <summary>
        /// 根据数据字典（YWDictionary）的主键“编码（Id）”从数据库中获取数据字典（YWDictionary）的实例。
        /// 成功从数据库中取得记录返回新数据字典（YWDictionary）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">数据字典（YWDictionary）的主键“编码（Id）”</param>
        public override YWDictionary GetDataById(int id)
        {
            YWDictionary yWDictionary = null;
            string sqlText = "SELECT [Id],[DictionaryTypeId],[CodeId],[Name],[Description],[Backup1],[Backup2],[Backup3],[Backup4],[Backup5],[Backup6],[Backup7],[Backup8],[Backup9],"
                           + "[Backup10] "
                           + "FROM [YWDictionary] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWDictionary = new YWDictionary();
                ReadYWDictionaryAllData(sqlDataReader,yWDictionary);
            }
            sqlDataReader.Close();
            return yWDictionary;
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


    }
}
