﻿using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a1
{
    public partial class AdminCustomerPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            GridView1.DataSource = _customerService.GetAll().Data;
            GridView1.DataBind();
        }

        ICustomerService _customerService = new CustomerManager();

        protected void LnkBtn_Update_Command(object sender, CommandEventArgs e)
        {
            var customerId = Convert.ToInt32(e.CommandArgument);
            var customerToUpdate = _customerService.GetById(customerId).Data;

            tbx_UpdateId.Text = Convert.ToString(customerToUpdate.Id);
            tbx_UpdateFirstName.Text = Convert.ToString(customerToUpdate.FirstName);
            tbx_UpdateLastName.Text = Convert.ToString(customerToUpdate.LastName);
            tbx_UpdateAddress.Text = Convert.ToString(customerToUpdate.Address);
            tbx_UpdateCity.Text = Convert.ToString(customerToUpdate.City);
            tbx_UpdatePhone.Text = Convert.ToString(customerToUpdate.Phone);
            tbx_UpdateEmail.Text = Convert.ToString(customerToUpdate.Email);

            GetAll();
        }

        protected void LnkBtn_Delete_Command(object sender, CommandEventArgs e)
        {
            var customerId = Convert.ToInt32(e.CommandArgument);
            var customerToDelete = _customerService.GetById(customerId).Data;

            Delete(customerToDelete);

            GetAll();
        }

        public void Delete(Customer customer)
        {
            _customerService.Delete(customer);
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(tbx_UpdateId.Text);
            customer.FirstName = tbx_UpdateFirstName.Text;
            customer.LastName = tbx_UpdateLastName.Text;
            customer.Address = tbx_UpdateAddress.Text;
            customer.City = tbx_UpdateCity.Text;
            customer.Phone = tbx_UpdatePhone.Text;
            customer.Email = tbx_UpdateEmail.Text;

            _customerService.Update(customer);
            GetAll();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.FirstName = tbx_AddFirstName.Text;
            customer.LastName = tbx_AddLastName.Text;
            customer.Address = tbx_AddAddress.Text;
            customer.City = tbx_AddCity.Text;
            customer.Phone = tbx_AddPhone.Text;
            customer.Email = tbx_AddEmail.Text;

            _customerService.Add(customer);
            GetAll();
        }
    }
}