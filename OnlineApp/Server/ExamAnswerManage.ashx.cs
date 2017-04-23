using Chr.OnlineApp.BLL;
using Chr.OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for ExamAnswerManage
    /// </summary>
    public class ExamAnswerManage : IHttpHandler
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

        //获取考试答题卷列表分页数据
        public void GetExamAnswerPageData(HttpContext context)
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

            string strResult = CommonToolsBLL.PageDataToJson(YWExamAnswerBLL.GetPageData(Convert.ToInt32(strPageSize), Convert.ToInt32(strCurPage), strcreateUserId, strcreateUserName, strcourseId, strcourseName, strupdateUserId, strupdateUserName, strstatus));
            CommonToolsBLL.OutputJson(context, strCallBack, strResult, "success", "获取数据成功");
        }

        //新增考试答题卷接口 
        public void AddExamAnswer(HttpContext context)
        {
            string strexamId = context.Request["examId"];
            string strquestionId = context.Request["questionId"];
            string strtype = context.Request["type"];
            string strscore = context.Request["score"];
            string strchanceAnswer = context.Request["chanceAnswer"];
            string strobjectAnswer = context.Request["objectAnswer"];
            string strobjectPic = context.Request["objectPic"];
            string strresult = context.Request["result"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWExamAnswer examAnswer = new YWExamAnswer();
            examAnswer.ExamId = strexamId != null ? Convert.ToInt32(strexamId) : 0;
            examAnswer.QuestionId = strquestionId != null ? Convert.ToInt32(strquestionId) : 0;
            examAnswer.Type = strtype != null ? Convert.ToInt32(strtype) : 0;
            examAnswer.Score = strscore != null ? Convert.ToInt32(strscore) : 0;
            examAnswer.ChanceAnswer = strchanceAnswer != null ? strchanceAnswer : "";
            examAnswer.ObjectAnswer = strobjectAnswer != null ? strobjectAnswer : "";
            examAnswer.ObjectPic = strobjectPic != null ? strobjectPic : "";
            examAnswer.Result = strresult != null ? Convert.ToInt32(strresult) : 0;
            examAnswer.CreateUserName = pTUsers.Nickname;
            examAnswer.CreateUserId = pTUsers.Id;
            examAnswer.UpdateUserName = pTUsers.Nickname;
            examAnswer.UpdateUserId = pTUsers.Id;
            examAnswer.CreateTime = DateTime.Now;
            examAnswer.UpdateTime = DateTime.Now;
            examAnswer.Alternate1 = strAlternate1 != null ? strAlternate1 : "";
            examAnswer.Alternate2 = strAlternate2 != null ? strAlternate2 : "";
            examAnswer.Alternate3 = strAlternate3 != null ? strAlternate3 : "";
            examAnswer.Alternate4 = strAlternate4 != null ? strAlternate4 : "";
            examAnswer.Alternate5 = strAlternate5 != null ? strAlternate5 : "";

            YWExamAnswerBLL.Insert(examAnswer);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "考试答题卷添加成功");
        }

        //更新考试答题卷接口 
        public void ModifyExamAnswer(HttpContext context)
        {
            string strId = context.Request["id"];
            string strexamId = context.Request["examId"];
            string strquestionId = context.Request["questionId"];
            string strtype = context.Request["type"];
            string strscore = context.Request["score"];
            string strchanceAnswer = context.Request["chanceAnswer"];
            string strobjectAnswer = context.Request["objectAnswer"];
            string strobjectPic = context.Request["objectPic"];
            string strresult = context.Request["result"];
            string strAlternate1 = context.Request["Alternate1"];
            string strAlternate2 = context.Request["Alternate2"];
            string strAlternate3 = context.Request["Alternate3"];
            string strAlternate4 = context.Request["Alternate4"];
            string strAlternate5 = context.Request["Alternate5"];
            string strCallBack = context.Request["callback"];

            YWExamAnswer examAnswer = YWExamAnswerBLL.GetDataById(strId);
            examAnswer.ExamId = strexamId != null ? Convert.ToInt32(strexamId) : examAnswer.ExamId;
            examAnswer.QuestionId = strquestionId != null ? Convert.ToInt32(strquestionId) : examAnswer.QuestionId;
            examAnswer.Type = strtype != null ? Convert.ToInt32(strtype) : examAnswer.Type;
            examAnswer.Score = strscore != null ? Convert.ToInt32(strscore) : examAnswer.Score;
            examAnswer.ChanceAnswer = strchanceAnswer != null ? strchanceAnswer : examAnswer.ChanceAnswer;
            examAnswer.ObjectAnswer = strobjectAnswer != null ? strobjectAnswer : examAnswer.ObjectAnswer;
            examAnswer.ObjectPic = strobjectPic != null ? strobjectPic : examAnswer.ObjectPic;
            examAnswer.Result = strresult != null ? Convert.ToInt32(strresult) : 0;
            examAnswer.UpdateUserName = pTUsers.Nickname;
            examAnswer.UpdateUserId = pTUsers.Id;
            examAnswer.UpdateTime = DateTime.Now;
            examAnswer.Alternate1 = strAlternate1 != null ? strAlternate1 : examAnswer.Alternate1;
            examAnswer.Alternate2 = strAlternate2 != null ? strAlternate2 : examAnswer.Alternate2;
            examAnswer.Alternate3 = strAlternate3 != null ? strAlternate3 : examAnswer.Alternate3;
            examAnswer.Alternate4 = strAlternate4 != null ? strAlternate4 : examAnswer.Alternate4;
            examAnswer.Alternate5 = strAlternate5 != null ? strAlternate5 : examAnswer.Alternate5;

            YWExamAnswerBLL.Update(examAnswer);
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "考试答题卷更新成功");
        }

        //删除指定的考试答题卷
        public void DeleteExamAnswer(HttpContext context)
        {
            string strDelete = context.Request["strDelete"];
            string strCallBack = context.Request["callback"];

            string[] strList = strDelete.Split(',');


            foreach (string item in strList)
            {
                YWExamAnswerBLL.Delete(Convert.ToInt32(item));
            }
            CommonToolsBLL.OutputJson(context, strCallBack, "{}", "success", "所选考试答题卷删除成功");
        }
    }
}