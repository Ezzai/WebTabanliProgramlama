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
    public partial class AdminTreePanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void GetAll()
        {
            GridView1.DataSource = _treeService.GetAll().Data;
            GridView1.DataBind();
        }

        ITreeService _treeService = new TreeManager();

        protected void LnkBtn_Update_Command(object sender, CommandEventArgs e)
        {
            var treeId = Convert.ToInt32(e.CommandArgument);
            var treeToUpdate = _treeService.GetById(treeId).Data;

            tbx_UpdateId.Text = Convert.ToString(treeToUpdate.Id);
            tbx_UpdateTreeTypeId.Text = Convert.ToString(treeToUpdate.TreeTypeId);
            tbx_UpdateName.Text = treeToUpdate.Name;
            tbx_UpdateUnitPrice.Text = Convert.ToString(treeToUpdate.UnitPrice);
            tbx_UpdateUnitsInStock.Text = Convert.ToString(treeToUpdate.UnitsInStock);
            tbx_UpdatePhoto.Text = treeToUpdate.Photo;
            GetAll();
        }

        protected void LnkBtn_Delete_Command(object sender, CommandEventArgs e)
        {
            var treeId = Convert.ToInt32(e.CommandArgument);
            var treeToDelete = _treeService.GetById(treeId).Data;

            Delete(treeToDelete);

            GetAll();
        }

        public void Delete(Tree tree)
        {
            _treeService.Delete(tree);
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            Tree tree = new Tree();
            tree.Id = Convert.ToInt32(tbx_UpdateId.Text);
            tree.TreeTypeId = Convert.ToInt32(tbx_UpdateTreeTypeId.Text);
            tree.Name = tbx_UpdateName.Text;
            tree.UnitPrice = Convert.ToDecimal(tbx_UpdateUnitPrice.Text);
            tree.UnitsInStock = Convert.ToInt16(tbx_UpdateUnitsInStock.Text);
            tree.Photo = tbx_UpdatePhoto.Text;

            _treeService.Update(tree);
            GetAll();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            Tree tree = new Tree();
            tree.TreeTypeId = Convert.ToInt32(tbx_AddTreeTypeId.Text);
            tree.Name = tbx_AddName.Text;
            tree.UnitPrice = Convert.ToDecimal(tbx_AddUnitPrice.Text);
            tree.UnitsInStock = Convert.ToInt16(tbx_AddUnitsInStock.Text);
            tree.Photo = tbx_AddPhoto.Text;

            _treeService.Add(tree);
            GetAll();
        }

    }
}