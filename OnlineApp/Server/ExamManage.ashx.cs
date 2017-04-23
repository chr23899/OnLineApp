using Chr.OnlineApp.BLL;
using Chr.OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for ExamManage
    /// </summary>
    public class ExamManage : IHttpHandler
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

        //获取考试列表分页数据
        public void GetExamPageData(HttpContext context)
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

            string strResult = CommonToolsBLL.PageDataToJson(YWExamBLL.GetPageData(Convert.ToInt32(strPageSize), Convert.ToInt32(strCurPage), strcreateUserId, strcreateUserName, strcourseId, strcourseName, strstudentId, strstudentName, strstatus));
            CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");

        }

        //新增考试接口 
        public void AddExam(HttpContext context)
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

            YWExam exam = new YWExam();
            exam.PlanId = strplanId != null ? Convert.ToInt32(strplanId) : 0;
            exam.PlanName = strplanName != null ? strcontent : "";
            exam.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : 0;
            exam.CourseName = strcourseName != null ? strcontent : "";
            exam.CreateUserName = pTUsers.Nickname;
            exam.CreateUserId = pTUsers.Id;
            exam.UpdateUserName = pTUsers.Nickname;
            exam.UpdateUserId = pTUsers.Id;
            exam.Title = strtitle != null ? strcontent : "";
            exam.Content = strcontent != null ? strcontent : "";
            exam.Link = strlink != null ? strcontent : "";
            exam.CreateTime = DateTime.Now;
            exam.UpdateTime = DateTime.Now;
            exam.Status = strstatus != null ? Convert.ToInt32(strstatus) : 0;
            exam.Alternate1 = strAlternate1 != null ? strAlternate1 : "";
            exam.Alternate2 = strAlternate2 != null ? strAlternate2 : "";
            exam.Alternate3 = strAlternate3 != null ? strAlternate3 : "";
            exam.Alternate4 = strAlternate4 != null ? strAlternate4 : "";
            exam.Alternate5 = strAlternate5 != null ? strAlternate5 : "";

            YWExamBLL.Insert(exam);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "考试添加成功");
        }

        //更新考试接口 
        public void ModifyExam(HttpContext context)
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

            YWExam exam = YWExamBLL.GetDataById(strId);
            exam.PlanId = strplanId != null ? Convert.ToInt32(strplanId) : exam.PlanId;
            exam.PlanName = strplanName != null ? strplanName : exam.PlanName;
            exam.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : exam.CourseId;
            exam.CourseName = strcourseName != null ? strcourseName : exam.CourseName;
            exam.UpdateUserName = pTUsers.Nickname;
            exam.UpdateUserId = pTUsers.Id;
            exam.Title = strtitle != null ? strtitle : exam.Title;
            exam.Content = strcontent != null ? strcontent : exam.Content;
            exam.Link = strlink != null ? strlink : exam.Link;
            exam.UpdateTime = DateTime.Now;
            exam.Status = strstatus != null ? Convert.ToInt32(strstatus) : exam.Status;
            exam.Alternate1 = strAlternate1 != null ? strAlternate1 : exam.Alternate1;
            exam.Alternate2 = strAlternate2 != null ? strAlternate2 : exam.Alternate2;
            exam.Alternate3 = strAlternate3 != null ? strAlternate3 : exam.Alternate3;
            exam.Alternate4 = strAlternate4 != null ? strAlternate4 : exam.Alternate4;
            exam.Alternate5 = strAlternate5 != null ? strAlternate5 : exam.Alternate5;

            YWExamBLL.Update(exam);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "考试更新成功");
        }

        //删除指定的考试
        public void DeleteExam(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');

            foreach (string item in strList)
            {
                YWExamBLL.Delete(Convert.ToInt32(item));
            }
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "所选考试删除成功");
        }
    }
}