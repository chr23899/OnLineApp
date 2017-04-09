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
    /// 对象名称：需求通用数据访问父类（数据访问层）
    /// 对象说明：提供“需求类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“需求类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public abstract class YWRequirementDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“需求（YWRequirementDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static YWRequirementDAL yWRequirementDAL;


        /// <summary>
        /// 获取“需求（YWRequirementDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“需求（YWRequirementDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static YWRequirementDAL Instance
        {
            get
            {
                if (yWRequirementDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            yWRequirementDAL = new SqlServer.YWRequirementDAL();
                            break;

                        default:
                            yWRequirementDAL = new SqlServer.YWRequirementDAL();
                            break;
                    }
                }
                return yWRequirementDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWRequirement对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWRequirement">需求（YWRequirement）实例对象</param>
        protected void ReadYWRequirementAllData(IDataReader dataReader, YWRequirement yWRequirement)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                yWRequirement.Id = Convert.ToInt32(dataReader["Id"]);
            // 项目
            if (dataReader["MaterialId"] != DBNull.Value)
                yWRequirement.Material = Convert.ToInt32(dataReader["MaterialId"]);
            // 计量方式
            if (dataReader["EstimateModeId"] != DBNull.Value)
                yWRequirement.EstimateMode = Convert.ToInt32(dataReader["EstimateModeId"]);
            // 数量
            if (dataReader["Quantity"] != DBNull.Value)
                yWRequirement.Quantity = Convert.ToDouble(dataReader["Quantity"]);
            // 数量单位
            if (dataReader["QuantityUnit"] != DBNull.Value)
                yWRequirement.QuantityUnit = Convert.ToString(dataReader["QuantityUnit"]);
            // 重量
            if (dataReader["Weight"] != DBNull.Value)
                yWRequirement.Weight = Convert.ToDouble(dataReader["Weight"]);
            // 重量单位
            if (dataReader["WeightUnit"] != DBNull.Value)
                yWRequirement.WeightUnit = Convert.ToString(dataReader["WeightUnit"]);
            // 来源
            if (dataReader["SourceOrgId"] != DBNull.Value)
                yWRequirement.SourceOrg = Convert.ToInt32(dataReader["SourceOrgId"]);
            // 提出人
            if (dataReader["ProposeUserName"] != DBNull.Value)
                yWRequirement.ProposeUser = Convert.ToString(dataReader["ProposeUserName"]);
            // 提出时间
            if (dataReader["ProposeTime"] != DBNull.Value)
                yWRequirement.ProposeTime = Convert.ToString(dataReader["ProposeTime"]);
            // 需求单状态
            if (dataReader["RequirementStateId"] != DBNull.Value)
                yWRequirement.RequirementState = Convert.ToInt32(dataReader["RequirementStateId"]);
            // 所属餐厅
            if (dataReader["OrgId"] != DBNull.Value)
                yWRequirement.Org = Convert.ToInt32(dataReader["OrgId"]);
            // 特殊要求
            if (dataReader["SpecialRequirement"] != DBNull.Value)
                yWRequirement.SpecialRequirement = Convert.ToString(dataReader["SpecialRequirement"]);
            // 接收人
            if (dataReader["ReceiveUserName"] != DBNull.Value)
                yWRequirement.ReceiveUser = Convert.ToString(dataReader["ReceiveUserName"]);
            // 接收时间
            if (dataReader["ReceiveTime"] != DBNull.Value)
                yWRequirement.ReceiveTime = Convert.ToString(dataReader["ReceiveTime"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将需求（YWRequirement）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWRequirement">需求（YWRequirement）实例对象</param>
        public abstract int Insert(YWRequirement yWRequirement);


        /// <summary>
        /// 将需求（YWRequirement）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWRequirement">需求（YWRequirement）实例对象</param>
        public abstract int Update(YWRequirement yWRequirement);


        /// <summary>
        /// 根据需求（YWRequirement）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">需求（YWRequirement）的主键“编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据条件参数采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="paramList">条件参数</param>
        public abstract int DeleteByParams(Parameter paramList);


        /// <summary>
        /// 根据需求（YWRequirement）的主键“编号（Id）”从数据库中获取需求（YWRequirement）的实例。
        /// 成功从数据库中取得记录返回新需求（YWRequirement）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">需求（YWRequirement）的主键“编号（Id）”</param>
        public abstract YWRequirement GetDataById(int id);



        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


    }
}
