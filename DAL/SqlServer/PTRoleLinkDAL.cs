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
    /// 对象名称：角色权限关联表SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“角色权限关联表类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“角色权限关联表类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTRoleLinkDAL:DAL.Common.PTRoleLinkDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将角色权限关联表（PTRoleLink）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTRoleLink">角色权限关联表（PTRoleLink）实例对象</param>
        public override int Insert(PTRoleLink pTRoleLink)
        {
            string sqlText = "INSERT INTO [PT_RoleLink]"
                           + "([RoleId],[FunctionId])"
                           + "VALUES"
                           + "(@RoleId,@FunctionId)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@RoleId"     , SqlDbType.Int      , 4 ){ Value = pTRoleLink.RoleId        },
                new SqlParameter("@FunctionId" , SqlDbType.NVarChar , 50){ Value = pTRoleLink.FunctionId    }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将角色权限关联表（PTRoleLink）数据，根据主键“序号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTRoleLink">角色权限关联表（PTRoleLink）实例对象</param>
        public override int Update(PTRoleLink pTRoleLink)
        {
            string sqlText = "UPDATE [PT_RoleLink] SET "
                           + "[RoleId]=@RoleId,[FunctionId]=@FunctionId "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@RoleId"     , SqlDbType.Int      , 4 ){ Value = pTRoleLink.RoleId        },
                new SqlParameter("@FunctionId" , SqlDbType.NVarChar , 50){ Value = pTRoleLink.FunctionId    },
                new SqlParameter("@Id"         , SqlDbType.Int      , 4 ){ Value = pTRoleLink.Id            }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据角色权限关联表（PTRoleLink）的主键“序号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">角色权限关联表（PTRoleLink）的主键“序号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [PT_RoleLink] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据角色权限关联表（PTRoleLink）的主键“序号（Id）”从数据库中获取角色权限关联表（PTRoleLink）的实例。
        /// 成功从数据库中取得记录返回新角色权限关联表（PTRoleLink）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">角色权限关联表（PTRoleLink）的主键“序号（Id）”</param>
        public override PTRoleLink GetDataById(int id)
        {
            PTRoleLink pTRoleLink = null;
            string sqlText = "SELECT [Id],[RoleId],[FunctionId] "
                           + "FROM [PT_RoleLink] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                pTRoleLink = new PTRoleLink();
                ReadRoleLinkAllData(sqlDataReader,pTRoleLink);
            }
            sqlDataReader.Close();
            return pTRoleLink;
        }


       

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

       

    }
}
