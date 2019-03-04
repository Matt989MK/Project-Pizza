using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPFrontEnd.App_Code
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
        private string mCardSecurityNumber;

        public string CardSecurityNumber
        {
            get
            {
                return mCardSecurityNumber;
            }
            set
            {
                mCardSecurityNumber = value;
            }
        }
        private DateTime mCardExpiryDate;
        public DateTime CardExpiryDate
        {
            get
            {
                return mCardExpiryDate;
            }
            set
            {
                mCardExpiryDate = value;
            }
        }
        private string mCustomerAddress;
        public string CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }
        private string mMobilePhone;
        public string MobilePhone
        {
            get
            {
                return mMobilePhone;
            }
            set
            {
                mMobilePhone = value;
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
        private int mOrderDescription;
        public int OrderDescription
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
    }
}