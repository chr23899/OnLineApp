using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using OnlineApp.COL;
using OnlineApp.DAL;
using OnlineApp.SFL;
using System.Data.SqlClient;

namespace OnlineApp.BLL
{
    /// <summary>
    /// 对象名称：数据字典业务逻辑类（业务逻辑层）
    /// 对象说明：系统所有数据字典的管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-8 9:36:12
    /// </summary>
    public class YWDictionaryBLL
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
        internal static DAL.Common.YWDictionaryDAL DataAccess
        {
            get
            {
                return DAL.Common.YWDictionaryDAL.Instance;
            }
        }


        /// <summary>
        /// 对数据字典（YWDictionary）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWDictionary">数据字典（YWDictionary）实例对象</param>
        public static void CheckValid(YWDictionary yWDictionary)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWDictionary.DictionaryType))
                throw new CustomException("“类别”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWDictionary.Name))
                throw new CustomException("“名称”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWDictionary.DictionaryType , 50))
                throw new CustomException("“类别”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWDictionary.CodeId , 50))
                throw new CustomException("“识别码”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWDictionary.Name , 50))
                throw new CustomException("“名称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWDictionary.Description , 50))
                throw new CustomException("“描述”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWDictionary.Backup1 , 50))
                throw new CustomException("“备用１”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWDictionary.Backup2 , 50))
                throw new CustomException("“备用２”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWDictionary.Backup3 , 50))
                throw new CustomException("“备用３”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWDictionary.Backup4 , 50))
                throw new CustomException("“备用４”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWDictionary.Backup5 , 50))
                throw new CustomException("“备用５”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWDictionary.Backup6 , 500))
                throw new CustomException("“备用６”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWDictionary.Backup7 , 500))
                throw new CustomException("“备用７”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWDictionary.Backup8 , 500))
                throw new CustomException("“备用８”长度不能超过 500 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将数据字典（YWDictionary）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWDictionary">数据字典（YWDictionary）实例对象</param>
        public static int Insert(YWDictionary yWDictionary)
        {
            CheckValid(yWDictionary);
            return DataAccess.Insert(yWDictionary);
        }


        /// <summary>
        /// 将数据字典（YWDictionary）数据，根据主键“编码（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWDictionary">数据字典（YWDictionary）实例对象</param>
        public static int Update(YWDictionary yWDictionary)
        {
            CheckValid(yWDictionary);
            return DataAccess.Update(yWDictionary);
        }


        /// <summary>
        /// 根据数据字典（YWDictionary）的主键“编码（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">数据字典（YWDictionary）的主键“编码（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据条件参数采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="paramList">条件参数</param>
        public static int DeleteByParams(Parameter paramList)
        {
            return DataAccess.DeleteByParams(paramList);
        }


        /// <summary>
        /// 根据数据字典（YWDictionary）的主键“编码（Id）”从数据库中获取数据字典（YWDictionary）的实例。
        /// 成功从数据库中取得记录返回新数据字典（YWDictionary）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">数据字典（YWDictionary）的主键“编码（Id）”</param>
        public static YWDictionary GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据数据字典（YWDictionary）的主键“编码（Id）”从数据库中获取数据字典（YWDictionary）的实例。
        /// 成功从数据库中取得记录返回新数据字典（YWDictionary）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">数据字典（YWDictionary）的主键“编码（Id）”</param>
        public static YWDictionary GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        //add by chr
        //获取系统中所有字典类型列表 成功返回success
        public static PageData GetSystemDictionaryList(int iPageSize, int iCurPage, string sDictionaryTypeId, string sCodeId, string sName, string sDescription)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWDictionary].[Id],[YWDictionary].[DictionaryTypeId],[YWDictionaryType].[Name] AS [DictionaryTypeName], [YWDictionary].[CodeId],  "
                                + "[YWDictionary].[Name],[YWDictionary].[Description],[PT_ORG].[Id] AS [OrgId],[PT_ORG].[OrgName]  "
                                + "FROM [YWDictionary] "
                                + "LEFT JOIN [YWDictionaryType] ON [YWDictionaryType].[Id] = [YWDictionary].[DictionaryTypeId] "
                                + "LEFT JOIN [PT_ORG] ON [PT_ORG].[Id] =  [YWDictionary].[Backup1] WHERE 1=1 ";
            if (sDictionaryTypeId.Trim() != "")
                parameter.SqlString += " AND [YWDictionary].[DictionaryTypeId] = " + sDictionaryTypeId + " ";
            if (sCodeId.Trim() != "")
                parameter.SqlString += " AND [YWDictionary].[CodeId] LIKE '%" + sCodeId + "%' ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [YWDictionary].[Name] LIKE '%" + sName + "%' ";
            if (sDescription.Trim() != "")
                parameter.SqlString += " AND [YWDictionary].[Description] LIKE '%" + sDescription + "%' ";

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据Id字符串获取数据字典列表数据
        public static DataTable GetDictionaryDataById(int iDictionaryId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT * FROM [YWDictionary] "
                                + "WHERE [YWDictionary].[Id] = '" + iDictionaryId + "' ";

            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by chr
        //通过字典类型和机构获取新增的CodeId
        public static string GetDictionaryCodeId(string sDictionaryTypeId, string sBackup1)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT CodeId FROM [YWDictionary] "
                                + "WHERE [YWDictionary].[DictionaryTypeId] = '" + sDictionaryTypeId + "' AND Backup1 = '" + sBackup1 + "' ORDER BY CodeId DESC ";
            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter);
            if (dt.Rows.Count == 0)
            {
                return "1001";
            }
            else
            {
                return (Convert.ToInt32(dt.Rows[0][0]) + 1).ToString();
            }
        }

        //add by zy
        //根据当前时间和组织机构Id，获取当前饭店，在当前时间所处的消费时间段Id
        public static int GetConsumeTimeBlockIdByDateTimeNow(string strOrgId)
        {
            //获取当前时间的小时+分钟，需要检查是否是24小时？？？
            string strTimeNow = DateTime.Now.ToString("HH:mm");

            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWDictionary].[Id] FROM [YWDictionary] "
                                + "WHERE [YWDictionary].[Backup1] = @OrgId AND [YWDictionary].[DictionaryTypeId] = @DictionaryTypeId "
                                + "AND (@TimeNow BETWEEN [YWDictionary].[Backup2] AND [YWDictionary].[Backup3])";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"              , SqlDbType.NVarChar , 50 ){ Value = strOrgId},
                new SqlParameter("@DictionaryTypeId"   , SqlDbType.NVarChar , 50 ){ Value = CodeDictionary.DictionaryType["消费时间段"]},
                new SqlParameter("@TimeNow"            , SqlDbType.NVarChar , 50 ){ Value = strTimeNow}
            };
            parameter.Parameters = parameters;

            return Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }

        //add by zy
        //根据组织机构编码和类型编码，获取本饭店的一类自定义编码
        public static DataTable GetCodeListByOrgIdAndTypeId(string strOrgId, string strTypeId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Id],[DictionaryTypeId],[CodeId],[Name],[Description],[Backup2],[Backup3] FROM [YWDictionary] "
                                + "WHERE [Backup1] = @OrgId AND [DictionaryTypeId] = @DictionaryTypeId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"              , SqlDbType.NVarChar , 50 ){ Value = strOrgId},
                new SqlParameter("@DictionaryTypeId"   , SqlDbType.NVarChar , 50 ){ Value = strTypeId}
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by zy
        //根据类型编码，系统的一类自定义编码
        public static DataTable GetCodeListByTypeId(string strTypeId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Id],[DictionaryTypeId],[CodeId],[Name],[Description] FROM [YWDictionary] "
                                + "WHERE [DictionaryTypeId] = @DictionaryTypeId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@DictionaryTypeId"   , SqlDbType.NVarChar , 50 ){ Value = strTypeId}
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by zy
        //根据组织机构编码和类型编码，获取本饭店的一类自定义编码
        public static DataTable GetEstimateMode(string strTypeId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Id],[DictionaryTypeId],[CodeId],[Name],[Description] FROM [YWDictionary] "
                                + "WHERE [DictionaryTypeId] = @DictionaryTypeId";
            SqlParameter[] parameters = 
            { 
                new SqlParameter("@DictionaryTypeId"   , SqlDbType.NVarChar , 50 ){ Value = strTypeId}
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        ////获取所有预置选项的分页，CodeId小于2000
        //public static PageData GetSystemItemPageList(int pageSize, int curPage)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [CodeId] < '2000' AND [Backup1] is null ORDER BY [DictionaryTypeId]";
            
        //    parameter.Parameters = null;

        //    return GetPageListByParams(pageSize, curPage, parameter);
        //}




        ////根据数据字典的类别编号来获取一组数据字典选项
        //public static List<YWDictionary> GetAllListByTypeId(string strTypeId)
        //{ 
        //     //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [DictionaryTypeId]=@DictionaryTypeId ORDER BY [CodeId]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@DictionaryTypeId"   , SqlDbType.NVarChar , 50 ){ Value = strTypeId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据数据字典的类别编号和餐厅机构代码来获取一组数据字典选项
        //public static List<YWDictionary> GetAllListByTypeIdOrgId(string strTypeId, int iOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [DictionaryTypeId]=@DictionaryTypeId AND [Backup1]=@Backup1  ORDER BY [CodeId]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@DictionaryTypeId"   , SqlDbType.NVarChar , 50 ){ Value = strTypeId},
        //        new SqlParameter("@Backup1"   , SqlDbType.NVarChar , 50 ){ Value = iOrgId.ToString()},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据数据字典的类别编号和餐厅机构代码来获取一组自定义选项，CodeId大于2000，CodeId最大的排在最前
        //public static List<YWDictionary> GetCustomItemListByTypeIdOrgId(string strTypeId, int iOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [DictionaryTypeId]=@DictionaryTypeId AND [Backup1]=@Backup1 AND [CodeId] > '2000' ORDER BY [CodeId] DESC";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@DictionaryTypeId"   , SqlDbType.NVarChar , 50 ){ Value = strTypeId},
        //        new SqlParameter("@Backup1"   , SqlDbType.NVarChar , 50 ){ Value = iOrgId.ToString()},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据数据字典的类别编号、餐厅机构代码和系统选项识别码来获取餐厅引用的系统选项，CodeId小于2000
        //public static List<YWDictionary> GetSystemItemListByTypeIdOrgIdCodeId(string strTypeId, int iOrgId, string strCodeId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [DictionaryTypeId]=@DictionaryTypeId AND [Backup1]=@Backup1 AND [CodeId] < '2000' AND [CodeId]=@CodeId ORDER BY [CodeId] DESC";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@DictionaryTypeId"   , SqlDbType.NVarChar , 50 ){ Value = strTypeId},
        //        new SqlParameter("@Backup1"   , SqlDbType.NVarChar , 50 ){ Value = iOrgId.ToString()},
        //        new SqlParameter("@CodeId"   , SqlDbType.NVarChar , 50 ){ Value = strCodeId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据数据字典的类别编号来获取一组预置选项，CodeId小于2000
        //public static List<YWDictionary> GetSystemItemListByTypeId(string strTypeId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [DictionaryTypeId]=@DictionaryTypeId AND [CodeId] < '2000' AND [Backup1] is null ORDER BY [CodeId]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@DictionaryTypeId"   , SqlDbType.NVarChar , 50 ){ Value = strTypeId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}
        ////根据数据字典的类别编号和选项识别码来获取一组预置选项，CodeId小于2000
        //public static List<YWDictionary> GetSystemItemListByTypeIdCodeId(string strTypeId, string strCodeId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [DictionaryTypeId]=@DictionaryTypeId AND [CodeId]=@CodeId AND [CodeId] < '2000' AND [Backup1] is null ORDER BY [CodeId]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@DictionaryTypeId"   , SqlDbType.NVarChar , 50 ){ Value = strTypeId},
        //        new SqlParameter("@CodeId"   , SqlDbType.NVarChar , 50 ){ Value = strCodeId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}
    }
}
