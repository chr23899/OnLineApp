using Chr.OnlineApp.BLL;
using Chr.OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for ExamScore
    /// </summary>
    public class ExamScore : IHttpHandler
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

        //获取考试分数列表分页数据
        public void GetExamScorePageData(HttpContext context)
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

            string strResult = CommonToolsBLL.PageDataToJson(YWExamScoreBLL.GetPageData(Convert.ToInt32(strPageSize), Convert.ToInt32(strCurPage), strcreateUserId, strcreateUserName, strcourseId, strcourseName, strupdateUserId, strupdateUserName, strstatus));
            CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");
        }

        //新增考试分数接口 
        public void AddExamScore(HttpContext context)
        {
            string strexamId = context.Request["examId"];
            string strscore = context.Request["score"];
            string strstudentId = context.Request["studentId"];
            string strstudentName = context.Request["studentName"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWExamScore examScore = new YWExamScore();
            examScore.ExamId = strexamId != null ? Convert.ToInt32(strexamId) : 0;
            examScore.Score = strscore != null ? Convert.ToInt32(strscore) : 0;
            examScore.StudentId = strstudentId != null ? Convert.ToInt32(strstudentId) : 0;
            examScore.StudentName = strstudentName != null ? strstudentName : "";
            examScore.CreateUserName = pTUsers.Nickname;
            examScore.CreateUserId = pTUsers.Id;
            examScore.UpdateUserName = pTUsers.Nickname;
            examScore.UpdateUserId = pTUsers.Id;
            examScore.CreateTime = DateTime.Now;
            examScore.UpdateTime = DateTime.Now;
            examScore.Alternate1 = strAlternate1 != null ? strAlternate1 : "";
            examScore.Alternate2 = strAlternate2 != null ? strAlternate2 : "";
            examScore.Alternate3 = strAlternate3 != null ? strAlternate3 : "";
            examScore.Alternate4 = strAlternate4 != null ? strAlternate4 : "";
            examScore.Alternate5 = strAlternate5 != null ? strAlternate5 : "";

            YWExamScoreBLL.Insert(examScore);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "考试分数添加成功");
        }

        //更新考试分数接口 
        public void ModifyExamScore(HttpContext context)
        {
            string strId = context.Request["id"];
            string strexamId = context.Request["examId"];
            string strscore = context.Request["score"];
            string strstudentId = context.Request["studentId"];
            string strstudentName = context.Request["studentName"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWExamScore examScore = YWExamScoreBLL.GetDataById(strId);
            examScore.ExamId = strexamId != null ? Convert.ToInt32(strexamId) : examScore.ExamId;
            examScore.Score = strscore != null ? Convert.ToInt32(strscore) : examScore.Score;
            examScore.StudentId = strstudentId != null ? Convert.ToInt32(strstudentId) : examScore.StudentId;
            examScore.StudentName = strstudentName != null ? strstudentName : examScore.StudentName;
            examScore.UpdateUserName = pTUsers.Nickname;
            examScore.UpdateUserId = pTUsers.Id;
            examScore.UpdateTime = DateTime.Now;
            examScore.Alternate1 = strAlternate1 != null ? strAlternate1 : examScore.Alternate1;
            examScore.Alternate2 = strAlternate2 != null ? strAlternate2 : examScore.Alternate2;
            examScore.Alternate3 = strAlternate3 != null ? strAlternate3 : examScore.Alternate3;
            examScore.Alternate4 = strAlternate4 != null ? strAlternate4 : examScore.Alternate4;
            examScore.Alternate5 = strAlternate5 != null ? strAlternate5 : examScore.Alternate5;

            YWExamScoreBLL.Update(examScore);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "考试分数更新成功");
        }

        //删除指定的考试分数
        public void DeleteExamScore(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');

            foreach (string item in strList)
            {
                YWExamScoreBLL.Delete(Convert.ToInt32(item));
            }
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "所选考试分数删除成功");
        }
    }
}