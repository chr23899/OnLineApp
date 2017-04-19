using Chr.OnlineApp.BLL;
using Chr.OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for CoursePlanPlanManage
    /// </summary>
    public class CoursePlanManage : IHttpHandler
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

        //获取用户列表分页数据
        public void GetCoursePlanPageData(HttpContext context)
        {
            string strPageSize = context.Request["PageSize"];
            string strCurPage = context.Request["CurPage"];
            string strteacherId = context.Request["teacherId"];
            string strteacherName = context.Request["teacherName"];
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["courseName"];
            string strcontent = context.Request["content"];
            string strtitle = context.Request["title"];
            string strstatus = context.Request["status"];
            string strCallBack = context.Request["callback"];

            try
            {
                //其中只有 courseId 、 courseName 、status 为搜索条件
                string strResult = CommonToolsBLL.PageDataToJson(YWCoursePlanBLL.GetPageData(Convert.ToInt32(strPageSize), Convert.ToInt32(strCurPage), strteacherId, strteacherName, strcourseId, strcourseName, strcontent, strtitle, strstatus));
                CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "获取数据失败" + e.ToString());
            }
        }

        //新增课程计划接口
        public void AddCoursePlan(HttpContext context)
        {
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["coursePlanName"];
            string strname = context.Request["name"];
            string strcontent = context.Request["content"];
            string strtype = context.Request["type"];
            string strpic = context.Request["pic"];
            string strvideo = context.Request["video"];
            string strstudy = context.Request["study"];
            string strtest = context.Request["test"];
            string strplanTime = context.Request["planTime"];
            string strstartTime = context.Request["startTime"];
            string strfinishTime = context.Request["finishTime"]; 
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWCoursePlan coursePlan = new YWCoursePlan();
            coursePlan.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : 0;
            coursePlan.CourseName = strcourseName != null ? strcourseName : "课程计划未命名";
            coursePlan.Name = strname != null ? strname : "无";
            coursePlan.Content = strcontent != null ? strcontent : "";
            coursePlan.Type = strtype != null ? strtype : "";
            coursePlan.Pic = strpic != null ? strpic : "";
            coursePlan.Video = strvideo != null ? strvideo : "";
            coursePlan.Study = strstudy != null ? strstudy : "";
            coursePlan.Test = strtest != null ? strtest : "";
            coursePlan.PlanTime = strplanTime != null ? Convert.ToDateTime(strplanTime) : DateTime.Now;
            coursePlan.StartTime = strstartTime != null ? Convert.ToDateTime(strstartTime) : DateTime.Now;
            coursePlan.FinishTime = strfinishTime != null ? Convert.ToDateTime(strfinishTime) : DateTime.Now;
            coursePlan.CreateTime = DateTime.Now;
            coursePlan.UpdateTime = DateTime.Now; 
            coursePlan.Status = strstatus != null ? Convert.ToInt32(strstatus) : 0;
            coursePlan.Alternate1 = strAlternate1 != null ? strAlternate1 : "";
            coursePlan.Alternate2 = strAlternate2 != null ? strAlternate2 : "";
            coursePlan.Alternate3 = strAlternate3 != null ? strAlternate3 : "";
            coursePlan.Alternate4 = strAlternate4 != null ? strAlternate4 : "";
            coursePlan.Alternate5 = strAlternate5 != null ? strAlternate5 : "";
            try
            {
                YWCoursePlanBLL.Insert(coursePlan);
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "课程计划添加成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "课程计划添加失败" + e.ToString());
            }
        }

        //编辑课程计划信息
        public void ModifyCoursePlan(HttpContext context)
        {
            string strId = context.Request["id"];
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["coursePlanName"];
            string strname = context.Request["name"];
            string strcontent = context.Request["content"];
            string strtype = context.Request["type"];
            string strpic = context.Request["pic"];
            string strvideo = context.Request["video"];
            string strstudy = context.Request["study"];
            string strtest = context.Request["test"];
            string strplanTime = context.Request["planTime"];
            string strstartTime = context.Request["startTime"];
            string strfinishTime = context.Request["finishTime"];
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWCoursePlan coursePlan = YWCoursePlanBLL.GetDataById(strId);
            coursePlan.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : coursePlan.CourseId;
            coursePlan.CourseName = strcourseName != null ? strcourseName : coursePlan.CourseName;
            coursePlan.Name = strname != null ? strname : coursePlan.Name;
            coursePlan.Content = strcontent != null ? strcontent : coursePlan.Content;
            coursePlan.Type = strtype != null ? strtype : coursePlan.Type;
            coursePlan.Pic = strpic != null ? strpic : coursePlan.Pic;
            coursePlan.Video = strvideo != null ? strvideo : coursePlan.Video;
            coursePlan.Study = strstudy != null ? strstudy : coursePlan.Study;
            coursePlan.Test = strtest != null ? strtest : coursePlan.Test;
            coursePlan.PlanTime = strplanTime != null ? Convert.ToDateTime(strplanTime) : coursePlan.PlanTime;
            coursePlan.StartTime = strstartTime != null ? Convert.ToDateTime(strstartTime) : coursePlan.StartTime;
            coursePlan.FinishTime = strfinishTime != null ? Convert.ToDateTime(strfinishTime) : coursePlan.FinishTime; 
            coursePlan.UpdateTime = DateTime.Now;
            coursePlan.Status = strstatus != null ? Convert.ToInt32(strstatus) : coursePlan.Status;
            coursePlan.Alternate1 = strAlternate1 != null ? strAlternate1 : coursePlan.Alternate1;
            coursePlan.Alternate2 = strAlternate2 != null ? strAlternate2 : coursePlan.Alternate2;
            coursePlan.Alternate3 = strAlternate3 != null ? strAlternate3 : coursePlan.Alternate3;
            coursePlan.Alternate4 = strAlternate4 != null ? strAlternate4 : coursePlan.Alternate4;
            coursePlan.Alternate5 = strAlternate5 != null ? strAlternate5 : coursePlan.Alternate5;
            try
            {
                YWCoursePlanBLL.Update(coursePlan);
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "课程计划更新成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "课程计划更新失败" + e.ToString());
            }
        }

        //删除指定的课程计划信息
        public void DeleteCoursePlan(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');

            try
            {
                foreach (string item in strList)
                {
                    YWCoursePlanBLL.Delete(Convert.ToInt32(item));
                }
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "所选课程计划删除成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "所选课程计划删除失败" + e.ToString());
            }
        }
    }
}