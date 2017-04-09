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
    /// 对象名称：还款通用数据访问父类（数据访问层）
    /// 对象说明：提供“还款类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“还款类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public abstract class YWPayBackDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“还款（YWPayBackDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static YWPayBackDAL yWPayBackDAL;


        /// <summary>
        /// 获取“还款（YWPayBackDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“还款（YWPayBackDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static YWPayBackDAL Instance
        {
            get
            {
                if (yWPayBackDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            yWPayBackDAL = new SqlServer.YWPayBackDAL();
                            break;

                        default:
                            yWPayBackDAL = new SqlServer.YWPayBackDAL();
                            break;
                    }
                }
                return yWPayBackDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWPayBack对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWPayBack">还款（YWPayBack）实例对象</param>
        protected void ReadYWPayBackAllData(IDataReader dataReader, YWPayBack yWPayBack)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                yWPayBack.Id = Convert.ToInt32(dataReader["Id"]);
            // 关联预支
            if (dataReader["PrePayId"] != DBNull.Value)
                yWPayBack.PrePay = Convert.ToInt32(dataReader["PrePayId"]);
            // 还款金额
            if (dataReader["ReturnAmount"] != DBNull.Value)
                yWPayBack.ReturnAmount = Convert.ToDouble(dataReader["ReturnAmount"]);
            // 还款时间
            if (dataReader["ReturnTime"] != DBNull.Value)
                yWPayBack.ReturnTime = Convert.ToString(dataReader["ReturnTime"]);
            // 还款人
            if (dataReader["ReturnUserName"] != DBNull.Value)
                yWPayBack.ReturnUser = Convert.ToString(dataReader["ReturnUserName"]);
            // 收款人
            if (dataReader["ReceiveUserName"] != DBNull.Value)
                yWPayBack.ReceiveUser = Convert.ToString(dataReader["ReceiveUserName"]);
            // 备注
            if (dataReader["Notes"] != DBNull.Value)
                yWPayBack.Notes = Convert.ToString(dataReader["Notes"]);
            // 所属餐厅
            if (dataReader["OrgId"] != DBNull.Value)
                yWPayBack.Org = Convert.ToInt32(dataReader["OrgId"]);
        }




        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将还款（YWPayBack）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPayBack">还款（YWPayBack）实例对象</param>
        public abstract int Insert(YWPayBack yWPayBack);


        /// <summary>
        /// 将还款（YWPayBack）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWPayBack">还款（YWPayBack）实例对象</param>
        public abstract int Update(YWPayBack yWPayBack);


        /// <summary>
        /// 根据还款（YWPayBack）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">还款（YWPayBack）的主键“编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据条件参数采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="paramList">条件参数</param>
        public abstract int DeleteByParams(Parameter paramList);


        /// <summary>
        /// 根据还款（YWPayBack）的主键“编号（Id）”从数据库中获取还款（YWPayBack）的实例。
        /// 成功从数据库中取得记录返回新还款（YWPayBack）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">还款（YWPayBack）的主键“编号（Id）”</param>
        public abstract YWPayBack GetDataById(int id);


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


    }
}
