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
    /// 对象名称：数据字典通用数据访问父类（数据访问层）
    /// 对象说明：提供“数据字典类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“数据字典类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：chr
    /// 编写日期：2014-11-8 9:36:12
    /// </summary>
    public abstract class YWDictionaryDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“数据字典（YWDictionaryDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static YWDictionaryDAL yWDictionaryDAL;


        /// <summary>
        /// 获取“数据字典（YWDictionaryDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“数据字典（YWDictionaryDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static YWDictionaryDAL Instance
        {
            get
            {
                if (yWDictionaryDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            yWDictionaryDAL = new SqlServer.YWDictionaryDAL();
                            break;

                        default:
                            yWDictionaryDAL = new SqlServer.YWDictionaryDAL();
                            break;
                    }
                }
                return yWDictionaryDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWDictionary对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWDictionary">数据字典（YWDictionary）实例对象</param>
        protected void ReadYWDictionaryAllData(IDataReader dataReader, YWDictionary yWDictionary)
        {
            // 编码
            if (dataReader["Id"] != DBNull.Value)
                yWDictionary.Id = Convert.ToInt32(dataReader["Id"]);
            // 类别
            if (dataReader["DictionaryTypeId"] != DBNull.Value)
                yWDictionary.DictionaryType = Convert.ToString(dataReader["DictionaryTypeId"]);
            // 识别码
            if (dataReader["CodeId"] != DBNull.Value)
                yWDictionary.CodeId = Convert.ToString(dataReader["CodeId"]);
            // 名称
            if (dataReader["Name"] != DBNull.Value)
                yWDictionary.Name = Convert.ToString(dataReader["Name"]);
            // 描述
            if (dataReader["Description"] != DBNull.Value)
                yWDictionary.Description = Convert.ToString(dataReader["Description"]);
            // 备用１
            if (dataReader["Backup1"] != DBNull.Value)
                yWDictionary.Backup1 = Convert.ToString(dataReader["Backup1"]);
            // 备用２
            if (dataReader["Backup2"] != DBNull.Value)
                yWDictionary.Backup2 = Convert.ToString(dataReader["Backup2"]);
            // 备用３
            if (dataReader["Backup3"] != DBNull.Value)
                yWDictionary.Backup3 = Convert.ToString(dataReader["Backup3"]);
            // 备用４
            if (dataReader["Backup4"] != DBNull.Value)
                yWDictionary.Backup4 = Convert.ToString(dataReader["Backup4"]);
            // 备用５
            if (dataReader["Backup5"] != DBNull.Value)
                yWDictionary.Backup5 = Convert.ToString(dataReader["Backup5"]);
            // 备用６
            if (dataReader["Backup6"] != DBNull.Value)
                yWDictionary.Backup6 = Convert.ToString(dataReader["Backup6"]);
            // 备用７
            if (dataReader["Backup7"] != DBNull.Value)
                yWDictionary.Backup7 = Convert.ToString(dataReader["Backup7"]);
            // 备用８
            if (dataReader["Backup8"] != DBNull.Value)
                yWDictionary.Backup8 = Convert.ToString(dataReader["Backup8"]);
            // 备用９
            if (dataReader["Backup9"] != DBNull.Value)
                yWDictionary.Backup9 = Convert.ToString(dataReader["Backup9"]);
            // 备用１０
            if (dataReader["Backup10"] != DBNull.Value)
                yWDictionary.Backup10 = Convert.ToString(dataReader["Backup10"]);
        }

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将数据字典（YWDictionary）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWDictionary">数据字典（YWDictionary）实例对象</param>
        public abstract int Insert(YWDictionary yWDictionary);


        /// <summary>
        /// 将数据字典（YWDictionary）数据，根据主键“编码（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWDictionary">数据字典（YWDictionary）实例对象</param>
        public abstract int Update(YWDictionary yWDictionary);


        /// <summary>
        /// 根据数据字典（YWDictionary）的主键“编码（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">数据字典（YWDictionary）的主键“编码（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据条件参数采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="paramList">条件参数</param>
        public abstract int DeleteByParams(Parameter paramList);


        /// <summary>
        /// 根据数据字典（YWDictionary）的主键“编码（Id）”从数据库中获取数据字典（YWDictionary）的实例。
        /// 成功从数据库中取得记录返回新数据字典（YWDictionary）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">数据字典（YWDictionary）的主键“编码（Id）”</param>
        public abstract YWDictionary GetDataById(int id);


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


    }
}
