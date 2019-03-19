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

       
            mCustomerID = 1;
            mAddress = "15 street";
            mFirstName = "John";
            mLastName = "Sab";
            mEmailAddress = "JohnSab@hotmail.com";
            mPhoneNo = "7755886644";
            return true;
            
        }
    }

}