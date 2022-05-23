using Business.Abstract;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a1.Controls
{
    public partial class AdminControl : System.Web.UI.UserControl
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Authorities"] == null)
            {
                Response.Redirect("~/User/TreeWebPage");
            }

            if (Session["Authorities"] != null)
            {
                var userAuthorities = Session["Authorities"].ToString();
                var authorities = userAuthorities.Split(',');

                if (!authorities.Contains("Admin"))
                {
                    Response.Redirect("~/User/TreeWebPage");
                }

                AdminMenuManager adminMenuManager = new AdminMenuManager();

                var menus = adminMenuManager.GetAll().Data;

                string myMenu = "";

                foreach (var menu in menus)
                {
                    myMenu += "<li>";
                    myMenu += "<a href = " + "" + menu.MenuName + " ><i class='fa fa-table'></i> " + " " + menu.MenuName + "</a>";
                    myMenu += "</li>";
                }
                Literal1.Text = myMenu;
            }
        }
    }
}