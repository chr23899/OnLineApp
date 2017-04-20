using Chr.OnlineApp.BLL;
using Chr.OnlineApp.COL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for UploadHandler
    /// </summary>
    public class UploadHandler : IHttpHandler
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

        /// <summary>
        /// add by chr
        /// 公共方法: 上传单个图片
        /// </summary>
        /// <param name="context"></param>
        public void UploadImg(HttpContext context)
        {
            HttpFileCollection files = context.Request.Files;
            //HttpPostedFile file = files[0];
            var nowfile = context.Request["file"];
            var strtype = context.Request["type"];
            var picName = context.Request["picName"];
            HttpPostedFile file = files[0];
            if (Directory.Exists(context.Server.MapPath("\\Static\\img\\" + strtype + "\\" + pTUsers.Type + "\\" + pTUsers.UserName + "\\")) == false)
            {
                Directory.CreateDirectory(context.Server.MapPath("\\Static\\img\\" + strtype + "\\" + pTUsers.Type + "\\" + pTUsers.UserName + "\\"));
            } 
            string fname = context.Server.MapPath("\\Static\\img\\" + strtype + "\\" + pTUsers.Type + "\\" + pTUsers.UserName + "\\" + picName + "_" + file.FileName);
            string strCallBack = context.Request["callback"];
            file.SaveAs(fname);
            context.Response.ContentType = "text/plain";
            context.Response.Write("\\Static\\img\\" + strtype + "\\" + pTUsers.Type + "\\" + pTUsers.UserName + "\\" + picName + "_" + file.FileName);
            context.Response.End(); 
        }

        /// <summary>
        /// add by chr
        /// 公共方法: 上传多个文件
        /// </summary>
        /// <param name="context"></param>
        public void UploadFile(HttpContext context)
        {
            HttpFileCollection files = context.Request.Files;
            //HttpPostedFile file = files[0];
            var nowfile = context.Request["file"];
            var strtype = context.Request["type"];
            var picName = context.Request["picName"];
            var strOut = "";
            if (Directory.Exists(context.Server.MapPath("\\Static\\file\\" + strtype + "\\" + pTUsers.Type + "\\" + pTUsers.UserName + "\\")) == false)
            {
                Directory.CreateDirectory(context.Server.MapPath("\\Static\\file\\" + strtype + "\\" + pTUsers.Type + "\\" + pTUsers.UserName + "\\"));
            } 
            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFile file = files[i];
                var userName = context.Request["name"]; string fname = context.Server.MapPath("\\Static\\file\\" + strtype + "\\" + pTUsers.Type + "\\" + pTUsers.UserName + "\\" + picName + "_" + file.FileName);
                strOut += "\\Static\\file\\" + strtype + "\\" + pTUsers.Type + "\\" + pTUsers.UserName + "\\" + picName + "_" + file.FileName + ";";
                file.SaveAs(fname); 
            }
            string strCallBack = context.Request["callback"]; 
            context.Response.ContentType = "text/plain";
            context.Response.Write(strOut);
            context.Response.End(); 
        }
    }
}