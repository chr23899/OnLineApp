using OnlineApp.BLL;
using OnlineApp.COL;
using OnlineApp.SFL;
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

        //新增用户接口
        public void AddUser(HttpContext context)
        {
            string strUserName = context.Request["UserName"];
            string strPassword = context.Request["Password"];
            string strNickname = context.Request["Nickname"];
            string strOrgId = context.Request["OrgId"];
            string strStateId = context.Request["StateId"];
            string strAlternate1 = context.Request["Alternate1"];
            string strCallBack = context.Request["callback"];

            PTUsers pTUser = new PTUsers();
            pTUser.UserName = strUserName;
            pTUser.Password = strPassword;
            pTUser.Nickname = strNickname;
            pTUser.OrgId = Convert.ToInt32(strOrgId);

            string tempStateId = "1";
            if (strStateId == "false")
            {
                tempStateId = "0";
            }
            pTUser.StateId = tempStateId;
            pTUser.Alternate1 = strAlternate1;

            PTUserLink userLink = new PTUserLink();
            userLink.UserName = strUserName;
            userLink.RoleId = CodeDictionary.UserRole["一般用户（初始默认）"];
            PTUsersBLL.Insert(pTUser);
            PTUserLinkBLL.Insert(userLink);

            YWUserTips ywUserTips = new YWUserTips();
            ywUserTips.UserName = strUserName;
            YWUserTipsBLL.Insert(ywUserTips);

            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "新用户添加成功");
        }

        //更新用户
        public void ModifyUser(HttpContext context)
        {
            string strUserName = context.Request["UserName"];
            string strPassword = context.Request["Password"];
            string strNickname = context.Request["Nickname"];
            string strOrgId = context.Request["OrgId"];
            string strStateId = context.Request["StateId"];
            string strAlternate1 = context.Request["Alternate1"];
            string strCallBack = context.Request["callback"];

            PTUsers pTUser = new PTUsers();
            pTUser.UserName = strUserName;
            pTUser.Password = strPassword;
            pTUser.Nickname = strNickname;
            pTUser.OrgId = Convert.ToInt32(strOrgId);

            string tempStateId = "1";
            if (strStateId == "false")
            {
                tempStateId = "0";
            }
            pTUser.StateId = tempStateId;
            pTUser.Alternate1 = strAlternate1;

            PTUsersBLL.Update(pTUser);

            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "用户信息更新成功");
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="context"></param>
        public void DeleteUser(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');
            foreach (string item in strList)
            {
                PTUsersBLL.DeleteUser(item);
            }


            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "所选用户删除成功");
        }

        /// <summary>
        /// 授权用户角色
        /// </summary>
        /// <param name="context"></param>
        public void AddUserRole(HttpContext context)
        {
            string strRoleId = context.Request["RoleId"];
            string strUserName = context.Request["UserName"];
            string strCallBack = context.Request["callback"];

            PTUserLink userLink = new PTUserLink();
            userLink.UserName = strUserName;
            userLink.RoleId = Convert.ToInt32(strRoleId);
            PTUserLinkBLL.Insert(userLink);

            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "授权用户权限成功");
        }

        /// <summary>
        /// 授权用户角色
        /// </summary>
        /// <param name="context"></param>
        public void DeleteUserRole(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');
            foreach (string item in strList)
            {
                PTUserLinkBLL.Delete(Convert.ToInt32(item));
            }

            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "撤销用户权限成功");
        }

        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        /// <param name="context"></param>
        public void IsExistUserName(HttpContext context)
        {
            string strUserName = context.Request["UserName"];
            string strCallBack = context.Request["callback"];

            if (PTUsersBLL.GetDataByUserName(strUserName) != null)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "该用户名已经存在!");
            }
            else
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "fail", "该用户名可以使用!");
            }
        }

        /// <summary>
        /// 检查手机号是否存在
        /// </summary>
        /// <param name="context"></param>
        public void IsExistTel(HttpContext context)
        {
            string strTel = context.Request["Tel"];
            string strCallBack = context.Request["callback"];

            if (PTUsersBLL.GetUserByTel(strTel).Rows.Count > 0)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "该手机号已经存在!");
            }
            else
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "fail", "该手机号可以使用!");
            }
        }
    }
}