using PizzaClassLibrary;
using PizzaLibraryClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            lbOrderList.DataSource = clsOrderConnection.OrderList;
            lbOrderList.DataValueField = "OrderId";
            lbOrderList.DataTextField = "CardNumber";

            lbOrderList.DataTextField = "CardSecurityCode";

            lbOrderList.DataBind();

        }
    }
}