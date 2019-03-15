using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace PPFrontEnd
{
    public partial class Checkout : System.Web.UI.Page
    {
        Int32 OrderId;

        protected void Page_Load(object sender, EventArgs e)
        {
            OrderId = Convert.ToInt32(Session["OrderId"]);
        }

        protected void btBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Homepage.aspx");
        }

        protected void btApplyVoucher_Click(object sender, EventArgs e)
        {
            // validate voucher and apply it
        }

        protected void btAddToOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btRemoveFromOrderList_Click(object sender, EventArgs e)
        {
            // remove product from order list
        }

        protected void btOrder_Click(object sender, EventArgs e)
        {
            //var to store any error messages
            string ErrorMsg="";
            
            App_Code.clsOrderCollection Orders = new App_Code.clsOrderCollection();
          
            // ErrorMsg=clsOrderCollection.ThisOrder.Valid
            if (ErrorMsg == "")
            {
                if (OrderId == -1)
                {
                   
                    Orders.ThisOrder.CardExpiryDate = tbCardExpiryDate.Text;
                    Orders.ThisOrder.CardSecurityCode = tbCardSecurityCode.Text;
                    Orders.ThisOrder.CardNumber = tbCardNumber.Text;
                    Orders.ThisOrder.CustomerAddress = tbAddress.Text;
                    Orders.ThisOrder.MobilePhone = tbPhoneNumber.Text;
                    Orders.ThisOrder.Voucher = tbVoucherCode.Text;
                    Orders.ThisOrder.Email = tbEmail.Text;//add this to clsOrderCollection Add/Update/Delete

                }
            }
            Response.Redirect("SuccessfulOrder.aspx");
            //Response.Redirect("FailedOrder.aspx");
        }

        protected void tbCardExpiryDate_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}