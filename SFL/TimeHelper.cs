using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineApp.SFL
{
    public class TimeHelper
    {
        /// <summary>
        /// 根据传入时间参数返回全格式完整时间字符串
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ConvertDateTimeToFullString(DateTime dt)
        {
            return dt.ToString("yyyy/MM/dd HH:mm:ss");
        }

        /// <summary>
        /// 根据传入时间参数返回全格式完整时间字符串（无秒）
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ConvertDateTimeToFullStringWithoutSeconds(DateTime dt)
        {
            return dt.ToString("yyyy/MM/dd HH:mm");
        }

        /// <summary>
        /// 根据传入时间参数返回日期字符串
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ConvertDateTimeToDateString(DateTime dt)
        {
            return dt.ToString("yyyy/MM/dd");
        }

        // <summary>
        /// 根据传入时间参数返回时间字符串
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ConvertDateTimeToTimeString(DateTime dt)
        {
            return dt.ToString("HH:mm:ss");
        }

        // <summary>
        /// 根据传入时间参数返回时间字符串（无秒）
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ConvertDateTimeToTimeStringWithoutSeconds(DateTime dt)
        {
            return dt.ToString("HH:mm");
        }
    }
}
