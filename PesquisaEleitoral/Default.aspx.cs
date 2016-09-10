using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace PesquisaEleitoral
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            txtUser.Text = System.Web.HttpContext.Current.User.Identity.GetUserName();





        }
    }
}