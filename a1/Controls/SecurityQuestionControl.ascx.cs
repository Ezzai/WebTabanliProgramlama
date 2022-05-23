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
    public partial class SecurityQuestionControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var userEmail = Session["Email"].ToString();
                var userSecurityQuestionDto = _userService.GetUserSecurityQuestion(userEmail);

                if (!userSecurityQuestionDto.Success)
                {
                    lbl_SecurityQuestionControl.Text = userSecurityQuestionDto.Message;
                    Response.Redirect("~/Register/RegisterPage");
                }

                Session["Question"] = userSecurityQuestionDto.Data.SecurityQuestion;

                lbl_Email.Text = userEmail;
                lbl_SecurityQuestion.Text = userSecurityQuestionDto.Data.SecurityQuestion;
            }
        }

        IUserService _userService = new UserManager();

       

        protected void btn_SecurityQuestion_Click(object sender, EventArgs e)
        {
            var userEmail = Session["Email"].ToString();
            var userSecurityQuestionDto = _userService.GetUserSecurityQuestion(userEmail);

            var userQuestionAnswer = tbx_SecurityQuestionAnswer.Text;

            if (userQuestionAnswer == userSecurityQuestionDto.Data.SecurityQuestionAnswer)
            {
                Session["QuestionAnswer"] = userQuestionAnswer;
                Response.Redirect("~/ForgotPassword/PasswordChange");
            }
            lbl_SecurityQuestionControl.Text = "Tekrar Deneyiniz.";

        }
    }
}