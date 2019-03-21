using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPFrontEnd
{
    public partial class PizzaProject : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnStaff_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Staff.aspx");
        }

        protected void btnHomepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");

        }

    }
}