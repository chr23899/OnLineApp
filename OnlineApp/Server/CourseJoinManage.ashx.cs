using Chr.OnlineApp.BLL;
using Chr.OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for CourseJoinManage
    /// </summary>
    public class CourseJoinManage : IHttpHandler
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

        //获取上课情况列表分页数据
        public void GetCoursePageData(HttpContext context)
        {
            string strPageSize = context.Request["PageSize"];
            string strCurPage = context.Request["CurPage"];
            string strcreateUserId = context.Request["createUserId"];
            string strcreateUserName = context.Request["createUserName"];
            string strupdateUserId = context.Request["updateUserId"];
            string strupdateUserName = context.Request["updateUserName"];
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["courseName"];
            string strcontent = context.Request["content"];
            string strtitle = context.Request["title"];
            string strstatus = context.Request["status"];
            string strCallBack = context.Request["callback"];

            try
            {
                string strResult = CommonToolsBLL.PageDataToJson(YWCourseJoinBLL.GetPageData(Convert.ToInt32(strPageSize), Convert.ToInt32(strCurPage), strcreateUserId, strcreateUserName, strcourseId, strcourseName, strupdateUserId, strupdateUserName, strstatus));
                CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "获取数据失败" + e.ToString());
            }
        }

        //新增上课情况接口 
        /*public void AddCourseJoin(HttpContext context)
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
            string strcreateTime = context.Request["createTime"];
            string strupdateTime = context.Request["updateTime"];
            string strtitle = context.Request["title"];
            string strlink = context.Request["link"];
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWCourseJoin courseJoin = new YWCourseJoin();
            courseJoin.PlanId = strplanId != null ? Convert.ToInt32(strplanId) : 0;
            courseJoin.PlanName = strplanName != null ? strcontent : "";
            courseJoin.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : 0;
            courseJoin.CourseName = strcourseName != null ? strcontent : "";
            courseJoin.CreateUserName = strcreateUserName != null ? strcontent : "";
            courseJoin.CreateUserId = strcreateUserId != null ? Convert.ToInt32(strcreateUserId) : 0;
            courseJoin.UpdateUserName = strupdateUserName != null ? strcontent : "";
            courseJoin.UpdateUserId = strupdateUserId != null ? Convert.ToInt32(strupdateUserId) : 0;
            courseJoin.Content = strcontent != null ? strcontent : "";
            courseJoin.Title = strtitle != null ? strcontent : "";
            courseJoin.Link = strlink != null ? strcontent : "";
            courseJoin.CreateTime = DateTime.Now;
            courseJoin.UpdateTime = DateTime.Now;
            courseJoin.Status = strstatus != null ? Convert.ToInt32(strstatus) : 0;
            courseJoin.Alternate1 = strAlternate1 != null ? strAlternate1 : "";
            courseJoin.Alternate2 = strAlternate2 != null ? strAlternate2 : "";
            courseJoin.Alternate3 = strAlternate3 != null ? strAlternate3 : "";
            courseJoin.Alternate4 = strAlternate4 != null ? strAlternate4 : "";
            courseJoin.Alternate5 = strAlternate5 != null ? strAlternate5 : "";

            try
            {
                YWCourseJoinBLL.Insert(courseJoin);
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "上课情况添加成功");

            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "课程添加失败" + e.ToString());
            }
        }

        //更新上课情况接口 
        public void ModifyCourseJoin(HttpContext context)
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
            string strcreateTime = context.Request["createTime"];
            string strupdateTime = context.Request["updateTime"];
            string strtitle = context.Request["title"];
            string strlink = context.Request["link"];
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWCourseJoin courseJoin = YWCourseJoinBLL.GetDataById(strId);
            courseJoin.PlanId = strplanId != null ? Convert.ToInt32(strplanId) : courseJoin.PlanId;
            courseJoin.PlanName = strplanName != null ? strcontent : courseJoin.PlanName;
            courseJoin.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : courseJoin.CourseId;
            courseJoin.CourseName = strcourseName != null ? strcontent : courseJoin.CourseName;
            courseJoin.CreateUserName = strcreateUserName != null ? strcontent : courseJoin.CreateUserName;
            courseJoin.CreateUserId = strcreateUserId != null ? Convert.ToInt32(strcreateUserId) : courseJoin.CreateUserId;
            courseJoin.UpdateUserName = strupdateUserName != null ? strcontent : courseJoin.UpdateUserName;
            courseJoin.UpdateUserId = strupdateUserId != null ? Convert.ToInt32(strupdateUserId) : courseJoin.UpdateUserId;
            courseJoin.Content = strcontent != null ? strcontent : courseJoin.Content;
            courseJoin.Title = strtitle != null ? strcontent : courseJoin.Title;
            courseJoin.Link = strlink != null ? strcontent : courseJoin.Link;
            courseJoin.UpdateTime = DateTime.Now;
            courseJoin.Status = strstatus != null ? Convert.ToInt32(strstatus) : courseJoin.Status;
            courseJoin.Alternate1 = strAlternate1 != null ? strAlternate1 : courseJoin.Alternate1;
            courseJoin.Alternate2 = strAlternate2 != null ? strAlternate2 : courseJoin.Alternate2;
            courseJoin.Alternate3 = strAlternate3 != null ? strAlternate3 : courseJoin.Alternate3;
            courseJoin.Alternate4 = strAlternate4 != null ? strAlternate4 : courseJoin.Alternate4;
            courseJoin.Alternate5 = strAlternate5 != null ? strAlternate5 : courseJoin.Alternate5;

            try
            {
                YWCourseJoinBLL.Update(courseJoin);
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "上课情况更新成功");

            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "上课情况更新失败" + e.ToString());
            }
        }

        //删除指定的上课情况
        public void DeleteCourseJoin(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');

            try
            {
                foreach (string item in strList)
                {
                    YWCourseJoinBLL.Delete(Convert.ToInt32(item));
                }
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "所选上课情况删除成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "所选上课情况删除失败" + e.ToString());
            }
        }*/
    }
}