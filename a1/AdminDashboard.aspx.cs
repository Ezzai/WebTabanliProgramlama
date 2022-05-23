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
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_TreeOrders.Text = Convert.ToString(TreeOrdersCount());
            lbl_Customers.Text = Convert.ToString(CustomersCount());
            lbl_Trees.Text = Convert.ToString(TreesCount());
            lbl_TreeTypes.Text = Convert.ToString(TreeTypesCount());
        }

        ICustomerService _customerService = new CustomerManager();
        ITreeOrderService _treeOrderService = new TreeOrderManager();
        ITreeService _treeService = new TreeManager();
        ITreeTypeService _treeTypeService = new TreeTypeManager();


        // Persents
        public double TreesPersent()
        {
            double result = _treeService.GetAll().Data.Count / 10.0;
            return result;
        }

        public double TreeOrdersPersent()
        {
            double result = _treeOrderService.GetAll().Data.Count / 10.0;
            return result;
        }
        public double TreeTypesPersent()
        {
            double result = _treeTypeService.GetAll().Data.Count / 10.0;
            return result;
        }
        public double CustomersPersent()
        {
            double result = _customerService.GetAll().Data.Count / 10.0;
            return result;
        }

        // Counts

        public int TreesCount()
        {
            return _treeService.GetAll().Data.Count;
        }

        public int TreeTypesCount()
        {
            return _treeTypeService.GetAll().Data.Count;
        }

        public int CustomersCount()
        {
            return _customerService.GetAll().Data.Count;
        }

        public int TreeOrdersCount()
        {
            return _treeOrderService.GetAll().Data.Count;
        }


        // GetAlls
        public List<Tree> TreesGetAll()
        {
            return _treeService.GetAll().Data;
        }
        public List<TreeType> TreeTypesGetAll()
        {
            return _treeTypeService.GetAll().Data;
        }

       
    }
}