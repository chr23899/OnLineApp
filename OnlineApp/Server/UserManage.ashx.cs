using OnlineApp.BLL;
using OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for UserManage1
    /// </summary>
    public class UserManage1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Request["command"] != null)
            {
                string command = context.Request["command"];
                System.Reflection.MethodInfo method = this.GetType().GetMethod(command);

                if (method!=null)
                {
                    method.Invoke(this, new object[] { context });
                }
            }
            else
            {
                List<String> l_output = new List<string>();
                for (int i = 0; i < 10; i++)
                {
                    l_output.Add("str" + i + 1);
                }
                string strResult = CommonToolsBLL.ListToJson(l_output);
                CommonToolsBLL.OutputJson(context, "", "the interface is not find inn the system", "fail", strResult);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        //获取用户基本信息，验证失败返回error（参数：用户名）
        public void GetUserDataByUserName(HttpContext context)
        {
            string strUserName = context.Request["UserName"];
            string strCallBack = context.Request["callback"];

            PTUsers pTUser = PTUsersBLL.GetDataByUserName(strUserName);
            if (pTUser != null)
            {
                string strResult = CommonToolsBLL.ObjectToJson(pTUser);
                CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");
            }
            else
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "error", "用户信息不存在");
            }
        }

        //获取用户列表分页数据
        public void GetUserPageData(HttpContext context)
        {
            string strPageSize = context.Request["PageSize"];
            string strCurPage = context.Request["CurPage"];
            string strNickname = context.Request["Nickname"];
            string strOrgName = context.Request["OrgName"];
            string strRoleId = context.Request["RoleId"];
            string strMobile = context.Request["Mobile"];
            string strCallBack = context.Request["callback"];

            string strResult = CommonToolsBLL.PageDataToJson(PTUsersBLL.GetPageData(Convert.ToInt32(strPageSize), Convert.ToInt32(strCurPage), strNickname, strOrgName, strRoleId, strMobile));
            CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");
        }
    }
}