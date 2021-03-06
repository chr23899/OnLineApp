﻿using Chr.OnlineApp.BLL;
using Chr.OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for CommentManage
    /// </summary>
    public class CommentManage : IHttpHandler
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


        //获取评论列表分页数据
        public void GetCommentPageData(HttpContext context)
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

            string strResult = CommonToolsBLL.PageDataToJson(YWCommentBLL.GetPageData(Convert.ToInt32(strPageSize), Convert.ToInt32(strCurPage), strcreateUserId, strcreateUserName, strcourseId, strcourseName, strstudentId, strstudentName, strstatus));
            CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");
        }

        //新增评论接口 
        public void AddComment(HttpContext context)
        {
            string strplanId = context.Request["planId"];
            string strplanName = context.Request["planName"];
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["courseName"];
            string strcontent = context.Request["content"];
            string strcreateTime = context.Request["createTime"];
            string strupdateTime = context.Request["updateTime"];
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWComment comment = new YWComment();
            comment.PlanId = strplanId != null ? Convert.ToInt32(strplanId) : 0;
            comment.PlanName = strplanName != null ? strplanName : "";
            comment.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : 0;
            comment.CourseName = strcourseName != null ? strcourseName : "";
            comment.CreateUserName = pTUsers.Nickname;
            comment.CreateUserId = pTUsers.Id;
            comment.UpdateUserName = pTUsers.Nickname;
            comment.UpdateUserId = pTUsers.Id;
            comment.Content = strcontent != null ? strcontent : "";
            comment.Support = 0; //初始支持数为 0 
            comment.Oppose = 0;  //初始反对数为 0
            comment.CreateTime = DateTime.Now;
            comment.UpdateTime = DateTime.Now;
            comment.Status = strstatus != null ? Convert.ToInt32(strstatus) : 0;
            comment.Alternate1 = strAlternate1 != null ? strAlternate1 : "";
            comment.Alternate2 = strAlternate2 != null ? strAlternate2 : "";
            comment.Alternate3 = strAlternate3 != null ? strAlternate3 : "";
            comment.Alternate4 = strAlternate4 != null ? strAlternate4 : "";
            comment.Alternate5 = strAlternate5 != null ? strAlternate5 : "";

            YWCommentBLL.Insert(comment);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "评论添加成功");
        }

        //更新评论接口 
        public void ModifyComment(HttpContext context)
        {
            string strId = context.Request["id"];
            string strplanId = context.Request["planId"];
            string strplanName = context.Request["planName"];
            string strcourseId = context.Request["courseId"];
            string strcourseName = context.Request["courseName"];
            string strcontent = context.Request["content"];
            string strsupport = context.Request["support"];
            string stroppose = context.Request["oppose"];
            string strcreateTime = context.Request["createTime"];
            string strupdateTime = context.Request["updateTime"];
            string strstatus = context.Request["status"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWComment comment = YWCommentBLL.GetDataById(strId);
            comment.PlanId = strplanId != null ? Convert.ToInt32(strplanId) : comment.PlanId;
            comment.PlanName = strplanName != null ? strplanName : comment.PlanName;
            comment.CourseId = strcourseId != null ? Convert.ToInt32(strcourseId) : comment.CourseId;
            comment.CourseName = strcourseName != null ? strcourseName : comment.CourseName;
            comment.UpdateUserName = pTUsers.Nickname;
            comment.UpdateUserId = pTUsers.Id;
            comment.Content = strcontent != null ? strcontent : comment.Content;
            comment.Support = strsupport != null ? Convert.ToInt32(strsupport) : comment.Support;
            comment.Oppose = stroppose != null ? Convert.ToInt32(stroppose) : comment.Oppose;
            comment.UpdateTime = DateTime.Now;
            comment.Status = strstatus != null ? Convert.ToInt32(strstatus) : comment.Status;
            comment.Alternate1 = strAlternate1 != null ? strAlternate1 : comment.Alternate1;
            comment.Alternate2 = strAlternate2 != null ? strAlternate2 : comment.Alternate2;
            comment.Alternate3 = strAlternate3 != null ? strAlternate3 : comment.Alternate3;
            comment.Alternate4 = strAlternate4 != null ? strAlternate4 : comment.Alternate4;
            comment.Alternate5 = strAlternate5 != null ? strAlternate5 : comment.Alternate5;

            YWCommentBLL.Update(comment);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "评论更新成功");
        }

        //删除指定的评论
        public void DeleteComment(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');

            foreach (string item in strList)
            {
                YWCommentBLL.Delete(Convert.ToInt32(item));
            }
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "所选评论删除成功");
        }
    }
}