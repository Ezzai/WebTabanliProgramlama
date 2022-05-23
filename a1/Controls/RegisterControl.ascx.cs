using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a1.Controls
{
    public partial class RegisterControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDown_SecurityQuestions.DataSource = GetAllQuestions();
                DropDown_SecurityQuestions.DataBind();
            }
        }

        private List<ListItem> GetAllQuestions()
        {
            var securityQuestions = _securityQuestionService.GetAll().Data;

            List<ListItem> list = new List<ListItem>();

            foreach (var question in securityQuestions)
            {
                ListItem item = new ListItem();
                item.Text = question.Question;
                item.Value = Convert.ToString(question.Id);

                list.Add(item);
            }

            return list;
        }

        IAuthService _authService = new AuthManager();
        ICustomerService _customerService = new CustomerManager();
        ISecurityQuestionService _securityQuestionService = new SecurityQuestionManager();

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            UserForRegisterDto userForRegisterDto = new UserForRegisterDto();

            userForRegisterDto.FirstName = tbx_FirstName.Text;
            userForRegisterDto.LastName = tbx_LastName.Text;
            userForRegisterDto.Email = tbx_Email.Text;
            userForRegisterDto.Password = tbx_Password.Text;

            UserSecurityQuestionDto userSecurityQuestionDto = new UserSecurityQuestionDto();

            userSecurityQuestionDto.SecurityQuestion = DropDown_SecurityQuestions.SelectedItem.Text;
            userSecurityQuestionDto.SecurityQuestionAnswer = tbx_SecurityQuestionAnswer.Text;

            var result = _authService.Register(userForRegisterDto, userSecurityQuestionDto);

            UserAuthority userAuthority = new UserAuthority();
            userAuthority.AuthorityId = 2;
            userAuthority.UserId = result.Data.Id;

            _authService.AddUserAuthority(userAuthority);

            Customer customer = new Customer
            {
                UserId = result.Data.Id,
                FirstName = tbx_FirstName.Text,
                LastName = tbx_LastName.Text,
                City = tbx_City.Text,
                Address = tbx_Address.Text,
                Phone = tbx_Phone.Text,
                Email = tbx_Email.Text
            };

            _customerService.Add(customer);

            if (result.Success)
            {
                lbl_Register.Text = result.Message;
                Response.Redirect("/Login/LoginPage");
            }

            lbl_Register.Text = result.Message;
        }
    }
}