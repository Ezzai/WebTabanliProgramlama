using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace a1
{
    public class Global : System.Web.HttpApplication
    {

        void UserRoute(RouteCollection route)
        {
            route.MapPageRoute("Giriş", "Login/LoginPage", "~/Login/LoginPage.aspx");
            route.MapPageRoute("Kayıt", "Register/RegisterPage", "~/Register/RegisterPage.aspx");
            route.MapPageRoute("Şifremi Hatırlat", "ForgotPassword/ForgotPassword", "~/ForgotPassword/ForgotPassword.aspx");
            route.MapPageRoute("Güvenlik Sorusu", "ForgotPassword/SecurityQuestions", "~/ForgotPassword/SecurityQuestions.aspx");
            route.MapPageRoute("Şifremi Değiştir", "ForgotPassword/PasswordChange", "~/ForgotPassword/PasswordChange.aspx");

            // Admin
            route.MapPageRoute("Tree", "Admin/Tree", "~/AdminTreePanel.aspx");
            route.MapPageRoute("TreeType", "Admin/TreeType", "~/AdminTreeTypePanel.aspx");
            route.MapPageRoute("Customer", "Admin/Customer", "~/AdminCustomerPanel.aspx");
            route.MapPageRoute("Dashboard", "Admin/Dashboard", "~/AdminDashboard.aspx");
            route.MapPageRoute("TreeOrder", "Admin/TreeOrder", "~/AdminTreeOrderPanel.aspx");
            route.MapPageRoute("Authority", "Admin/Authority", "~/AdminAuthorityPanel.aspx");
            route.MapPageRoute("User", "Admin/User", "~/AdminUserPanel.aspx");
            route.MapPageRoute("UserAuthority", "Admin/UserAuthority", "~/AdminUserAuthorityPanel.aspx");

            route.MapPageRoute("UserTree", "Site/Tree", "~/Site/TreeSell.aspx");
            route.MapPageRoute("Cart", "CartForm/CartPage", "~/Site/CartPage.aspx");


        }

        protected void Application_Start(object sender, EventArgs e)
        {
            UserRoute(RouteTable.Routes);
        }


        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}