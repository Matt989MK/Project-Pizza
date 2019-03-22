using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPFrontEnd
{
    public partial class Menu : System.Web.UI.Page
    {
       public static List<string> shoppingList = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
           // going through the shopping list and adding each item to the current order
            foreach(var item in shoppingList)
            {
                tbCurrentOrder.Text += item;
            }
            //display current amount of items in the basket
            lbProductsInBasket.Text = shoppingList.Count().ToString();
        }
        
        protected void btCheckout_Click(object sender, EventArgs e)
        {
            //redirect to the checkout with the parameters of the order
            HyperLink1.Target = "Checkout.aspx"+"?";
            Response.Redirect("Checkout.aspx",false);
        
        }

        protected void btPizza1Add_Click(object sender, EventArgs e)
        {
            //Adding "Pizza 1" product
            shoppingList.Add("Pizza 1");
            tbCurrentOrder.Text = "";
            //foreach item add it to the text with a new line
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item +Environment.NewLine;
            }
            //display amount of items in the lbProductsInBasket
            lbProductsInBasket.Text = shoppingList.Count().ToString();
            //give parameters to the Checkount, will go to the next page and transfer the parameters
            HyperLink1.NavigateUrl = "Checkout.aspx" + "?"+"tbCurrentOrder="+tbCurrentOrder.Text;

        }

        protected void btPizza2Add_Click(object sender, EventArgs e)
        {
            //Adding "Pizza 2" product
            shoppingList.Add("Pizza 2");
            //
            tbCurrentOrder.Text = "";
            //foreach item add it to the text with a new line
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item + Environment.NewLine;
            }
            //display amount of items in the lbProductsInBasket
            lbProductsInBasket.Text = shoppingList.Count().ToString();
            //give parameters to the Checkount, will go to the next page and transfer the parameters
            HyperLink1.NavigateUrl = "Checkout.aspx" + "?" + "tbCurrentOrder=" + tbCurrentOrder.Text;

        }

        protected void btPizza3Add_Click(object sender, EventArgs e)
        {
            //Adding "Pizza 3" product
            shoppingList.Add("Pizza 3");
            tbCurrentOrder.Text = "";
            //foreach item add it to the text with a new line
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item + Environment.NewLine;
            }
            //display amount of items in the lbProductsInBasket
            lbProductsInBasket.Text = shoppingList.Count().ToString();
            //give parameters to the Checkount, will go to the next page and transfer the parameters
            HyperLink1.NavigateUrl = "Checkout.aspx" + "?" + "tbCurrentOrder=" + tbCurrentOrder.Text;

        }

        protected void btPizza1Remove_Click(object sender, EventArgs e)
        {
            //remove "Pizza 1"
            shoppingList.Remove("Pizza 1");
            tbCurrentOrder.Text = "";
            //foreach item add it to the text with a new line
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item + Environment.NewLine;
            }
            //display amount of items in the lbProductsInBasket
            lbProductsInBasket.Text = shoppingList.Count().ToString();
            //give parameters to the Checkount, will go to the next page and transfer the parameters
            HyperLink1.NavigateUrl = "Checkout.aspx" + "?" + "tbCurrentOrder=" + tbCurrentOrder.Text;

        }

        protected void btPizza2Remove_Click(object sender, EventArgs e)
        {
            //remove "Pizza 2"
            shoppingList.Remove("Pizza 2");
            tbCurrentOrder.Text = "";
            //foreach item add it to the text with a new line
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item + Environment.NewLine;
            }
            //display amount of items in the lbProductsInBasket
            lbProductsInBasket.Text = shoppingList.Count().ToString();
            //give parameters to the Checkount, will go to the next page and transfer the parameters
            HyperLink1.NavigateUrl = "Checkout.aspx" + "?" + "tbCurrentOrder=" + tbCurrentOrder.Text;

        }

        protected void btPizza3Remove_Click(object sender, EventArgs e)
        {
            //remove "Pizza 3"
            shoppingList.Remove("Pizza 3");
            tbCurrentOrder.Text = "";
            //foreach item add it to the text with a new line
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item + Environment.NewLine;
            }
            //display amount of items in the lbProductsInBasket
            lbProductsInBasket.Text = shoppingList.Count().ToString();
            //give parameters to the Checkount, will go to the next page and transfer the parameters
            HyperLink1.NavigateUrl = "Checkout.aspx" + "?" + "tbCurrentOrder=" + tbCurrentOrder.Text;

        }
    }
}