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
    /// 对象名称：提示消息通用数据访问父类（数据访问层）
    /// 对象说明：提供“提示消息类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“提示消息类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：牛大宝
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public abstract class PTNoticesDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“提示消息（NoticesDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static PTNoticesDAL noticesDAL;


        /// <summary>
        /// 获取“提示消息（NoticesDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“提示消息（NoticesDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static PTNoticesDAL Instance
        {
            get
            {
                if (noticesDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            noticesDAL = new SqlServer.PTNoticesDAL();
                            break;

                        default:
                            noticesDAL = new SqlServer.PTNoticesDAL();
                            break;
                    }
                }
                return noticesDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为Notices对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="notices">提示消息（Notices）实例对象</param>
        protected void ReadNoticesAllData(IDataReader dataReader, PTNotices notices)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                notices.Id = Convert.ToInt32(dataReader["Id"]);
            // 类别
            if (dataReader["TypeId"] != DBNull.Value)
                notices.TypeId = Convert.ToString(dataReader["TypeId"]);
            // 机构范围
            if (dataReader["OrgRange"] != DBNull.Value)
                notices.OrgRange = Convert.ToString(dataReader["OrgRange"]);
            // 角色范围
            if (dataReader["RoleScope"] != DBNull.Value)
                notices.RoleScope = Convert.ToString(dataReader["RoleScope"]);
            // 用户范围
            if (dataReader["UserRange"] != DBNull.Value)
                notices.UserRange = Convert.ToString(dataReader["UserRange"]);
            // 作者
            if (dataReader["Author"] != DBNull.Value)
                notices.Author = Convert.ToString(dataReader["Author"]);
            // 发布时间
            if (dataReader["ReleaseTime"] != DBNull.Value)
                notices.ReleaseTime = Convert.ToString(dataReader["ReleaseTime"]);
            // 已读状态
            if (dataReader["ReadStatus"] != DBNull.Value)
                notices.ReadStatus = Convert.ToString(dataReader["ReadStatus"]);
            // 标题
            if (dataReader["Title"] != DBNull.Value)
                notices.Title = Convert.ToString(dataReader["Title"]);
            // 正文
            if (dataReader["Content"] != DBNull.Value)
                notices.Content = Convert.ToString(dataReader["Content"]);
            // 附件地址
            if (dataReader["Attachment"] != DBNull.Value)
                notices.Attachment = Convert.ToString(dataReader["Attachment"]);
            // 图片地址
            if (dataReader["PictureAddress"] != DBNull.Value)
                notices.PictureAddress = Convert.ToString(dataReader["PictureAddress"]);
            // 备用１
            if (dataReader["Alternate1"] != DBNull.Value)
                notices.Alternate1 = Convert.ToString(dataReader["Alternate1"]);
            // 备用２
            if (dataReader["Alternate2"] != DBNull.Value)
                notices.Alternate2 = Convert.ToString(dataReader["Alternate2"]);
            // 备用３
            if (dataReader["Alternate3"] != DBNull.Value)
                notices.Alternate3 = Convert.ToString(dataReader["Alternate3"]);
            // 备用４
            if (dataReader["Alternate4"] != DBNull.Value)
                notices.Alternate4 = Convert.ToString(dataReader["Alternate4"]);
            // 备用５
            if (dataReader["Alternate5"] != DBNull.Value)
                notices.Alternate5 = Convert.ToString(dataReader["Alternate5"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将提示消息（Notices）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="notices">提示消息（Notices）实例对象</param>
        public abstract int Insert(PTNotices notices);


        /// <summary>
        /// 将提示消息（Notices）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="notices">提示消息（Notices）实例对象</param>
        public abstract int Update(PTNotices notices);


        /// <summary>
        /// 根据提示消息（Notices）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">提示消息（Notices）的主键“编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据提示消息（Notices）的主键“编号（Id）”从数据库中获取提示消息（Notices）的实例。
        /// 成功从数据库中取得记录返回新提示消息（Notices）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">提示消息（Notices）的主键“编号（Id）”</param>
        public abstract PTNotices GetDataById(int id);




        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


     



    }
}
