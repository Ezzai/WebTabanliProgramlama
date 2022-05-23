using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace a1.Site
{
    public partial class AdminTreeSell : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grd_Trees.DataSource = GetAll();
            Grd_Trees.DataBind();
        }

        ITreeService _treeService = new TreeManager();
        ITreeTypeService _treeTypeService = new TreeTypeManager();
        protected List<TreeDto> GetAll()
        {
            var result = _treeService.GetAllTreeDtos();
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        protected List<TreeType> GetAllTreeTypes()
        {
            var result = _treeTypeService.GetAll();
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        protected void Lnk_AddToCart_Command(object sender, CommandEventArgs e)
        {

        }

        protected void Grd_Trees_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grd_Trees.PageIndex = e.NewPageIndex;
            Grd_Trees.DataBind();
        }
        


    }
}