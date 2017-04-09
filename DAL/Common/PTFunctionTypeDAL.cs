using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using OnlineApp.COL;
using OnlineApp.SFL;

namespace OnlineApp.DAL.Common
{
    /// <summary>
    /// 对象名称：功能类型（码表）通用数据访问父类（数据访问层）
    /// 对象说明：提供“功能类型（码表）类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“功能类型（码表）类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public abstract class PTFunctionTypeDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“功能类型（码表）（PTFunctionTypeDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static PTFunctionTypeDAL pTFunctionTypeDAL;


        /// <summary>
        /// 获取“功能类型（码表）（PTFunctionTypeDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“功能类型（码表）（PTFunctionTypeDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static PTFunctionTypeDAL Instance
        {
            get
            {
                if (pTFunctionTypeDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            pTFunctionTypeDAL = new SqlServer.PTFunctionTypeDAL();
                            break;

                        default:
                            pTFunctionTypeDAL = new SqlServer.PTFunctionTypeDAL();
                            break;
                    }
                }
                return pTFunctionTypeDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为PTFunctionType对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="functionType">功能类型（码表）（PTFunctionType）实例对象</param>
        protected void ReadPTFunctionTypeAllData(IDataReader dataReader, PTFunctionType pTFunctionType)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                pTFunctionType.Id = Convert.ToString(dataReader["Id"]);
            // 名称
            if (dataReader["Name"] != DBNull.Value)
                pTFunctionType.Name = Convert.ToString(dataReader["Name"]);
            // 描述
            if (dataReader["Description"] != DBNull.Value)
                pTFunctionType.Description = Convert.ToString(dataReader["Description"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将功能类型（码表）（PTFunctionType）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="functionType">功能类型（码表）（PTFunctionType）实例对象</param>
        public abstract int Insert(PTFunctionType pTFunctionType);


        /// <summary>
        /// 将功能类型（码表）（PTFunctionType）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="functionType">功能类型（码表）（PTFunctionType）实例对象</param>
        public abstract int Update(PTFunctionType pTFunctionType);


        /// <summary>
        /// 根据功能类型（码表）（PTFunctionType）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">功能类型（码表）（PTFunctionType）的主键“编号（Id）”</param>
        public abstract int Delete(string id);


        /// <summary>
        /// 根据功能类型（码表）（PTFunctionType）的主键“编号（Id）”从数据库中获取功能类型（码表）（PTFunctionType）的实例。
        /// 成功从数据库中取得记录返回新功能类型（码表）（PTFunctionType）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">功能类型（码表）（PTFunctionType）的主键“编号（Id）”</param>
        public abstract PTFunctionType GetDataById(string id);


        /// <summary>
        /// 从数据库中读取并返回所有功能类型（码表）（PTFunctionType）List列表。
        /// </summary>
        public abstract List<PTFunctionType> GetAllList();




        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
