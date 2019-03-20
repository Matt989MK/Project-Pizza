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
            clsOrderCollection clsOrderConnection = new clsOrderCollection();
            //load all the records 
       //finish this bit and add delete
            clsOrderConnection.SelectAll();

            foreach (var item in clsOrderConnection.OrderList)
            {
                tbDisplayRecords.Text += item.MobilePhone;
            }
         
        }

        protected void tbDisplayRecords_TextChanged(object sender, EventArgs e)
        {

        }
    }
}