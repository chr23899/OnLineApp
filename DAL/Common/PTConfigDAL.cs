﻿using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using Chr.OnlineApp.COL;
using Chr.OnlineApp.SFL;

namespace Chr.OnlineApp.DAL.Common
{
    /// <summary>
    /// 对象名称：配置设置通用数据访问父类（数据访问层）
    /// 对象说明：提供“配置设置类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“配置设置类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：chr
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public abstract class PTConfigDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“配置设置（PTConfigDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static PTConfigDAL pTConfigDAL;


        /// <summary>
        /// 获取“配置设置（PTConfigDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“配置设置（PTConfigDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static PTConfigDAL Instance
        {
            get
            {
                if (pTConfigDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            pTConfigDAL = new SqlServer.PTConfigDAL();
                            break;

                        default:
                            pTConfigDAL = new SqlServer.PTConfigDAL();
                            break;
                    }
                }
                return pTConfigDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为PTConfig对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="pTConfiguration">配置设置（PTConfig）实例对象</param>
        protected void ReadPTConfigAllData(IDataReader dataReader, PTConfig pTConfiguration)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                pTConfiguration.Id = Convert.ToString(dataReader["Id"]);
            // 名称
            if (dataReader["Name"] != DBNull.Value)
                pTConfiguration.Name = Convert.ToString(dataReader["Name"]);
            // 类型
            if (dataReader["TypeId"] != DBNull.Value)
                pTConfiguration.Type = Convert.ToString(dataReader["TypeId"]);
            // 分组
            if (dataReader["GroupId"] != DBNull.Value)
                pTConfiguration.GroupId = Convert.ToInt32(dataReader["GroupId"]);
            // 默认值
            if (dataReader["DefaultValue"] != DBNull.Value)
                pTConfiguration.DefaultValue = Convert.ToString(dataReader["DefaultValue"]);
            // 备注
            if (dataReader["Notes"] != DBNull.Value)
                pTConfiguration.Notes = Convert.ToString(dataReader["Notes"]);
            // 备用１
            if (dataReader["Alternate1"] != DBNull.Value)
                pTConfiguration.Alternate1 = Convert.ToString(dataReader["Alternate1"]);
            // 备用２
            if (dataReader["Alternate2"] != DBNull.Value)
                pTConfiguration.Alternate2 = Convert.ToString(dataReader["Alternate2"]);
            // 备用３
            if (dataReader["Alternate3"] != DBNull.Value)
                pTConfiguration.Alternate3 = Convert.ToString(dataReader["Alternate3"]);
            // 备用４
            if (dataReader["Alternate4"] != DBNull.Value)
                pTConfiguration.Alternate4 = Convert.ToString(dataReader["Alternate4"]);
            // 备用５
            if (dataReader["Alternate5"] != DBNull.Value)
                pTConfiguration.Alternate5 = Convert.ToString(dataReader["Alternate5"]);
        }

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将配置设置（PTConfig）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTConfiguration">配置设置（PTConfig）实例对象</param>
        public abstract int Insert(PTConfig pTConfiguration);


        /// <summary>
        /// 将配置设置（PTConfig）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTConfiguration">配置设置（PTConfig）实例对象</param>
        public abstract int Update(PTConfig pTConfiguration);


        /// <summary>
        /// 根据配置设置（PTConfig）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">配置设置（PTConfig）的主键“编号（Id）”</param>
        public abstract int Delete(string id);


        /// <summary>
        /// 根据配置设置（PTConfig）的主键“编号（Id）”从数据库中获取配置设置（PTConfig）的实例。
        /// 成功从数据库中取得记录返回新配置设置（PTConfig）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">配置设置（PTConfig）的主键“编号（Id）”</param>
        public abstract PTConfig GetDataById(string id);

         /// <summary>
        /// 从数据库中读取并返回所有配置项（PTConfig）List列表。
        /// </summary>
        public abstract List<PTConfig> GetAllList();
     


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍







    }
}
