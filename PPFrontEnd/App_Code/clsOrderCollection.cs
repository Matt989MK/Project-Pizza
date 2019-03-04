using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPFrontEnd.App_Code
{
    public class clsOrderCollection
    {
        clsDataConnection dbConnection;
        clsOrder mThisOrder = new clsOrder();

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        public Int32 Add()
        {
            Int32 PrimaryKey;
            //create a connection to the database
            clsDataConnection NewOrder = new clsDataConnection();
            //add the CardNumber parameter
            NewOrder.AddParameter("@CardNumber", mThisOrder.CardNumber);
            //add the CardSecurityNumber parameter
            NewOrder.AddParameter("@CardSecurityNumber", mThisOrder.CardSecurityNumber);
            //add the CardExpiryDate parameter
            NewOrder.AddParameter("@CardExpiryDate", mThisOrder.CardExpiryDate);
            //add the CustomerAddress parameter
            NewOrder.AddParameter("@CustomerAddress", mThisOrder.CustomerAddress);
            //add the MobilePhone parameter
            NewOrder.AddParameter("@MobilePhone", mThisOrder.MobilePhone);
            //add the Voucher parameter
            NewOrder.AddParameter("@Voucher", mThisOrder.Voucher);
            //add the DeliveryTime parameter
            NewOrder.AddParameter("@DeliveryTime", mThisOrder.DeliveryTime);
            //add the DeliveryPrice parameter
            NewOrder.AddParameter("@DeliveryPrice", mThisOrder.DeliveryPrice);
            //add the OrderDescription parameter
            NewOrder.AddParameter("@OrderDescription", mThisOrder.OrderDescription);

            //execute the query to add the record - it will return the primary key value of the new record
            PrimaryKey = NewOrder.Execute("sproc_tblAddress_Insert");
            //return the primary key value of the new record
            return PrimaryKey;
        }
    }
}