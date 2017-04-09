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
    /// 对象名称：用户提示通用数据访问父类（数据访问层）
    /// 对象说明：提供“用户提示类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“用户提示类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：chr
    /// 编写日期：2016-1-25 16:42:49
    /// </summary>
    public abstract class YWUserTipsDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“用户提示（YWUserTipsDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static YWUserTipsDAL yWUserTipsDAL;


        /// <summary>
        /// 获取“用户提示（YWUserTipsDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“用户提示（YWUserTipsDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static YWUserTipsDAL Instance
        {
            get
            {
                if (yWUserTipsDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            yWUserTipsDAL = new SqlServer.YWUserTipsDAL();
                            break;

                        default:
                            yWUserTipsDAL = new SqlServer.YWUserTipsDAL();
                            break;
                    }
                }
                return yWUserTipsDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWUserTips对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWUserTips">用户提示（YWUserTips）实例对象</param>
        protected void ReadYWUserTipsAllData(IDataReader dataReader, YWUserTips yWUserTips)
        {
            // 用户名
            if (dataReader["UserName"] != DBNull.Value)
                yWUserTips.UserName = Convert.ToString(dataReader["UserName"]);
            // 提示1
            if (dataReader["Tips1"] != DBNull.Value)
                yWUserTips.Tips1 = Convert.ToInt32(dataReader["Tips1"]);
            // 提示2
            if (dataReader["Tips2"] != DBNull.Value)
                yWUserTips.Tips2 = Convert.ToInt32(dataReader["Tips2"]);
            // 提示3
            if (dataReader["Tips3"] != DBNull.Value)
                yWUserTips.Tips3 = Convert.ToInt32(dataReader["Tips3"]);
            // 提示4
            if (dataReader["Tips4"] != DBNull.Value)
                yWUserTips.Tips4 = Convert.ToInt32(dataReader["Tips4"]);
            // 提示5
            if (dataReader["Tips5"] != DBNull.Value)
                yWUserTips.Tips5 = Convert.ToInt32(dataReader["Tips5"]);
            // 提示6
            if (dataReader["Tips6"] != DBNull.Value)
                yWUserTips.Tips6 = Convert.ToInt32(dataReader["Tips6"]);
            // 提示7
            if (dataReader["Tips7"] != DBNull.Value)
                yWUserTips.Tips7 = Convert.ToInt32(dataReader["Tips7"]);
            // 提示8
            if (dataReader["Tips8"] != DBNull.Value)
                yWUserTips.Tips8 = Convert.ToInt32(dataReader["Tips8"]);
            // 提示9
            if (dataReader["Tips9"] != DBNull.Value)
                yWUserTips.Tips9 = Convert.ToInt32(dataReader["Tips9"]);
            // 提示10
            if (dataReader["Tips10"] != DBNull.Value)
                yWUserTips.Tips10 = Convert.ToInt32(dataReader["Tips10"]);
            // 提示11
            if (dataReader["Tips11"] != DBNull.Value)
                yWUserTips.Tips11 = Convert.ToInt32(dataReader["Tips11"]);
            // 提示12
            if (dataReader["Tips12"] != DBNull.Value)
                yWUserTips.Tips12 = Convert.ToInt32(dataReader["Tips12"]);
            // 提示13
            if (dataReader["Tips13"] != DBNull.Value)
                yWUserTips.Tips13 = Convert.ToInt32(dataReader["Tips13"]);
            // 提示14
            if (dataReader["Tips14"] != DBNull.Value)
                yWUserTips.Tips14 = Convert.ToInt32(dataReader["Tips14"]);
            // 提示15
            if (dataReader["Tips15"] != DBNull.Value)
                yWUserTips.Tips15 = Convert.ToInt32(dataReader["Tips15"]);
            // 提示16
            if (dataReader["Tips16"] != DBNull.Value)
                yWUserTips.Tips16 = Convert.ToInt32(dataReader["Tips16"]);
            // 提示17
            if (dataReader["Tips17"] != DBNull.Value)
                yWUserTips.Tips17 = Convert.ToInt32(dataReader["Tips17"]);
            // 提示18
            if (dataReader["Tips18"] != DBNull.Value)
                yWUserTips.Tips18 = Convert.ToInt32(dataReader["Tips18"]);
            // 提示19
            if (dataReader["Tips19"] != DBNull.Value)
                yWUserTips.Tips19 = Convert.ToInt32(dataReader["Tips19"]);
            // 提示20
            if (dataReader["Tips20"] != DBNull.Value)
                yWUserTips.Tips20 = Convert.ToInt32(dataReader["Tips20"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为YWUserTips对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="yWUserTips">用户提示（YWUserTips）实例对象</param>
        protected void ReadYWUserTipsPageData(IDataReader dataReader, YWUserTips yWUserTips)
        {
            // 用户名
            if (dataReader["UserName"] != DBNull.Value)
                yWUserTips.UserName = Convert.ToString(dataReader["UserName"]);
            // 提示1
            if (dataReader["Tips1"] != DBNull.Value)
                yWUserTips.Tips1 = Convert.ToInt32(dataReader["Tips1"]);
            // 提示2
            if (dataReader["Tips2"] != DBNull.Value)
                yWUserTips.Tips2 = Convert.ToInt32(dataReader["Tips2"]);
            // 提示3
            if (dataReader["Tips3"] != DBNull.Value)
                yWUserTips.Tips3 = Convert.ToInt32(dataReader["Tips3"]);
            // 提示4
            if (dataReader["Tips4"] != DBNull.Value)
                yWUserTips.Tips4 = Convert.ToInt32(dataReader["Tips4"]);
            // 提示5
            if (dataReader["Tips5"] != DBNull.Value)
                yWUserTips.Tips5 = Convert.ToInt32(dataReader["Tips5"]);
            // 提示6
            if (dataReader["Tips6"] != DBNull.Value)
                yWUserTips.Tips6 = Convert.ToInt32(dataReader["Tips6"]);
            // 提示7
            if (dataReader["Tips7"] != DBNull.Value)
                yWUserTips.Tips7 = Convert.ToInt32(dataReader["Tips7"]);
            // 提示8
            if (dataReader["Tips8"] != DBNull.Value)
                yWUserTips.Tips8 = Convert.ToInt32(dataReader["Tips8"]);
            // 提示9
            if (dataReader["Tips9"] != DBNull.Value)
                yWUserTips.Tips9 = Convert.ToInt32(dataReader["Tips9"]);
            // 提示10
            if (dataReader["Tips10"] != DBNull.Value)
                yWUserTips.Tips10 = Convert.ToInt32(dataReader["Tips10"]);
            // 提示11
            if (dataReader["Tips11"] != DBNull.Value)
                yWUserTips.Tips11 = Convert.ToInt32(dataReader["Tips11"]);
            // 提示12
            if (dataReader["Tips12"] != DBNull.Value)
                yWUserTips.Tips12 = Convert.ToInt32(dataReader["Tips12"]);
            // 提示13
            if (dataReader["Tips13"] != DBNull.Value)
                yWUserTips.Tips13 = Convert.ToInt32(dataReader["Tips13"]);
            // 提示14
            if (dataReader["Tips14"] != DBNull.Value)
                yWUserTips.Tips14 = Convert.ToInt32(dataReader["Tips14"]);
            // 提示15
            if (dataReader["Tips15"] != DBNull.Value)
                yWUserTips.Tips15 = Convert.ToInt32(dataReader["Tips15"]);
            // 提示16
            if (dataReader["Tips16"] != DBNull.Value)
                yWUserTips.Tips16 = Convert.ToInt32(dataReader["Tips16"]);
            // 提示17
            if (dataReader["Tips17"] != DBNull.Value)
                yWUserTips.Tips17 = Convert.ToInt32(dataReader["Tips17"]);
            // 提示18
            if (dataReader["Tips18"] != DBNull.Value)
                yWUserTips.Tips18 = Convert.ToInt32(dataReader["Tips18"]);
            // 提示19
            if (dataReader["Tips19"] != DBNull.Value)
                yWUserTips.Tips19 = Convert.ToInt32(dataReader["Tips19"]);
            // 提示20
            if (dataReader["Tips20"] != DBNull.Value)
                yWUserTips.Tips20 = Convert.ToInt32(dataReader["Tips20"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将用户提示（YWUserTips）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWUserTips">用户提示（YWUserTips）实例对象</param>
        public abstract int Insert(YWUserTips yWUserTips);


        /// <summary>
        /// 将用户提示（YWUserTips）数据，根据主键“用户名（UserName）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWUserTips">用户提示（YWUserTips）实例对象</param>
        public abstract int Update(YWUserTips yWUserTips);


        /// <summary>
        /// 根据用户提示（YWUserTips）的主键“用户名（UserName）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="userName">用户提示（YWUserTips）的主键“用户名（UserName）”</param>
        public abstract int Delete(string userName);


        /// <summary>
        /// 根据用户提示（YWUserTips）的主键“用户名（UserName）”从数据库中获取用户提示（YWUserTips）的实例。
        /// 成功从数据库中取得记录返回新用户提示（YWUserTips）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="userName">用户提示（YWUserTips）的主键“用户名（UserName）”</param>
        public abstract YWUserTips GetDataByUserName(string userName);


        /// <summary>
        /// 从数据库中读取并返回所有用户提示（YWUserTips）List列表。
        /// </summary>
        public abstract List<YWUserTips> GetAllList();



        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
