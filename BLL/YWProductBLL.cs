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
    /// 对象名称：菜品业务逻辑类（业务逻辑层）
    /// 对象说明：菜品管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWProductBLL
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
        internal static DAL.Common.YWProductDAL DataAccess
        {
            get
            {
                return DAL.Common.YWProductDAL.Instance;
            }
        }


        /// <summary>
        /// 对菜品（YWProduct）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWProduct">菜品（YWProduct）实例对象</param>
        public static void CheckValid(YWProduct yWProduct)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWProduct.Name))
                throw new CustomException("“名称”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWProduct.ProductType))
                throw new CustomException("“菜品类别”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWProduct.HotDegree))
                throw new CustomException("“辣度”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWProduct.BlongOrg))
                throw new CustomException("“菜品归属”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWProduct.Score))
                throw new CustomException("“评分”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWProduct.StdPrice))
                throw new CustomException("“标准价格”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWProduct.MemberPrice))
                throw new CustomException("“会员价格”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWProduct.State))
                throw new CustomException("“状态”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWProduct.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWProduct.CutCnt))
                throw new CustomException("“切配数量”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWProduct.Name , 50))
                throw new CustomException("“名称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWProduct.ShortName, 50))
                throw new CustomException("“简称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWProduct.State, 50))
                throw new CustomException("“状态”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将菜品（YWProduct）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWProduct">菜品（YWProduct）实例对象</param>
        public static int Insert(YWProduct yWProduct)
        {
            CheckValid(yWProduct);
            return DataAccess.Insert(yWProduct);
        }


        /// <summary>
        /// 将菜品（YWProduct）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWProduct">菜品（YWProduct）实例对象</param>
        public static int Update(YWProduct yWProduct)
        {
            CheckValid(yWProduct);
            return DataAccess.Update(yWProduct);
        }


        /// <summary>
        /// 根据菜品（YWProduct）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">菜品（YWProduct）的主键“编号（Id）”</param>
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
        /// 根据菜品（YWProduct）的主键“编号（Id）”从数据库中获取菜品（YWProduct）的实例。
        /// 成功从数据库中取得记录返回新菜品（YWProduct）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">菜品（YWProduct）的主键“编号（Id）”</param>
        public static YWProduct GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据菜品（YWProduct）的主键“编号（Id）”从数据库中获取菜品（YWProduct）的实例。
        /// 成功从数据库中取得记录返回新菜品（YWProduct）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">菜品（YWProduct）的主键“编号（Id）”</param>
        public static YWProduct GetDataById(string id)
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
        //获取系统所有菜品信息
        public static PageData GetSystemProductList(int iPageSize, int iCurPage, string sOrgId, string sName, string sProductTypeId, string sHotDegreeId, string sBlongOrgId, string sMakeTimeId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWProduct].[Id],[YWProduct].[Name],[YWProduct].[ShortName],[YWDictionary1].[Name] AS [ProductTypeName],[YWDictionary2].[Name] AS [HotDegreeName],"
                                + "[PT_ORG1].[OrgName] AS [BlongOrgName],[YWProduct].[Score],[YWProduct].[StdPrice],[YWProduct].[MemberPrice],CONVERT(BIT,[YWProduct].[StateId]) AS [StateId],"
                                + "[YWDictionary3].[Name] AS [MakeTimeName],[YWProduct].[Materials],[YWProduct].[Description],[PT_ORG2].[OrgName] AS [OrgName],[PT_ORG2].[Id] AS [OrgId] "
                                + "FROM [YWProduct] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWProduct].[ProductTypeId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWProduct].[HotDegreeId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG1] ON [YWProduct].[BlongOrgId]=[PT_ORG1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWProduct].[MakeTimeId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG2] ON [YWProduct].[OrgId]=[PT_ORG2].[Id] "
                                + "WHERE [YWProduct].[StateId]=@StateId";
            if (sOrgId.Trim() != "")
                parameter.SqlString += " AND [YWProduct].[OrgId] = '" + sOrgId + "' ";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [YWProduct].[Name] LIKE '%" + sName + "%' ";
            if (sProductTypeId.Trim() != "")
                parameter.SqlString += " AND [YWProduct].[ProductTypeId] =" + sProductTypeId + " ";
            if (sHotDegreeId.Trim() != "")
                parameter.SqlString += " AND [YWProduct].[HotDegreeId] = '" + sHotDegreeId + "'  ";
            if (sBlongOrgId.Trim() != "")
                parameter.SqlString += " AND [YWProduct].[BlongOrgId] =" + sBlongOrgId + " ";
            if (sMakeTimeId.Trim() != "")
                parameter.SqlString += " AND [YWProduct].[MakeTimeId] = '" + sMakeTimeId + "'  ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StateId"   , SqlDbType.Int           , 50 ){ Value = CodeDictionary.SystemState["已启用"]}
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by zy
        //根据用户名获取菜单列表
        public static PageData GetRestaurantProductListByOrgId(int iOrgId, int iPageSize, int iCurPage, string sName, string sProductTypeId, string sHotDegreeId, string sBlongOrgId, string sMakeTimeId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWProduct].[Id],[YWProduct].[Name],[YWProduct].[ShortName],[YWDictionary1].[Name] AS [ProductTypeName],[YWDictionary2].[Name] AS [HotDegreeName],"
                                + "[PT_ORG1].[OrgName] AS [BlongOrgName],[YWProduct].[Score],[YWProduct].[StdPrice],[YWProduct].[MemberPrice],CONVERT(BIT,[YWProduct].[StateId]) AS [StateId],"
                                + "[YWDictionary3].[Name] AS [MakeTimeName],[YWProduct].[Materials],[YWProduct].[Description],[PT_ORG2].[OrgName] AS [Org] "
                                + "FROM [YWProduct] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWProduct].[ProductTypeId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWProduct].[HotDegreeId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG1] ON [YWProduct].[BlongOrgId]=[PT_ORG1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWProduct].[MakeTimeId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG2] ON [YWProduct].[OrgId]=[PT_ORG2].[Id] "
                                + "WHERE [YWProduct].[StateId]=@StateId AND [YWProduct].[OrgId]=@OrgId";
            if (sName.Trim() != "")
                parameter.SqlString += " AND [YWProduct].[Name] LIKE '%" + sName + "%' ";
            if (sProductTypeId.Trim() != "")
                parameter.SqlString += " AND [YWProduct].[ProductTypeId] =" + sProductTypeId + " ";
            if (sHotDegreeId.Trim() != "")
                parameter.SqlString += " AND [YWProduct].[HotDegreeId] = '" + sHotDegreeId + "'  ";
            if (sBlongOrgId.Trim() != "")
                parameter.SqlString += " AND [YWProduct].[BlongOrgId] =" + sBlongOrgId + " ";
            if (sMakeTimeId.Trim() != "")
                parameter.SqlString += " AND [YWProduct].[MakeTimeId] = '" + sMakeTimeId + "'  ";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@StateId"   , SqlDbType.Int           , 50 ){ Value = CodeDictionary.SystemState["已启用"]},
                new SqlParameter("@OrgId"     , SqlDbType.Int           , 50 ){ Value = iOrgId}
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by zy
        //根据用户名获取菜单列表
        public static DataTable GetProductDataById(int iId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWProduct].[Id],[YWProduct].[Name],[YWProduct].[ShortName],[YWDictionary1].[Name] AS [ProductTypeName],[YWDictionary2].[Name] AS [HotDegreeName],[YWDictionary1].[Id] AS [ProductTypeId],[YWDictionary2].[Id] AS [HotDegreeId],"
                                + "[PT_ORG1].[OrgName] AS [BlongOrgName],[PT_ORG1].[Id] AS [BlongOrgId],[YWProduct].[Score],[YWProduct].[StdPrice],[YWProduct].[MemberPrice],CONVERT(BIT,[YWProduct].[StateId]) AS [StateId],"
                                + "[YWDictionary3].[Name] AS [MakeTimeName],[YWDictionary3].[Id] AS [MakeTimeId],[YWProduct].[Materials],[YWProduct].[Description],[PT_ORG2].[OrgName] AS [Org] "
                                + "FROM [YWProduct] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWProduct].[ProductTypeId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWProduct].[HotDegreeId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG1] ON [YWProduct].[BlongOrgId]=[PT_ORG1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWProduct].[MakeTimeId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [PT_ORG] AS [PT_ORG2] ON [YWProduct].[OrgId]=[PT_ORG2].[Id] "
                                + "WHERE [YWProduct].[Id]=@Id";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id"     , SqlDbType.Int           , 50 ){ Value = iId}
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        ////根据餐厅机构编号获取菜单列表
        //public static List<YWProduct> GetAllListByOrgId(int iOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据餐厅机构编号获取菜单列表分页
        //public static PageData GetPageDataByOrgId(int pageSize, int curPage, int iOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.Int , 50 ){ Value = iOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetPageListByParams(pageSize, curPage, parameter);
        //}



    }
}
