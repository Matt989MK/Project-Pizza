using System;

namespace PizzaProjectTesting
{
    class clsOrder
    {
        public int OrderNo { get; internal set; }
        public DateTime CardExpiryNumber { get; internal set; }
        public string CardNumber { get; internal set; }
        public string CardSecurityCode { get; internal set; }
        public string CustomerMobile { get; internal set; }
        public string DeliveryAddress { get; internal set; }
        public int DeliveryTime { get; internal set; }
        public string ID { get; internal set; }
        public int Price { get; internal set; }
        public string Status { get; internal set; }
        public string Voucher { get; internal set; }

        internal string FindID(string iD) // cant be letters
        {
            if (iD != "")
            {
                return "";
            }
            else
                return "ID cannot be blank";
        }

        internal string VoucherDiscount(string voucher)
        {
            if (voucher.Length >15 || voucher.Length<1)
            {
                return "invalid Length";
            }
            else
                return "";
        }

        internal string Valid(string cardNumber, string cardSecurityCode, DateTime cardExpiryDate, string customerMobile, string deliveryAddress)
        {
            if (cardNumber.Length != 16) // cant be letters
            {
                return "card number invalid";
            }
            if (cardSecurityCode.Length != 3) // fix cant be letters
            {
                return "card security code invalid";
            }
            if (cardExpiryDate==null) // cant be 
            {
                return "card expiry date cannot be blank";
            }
            if (customerMobile.Length!=11) // cant be 
            {
                return "wrong mobile number";
            }
            if (deliveryAddress == null) // cant be 
            {
                return "address cannot be empty";
            }
            else return "";
        }
    }
}