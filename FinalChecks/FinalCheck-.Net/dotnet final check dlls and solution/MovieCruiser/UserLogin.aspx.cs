﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace MovieCruiser
{
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            if (Txtname.Text == "vyshnavi" && Txtpassword.Text == "12345")
            {
                Session["Name"] = Txtname.Text;
                FormsAuthentication.RedirectFromLoginPage(Txtname.Text, true);

            }
        }



    }
}