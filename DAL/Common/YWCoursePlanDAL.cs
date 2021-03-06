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
    /// 对象名称：基础对象名称通用数据访问父类（数据访问层）
    /// 对象说明：提供“基础对象名称类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“基础对象名称类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：陈焕然
    /// 编写日期：2017/4/13 23:51:40
    /// </summary>
    public abstract class YWCoursePlanDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“基础对象名称（YWCoursePlanDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static YWCoursePlanDAL yWCoursePlanDAL;


        /// <summary>
        /// 获取“基础对象名称（YWCoursePlanDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“基础对象名称（YWCoursePlanDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static YWCoursePlanDAL Instance
        {
            get
            {
                if (yWCoursePlanDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            yWCoursePlanDAL = new SqlServer.YWCoursePlanDAL();
                            break;

                        default:
                            yWCoursePlanDAL = new SqlServer.YWCoursePlanDAL();
                            break;
                    }
                }
                return yWCoursePlanDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWCoursePlan对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWCoursePlan">基础对象名称（YWCoursePlan）实例对象</param>
        protected void ReadYWCoursePlanAllData(IDataReader dataReader, YWCoursePlan yWCoursePlan)
        {
            // 
            if (dataReader["Id"] != DBNull.Value)
                yWCoursePlan.Id = Convert.ToInt32(dataReader["Id"]);
            // 
            if (dataReader["courseId"] != DBNull.Value)
                yWCoursePlan.CourseId = Convert.ToInt32(dataReader["courseId"]);
            // 
            if (dataReader["courseName"] != DBNull.Value)
                yWCoursePlan.CourseName = Convert.ToString(dataReader["courseName"]);
            // 
            if (dataReader["name"] != DBNull.Value)
                yWCoursePlan.Name = Convert.ToString(dataReader["name"]);
            // 
            if (dataReader["content"] != DBNull.Value)
                yWCoursePlan.Content = Convert.ToString(dataReader["content"]);
            // 
            if (dataReader["type"] != DBNull.Value)
                yWCoursePlan.Type = Convert.ToString(dataReader["type"]);
            // 
            if (dataReader["pic"] != DBNull.Value)
                yWCoursePlan.Pic = Convert.ToString(dataReader["pic"]);
            // 
            if (dataReader["video"] != DBNull.Value)
                yWCoursePlan.Video = Convert.ToString(dataReader["video"]);
            // 
            if (dataReader["study"] != DBNull.Value)
                yWCoursePlan.Study = Convert.ToString(dataReader["study"]);
            // 
            if (dataReader["test"] != DBNull.Value)
                yWCoursePlan.Test = Convert.ToString(dataReader["test"]);
            // 
            if (dataReader["planTime"] != DBNull.Value)
                yWCoursePlan.PlanTime = Convert.ToDateTime(dataReader["planTime"]);
            // 
            if (dataReader["startTime"] != DBNull.Value)
                yWCoursePlan.StartTime = Convert.ToDateTime(dataReader["startTime"]);
            // 
            if (dataReader["finishTime"] != DBNull.Value)
                yWCoursePlan.FinishTime = Convert.ToDateTime(dataReader["finishTime"]);
            // 
            if (dataReader["createTime"] != DBNull.Value)
                yWCoursePlan.CreateTime = Convert.ToDateTime(dataReader["createTime"]);
            // 
            if (dataReader["updateTime"] != DBNull.Value)
                yWCoursePlan.UpdateTime = Convert.ToDateTime(dataReader["updateTime"]);
            // 
            if (dataReader["status"] != DBNull.Value)
                yWCoursePlan.Status = Convert.ToInt32(dataReader["status"]);
            // 
            if (dataReader["Alternate1"] != DBNull.Value)
                yWCoursePlan.Alternate1 = Convert.ToString(dataReader["Alternate1"]);
            // 
            if (dataReader["Alternate2"] != DBNull.Value)
                yWCoursePlan.Alternate2 = Convert.ToString(dataReader["Alternate2"]);
            // 
            if (dataReader["Alternate3"] != DBNull.Value)
                yWCoursePlan.Alternate3 = Convert.ToString(dataReader["Alternate3"]);
            // 
            if (dataReader["Alternate4"] != DBNull.Value)
                yWCoursePlan.Alternate4 = Convert.ToString(dataReader["Alternate4"]);
            // 
            if (dataReader["Alternate5"] != DBNull.Value)
                yWCoursePlan.Alternate5 = Convert.ToString(dataReader["Alternate5"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWCoursePlan对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWCoursePlan">基础对象名称（YWCoursePlan）实例对象</param>
        protected void ReadYWCoursePlanPageData(IDataReader dataReader, YWCoursePlan yWCoursePlan)
        {
            // 
            if (dataReader["Id"] != DBNull.Value)
                yWCoursePlan.Id = Convert.ToInt32(dataReader["Id"]);
            // 
            if (dataReader["courseId"] != DBNull.Value)
                yWCoursePlan.CourseId = Convert.ToInt32(dataReader["courseId"]);
            // 
            if (dataReader["courseName"] != DBNull.Value)
                yWCoursePlan.CourseName = Convert.ToString(dataReader["courseName"]);
            // 
            if (dataReader["name"] != DBNull.Value)
                yWCoursePlan.Name = Convert.ToString(dataReader["name"]);
            // 
            if (dataReader["content"] != DBNull.Value)
                yWCoursePlan.Content = Convert.ToString(dataReader["content"]);
            // 
            if (dataReader["type"] != DBNull.Value)
                yWCoursePlan.Type = Convert.ToString(dataReader["type"]);
            // 
            if (dataReader["pic"] != DBNull.Value)
                yWCoursePlan.Pic = Convert.ToString(dataReader["pic"]);
            // 
            if (dataReader["video"] != DBNull.Value)
                yWCoursePlan.Video = Convert.ToString(dataReader["video"]);
            // 
            if (dataReader["study"] != DBNull.Value)
                yWCoursePlan.Study = Convert.ToString(dataReader["study"]);
            // 
            if (dataReader["test"] != DBNull.Value)
                yWCoursePlan.Test = Convert.ToString(dataReader["test"]);
            // 
            if (dataReader["planTime"] != DBNull.Value)
                yWCoursePlan.PlanTime = Convert.ToDateTime(dataReader["planTime"]);
            // 
            if (dataReader["startTime"] != DBNull.Value)
                yWCoursePlan.StartTime = Convert.ToDateTime(dataReader["startTime"]);
            // 
            if (dataReader["finishTime"] != DBNull.Value)
                yWCoursePlan.FinishTime = Convert.ToDateTime(dataReader["finishTime"]);
            // 
            if (dataReader["createTime"] != DBNull.Value)
                yWCoursePlan.CreateTime = Convert.ToDateTime(dataReader["createTime"]);
            // 
            if (dataReader["updateTime"] != DBNull.Value)
                yWCoursePlan.UpdateTime = Convert.ToDateTime(dataReader["updateTime"]);
            // 
            if (dataReader["status"] != DBNull.Value)
                yWCoursePlan.Status = Convert.ToInt32(dataReader["status"]);
            // 
            if (dataReader["Alternate1"] != DBNull.Value)
                yWCoursePlan.Alternate1 = Convert.ToString(dataReader["Alternate1"]);
            // 
            if (dataReader["Alternate2"] != DBNull.Value)
                yWCoursePlan.Alternate2 = Convert.ToString(dataReader["Alternate2"]);
            // 
            if (dataReader["Alternate3"] != DBNull.Value)
                yWCoursePlan.Alternate3 = Convert.ToString(dataReader["Alternate3"]);
            // 
            if (dataReader["Alternate4"] != DBNull.Value)
                yWCoursePlan.Alternate4 = Convert.ToString(dataReader["Alternate4"]);
            // 
            if (dataReader["Alternate5"] != DBNull.Value)
                yWCoursePlan.Alternate5 = Convert.ToString(dataReader["Alternate5"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将基础对象名称（YWCoursePlan）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWCoursePlan">基础对象名称（YWCoursePlan）实例对象</param>
        public abstract int Insert(YWCoursePlan yWCoursePlan);


        /// <summary>
        /// 将基础对象名称（YWCoursePlan）数据，根据主键“（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWCoursePlan">基础对象名称（YWCoursePlan）实例对象</param>
        public abstract int Update(YWCoursePlan yWCoursePlan);


        /// <summary>
        /// 根据基础对象名称（YWCoursePlan）的主键“（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">基础对象名称（YWCoursePlan）的主键“（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据基础对象名称（YWCoursePlan）的主键“（Id）”从数据库中获取基础对象名称（YWCoursePlan）的实例。
        /// 成功从数据库中取得记录返回新基础对象名称（YWCoursePlan）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基础对象名称（YWCoursePlan）的主键“（Id）”</param>
        public abstract YWCoursePlan GetDataById(int id);


        /// <summary>
        /// 从数据库中读取并返回所有基础对象名称（YWCoursePlan）List列表。
        /// </summary>
        public abstract List<YWCoursePlan> GetAllList();
         


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
