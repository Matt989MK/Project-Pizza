using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPFrontEnd
{
    public partial class OrderAdmin : System.Web.UI.Page
    {
        //var to store the address number
        Int32 OrderId;

        //event handler for the page load event
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the address no from the session object
            OrderId = Convert.ToInt32(Session["OrderId"]);
            //if this is the first time the page has loaded
            if (IsPostBack == false)
            {
                //populate the orders drop down
                //DisplayOrders();
                //if we are not adding a new record
                if (OrderId != -1)
                {
                    //update the fields on the page with the data from the record
                    Console.WriteLine("There are no orders");
                }
                
            }
        }
    }
}