using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPFrontEnd
{
     internal class  clsOrderCollection
    {
        private clsDataConnection dbConnection=new clsDataConnection();
        private  clsOrder mThisOrder = new clsOrder();

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
           // NewOrder.AddParameter("@OrderId", mThisOrder.OrderId);
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
            //add the email parameter
            NewOrder.AddParameter("@Email", mThisOrder.Email);
            //add the Voucher parameter
            NewOrder.AddParameter("@Voucher", mThisOrder.Voucher);
            //add the DeliveryTime parameter
            NewOrder.AddParameter("@DeliveryTime", mThisOrder.DeliveryTime);
            //add the DeliveryPrice parameter
            NewOrder.AddParameter("@DeliveryPrice", mThisOrder.DeliveryPrice);
            //add the OrderDescription parameter
            NewOrder.AddParameter("@OrderDescription", mThisOrder.OrderDescription);

            //execute the query to add the record - it will return the primary key value of the new record
            PrimaryKey = NewOrder.Execute("sproc_tblOrder_Insert");
            //return the primary key value of the new record
            return PrimaryKey;
        }
        //function for the public Update method
        public void Update()
        {
            //this function updates an existing record specified by the class level variable addressNo
            //it returns no value

            //create a connection to the database
            clsDataConnection NewOrder = new clsDataConnection();
            NewOrder.AddParameter("@OrderId", mThisOrder.OrderId);
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
            //add the email parameter
            NewOrder.AddParameter("@Email", mThisOrder.Email);
            //add the Voucher parameter
            NewOrder.AddParameter("@Voucher", mThisOrder.Voucher);
            //add the DeliveryTime parameter
            NewOrder.AddParameter("@DeliveryTime", mThisOrder.DeliveryTime);
            //add the DeliveryPrice parameter
            NewOrder.AddParameter("@DeliveryPrice", mThisOrder.DeliveryPrice);
            //add the OrderDescription parameter
            NewOrder.AddParameter("@OrderDescription", mThisOrder.OrderDescription);
            //execute the query
            NewOrder.Execute("sproc_tblOrder_Update");
        }
        public void Delete()
        ///it is a void function and returns no value
        {
            //initialise the DBConnection
            clsDataConnection dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute the stored procedure to delete the address
            dBConnection.Execute("sproc_tblOrder_Delete");
        }
        ///this function defines the FilterByPostCode method
        public void FilterByOrderId(string OrderId)
        ///it accepts a single parameter PostCode and returns no value
        {
            //initialise the DBConnection
            clsDataConnection dBConnection = new clsDataConnection();
            //add the parameter data used by the stored procedure
            dBConnection.AddParameter("@OrderId", OrderId);
            //execute the stored procedure to delete the address
            dBConnection.Execute("sproc_tblOrder_FilterByOrderId");
        }
        ///this function defines the public property Count
        public Int32 Count
        ///it returns the count of records currently in QueryResults
        {
            get
            {
                clsDataConnection dBConnection = new clsDataConnection();

                //return the count of records
                return dBConnection.Count;
            }
        }

        public List<clsOrder> OrderList
        {
            get
            {
                clsDataConnection dBConnection = new clsDataConnection();
                List<clsOrder> mOrderList = new List<clsOrder>();
                Int32 Index = 0;
                while (Index < dBConnection.Count)
                {
                    clsOrder NewOrder = new clsOrder();
                    //get the house no from the query results
                    NewOrder.CardNumber = Convert.ToString(dBConnection.DataTable.Rows[Index]["CardNumber"]);
                    //get the street from the query results
                    NewOrder.CardSecurityNumber = Convert.ToString(dBConnection.DataTable.Rows[Index]["CardSecurityNumber"]);
                    //get the post code from the query results
                    NewOrder.CardExpiryDate = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["CardExpiryDate"]);
                    //get the address no from the query results
                    NewOrder.CustomerAddress = Convert.ToString(dBConnection.DataTable.Rows[Index]["CustomerAddress"]);
                    //get the address no from the query results
                    NewOrder.MobilePhone = Convert.ToString(dBConnection.DataTable.Rows[Index]["MobilePhone"]);
                    //get the address no from the query results
                    NewOrder.MobilePhone = Convert.ToString(dBConnection.DataTable.Rows[Index]["Email"]);
                    //get the address no from the query results
                    NewOrder.Voucher = Convert.ToString(dBConnection.DataTable.Rows[Index]["Voucher"]);
                    //get the address no from the query results
                    NewOrder.DeliveryTime = Convert.ToString(dBConnection.DataTable.Rows[Index]["DeliveryTime"]);
                    //get the address no from the query results
                    NewOrder.DeliveryPrice = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["DeliveryPrice"]);
                    //get the address no from the query results
                    NewOrder.OrderDescription = Convert.ToString(dBConnection.DataTable.Rows[Index]["OrderDescription"]);
                    //increment the index
                    Index++;
                    //add the address to the list
                    mOrderList.Add(NewOrder);
                }
                //return the list of addresses
                return mOrderList;
            }
        }
    }
}