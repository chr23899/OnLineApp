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
    /// 对象名称：退菜业务逻辑类（业务逻辑层）
    /// 对象说明：退菜申请管理。
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2016-2-17 10:26:09
    /// </summary>
    public class YWFoodReturnBLL
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
        internal static DAL.Common.YWFoodReturnDAL DataAccess
        {
            get
            {
                return DAL.Common.YWFoodReturnDAL.Instance;
            }
        }


        /// <summary>
        /// 对退菜（YWFoodReturn）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWFoodReturn">退菜（YWFoodReturn）实例对象</param>
        public static void CheckValid(YWFoodReturn yWFoodReturn)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWFoodReturn.Food))
                throw new CustomException("“菜品编码”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWFoodReturn.ReasonId))
                throw new CustomException("“退菜原因”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWFoodReturn.ApplyTime))
                throw new CustomException("“申请时间”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWFoodReturn.ApplyUser))
                throw new CustomException("“申请人”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWFoodReturn.Description , 50))
                throw new CustomException("“描述”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWFoodReturn.ApplyTime , 50))
                throw new CustomException("“申请时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWFoodReturn.ApplyUser , 50))
                throw new CustomException("“申请人”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWFoodReturn.ApproveTime , 50))
                throw new CustomException("“审核时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWFoodReturn.ApproveUser, 50))
                throw new CustomException("“审核人”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将退菜（YWFoodReturn）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFoodReturn">退菜（YWFoodReturn）实例对象</param>
        public static int Insert(YWFoodReturn yWFoodReturn)
        {
            CheckValid(yWFoodReturn);
            return DataAccess.Insert(yWFoodReturn);
        }


        /// <summary>
        /// 将退菜（YWFoodReturn）数据，根据主键“编码（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFoodReturn">退菜（YWFoodReturn）实例对象</param>
        public static int Update(YWFoodReturn yWFoodReturn)
        {
            CheckValid(yWFoodReturn);
            return DataAccess.Update(yWFoodReturn);
        }


        /// <summary>
        /// 根据退菜（YWFoodReturn）的主键“编码（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">退菜（YWFoodReturn）的主键“编码（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据退菜（YWFoodReturn）的主键“编码（Id）”从数据库中获取退菜（YWFoodReturn）的实例。
        /// 成功从数据库中取得记录返回新退菜（YWFoodReturn）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">退菜（YWFoodReturn）的主键“编码（Id）”</param>
        public static YWFoodReturn GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据退菜（YWFoodReturn）的主键“编码（Id）”从数据库中获取退菜（YWFoodReturn）的实例。
        /// 成功从数据库中取得记录返回新退菜（YWFoodReturn）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">退菜（YWFoodReturn）的主键“编码（Id）”</param>
        public static YWFoodReturn GetDataById(string id)
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
        //根据菜品Id、审核人用户名更新对应菜品数据及菜品退菜数据
        public static void UpdateFoodMakeStateIdAndApproveUserName(string strFoodId, string strApproveTime, string strApproveUser)
        {
            //检查点记录数
            int iCheckPoint = strFoodId.Split(',').Length;
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWFood] SET [MakeStateId] = @MakeStateId WHERE [Id] IN (" + strFoodId + ") ";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@MakeStateId"     , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodMakeState["已退菜"]   }
            };
            parameter1.Parameters = parameters1;

            Parameter parameter2 = new Parameter();
            parameter2.SqlString = "UPDATE [YWFoodReturn] SET [ApproveTime] = @ApproveTime, [ApproveUser] = @ApproveUser WHERE [FoodId] IN (" + strFoodId + ") ";
            SqlParameter[] parameters2 = 
            {
                new SqlParameter("@ApproveTime"     , SqlDbType.NVarChar      , 50         ){ Value = strApproveTime   },
                new SqlParameter("@ApproveUser"     , SqlDbType.NVarChar      , 50         ){ Value = strApproveUser   }
            };
            parameter2.Parameters = parameters2;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }


        //add by zy
        //根据Id字符串删除退菜申请
        public static void DeleteFoodReturnDataById(string strFoodId)
        {
            //检查点记录数
            int iCheckPoint = strFoodId.Split(',').Length;
            Parameter parameter = new Parameter();
            parameter.SqlString = "DELETE FROM [YWFoodReturn] WHERE [FoodId] IN (" + strFoodId + ") ";

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);
            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

    }
}
