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
    public partial class CartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grd_Cart.DataSource = GetAllCartDtos();
            Grd_Cart.DataBind();

            if (GetAllCartDtos() == null)
            {
                Response.Redirect("/Login/LoginPage");
            }

            lbl_Total.Text = TotalPrice().ToString() + "TL";
        }

        ITreeTypeService _treeTypeService = new TreeTypeManager();
        ITreeService _treeService = new TreeManager();
        IUserService _userService = new UserManager();
        ICartService _cartService = new CartManager();
        ICustomerService _customerService = new CustomerManager();
        ITreeOrderService _treeOrderService = new TreeOrderManager();
        protected List<TreeType> GetAllTreeTypes()
        {
            var result = _treeTypeService.GetAll();
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        protected List<CartDto> GetAllCartDtos()
        {
            if (HttpContext.Current.Session["UserId"] != null)
            {
                int userId = Convert.ToInt32(Session["UserId"]);
                var user = _userService.GetById(userId).Data;

                var result = _cartService.GetAllByDtos(user);
                if (result.Success)
                {
                    return result.Data;
                }
            }
            return null;
        }

        public decimal TotalPrice()
        {
            decimal price = 0;
            foreach (var cartItem in GetAllCartDtos())
            {
                price += cartItem.TreeUnitPrice * cartItem.Quantity;
            }
            return price;
        }

        protected void Lnk_DeleteToCart_Command(object sender, CommandEventArgs e)
        {
            var treeId = Convert.ToInt32(e.CommandArgument);

            Cart cart = new Cart();
            cart.TreeId = treeId;
            cart.UserId = Convert.ToInt32(HttpContext.Current.Session["UserId"]);
            cart.Quantity = 1;

            _cartService.CartDelete(cart);
            Response.Redirect("~/CartForm/CartPage");
        }

        protected void Lnk_Order_Click(object sender, EventArgs e)
        {
            var userCarts = GetAllCartDtos();
            var userId = Convert.ToInt32(HttpContext.Current.Session["UserId"]);
            foreach (var cartItem in userCarts)
            {
                TreeOrder treeOrder = new TreeOrder()
                {
                    TreeId = cartItem.TreeId,
                    CustomerId = _customerService.GetByUserId(userId).Data.Id,
                    Quantity = cartItem.Quantity
                };
                _treeOrderService.Add(treeOrder);

                var tree = _treeService.GetById(cartItem.TreeId).Data;
                tree.UnitsInStock -= cartItem.Quantity;
                _treeService.Update(tree);

                var cart = _cartService.GetById(cartItem.CartId).Data;
                _cartService.Delete(cart);
            }
            Response.Redirect("~/Site/Tree");
        }
    }
}