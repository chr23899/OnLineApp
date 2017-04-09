using System;
using System.Text;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using OnlineApp.COL;
using OnlineApp.DAL;
using OnlineApp.SFL;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
//using System.ServiceModel;
//using System.ServiceModel.Web;
//using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text.RegularExpressions;

namespace OnlineApp.BLL
{
    public class CommonToolsBLL
    {
        /// <summary>
        /// 返回与本类相关联的数据访问类。通常本类需要访问自身关联的数据访问类，与数据库进行交互时，应优先使用该属性，
        /// 本类调用业务逻辑层其它业务逻辑类时，应当优先使用其它类中公开的方法，而不优先使用其它类中的DataAccess属性。
        /// </summary>
        internal static DAL.Common.CommonToolsDAL DataAccess
        {
            get
            {
                return DAL.Common.CommonToolsDAL.Instance;
            }
        }

        /// <summary>
        /// 通用sql查询，返回datatable数据集
        /// </summary>
        public static DataTable GetAllListByParams(Parameter paramList)
        {
            return DataAccess.GetAllListByParams(paramList);
        }

        /// <summary>
        /// 通用sql查询，返回PageData数据集
        /// </summary>
        public static PageData GetPageListByParams(int pageSize, int curPage, Parameter paramList)
        {
            return DataAccess.GetPageListByParams(pageSize, curPage, paramList);
        }


        /// <summary>
        /// 通用sql查询，返回PageData数据集，添加越界处理
        /// </summary>
        public static PageData GetPageListByParamsOutBound(int pageSize, int curPage, Parameter paramList)
        {
            return DataAccess.GetPageListByParamsOutBound(pageSize, curPage, paramList);
        }

        /// <summary>
        /// 通用sql查询，返回受影响的行数。
        /// </summary>
        public static int ExcuteSql(Parameter paramList)
        {
            return DataAccess.ExcuteSql(paramList);
        }

        /// <summary>
        /// add by zy
        /// 通用sql查询，返回受影响的行数(使用事务方式处理)。
        /// </summary>
        public static void ExcuteSqlWithTransaction(List<Parameter> paramList)
        {
            DataAccess.ExcuteSqlWithTransaction(paramList);
        }

        /// <summary>
        /// add by zy
        /// 通过事务方式执行多个SQL语句，不返回任何对象（其中第一条SQL执行结果与传入参数对比判断，结果为真才继续执行，否则回滚）。
        /// </summary>
        /// <param name="paramList">多个sql对象</param>
        /// <param name="iCheckPoint">检查点</param>
        public static void ExecuteNonQueryWithTransactionByCheckPoint(List<Parameter> paramList, int iCheckPoint)
        {
            DataAccess.ExecuteNonQueryWithTransactionByCheckPoint(paramList, iCheckPoint);
        }

        /// <summary>
        /// add by zy
        /// 通用sql查询，返回查询结果的第一行第一列对象。
        /// </summary>
        public static object ExcuteSqlReturnSingleObject(Parameter paramList)
        {
            return DataAccess.ExcuteSqlReturnSingleObject(paramList);
        }

