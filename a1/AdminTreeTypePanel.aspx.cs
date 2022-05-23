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
    public partial class TreeTypePanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void GetAll()
        {
            GridView1.DataSource = _treeTypeService.GetAll().Data;
            GridView1.DataBind();
        }

        ITreeTypeService _treeTypeService = new TreeTypeManager();

        protected void LnkBtn_Update_Command(object sender, CommandEventArgs e)
        {
            var treeTypeId = Convert.ToInt32(e.CommandArgument);
            var treeTypeToUpdate = _treeTypeService.GetById(treeTypeId).Data;

            tbx_UpdateId.Text = Convert.ToString(treeTypeToUpdate.Id);
            tbx_UpdateName.Text = Convert.ToString(treeTypeToUpdate.Name);
            


            GetAll();
        }

        protected void LnkBtn_Delete_Command(object sender, CommandEventArgs e)
        {
            var treeTypeId = Convert.ToInt32(e.CommandArgument);
            var treeTypeToDelete = _treeTypeService.GetById(treeTypeId).Data;

            Delete(treeTypeToDelete);

            GetAll();
        }

        public void Delete(TreeType treeType)
        {
            _treeTypeService.Delete(treeType);
        }

        protected void btn_Update_Click(object sender, EventArgs e)
        {
            TreeType treeType = new TreeType();
            treeType.Id = Convert.ToInt32(tbx_UpdateId.Text);
            treeType.Name = (tbx_UpdateName.Text);
           

            _treeTypeService.Update(treeType);
            GetAll();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            TreeType treeType = new TreeType();
            
            treeType.Name = tbx_AddName.Text;


            _treeTypeService.Add(treeType);
            GetAll();
        }
    }
}