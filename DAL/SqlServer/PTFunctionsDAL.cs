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
    /// 对象名称：系统功能列表SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“系统功能列表类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“系统功能列表类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：chr
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTFunctionsDAL:DAL.Common.PTFunctionsDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将系统功能列表（PTFunctions）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTFunctions">系统功能列表（PTFunctions）实例对象</param>
        public override int Insert(PTFunctions pTFunctions)
        {
            string sqlText = "INSERT INTO [PT_FUNCTION]"
                           + "([Id],[FatherNumber],[FunctionName],[FunctionTypeId],[FunctionPath],[Description],[StateId],[Alternate1],[Alternate2],[Alternate3],"
                           + "[Alternate4],[Alternate5])"
                           + "VALUES"
                           + "(@Id,@FatherNumber,@FunctionName,@FunctionTypeId,@FunctionPath,@Description,@StateId,@Alternate1,@Alternate2,@Alternate3,"
                           + "@Alternate4,@Alternate5)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id"             , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.Id                },
                new SqlParameter("@FatherNumber"   , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.FatherNumber      },
                new SqlParameter("@FunctionName"   , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.FunctionName      },
                new SqlParameter("@FunctionTypeId" , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.FunctionTypeId    },
                new SqlParameter("@FunctionPath"   , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.FunctionPath      },
                new SqlParameter("@Description"    , SqlDbType.NVarChar , 500){ Value = pTFunctions.Description       },
                new SqlParameter("@StateId"        , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.StateId           },
                new SqlParameter("@Alternate1"     , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.Alternate1        },
                new SqlParameter("@Alternate2"     , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.Alternate2        },
                new SqlParameter("@Alternate3"     , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.Alternate3        },
                new SqlParameter("@Alternate4"     , SqlDbType.NVarChar , 500){ Value = pTFunctions.Alternate4        },
                new SqlParameter("@Alternate5"     , SqlDbType.NVarChar , 500){ Value = pTFunctions.Alternate5        }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将系统功能列表（PTFunctions）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTFunctions">系统功能列表（PTFunctions）实例对象</param>
        public override int Update(PTFunctions pTFunctions)
        {
            string sqlText = "UPDATE [PT_FUNCTION] SET "
                           + "[FatherNumber]=@FatherNumber,[FunctionName]=@FunctionName,[FunctionTypeId]=@FunctionTypeId,[FunctionPath]=@FunctionPath,"
                           + "[Description]=@Description,[StateId]=@StateId,[Alternate1]=@Alternate1,[Alternate2]=@Alternate2,[Alternate3]=@Alternate3,[Alternate4]=@Alternate4,"
                           + "[Alternate5]=@Alternate5 "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@FatherNumber"   , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.FatherNumber      },
                new SqlParameter("@FunctionName"   , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.FunctionName      },
                new SqlParameter("@FunctionTypeId" , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.FunctionTypeId    },
                new SqlParameter("@FunctionPath"   , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.FunctionPath      },
                new SqlParameter("@Description"    , SqlDbType.NVarChar , 500){ Value = pTFunctions.Description       },
                new SqlParameter("@StateId"        , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.StateId           },
                new SqlParameter("@Alternate1"     , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.Alternate1        },
                new SqlParameter("@Alternate2"     , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.Alternate2        },
                new SqlParameter("@Alternate3"     , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.Alternate3        },
                new SqlParameter("@Alternate4"     , SqlDbType.NVarChar , 500){ Value = pTFunctions.Alternate4        },
                new SqlParameter("@Alternate5"     , SqlDbType.NVarChar , 500){ Value = pTFunctions.Alternate5        },
                new SqlParameter("@Id"             , SqlDbType.NVarChar , 50 ){ Value = pTFunctions.Id                }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据系统功能列表（PTFunctions）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">系统功能列表（PTFunctions）的主键“编号（Id）”</param>
        public override int Delete(string id)
        {
            string sqlText = "DELETE FROM [PT_FUNCTION] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.NVarChar , 50){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据系统功能列表（PTFunctions）的主键“编号（Id）”从数据库中获取系统功能列表（PTFunctions）的实例。
        /// 成功从数据库中取得记录返回新系统功能列表（PTFunctions）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">系统功能列表（PTFunctions）的主键“编号（Id）”</param>
        public override PTFunctions GetDataById(string id)
        {
            PTFunctions pTFunctions = null;
            string sqlText = "SELECT [Id],[FatherNumber],[FunctionName],[FunctionTypeId],[FunctionPath],[Description],[StateId],[Alternate1],[Alternate2],[Alternate3],"
                           + "[Alternate4],[Alternate5] "
                           + "FROM [PT_FUNCTION] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.NVarChar , 50){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                pTFunctions = new PTFunctions();
                ReadPTFunctionsAllData(sqlDataReader,pTFunctions);
            }
            sqlDataReader.Close();
            return pTFunctions;
        }


       

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍





    }
}
