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
    /// 对象名称：菜品通用数据访问父类（数据访问层）
    /// 对象说明：提供“菜品类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“菜品类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public abstract class YWFoodDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“菜品（YWFoodDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static YWFoodDAL yWFoodDAL;


        /// <summary>
        /// 获取“菜品（YWFoodDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“菜品（YWFoodDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static YWFoodDAL Instance
        {
            get
            {
                if (yWFoodDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            yWFoodDAL = new SqlServer.YWFoodDAL();
                            break;

                        default:
                            yWFoodDAL = new SqlServer.YWFoodDAL();
                            break;
                    }
                }
                return yWFoodDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWFood对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWFood">菜品（YWFood）实例对象</param>
        protected void ReadYWFoodAllData(IDataReader dataReader, YWFood yWFood)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                yWFood.Id = Convert.ToInt32(dataReader["Id"]);
            // 菜品
            if (dataReader["ProductId"] != DBNull.Value)
                yWFood.Product = Convert.ToInt32(dataReader["ProductId"]);
            // 关联消费
            if (dataReader["ConsumeId"] != DBNull.Value)
                yWFood.Consume = Convert.ToInt32(dataReader["ConsumeId"]);
            // 特殊要求
            if (dataReader["SpecialRequirement"] != DBNull.Value)
                yWFood.SpecialRequirement = Convert.ToString(dataReader["SpecialRequirement"]);
            // 下单时间
            if (dataReader["OrderTime"] != DBNull.Value)
                yWFood.OrderTime = Convert.ToString(dataReader["OrderTime"]);
            // 配菜时间
            if (dataReader["PreparedTime"] != DBNull.Value)
                yWFood.PreparedTime = Convert.ToString(dataReader["PreparedTime"]);
            // 出菜时间
            if (dataReader["OutPutTime"] != DBNull.Value)
                yWFood.OutPutTime = Convert.ToString(dataReader["OutPutTime"]);
            // 上菜时间
            if (dataReader["OnTableTime"] != DBNull.Value)
                yWFood.OnTableTime = Convert.ToString(dataReader["OnTableTime"]);
            // 结账时间
            if (dataReader["CheckoutTime"] != DBNull.Value)
                yWFood.CheckoutTime = Convert.ToString(dataReader["CheckoutTime"]);
            // 菜品制作状态
            if (dataReader["MakeStateId"] != DBNull.Value)
                yWFood.MakeState = Convert.ToInt32(dataReader["MakeStateId"]);
            // 菜品预定状态
            if (dataReader["OrderStateId"] != DBNull.Value)
                yWFood.OrderState = Convert.ToInt32(dataReader["OrderStateId"]);
            // 菜品结账状态
            if (dataReader["CheckStateId"] != DBNull.Value)
                yWFood.CheckState = Convert.ToInt32(dataReader["CheckStateId"]);
            // 所属餐厅
            if (dataReader["OrgId"] != DBNull.Value)
                yWFood.Org = Convert.ToInt32(dataReader["OrgId"]);
        }



        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将菜品（YWFood）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFood">菜品（YWFood）实例对象</param>
        public abstract int Insert(YWFood yWFood);


        /// <summary>
        /// 将菜品（YWFood）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFood">菜品（YWFood）实例对象</param>
        public abstract int Update(YWFood yWFood);


        /// <summary>
        /// 根据菜品（YWFood）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">菜品（YWFood）的主键“编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据条件参数采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="paramList">条件参数</param>
        public abstract int DeleteByParams(Parameter paramList);


        /// <summary>
        /// 根据菜品（YWFood）的主键“编号（Id）”从数据库中获取菜品（YWFood）的实例。
        /// 成功从数据库中取得记录返回新菜品（YWFood）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">菜品（YWFood）的主键“编号（Id）”</param>
        public abstract YWFood GetDataById(int id);


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


    }
}
