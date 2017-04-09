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
    /// 对象名称：套餐业务逻辑类（业务逻辑层）
    /// 对象说明：套餐管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWProductGroupBLL
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
        internal static DAL.Common.YWProductGroupDAL DataAccess
        {
            get
            {
                return DAL.Common.YWProductGroupDAL.Instance;
            }
        }


        /// <summary>
        /// 对套餐（YWProductGroup）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWProductGroup">套餐（YWProductGroup）实例对象</param>
        public static void CheckValid(YWProductGroup yWProductGroup)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWProductGroup.Name))
                throw new CustomException("“名称”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWProductGroup.Products))
                throw new CustomException("“包含菜品编号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWProductGroup.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWProductGroup.Name , 50))
                throw new CustomException("“名称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将套餐（YWProductGroup）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWProductGroup">套餐（YWProductGroup）实例对象</param>
        public static int Insert(YWProductGroup yWProductGroup)
        {
            CheckValid(yWProductGroup);
            return DataAccess.Insert(yWProductGroup);
        }


        /// <summary>
        /// 将套餐（YWProductGroup）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWProductGroup">套餐（YWProductGroup）实例对象</param>
        public static int Update(YWProductGroup yWProductGroup)
        {
            CheckValid(yWProductGroup);
            return DataAccess.Update(yWProductGroup);
        }


        /// <summary>
        /// 根据套餐（YWProductGroup）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">套餐（YWProductGroup）的主键“编号（Id）”</param>
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
        /// 根据套餐（YWProductGroup）的主键“编号（Id）”从数据库中获取套餐（YWProductGroup）的实例。
        /// 成功从数据库中取得记录返回新套餐（YWProductGroup）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">套餐（YWProductGroup）的主键“编号（Id）”</param>
        public static YWProductGroup GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据套餐（YWProductGroup）的主键“编号（Id）”从数据库中获取套餐（YWProductGroup）的实例。
        /// 成功从数据库中取得记录返回新套餐（YWProductGroup）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">套餐（YWProductGroup）的主键“编号（Id）”</param>
        public static YWProductGroup GetDataById(string id)
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


        //add by zy
        //获取系统所有套餐信息
        public static PageData GetSystemProductGroupList(int iPageSize, int iCurPage, string sOrgId, string sName)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWProductGroup].[Id],[YWProductGroup].[Name],[YWProductGroup].[Products],[YWProductGroup].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [YWProductGroup] "
                                + "LEFT JOIN [PT_ORG] ON [YWProductGroup].[OrgId]=[PT_ORG].[Id] WHERE 1=1 ";
            if (sOrgId.Trim() != "")
                parameter.SqlString += " AND [YWProductGroup].[OrgId] = '" + sOrgId + "' ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [YWProductGroup].[Name] LIKE '%" + sName + "%' ";
            PageData pg = CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
            TransProductsId(pg.PageList);
            return pg;
        }

        //add by zy
        //根据餐厅组织机构Id获取菜单列表
        public static PageData GetRestaurantProductGroupListByOrgId(int iOrgId, int iPageSize, int iCurPage, string sName)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWProductGroup].[Id],[YWProductGroup].[Name],[YWProductGroup].[Products],[YWProductGroup].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [YWProductGroup] "
                                + "LEFT JOIN [PT_ORG] ON [YWProductGroup].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWProductGroup].[OrgId]=@OrgId";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [YWProductGroup].[Name] LIKE '%" + sName + "%' ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrgId"     , SqlDbType.Int           , 50 ){ Value = iOrgId}
            };
            parameter.Parameters = parameters;

            PageData pg = CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
            TransProductsId(pg.PageList);
            return pg;
        }

        //add by zy
        //根据Id获取套餐基本信息
        public static DataTable GetProductGroupDataById(int iId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWProductGroup].[Id],[YWProductGroup].[Name],[YWProductGroup].[Products],[YWProductGroup].[OrgId],[PT_ORG].[OrgName] "
                                + "FROM [YWProductGroup] "
                                + "LEFT JOIN [PT_ORG] ON [YWProductGroup].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWProductGroup].[Id]=@Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id"     , SqlDbType.Int           , 50 ){ Value = iId}
            };
            parameter.Parameters = parameters;
            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter);
            //TransProductsId(dt);
            return dt;
        }

        //add by zy
        //翻译结果集中的Products的Id信息
        private static void TransProductsId(DataTable dt)
        {
            dt.Columns["Products"].ReadOnly = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Parameter parameter1 = new Parameter();
                parameter1.SqlString = "SELECT DISTINCT STUFF((SELECT ','+ [Name] FROM [YWProduct] WHERE [Id] IN (" + Convert.ToString(dt.Rows[i]["Products"]) + ") for xml path('')),1,1,'') FROM [YWProduct]";
                string strResult = CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter1).ToString();
                dt.Rows[i]["Products"] = strResult;
            }
        }
    }
}
