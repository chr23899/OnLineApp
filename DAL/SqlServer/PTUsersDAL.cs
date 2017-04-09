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
    /// 对象名称：基本用户信息SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“基本用户信息类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“基本用户信息类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：chr
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTUsersDAL:DAL.Common.PTUsersDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将基本用户信息（PTUsers）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTUsers">基本用户信息（PTUsers）实例对象</param>
        public override int Insert(PTUsers pTUsers)
        {
            string sqlText = "INSERT INTO [PT_USER]"
                           + "([UserName],[Password],[OrgId],[Nickname],[StateId],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5],[Tel],[LevelId],[Type],[Layer],[Note])"
                           + "VALUES"
                           + "(@UserName,@Password,@OrgId,@Nickname,@StateId,@Alternate1,@Alternate2,@Alternate3,@Alternate4,@Alternate5,@Tel,@LevelId,@Type,@Layer,@Note)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = pTUsers.UserName   },
                new SqlParameter("@Password"   , SqlDbType.NVarChar , 50 ){ Value = pTUsers.Password   },
                new SqlParameter("@OrgId"      , SqlDbType.Int      , 4  ){ Value = pTUsers.OrgId      },
                new SqlParameter("@Nickname"   , SqlDbType.NVarChar , 50 ){ Value = pTUsers.Nickname   },
                new SqlParameter("@StateId"    , SqlDbType.NVarChar , 50 ){ Value = pTUsers.StateId    },
                new SqlParameter("@Alternate1" , SqlDbType.NVarChar , 50 ){ Value = pTUsers.Alternate1 },
                new SqlParameter("@Alternate2" , SqlDbType.NText    , 1073741823){ Value = pTUsers.Alternate2 },
                new SqlParameter("@Alternate3" , SqlDbType.NVarChar , 50 ){ Value = pTUsers.Alternate3 },
                new SqlParameter("@Alternate4" , SqlDbType.NVarChar , 500){ Value = pTUsers.Alternate4 },
                new SqlParameter("@Alternate5" , SqlDbType.NVarChar , 500){ Value = pTUsers.Alternate5 },
                new SqlParameter("@Tel" , SqlDbType.NVarChar , 500){ Value = pTUsers.Tel },
                new SqlParameter("@LevelId" , SqlDbType.NVarChar , 500){ Value = pTUsers.LevelId },
                new SqlParameter("@Type" , SqlDbType.NVarChar , 500){ Value = pTUsers.Type },
                new SqlParameter("@Layer" , SqlDbType.NVarChar , 500){ Value = pTUsers.Layer },
                new SqlParameter("@Note" , SqlDbType.NVarChar , 500){ Value = pTUsers.Note }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将基本用户信息（PTUsers）数据，根据主键“用户名（UserName）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTUsers">基本用户信息（PTUsers）实例对象</param>
        public override int Update(PTUsers pTUsers)
        {
            string sqlText = "UPDATE [PT_USER] SET "
                           + "[Password]=@Password,[OrgId]=@OrgId,[Nickname]=@Nickname,[StateId]=@StateId,[Alternate1]=@Alternate1,[Alternate2]=@Alternate2,"
                           + "[Alternate3]=@Alternate3,[Alternate4]=@Alternate4,[Alternate5]=@Alternate5,[Tel]=@Tel,[Type]=@Type,[Layer]=@Layer,[Note]=@Note "
                           + "WHERE [UserName]=@UserName";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Password"   , SqlDbType.NVarChar , 50 ){ Value = pTUsers.Password   },
                new SqlParameter("@OrgId"      , SqlDbType.Int      , 4  ){ Value = pTUsers.OrgId      },
                new SqlParameter("@Nickname"   , SqlDbType.NVarChar , 50 ){ Value = pTUsers.Nickname   },
                new SqlParameter("@StateId"    , SqlDbType.NVarChar , 50 ){ Value = pTUsers.StateId    },
                new SqlParameter("@Alternate1" , SqlDbType.NVarChar , 50 ){ Value = pTUsers.Alternate1 },
                new SqlParameter("@Alternate2" , SqlDbType.NText    , 1073741823){ Value = pTUsers.Alternate2 },
                new SqlParameter("@Alternate3" , SqlDbType.NVarChar , 50 ){ Value = pTUsers.Alternate3 },
                new SqlParameter("@Alternate4" , SqlDbType.NVarChar , 500){ Value = pTUsers.Alternate4 },
                new SqlParameter("@Alternate5" , SqlDbType.NVarChar , 500){ Value = pTUsers.Alternate5 },
                new SqlParameter("@Tel" , SqlDbType.NVarChar , 50){ Value = pTUsers.Tel },
                new SqlParameter("@Type" , SqlDbType.NVarChar , 50){ Value = pTUsers.Type },
                new SqlParameter("@Layer" , SqlDbType.NVarChar , 50){ Value = pTUsers.Layer },
                new SqlParameter("@Note" , SqlDbType.NVarChar , 50){ Value = pTUsers.Note },
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = pTUsers.UserName   }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据基本用户信息（PTUsers）的主键“用户名（UserName）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="userName">基本用户信息（PTUsers）的主键“用户名（UserName）”</param>
        public override int Delete(string userName)
        {
            string sqlText = "DELETE FROM [PT_USER] "
                           + "WHERE [UserName]=@UserName";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName" , SqlDbType.NVarChar , 50){ Value = userName }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据基本用户信息（PTUsers）的主键“用户名（UserName）”从数据库中获取基本用户信息（PTUsers）的实例。
        /// 成功从数据库中取得记录返回新基本用户信息（PTUsers）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="userName">基本用户信息（PTUsers）的主键“用户名（UserName）”</param>
        public override PTUsers GetDataByUserName(string userName)
        {
            PTUsers pTUsers = null;
            string sqlText = "SELECT [Id],[UserName],[Password],[OrgId],[Nickname],[StateId],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] "
                           + "FROM [PT_USER] "
                           + "WHERE [UserName]=@UserName";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName" , SqlDbType.NVarChar , 50){ Value = userName }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                pTUsers = new PTUsers();
                ReadPTUsersAllData(sqlDataReader,pTUsers);
            }
            sqlDataReader.Close();
            return pTUsers;
        }


        

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

       

    }
}
