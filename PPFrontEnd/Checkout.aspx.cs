using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PPFrontEnd.App_Code;
namespace PPFrontEnd
{
    public partial class Checkout : System.Web.UI.Page
    {
        
      
        protected void Page_Load(object sender, EventArgs e)
        {
            
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
            
            clsOrderCollection OrderCollection = new clsOrderCollection();
            OrderCollection.ThisOrder.CardNumber= tbCardNumber.Text;
            OrderCollection.ThisOrder.CardExpiryDate =Convert.ToDateTime(tbCardExpiryDate.Text);
            OrderCollection.ThisOrder.CardSecurityNumber = tbCardSecurityCode.Text;
            OrderCollection.ThisOrder.MobilePhone = tbPhoneNumber.Text;
            OrderCollection.ThisOrder.CustomerAddress = tbAddress.Text;
            OrderCollection.ThisOrder.Voucher = tbVoucherCode.Text;
            OrderCollection.ThisOrder.Email = tbEmail.Text;

            Response.Redirect("SuccessfulOrder.aspx");
            //Response.Redirect("FailedOrder.aspx");
        }

        protected void tbCardExpiryDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}