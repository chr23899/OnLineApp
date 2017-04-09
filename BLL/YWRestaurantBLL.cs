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
    /// 对象名称：餐厅业务逻辑类（业务逻辑层）
    /// 对象说明：餐厅管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWRestaurantBLL
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
        internal static DAL.Common.YWRestaurantDAL DataAccess
        {
            get
            {
                return DAL.Common.YWRestaurantDAL.Instance;
            }
        }


        /// <summary>
        /// 对餐厅（YWRestaurant）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWRestaurant">餐厅（YWRestaurant）实例对象</param>
        public static void CheckValid(YWRestaurant yWRestaurant)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWRestaurant.Org))
                throw new CustomException("“机构编号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRestaurant.Name))
                throw new CustomException("“名称”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRestaurant.RestaurantType))
                throw new CustomException("“餐厅类别”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRestaurant.RoleType))
                throw new CustomException("“授权类型”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRestaurant.FinishTime))
                throw new CustomException("“到期时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRestaurant.State))
                throw new CustomException("“状态”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWRestaurant.Owner))
                throw new CustomException("“负责人”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWRestaurant.Name , 50))
                throw new CustomException("“名称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWRestaurant.FinishTime , 50))
                throw new CustomException("“到期时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWRestaurant.State , 50))
                throw new CustomException("“状态”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWRestaurant.Address , 50))
                throw new CustomException("“地址”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWRestaurant.Phone , 50))
                throw new CustomException("“电话”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWRestaurant.Owner , 50))
                throw new CustomException("“负责人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将餐厅（YWRestaurant）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWRestaurant">餐厅（YWRestaurant）实例对象</param>
        public static int Insert(YWRestaurant yWRestaurant)
        {
            CheckValid(yWRestaurant);
            return DataAccess.Insert(yWRestaurant);
        }


        /// <summary>
        /// 将餐厅（YWRestaurant）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWRestaurant">餐厅（YWRestaurant）实例对象</param>
        public static int Update(YWRestaurant yWRestaurant)
        {
            CheckValid(yWRestaurant);
            return DataAccess.Update(yWRestaurant);
        }


        /// <summary>
        /// 根据餐厅（YWRestaurant）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">餐厅（YWRestaurant）的主键“编号（Id）”</param>
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
        /// 根据餐厅（YWRestaurant）的主键“编号（Id）”从数据库中获取餐厅（YWRestaurant）的实例。
        /// 成功从数据库中取得记录返回新餐厅（YWRestaurant）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">餐厅（YWRestaurant）的主键“编号（Id）”</param>
        public static YWRestaurant GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据餐厅（YWRestaurant）的主键“编号（Id）”从数据库中获取餐厅（YWRestaurant）的实例。
        /// 成功从数据库中取得记录返回新餐厅（YWRestaurant）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">餐厅（YWRestaurant）的主键“编号（Id）”</param>
        public static YWRestaurant GetDataById(string id)
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
        //根据用户名获取所在餐厅的基本信息
        public static DataTable GetRestaurantDataByUserName(string strUserName)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWRestaurant].[Id],[PT_Org].[OrgName],[YWRestaurant].[Name],[YWDictionary1].[Name] AS [RestaurantTypeName],[YWDictionary1].[Id] AS [RestaurantTypeId],[YWDictionary2].[Name] AS [RoleTypeName],[YWDictionary2].[Id] AS [RoleTypeId], "
                                + "[YWRestaurant].[FinishTime],CONVERT(BIT,[YWRestaurant].[StateId]) AS  [StateId],[YWRestaurant].[Score],"
                                + "[YWRestaurant].[Address],[YWRestaurant].[Phone],[PT_USER].[UserName] AS [OwnerUserName],[YWRestaurant].[BookPhones],[YWRestaurant].[Description] "
                                + "FROM [YWRestaurant] "
                                + "LEFT JOIN [PT_Org] ON [PT_Org].[Id]=[YWRestaurant].[OrgId] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWDictionary1].[Id]=[YWRestaurant].[RestaurantTypeId] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWDictionary2].[Id]=[YWRestaurant].[RoleTypeId] "
                                + "LEFT JOIN [PT_USER] ON [PT_USER].[UserName]=[YWRestaurant].[OwnerUserName] "
                                + "WHERE [YWRestaurant].[OrgId]=@OrgId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"   , SqlDbType.Int, 4){ Value = iOrgId }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by zy
        //获取系统所有餐厅的基本信息
        public static PageData GetRestaurantList(int iPageSize, int iCurPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWRestaurant].[Id],[PT_Org].[OrgName],[PT_Org].[Id] AS [OrgId],[YWRestaurant].[Name],[YWDictionary1].[Name] AS [RestaurantTypeName],[YWDictionary2].[Name] AS [RoleTypeName],"
                                + "[YWRestaurant].[FinishTime],CONVERT(BIT,[YWRestaurant].[StateId]) AS  [StateId],[YWRestaurant].[Score],"
                                + "[YWRestaurant].[Address],[YWRestaurant].[Phone],[PT_USER].[NickName] AS [OwnerUserName],[PT_USER].[UserName] AS [UserName],[YWRestaurant].[BookPhones],[YWRestaurant].[Description] "
                                + "FROM [YWRestaurant] "
                                + "LEFT JOIN [PT_Org] ON [PT_Org].[Id]=[YWRestaurant].[OrgId] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWDictionary1].[Id]=[YWRestaurant].[RestaurantTypeId] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWDictionary2].[Id]=[YWRestaurant].[RoleTypeId] "
                                + "LEFT JOIN [PT_USER] ON [PT_USER].[UserName]=[YWRestaurant].[OwnerUserName]";
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        ////根据机构编号来获取关联的餐厅数据
        //public static List<YWRestaurant> GetAllListByOrgId(string strOrgId)
        //{
        //    //构建查询条件
        //    Parameter parameter = new Parameter();
        //    parameter.SqlString = " WHERE [OrgId]=@OrgId ORDER BY [Id]";
        //    SqlParameter[] parameters = 
        //    {
        //        new SqlParameter("@OrgId"   , SqlDbType.NVarChar , 50 ){ Value = strOrgId},
        //    };
        //    parameter.Parameters = parameters;

        //    return GetAllListByParams(parameter);
        //}

        ////根据用户名来获取关联的餐厅数据
        //public static List<YWRestaurant> GetAllListByUserName(string strUserName)
        //{
        //    return GetAllListByOrgId(BLL.YWPersonBLL.GetDataByUserName(strUserName).Org.Id.ToString());
        //}


    }
}
