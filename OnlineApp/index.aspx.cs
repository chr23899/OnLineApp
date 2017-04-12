using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chr.OnlineApp
{
    public partial class index : System.Web.UI.Page
    {
        public String nowPath = "";
        protected void Page_Load(object sender, EventArgs e)
        { 
            String spath = Request.Url.AbsolutePath;
            String sUripath = Request.Url.AbsoluteUri;
            nowPath = sUripath.Substring(0, sUripath.Length - spath.Length); 
        }

        protected void butn_logout_Click(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut(); 
            Response.Redirect("login.aspx");
        }
         
    }
}