using Chr.OnlineApp.BLL;
using Chr.OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for AssignmentManage
    /// </summary>
    public class AssignmentManage : IHttpHandler
    {
        private PTUsers pTUsers = Chr.OnlineApp.Public.UITools.GetCurrentUserInfo(); // 从数据库中获取关联对象信息，以备进行修改操作。

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Request["command"] != null)
            {
                string command = context.Request["command"];
                System.Reflection.MethodInfo method = this.GetType().GetMethod(command);

                if (method != null)
                {
                    method.Invoke(this, new object[] { context });
                }
            }
            else
            {
                string strResult = "not found";
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

        //获取作业列表分页数据
        public void GetAssignmentPageData(HttpContext context)
        {
            string strPageSize = context.Request["PageSize"];
            string strCurPage = context.Request["CurPage"];
            string strcreateUserId = context.Request["createUserId"];
            string strcreateUserName = context.Request["createUserName"];
            string strstudentId = context.Request["studentId"];
            string strstudentName = context.Request["studentName"];
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["courseName"];
            string strcontent = context.Request["content"];
            string strtitle = context.Request["title"];
            string strstatus = context.Request["status"];
            string strCallBack = context.Request["callback"];
            string strResult = CommonToolsBLL.PageDataToJson(YWAssignmentBLL.GetPageData(Convert.ToInt32(strPageSize), Convert.ToInt32(strCurPage), strcreateUserId, strcreateUserName, strcourseId, strcourseName, strstudentId, strstudentName, strstatus));
            CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");
        }

        //新增作业接口 
        public void AddAssignment(HttpContext context)
        {
            string strplanId = context.Request["planId"];
            string strplanName = context.Request["planName"];
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["courseName"];
            string strcontent = context.Request["content"];
            string strtitle = context.Request["title"];
            string strlink = context.Request["link"];
            string strcreateTime = context.Request["createTime"];
            string strupdateTime = context.Request["updateTime"];
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWAssignment assignment = new YWAssignment();
            assignment.PlanId = strplanId != null ? Convert.ToInt32(strplanId) : 0;
            assignment.PlanName = strplanName != null ? strcontent : "zanwujihua";
            assignment.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : 0;
            assignment.CourseName = strcourseName != null ? strcontent : "zanwukechen";
            assignment.CreateUserName = pTUsers.Nickname;
            assignment.CreateUserId = pTUsers.Id;
            assignment.UpdateUserName = pTUsers.Nickname;
            assignment.UpdateUserId = pTUsers.Id;
            assignment.Title = strtitle != null ? strcontent : "zanwubiaoti";
            assignment.Content = strcontent != null ? strcontent : "";
            assignment.Link = strlink != null ? strcontent : "";
            assignment.CreateTime = DateTime.Now;
            assignment.UpdateTime = DateTime.Now;
            assignment.Status = strstatus != null ? Convert.ToInt32(strstatus) : 0;
            assignment.Alternate1 = strAlternate1 != null ? strAlternate1 : "";
            assignment.Alternate2 = strAlternate2 != null ? strAlternate2 : "";
            assignment.Alternate3 = strAlternate3 != null ? strAlternate3 : "";
            assignment.Alternate4 = strAlternate4 != null ? strAlternate4 : "";
            assignment.Alternate5 = strAlternate5 != null ? strAlternate5 : "";

            YWAssignmentBLL.Insert(assignment);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "作业添加成功");
        }

        //更新作业接口 
        public void ModifyAssignment(HttpContext context)
        {
            string strId = context.Request["id"];
            string strplanId = context.Request["planId"];
            string strplanName = context.Request["planName"];
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["courseName"];
            string strcontent = context.Request["content"];
            string strtitle = context.Request["title"];
            string strlink = context.Request["link"];
            string strcreateTime = context.Request["createTime"];
            string strupdateTime = context.Request["updateTime"];
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWAssignment assignment = YWAssignmentBLL.GetDataById(strId);
            assignment.PlanId = strplanId != null ? Convert.ToInt32(strplanId) : assignment.PlanId;
            assignment.PlanName = strplanName != null ? strplanName : assignment.PlanName;
            assignment.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : assignment.CourseId;
            assignment.CourseName = strcourseName != null ? strcourseName : assignment.CourseName;
            assignment.UpdateUserName = pTUsers.Nickname;
            assignment.UpdateUserId = pTUsers.Id;
            assignment.Title = strtitle != null ? strtitle : assignment.Title;
            assignment.Content = strcontent != null ? strcontent : assignment.Content;
            assignment.Link = strlink != null ? strlink : assignment.Link;
            assignment.UpdateTime = DateTime.Now;
            assignment.Status = strstatus != null ? Convert.ToInt32(strstatus) : assignment.Status;
            assignment.Alternate1 = strAlternate1 != null ? strAlternate1 : assignment.Alternate1;
            assignment.Alternate2 = strAlternate2 != null ? strAlternate2 : assignment.Alternate2;
            assignment.Alternate3 = strAlternate3 != null ? strAlternate3 : assignment.Alternate3;
            assignment.Alternate4 = strAlternate4 != null ? strAlternate4 : assignment.Alternate4;
            assignment.Alternate5 = strAlternate5 != null ? strAlternate5 : assignment.Alternate5;

            YWAssignmentBLL.Update(assignment);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "作业更新成功");
        }

        //删除指定的作业
        public void DeleteAssignment(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');

            foreach (string item in strList)
            {
                YWAssignmentBLL.Delete(Convert.ToInt32(item));
            }
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "所选作业删除成功");

        }
    }
}