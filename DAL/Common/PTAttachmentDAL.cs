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
    /// 对象名称：附件信息通用数据访问父类（数据访问层）
    /// 对象说明：提供“附件信息类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“附件信息类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：chr
    /// 编写日期：2014-1-28 10:09:09
    /// </summary>
    public abstract class PTAttachmentDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“附件信息（PTAttachmentDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static PTAttachmentDAL pTAttachmentDAL;


        /// <summary>
        /// 获取“附件信息（PTAttachmentDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“附件信息（PTAttachmentDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static PTAttachmentDAL Instance
        {
            get
            {
                if (pTAttachmentDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            pTAttachmentDAL = new SqlServer.PTAttachmentDAL();
                            break;

                        default:
                            pTAttachmentDAL = new SqlServer.PTAttachmentDAL();
                            break;
                    }
                }
                return pTAttachmentDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为PTAttachment对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="pTAttachment">附件信息（PTAttachment）实例对象</param>
        protected void ReadPTAttachmentAllData(IDataReader dataReader, PTAttachment pTAttachment)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                pTAttachment.Id = Convert.ToInt32(dataReader["Id"]);
            // 文件名
            if (dataReader["FileName"] != DBNull.Value)
                pTAttachment.FileName = Convert.ToString(dataReader["FileName"]);
            // 文件大小
            if (dataReader["FileSize"] != DBNull.Value)
                pTAttachment.FileSize = Convert.ToInt32(dataReader["FileSize"]);
            // 上传日期
            if (dataReader["UploadDate"] != DBNull.Value)
                pTAttachment.UploadDate = Convert.ToString(dataReader["UploadDate"]);
            // 功能
            if (dataReader["FunctionName"] != DBNull.Value)
                pTAttachment.FunctionName = Convert.ToString(dataReader["FunctionName"]);
            // 上传者
            if (dataReader["UserName"] != DBNull.Value)
                pTAttachment.UserName = Convert.ToString(dataReader["UserName"]);
            // 备注
            if (dataReader["Notes"] != DBNull.Value)
                pTAttachment.Notes = Convert.ToString(dataReader["Notes"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将附件信息（PTAttachment）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTAttachment">附件信息（PTAttachment）实例对象</param>
        public abstract int Insert(PTAttachment pTAttachment);


        /// <summary>
        /// 将附件信息（PTAttachment）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTAttachment">附件信息（PTAttachment）实例对象</param>
        public abstract int Update(PTAttachment pTAttachment);


        /// <summary>
        /// 根据附件信息（PTAttachment）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">附件信息（PTAttachment）的主键“编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据附件信息（PTAttachment）的主键“编号（Id）”从数据库中获取附件信息（PTAttachment）的实例。
        /// 成功从数据库中取得记录返回新附件信息（PTAttachment）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">附件信息（PTAttachment）的主键“编号（Id）”</param>
        public abstract PTAttachment GetDataById(int id);


     


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
