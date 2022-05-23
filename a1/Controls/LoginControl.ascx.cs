using Business.Abstract;
using Business.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a1.Controls
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        IAuthService _authService = new AuthManager();


        protected void lnk_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register/RegisterPage");
        }

        protected void lnk_ForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ForgotPassword/ForgotPassword");
        }

        protected void btn_Login_Click(object sender, EventArgs e)
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto();
            userForLoginDto.Email = tbx_Email.Text;
            userForLoginDto.Password = tbx_Password.Text;

            var userLogin = _authService.Login(userForLoginDto);

            if (userLogin.Success)
            {
                var userAuthorities = _authService.GetUserAuthority(userLogin.Data).Data;
                var authorities = _authService.GetAuthorities(userAuthorities).Data;
                var routeUser = _authService.UserAuthorityRoute(authorities).Data;

                Session["Authorities"] = authorities;
                Session["UserName"] = userAuthorities.User.FirstName + " " + userAuthorities.User.LastName;
                Session["UserId"] = userLogin.Data.Id;
                Response.Redirect(routeUser);
            }
            lbl_Login.Text = userLogin.Message;

        }
    }
}