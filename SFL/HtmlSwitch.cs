using System;
using System.Web;
using System.Web.UI;
using System.Collections.Generic;
using System.Text;

namespace Chr.OnlineApp.SFL
{
    public class HtmlSwitch
    {
        public static string HtmlEncode(string htmlStr)
        {
            if (string.IsNullOrEmpty(htmlStr)) 
                return "";

            htmlStr = HttpContext.Current.Server.HtmlEncode(htmlStr);
            htmlStr = htmlStr.Replace("  ", "&nbsp;&nbsp;");
            htmlStr = htmlStr.Replace("\n", "<br>");
            return htmlStr;
        }
    }
}

