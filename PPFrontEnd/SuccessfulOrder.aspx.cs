using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPFrontEnd
{
    public partial class SuccessfulOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btHomepage_Click(object sender, EventArgs e)
        {
            //Redirect to homepage
            Response.Redirect("Homepage.aspx");
        }
    }
}