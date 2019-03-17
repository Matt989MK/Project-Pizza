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
           // shoppingList.Add("Pizza");
            foreach(var item in shoppingList)
            {
                tbCurrentOrder.Text += item;
            }
            lbProductsInBasket.Text = shoppingList.Count().ToString();
        }
        
        protected void btCheckout_Click(object sender, EventArgs e)
        {
          
        }

        protected void btPizza1Add_Click(object sender, EventArgs e)
        {
            shoppingList.Add("Pizza 1");
            tbCurrentOrder.Text = "";
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item +Environment.NewLine;
            }
            lbProductsInBasket.Text = shoppingList.Count().ToString();

        }

        protected void btPizza2Add_Click(object sender, EventArgs e)
        {
            shoppingList.Add("Pizza 2");
            tbCurrentOrder.Text = "";
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item + Environment.NewLine;
            }
            lbProductsInBasket.Text = shoppingList.Count().ToString();
        }

        protected void btPizza3Add_Click(object sender, EventArgs e)
        {
            shoppingList.Add("Pizza 3");
            tbCurrentOrder.Text = "";
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item + Environment.NewLine;
            }
            lbProductsInBasket.Text = shoppingList.Count().ToString();
        }

        protected void btPizza1Remove_Click(object sender, EventArgs e)
        {
            shoppingList.Remove("Pizza 1");
            tbCurrentOrder.Text = "";
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item + Environment.NewLine;
            }
            lbProductsInBasket.Text = shoppingList.Count().ToString();
        }

        protected void btPizza2Remove_Click(object sender, EventArgs e)
        {
            shoppingList.Remove("Pizza 2");
            tbCurrentOrder.Text = "";
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item + Environment.NewLine;
            }
            lbProductsInBasket.Text = shoppingList.Count().ToString();

        }

        protected void btPizza3Remove_Click(object sender, EventArgs e)
        {
            shoppingList.Remove("Pizza 3");
            tbCurrentOrder.Text = "";
            foreach (var item in shoppingList)
            {
                tbCurrentOrder.Text += item + Environment.NewLine;
            }
            lbProductsInBasket.Text = shoppingList.Count().ToString();

        }
    }
}