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
    /// 对象名称：用户提示业务逻辑类（业务逻辑层）
    /// 对象说明：记录系统发给用户的提示信息。
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2016-1-25 16:42:49
    /// </summary>
    public class YWUserTipsBLL
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
        internal static DAL.Common.YWUserTipsDAL DataAccess
        {
            get
            {
                return DAL.Common.YWUserTipsDAL.Instance;
            }
        }


        /// <summary>
        /// 对用户提示（YWUserTips）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="yWUserTips">用户提示（YWUserTips）实例对象</param>
        public static void CheckValid(YWUserTips yWUserTips)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(yWUserTips.UserName))
                throw new CustomException("“用户名”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(yWUserTips.UserName , 50))
                throw new CustomException("“用户名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将用户提示（YWUserTips）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWUserTips">用户提示（YWUserTips）实例对象</param>
        public static int Insert(YWUserTips yWUserTips)
        {
            CheckValid(yWUserTips);
            return DataAccess.Insert(yWUserTips);
        }


        /// <summary>
        /// 将用户提示（YWUserTips）数据，根据主键“用户名（UserName）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWUserTips">用户提示（YWUserTips）实例对象</param>
        public static int Update(YWUserTips yWUserTips)
        {
            CheckValid(yWUserTips);
            return DataAccess.Update(yWUserTips);
        }


        /// <summary>
        /// 根据用户提示（YWUserTips）的主键“用户名（UserName）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="userName">用户提示（YWUserTips）的主键“用户名（UserName）”</param>
        public static int Delete(string userName)
        {
            return DataAccess.Delete(userName);
        }


        /// <summary>
        /// 根据用户提示（YWUserTips）的主键“用户名（UserName）”从数据库中获取用户提示（YWUserTips）的实例。
        /// 成功从数据库中取得记录返回新用户提示（YWUserTips）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="userName">用户提示（YWUserTips）的主键“用户名（UserName）”</param>
        public static YWUserTips GetDataByUserName(string userName)
        {
            return DataAccess.GetDataByUserName(userName);
        }


        /// <summary>
        /// 从数据库中读取并返回所有用户提示（YWUserTips）List列表。
        /// </summary>
        public static List<YWUserTips> GetAllList()
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
        /// 根据用户名数组和用户提示类型字典，生成update语句并执行
        /// </summary>
        /// <param name="strUserList"></param>
        /// <param name="dicUserTips"></param>
        /// <returns></returns>
        public static int UpdateByUserListAndTipsList(string[] strUserList, Dictionary<string,int> dicUserTips)
        {
            Parameter parameter = new Parameter();
            List<SqlParameter> parameterList = new List<SqlParameter>();

            //拼装update段
            parameter.SqlString = "UPDATE [YWUserTips] SET ";

            //拼装set段
            int ifirst = 0;
            foreach (KeyValuePair<string, int> item in dicUserTips)
            {
                if (ifirst == 0)
                    parameter.SqlString += "[" + item.Key + "] = @" + item.Key;
                else
                    parameter.SqlString += ", [" + item.Key + "] = @" + item.Key;

                parameterList.Add(new SqlParameter("@" + item.Key, SqlDbType.Int, 50) { Value = item.Value });
                ifirst++;
            }

            //拼装where段
            parameter.SqlString += " WHERE [UserName] IN (";
            for (int i = 0; i < strUserList.Length; i++)
            {
                if (i == 0)
                {
                    parameter.SqlString += "@UserName" + (i + 1).ToString();
                }
                else
                {
                    parameter.SqlString += ", @UserName" + (i + 1).ToString();
                }
                parameterList.Add(new SqlParameter("@UserName" + (i + 1).ToString(), SqlDbType.NVarChar, 50) { Value = strUserList[i] });
            }

            parameter.SqlString += ")";
          
            SqlParameter[] parameters = parameterList.ToArray();
            parameter.Parameters = parameters;

            return CommonToolsBLL.ExcuteSql(parameter);
        }

        /// <summary>
        /// add by chr
        /// 根据用户名获取提示信息
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public static DataTable GetTipsByUserName(string strUserName)
        {
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT [Tips1], [Tips2], [Tips3], [Tips4], [Tips5], [Tips6], [Tips7], [Tips8], [Tips9], [Tips10], [Tips11], [Tips12], [Tips13], [Tips14], [Tips15], [Tips16], [Tips17], [Tips18], [Tips19], [Tips20] ";
            parameter.SqlString += "FROM [YWUserTips] WHERE [UserName] = @UserName ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NChar , 50 ){ Value = strUserName},
            };
            parameter.Parameters = parameters;
            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter);
            if (dt.Rows.Count != 1)
            {
                throw new CustomException("提示信息表中同一个用户存在多条记录。");
            }
            else
            {
                return dt;
            }


            //Dictionary<string, int> myDic = new Dictionary<string,int>();
            //foreach (KeyValuePair<string, int> kvp in UserTipsDictionary.UserTipsType)
            //{
            //    switch (kvp.Value)
            //    {
            //        case 1:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips1"]));
            //            break;
            //        case 2:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips2"]));
            //            break;
            //        case 3:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips3"]));
            //            break;
            //        case 4:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips4"]));
            //            break;
            //        case 5:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips5"]));
            //            break;
            //        case 6:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips6"]));
            //            break;
            //        case 7:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips7"]));
            //            break;
            //        case 8:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips8"]));
            //            break;
            //        case 9:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips9"]));
            //            break;
            //        case 10:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips10"]));
            //            break;
            //        case 11:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips11"]));
            //            break;
            //        case 12:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips12"]));
            //            break;
            //        case 13:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips13"]));
            //            break;
            //        case 14:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips14"]));
            //            break;
            //        case 15:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips15"]));
            //            break;
            //        case 16:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips16"]));
            //            break;
            //        case 17:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips17"]));
            //            break;
            //        case 18:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips18"]));
            //            break;
            //        case 19:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips19"]));
            //            break;
            //        case 20:
            //            myDic.Add(kvp.Key, Convert.ToInt32(dt.Rows[0]["Tips20"]));
            //            break;
            //    }
            //}

            //return myDic;
        }


    }
}
