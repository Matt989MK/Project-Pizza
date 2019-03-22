using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaClassLibrary
{
    public class clsOrder
    {
        private string mCardNumber;
        public string CardNumber
        {
            get
            {
                //return the private data
                 return mCardNumber;
            }
            set
            {
                //set the private data
                mCardNumber = value;
            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the private data
                mEmail = value;
            }
        }
        private int mOrderNo;
        public int OrderId
        {
            get
            {
                //return the private data
                return mOrderNo;
            }
            set
            {
                //set the private data
                mOrderNo = value;
            }
        }
        private string mCardSecurityCode;
        public string CardSecurityCode
        {
            get
            {
                //return the private data
                return mCardSecurityCode;
            }
            set
            {
                //set the private data
                mCardSecurityCode = value;
            }
        }
        private DateTime mCardExpiryNumber;
        public DateTime CardExpiryNumber
        {
            get
            {
                //return the private data
                return mCardExpiryNumber;
            }
            set
            {
                //set the private data
                mCardExpiryNumber = value;
            }
        }
        private string mDeliveryAddress;
        public string DeliveryAddress
        {
            get
            {
                //return the private data
                return mDeliveryAddress;
            }
            set
            {
                //set the private data
                mDeliveryAddress = value;
            }
        }
        private string mCustomerMobile;
        public string CustomerMobile
        {
            get
            {
                //return the private data
                return mCustomerMobile;
            }
            set
            {
                //set the private data
                mCustomerMobile = value;
            }
        }
        private string mVoucher;
        public string Voucher
        {
            get
            {
                //return the private data
                return mVoucher;
            }
            set
            {
                //set the private data
                mVoucher = value;
            }
        }
        private string mDeliveryTime;
        public string DeliveryTime
        {
            get
            {
                //return the private data
                return mDeliveryTime;
            }
            set
            {
                //set the private data
                mDeliveryTime = value;
            }
        }
        private int mDeliveryPrice;
        public int DeliveryPrice
        {
            get
            {
                //return the private data
                return mDeliveryPrice;
            }
            set
            {
                //set the private data
                mDeliveryPrice = value;
            }
        }
        private string mOrderDescription;
        public string OrderDescription
        {
            get
            {
                //return the private data
                return mOrderDescription;
            }
            set
            {
                //set the private data
                mOrderDescription = value;
            }
        }
        private int mPrice;
        public int Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }
        private string mCustomerId;
        public string CustomerId {
            get
            {
                //return the private data
                return mCustomerId;
            }
            set
            {
                //set the private data
                mCustomerId = value;
            } }

        public int FindID(int ID) // cant be letters
        {
            //checking if the id is not empty
            if (ID !=-1)
            {
                OrderId = ID;
                return OrderId;
            }
            else
                //if it is return error
                return 0;
        }
        public string Valid(string cardNumber, string cardSecurityCode, DateTime cardExpiryDate, string customerMobile, string deliveryAddress, int deliveryTime, string customerId, int price, string voucher)
        {
            if (cardNumber.Length != 16) // if card number isnt 16 characters long return error
            {
                return "card number invalid";
            }

            if (cardSecurityCode.Length != 6) // if card number isnt 6 characters long return error
            {
                return "card security code invalid";
            }
            if (cardExpiryDate == null) // cant be empty
            {
                return "card expiry date cannot be blank";
            }
            if (customerMobile.Length != 11) // if card number isnt 11 characters long return error
            {
                return "wrong mobile number";
            }
            if (deliveryAddress.Length > 50 || deliveryAddress.Length < 5) // if delivery address is longer than 50 characters or shorter than 5 return error
            {
                return "address cannot be empty";
            }
            if (deliveryTime < 10 || deliveryTime > 200) // if delivery time is longer than 200 and shorter than 10 return error
            {
                return "delivery time impossible";
            }
            if (customerId == null) // if customerId empty return error
            {
                return "customer id is null";
            }
            if (price < 10 || price > 500) { return "price is incorrect"; } // if price is bigger than 500 or smaller than 10 return error
            if (voucher.Length < 5 || voucher.Length > 20) { return "voucher is incorrect"; }// if voucher length is shorter than 5 or bigger than 20 return error
            else return "";
        }

    }
}