        /// <summary>
        /// 公共方法：list转化为json
        /// </summary>
        public static string ListToJson(IList objList)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //JSON序列化
            return serializer.Serialize(objList);
        }
        /// <summary>
        /// 公共方法：json转化为list
        /// </summary>
        public static List<Object> JsonToList(string strJson)
        {
            if (strJson == null || strJson == "")
            {
                return new List<Object>();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<List<Object>>(strJson);
        }
        /// <summary>
        /// 公共方法：object转化为json
        /// </summary>
        public static string ObjectToJson(Object objList)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //JSON序列化
            return serializer.Serialize(objList);
        }
        /// <summary>
        /// 公共方法：json转化为object
        /// </summary>
        public static Object JsonToObject(string strJson)
        {
            if (strJson == null || strJson == "")
            {
                return new List<Object>();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<Object>(strJson);
        }
        /// 将json字符串转化为方法实体类  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="jsonString"></param>  
        /// <returns></returns>  
        public static T JsonToObject<T>(string strJson)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(strJson));
            T jsonObject = (T)serializer.ReadObject(ms);
            ms.Close();
            return jsonObject;
        }  
        /// <summary>
        /// 公共方法：dictionary转化为json
        /// </summary>
        public static string DictionaryToJson(Dictionary<string, int> dic)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //JSON序列化
            return serializer.Serialize(dic);
        }
        /// <summary>
        /// 公共方法：json转化为dictionary
        /// </summary>
        public static Dictionary<string, int> JsonToDictionary(string strJson)
        {
            if (strJson == null || strJson == "")
            {
                return new Dictionary<string, int>();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<Dictionary<string, int>>(strJson);
        }

        /// <summary>
        /// 公共方法：datatable转化为json
        /// </summary>
        public static string DataTableToJson(DataTable dt)
        {

            string strResult = "[";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (i > 0)
                {
                    strResult += ",";
                }
                strResult += "{";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (j > 0)
                    {
                        strResult += ",";
                    }
                    strResult += "\"" + dt.Columns[j].ColumnName + "\":";
                    if (dt.Columns[j].DataType.IsValueType)
                    {
                        string temp =  dt.Rows[i][j].ToString() ;
                        if (dt.Columns[j].DataType == typeof(Boolean))
                        {
                            //这里处理一下bool型的首字母大写问题
                            
                            if (temp == "True")
                            {
                                temp = "true";
                            }
                            if (temp == "False")
                            {
                                temp = "false";
                            }
                            
                        }
                        if (dt.Columns[j].DataType == typeof(DateTime))
                        {
                            //这里处理一下日期格式的字段为字符串
                            temp = "\"" + dt.Rows[i][j].ToString() + "\""; ;
                        }
                        if (temp == "")
                        {
                            //这里处理一下空值转为空字符串的话，变为null
                            temp = "null";
                        }
                        strResult += temp;
                    }
                    else
                    {
                        strResult += "\"" + StringFormat(dt.Rows[i][j].ToString()) + "\"";
                    }
                }
                strResult += "}";
            }
            strResult += "]";
            return strResult;
        }

        /// <summary>
        /// add by chr
        /// 公共方法：特殊字符处理 
        /// </summary>
        /// <param name="oldstr"></param>
        /// <returns></returns>
        public static string StringFormat(string oldstr)
        {
            oldstr = oldstr.Replace("\\", "\\\\");
            oldstr = oldstr.Replace("/", "\\/");
            oldstr = oldstr.Replace("\b", "\\b");
            oldstr = oldstr.Replace("\t", "\\t");
            oldstr = oldstr.Replace("\n", "\\n");
            oldstr = oldstr.Replace("\f", "\\f");
            oldstr = oldstr.Replace("\r", "\\r");
            oldstr = oldstr.Replace("\"", "\\\""); 
            return oldstr;
        }

        /// <summary>
        /// 公共方法：datarow转化为json
        /// </summary>
        public static string DataRowToJson(DataRow dr)
        {


            string strResult = "{";
            for (int j = 0; j < dr.Table.Columns.Count; j++)
            {
                if (j > 0)
                {
                    strResult += ",";
                }
                strResult += "\"" + dr.Table.Columns[j].ColumnName + "\":";
                if (dr.Table.Columns[j].DataType.IsValueType)
                {
                    string temp =  dr[j].ToString() ;
                    if (dr.Table.Columns[j].DataType == typeof(Boolean))
                    {
                        //这里处理一下bool型的首字母大写问题

                        if (temp == "True")
                        {
                            temp = "true";
                        }
                        if (temp == "False")
                        {
                            temp = "false";
                        }

                    }
                    if (dr.Table.Columns[j].DataType == typeof(DateTime))
                    {
                        //这里处理一下日期格式的字段为字符串
                        temp = "\"" + dr[j].ToString() + "\""; ;
                    }
                    if (temp == "")
                    {
                        //这里处理一下空值转为空字符串的话，变为null
                        temp = "null";
                    }
                    strResult += temp;
                }
                else
                {
                    strResult += "\"" + StringFormat(dr[j].ToString()) + "\"";
                }
            }
            strResult += "}";

            return strResult;
        }

        /// <summary>
        /// 公共方法：pageData转化为json
        /// </summary>
        public static string PageDataToJson(PageData pageData)
        {


            string strResult = "{";
            strResult += @"""PageList"":" + DataTableToJson(pageData.PageList) + @",";
            strResult += @"""PageSize"":" + pageData.PageSize + @",";
            strResult += @"""CurPage"":" + pageData.CurPage + @",";
            strResult += @"""PageCount"":" + pageData.PageCount + @",";
            strResult += @"""RecordCount"":" + pageData.RecordCount + @",";
            strResult += @"""PrevPage"":" + pageData.PrevPage + @",";
            strResult += @"""NextPage"":" + pageData.NextPage;

            strResult += "}";

            return strResult;
        }

        /// <summary>
        /// 公共方法：根据callback处理接口返回值（JsonP/Json）
        /// </summary>
        public static void OutputJson(HttpContext context, string strCallBack, string strJson, string strType, string strMsg)
        {
            strJson = "{\"result\":" + strJson + ", \"type\":\"" + strType + "\", \"message\":\"" + strMsg + "\"}";
            if (strCallBack != null && strCallBack != "")
            {
                context.Response.ContentType = "application/x-javascript";
                context.Response.Write(strCallBack + "(" + strJson + ");");
            }
            else
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write(strJson);
            }
            context.Response.End();

        }

        /// <summary>
        /// 公共方法，合并两个结构相同的DataTable
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        public static DataTable MergeDataTable(DataTable dt1, DataTable dt2)
        {
            DataTable dt = new DataTable();
            dt = dt1.Clone();
            dt.Rows.Clear();
            object[] obj = new object[dt.Columns.Count];

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dt1.Rows[i].ItemArray.CopyTo(obj, 0);
                dt.Rows.Add(obj);
            }
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                dt2.Rows[i].ItemArray.CopyTo(obj, 0);
                dt.Rows.Add(obj);
            }

            return dt;
        }
    }
}
