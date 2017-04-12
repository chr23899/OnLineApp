using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using Chr.OnlineApp.COL;
using Chr.OnlineApp.DAL;
using Chr.OnlineApp.SFL;
using System.Data.SqlClient;

namespace Chr.OnlineApp.BLL
{
    /// <summary>
    /// 对象名称：消费业务逻辑类（业务逻辑层）
    /// 对象说明：消费管理
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    public class YWConsumeBLL
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
        internal static DAL.Common.YWConsumeDAL DataAccess
        {
            get
            {
                return DAL.Common.YWConsumeDAL.Instance;
            }
        }


        /// <summary>
        /// 对消费（YWConsume）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWConsume">消费（YWConsume）实例对象</param>
        public static void CheckValid(YWConsume yWConsume)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWConsume.ConsumeTable))
                throw new CustomException("“座位”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWConsume.ConsumeTime))
                throw new CustomException("“消费日期”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWConsume.ConsumeTimeBlock))
                throw new CustomException("“消费时间段”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWConsume.ActualNumber))
                throw new CustomException("“实际消费人数”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWConsume.WelcomeOwner))
                throw new CustomException("“带客人”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWConsume.ServiceOwner))
                throw new CustomException("“服务员”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWConsume.TotalPrice))
                throw new CustomException("“应收总价”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWConsume.ActualTotalPrice))
                throw new CustomException("“实收总价”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWConsume.ConsumeState))
                throw new CustomException("“消费状态”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(yWConsume.Org))
                throw new CustomException("“所属餐厅”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWConsume.ConsumeTime , 50))
                throw new CustomException("“消费日期”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWConsume.WelcomeOwner , 50))
                throw new CustomException("“带客人”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(yWConsume.ServiceOwner , 50))
                throw new CustomException("“服务员”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将消费（YWConsume）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWConsume">消费（YWConsume）实例对象</param>
        public static int Insert(YWConsume yWConsume)
        {
            CheckValid(yWConsume);
            return DataAccess.Insert(yWConsume);
        }


        /// <summary>
        /// 将消费（YWConsume）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWConsume">消费（YWConsume）实例对象</param>
        public static int Update(YWConsume yWConsume)
        {
            CheckValid(yWConsume);
            return DataAccess.Update(yWConsume);
        }


        /// <summary>
        /// 根据消费（YWConsume）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">消费（YWConsume）的主键“编号（Id）”</param>
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
        /// 根据消费（YWConsume）的主键“编号（Id）”从数据库中获取消费（YWConsume）的实例。
        /// 成功从数据库中取得记录返回新消费（YWConsume）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">消费（YWConsume）的主键“编号（Id）”</param>
        public static YWConsume GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据消费（YWConsume）的主键“编号（Id）”从数据库中获取消费（YWConsume）的实例。
        /// 成功从数据库中取得记录返回新消费（YWConsume）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">消费（YWConsume）的主键“编号（Id）”</param>
        public static YWConsume GetDataById(string id)
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
        //根据已点菜列表、优惠券列表、及其它参数创建消费单
        public static void CreateConsumeListByParameter(ConsumeJsonObject dataObj)
        {
            //获取当前日期
            string strConsumeTime = TimeHelper.ConvertDateTimeToDateString(DateTime.Now);
            //获取用户所处的组织机构
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(dataObj.username);
            //获取当前饭店，在当前时间所处的消费时间段Id
            int iConsumeTimeBlockId = YWDictionaryBLL.GetConsumeTimeBlockIdByDateTimeNow(iOrgId.ToString());

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            
            //如果未传递消费记录Id的信息
            if (dataObj.consumeId == 0)
            {
                //构建查询条件
                Parameter parameter1 = new Parameter();
                parameter1.SqlString = "INSERT INTO [YWConsume]"
                                    + "([ConsumeTableId],[FromBookId],[ConsumeTime],[ConsumeTimeBlockId],[ActualNumber],[WelcomeOwnerUserName],[ServiceOwnerUserName],"
                                    + "[TotalPrice],[PriceOff],[Discount],[ActualTotalPrice],[ConsumeStateId],[OrgId],[IsMember],[MemberCardNo],[ServiceNo],[Payment])"
                                    + "VALUES"
                                    + "(@ConsumeTableId,@FromBookId,@ConsumeTime,@ConsumeTimeBlockId,@ActualNumber,@WelcomeOwnerUserName,@ServiceOwnerUserName,"
                                    + "@TotalPrice,@PriceOff,@Discount,@ActualTotalPrice,@ConsumeStateId,@OrgId,@IsMember,@MemberCardNo,@ServiceNo,@Payment)";
                SqlParameter[] parameters1 = 
                {
                    new SqlParameter("@ConsumeTableId"       , SqlDbType.Int      , 4         ){ Value = dataObj.tableId                        },
                    new SqlParameter("@FromBookId"           , SqlDbType.Int      , 4         ){ Value = dataObj.frombookId                     },
                    new SqlParameter("@ConsumeTime"          , SqlDbType.NVarChar , 50        ){ Value = strConsumeTime                         },
                    new SqlParameter("@ConsumeTimeBlockId"   , SqlDbType.Int      , 4         ){ Value = iConsumeTimeBlockId                    },
                    new SqlParameter("@ActualNumber"         , SqlDbType.Int      , 4         ){ Value = 0                                      },
                    new SqlParameter("@WelcomeOwnerUserName" , SqlDbType.NVarChar , 50        ){ Value = dataObj.username                       },
                    new SqlParameter("@ServiceOwnerUserName" , SqlDbType.NVarChar , 50        ){ Value = dataObj.username                       },
                    new SqlParameter("@TotalPrice"           , SqlDbType.Decimal  , 9         ){ Value = dataObj.totalPrice                     },
                    new SqlParameter("@PriceOff"             , SqlDbType.Decimal  , 9         ){ Value = dataObj.priceOff                       },
                    new SqlParameter("@Discount"             , SqlDbType.Decimal  , 9         ){ Value = dataObj.discount                       },
                    new SqlParameter("@ActualTotalPrice"     , SqlDbType.Decimal  , 9         ){ Value = dataObj.actualTotalPrice               },
                    new SqlParameter("@ConsumeStateId"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.ConsumeState["已结账"]  },
                    new SqlParameter("@OrgId"                , SqlDbType.Int      , 4         ){ Value = iOrgId                                 },
                    new SqlParameter("@IsMember"             , SqlDbType.Int      , 4         ){ Value = dataObj.isMember                       },
                    new SqlParameter("@MemberCardNo"         , SqlDbType.NVarChar , 50        ){ Value = dataObj.memberCardNo                   },
                    new SqlParameter("@ServiceNo"            , SqlDbType.NVarChar , 50        ){ Value = dataObj.serviceNo                      },
                    new SqlParameter("@Payment"              , SqlDbType.Int      , 4         ){ Value = dataObj.payment                        }
                };
                parameter1.Parameters = parameters1;
                parmList.Add(parameter1);
                //构建查询条件
                for (int i = 0; i < dataObj.foods.Count; i++)
                {
                    Parameter parameter2 = new Parameter();
                    parameter2.SqlString = "INSERT INTO [YWFood] "
                                        + "([ProductId],[ConsumeId],[SpecialRequirement],[OrderTime],[MakeStateId],[OrderStateId],[CheckStateId],[OrgId]) "
                                        + "VALUES ";
                    //如果有多个菜品，循环增加多个values串
                    for (int j = 0; j < dataObj.foods[i].cnt; j++)
                    {
                        if (j != 0)
                        {
                            parameter2.SqlString += ",";
                        }
                        parameter2.SqlString += "(@ProductId,CONVERT(INT,IDENT_CURRENT(@YWTableName)),@SpecialRequirement,@OrderTime,@MakeStateId,@OrderStateId,@CheckStateId,@OrgId)";
                    }

                    SqlParameter[] parameters2 = 
                    {
                        new SqlParameter("@ProductId"          , SqlDbType.Int      , 4         ){ Value = dataObj.foods[i].productId              },
                        new SqlParameter("@YWTableName"        , SqlDbType.NVarChar , 50        ){ Value = "YWConsume"                             },
                        new SqlParameter("@SpecialRequirement" , SqlDbType.NText    , 1073741823){ Value = ""                                      },
                        new SqlParameter("@OrderTime"          , SqlDbType.NVarChar , 50        ){ Value = strConsumeTime                          },
                        new SqlParameter("@MakeStateId"        , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodMakeState["已上菜"]  },
                        new SqlParameter("@OrderStateId"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodOrderState["等叫"]   },
                        new SqlParameter("@CheckStateId"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodCheckState["已结账"] },
                        new SqlParameter("@OrgId"              , SqlDbType.Int      , 4         ){ Value = iOrgId                                  }
                    };
                    parameter2.Parameters = parameters2;
                    parmList.Add(parameter2);
                }
                //构建查询条件
                for (int i = 0; i < dataObj.coupons.Count; i++)
                {
                    Parameter parameter3 = new Parameter();
                    parameter3.SqlString = "INSERT INTO [YWCoupons] "
                                        + "([ConsumeId],[CouponsTypeId],[Cnt],[TicketNo],[Amount]) "
                                        + "VALUES "
                                        + "(CONVERT(INT,IDENT_CURRENT(@YWTableName)),@CouponsTypeId,@Cnt,@TicketNo,@Amount)";
                    SqlParameter[] parameters3 = 
                    {
                        new SqlParameter("@YWTableName"   , SqlDbType.NVarChar , 50){ Value = "YWConsume"                  },
                        new SqlParameter("@CouponsTypeId" , SqlDbType.Int      , 4 ){ Value = dataObj.coupons[i].typeId    },
                        new SqlParameter("@Cnt"           , SqlDbType.Int      , 4 ){ Value = dataObj.coupons[i].cnt       },
                        new SqlParameter("@TicketNo"      , SqlDbType.NVarChar , 50){ Value = dataObj.coupons[i].no        },
                        new SqlParameter("@Amount"        , SqlDbType.Decimal  , 9 ){ Value = dataObj.coupons[i].amount    }
                    };
                    parameter3.Parameters = parameters3;
                    parmList.Add(parameter3);
                }
                //构建查询条件(给本饭店所有具有切配功能的人发通知)
                Parameter parameter4 = new Parameter();
                parameter4.SqlString = "UPDATE YWUserTips SET Tips1=1 WHERE UserName IN ("
                                     + "SELECT UserName FROM PT_USER WHERE OrgId=@OrgId AND UserName IN ("
                                     + "SELECT UserName FROM PT_UserLink WHERE RoleId IN ("
                                     + "SELECT RoleId FROM PT_RoleLink WHERE FunctionId='0101030401')))";
                SqlParameter[] parameters4 = 
                {
                    new SqlParameter("@OrgId"                , SqlDbType.Int      , 4         ){ Value = iOrgId                                 }
                };
                parameter4.Parameters = parameters4;
                parmList.Add(parameter4);
                CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, 1);
               
            }
            //如果传递了消费记录Id的信息
            else 
            {
                //构建查询条件
                Parameter parameter1 = new Parameter();
                parameter1.SqlString = "DELETE FROM [YWFood] WHERE [ConsumeId]=@ConsumeId ";
                SqlParameter[] parameters1 = 
                {
                    new SqlParameter("@ConsumeId", SqlDbType.Int, 4){ Value = dataObj.consumeId }
                };
                parameter1.Parameters = parameters1;
                parmList.Add(parameter1);
                //构建查询条件
                for (int i = 0; i < dataObj.foods.Count; i++)
                {
                    Parameter parameter2 = new Parameter();
                    parameter2.SqlString = "INSERT INTO [YWFood] "
                                        + "([ProductId],[ConsumeId],[SpecialRequirement],[OrderTime],[MakeStateId],[OrderStateId],[CheckStateId],[OrgId]) "
                                        + "VALUES ";
                    //如果有多个菜品，循环增加多个values串
                    for (int j = 0; j < dataObj.foods[i].cnt; j++)
                    {
                        if (j != 0)
                        {
                            parameter2.SqlString += ",";
                        }
                        parameter2.SqlString += "(@ProductId,@ConsumeId,@SpecialRequirement,@OrderTime,@MakeStateId,@OrderStateId,@CheckStateId,@OrgId)";
                    }

                    SqlParameter[] parameters2 = 
                    {
                        new SqlParameter("@ProductId"          , SqlDbType.Int      , 4         ){ Value = dataObj.foods[i].productId              },
                        new SqlParameter("@ConsumeId  "        , SqlDbType.Int      , 4         ){ Value = dataObj.consumeId                       },
                        new SqlParameter("@SpecialRequirement" , SqlDbType.NText    , 1073741823){ Value = ""                                      },
                        new SqlParameter("@OrderTime"          , SqlDbType.NVarChar , 50        ){ Value = strConsumeTime                          },
                        new SqlParameter("@MakeStateId"        , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodMakeState["已上菜"]  },
                        new SqlParameter("@OrderStateId"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodOrderState["等叫"]   },
                        new SqlParameter("@CheckStateId"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodCheckState["已结账"] },
                        new SqlParameter("@OrgId"              , SqlDbType.Int      , 4         ){ Value = iOrgId                                  }
                    };
                    parameter2.Parameters = parameters2;
                    parmList.Add(parameter2);
                }
                
                //构建查询条件
                Parameter parameter3 = new Parameter();
                parameter3.SqlString = "DELETE FROM [YWCoupons] WHERE [ConsumeId]=@ConsumeId ";
                SqlParameter[] parameters3 = 
                {
                    new SqlParameter("@ConsumeId", SqlDbType.Int, 4){ Value = dataObj.consumeId }
                };
                parameter3.Parameters = parameters3;
                parmList.Add(parameter3);
                //构建查询条件
                for (int i = 0; i < dataObj.coupons.Count; i++)
                {
                    Parameter parameter4 = new Parameter();
                    parameter4.SqlString = "INSERT INTO [YWCoupons] "
                                        + "([ConsumeId],[CouponsTypeId],[Cnt],[TicketNo],[Amount]) "
                                        + "VALUES "
                                        + "(@ConsumeId,@CouponsTypeId,@Cnt,@TicketNo,@Amount)";
                    SqlParameter[] parameters4 = 
                    {
                        new SqlParameter("@ConsumeId"     , SqlDbType.Int      , 4 ){ Value = dataObj.consumeId            },
                        new SqlParameter("@CouponsTypeId" , SqlDbType.Int      , 4 ){ Value = dataObj.coupons[i].typeId    },
                        new SqlParameter("@Cnt"           , SqlDbType.Int      , 4 ){ Value = dataObj.coupons[i].cnt       },
                        new SqlParameter("@TicketNo"      , SqlDbType.NVarChar , 50){ Value = dataObj.coupons[i].no        },
                        new SqlParameter("@Amount"        , SqlDbType.Decimal  , 9 ){ Value = dataObj.coupons[i].amount    }
                    };
                    parameter4.Parameters = parameters4;
                    parmList.Add(parameter4);
                }
                CommonToolsBLL.ExcuteSqlWithTransaction(parmList);
            }
        }

        //add by chr
        //根据Id获取消费记录当前状态
        public static int GetConsumeStateById(int iConsumeId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [ConsumeStateId] FROM [YWConsume] WHERE [Id]=@ConsumeId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ConsumeId"          , SqlDbType.Int      , 4         ){ Value = iConsumeId     }
            };
            parameter.Parameters = parameters;
            return Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }

        //add by chr
        //根据桌号、日期、时间段，检查是否存在状态非“已关桌”的消费记录，如果存在，则认为不能开桌
        public static Boolean CheckConsumeDataDuplicate(int iConsumeTableId, string strConsumeTime, int iConsumeTimeBlockId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT COUNT(*) FROM [YWConsume] WHERE [ConsumeTableId]=@ConsumeTableId AND [ConsumeTime]=@ConsumeTime AND [ConsumeTimeBlockId]=@ConsumeTimeBlockId AND [ConsumeStateId]<>@ConsumeStateId ";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@ConsumeTableId"        , SqlDbType.Int      , 4         ){ Value = iConsumeTableId                               },
                new SqlParameter("@ConsumeTime"           , SqlDbType.NVarChar , 50        ){ Value = strConsumeTime                                },
                new SqlParameter("@ConsumeTimeBlockId"    , SqlDbType.Int      , 4         ){ Value = iConsumeTimeBlockId                           },
                new SqlParameter("@ConsumeStateId"        , SqlDbType.Int      , 4         ){ Value = CodeDictionary.ConsumeState["已关桌"]         }
            };
            parameter.Parameters = parameters;

            if (Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter)) > 0)
                return true;
            else
                return false;
        }

        //add by chr
        //根据ConsumeId从消费表中获取其所属的组织机构Id
        public static int GetOrgIdByConsumeId(int iConsumeId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [OrgId] FROM [YWConsume] WHERE [Id] = @Id ";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id"    , SqlDbType.Int      , 4         ){ Value = iConsumeId         }
            };
            parameter.Parameters = parameters;

            return Convert.ToInt32(CommonToolsBLL.ExcuteSqlReturnSingleObject(parameter));
        }

        //add by chr
        //根据消费记录ID查询账单
        public static DataTable GetConsumeDataById(int iConsumeId)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWConsume].[Id],[YWConsume].[ConsumeTableId],[YWTable].[Name] AS [ConsumeTableName],[YWConsume].[FromBookId],"
                                + "[YWConsume].[ConsumeTime],[YWConsume].[ConsumeTimeBlockId],[YWDictionary1].[Name] AS ConsumeTimeBlockName,"
                                + "[YWConsume].[ActualNumber],[YWConsume].[WelcomeOwnerUserName],[PT_USER1].[Nickname] AS [WelcomeOwnerNickName],"
                                + "[YWConsume].[ServiceOwnerUserName],[PT_USER2].[Nickname] AS [ServiceOwnerNickName],[YWConsume].[TotalPrice],"
                                + "[YWConsume].[PriceOff],[YWConsume].[Discount],[YWConsume].[ActualTotalPrice],[YWConsume].[ConsumeStateId],"
                                + "[YWDictionary2].[Name] AS [ConsumeStateName],[YWConsume].[OrgId],[PT_ORG].[OrgName] AS [OrgName],"
                                + "[YWConsume].[IsMember],[YWConsume].[MemberCardNo],[YWConsume].[ServiceNo],[YWConsume].[Payment] AS [PaymentId],[YWDictionary3].[Name] AS [PaymentName] "
                                + "FROM [YWConsume] "
                                + "LEFT JOIN [YWTable] ON [YWConsume].[ConsumeTableId]=[YWTable].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWConsume].[ConsumeTimeBlockId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWConsume].[WelcomeOwnerUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWConsume].[ServiceOwnerUserName]=[PT_USER2].[UserName] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWConsume].[ConsumeStateId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWConsume].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWConsume].[Payment]=[YWDictionary3].[Id] "
                                + "WHERE [YWConsume].[Id]=@ConsumeId";

            SqlParameter[] parameters = 
            {
                new SqlParameter("@ConsumeId" , SqlDbType.Int , 4  ){ Value = iConsumeId  }
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.GetAllListByParams(parameter);
        }

        //add by chr
        //获取系统所有消费记录列表
        public static PageData GetSystemConsumeList(int iPageSize, int iCurPage)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWConsume].[Id],[YWConsume].[ConsumeTableId],[YWTable].[Name] AS [ConsumeTableName],[YWConsume].[FromBookId],"
                                + "[YWConsume].[ConsumeTime],[YWConsume].[ConsumeTimeBlockId],[YWDictionary1].[Name] AS ConsumeTimeBlockName,"
                                + "[YWConsume].[ActualNumber],[YWConsume].[WelcomeOwnerUserName],[PT_USER1].[Nickname] AS [WelcomeOwnerNickName],"
                                + "[YWConsume].[ServiceOwnerUserName],[PT_USER2].[Nickname] AS [ServiceOwnerNickName],[YWConsume].[TotalPrice],"
                                + "[YWConsume].[PriceOff],[YWConsume].[Discount],[YWConsume].[ActualTotalPrice],[YWConsume].[ConsumeStateId],"
                                + "[YWDictionary2].[Name] AS [ConsumeStateName],[YWConsume].[OrgId],[PT_ORG].[OrgName] AS [OrgName],"
                                + "[YWConsume].[IsMember],[YWConsume].[MemberCardNo],[YWConsume].[ServiceNo],[YWConsume].[Payment] AS [PaymentId],[YWDictionary3].[Name] AS [PaymentName] "
                                + "FROM [YWConsume] "
                                + "LEFT JOIN [YWTable] ON [YWConsume].[ConsumeTableId]=[YWTable].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWConsume].[ConsumeTimeBlockId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWConsume].[WelcomeOwnerUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWConsume].[ServiceOwnerUserName]=[PT_USER2].[UserName] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWConsume].[ConsumeStateId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWConsume].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWConsume].[Payment]=[YWDictionary3].[Id] ";

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据用户名获取消费记录列表
        public static PageData GetConsumeListByUserName(string strUserName, string strType, int iPageSize, int iCurPage)
        {
            //获取用户所处的组织机构
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);

            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWConsume].[Id],[YWConsume].[ConsumeTableId],[YWTable].[Name] AS [ConsumeTableName],[YWConsume].[FromBookId],"
                                + "[YWConsume].[ConsumeTime],[YWConsume].[ConsumeTimeBlockId],[YWDictionary1].[Name] AS ConsumeTimeBlockName,"
                                + "[YWConsume].[ActualNumber],[YWConsume].[WelcomeOwnerUserName],[PT_USER1].[Nickname] AS [WelcomeOwnerNickName],"
                                + "[YWConsume].[ServiceOwnerUserName],[PT_USER2].[Nickname] AS [ServiceOwnerNickName],[YWConsume].[TotalPrice],"
                                + "[YWConsume].[PriceOff],[YWConsume].[Discount],[YWConsume].[ActualTotalPrice],[YWConsume].[ConsumeStateId],"
                                + "[YWDictionary2].[Name] AS [ConsumeStateName],[YWConsume].[OrgId],[PT_ORG].[OrgName] AS [OrgName],"
                                + "[YWConsume].[IsMember],[YWConsume].[MemberCardNo],[YWConsume].[ServiceNo],[YWConsume].[Payment] AS [PaymentId],[YWDictionary3].[Name] AS [PaymentName],"
                                + "ISNULL([SumFood].[Cnt],0) AS Cnt,ISNULL([SumFood].[StdPrice],0) AS StdPrice "
                                + "FROM [YWConsume] "
                                + "LEFT JOIN [YWTable] ON [YWConsume].[ConsumeTableId]=[YWTable].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWConsume].[ConsumeTimeBlockId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWConsume].[WelcomeOwnerUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWConsume].[ServiceOwnerUserName]=[PT_USER2].[UserName] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWConsume].[ConsumeStateId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWConsume].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWConsume].[Payment]=[YWDictionary3].[Id] "
                                + "LEFT JOIN ("
                                + "SELECT [YWFood].[ConsumeId],COUNT(*) AS Cnt,SUM([YWProduct].[StdPrice]) AS StdPrice "
                                + "FROM [YWFood] "
                                + "JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "WHERE [YWFood].[OrgId]=@OrgId "
                                + "GROUP BY [YWFood].[ConsumeId]) SumFood ON [YWConsume].[Id]=[SumFood].[ConsumeId] "
                                + "WHERE [YWConsume].[OrgId]=@OrgId AND [YWConsume].[ConsumeStateId]<>@ConsumeStateId ";

            SqlParameter[] parameters;

            switch (strType)
            {
                case "All":
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@OrgId"                , SqlDbType.Int      , 4   ){ Value = iOrgId                                 },
                        new SqlParameter("@ConsumeStateId"       , SqlDbType.Int      , 4   ){ Value = CodeDictionary.ConsumeState["已关桌"]  }
                    };
                    break;
                case "Mine":
                    parameter.SqlString += "AND [YWConsume].[ServiceOwnerUserName]=@ServiceOwnerUserName ";   
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@OrgId"                , SqlDbType.Int      , 4   ){ Value = iOrgId                   },
                        new SqlParameter("@ConsumeStateId"       , SqlDbType.Int      , 4   ){ Value = CodeDictionary.ConsumeState["已关桌"]  },
                        new SqlParameter("@ServiceOwnerUserName" , SqlDbType.NVarChar , 50  ){ Value = strUserName  }
                    };
                    break;
                default:
                    parameters = new SqlParameter[]{};
                    break;
            }
            parameter.SqlString += "ORDER BY [YWConsume].[ConsumeTime],[YWConsume].[ConsumeTimeBlockId],[YWConsume].[ConsumeStateId]";   

            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据用户名和业务类型获取消费记录列表
        public static PageData GetConsumeListByUserNameAndType(string strUserName, string strType, int iPageSize, int iCurPage)
        {
            //获取用户所处的组织机构
            int iOrgId = YWPersonBLL.GetUserRestaurantOrgId(strUserName);

            //获取当前饭店，在当前时间所处的消费时间段Id
            int iConsumeTimeBlockId = YWDictionaryBLL.GetConsumeTimeBlockIdByDateTimeNow(iOrgId.ToString());


            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [YWConsume].[Id],[YWConsume].[ConsumeTableId],[YWTable].[Name] AS [ConsumeTableName],[YWConsume].[FromBookId],"
                                + "[YWConsume].[ConsumeTime],[YWConsume].[ConsumeTimeBlockId],[YWDictionary1].[Name] AS ConsumeTimeBlockName,"
                                + "[YWConsume].[ActualNumber],[YWConsume].[WelcomeOwnerUserName],[PT_USER1].[Nickname] AS [WelcomeOwnerNickName],"
                                + "[YWConsume].[ServiceOwnerUserName],[PT_USER2].[Nickname] AS [ServiceOwnerNickName],[YWConsume].[TotalPrice],"
                                + "[YWConsume].[PriceOff],[YWConsume].[Discount],[YWConsume].[ActualTotalPrice],[YWConsume].[ConsumeStateId],"
                                + "[YWDictionary2].[Name] AS [ConsumeStateName],[YWConsume].[OrgId],[PT_ORG].[OrgName] AS [OrgName],"
                                + "[YWConsume].[IsMember],[YWConsume].[MemberCardNo],[YWConsume].[ServiceNo],[YWConsume].[Payment] AS [PaymentId],[YWDictionary3].[Name] AS [PaymentName],"
                                + "[SumFood].[Cnt],[SumFood].[StdPrice],[SumFood].[MemberPrice],"
                                + "ISNULL([SumCoupons].[CouponsCnt],0) AS [CouponsCnt],ISNULL([SumCoupons].[CouponsAmount],0) AS [CouponsAmount] "
                                + "FROM [YWConsume] "
                                + "LEFT JOIN [YWTable] ON [YWConsume].[ConsumeTableId]=[YWTable].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary1] ON [YWConsume].[ConsumeTimeBlockId]=[YWDictionary1].[Id] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER1] ON [YWConsume].[WelcomeOwnerUserName]=[PT_USER1].[UserName] "
                                + "LEFT JOIN [PT_USER] AS [PT_USER2] ON [YWConsume].[ServiceOwnerUserName]=[PT_USER2].[UserName] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary2] ON [YWConsume].[ConsumeStateId]=[YWDictionary2].[Id] "
                                + "LEFT JOIN [PT_ORG] ON [YWConsume].[OrgId]=[PT_ORG].[Id] "
                                + "LEFT JOIN [YWDictionary] AS [YWDictionary3] ON [YWConsume].[Payment]=[YWDictionary3].[Id] "
                                + "LEFT JOIN ("
                                + "SELECT [YWFood].[ConsumeId],COUNT(*) AS Cnt,SUM([YWProduct].[StdPrice]) AS StdPrice,SUM([YWProduct].[MemberPrice]) AS MemberPrice "
                                + "FROM [YWFood] "
                                + "JOIN [YWProduct] ON [YWFood].[ProductId]=[YWProduct].[Id] "
                                + "WHERE [YWFood].[OrgId]=@OrgId "
                                + "GROUP BY [YWFood].[ConsumeId]) SumFood ON [YWConsume].[Id]=[SumFood].[ConsumeId] "
                                + "LEFT JOIN ("
                                + "SELECT [YWCoupons].[ConsumeId],SUM(Cnt) AS CouponsCnt,SUM([YWCoupons].[Amount]) AS CouponsAmount "
                                + "FROM [YWCoupons] "
                                + "GROUP BY [YWCoupons].[ConsumeId]) SumCoupons ON [YWConsume].[Id]=[SumCoupons].[ConsumeId] "
                                + "WHERE [YWConsume].[OrgId]=@OrgId AND [YWConsume].[ConsumeStateId]=@ConsumeStateId ";

            SqlParameter[] parameters;

            switch (strType)
            {
                case "WaitCheckOut":
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@OrgId"                , SqlDbType.Int      , 4   ){ Value = iOrgId                                 },
                        new SqlParameter("@ConsumeStateId"       , SqlDbType.Int      , 4   ){ Value = CodeDictionary.ConsumeState["待结账"]  }
                    };
                    break;
                case "DoneCheckOut":
                    parameter.SqlString += "AND [YWConsume].[ConsumeTimeBlockId]=@ConsumeTimeBlockId ";
                    parameters = new SqlParameter[]
                    {
                        new SqlParameter("@OrgId"                , SqlDbType.Int      , 4   ){ Value = iOrgId                                 },
                        new SqlParameter("@ConsumeStateId"       , SqlDbType.Int      , 4   ){ Value = CodeDictionary.ConsumeState["已结账"]  },
                        new SqlParameter("@ConsumeTimeBlockId"   , SqlDbType.Int      , 4   ){ Value = iConsumeTimeBlockId                    }
                    };
                    break;
                default:
                    parameters = new SqlParameter[] { };
                    break;
            }
            parameter.SqlString += "ORDER BY [YWConsume].[Id] DESC";

            parameter.Parameters = parameters;

            return CommonToolsBLL.GetPageListByParams(iPageSize, iCurPage, parameter);
        }

        //add by chr
        //根据传入参数更新消费记录，金额、折扣、状态
        public static int UpdateConsumeInfoById(int iId, double douTotalPrice, double douPriceOff, double douDiscount, double douActualTotalPrice, int iConsumeStateId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWConsume] "
                                + "SET [TotalPrice]=@TotalPrice,[PriceOff]=@PriceOff,[Discount]=@Discount,[ActualTotalPrice]=@ActualTotalPrice,[ConsumeStateId]=@ConsumeStateId "
                                + "WHERE [Id] =@Id ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@TotalPrice"           , SqlDbType.Decimal  , 9         ){ Value = douTotalPrice            },
                new SqlParameter("@PriceOff"             , SqlDbType.Decimal  , 9         ){ Value = douPriceOff              },
                new SqlParameter("@Discount"             , SqlDbType.Decimal  , 9         ){ Value = douDiscount              },
                new SqlParameter("@ActualTotalPrice"     , SqlDbType.Decimal  , 9         ){ Value = douActualTotalPrice      },
                new SqlParameter("@ConsumeStateId"       , SqlDbType.Int      , 4         ){ Value = iConsumeStateId          },
                new SqlParameter("@Id"                   , SqlDbType.Int      , 4         ){ Value = iId                      }
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.ExcuteSql(parameter);
        }

        //add by chr
        //完成结账，根据传入参数更新消费记录，金额、折扣、状态，并将消费记录中未结账的菜品更新为已结账
        public static void CompleteCheckout(int iId, double douTotalPrice, double douPriceOff, double douDiscount, double douActualTotalPrice, int iConsumeStateId)
        {
            //构建查询条件
            Parameter parameter1 = new Parameter();
            parameter1.SqlString = "UPDATE [YWConsume] "
                                 + "SET [TotalPrice]=@TotalPrice,[PriceOff]=@PriceOff,[Discount]=@Discount,[ActualTotalPrice]=@ActualTotalPrice,[ConsumeStateId]=@ConsumeStateId "
                                 + "WHERE [Id] =@Id ";
            SqlParameter[] parameters1 = 
            {
                new SqlParameter("@TotalPrice"           , SqlDbType.Decimal  , 9         ){ Value = douTotalPrice            },
                new SqlParameter("@PriceOff"             , SqlDbType.Decimal  , 9         ){ Value = douPriceOff              },
                new SqlParameter("@Discount"             , SqlDbType.Decimal  , 9         ){ Value = douDiscount              },
                new SqlParameter("@ActualTotalPrice"     , SqlDbType.Decimal  , 9         ){ Value = douActualTotalPrice      },
                new SqlParameter("@ConsumeStateId"       , SqlDbType.Int      , 4         ){ Value = iConsumeStateId          },
                new SqlParameter("@Id"                   , SqlDbType.Int      , 4         ){ Value = iId                      }
            };
            parameter1.Parameters = parameters1;

            //构建查询条件
            Parameter parameter2 = new Parameter();
            parameter2.SqlString = "UPDATE [YWFood] "
                                 + "SET [CheckStateId]=@ToCheckStateId "
                                 + "WHERE [ConsumeId] =@ConsumeId AND [CheckStateId]=@FromCheckStateId";
            SqlParameter[] parameters2 = 
            {
                new SqlParameter("@FromCheckStateId"     , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodCheckState["未结账"]          },
                new SqlParameter("@ToCheckStateId"       , SqlDbType.Int      , 4         ){ Value = CodeDictionary.FoodCheckState["已结账"]          },
                new SqlParameter("@ConsumeId"            , SqlDbType.Int      , 4         ){ Value = iId                                              }
            };
            parameter2.Parameters = parameters2;

            //构建List，并进行事务操作
            List<Parameter> parmList = new List<Parameter>();
            parmList.Add(parameter1);
            parmList.Add(parameter2);

            CommonToolsBLL.ExecuteNonQueryWithTransactionByCheckPoint(parmList, 1);
        }

        //add by chr
        //根据传入参数更新消费记录状态
        public static int UpdateConsumeStateById(int iId, int iConsumeStateId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "UPDATE [YWConsume] "
                                + "SET [ConsumeStateId]=@ConsumeStateId "
                                + "WHERE [Id] =@Id ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ConsumeStateId"       , SqlDbType.Int      , 4         ){ Value = iConsumeStateId          },
                new SqlParameter("@Id"                   , SqlDbType.Int      , 4         ){ Value = iId                      }
            };
            parameter.Parameters = parameters;

            return CommonToolsBLL.ExcuteSql(parameter);
        }


    }
}
