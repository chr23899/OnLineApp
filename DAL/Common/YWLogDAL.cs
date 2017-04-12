using System;
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
    /// 对象名称：日志通用数据访问父类（数据访问层）
    /// 对象说明：提供“日志类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“日志类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：chr
    /// 编写日期：2016-1-16 10:55:02
    /// </summary>
    public abstract class YWLogDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“日志（YWLogDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static YWLogDAL yWLogDAL;


        /// <summary>
        /// 获取“日志（YWLogDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“日志（YWLogDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static YWLogDAL Instance
        {
            get
            {
                if (yWLogDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            yWLogDAL = new SqlServer.YWLogDAL();
                            break;

                        default:
                            yWLogDAL = new SqlServer.YWLogDAL();
                            break;
                    }
                }
                return yWLogDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWLog对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWLog">日志（YWLog）实例对象</param>
        protected void ReadYWLogAllData(IDataReader dataReader, YWLog yWLog)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                yWLog.Id = Convert.ToInt32(dataReader["Id"]);
            // 业务类别
            if (dataReader["YWTypeId"] != DBNull.Value)
            {
                YWDictionary tmpYWDictionary = YWDictionaryDAL.Instance.GetDataById(Convert.ToInt32(dataReader["YWTypeId"]));
                if (tmpYWDictionary != null) yWLog.YWType = tmpYWDictionary;
            }
            // 业务数据编号
            if (dataReader["YWRecordId"] != DBNull.Value)
                yWLog.YWRecordId = Convert.ToInt32(dataReader["YWRecordId"]);
            // 操作人
            if (dataReader["OprUserName"] != DBNull.Value)
            {
                PTUsers tmpPTUsers = PTUsersDAL.Instance.GetDataByUserName(Convert.ToString(dataReader["OprUserName"]));
                if (tmpPTUsers != null) yWLog.Opr = tmpPTUsers;
            }
            // 操作时间
            if (dataReader["OprTime"] != DBNull.Value)
                yWLog.OprTime = Convert.ToDateTime(dataReader["OprTime"]);
            // 描述
            if (dataReader["Description"] != DBNull.Value)
                yWLog.Description = Convert.ToString(dataReader["Description"]);
            // 备用1
            if (dataReader["Backup1"] != DBNull.Value)
                yWLog.Backup1 = Convert.ToString(dataReader["Backup1"]);
            // 备用2
            if (dataReader["Backup2"] != DBNull.Value)
                yWLog.Backup2 = Convert.ToString(dataReader["Backup2"]);
            // 备用3
            if (dataReader["Backup3"] != DBNull.Value)
                yWLog.Backup3 = Convert.ToString(dataReader["Backup3"]);
            // 备用4
            if (dataReader["Backup4"] != DBNull.Value)
                yWLog.Backup4 = Convert.ToString(dataReader["Backup4"]);
            // 备用5
            if (dataReader["Backup5"] != DBNull.Value)
                yWLog.Backup5 = Convert.ToString(dataReader["Backup5"]);
            // 备用6
            if (dataReader["Backup6"] != DBNull.Value)
                yWLog.Backup6 = Convert.ToString(dataReader["Backup6"]);
            // 备用7
            if (dataReader["Backup7"] != DBNull.Value)
                yWLog.Backup7 = Convert.ToString(dataReader["Backup7"]);
            // 备用8
            if (dataReader["Backup8"] != DBNull.Value)
                yWLog.Backup8 = Convert.ToString(dataReader["Backup8"]);
            // 备用9
            if (dataReader["Backup9"] != DBNull.Value)
                yWLog.Backup9 = Convert.ToString(dataReader["Backup9"]);
            // 备用10
            if (dataReader["Backup10"] != DBNull.Value)
                yWLog.Backup10 = Convert.ToString(dataReader["Backup10"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWLog对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWLog">日志（YWLog）实例对象</param>
        protected void ReadYWLogPageData(IDataReader dataReader, YWLog yWLog)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                yWLog.Id = Convert.ToInt32(dataReader["Id"]);
            // 业务类别
            if (dataReader["YWTypeId"] != DBNull.Value)
            {
                YWDictionary tmpYWDictionary = YWDictionaryDAL.Instance.GetDataById(Convert.ToInt32(dataReader["YWTypeId"]));
                if (tmpYWDictionary != null) yWLog.YWType = tmpYWDictionary;
            }
            // 业务数据编号
            if (dataReader["YWRecordId"] != DBNull.Value)
                yWLog.YWRecordId = Convert.ToInt32(dataReader["YWRecordId"]);
            // 操作人
            if (dataReader["OprUserName"] != DBNull.Value)
            {
                PTUsers tmpPTUsers = PTUsersDAL.Instance.GetDataByUserName(Convert.ToString(dataReader["OprUserName"]));
                if (tmpPTUsers != null) yWLog.Opr = tmpPTUsers;
            }
            // 操作时间
            if (dataReader["OprTime"] != DBNull.Value)
                yWLog.OprTime = Convert.ToDateTime(dataReader["OprTime"]);
            // 描述
            if (dataReader["Description"] != DBNull.Value)
                yWLog.Description = Convert.ToString(dataReader["Description"]);
            // 备用1
            if (dataReader["Backup1"] != DBNull.Value)
                yWLog.Backup1 = Convert.ToString(dataReader["Backup1"]);
            // 备用2
            if (dataReader["Backup2"] != DBNull.Value)
                yWLog.Backup2 = Convert.ToString(dataReader["Backup2"]);
            // 备用3
            if (dataReader["Backup3"] != DBNull.Value)
                yWLog.Backup3 = Convert.ToString(dataReader["Backup3"]);
            // 备用4
            if (dataReader["Backup4"] != DBNull.Value)
                yWLog.Backup4 = Convert.ToString(dataReader["Backup4"]);
            // 备用5
            if (dataReader["Backup5"] != DBNull.Value)
                yWLog.Backup5 = Convert.ToString(dataReader["Backup5"]);
            // 备用6
            if (dataReader["Backup6"] != DBNull.Value)
                yWLog.Backup6 = Convert.ToString(dataReader["Backup6"]);
            // 备用7
            if (dataReader["Backup7"] != DBNull.Value)
                yWLog.Backup7 = Convert.ToString(dataReader["Backup7"]);
            // 备用8
            if (dataReader["Backup8"] != DBNull.Value)
                yWLog.Backup8 = Convert.ToString(dataReader["Backup8"]);
            // 备用9
            if (dataReader["Backup9"] != DBNull.Value)
                yWLog.Backup9 = Convert.ToString(dataReader["Backup9"]);
            // 备用10
            if (dataReader["Backup10"] != DBNull.Value)
                yWLog.Backup10 = Convert.ToString(dataReader["Backup10"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将日志（YWLog）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWLog">日志（YWLog）实例对象</param>
        public abstract int Insert(YWLog yWLog);


        /// <summary>
        /// 将日志（YWLog）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWLog">日志（YWLog）实例对象</param>
        public abstract int Update(YWLog yWLog);


        /// <summary>
        /// 根据日志（YWLog）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">日志（YWLog）的主键“编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据日志（YWLog）的主键“编号（Id）”从数据库中获取日志（YWLog）的实例。
        /// 成功从数据库中取得记录返回新日志（YWLog）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">日志（YWLog）的主键“编号（Id）”</param>
        public abstract YWLog GetDataById(int id);


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


    }
}
