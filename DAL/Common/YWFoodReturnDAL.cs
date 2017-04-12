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
    /// 对象名称：退菜通用数据访问父类（数据访问层）
    /// 对象说明：提供“退菜类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“退菜类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：chr
    /// 编写日期：2016-2-17 10:26:09
    /// </summary>
    public abstract class YWFoodReturnDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“退菜（YWFoodReturnDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static YWFoodReturnDAL yWFoodReturnDAL;


        /// <summary>
        /// 获取“退菜（YWFoodReturnDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“退菜（YWFoodReturnDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static YWFoodReturnDAL Instance
        {
            get
            {
                if (yWFoodReturnDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            yWFoodReturnDAL = new SqlServer.YWFoodReturnDAL();
                            break;

                        default:
                            yWFoodReturnDAL = new SqlServer.YWFoodReturnDAL();
                            break;
                    }
                }
                return yWFoodReturnDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWFoodReturn对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWFoodReturn">退菜（YWFoodReturn）实例对象</param>
        protected void ReadYWFoodReturnAllData(IDataReader dataReader, YWFoodReturn yWFoodReturn)
        {
            // 编码
            if (dataReader["Id"] != DBNull.Value)
                yWFoodReturn.Id = Convert.ToInt32(dataReader["Id"]);
            // 菜品编码
            if (dataReader["FoodId"] != DBNull.Value)
                yWFoodReturn.Food = Convert.ToInt32(dataReader["FoodId"]);
            // 退菜原因
            if (dataReader["ReasonId"] != DBNull.Value)
                yWFoodReturn.ReasonId = Convert.ToInt32(dataReader["ReasonId"]);
            // 描述
            if (dataReader["Description"] != DBNull.Value)
                yWFoodReturn.Description = Convert.ToString(dataReader["Description"]);
            // 申请时间
            if (dataReader["ApplyTime"] != DBNull.Value)
                yWFoodReturn.ApplyTime = Convert.ToString(dataReader["ApplyTime"]);
            // 申请人
            if (dataReader["ApplyUser"] != DBNull.Value)
                yWFoodReturn.ApplyUser = Convert.ToString(dataReader["ApplyUser"]);
            // 审核时间
            if (dataReader["ApproveTime"] != DBNull.Value)
                yWFoodReturn.ApproveTime = Convert.ToString(dataReader["ApproveTime"]);
            // 审核人
            if (dataReader["ApproveUser"] != DBNull.Value)
                yWFoodReturn.ApproveUser = Convert.ToString(dataReader["ApproveUser"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将退菜（YWFoodReturn）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFoodReturn">退菜（YWFoodReturn）实例对象</param>
        public abstract int Insert(YWFoodReturn yWFoodReturn);


        /// <summary>
        /// 将退菜（YWFoodReturn）数据，根据主键“编码（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFoodReturn">退菜（YWFoodReturn）实例对象</param>
        public abstract int Update(YWFoodReturn yWFoodReturn);


        /// <summary>
        /// 根据退菜（YWFoodReturn）的主键“编码（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">退菜（YWFoodReturn）的主键“编码（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据退菜（YWFoodReturn）的主键“编码（Id）”从数据库中获取退菜（YWFoodReturn）的实例。
        /// 成功从数据库中取得记录返回新退菜（YWFoodReturn）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">退菜（YWFoodReturn）的主键“编码（Id）”</param>
        public abstract YWFoodReturn GetDataById(int id);


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
