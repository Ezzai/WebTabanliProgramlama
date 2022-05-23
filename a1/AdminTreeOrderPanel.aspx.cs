using Business.Abstract;
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
    public partial class TreeOrderPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void GetAll()
        {
            GridView1.DataSource = _treeOrderService.GetAll().Data;
            GridView1.DataBind();
        }

        ITreeOrderService _treeOrderService = new TreeOrderManager();

        protected void LnkBtn_Update_Command(object sender, CommandEventArgs e)
        {
            var treeOrderId = Convert.ToInt32(e.CommandArgument);
            var treeOrderToUpdate = _treeOrderService.GetById(treeOrderId).Data;

            tbx_UpdateId.Text = Convert.ToString(treeOrderToUpdate.Id);
            tbx_UpdateTreeId.Text = Convert.ToString(treeOrderToUpdate.TreeId);
            tbx_UpdateCustomerId.Text = Convert.ToString(treeOrderToUpdate.CustomerId);


            GetAll();
        }

        protected void LnkBtn_Delete_Command(object sender, CommandEventArgs e)
        {
            var treeOrderId = Convert.ToInt32(e.CommandArgument);
            var treeOrderToDelete = _treeOrderService.GetById(treeOrderId).Data;

            Delete(treeOrderToDelete);

            GetAll();
        }

        public void Delete(TreeOrder treeOrder)
        {
            _treeOrderService.Delete(treeOrder);
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            TreeOrder treeOrder = new TreeOrder();
            treeOrder.Id = Convert.ToInt32(tbx_UpdateId.Text);
            treeOrder.TreeId = Convert.ToInt32(tbx_UpdateTreeId.Text);
            treeOrder.CustomerId = Convert.ToInt32(tbx_UpdateCustomerId.Text);


            _treeOrderService.Update(treeOrder);
            GetAll();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            TreeOrder treeOrder = new TreeOrder();
            treeOrder.TreeId = Convert.ToInt32(tbx_AddTreeId.Text);
            treeOrder.CustomerId = Convert.ToInt32(tbx_CustomerId.Text);


            _treeOrderService.Add(treeOrder);
            GetAll();
        }
    }
}