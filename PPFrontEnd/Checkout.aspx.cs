﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaProjectTesting;
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
            if (lbVoucherCode.Text == "voucher")
            {
                OrderPrice -= 5;
                lbOrderPriceDisplay.Text = OrderPrice.ToString();
            }
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
            ErrorMsg = "a"; // fix it to pizza testing
            //ErrorMsg = AddressBook.ThisAddress.Valid(txtHouseNo.Text, txtStreet.Text, txtTown.Text, txtPostCode.Text, txtDateAdded.Text);
            //if there is no error message
            if (ErrorMsg == "")
            {
                /*TEST ID*/
              //  OrderCollection.ThisOrder.OrderId = 1;
                    OrderCollection.ThisOrder.CardNumber = tbCardNumber.Text;
                    OrderCollection.ThisOrder.CardExpiryNumber = Convert.ToDateTime(tbCardExpiryDate.Text);
                    OrderCollection.ThisOrder.CardSecurityCode = tbCardSecurityCode.Text;
                    OrderCollection.ThisOrder.CustomerMobile = tbPhoneNumber.Text;
                    OrderCollection.ThisOrder.DeliveryAddress = tbAddress.Text;
                    OrderCollection.ThisOrder.Voucher = tbVoucherCode.Text;
                    OrderCollection.ThisOrder.Email = tbEmail.Text;
                    OrderCollection.ThisOrder.DeliveryPrice = Convert.ToInt32(lbOrderPriceDisplay.Text);
                OrderCollection.ThisOrder.DeliveryTime = 20.ToString();
                    OrderCollection.ThisOrder.OrderDescription = tbOrders.Text;
                    OrderCollection.Add();
                //OrderCollection.Update();
                
                
            }
            else//there are errors
            {
                //display the error message
                Response.Redirect("FailedOrder.aspx");
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

        protected void tbVoucherCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}