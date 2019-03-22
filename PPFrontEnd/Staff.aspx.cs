using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPFrontEnd
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //event handler for the add button
        protected void btnAddStaff_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record
            Session["StaffNo"] = -1;
            //redirect the user to the data entry page
            Response.Redirect("AddStaff.aspx");
        }

        protected void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            //redirect the user to the data entry page
            Response.Redirect(".aspx");
        }
    }
}