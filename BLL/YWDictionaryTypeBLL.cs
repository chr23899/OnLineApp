using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using Chr.OnlineApp.COL;
using Chr.OnlineApp.DAL;
using Chr.OnlineApp.SFL;

namespace Chr.OnlineApp.BLL
{
    /// <summary>
    /// 对象名称：字典表类型（码表）业务逻辑类（业务逻辑层）
    /// 对象说明：集中式字典表的分类管理。
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWDictionaryTypeBLL
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
        internal static DAL.Common.YWDictionaryTypeDAL DataAccess
        {
            get
            {
                return DAL.Common.YWDictionaryTypeDAL.Instance;
            }
        }


        /// <summary>
        /// 对字典表类型（码表）（YWDictionaryType）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="YWDictionaryType">字典表类型（码表）（YWDictionaryType）实例对象</param>
        public static void CheckValid(YWDictionaryType ywDictionaryType)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(ywDictionaryType.Id))
                throw new CustomException("“编号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(ywDictionaryType.Name))
                throw new CustomException("“名称”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(ywDictionaryType.Id , 50))
                throw new CustomException("“编号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(ywDictionaryType.Name , 50))
                throw new CustomException("“名称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(ywDictionaryType.Description , 50))
                throw new CustomException("“描述”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将字典表类型（码表）（YWDictionaryType）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="YWDictionaryType">字典表类型（码表）（YWDictionaryType）实例对象</param>
        public static int Insert(YWDictionaryType ywDictionaryType)
        {
            CheckValid(ywDictionaryType);
            return DataAccess.Insert(ywDictionaryType);
        }


        /// <summary>
        /// 将字典表类型（码表）（YWDictionaryType）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="YWDictionaryType">字典表类型（码表）（YWDictionaryType）实例对象</param>
        public static int Update(YWDictionaryType ywDictionaryType)
        {
            CheckValid(ywDictionaryType);
            return DataAccess.Update(ywDictionaryType);
        }


        /// <summary>
        /// 根据字典表类型（码表）（YWDictionaryType）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">字典表类型（码表）（YWDictionaryType）的主键“编号（Id）”</param>
        public static int Delete(string id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据字典表类型（码表）（YWDictionaryType）的主键“编号（Id）”从数据库中获取字典表类型（码表）（YWDictionaryType）的实例。
        /// 成功从数据库中取得记录返回新字典表类型（码表）（YWDictionaryType）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">字典表类型（码表）（YWDictionaryType）的主键“编号（Id）”</param>
        public static YWDictionaryType GetDataById(string id)
        {
            return DataAccess.GetDataById(id);
        }


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        //add by chr
        //获取系统中所有字典类型列表 成功返回success
        public static PageData GetSystemDictionaryTypeList(int iPageSize, int iCurPage, string sName, string sDescription)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Id],[Name],[Description] FROM [YWDictionaryType] WHERE 1=1 ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [YWDictionaryType].[Name] LIKE '%" + sName + "%' ";
            if (sDescription.Trim() != "")
                parameter.SqlString += " AND [YWDictionaryType].[Description] LIKE '%" + sDescription + "%' ";
            parameter.SqlString += " ORDER BY Id  ";

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //新增时候检测系统中是否存在了该条记录
        public static string IsAddValid(string id, string name)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Id],[Name],[Description] FROM YWDictionaryType WHERE Id = '" + id + "' ORDER BY Id  ";
            DataTable dt = new DataTable();
            dt = CommonToolsBLL.GetAllListByParams(parameter);
            if (dt.Rows.Count > 0)
                return "该编号已经被使用!";
            parameter.SqlString = "SELECT [Id],[Name],[Description] FROM YWDictionaryType  WHERE Id = '" + name + "' ORDER BY Id  ";
            dt = CommonToolsBLL.GetAllListByParams(parameter);
            if (dt.Rows.Count > 0)
                return "该名称已经被使用!";
            return "";
        }

        //add by chr
        //新增时候检测系统中是否存在了该条记录
        public static string IsUpdateValid(string id, string name)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Id],[Name],[Description] FROM YWDictionaryType WHERE Id = '" + id + "' ORDER BY Id  ";
            DataTable dt = new DataTable();
            dt = CommonToolsBLL.GetAllListByParams(parameter);
            if (dt.Rows.Count == 0)
                return "要修改的编号不存在!";
            parameter.SqlString = "SELECT [Id],[Name],[Description] FROM YWDictionaryType  WHERE Id = '" + name + "' ORDER BY Id  ";
            dt = CommonToolsBLL.GetAllListByParams(parameter);
            if (dt.Rows.Count > 0)
                return "该名称已经被使用!";
            return "";
        }
    }
}
