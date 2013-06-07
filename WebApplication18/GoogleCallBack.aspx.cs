using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;

namespace WebApplication18
{
    public partial class GoogleCallBack : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var returnUrl = Request.QueryString["sid"];
            var authResult = OpenAuth.VerifyAuthentication(returnUrl);
            if (authResult.IsSuccessful)
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie(authResult.UserName, false);
                Response.Redirect("default.aspx");
            }
            else {
                Response.Write("授權失敗!!!");
            }
        }
    }
}