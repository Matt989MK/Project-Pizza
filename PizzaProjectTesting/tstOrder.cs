using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzaProjectTesting
{
    
    [TestClass]
    public class tstOrder
    {
        string cardNumber = "1234567891234567";
        DateTime cardExpiryDate = new DateTime(10/12/2010);
        string cardSecurityCode = "123456";
        string customerMobile = "12345678912";
        string deliveryAddress = "abc 25 street";
        int deliveryTime = 150;
        string CustomerId = "22";
        int price = 500;
        string voucher = "voucher";

        [TestMethod]
        public void InstanceOK()
        {
            clstOrder cOrder = new clstOrder();
            Assert.IsNotNull(cOrder);
        }
        [TestMethod]
        public void OrderCardVoucherMaxBoundary()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            voucher="abcdefksieoasdfghuok";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress,deliveryTime,CustomerId,price,voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardVoucherMaxLessOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            voucher = "abcdefksieoasdfghuo";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardVoucherMaxPlusOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            voucher = "abcdefksieoasdfghuoka";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardVoucherMinBoundary()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            voucher = "abcdef";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardVoucherMinLessOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            voucher = "abcde";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardVoucherMinPlusOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            voucher = "abcdeef";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMaxBoundary()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            price = 500;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMaxLessOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            price = 499;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMaxPlusOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            price = 501;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMinBoundary()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            price = 10;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMinLessOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            price = 9;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMinPlusOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            price = 11;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMaxBoundary()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            CustomerId = "500";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMaxLessOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            CustomerId = "499";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMaxPlusOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            CustomerId = "501";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMinBoundary()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            CustomerId = null;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMinLessOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            CustomerId = "-1";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMinPlusOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            CustomerId = "1";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMaxBoundary()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            deliveryTime = 120;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMaxLessOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            deliveryTime = 119;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMaxPlusOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            deliveryTime = 121;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMinBoundary()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            deliveryTime = 10;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMinLessOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            deliveryTime = 9;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMinPlusOne()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            deliveryTime = 11;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMaxBoundary()
        {
            //implement
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            cardExpiryDate = new DateTime(11/ 12 / 2010);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMaxLessOne()
        {
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            cardExpiryDate = new DateTime(9 / 12 / 2010);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMaxPlusOne()
        {
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            cardExpiryDate = new DateTime(11 / 12 / 2010);

            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMinBoundary()
        {
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            cardExpiryDate = new DateTime(9 / 12 / 2010);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMinLessOne()
        {
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            cardExpiryDate = new DateTime(9 / 12 / 2010);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMinPlusOne()
        {
            clstOrder clsOrder = new clstOrder();
            String Error = "";
            cardExpiryDate = new DateTime(9 / 12 / 2010);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderCardExpiryNumberOK()
        {
            clstOrder clsOrder = new clstOrder();
            string Error = "";

            DateTime cardExpiryNumber = new DateTime(2017, 1, 18);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");

        }
        [TestMethod]      
        public void OrderCardNumberOK()
        {
            clstOrder clsOrder = new clstOrder();
            string Error = "";
            string cardNumber = "1234567891234567";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error,"");
        }
        [TestMethod]
        public void OrderCardNumberMaxBoundary()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string cardNumber = "1234567891234567";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberLessOne()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string cardNumber = "123456789123456";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberPlusOne()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string cardNumber = "12345678912345678";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMinBoundary()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string cardNumber = "1234567891234567";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMinLessOne()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string cardNumber = "123456789123456";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMinPlusOne()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string cardNumber = "12345678912345678";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMaxBoundary()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string customerMobile = "12345678912";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMaxLessOne()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string customerMobile = "1234567891";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMaxPlusOne()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string customerMobile = "123456789121";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMinBoundary()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string customerMobile = "12345678912";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMinLessOne()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string customerMobile = "1234567891";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMinPlusOne()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string customerMobile = "123456789122";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMaxBoundary()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string deliveryAddress = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMaxLessOne()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string deliveryAddress = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMaxPlusOne()
        {//fix
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string deliveryAddress = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMinBoundary()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string deliveryAddress = "abcde";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMinLessOne()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string deliveryAddress = "abcd";//fix
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMinPlusOne()
        {
            string Error = "";
            clstOrder clsOrder = new clstOrder();
            string deliveryAddress = "abcdef";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardSecurityCodeOK()
        {
            clstOrder clsOrder = new clstOrder();
            string Error = "";
            string cardSecurityCode = "123456";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCustomerMobileOK()
        {
            clstOrder clsOrder = new clstOrder();
            string customerMobile = "12345678912";
            string Error = "";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressOK()
        {
            clstOrder clsOrder = new clstOrder();
            string deliveryAddress = "123";
            string Error = "";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryTimeOK()
        {
            clstOrder cOrder = new clstOrder();
            int deliveryTime = 60;
            cOrder.DeliveryTime = deliveryTime;
            Assert.AreEqual(cOrder.DeliveryTime, deliveryTime);
        }
        [TestMethod]
        public void OrderIDOK()
        {
            clstOrder cOrder = new clstOrder();
            string id = "1";
            cOrder.CustomerId = id;
            Assert.AreEqual(cOrder.CustomerId, id);
        }
        [TestMethod]
        public void OrderPriceOK()
        {
            clstOrder cOrder = new clstOrder();
            int price = 60;
            cOrder.Price = price;
            Assert.AreEqual(cOrder.Price, price);
        }
      
        [TestMethod]
        public void OrderVoucherOK()
        {
            clstOrder cOrder = new clstOrder();
            string voucher = "abcjhf23";
            cOrder.Voucher = voucher;
            Assert.AreEqual(cOrder.Voucher, voucher);
        }
        [TestMethod]
        public void FindIDOK()
        {
            clstOrder cOrder = new clstOrder();
            string Error = "";
            string ID = "2";
            Error = cOrder.FindID(ID);
            Assert.AreEqual(Error,"");
        }
        [TestMethod]
        public void VoucherDiscountOK()
        {
            clstOrder cOrder = new clstOrder();
            string Error = "";
            string voucher = "absd2";
            Error = cOrder.VoucherDiscount(voucher);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ValidOK()
        {
            clstOrder clsOrder = new clstOrder();
            string Error = "";
            string cardNumber="1234567891234567";
            string cardSecurityCode="123456";
            DateTime cardExpiryDate=new DateTime(2017, 1, 18);
            string customerMobile="12345678912";
            string deliveryAddress="newyrsStreet";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
    }
}
