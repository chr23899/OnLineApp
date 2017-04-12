using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.Data;

namespace Chr.OnlineApp.Public
{
    /// <summary>  
    /// JSON帮助类。用于将对象转换为Json格式的字符串，或者将Json的字符串转化为对象。  
    /// </summary>  
    public static class JsonHelper
    {
        /// <summary>  
        /// 将对象转化为Json字符串   
        /// </summary>  
        /// <typeparam name="T">源类型</typeparam>  
        /// <param name="obj">源类型实例</param>  
        /// <returns>Json字符串</returns>  
        public static string GetJsonFromObj<T>(T obj)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(obj.GetType());
            using (MemoryStream ms = new MemoryStream())
            {
                jsonSerializer.WriteObject(ms, obj);
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        /// <summary>  
        /// 将Json字符串转化为对象  
        /// </summary>  
        /// <typeparam name="T">目标类型</typeparam>  
        /// <param name="strJson">Json字符串</param>  
        /// <returns>目标类型的一个实例</returns>  
        public static T GetObjFromJson<T>(string strJson)
        {
            T obj = Activator.CreateInstance<T>();
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(strJson)))
            {
                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(obj.GetType());
                return (T)jsonSerializer.ReadObject(ms);
            }
        }

        /// <summary>  
        /// 将DataTable转换为JSON字符串  
        /// </summary>  
        /// <param name="dt">数据表</param>  
        /// <returns>JSON字符串</returns>  
        public static string GetJsonFromDataTable(DataTable dt)
        {
            StringBuilder JsonString = new StringBuilder();
            if (dt != null && dt.Rows.Count > 0)
            {
                JsonString.Append("{ ");
                JsonString.Append("\"TableInfo\":[ ");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    JsonString.Append("{ ");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j < dt.Columns.Count - 1)
                        {
                            JsonString.Append("\"" + dt.Columns[j].ColumnName.ToString() + "\":" + "\"" + dt.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == dt.Columns.Count - 1)
                        {
                            JsonString.Append("\"" + dt.Columns[j].ColumnName.ToString() + "\":" + "\"" + dt.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == dt.Rows.Count - 1)
                    {
                        JsonString.Append("} ");
                    }
                    else
                    {
                        JsonString.Append("}, ");
                    }
                }
                JsonString.Append("]}");
                return JsonString.ToString();
            }
            else
            {
                return null;
            }
        }

        /// <summary>   
        /// 将对象转化为Json字符串   
        /// </summary>   
        /// <param name="obj">源对象</param>   
        /// <returns>json数据</returns>   
        public static string ObjToJson(this object obj)
        {
            JavaScriptSerializer serialize = new JavaScriptSerializer();
            return serialize.Serialize(obj);
        }

        /// <summary>   
        /// 将Json字符串转化为对象  
        /// </summary>   
        /// <param name="strJson">Json字符串</param>   
        /// <returns>目标对象</returns>  
        public static T JsonToObj<T>(string strJson)
        {
            JavaScriptSerializer serialize = new JavaScriptSerializer();
            return serialize.Deserialize<T>(strJson);
        }

        /// <summary>   
        /// 将对象转化为Json字符串(控制深度 )  
        /// </summary>   
        /// <param name="obj">源对象</param>   
        /// <param name="recursionDepth">深度</param>   
        /// <returns>json数据</returns>   
        public static string ObjToJson(this object obj, int recursionDepth)
        {
            JavaScriptSerializer serialize = new JavaScriptSerializer();
            serialize.RecursionLimit = recursionDepth;
            return serialize.Serialize(obj);
        }

        /// <summary>   
        /// 将Json字符串转化为对象(控制深度 )  
        /// </summary>   
        /// <param name="strJson">Json字符串</param>   
        /// <param name="recursionDepth">深度</param>   
        /// <returns>目标对象</returns>  
        public static T JsonToObj<T>(string strJson, int recursionDepth)
        {
            JavaScriptSerializer serialize = new JavaScriptSerializer();
            serialize.RecursionLimit = recursionDepth;
            return serialize.Deserialize<T>(strJson);
        }

        /// <summary>   
        /// 将DataTable转换为JSON字符串  
        /// </summary>   
        /// <param name="dt">DataTable</param>   
        /// <returns>json数据</returns>   
        public static string DataTableToJson(DataTable dt)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();

            int index = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, object> result = new Dictionary<string, object>();

                foreach (DataColumn dc in dt.Columns)
                {
                    result.Add(dc.ColumnName, dr[dc].ToString());
                }
                dic.Add(index.ToString(), result);
                index++;
            }
            return ObjToJson(dic);
        }
    }  
}