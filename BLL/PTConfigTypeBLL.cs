using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using OnlineApp.COL;
using OnlineApp.DAL;
using OnlineApp.SFL;

namespace OnlineApp.BLL
{
    /// <summary>
    /// 对象名称：配置类型（码表）业务逻辑类（业务逻辑层）
    /// 对象说明：管理系统配置项的不同类型，决定配置项的作用对象，可以是角色，用户，机构等
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTConfigTypeBLL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要提供该类的基本业务逻辑。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 返回与本类相关联的数据访问类。通常本类需要访问自身关联的数据访问类，与数据库进行交互时，应优先使用该属性，
        /// 本类调用业务逻辑层其它业务逻辑类时，应当优先使用其它类中公开的方法，而不优先使用其它类中的DataAccess属性。
        /// </summary>
        internal static DAL.Common.PTConfigTypeDAL DataAccess
        {
            get
            {
                return DAL.Common.PTConfigTypeDAL.Instance;
            }
        }


        /// <summary>
        /// 对配置类型（码表）（PTConfigType）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="configType">配置类型（码表）（PTConfigType）实例对象</param>
        public static void CheckValid(PTConfigType pTConfigType)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(pTConfigType.Id))
                throw new CustomException("“编号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTConfigType.Name))
                throw new CustomException("“名称”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(pTConfigType.Id, 50))
                throw new CustomException("“编号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTConfigType.Name, 50))
                throw new CustomException("“名称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(pTConfigType.Description, 50))
                throw new CustomException("“描述”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将配置类型（码表）（PTConfigType）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="configType">配置类型（码表）（PTConfigType）实例对象</param>
        public static int Insert(PTConfigType pTConfigType)
        {
            CheckValid(pTConfigType);
            return DataAccess.Insert(pTConfigType);
        }


        /// <summary>
        /// 将配置类型（码表）（PTConfigType）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="configType">配置类型（码表）（PTConfigType）实例对象</param>
        public static int Update(PTConfigType pTConfigType)
        {
            CheckValid(pTConfigType);
            return DataAccess.Update(pTConfigType);
        }


        /// <summary>
        /// 根据配置类型（码表）（PTConfigType）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">配置类型（码表）（PTConfigType）的主键“编号（Id）”</param>
        public static int Delete(string id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据配置类型（码表）（PTConfigType）的主键“编号（Id）”从数据库中获取配置类型（码表）（PTConfigType）的实例。
        /// 成功从数据库中取得记录返回新配置类型（码表）（PTConfigType）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">配置类型（码表）（PTConfigType）的主键“编号（Id）”</param>
        public static PTConfigType GetDataById(string id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 从数据库中读取并返回所有配置类型（码表）（PTConfigType）List列表。
        /// </summary>
        public static List<PTConfigType> GetAllList()
        {
            return DataAccess.GetAllList();
        }


      

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// add by chr
        /// 获取分组类型列表的分页数据
        /// </summary>
        /// <param name="pageSize">每页大小</param>
        /// <param name="curPage">当前页面</param>
        /// <returns></returns>
        public static PageData GetPageData(int pageSize, int curPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT [Id],[Name],[Description] FROM [PT_CONFIGTYPE] ";

            return BLL.CommonToolsBLL.GetPageListByParamsOutBound(pageSize, curPage, parameter);
        }

        /// <summary>
        /// add by chr
        /// 验证是否可以新增
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string AddValid(string id, string name)
        {
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = " SELECT * FROM [PT_CONFIGTYPE] WHERE [Id] = '" + id + "' ";
            //查询数据
            DataTable dt1 = BLL.CommonToolsBLL.GetAllListByParams(parameter1);
            if (dt1.Rows.Count > 0)
                return "该编号已经被使用!";
            //构建查询条件
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = " SELECT * FROM [PT_CONFIGTYPE] WHERE [Name] = '" + name + "' ";
            //查询数据
            DataTable dt2 = BLL.CommonToolsBLL.GetAllListByParams(parameter2);
            if (dt2.Rows.Count > 0)
                return "该名称已经被使用!";
            return "";
        }

        /// <summary>
        /// add by chr
        /// 验证是否可以修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string EditValid(string id, string name)
        {
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = " SELECT * FROM [PT_CONFIGTYPE] WHERE [Name] = '" + name + "' AND [Id] NOT LIKE '" + id + "'";
            //查询数据
            DataTable dt1 = BLL.CommonToolsBLL.GetAllListByParams(parameter1);
            if (dt1.Rows.Count > 0)
                return "该名称已经被占用!";
            return "";
        }

        /// <summary>
        /// add by chr
        /// 验证是否可以删除
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string DeleteValid(string id)
        {
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = " SELECT * FROM [PT_CONFIG] WHERE [TypeId] = '" + id + "'";
            //查询数据
            DataTable dt1 = BLL.CommonToolsBLL.GetAllListByParams(parameter1);
            if (dt1.Rows.Count > 0)
                return "该配置类型下存在配置项!";
            return "";
        }





    }
}
