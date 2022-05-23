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
    public partial class TreeSell : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grd_Trees.DataSource = GetAll();
            Grd_Trees.DataBind();
        }

        ITreeService _treeService = new TreeManager();
        ITreeTypeService _treeTypeService = new TreeTypeManager();
        ICartService _cartService = new CartManager();
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
            var treeId = Convert.ToInt32(e.CommandArgument);

            Cart cart = new Cart();
            cart.TreeId = treeId;
            cart.UserId = Convert.ToInt32(HttpContext.Current.Session["UserId"]);
            cart.Quantity = 1;

            _cartService.CheckCart(cart);
        }

        protected void Grd_Trees_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Grd_Trees.PageIndex = e.NewPageIndex;
            Grd_Trees.DataBind();
        }
    }
}