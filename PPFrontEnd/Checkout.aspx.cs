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
        Int32 OrderId;
        Int32 OrderPrice = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string br = Request.Params["tbCurrentOrder"];
           
            for (int i = 0; i < br.Length; i++)
            {
                tbOrders.Text += br[i];
                if (br[i]=='1') {  tbOrders.Text +=Environment.NewLine; OrderPrice += 10; }
                if (br[i]=='2') { tbOrders.Text += Environment.NewLine; OrderPrice += 15; }
                if (br[i]=='3') { tbOrders.Text += Environment.NewLine; OrderPrice += 20; }
                lbOrderPriceDisplay.Text = OrderPrice.ToString();
            }
           
         OrderId= Convert.ToInt32(Session["OrderId"]);
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
            //create an instance of the address class
                clsOrderCollection OrderCollection = new clsOrderCollection();
            //use the objects validation method to test the data
            //ErrorMsg = AddressBook.ThisAddress.Valid(txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtPostCode.Text, txtDateAdded.Text);
            //if there is no error message
            if (ErrorMsg == "")
            {
                
                    OrderCollection.ThisOrder.CardNumber = tbCardNumber.Text;
                    OrderCollection.ThisOrder.CardExpiryDate = Convert.ToDateTime(tbCardExpiryDate.Text);
                    OrderCollection.ThisOrder.CardSecurityNumber = tbCardSecurityCode.Text;
                    OrderCollection.ThisOrder.MobilePhone = tbPhoneNumber.Text;
                    OrderCollection.ThisOrder.CustomerAddress = tbAddress.Text;
                    OrderCollection.ThisOrder.Voucher = tbVoucherCode.Text;
                    OrderCollection.ThisOrder.Email = tbEmail.Text;
                    OrderCollection.ThisOrder.DeliveryPrice = Convert.ToInt32(lbOrderPriceDisplay.Text);
                    OrderCollection.ThisOrder.OrderDescription = tbOrders.Text;
                    OrderCollection.Add();
                
                
            }
            else//there are errors
            {
                //display the error message
               // MessageBox.show(ErrorMsg);
            }
            Response.Redirect("SuccessfulOrder.aspx");
            //Response.Redirect("FailedOrder.aspx");
        }

        protected void tbCardExpiryDate_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}