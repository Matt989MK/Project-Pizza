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
                return mCardNumber;
            }
            set
            {
                mCardNumber = value;
            }
        }
        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        private int mOrderNo;
        public int OrderId
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
        private string mCardSecurityCode;
        public string CardSecurityCode
        {
            get
            {
                return mCardSecurityCode;
            }
            set
            {
                mCardSecurityCode = value;
            }
        }
        private DateTime mCardExpiryNumber;
        public DateTime CardExpiryNumber
        {
            get
            {
                return mCardExpiryNumber;
            }
            set
            {
                mCardExpiryNumber = value;
            }
        }
        private string mDeliveryAddress;
        public string DeliveryAddress
        {
            get
            {
                return mDeliveryAddress;
            }
            set
            {
                mDeliveryAddress = value;
            }
        }
        private string mCustomerMobile;
        public string CustomerMobile
        {
            get
            {
                return mCustomerMobile;
            }
            set
            {
                mCustomerMobile = value;
            }
        }
        private string mVoucher;
        public string Voucher
        {
            get
            {
                return mVoucher;
            }
            set
            {
                mVoucher = value;
            }
        }
        private string mDeliveryTime;
        public string DeliveryTime
        {
            get
            {
                return mDeliveryTime;
            }
            set
            {
                mDeliveryTime = value;
            }
        }
        private int mDeliveryPrice;
        public int DeliveryPrice
        {
            get
            {
                return mDeliveryPrice;
            }
            set
            {
                mDeliveryPrice = value;
            }
        }
        private string mOrderDescription;
        public string OrderDescription
        {
            get
            {
                return mOrderDescription;
            }
            set
            {
                mOrderDescription = value;
            }
        }
        private int mPrice;
        public int Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public string CustomerId { get;  set; }

        public string FindID(string iD) // cant be letters
        {
            if (iD != "")
            {
                return "";
            }
            else
                return "ID cannot be blank";
        }
        public string Valid(string cardNumber, string cardSecurityCode, DateTime cardExpiryDate, string customerMobile, string deliveryAddress, int deliveryTime, string customerId, int price, string voucher)
        {
            if (cardNumber.Length != 16) // cant be letters
            {
                return "card number invalid";
            }

            if (cardSecurityCode.Length != 6) // fix cant be letters
            {
                return "card security code invalid";
            }
            if (cardExpiryDate == null) // cant be 
            {
                return "card expiry date cannot be blank";
            }
            if (customerMobile.Length != 11) // cant be 
            {
                return "wrong mobile number";
            }
            if (deliveryAddress.Length > 50 || deliveryAddress.Length < 5) // cant be 
            {
                return "address cannot be empty";
            }
            if (deliveryTime < 10 || deliveryTime > 200)
            {
                return "delivery time impossible";
            }
            if (customerId == null)
            {
                return "customer id is null";
            }
            if (price < 10 || price > 500) { return "price is incorrect"; }
            if (voucher.Length < 5 || voucher.Length > 20) { return "voucher is incorrect"; }
            else return "";
        }

    }
}