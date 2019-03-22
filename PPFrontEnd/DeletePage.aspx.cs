using PizzaLibraryClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPFrontEnd
{
    public partial class DeletePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btDelete_Click(object sender, EventArgs e)
        {
            Int32 OrderId = 0;
            if (lstDeleteRecord.SelectedIndex!= -1)
            {
                OrderId = Convert.ToInt32(lstDeleteRecord.SelectedValue);
                Session["OrderId"] = OrderId;
                clsOrderCollection clsOrderCollection = new clsOrderCollection();
                clsOrderCollection.ThisOrder.FindID(OrderId);
                clsOrderCollection.Delete();
                lbError.Text = "Deleted record";

            }
            else
            {
                lbError.Text = "Please select appropriate orderId";
            }
           
        }

        protected void btBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminOrderDisplay.aspx");
        }
    }
}