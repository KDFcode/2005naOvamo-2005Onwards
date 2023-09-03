using _2005naOvamo.NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2005naOvamo
{
    public partial class AllProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductsTableAdapter productsAdapter = new
            ProductsTableAdapter();
            GridView1.DataSource = productsAdapter.GetProducts();
            GridView1.DataBind();
        }
    }
}