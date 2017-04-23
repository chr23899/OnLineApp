using Chr.OnlineApp.BLL;
using Chr.OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for ExamQuestionManage
    /// </summary>
    public class ExamQuestionManage : IHttpHandler
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

        //获取考试问题卷列表分页数据
        public void GetExamQuestionPageData(HttpContext context)
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


            string strResult = CommonToolsBLL.PageDataToJson(YWExamQuestionBLL.GetPageData(Convert.ToInt32(strPageSize), Convert.ToInt32(strCurPage), strcreateUserId, strcreateUserName, strcourseId, strcourseName, strupdateUserId, strupdateUserName, strstatus));
            CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");
        }

        //新增考试问题卷接口 
        public void AddExamQuestion(HttpContext context)
        {
            string strexamId = context.Request["examId"];
            string strtype = context.Request["type"];
            string strpic = context.Request["pic"];
            string strscore = context.Request["score"];
            string strchance1 = context.Request["chance1"];
            string strchance2 = context.Request["chance2"];
            string strchance3 = context.Request["chance3"];
            string strchance4 = context.Request["chance4"];
            string strchance5 = context.Request["chance5"];
            string strcontent = context.Request["content"];
            string strchanceAnswer = context.Request["chanceAnswer"];
            string strobjectAnswer = context.Request["objectAnswer"];
            string strobjectPic = context.Request["objectPic"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWExamQuestion examQuestion = new YWExamQuestion();
            examQuestion.ExamId = strexamId != null ? Convert.ToInt32(strexamId) : 0;
            examQuestion.Type = strtype != null ? Convert.ToInt32(strtype) : 0;
            examQuestion.Pic = strpic != null ? strpic : "";
            examQuestion.Score = strscore != null ? Convert.ToInt32(strscore) : 0;
            examQuestion.ChanceAnswer = strchanceAnswer != null ? strchanceAnswer : "";
            examQuestion.Chance1 = strchance1 != null ? strchance1 : "";
            examQuestion.Chance2 = strchance2 != null ? strchance2 : "";
            examQuestion.Chance3 = strchance3 != null ? strchance3 : "";
            examQuestion.Chance4 = strchance4 != null ? strchance4 : "";
            examQuestion.Chance5 = strchance5 != null ? strchance5 : "";
            examQuestion.Content = strcontent != null ? strcontent : "";
            examQuestion.ObjectAnswer = strobjectAnswer != null ? strobjectAnswer : "";
            examQuestion.ObjectPic = strobjectPic != null ? strobjectPic : "";
            examQuestion.CreateTime = DateTime.Now;
            examQuestion.UpdateTime = DateTime.Now;
            examQuestion.Alternate1 = strAlternate1 != null ? strAlternate1 : "";
            examQuestion.Alternate2 = strAlternate2 != null ? strAlternate2 : "";
            examQuestion.Alternate3 = strAlternate3 != null ? strAlternate3 : "";
            examQuestion.Alternate4 = strAlternate4 != null ? strAlternate4 : "";
            examQuestion.Alternate5 = strAlternate5 != null ? strAlternate5 : "";


            YWExamQuestionBLL.Insert(examQuestion);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "考试问题卷添加成功");
        }

        //更新考试问题卷接口 
        public void ModifyExamQuestion(HttpContext context)
        {
            string strId = context.Request["id"];
            string strexamId = context.Request["examId"];
            string strtype = context.Request["type"];
            string strpic = context.Request["pic"];
            string strscore = context.Request["score"];
            string strchance1 = context.Request["chance1"];
            string strchance2 = context.Request["chance2"];
            string strchance3 = context.Request["chance3"];
            string strchance4 = context.Request["chance4"];
            string strchance5 = context.Request["chance5"];
            string strcontent = context.Request["content"];
            string strchanceAnswer = context.Request["chanceAnswer"];
            string strobjectAnswer = context.Request["objectAnswer"];
            string strobjectPic = context.Request["objectPic"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWExamQuestion examQuestion = YWExamQuestionBLL.GetDataById(strId);
            examQuestion.ExamId = strexamId != null ? Convert.ToInt32(strexamId) : examQuestion.ExamId;
            examQuestion.Type = strtype != null ? Convert.ToInt32(strtype) : examQuestion.Type;
            examQuestion.Pic = strpic != null ? strpic : examQuestion.Pic;
            examQuestion.Score = strscore != null ? Convert.ToInt32(strscore) : examQuestion.Score;
            examQuestion.ChanceAnswer = strchanceAnswer != null ? strchanceAnswer : examQuestion.ChanceAnswer;
            examQuestion.Chance1 = strchance1 != null ? strchance1 : examQuestion.Chance1;
            examQuestion.Chance2 = strchance2 != null ? strchance2 : examQuestion.Chance2;
            examQuestion.Chance3 = strchance3 != null ? strchance3 : examQuestion.Chance3;
            examQuestion.Chance4 = strchance4 != null ? strchance4 : examQuestion.Chance4;
            examQuestion.Chance5 = strchance5 != null ? strchance5 : examQuestion.Chance5;
            examQuestion.Content = strcontent != null ? strcontent : examQuestion.Content;
            examQuestion.ObjectAnswer = strobjectAnswer != null ? strobjectAnswer : examQuestion.ObjectAnswer;
            examQuestion.ObjectPic = strobjectPic != null ? strobjectPic : examQuestion.ObjectPic;
            examQuestion.UpdateTime = DateTime.Now;
            examQuestion.Alternate1 = strAlternate1 != null ? strAlternate1 : examQuestion.Alternate1;
            examQuestion.Alternate2 = strAlternate2 != null ? strAlternate2 : examQuestion.Alternate2;
            examQuestion.Alternate3 = strAlternate3 != null ? strAlternate3 : examQuestion.Alternate3;
            examQuestion.Alternate4 = strAlternate4 != null ? strAlternate4 : examQuestion.Alternate4;
            examQuestion.Alternate5 = strAlternate5 != null ? strAlternate5 : examQuestion.Alternate5;

            YWExamQuestionBLL.Update(examQuestion);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "考试问题卷更新成功");
        }

        //删除指定的考试问题卷
        public void DeleteExamQuestion(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');

            foreach (string item in strList)
            {
                YWExamQuestionBLL.Delete(Convert.ToInt32(item));
            }
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "所选考试问题卷删除成功");
        }
    }
}