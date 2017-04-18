﻿using Chr.OnlineApp.BLL;
using Chr.OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for CourseManage
    /// </summary>
    public class CourseManage : IHttpHandler
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
        public void GetCoursePageData(HttpContext context)
        {
            string strPageSize = context.Request["PageSize"];
            string strCurPage = context.Request["CurPage"];
            string strteacherId = context.Request["teacherId"];
            string strteacherName = context.Request["teacherName"];
            string strcontent = context.Request["content"];
            string strtitle = context.Request["title"];
            string strstatus = context.Request["status"];
            string strCallBack = context.Request["callback"];

            try
            {
                string strResult = CommonToolsBLL.PageDataToJson(YWCourseBLL.GetPageData(Convert.ToInt32(strPageSize), Convert.ToInt32(strCurPage), strteacherId, strteacherName, strcontent, strtitle, strstatus));
                CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "获取数据失败" + e.ToString());
            }
        }

        //新增课程接口
        public void AddCourse(HttpContext context)
        {
            string strcourseName = context.Request["courseName"];
            string strlinkBook = context.Request["linkBook"];
            string strteacherName = context.Request["teacherName"];
            string strteacherId = context.Request["teacherId"];
            string strcontent = context.Request["content"];
            string strtitle = context.Request["title"];
            string strspan = context.Request["span"];
            string strshow = context.Request["show"];
            string strcourseNum = "0";  //初始时改课程上课人数为0 
            string strupdateUserName = context.Request["updateUserName"];
            string strupdateUserId = context.Request["updateUserId"];
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWCourse course = new YWCourse();
            course.CourseName = strcourseName != null ? strcourseName: "课程未命名";
            course.LinkBook = strlinkBook != null ? strlinkBook : "无";
            course.TeacherName = strteacherName != null ? strteacherName : "无";
            course.TeacherId = strteacherId  != null ? Convert.ToInt32(strteacherId) : 0;
            course.Content = strcontent != null ? strcontent : "";
            course.Title = strtitle != null ? strtitle : "";
            course.Span = strspan != null ? strspan : "";
            course.Show = strshow != null ? strshow : "";
            course.CourseNum = strcourseNum != null ? Convert.ToInt32(strcourseNum) : 0;
            course.CreateTime = DateTime.Now;
            course.UpdateTime = DateTime.Now;
            course.UpdateUserName = strupdateUserName != null ? strupdateUserName : "无";
            course.UpdateUserId = strupdateUserId != null ? Convert.ToInt32(strupdateUserId) : 0;
            course.Status = strstatus != null ? Convert.ToInt32(strstatus) : 0;
            course.Alternate1 = strAlternate1 != null ? strAlternate1 : "";
            course.Alternate2 = strAlternate2 != null ? strAlternate2 : "";
            course.Alternate3 = strAlternate3 != null ? strAlternate3 : "";
            course.Alternate4 = strAlternate4 != null ? strAlternate4 : "";
            course.Alternate5 = strAlternate5 != null ? strAlternate5 : "";
            try
            {                
                YWCourseBLL.Insert(course); 
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "课程添加成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "课程添加失败" + e.ToString());
            }
        }

        //编辑课程信息
        public void ModifyCourse(HttpContext context)
        {
            string strId= context.Request["id"];
            string strcourseName = context.Request["courseName"];
            string strlinkBook = context.Request["linkBook"]; 
            string strcontent = context.Request["content"];
            string strtitle = context.Request["title"];
            string strspan = context.Request["span"];
            string strshow = context.Request["show"];
            string strcourseNum = "0";  //初始时改课程上课人数为0 
            string strupdateUserName = context.Request["updateUserName"];
            string strupdateUserId = context.Request["updateUserId"];
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWCourse course = YWCourseBLL.GetDataById(strId);
            course.CourseName = strcourseName != null ? strcourseName : course.CourseName;
            course.LinkBook = strlinkBook != null ? strlinkBook : course.LinkBook;
            course.Content = strcontent != null ? strcontent : course.Content;
            course.Title = strtitle != null ? strtitle : course.Title;
            course.Span = strspan != null ? strspan : course.Span;
            course.Show = strshow != null ? strshow : course.Show;
            course.CourseNum = strcourseNum != null ? Convert.ToInt32(strcourseNum) : course.CourseNum; 
            course.UpdateTime = DateTime.Now;
            course.UpdateUserName = strupdateUserName != null ? strupdateUserName : course.UpdateUserName;
            course.UpdateUserId = strupdateUserId != null ? Convert.ToInt32(strupdateUserId) : course.UpdateUserId;
            course.Status = strstatus != null ? Convert.ToInt32(strstatus) : course.Status;
            course.Alternate1 = strAlternate1 != null ? strAlternate1 : course.Alternate1;
            course.Alternate2 = strAlternate2 != null ? strAlternate2 : course.Alternate2;
            course.Alternate3 = strAlternate3 != null ? strAlternate3 : course.Alternate3;
            course.Alternate4 = strAlternate4 != null ? strAlternate4 : course.Alternate4;
            course.Alternate5 = strAlternate5 != null ? strAlternate5 : course.Alternate5;
            try
            {
                YWCourseBLL.Update(course);
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "课程更新成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "课程更新失败" + e.ToString());
            }
        }

        //删除指定的课程信息
        public void DeleteCourse(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');

            try
            {                
                foreach (string item in strList)
                {
                    YWCourseBLL.Delete(Convert.ToInt32(item));
                }
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "所选课程删除成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "所选课程删除失败" + e.ToString());
            }
        }
    }
}