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
    /// 对象名称：餐厅通用数据访问父类（数据访问层）
    /// 对象说明：提供“餐厅类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“餐厅类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public abstract class YWRestaurantDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“餐厅（YWRestaurantDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static YWRestaurantDAL yWRestaurantDAL;


        /// <summary>
        /// 获取“餐厅（YWRestaurantDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“餐厅（YWRestaurantDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static YWRestaurantDAL Instance
        {
            get
            {
                if (yWRestaurantDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            yWRestaurantDAL = new SqlServer.YWRestaurantDAL();
                            break;

                        default:
                            yWRestaurantDAL = new SqlServer.YWRestaurantDAL();
                            break;
                    }
                }
                return yWRestaurantDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWRestaurant对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWRestaurant">餐厅（YWRestaurant）实例对象</param>
        protected void ReadYWRestaurantAllData(IDataReader dataReader, YWRestaurant yWRestaurant)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                yWRestaurant.Id = Convert.ToInt32(dataReader["Id"]);
            // 机构编号
            if (dataReader["OrgId"] != DBNull.Value)
                yWRestaurant.Org = Convert.ToInt32(dataReader["OrgId"]);
            // 名称
            if (dataReader["Name"] != DBNull.Value)
                yWRestaurant.Name = Convert.ToString(dataReader["Name"]);
            // 餐厅类别
            if (dataReader["RestaurantTypeId"] != DBNull.Value)
                yWRestaurant.RestaurantType = Convert.ToInt32(dataReader["RestaurantTypeId"]);
            // 授权类型
            if (dataReader["RoleTypeId"] != DBNull.Value)
                yWRestaurant.RoleType = Convert.ToInt32(dataReader["RoleTypeId"]);
            // 到期时间
            if (dataReader["FinishTime"] != DBNull.Value)
                yWRestaurant.FinishTime = Convert.ToString(dataReader["FinishTime"]);
            // 状态
            if (dataReader["StateId"] != DBNull.Value)
                yWRestaurant.State = Convert.ToString(dataReader["StateId"]);
            // 评分
            if (dataReader["Score"] != DBNull.Value)
                yWRestaurant.Score = Convert.ToInt32(dataReader["Score"]);
            // 地址
            if (dataReader["Address"] != DBNull.Value)
                yWRestaurant.Address = Convert.ToString(dataReader["Address"]);
            // 电话
            if (dataReader["Phone"] != DBNull.Value)
                yWRestaurant.Phone = Convert.ToString(dataReader["Phone"]);
            // 负责人
            if (dataReader["OwnerUserName"] != DBNull.Value)
                yWRestaurant.Owner = Convert.ToString(dataReader["OwnerUserName"]);
            // 订餐电话
            if (dataReader["BookPhones"] != DBNull.Value)
                yWRestaurant.BookPhones = Convert.ToString(dataReader["BookPhones"]);
            // 简介
            if (dataReader["Description"] != DBNull.Value)
                yWRestaurant.Description = Convert.ToString(dataReader["Description"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将餐厅（YWRestaurant）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWRestaurant">餐厅（YWRestaurant）实例对象</param>
        public abstract int Insert(YWRestaurant yWRestaurant);


        /// <summary>
        /// 将餐厅（YWRestaurant）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWRestaurant">餐厅（YWRestaurant）实例对象</param>
        public abstract int Update(YWRestaurant yWRestaurant);


        /// <summary>
        /// 根据餐厅（YWRestaurant）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">餐厅（YWRestaurant）的主键“编号（Id）”</param>
        public abstract int Delete(int id);

        /// <summary>
        /// 根据条件参数采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="paramList">条件参数</param>
        public abstract int DeleteByParams(Parameter paramList);


        /// <summary>
        /// 根据餐厅（YWRestaurant）的主键“编号（Id）”从数据库中获取餐厅（YWRestaurant）的实例。
        /// 成功从数据库中取得记录返回新餐厅（YWRestaurant）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">餐厅（YWRestaurant）的主键“编号（Id）”</param>
        public abstract YWRestaurant GetDataById(int id);


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


    }
}
