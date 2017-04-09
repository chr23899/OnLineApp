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
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWFoodBLL
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
        internal static DAL.Common.YWFoodDAL DataAccess
        {
            get
            {
                return DAL.Common.YWFoodDAL.Instance;
            }
        }


        /// <summary>
        /// 对菜品（YWFood）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWFood">菜品（YWFood）实例对象</param>
        public static void CheckValid(YWFood yWFood)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWFood.Product))
                throw new CustomException("“菜品”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWFood.Consume))
                throw new CustomException("“关联消费”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWFood.MakeState))
                throw new CustomException("“菜品制作状态”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWFood.OrderState))
                throw new CustomException("“菜品预定状态”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWFood.CheckState))
                throw new CustomException("“菜品结账状态”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWFood.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWFood.OrderTime , 50))
                throw new CustomException("“下单时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWFood.PreparedTime , 50))
                throw new CustomException("“配菜时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWFood.OutPutTime , 50))
                throw new CustomException("“出菜时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWFood.OnTableTime , 50))
                throw new CustomException("“上菜时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWFood.CheckoutTime , 50))
                throw new CustomException("“结账时间”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将菜品（YWFood）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFood">菜品（YWFood）实例对象</param>
        public static int Insert(YWFood yWFood)
        {
            CheckValid(yWFood);
            return DataAccess.Insert(yWFood);
        }


        /// <summary>
        /// 将菜品（YWFood）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWFood">菜品（YWFood）实例对象</param>
        public static int Update(YWFood yWFood)
        {
            CheckValid(yWFood);
            return DataAccess.Update(yWFood);
        }


        /// <summary>
        /// 根据菜品（YWFood）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">菜品（YWFood）的主键“编号（Id）”</param>
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
        /// 根据菜品（YWFood）的主键“编号（Id）”从数据库中获取菜品（YWFood）的实例。
        /// 成功从数据库中取得记录返回新菜品（YWFood）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">菜品（YWFood）的主键“编号（Id）”</param>
        public static YWFood GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据菜品（YWFood）的主键“编号（Id）”从数据库中获取菜品（YWFood）的实例。
        /// 成功从数据库中取得记录返回新菜品（YWFood）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">菜品（YWFood）的主键“编号（Id）”</param>
        public static YWFood GetDataById(string id)
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
        //切配窗口1
        public static DataTable WaitCutFoodForm1(string strUserName)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWFood].[Id],[YWProduct].[Name] AS [ProductName],[YWFood].[ConsumeId],[YWFood].[SpecialRequirement],[YWConsume].[ConsumeTime] AS [OrderDate],"
                                + "[YWFood].[OrderTime],[YWDictionary1].[Name] AS [MakeState],[YWDictionary2].[Name] AS [OrderState],[YWDictionary3].[Name] AS [CheckState],"
                                + "[PT_ORG].[OrgName] AS OrgName,[YWDictionary4].[Name] AS [MakeTime],[YWProduct].[CutCnt],0 AS [IsRead],"
                                + "datediff(minute,[YWConsume].[ConsumeTime]+' '+[YWFood].[OrderTime]+':00',getdate()) AS [WaitMinute],"//计算等待分钟数
                                + "([YWDictionary4].[Backup2]+[YWDictionary4].[Backup3])/2 AS [AvgMakeMinute],"//计算平均制作分钟数
                                + "datediff(minute,[YWConsume].[ConsumeTime]+' '+[YWFood].[OrderTime]+':00',getdate())+([YWDictionary4].[Backup2]+[YWDictionary4].[Backup3])/2 AS [OrderCondition] "//使用等待时间+平均制作时间作为排序条件
                                + "FROM [YWFood] "
                                + "LEFT JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "LEFT JOIN [YWConsume] ON [YWFood].[ConsumeId]=[YWConsume].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWFood].[MakeStateId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWFood].[OrderStateId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWFood].[CheckStateId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary4] ON [YWProduct].[MakeTimeId]=[YWDictionary4].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWFood].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWFood].[OrgId]=@OrgId AND [YWFood].[MakeStateId]=@MakeStateId "
                                + "ORDER BY [OrderCondition] DESC";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"          , SqlDbType.Int      , 4      ){ Value = iOrgId                                    },
                new SqlParameter("@MakeStateId"    , SqlDbType.Int      , 4      ){ Value = CodeDictionary.FoodMakeState["已下单"]    }
            };
            parameter.Parameters = parameters;
            //执行SQL，获取结果集
            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter);
            dt.Columns["IsRead"].ReadOnly = false;  //将数据集中的处理标记字段置为可修改
            //新建datatable用于输出结果
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("ProductName", typeof(string));          //菜品名称
            dtResult.Columns.Add("SpecialRequirement", typeof(string));   //特殊要求
            dtResult.Columns.Add("Cnt", typeof(int));                     //菜品数量
            dtResult.Columns.Add("FoodId", typeof(string));               //菜品编号
            dtResult.Columns.Add("OrderState", typeof(bool));             //菜品等叫状态(false-等叫，true-起菜)
            dtResult.Columns.Add("OrderStateName", typeof(string));       //菜品等叫状态名称
            
            //第一次循环，对“起菜”状态的菜品进行分组汇总
            //第一层循环
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //判断记录是否已处理
                if (Convert.ToInt32(dt.Rows[i]["IsRead"]) == 0 && dt.Rows[i]["OrderState"].ToString() == "起菜")
                {
                    //将该行标记为已处理
                    dt.Rows[i]["IsRead"] = 1;
                    //新建返回结果中的数据行，并获取菜品名称、特殊要求等信息，数量初始为1,
                    DataRow dr = dtResult.NewRow();
                    dr["ProductName"] = dt.Rows[i]["ProductName"];
                    dr["SpecialRequirement"] = dt.Rows[i]["SpecialRequirement"];
                    dr["Cnt"] = 1;
                    dr["FoodId"] = dt.Rows[i]["Id"];
                    dr["OrderState"] = true;//(false-等叫，true-起菜)
                    dr["OrderStateName"] = dt.Rows[i]["OrderState"];
                    dtResult.Rows.Add(dr);
                    //获取菜品切配的最大合并数量，如果数值为0，则不限数量，数值置为999
                    int iCutCnt = Convert.ToInt32(dt.Rows[i]["CutCnt"]) == 0 ? 999 : Convert.ToInt32(dt.Rows[i]["CutCnt"]);
                    //菜品数量统计值，初始化为1
                    int k = 1;
                    //第二层循环（从当前行的下一行开始循环）
                    for (int j = i + 1; j < dt.Rows.Count; j++)
                    {
                        //当菜品名称、特殊要求一致、时间差30分钟以内时，菜品数量进行累加
                        if (dt.Rows[i]["ProductName"].ToString() == dt.Rows[j]["ProductName"].ToString() && dt.Rows[i]["SpecialRequirement"] == dt.Rows[j]["SpecialRequirement"] && Convert.ToInt32(dt.Rows[i]["WaitMinute"]) - 30 < Convert.ToInt32(dt.Rows[j]["WaitMinute"]))
                        {
                            //将该行标记为已处理
                            dt.Rows[j]["IsRead"] = 1;
                            //将结果集中的最后一行菜品数量加1
                            dtResult.Rows[dtResult.Rows.Count - 1]["Cnt"] = Convert.ToInt32(dtResult.Rows[dtResult.Rows.Count - 1]["Cnt"]) + 1;
                            //将结果集中的最后一行菜品编码逗号分隔
                            dtResult.Rows[dtResult.Rows.Count - 1]["FoodId"] = dtResult.Rows[dtResult.Rows.Count - 1]["FoodId"].ToString() + "," + dt.Rows[j]["Id"];
                            k += 1;
                            //达到菜品切配的最大合并数量时，跳出循环
                            if (k == iCutCnt)
                                break;
                        }
                    }
                }
            }
            //第二次循环，对“等叫”状态的菜品进行罗列
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //判断记录是否已处理
                if (Convert.ToInt32(dt.Rows[i]["IsRead"]) == 0 && dt.Rows[i]["OrderState"].ToString() == "等叫")
                {
                    //将该行标记为已处理
                    dt.Rows[i]["IsRead"] = 1;
                    //新建返回结果中的数据行，并获取菜品名称、特殊要求等信息，数量初始为1,
                    DataRow dr = dtResult.NewRow();
                    dr["ProductName"] = dt.Rows[i]["ProductName"];
                    dr["SpecialRequirement"] = dt.Rows[i]["SpecialRequirement"];
                    dr["Cnt"] = 1;
                    dr["FoodId"] = dt.Rows[i]["Id"];
                    dr["OrderState"] = false;//(false-等叫，true-起菜)
                    dr["OrderStateName"] = dt.Rows[i]["OrderState"];
                    dtResult.Rows.Add(dr);
                }
            }
            return dtResult;
        }

        //add by chr
        //切配窗口3
        public static DataTable WaitCutFoodForm3(string strUserName)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWFood].[Id],[YWProduct].[Name] AS [ProductName],[YWFood].[SpecialRequirement],[YWFood].[OrderStateId],[YWDictionary].[Name] AS [OrderState] "
                                + "FROM [YWFood] "
                                + "LEFT JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "LEFT JOIN [YWDictionary] ON [YWFood].[OrderStateId]=[YWDictionary].[Id] "
                                + "WHERE [YWFood].[OrgId]=@OrgId AND [YWFood].[MakeStateId]=@MakeStateId "
                                + "ORDER BY [OrderStateId],[PreparedTime]";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"          , SqlDbType.Int      , 4      ){ Value = iOrgId                                    },
                new SqlParameter("@MakeStateId"    , SqlDbType.Int      , 4      ){ Value = CodeDictionary.FoodMakeState["待制作"]    }
            };
            parameter.Parameters = parameters;
            //执行SQL，获取结果集
            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter);
            //新建datatable用于输出结果
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add("ProductName", typeof(string));          //菜品名称
            dtResult.Columns.Add("SpecialRequirement", typeof(string));   //特殊要求
            dtResult.Columns.Add("Cnt", typeof(int));                     //菜品数量
            dtResult.Columns.Add("FoodId", typeof(string));               //菜品编号
            dtResult.Columns.Add("OrderState", typeof(bool));             //菜品等叫状态(false-等叫，true-起菜)
            dtResult.Columns.Add("OrderStateName", typeof(string));       //菜品等叫状态名称

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //新建返回结果中的数据行，并获取菜品名称、特殊要求等信息，数量初始为1,
                DataRow dr = dtResult.NewRow();
                dr["ProductName"] = dt.Rows[i]["ProductName"];
                dr["SpecialRequirement"] = dt.Rows[i]["SpecialRequirement"];
                dr["Cnt"] = 1;
                dr["FoodId"] = dt.Rows[i]["Id"];
                if (dt.Rows[i]["OrderState"].ToString() == "等叫")
                {
                    dr["OrderState"] = false;//(false-等叫，true-起菜)
                }
                else if (dt.Rows[i]["OrderState"].ToString() == "起菜")
                {
                    dr["OrderState"] = true;//(false-等叫，true-起菜)
                }
                dr["OrderStateName"] = dt.Rows[i]["OrderState"];
                dtResult.Rows.Add(dr);
            }
            return dtResult;
        }

        //add by chr
        //根据消费记录Id获取消费总价（标准价）
        public static double GetStdTotalPriceByConsumeId(int iConsumeId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT ISNULL(SUM([YWProduct].[StdPrice]),0) AS [TotalPrice] FROM [YWFood] "
                                + "LEFT JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "WHERE [YWFood].[ConsumeId]=@ConsumeId AND [YWFood].[MakeStateId]<>@MakeStateId AND [YWFood].[CheckStateId]<>@CheckStateId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ConsumeId"   , SqlDbType.Int, 4){ Value = iConsumeId                              },
                new SqlParameter("@MakeStateId" , SqlDbType.Int, 4){ Value = CodeDictionary.FoodMakeState["已退菜"]  },
                new SqlParameter("@CheckStateId", SqlDbType.Int, 4){ Value = CodeDictionary.FoodCheckState["已结账"] }
            };
            parameter.Parameters = parameters;
            return Convert.ToDouble(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }

        //add by chr
        //根据FoodId获取记录的预定状态
        public static int GetFoodOrderStateIdById(int iFoodId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [OrderStateId] FROM [YWFood] WHERE [Id] = @Id ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id"            , SqlDbType.Int      , 4         ){ Value = iFoodId          }
            };
            parameter.Parameters = parameters;
            return Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }
        //add by chr
        //根据FoodId字符串获取记录的消费记录Id（FoodId字符串中的Id必须来源于同一消费单）
        public static int GetConsumeIdById(string strFoodId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT DISTINCT [ConsumeId] FROM [YWFood] WHERE [Id] IN (" + strFoodId + ") ";
            return Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }

        //add by chr
        //获取系统所有菜品记录列表
        public static PageData GetSystemFoodList(int iPageSize, int iCurPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWFood].[Id],[YWProduct].[Name] AS [ProductName],[YWFood].[ConsumeId],[YWFood].[SpecialRequirement],[YWFood].[OrderTime],[YWFood].[PreparedTime],"
                                + "[YWFood].[OutPutTime],[YWFood].[OnTableTime],[YWFood].[CheckoutTime],[YWDictionary1].[Name] AS [MakeState],[YWDictionary2].[Name] AS [OrderState],[YWDictionary3].[Name] AS [CheckState],[PT_ORG].[OrgName] AS OrgName "
                                + "FROM [YWFood] "
                                + "LEFT JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWFood].[MakeStateId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWFood].[OrderStateId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWFood].[CheckStateId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWFood].[OrgId]=[PT_ORG].[Id] ";
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据用户名获取待切配列表
        public static PageData GetWaitCutFoodListByUserName(string strUserName, int iPageSize, int iCurPage)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWFood].[Id],[YWProduct].[Name] AS [ProductName],[YWFood].[ConsumeId],[YWFood].[SpecialRequirement],[YWFood].[OrderTime],[YWFood].[PreparedTime],"
                                + "[YWFood].[OutPutTime],[YWFood].[OnTableTime],[YWFood].[CheckoutTime],[YWDictionary1].[Name] AS [MakeState],[YWDictionary2].[Name] AS [OrderState],[YWDictionary3].[Name] AS [CheckState],[PT_ORG].[OrgName] AS OrgName "
                                + "FROM [YWFood] "
                                + "LEFT JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWFood].[MakeStateId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWFood].[OrderStateId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWFood].[CheckStateId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWFood].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWFood].[OrgId]=@OrgId AND [YWFood].[MakeStateId]=@MakeStateId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"          , SqlDbType.Int      , 4      ){ Value = iOrgId                                    },
                new SqlParameter("@MakeStateId"    , SqlDbType.Int      , 4      ){ Value = CodeDictionary.FoodMakeState["已下单"]    }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据用户名获取已出菜列表,并按配菜时间排序
        public static PageData GetFinishedFoodListByUserName(string strUserName, int iPageSize, int iCurPage)
        {
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWFood].[Id],[YWProduct].[Name] AS [ProductName],[YWFood].[ConsumeId],[YWFood].[SpecialRequirement],[YWFood].[OrderTime],[YWFood].[PreparedTime],"
                                + "[YWFood].[OutPutTime],[YWFood].[OnTableTime],[YWFood].[CheckoutTime],[YWDictionary1].[Name] AS [MakeState],[YWDictionary2].[Name] AS [OrderState],[YWDictionary3].[Name] AS [CheckState],[PT_ORG].[OrgName] AS OrgName "
                                + "FROM [YWFood] "
                                + "LEFT JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWFood].[MakeStateId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWFood].[OrderStateId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWFood].[CheckStateId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWFood].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWFood].[OrgId]=@OrgId AND [YWFood].[MakeStateId]=@MakeStateId "
                                + "ORDER BY [YWFood].[PreparedTime]";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"          , SqlDbType.Int      , 4      ){ Value = iOrgId                                    },
                new SqlParameter("@MakeStateId"    , SqlDbType.Int      , 4      ){ Value = CodeDictionary.FoodMakeState["已出菜"]    }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据用户名获取传菜员列表，获取成功返回success（参数：UserName）
        public static PageData GetSendUserListByUserName(string strUserName, int iPageSize, int iCurPage)
        {
            //获取用户所属饭店OrgID
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWPerson].[UserNameUserName],[YWFood].[OutPutTime] FROM [YWPerson] "
                                + "LEFT JOIN [YWFood] ON [YWPerson].[UserNameUserName]=[YWFood].[Backup2] "
                                + "WHERE "
                                + "[YWPerson].[UserNameUserName] IN (SELECT [UserName] FROM [PT_UserLink] WHERE [RoleId]=@RoleId) "
                                + "AND [YWPerson].[OrgId]=@OrgId "
                                + "ORDER BY [YWFood].[OutPutTime]";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@OrgId"     , SqlDbType.Int      , 4      ){ Value = iOrgId                                   },
                new SqlParameter("@RoleId"    , SqlDbType.Int      , 4      ){ Value = CodeDictionary.BusinessRole["传菜员"]    }
            };
            parameter.Parameters = parameters;
            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据用户名获取本店所有待审批的退菜列表
        public static DataTable GetWaitCheckReturnFoodList(string strUserName, string strType)
        {
            //获取用户所属饭店OrgID
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //获取当前饭店，在当前时间所处的消费时间段Id
            int iConsumeTimeBlockId = YWDictionaryBLL.GetConsumeTimeBlockIdByDateTimeNow(iOrgId.ToString());
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWFood].[Id],[YWProduct].[Name] AS FoodName,[YWProduct].[StdPrice],[YWProduct].[MemberPrice],"
                                + "[YWDictionary1].[Name] AS MakeStateName,[YWDictionary2].[Name] AS [OrderStateName],[YWDictionary3].[Name] AS [CheckStateName],"
                                + "[YWFood].[SpecialRequirement],CONVERT(NVARCHAR,'') AS [SpecialRequirementName],"
                                + "[YWFood].[OrderTime],[YWFood].[PreparedTime],[YWFood].[OutPutTime],[YWFood].[OnTableTime],[YWFood].[CheckoutTime],"
                                + "[YWFoodReturn].[ReasonId],[YWDictionary4].[Name] AS ReasonName,[YWFoodReturn].[Description],[YWFoodReturn].[ApplyTime],"
                                + "[PT_User].[NickName] AS [ApplyUser],[YWConsume].[ConsumeTableId],[YWTable].[Name] AS TableName,[YWFood].[OrgId],[PT_ORG].[OrgName] AS OrgName "
                                + "FROM [YWFood] "
                                + "INNER JOIN [YWFoodReturn] ON [YWFood].[Id]=[YWFoodReturn].[FoodId] "
                                + "LEFT JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWFood].[MakeStateId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWFood].[OrderStateId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWFood].[CheckStateId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary4] ON [YWFoodReturn].[ReasonId]=[YWDictionary4].[Id] "
                                + "LEFT JOIN [PT_USER] ON [YWFoodReturn].[ApplyUser]=[PT_USER].[UserName] "
                                + "LEFT JOIN [YWConsume] ON [YWFood].[ConsumeId]=[YWConsume].[Id] "
                                + "LEFT JOIN [YWTable] ON [YWConsume].[ConsumeTableId]=[YWTable].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWFood].[OrgId]=[PT_ORG].[Id] ";
            SqlParameter[] parameters;
            switch (strType)
            {
                case "WaitCheck":
                    parameter.SqlString += "WHERE [YWFood].[OrgId]=@OrgId AND [YWFoodReturn].[ApproveTime] IS NULL OR [YWFoodReturn].[ApplyTime]='' ";
                    parameters = new SqlParameter[] 
                    { 
                        new SqlParameter("@OrgId" , SqlDbType.Int , 4  ){ Value = iOrgId  }
                    };
                    break;
                case "CheckDone":
                    parameter.SqlString += "WHERE [YWFood].[OrgId]=@OrgId AND [YWFoodReturn].[ApproveTime] IS NOT NULL AND [YWFoodReturn].[ApplyTime]<>'' AND [YWConsume].[ConsumeTimeBlockId]=@ConsumeTimeBlockId ";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@OrgId"              , SqlDbType.Int , 4  ){ Value = iOrgId               },
                        new SqlParameter("@ConsumeTimeBlockId" , SqlDbType.Int , 4  ){ Value = iConsumeTimeBlockId  }
                    };
                    break;
                default:
                    parameters = new SqlParameter[] { };
                    break;
            }
            parameter.SqlString += "ORDER BY [YWFoodReturn].[ApplyTime]";
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by chr
        //根据用户名获取所有已点菜列表
        public static DataTable GetOrderedFoodListByUserName(string strUserName, string strOrderState)
        {
            //获取用户所属饭店OrgID
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);
            //获取当前饭店，在当前时间所处的消费时间段Id
            int iConsumeTimeBlockId = YWDictionaryBLL.GetConsumeTimeBlockIdByDateTimeNow(iOrgId.ToString());
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWFood].[Id],[YWProduct].[Name] AS FoodName,[YWProduct].[StdPrice],[YWProduct].[MemberPrice],"
                                + "[YWDictionary1].[Name] AS MakeStateName,[YWDictionary2].[Name] AS [OrderStateName],[YWDictionary3].[Name] AS [CheckStateName],"
                                + "[YWFood].[SpecialRequirement],CONVERT(NVARCHAR,'') AS [SpecialRequirementName],"
                                + "[YWFood].[OrderTime],[YWFood].[PreparedTime],[YWFood].[OutPutTime],[YWFood].[OnTableTime],[YWFood].[CheckoutTime],"
                                + "[YWFoodReturn].[ReasonId],[YWDictionary4].[Name] AS ReasonName,[YWFoodReturn].[Description],[YWFoodReturn].[ApplyTime],"
                                + "[PT_User].[NickName] AS [ApplyUser],[YWConsume].[ConsumeTableId],[YWTable].[Name] AS TableName,[YWFood].[OrgId],[PT_ORG].[OrgName] AS OrgName "
                                + "FROM [YWFood] "
                                + "INNER JOIN [YWFoodReturn] ON [YWFood].[Id]=[YWFoodReturn].[FoodId] "
                                + "LEFT JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWFood].[MakeStateId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWFood].[OrderStateId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWFood].[CheckStateId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary4] ON [YWFoodReturn].[ReasonId]=[YWDictionary4].[Id] "
                                + "LEFT JOIN [PT_USER] ON [YWFoodReturn].[ApplyUser]=[PT_USER].[UserName] "
                                + "LEFT JOIN [YWConsume] ON [YWFood].[ConsumeId]=[YWConsume].[Id] "
                                + "LEFT JOIN [YWTable] ON [YWConsume].[ConsumeTableId]=[YWTable].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWFood].[OrgId]=[PT_ORG].[Id] "
                                + "WHERE [YWFood].[OrgId]=@OrgId AND [YWFood].[OrderStateId]=@OrderStateId AND [YWConsume].[ConsumeTimeBlockId]=@ConsumeTimeBlockId ";
            SqlParameter[] parameters;
            switch (strOrderState)
            {
                case "Wait":
                    parameters = new SqlParameter[] 
                    { 
                        new SqlParameter("@OrgId"              , SqlDbType.Int , 4  ){ Value = iOrgId                                              },
                        new SqlParameter("@OrderStateId"       , SqlDbType.Int , 4  ){ Value = CodeDictionary.FoodOrderState["等叫"]               },
                        new SqlParameter("@ConsumeTimeBlockId" , SqlDbType.Int , 4  ){ Value = iConsumeTimeBlockId                                 }
                    };
                    break;
                case "Serving":
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@OrgId"              , SqlDbType.Int , 4  ){ Value = iOrgId                                              },
                        new SqlParameter("@OrderStateId"       , SqlDbType.Int , 4  ){ Value = CodeDictionary.FoodOrderState["起菜"]               },
                        new SqlParameter("@ConsumeTimeBlockId" , SqlDbType.Int , 4  ){ Value = iConsumeTimeBlockId                                 }
                    };
                    break;
                default:
                    parameters = new SqlParameter[] { };
                    break;
            }
            parameter.SqlString += "ORDER BY [YWFoodReturn].[ApplyTime]";
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by chr
        //根据菜品Id获取菜品列表
        public static DataTable GetFoodListById(string strFoodId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWFood].[Id],[YWProduct].[Name] AS [ProductName],[YWFood].[ConsumeId],[YWFood].[SpecialRequirement],CONVERT(NVARCHAR,'') AS [SpecialRequirementName],"
                                + "[YWFood].[OrderTime],[YWFood].[PreparedTime],[YWFood].[OutPutTime],[YWFood].[OnTableTime],[YWFood].[CheckoutTime],"
                                + "[YWFood].[MakeStateId],[YWDictionary1].[Name] AS [MakeState],"
                                + "[YWFood].[OrderStateId],[YWDictionary2].[Name] AS [OrderState],"
                                + "[YWFood].[CheckStateId],[YWDictionary3].[Name] AS [CheckState],"
                                + "CONVERT(BIT,CASE WHEN [YWFoodReturn].[ApplyUser] IS NULL THEN 0 ELSE 1 END) AS [ReturnState],"
                                + "[YWProduct].[ProductTypeId],[YWDictionary4].[Name] AS [ProductTypeName],[YWProduct].[StdPrice],[YWProduct].[MemberPrice],[YWFood].[OrgId],[PT_ORG].[OrgName] AS OrgName "
                                + "FROM [YWFood] "
                                + "LEFT JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWFood].[MakeStateId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWFood].[OrderStateId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWFood].[CheckStateId]=[YWDictionary3].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary4] ON [YWDictionary4].[Id]=[YWProduct].[ProductTypeId] "
                                + "LEFT JOIN [PT_ORG] ON [YWFood].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [YWFoodReturn] ON [YWFood].[Id] = [YWFoodReturn].[FoodId] "
                                + "WHERE [YWFood].[Id] IN (" + strFoodId + ") "
                                + "ORDER BY [ReturnState],[OrderTime]";
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by chr
        //翻译菜品特殊要求字符串，要求Datatable中必须有SpecialRequirement、SpecialRequirementName俩列
        //public static DataTable TranslateSpecialRequirement(DataTable datatableResult)
        //{
        //    if (datatableResult.Rows.Count > 0)
        //    {
        //        //将需要赋值的列设置为可读写
        //        datatableResult.Columns["SpecialRequirementName"].ReadOnly = false;
        //        //根据结果数据中的最大组织机构编码和编码类型，获取其对应的自定义特殊要求编码
        //        string strOrgId = datatableResult.Compute("MAX(OrgId)", "").ToString();
        //        //判断结果集中是否有记录
        //        if (strOrgId != null && strOrgId != "")
        //        {
        //            DataTable datatableCodeList = YWDictionaryBLL.GetCodeListByOrgIdAndTypeId(strOrgId, CodeDictionary.DictionaryType["特殊要求"]);
        //            //循环结果数据，如果特殊要求编码不为空，则获取对应的名称并拼装以及赋值
        //            foreach (DataRow dr in datatableResult.Rows)
        //            {
        //                string strId = dr["SpecialRequirement"].ToString();
        //                if (strId != "")
        //                {
        //                    DataRow[] datarow = datatableCodeList.Select("Id IN (" + strId + ")");
        //                    string strName = "";
        //                    for (int i = 0; i < datarow.Length; i++)
        //                    {
        //                        if (i != 0)
        //                        {
        //                            strName += ",";
        //                        }
        //                        strName += datarow[i]["Name"].ToString();
        //                    }
        //                    dr["SpecialRequirementName"] = strName;
        //                }
        //            }
        //        }
        //    }
        //    return datatableResult;
        //}


        //add by chr
        //获取菜品数据的分组汇总数据，包括名称、数量、标准单价、会员单价
        public static DataTable GetFoodListByConsumeId(int iConsumeId, int iOrderStateId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWFood].[Id],[YWFood].[ProductId],[YWProduct].[Name],[YWFood].[MakeStateId],[YWDictionary1].[CodeId],"
                                + "CASE WHEN [YWFoodReturn].[FoodId]>0 AND [YWFoodReturn].[ApproveUser] IS NULL THEN '退菜中' ELSE [YWDictionary1].[Name] END AS [MakeStateName],"//根据关联的退菜表中是否有申请人名称，判断是否处于退菜申请状态
                                + "[YWFood].[OrderStateId],[YWDictionary2].[Name] AS [OrderStateName],"
                                + "[YWProduct].[ProductTypeId],[YWDictionary3].[Name] AS [ProductTypeName],[YWProduct].[StdPrice],[YWProduct].[MemberPrice] "
                                + "FROM [YWFood] "
                                + "LEFT JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWDictionary1].[Id]=[YWFood].[MakeStateId] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWDictionary2].[Id]=[YWFood].[OrderStateId] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWDictionary3].[Id]=[YWProduct].[ProductTypeId] "
                                + "LEFT JOIN [YWFoodReturn] ON [YWFood].[Id] = [YWFoodReturn].[FoodId] "
                                + "WHERE [YWFood].[ConsumeId]=@ConsumeId AND [YWFood].[OrderStateId]=@OrderStateId "
                                + "ORDER BY [YWFood].[OrderStateId],[YWFood].[ProductId],[YWFood].[MakeStateId],[YWFoodReturn].[ApplyUser]";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ConsumeId"   , SqlDbType.Int, 4){ Value = iConsumeId    },
                new SqlParameter("@OrderStateId", SqlDbType.Int, 4){ Value = iOrderStateId }
            };
            parameter.Parameters = parameters;
            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter);
            //初始化结果集的格式
            DataTable dtResult = new DataTable();
            dtResult.Columns.Add(new DataColumn("OrderStateName", typeof(string)));
            dtResult.Columns.Add(new DataColumn("ProductId", typeof(int)));
            dtResult.Columns.Add(new DataColumn("Name", typeof(string)));
            dtResult.Columns.Add(new DataColumn("ProductTypeName", typeof(string)));
            dtResult.Columns.Add(new DataColumn("StdPrice", typeof(double)));
            dtResult.Columns.Add(new DataColumn("MemberPrice", typeof(double)));
            dtResult.Columns.Add(new DataColumn("Cnt", typeof(int)));
            dtResult.Columns.Add(new DataColumn("SumStdPrice", typeof(double)));
            dtResult.Columns.Add(new DataColumn("SumMemberPrice", typeof(double)));
            dtResult.Columns.Add(new DataColumn("FoodId", typeof(string)));
            dtResult.Columns.Add(new DataColumn("MakeStateName", typeof(string)));
            dtResult.Columns.Add(new DataColumn("MinMakeStateCodeId", typeof(int)));
            //第一层循环
            for (int i = 0; i < dt.Rows.Count; )
            {
                //定义新数据行
                DataRow dr = dtResult.NewRow();
                //初始化分组字段信息
                string strOrderStateName = dt.Rows[i]["OrderStateName"].ToString();
                int iProductId = Convert.ToInt32(dt.Rows[i]["ProductId"].ToString());
                string strName = dt.Rows[i]["Name"].ToString();
                string strProductTypeName = dt.Rows[i]["ProductTypeName"].ToString();
                double douStdPrice = Convert.ToDouble(dt.Rows[i]["StdPrice"]);
                double douMemberPrice = Convert.ToDouble(dt.Rows[i]["MemberPrice"]);
                dr["OrderStateName"] = strOrderStateName;
                dr["ProductId"] = iProductId;
                dr["Name"] = strName;
                dr["ProductTypeName"] = strProductTypeName;
                dr["StdPrice"] = douStdPrice;
                dr["MemberPrice"] = douMemberPrice;
                //初始化汇总字段
                int iCnt = 0;                                                       //记录数
                double douSumStdPrice = 0;                                          //标准总价
                double douSumMemberPrice = 0;                                       //会员总价
                string strFoodId = "";                                              //菜品Id字符串
                string strMakeStateName = "";                                       //菜品状态（用于比较）
                string strMakeStateNameResult = "";                                 //菜品状态（输出结果）
                string strTemp = "";                                                //菜品状态（中间值）
                int iMinFoodStateCodeId = Convert.ToInt32(dt.Rows[i]["CodeId"]);    //菜品最小状态编码
                //第二层循环
                for (; i < dt.Rows.Count; )
                {    
                    //初始化第二层统计计数
                    int iStateCnt = 0;                                              //状态计数（用于累加每个菜品每个状态对应的数量）
                    strMakeStateName = dt.Rows[i]["MakeStateName"].ToString();
                    //菜品名称一致性判断
                    if (strName == dt.Rows[i]["Name"].ToString())
                    {   
                        //第三层循环
                        for (; i < dt.Rows.Count; )
                        {
                            //菜品名称及菜品状态一致性判断
                            if (strName == dt.Rows[i]["Name"].ToString() && strMakeStateName == dt.Rows[i]["MakeStateName"].ToString())
                            {
                                //计数及字符串的累加，并向datarow赋值
                                iCnt += 1;
                                douSumStdPrice += Convert.ToDouble(dt.Rows[i]["StdPrice"]);
                                douSumMemberPrice += Convert.ToDouble(dt.Rows[i]["MemberPrice"]);
                                strFoodId += dt.Rows[i]["Id"].ToString() + ",";        
                                dr["Cnt"] = iCnt;
                                dr["SumStdPrice"] = douSumStdPrice;
                                dr["SumMemberPrice"] = douSumMemberPrice;
                                dr["FoodId"] = strFoodId.Substring(0, strFoodId.Length - 1);
                                //根据状态累加计数
                                iStateCnt += 1;
                                strTemp = dt.Rows[i]["MakeStateName"].ToString() + "×" + iStateCnt.ToString() + " ";
                                //用于datatable最后一行的判断，否则最后一类菜品的状态字符串无法赋值
                                if (i == dt.Rows.Count - 1)
                                {
                                    strMakeStateNameResult += strTemp;
                                    dr["MakeStateName"] = strMakeStateNameResult;
                                }
                                //菜品最小状态编码的比较和赋值
                                if (iMinFoodStateCodeId > Convert.ToInt32(dt.Rows[i]["CodeId"]))
                                {
                                    iMinFoodStateCodeId = Convert.ToInt32(dt.Rows[i]["CodeId"]);
                                }
                                dr["MinMakeStateCodeId"] = iMinFoodStateCodeId;
                                //游标移动
                                i++;
                            }
                            else
                            {
                                //当下一行菜品名称和状态出现不一致时，状态计数清零，状态字符串累加并赋值
                                iStateCnt = 0;
                                strMakeStateNameResult += strTemp;
                                dr["MakeStateName"] = strMakeStateNameResult;
                                break;
                            }
                        }          
                    }
                    else
                    { 
                        break;
                    }
                }
                //如果数量为1，将状态字符串后的数量截掉
                if (Convert.ToInt32(dr["Cnt"]) == 1)
                {
                    string s = dr["MakeStateName"].ToString();
                    dr["MakeStateName"] = s.Substring(0, s.IndexOf("×"));
                }
                dtResult.Rows.Add(dr);
            }
            return dtResult;
        }

        //add by chr
        //根据Id获取菜品当前制作状态
        public static int GetFoodMakeStateById(int iFoodId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [MakeStateId] FROM [YWFood] WHERE [Id]=@FoodId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@FoodId"          , SqlDbType.Int      , 4         ){ Value = iFoodId            }
            };
            parameter.Parameters = parameters;
            return Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }

        //add by chr
        //根据string类型的Id获取多个菜品当前制作状态
        public static DataTable GetFoodMakeStatesByIds(string strFoodId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [MakeStateId] FROM [YWFood] WHERE [Id] IN (" + strFoodId + ")";
            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by chr
        //根据FoodId获取该菜品对应的特殊要求信息列表
        //public static DataTable GetFoodSpecialRequirementListById(int iFoodId)
        //{
        //    //构建查询条件，根据FoodId获取特殊需求Id字符串
        //    Parameter parameter1 = new Parameter();
        //    parameter1.SqlString = "SELECT [SpecialRequirement] FROM [YWFood] WHERE [Id] = @Id";
        //    SqlParameter[] parameters1 = 
        //    {
        //        new SqlParameter("@FoodId"          , SqlDbType.Int      , 4         ){ Value = iFoodId            }
        //    };
        //    parameter1.Parameters = parameters1;
        //    string strSpecialRequirementId = CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter1).ToString();
        //    //构建查询条件，根据特殊需求Id字符串获取特殊需求编码列表
        //    Parameter parameter2 = new Parameter();
        //    parameter2.SqlString = "SELECT [Id],[DictionaryTypeId],[CodeId],[Name],[Description] FROM [YWDictionary] "
        //                         + "WHERE [Id] IN (" + strSpecialRequirementId + ") ";
        //    return CommonToolsBLL.GetAllListByParams(parameter2);
        //}

        //add by chr
        //根据string类型的Id，检查对应的消费记录中是否还存在状态非“已上菜”或“已退菜”的菜品
        public static Boolean CheckOtherFoodIsServed(string strFoodId, int iConsumeId)
        {
            //构建查询条件，根据FoodId获取特殊需求Id字符串
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT COUNT(*) FROM [YWFood] WHERE [ConsumeId]=@ConsumeId AND [MakeStateId] NOT IN (@MakeStateId1,@MakeStateId2)";
            //允许传入的菜品Id为空，此时检查消费记录中的所有菜品状态
            if (strFoodId != null && strFoodId != "")
            {
                parameter.SqlString += "AND [Id] NOT IN (" + strFoodId + ") ";
            }
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ConsumeId"          , SqlDbType.Int      , 4         ){ Value = iConsumeId                                        },
                new SqlParameter("@MakeStateId1"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodMakeState["已上菜"]            },
                new SqlParameter("@MakeStateId2"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodMakeState["已退菜"]            }
            };
            parameter.Parameters = parameters;
            if (Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter)) > 0)
                return false;
            else
                return true;
        }

        //add by chr
        //点菜
        public static void AddFoodData(int iProductId, int iConsumeId, string strSpecialRequirement, string strOrderTime, int iMakeStateId, int iOrderStateId, int iCheckStateId, int iOrgId, int iCnt)
        {
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "INSERT INTO [YWFood] "
                                + "([ProductId],[ConsumeId],[SpecialRequirement],[OrderTime],[MakeStateId],[OrderStateId],[CheckStateId],[OrgId]) "
                                + "VALUES ";
            //如果有多个菜品，循环增加多个values串
            for (int i = 0; i < iCnt; i++)
            {
                if (i != 0)
                {
                    parameter1.SqlString += ",";
                }
                parameter1.SqlString += "(@ProductId,@ConsumeId,@SpecialRequirement,@OrderTime,@MakeStateId,@OrderStateId,@CheckStateId,@OrgId)"; 
            }
                
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@ProductId"          , SqlDbType.Int      , 4         ){ Value = iProductId            },
                new SqlParameter("@ConsumeId"          , SqlDbType.Int      , 4         ){ Value = iConsumeId            },
                new SqlParameter("@SpecialRequirement" , SqlDbType.NText    , 1073741823){ Value = strSpecialRequirement },
                new SqlParameter("@OrderTime"          , SqlDbType.NVarChar , 50        ){ Value = strOrderTime          },
                new SqlParameter("@MakeStateId"        , SqlDbType.Int      , 4         ){ Value = iMakeStateId          },
                new SqlParameter("@OrderStateId"       , SqlDbType.Int      , 4         ){ Value = iOrderStateId         },
                new SqlParameter("@CheckStateId"       , SqlDbType.Int      , 4         ){ Value = iCheckStateId         },
                new SqlParameter("@OrgId"              , SqlDbType.Int      , 4         ){ Value = iOrgId                }
            };
            parameter1.Parameters = parameters1;

            //构建查询条件（更新消费记录状态为“已点菜”）
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = "UPDATE [YWConsume] "
                                 + "SET [ConsumeStateId]=@ConsumeStateId "
                                 + "WHERE [Id] =@Id ";
            SqlParameter[] parameters2 = 
            {
                new SqlParameter("@ConsumeStateId"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.ConsumeState["已点菜"]          },
                new SqlParameter("@Id"                   , SqlDbType.Int      , 4         ){ Value = iConsumeId                                     }
            };
            parameter2.Parameters = parameters2;
            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);

            CommonToolsBLL.ExcuteSqlWithTransaction(parmList);
        }

        //add by chr
        //将菜品状态改为已上菜，并检查菜是否已上齐，若已上齐则修改消费记录状态为“菜上齐”
        public static void ServingFood(string strFoodId, int iFromStateId, int iToStateId)
        {
            //检查点记录数
            int iCheckPoint = strFoodId.Split(',').Length;
            //根据菜品ID获取消费记录Id
            int iConsumeId = YWFoodBLL.GetConsumeIdById(strFoodId);
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWFood] SET [MakeStateId] = @ToStateId WHERE [MakeStateId] = @FromStateId AND [Id] IN (" + strFoodId + ") ";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@ToStateId"     , SqlDbType.Int      , 4         ){ Value = iToStateId       },
                new SqlParameter("@FromStateId"   , SqlDbType.Int      , 4         ){ Value = iFromStateId     }
            };
            parameter1.Parameters = parameters1;

            //构建查询条件
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = "UPDATE [YWConsume] "
                                + "SET [ConsumeStateId]=@ToStateId "
                                + "WHERE [Id] =@Id AND [ConsumeStateId]<>@FromStateId "; //已结账则不允许修改状态至“菜上齐”
            SqlParameter[] parameters2 = 
            {
                new SqlParameter("@ToStateId"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.ConsumeState["菜上齐"]          },
                new SqlParameter("@FromStateId"     , SqlDbType.Int      , 4         ){ Value = CodeDictionary.ConsumeState["已结账"]          },
                new SqlParameter("@Id"              , SqlDbType.Int      , 4         ){ Value = iConsumeId                                     }
            };
            parameter2.Parameters = parameters2;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            //如果本消费单存在未上完的菜，则仅更新菜品状态，否则同时更新消费单状态为“菜上齐”
            if (CheckOtherFoodIsServed(strFoodId, iConsumeId))
            {
                parmList.Add(parameter1);
            }
            else
            {
                parmList.Add(parameter1);
                parmList.Add(parameter2);
            }
            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        //add by chr
        //更新菜品预定状态，根据源状态Id和目的状态Id更新
        public static void UpdateFoodOrderStateById(string strFoodId, int iFromStateId, int iToStateId)
        {
            //检查点记录数
            int iCheckPoint = strFoodId.Split(',').Length;
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWFood] SET [OrderStateId] = @ToStateId WHERE [Id] IN (" + strFoodId + ") AND [OrderStateId] = @FromStateId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ToStateId"     , SqlDbType.Int      , 4         ){ Value = iToStateId       },
                new SqlParameter("@FromStateId"   , SqlDbType.Int      , 4         ){ Value = iFromStateId     }
            };
            parameter.Parameters = parameters;
            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);   
        }

        //add by chr
        //更新菜品制作状态，根据源状态Id和目的状态Id更新
        private static void UpdateFoodMakeStateById(string strFoodId, int iFromStateId, int iToStateId)
        {
            //检查点记录数
            int iCheckPoint = strFoodId.Split(',').Length;
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWFood] SET [MakeStateId] = @ToStateId WHERE [Id] IN (" + strFoodId + ") AND [MakeStateId] = @FromStateId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ToStateId"     , SqlDbType.Int      , 4         ){ Value = iToStateId       },
                new SqlParameter("@FromStateId"   , SqlDbType.Int      , 4         ){ Value = iFromStateId     }
            };
            parameter.Parameters = parameters;
            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        //add by chr
        //根据菜品预定状态不同，更新菜品制作状态
        public static string UpdateFoodMakeStateByIdWithFoodOrderState(string strFoodId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Id],[MakeStateId],[OrderStateId] FROM [YWFood] WHERE [Id] IN (" + strFoodId + ") ";
            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter);

            string strFoodId1 = "";
            string strFoodId2 = "";
            int iCheckPoint1 = 0;
            int iCheckPoint2 = 0;
            string strResult = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //判断是否为“等叫”
                if (Convert.ToInt32(dt.Rows[i]["OrderStateId"]) == CodeDictionary.FoodOrderState["等叫"])
                {
                    iCheckPoint1 += 1;
                    strFoodId1 += dt.Rows[i]["Id"].ToString() + ",";
                }
                //判断是否为“起菜”
                else if (Convert.ToInt32(dt.Rows[i]["OrderStateId"]) == CodeDictionary.FoodOrderState["起菜"])
                {
                    iCheckPoint2 += 1;
                    strFoodId2 += dt.Rows[i]["Id"].ToString() + ",";
                }
            }
            //判断是否有记录
            if (iCheckPoint1 > 0)
            {
                //截取字符串最后一个逗号
                strFoodId1 = strFoodId1.Substring(0, strFoodId1.Length - 1);
                UpdateFoodMakeStateById(strFoodId1, CodeDictionary.FoodMakeState["已下单"], CodeDictionary.FoodMakeState["待制作"]);
                strResult += "待制作×" + iCheckPoint1.ToString();
            }
            //判断是否有记录
            if (iCheckPoint2 > 0)
            {
                //截取字符串最后一个逗号
                strFoodId2 = strFoodId2.Substring(0, strFoodId2.Length - 1);
                UpdateFoodMakeStateById(strFoodId2, CodeDictionary.FoodMakeState["已下单"], CodeDictionary.FoodMakeState["制作中"]);
                strResult += " 制作中×" + iCheckPoint2.ToString();
            }

            return strResult;
        }

        //add by chr
        //更新菜品制作状态，根据源状态Id和目的状态Id更新
        public static void UpdateFoodMakeStateByIdAndMakeStateAndOrderState(string strFoodId)
        {
            //检查点记录数
            int iCheckPoint = strFoodId.Split(',').Length;
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWFood] SET [MakeStateId] = @ToStateId WHERE [Id] IN (" + strFoodId + ") AND [OrderStateId] = @OrderStateId AND [MakeStateId] = @FromStateId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ToStateId"     , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodMakeState["制作中"]      },
                new SqlParameter("@FromStateId"   , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodMakeState["待制作"]      },
                new SqlParameter("@OrderStateId"  , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodOrderState["起菜"]       }
            };
            parameter.Parameters = parameters;
            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        //add by chr
        //根据菜品Id、传菜员用户名更新对应菜品数据
        public static void UpdateFoodMakeStateIdAndSendUserName(string strFoodId, string strSendUserName)
        {
            //检查点记录数
            int iCheckPoint = strFoodId.Split(',').Length;
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWFood] SET [MakeStateId] = @ToStateId, [Backup2] = @SendUserName WHERE [MakeStateId] = @FromStateId AND [Id] IN (" + strFoodId + ") ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@SendUserName"  , SqlDbType.NVarChar , 50        ){ Value = strSendUserName                              },
                new SqlParameter("@FromStateId"   , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodMakeState["制作中"]       },
                new SqlParameter("@ToStateId"     , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodMakeState["已出菜"]       }
            };
            parameter.Parameters = parameters;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        //add by chr
        //根据菜品ID，完成菜品的下单，并将消费记录状态改为已点菜
        public static void UpdateFoodOrderStateIdAndConsumeStateId(string strFoodId)
        {
            //检查点记录数
            int iCheckPoint = strFoodId.Split(',').Length;
            //获取消费记录ID
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT DISTINCT [ConsumeId] FROM [YWFood] WHERE [Id] IN (" + strFoodId + ") ";
            int iConsumeId = Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWFood] SET [OrderStateId] = @OrderStateId WHERE [Id] IN (" + strFoodId + ") ";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@OrderStateId", SqlDbType.Int, 4){ Value = CodeDictionary.FoodOrderState["起菜"] }
            };
            parameter1.Parameters = parameters1;

            Parameter parameter2 = new Parameter();
            parameter2.SqlString = "UPDATE [YWConsume] SET [ConsumeStateId] = @ToStateId WHERE [Id] = @ConsumeId AND [ConsumeStateId] IN (@FromStateId1, @FromStateId2, @FromStateId3) ";
            SqlParameter[] parameters2 = 
            {
                new SqlParameter("@ConsumeId"   , SqlDbType.Int, 4){ Value = iConsumeId                            },
                new SqlParameter("@ToStateId"   , SqlDbType.Int, 4){ Value = CodeDictionary.ConsumeState["已点菜"] },
                new SqlParameter("@FromStateId1", SqlDbType.Int, 4){ Value = CodeDictionary.ConsumeState["已开桌"] },
                new SqlParameter("@FromStateId2", SqlDbType.Int, 4){ Value = CodeDictionary.ConsumeState["菜上齐"] },
                new SqlParameter("@FromStateId3", SqlDbType.Int, 4){ Value = CodeDictionary.ConsumeState["待结账"] }
            };
            parameter2.Parameters = parameters2;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        //add by chr
        //根据菜品ID，取消菜品的下单，并根据操作类型选择是否将消费记录状态改为已开桌
        public static void UpdateFoodOrderStateIdAndConsumeStateIdByOprType(string strFoodId, string strType)
        {
            //检查点记录数
            int iCheckPoint = strFoodId.Split(',').Length;
            //获取消费记录ID
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT DISTINCT [ConsumeId] FROM [YWFood] WHERE [Id] IN (" + strFoodId + ") ";
            int iConsumeId = Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWFood] SET [OrderStateId] = @OrderStateId WHERE [MakeStateId]=@MakeStateId AND [Id] IN (" + strFoodId + ") ";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@OrderStateId", SqlDbType.Int, 4){ Value = CodeDictionary.FoodOrderState["等叫"] },
                new SqlParameter("@MakeStateId" , SqlDbType.Int, 4){ Value = CodeDictionary.FoodMakeState["已下单"] }
            };
            parameter1.Parameters = parameters1;

            Parameter parameter2 = new Parameter();
            parameter2.SqlString = "UPDATE [YWConsume] SET [ConsumeStateId] = @ToStateId WHERE [Id] = @ConsumeId AND [ConsumeStateId] IN (@FromStateId1, @FromStateId2, @FromStateId3) ";
            SqlParameter[] parameters2 = 
            {
                new SqlParameter("@ConsumeId"   , SqlDbType.Int, 4){ Value = iConsumeId                            },
                new SqlParameter("@ToStateId"   , SqlDbType.Int, 4){ Value = CodeDictionary.ConsumeState["已开桌"] },
                new SqlParameter("@FromStateId1", SqlDbType.Int, 4){ Value = CodeDictionary.ConsumeState["已点菜"] },
                new SqlParameter("@FromStateId2", SqlDbType.Int, 4){ Value = CodeDictionary.ConsumeState["菜上齐"] },
                new SqlParameter("@FromStateId3", SqlDbType.Int, 4){ Value = CodeDictionary.ConsumeState["待结账"] }
            };
            parameter2.Parameters = parameters2;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            switch (strType)
            {
                case "Part":
                    parmList.Add(parameter1);
                    break;
                case "All":
                    parmList.Add(parameter1);
                    parmList.Add(parameter2);
                    break;
            }
            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }

        //add by chr
        //根据多个菜品ID，完成菜品的删除
        public static void DeleteFoodListByIds(string strFoodId)
        {
            //检查点记录数
            int iCheckPoint = strFoodId.Split(',').Length;
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "DELETE FROM [YWFood] WHERE [Id] IN (" + strFoodId + ") ";

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, iCheckPoint);
        }
    }
}
