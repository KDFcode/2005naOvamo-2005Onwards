using _2005naOvamo.NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//using NorthwindTableAdapters; //sto ovo zeza?

namespace _2005naOvamo
{
    public partial class Beverages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductsTableAdapter productsAdapter = new
              ProductsTableAdapter();
            GridView1.DataSource =
              productsAdapter.GetProductsByCategoryID(1);
            GridView1.DataBind();
        }
    }
}