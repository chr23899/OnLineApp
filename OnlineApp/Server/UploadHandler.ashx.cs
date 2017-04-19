using Chr.OnlineApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineApp.Server
{
    /// <summary>
    /// Summary description for UploadHandler
    /// </summary>
    public class UploadHandler : IHttpHandler
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

        /// <summary>
        /// add by chr
        /// 公共方法: 上传单个图片
        /// </summary>
        /// <param name="context"></param>
        public void UploadImg(HttpContext context)
        {
            HttpFileCollection files = context.Request.Files;
            HttpPostedFile file = files[0];
            var strtype = context.Request["type"];
            var picName = context.Request["picName"];
            string fname = context.Server.MapPath("\\Static\\img\\" + strtype + "\\" + picName + "_" + file.FileName);
            string strCallBack = context.Request["callback"];

            try
            {
                file.SaveAs(fname); 
                CommonToolsBLL.OutputJson(context, strCallBack, fname, "success", "图片上传成功");
            }
            catch (Exception e)
            {
                CommonToolsBLL.OutputJson(context, strCallBack, "{}", "failed", "图片上传失败" + e.ToString());
            }
        }
    }
}