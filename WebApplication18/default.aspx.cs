using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication18
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(User.Identity.Name))
                this.Label1.Text = User.Identity.Name;
            else
                Response.Redirect("login.aspx");
        }
    }
}