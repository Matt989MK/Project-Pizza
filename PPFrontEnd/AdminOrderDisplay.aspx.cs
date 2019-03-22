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
            //createa and instance of clsOrderCollection
            clsOrderCollection clsOrderConnection = new clsOrderCollection();
            //set datasource to clsOrderConnection OrderList
            lbOrderList.DataSource = clsOrderConnection.OrderList;
            //set paraemters to OrderId and display it
            lbOrderList.DataTextField = "OrderId";
            lbOrderList.DataValueField = "OrderId";

            lbOrderList.DataTextField = "CardNumber";
            lbOrderList.DataValueField = "CardNumber";
            lbOrderList.DataTextField = "CardSecurityCode";
            lbOrderList.DataValueField = "CardSecurityCode";
            lbOrderList.DataTextField = "CardExpiryNumber";
            lbOrderList.DataValueField = "CardExpiryNumber";

            lbOrderList.DataTextField = "DeliveryAddress";
            //lbOrderList.DataTextField = "CustomerMobile";
            //lbOrderList.DataTextField = "Email";
            //lbOrderList.DataTextField = "Voucher";
            //lbOrderList.DataTextField = "OrderDescription";


            lbOrderList.DataBind();

        }
    }
}