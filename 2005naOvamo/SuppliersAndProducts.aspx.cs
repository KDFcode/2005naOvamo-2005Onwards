using _2005naOvamo.NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _2005naOvamo.NorthwindTableAdapters;

namespace _2005naOvamo
{
    public partial class SuppliersAndProducts : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            SuppliersTableAdapter suppliersAdapter = new
              SuppliersTableAdapter();
            GridView1.DataSource = suppliersAdapter.GetSuppliers(); //na koju foru ga ne vidi?
            GridView1.DataBind();//GridView1 stoji u elementu lepo ID,
        }
    }
}