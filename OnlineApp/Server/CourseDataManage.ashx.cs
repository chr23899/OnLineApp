using Chr.OnlineApp.BLL;
using Chr.OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for CourseDataManage
    /// </summary>
    public class CourseDataManage : IHttpHandler
    {

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

        //获取课程资料列表分页数据
        public void GetCourseDataPageData(HttpContext context)
        {
            string strPageSize = context.Request["PageSize"];
            string strCurPage = context.Request["CurPage"];
            string strcreateUserId = context.Request["createUserId"];
            string strcreateUserName = context.Request["createUserName"];
            string strupdateUserId = context.Request["updateUserId"];
            string strupdateUserName = context.Request["updateUserName"];
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["courseName"]; 
            string strstatus = context.Request["status"];
            string strCallBack = context.Request["callback"];

            try
            {
                string strResult = CommonToolsBLL.PageDataToJson(YWCourseDataBLL.GetPageData(Convert.ToInt32(strPageSize), Convert.ToInt32(strCurPage), strcreateUserId, strcreateUserName, strcourseId, strcourseName, strupdateUserId, strupdateUserName, strstatus));
                CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "获取数据失败" + e.ToString());
            }
        }

        //新增课程资料接口 
        public void AddCourseData(HttpContext context)
        {
            string strplanId = context.Request["planId"];
            string strplanName = context.Request["planName"];
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["courseName"];
            string strcreateUserName = context.Request["createUserName"];
            string strcreateUserId = context.Request["createUserId"];
            string strupdateUserName = context.Request["updateUserName"];
            string strupdateUserId = context.Request["updateUserId"];
            string strcontent = context.Request["content"]; 
            string strtitle = context.Request["title"];
            string strlink = context.Request["link"];
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWCourseData courseData = new YWCourseData();
            courseData.PlanId = strplanId != null ? Convert.ToInt32(strplanId) : 0;
            courseData.PlanName = strplanName != null ? strplanName : "";
            courseData.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : 0;
            courseData.CourseName = strcourseName != null ? strcourseName : "";
            courseData.CreateUserName = strcreateUserName != null ? strcreateUserName : "";
            courseData.CreateUserId = strcreateUserId != null ? Convert.ToInt32(strcreateUserId) : 0;
            courseData.UpdateUserName = strupdateUserName != null ? strupdateUserName : "";
            courseData.UpdateUserId = strupdateUserId != null ? Convert.ToInt32(strupdateUserId) : 0;
            courseData.Content = strcontent != null ? strcontent : "";
            courseData.Title = strtitle != null ? strtitle : "";
            courseData.Link = strlink != null ? strlink : ""; 
            courseData.CreateTime = DateTime.Now;
            courseData.UpdateTime = DateTime.Now;
            courseData.Status = strstatus != null ? Convert.ToInt32(strstatus) : 0;
            courseData.Alternate1 = strAlternate1 != null ? strAlternate1 : "";
            courseData.Alternate2 = strAlternate2 != null ? strAlternate2 : "";
            courseData.Alternate3 = strAlternate3 != null ? strAlternate3 : "";
            courseData.Alternate4 = strAlternate4 != null ? strAlternate4 : "";
            courseData.Alternate5 = strAlternate5 != null ? strAlternate5 : "";

            try
            {
                YWCourseDataBLL.Insert(courseData);
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "课程资料添加成功");

            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "课程添加失败" + e.ToString());
            }
        }

        //更新课程资料接口 
        public void ModifyCourseData(HttpContext context)
        {
            string strId = context.Request["id"];
            string strplanId = context.Request["planId"];
            string strplanName = context.Request["planName"];
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["courseName"];
            string strcreateUserName = context.Request["createUserName"];
            string strcreateUserId = context.Request["createUserId"];
            string strupdateUserName = context.Request["updateUserName"];
            string strupdateUserId = context.Request["updateUserId"];
            string strcontent = context.Request["content"];
            string strsupport = context.Request["support"];
            string stroppose = context.Request["oppose"]; 
            string strtitle = context.Request["title"];
            string strlink = context.Request["link"];
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWCourseData courseData = YWCourseDataBLL.GetDataById(strId);
            courseData.PlanId = strplanId != null ? Convert.ToInt32(strplanId) : courseData.PlanId;
            courseData.PlanName = strplanName != null ? strplanName : courseData.PlanName;
            courseData.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : courseData.CourseId;
            courseData.CourseName = strcourseName != null ? strcourseName : courseData.CourseName;
            courseData.CreateUserName = strcreateUserName != null ? strcreateUserName : courseData.CreateUserName;
            courseData.CreateUserId = strcreateUserId != null ? Convert.ToInt32(strcreateUserId) : courseData.CreateUserId;
            courseData.UpdateUserName = strupdateUserName != null ? strupdateUserName : courseData.UpdateUserName;
            courseData.UpdateUserId = strupdateUserId != null ? Convert.ToInt32(strupdateUserId) : courseData.UpdateUserId;
            courseData.Content = strcontent != null ? strcontent : courseData.Content;
            courseData.Title = strtitle != null ? strtitle : courseData.Title;
            courseData.Link = strlink != null ? strlink : courseData.Link;
            courseData.UpdateTime = DateTime.Now;
            courseData.Status = strstatus != null ? Convert.ToInt32(strstatus) : courseData.Status;
            courseData.Alternate1 = strAlternate1 != null ? strAlternate1 : courseData.Alternate1;
            courseData.Alternate2 = strAlternate2 != null ? strAlternate2 : courseData.Alternate2;
            courseData.Alternate3 = strAlternate3 != null ? strAlternate3 : courseData.Alternate3;
            courseData.Alternate4 = strAlternate4 != null ? strAlternate4 : courseData.Alternate4;
            courseData.Alternate5 = strAlternate5 != null ? strAlternate5 : courseData.Alternate5;

            try
            {
                YWCourseDataBLL.Update(courseData);
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "课程资料更新成功");

            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "课程资料更新失败" + e.ToString());
            }
        }

        //删除指定的课程资料
        public void DeleteCourseData(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');

            try
            {
                foreach (string item in strList)
                {
                    YWCourseDataBLL.Delete(Convert.ToInt32(item));
                }
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "所选课程资料删除成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "所选课程资料删除失败" + e.ToString());
            }
        }
    }
}