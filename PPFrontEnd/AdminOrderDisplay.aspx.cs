using PizzaClassLibrary;
using PizzaLibraryClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPFrontEnd
{
    public partial class AdminOrderDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //load all the records 
       //finish this bit and add delete

        
         
        }

        protected void tbDisplayRecords_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btGetRecords_Click(object sender, EventArgs e)
        {
            clsOrderCollection clsOrderConnection = new clsOrderCollection();
            lbOrderList.Text = clsOrderConnection.SelectAll().ToString();

            List<clsOrder> orderList = new List<clsOrder>();
            orderList = clsOrderConnection.OrderList;
            foreach (var item in orderList)
            {
                lbOrderList.Text += item;
            }
        }
    }
}