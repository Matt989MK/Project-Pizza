using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaLibraryClass;
using PizzaProjectTesting;
namespace PPFrontEnd
{
    public partial class Checkout : System.Web.UI.Page
    {
        //initialise orderId
        Int32 OrderId;
        //initialise OrderPrice
        Int32 OrderPrice = 0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //getting parametere from previous table with the orders and getting 
            string br = Request.Params["tbCurrentOrder"];
           
            for (int i = 0; i < br.Length; i++)
            {
                //tbOrders text adds to the orders from previous table from Menu.aspx
                tbOrders.Text += br[i];
                //if the product is Pizza '1' add 10 to the price
                if (br[i]=='1') {  tbOrders.Text +=Environment.NewLine; OrderPrice += 10; }
                //if the product is Pizza '2' add 15 to the price
                if (br[i]=='2') { tbOrders.Text += Environment.NewLine; OrderPrice += 15; }
                //if the product is Pizza '3' add 20 to the price
                if (br[i]=='3') { tbOrders.Text += Environment.NewLine; OrderPrice += 20; }
                //display the total price on the lbOrderPriceDisplay
                lbOrderPriceDisplay.Text = OrderPrice.ToString();
            }
           //getting the orders from the previous page
         OrderId= Convert.ToInt32(Session["OrderId"]);
        }

        protected void btBack_Click(object sender, EventArgs e)
        {
            //redirect to homepage
            Response.Redirect("Homepage.aspx");
        }

        protected void btApplyVoucher_Click(object sender, EventArgs e)
        {
            // validate voucher and apply it
            if (lbVoucherCode.Text == "voucher")
            {
                //if lbVoucherCode =="voucher" get the price down by 5
                OrderPrice -= 5;
                //assignt price to the text
                lbOrderPriceDisplay.Text = OrderPrice.ToString();
            }
        }

        protected void btAddToOrder_Click(object sender, EventArgs e)
        {
            //redirect to menu
            Response.Redirect("Menu.aspx");
        }

        protected void btRemoveFromOrderList_Click(object sender, EventArgs e)
        {
            // remove product from order list
        }

        protected void btOrder_Click(object sender, EventArgs e)
        {
            //var to store any error messages
            string ErrorMsg="s";
            //create an instance of the address class
                clsOrderCollection OrderCollection = new clsOrderCollection();

            //use the objects validation method to test the data
           
           // ErrorMsg = OrderCollection.ThisOrder.Valid(tbCardNumber.Text,tbCardSecurityCode.Text,Convert.ToDateTime(tbCardExpiryDate),tbPhoneNumber.Text,tbAddress.Text,Convert.ToInt32(lbDeliveryTime.Text),"1",Convert.ToInt32(lbOrderPriceDisplay.Text),tbVoucherCode.Text);
          
            //if there is no error message
            if (ErrorMsg == "")
            {
               //assign CardNumber to the textbox
                    OrderCollection.ThisOrder.CardNumber = tbCardNumber.Text;
                //assign CardExpiryNumber to the textbox
                OrderCollection.ThisOrder.CardExpiryNumber = Convert.ToDateTime(tbCardExpiryDate.Text);
                //assign CardSecurityCode to the textbox
                OrderCollection.ThisOrder.CardSecurityCode = tbCardSecurityCode.Text;
                //assign CustomerMobile to the textbox
                OrderCollection.ThisOrder.CustomerMobile = tbPhoneNumber.Text;
                //assign DeliveryAddress to the textbox
                OrderCollection.ThisOrder.DeliveryAddress = tbAddress.Text;
                //assign Voucher to the textbox
                OrderCollection.ThisOrder.Voucher = tbVoucherCode.Text;
                //assign Email to the textbox
                OrderCollection.ThisOrder.Email = tbEmail.Text;
                //assign DeliveryPrice to the textbox
                OrderCollection.ThisOrder.DeliveryPrice = Convert.ToInt32(lbOrderPriceDisplay.Text);
                //assign DeliveryTime to the textbox
                OrderCollection.ThisOrder.DeliveryTime = 20.ToString();
                //assign OrderDescription to the textbox
                OrderCollection.ThisOrder.OrderDescription = tbOrders.Text;
                //Calling the Add function
                    OrderCollection.Add();     
                
            }
            else//there are errors
            {
                // GO to failed order page
                Response.Redirect("FailedOrder.aspx");
            }
            Response.Redirect("SuccessfulOrder.aspx");
            //Response.Redirect("GO to SuccessfulOrder.aspx");
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

        protected void tbVoucherCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}