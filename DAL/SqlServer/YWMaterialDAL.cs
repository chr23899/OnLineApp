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
    /// 对象名称：原料SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“原料类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“原料类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWMaterialDAL:DAL.Common.YWMaterialDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将原料（YWMaterial）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWMaterial">原料（YWMaterial）实例对象</param>
        public override int Insert(YWMaterial yWMaterial)
        {
            string sqlText = "INSERT INTO [YWMaterial]"
                           + "([Name],[ShortName],[MaterialTypeId],[StdUnit],[BelongTypeId],[StorageRules],[OtherUnits],[MinStorage],[OrgId],[InventoryCycle])"
                           + "VALUES"
                           + "(@Name,@ShortName,@MaterialTypeId,@StdUnit,@BelongTypeId,@StorageRules,@OtherUnits,@MinStorage,@OrgId,@InventoryCycle)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Name"           , SqlDbType.NVarChar , 50        ){ Value = yWMaterial.Name            },
                new SqlParameter("@ShortName"      , SqlDbType.NVarChar , 50        ){ Value = yWMaterial.ShortName       },
                new SqlParameter("@MaterialTypeId" , SqlDbType.Int      , 4         ){ Value = yWMaterial.MaterialType    },
                new SqlParameter("@StdUnit"        , SqlDbType.NVarChar , 50        ){ Value = yWMaterial.StdUnit         },
                new SqlParameter("@BelongTypeId"   , SqlDbType.Int      , 4         ){ Value = yWMaterial.BelongType      },
                new SqlParameter("@StorageRules"   , SqlDbType.NVarChar , 50        ){ Value = yWMaterial.StorageRules    },
                new SqlParameter("@OtherUnits"     , SqlDbType.NText    , 1073741823){ Value = yWMaterial.OtherUnits      },
                new SqlParameter("@MinStorage"     , SqlDbType.Int      , 4         ){ Value = yWMaterial.MinStorage      },
                new SqlParameter("@OrgId"          , SqlDbType.Int      , 4         ){ Value = yWMaterial.Org             },
                new SqlParameter("@InventoryCycle" , SqlDbType.Int      , 4         ){ Value = yWMaterial.InventoryCycle  }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将原料（YWMaterial）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWMaterial">原料（YWMaterial）实例对象</param>
        public override int Update(YWMaterial yWMaterial)
        {
            string sqlText = "UPDATE [YWMaterial] SET "
                           + "[Name]=@Name,[ShortName]=@ShortName,[MaterialTypeId]=@MaterialTypeId,[StdUnit]=@StdUnit,[BelongTypeId]=@BelongTypeId,"
                           + "[StorageRules]=@StorageRules,[OtherUnits]=@OtherUnits,[MinStorage]=@MinStorage,[OrgId]=@OrgId,[InventoryCycle]=@InventoryCycle "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Name"           , SqlDbType.NVarChar , 50        ){ Value = yWMaterial.Name            },
                new SqlParameter("@ShortName"      , SqlDbType.NVarChar , 50        ){ Value = yWMaterial.ShortName       },
                new SqlParameter("@MaterialTypeId" , SqlDbType.Int      , 4         ){ Value = yWMaterial.MaterialType    },
                new SqlParameter("@StdUnit"        , SqlDbType.NVarChar , 50        ){ Value = yWMaterial.StdUnit         },
                new SqlParameter("@BelongTypeId"   , SqlDbType.Int      , 4         ){ Value = yWMaterial.BelongType      },
                new SqlParameter("@StorageRules"   , SqlDbType.NVarChar , 50        ){ Value = yWMaterial.StorageRules    },
                new SqlParameter("@OtherUnits"     , SqlDbType.NText    , 1073741823){ Value = yWMaterial.OtherUnits      },
                new SqlParameter("@MinStorage"     , SqlDbType.Int      , 4         ){ Value = yWMaterial.MinStorage      },
                new SqlParameter("@OrgId"          , SqlDbType.Int      , 4         ){ Value = yWMaterial.Org             },
                new SqlParameter("@InventoryCycle" , SqlDbType.Int      , 4         ){ Value = yWMaterial.InventoryCycle  },
                new SqlParameter("@Id"             , SqlDbType.Int      , 4         ){ Value = yWMaterial.Id              }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据原料（YWMaterial）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">原料（YWMaterial）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YWMaterial] "
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
            string sqlText = "DELETE FROM [YWMaterial] "
                           + paramList.SqlString;
           
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, paramList.Parameters);
        }


        /// <summary>
        /// 根据原料（YWMaterial）的主键“编号（Id）”从数据库中获取原料（YWMaterial）的实例。
        /// 成功从数据库中取得记录返回新原料（YWMaterial）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">原料（YWMaterial）的主键“编号（Id）”</param>
        public override YWMaterial GetDataById(int id)
        {
            YWMaterial yWMaterial = null;
            string sqlText = "SELECT [Id],[Name],[ShortName],[MaterialTypeId],[StdUnit],[BelongTypeId],[StorageRules],[OtherUnits],[MinStorage],[OrgId],[InventoryCycle] "
                           + "FROM [YWMaterial] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWMaterial = new YWMaterial();
                ReadYWMaterialAllData(sqlDataReader,yWMaterial);
            }
            sqlDataReader.Close();
            return yWMaterial;
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

    }
}
