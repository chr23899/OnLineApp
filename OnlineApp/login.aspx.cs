using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineApp
{
    public partial class login : System.Web.UI.Page
    {

        public String nowPath = "";
        protected void Page_Load(object sender, EventArgs e)
        { 
            if (!IsPostBack)
            {
                error_note.Visible = false;

                String spath = Request.Url.AbsolutePath;
                String sUripath = Request.Url.AbsoluteUri;
                nowPath = sUripath.Substring(0, sUripath.Length - spath.Length); 

                string strUserName = Request.QueryString["UserId"];
                string strPassWord = Request.QueryString["Pw"];

                if (strUserName != "" && strUserName != null)
                {
                    txt_login_userName.Value = strUserName;
                    CheckUserInfo(strUserName, strPassWord);
                }
            }
        }

        private void CheckUserInfo(string strUserName, string strPassWord)
        {
            if (Public.UITools.UserCheck(strUserName, strPassWord))
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie(this.txt_login_userName.Value, false);
                if (Request.QueryString["ReturnUrl"] != "" && Request.QueryString["ReturnUrl"] != null)
                {
                    Response.Redirect(Request.QueryString["ReturnUrl"]);
                }
                else
                {
                    Response.Redirect("index.aspx");
                } 
            }
            else
            {
                error_note.Visible = true;
            }
        }

        protected void butn_login_Click(object sender, EventArgs e)
        {
            CheckUserInfo(txt_login_userName.Value, txt_login_passWord.Value);
        }

        protected void butn_register_Click(object sender, EventArgs e)
        {

        }

        protected void butn_find_Click(object sender, EventArgs e)
        {

        }
    }
}