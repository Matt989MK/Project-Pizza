using System;

namespace MyTesting_Customer
{
    public class clsCustomer
    {
        private string mAddress;
        private string mEmailAddress;
        private string mFirstName;
        private string mLastName;
        private string mPhoneNo;
        private Int32 mCustomerID;

        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }
        public string EmailAddress
        {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }

        public string PhoneNo
        {
            get
            {
                return mPhoneNo;
            }
            set
            {
                mPhoneNo = value;
            }
        }

        public bool Find (int CustomerID)
        {
            
            
                //// create an instance of the data connection
                ////clsDataConnection DB = new clsDataConnection
                //// add the parameter for the address no to search for 
                ////DB.Execute("@CustomerId", CustomerID);
                ////execute the stored procedure 
                //DB.Execute("sproc_tblCustomer_FilterByCustomerId");
                ////if one record is found (there should be either one or zero!)
                //if (DB.Count == 1)
                //{
                //    //copt the data from the database to the private data members
                //    mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                //    mAddress = Convert.ToInt32(DB.DataTable.Rows[0]["Address"]);
                //    mFirstName = Convert.ToInt32(DB.DataTable.Rows[0]["FirstName"]);
                //    mLastName = Convert.ToInt32(DB.DataTable.Rows[0]["LastName"]);
                //    mEmailAddress = Convert.ToInt32(DB.DataTable.Rows[0]["EmailAddress"]);
                //    mPhoneNo = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNo"]);
                //}
                ////if no record was found
                //else
                //{
                //    //return false indicating a problem
                //    return false;
                //}
            mCustomerID = 1;
            mAddress = "15 street";
            mFirstName = "John";
            mLastName = "Sab";
            mEmailAddress = "JohnSab@hotmail.com";
            mPhoneNo = "7755886644";
            return true;
            
        }

        internal string Valid()
        {
            throw new NotImplementedException();
        }


        internal string Valid(int customerID, Action firstName, Action lastName, Action address, Action emailAddress, Action phoneNo)
        {
            return "";
        }

        internal string Valid(int customerID, Action firstName, Action lastName, string address, Action emailAddress, Action phoneNo)
        {
            string Error = "";
            if (address.Length == 0)
            {
                Error = Error + "The may not be blank: ";
            }
            return Error;
        }

        internal string Valid(int customerID, Action firstName, Action lastName, Action address, string emailAddress, Action phoneNo)
        {
            string Error = "";
            if (emailAddress.Length == 0)
            {
                Error = Error + "The EmailAdress may not be blank:";
            }
           
            if (emailAddress.Length > 6)
            {
                Error = Error + "The EmailAdress may not be more than 50 characters:";
            }
            return Error;

        }

        internal string Valid(int customerID, string firstName, Action lastName, Action address, Action emailAddress, Action phoneNo)
        {
            string Error = "";
            if (firstName.Length == 0)
            {
                Error = Error + "The firstname may not be blank:";
            }

            if (firstName.Length > 6)
            {
                Error = Error + "The firstname may not be more than 50 characters:";
            }
            else if (firstName.Length < 1)
            {
                Error = Error + "The firstname may not be single alphabet:";
            }
            return Error;

        }

        internal string Valid(int customerID, Action firstName, string lastName, Action address, Action emailAddress, Action phoneNo)
        {
            string Error = "";
            if (lastName.Length == 0)
            {
                Error = Error + "The lastname may not be blank:";
            }

            if (lastName.Length > 6)
            {
                Error = Error + "The lastname may not be more than 50 characters:";
            }
            else if (lastName.Length < 1)
            {
                Error = Error + "The lastname may not be single alphabet:";
            }
            return Error;
        }

        internal string Valid(int customerID, Action firstName, Action lastName, Action address, Action emailAddress, string phoneNo)
        {
            String Error = "";
            if (phoneNo.Length > 11)
            {
                Error = Error +  "PhoneNo must be 10 digit : ";
            }
            return Error;
        }
    }

}