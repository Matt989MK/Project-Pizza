using PizzaClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLibraryClass
{
    public class clsOrderCollection
    {
        //Creating database connection
        private clsDataConnection dbConnection = new clsDataConnection();
        private clsOrder mThisOrder = new clsOrder();
        List<clsOrder> mOrderList = new List<clsOrder>();
        //this is list of all the orders, instantion of class clsOrder
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        //this is a constructor
        public clsOrderCollection()
        {
           //creating the database instantion
            clsDataConnection DB = new clsDataConnection();
            //executing the select procedure
            DB.Execute("sproc_tblOrder_Select");
            //calling the method to populate the listBox with parameter Orders.mdf
            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection DB)
        {
            //index variable to go through records
            Int32 Index = 0;
            //amount of records in the database
            Int32 RecordCount = DB.Count;
            //assigning mOrderList to a list of clsOrder
            mOrderList = new List<clsOrder>();
            while( Index < RecordCount)
            {
                clsOrder NewOrder = new clsOrder();
                //get the CardNumber from the query results
                NewOrder.CardNumber = Convert.ToString(DB.DataTable.Rows[Index]["CardNumber"]);
                //get the CardSecurityNumber from the query results
                NewOrder.CardSecurityCode = Convert.ToString(DB.DataTable.Rows[Index]["CardSecurityNumber"]);
                //get the CardExpiryDate from the query results
                NewOrder.CardExpiryNumber = Convert.ToDateTime(DB.DataTable.Rows[Index]["CardExpiryDate"]);
                //get the CustomerAddress from the query results
                NewOrder.DeliveryAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                //get the MobilePhone from the query results
                NewOrder.CustomerMobile = Convert.ToString(DB.DataTable.Rows[Index]["MobilePhone"]);
                //get the Email from the query results
                NewOrder.CustomerMobile = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                //get the Voucher from the query results
                NewOrder.Voucher = Convert.ToString(DB.DataTable.Rows[Index]["Voucher"]);
                //get the DeliveryTime from the query results
                NewOrder.DeliveryTime = Convert.ToString(DB.DataTable.Rows[Index]["DeliveryTime"]);
                //get the DeliveryPrice from the query results
                NewOrder.DeliveryPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["DeliveryPrice"]);
                //get the OrderDescription from the query results
                NewOrder.OrderDescription = Convert.ToString(DB.DataTable.Rows[Index]["OrderDescription"]);
                //add the order to the list
                mOrderList.Add(NewOrder);
                //increment the index
                Index++;

            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
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
            NewOrder.AddParameter("@CardSecurityNumber", mThisOrder.CardSecurityCode);
            //add the CardExpiryDate parameter
            NewOrder.AddParameter("@CardExpiryDate", mThisOrder.CardExpiryNumber);
            //add the CustomerAddress parameter
            NewOrder.AddParameter("@CustomerAddress", mThisOrder.DeliveryAddress);
            //add the MobilePhone parameter
            NewOrder.AddParameter("@MobilePhone", mThisOrder.CustomerMobile);
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
            NewOrder.AddParameter("@CardSecurityNumber", mThisOrder.CardSecurityCode);
            //add the CardExpiryDate parameter
            NewOrder.AddParameter("@CardExpiryDate", mThisOrder.CardExpiryNumber);
            //add the CustomerAddress parameter
            NewOrder.AddParameter("@CustomerAddress", mThisOrder.DeliveryAddress);
            //add the MobilePhone parameter
            NewOrder.AddParameter("@MobilePhone", mThisOrder.CustomerMobile);
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

      
    }
}

