﻿using System;
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
    /// 对象名称：人员通用数据访问父类（数据访问层）
    /// 对象说明：提供“人员类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“人员类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public abstract class YWPersonDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“人员（YWPersonDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static YWPersonDAL yWPersonDAL;


        /// <summary>
        /// 获取“人员（YWPersonDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“人员（YWPersonDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static YWPersonDAL Instance
        {
            get
            {
                if (yWPersonDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            yWPersonDAL = new SqlServer.YWPersonDAL();
                            break;

                        default:
                            yWPersonDAL = new SqlServer.YWPersonDAL();
                            break;
                    }
                }
                return yWPersonDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWPerson对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWPerson">人员（YWPerson）实例对象</param>
        protected void ReadYWPersonAllData(IDataReader dataReader, YWPerson yWPerson)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                yWPerson.Id = Convert.ToInt32(dataReader["Id"]);
            // 用户名
            if (dataReader["UserName"] != DBNull.Value)
                yWPerson.UserName = Convert.ToString(dataReader["UserName"]);
            // 姓名
            if (dataReader["Name"] != DBNull.Value)
                yWPerson.Name = Convert.ToString(dataReader["Name"]);
            // 性别
            if (dataReader["Sex"] != DBNull.Value)
                yWPerson.Sex = Convert.ToString(dataReader["Sex"]);
            // 出生年月
            if (dataReader["Birth"] != DBNull.Value)
                yWPerson.Birth = Convert.ToString(dataReader["Birth"]);
            // 入职时间
            if (dataReader["EntryTime"] != DBNull.Value)
                yWPerson.EntryTime = Convert.ToString(dataReader["EntryTime"]);
            // 电话
            if (dataReader["Phone"] != DBNull.Value)
                yWPerson.Phone = Convert.ToString(dataReader["Phone"]);
            // 身份证号
            if (dataReader["IDCardId"] != DBNull.Value)
                yWPerson.IDCardId = Convert.ToString(dataReader["IDCardId"]);
            // 评分
            if (dataReader["Score"] != DBNull.Value)
                yWPerson.Score = Convert.ToInt32(dataReader["Score"]);
            // 所属餐厅
            if (dataReader["OrgId"] != DBNull.Value)
                yWPerson.Org = Convert.ToInt32(dataReader["OrgId"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将人员（YWPerson）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPerson">人员（YWPerson）实例对象</param>
        public abstract int Insert(YWPerson yWPerson);


        /// <summary>
        /// 将人员（YWPerson）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPerson">人员（YWPerson）实例对象</param>
        public abstract int Update(YWPerson yWPerson);


        /// <summary>
        /// 根据人员（YWPerson）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">人员（YWPerson）的主键“编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据条件参数采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="paramList">条件参数</param>
        public abstract int DeleteByParams(Parameter paramList);


        /// <summary>
        /// 根据人员（YWPerson）的主键“编号（Id）”从数据库中获取人员（YWPerson）的实例。
        /// 成功从数据库中取得记录返回新人员（YWPerson）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">人员（YWPerson）的主键“编号（Id）”</param>
        public abstract YWPerson GetDataById(int id);


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


    }
}