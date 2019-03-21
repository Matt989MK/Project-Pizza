using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClassLibrary;
using PizzaLibraryClass;

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
        int deliveryTime = 200;
        string CustomerId = "22";
        int price = 200;
        string voucher = "voucher";

        [TestMethod]
        public void cardNumberOK()
        {
            clsOrder clsOrder = new clsOrder();
            string cardNumber = "1234567812345678";
            clsOrder.CardNumber = cardNumber;
            Assert.AreEqual(clsOrder.CardNumber,cardNumber);
        }
        [TestMethod]
        public void cardExpiryDateOK()
        {
            clsOrder clsOrder = new clsOrder();
            DateTime cardExpiryNumber = new DateTime(10/10/2010);
            clsOrder.CardExpiryNumber = cardExpiryNumber;
            Assert.AreEqual(clsOrder.CardExpiryNumber, cardExpiryNumber);
        }
        [TestMethod]
        public void cardSecurityCodeOK()
        {
            clsOrder clsOrder = new clsOrder();
            string cardSecurityCode = "123456";
            clsOrder.CardSecurityCode = cardSecurityCode;
            Assert.AreEqual(clsOrder.CardSecurityCode, cardSecurityCode);
        }
        [TestMethod]
        public void AddressOK()
        {
            clsOrder clsOrder = new clsOrder();
            string address = "abc street";
            clsOrder.DeliveryAddress = address;
            Assert.AreEqual(clsOrder.DeliveryAddress, address);
        }
        [TestMethod]
        public void EmailOK()
        {
            clsOrder clsOrder = new clsOrder();
            string email = "abc@gmail.com";
            clsOrder.Email = email;
            Assert.AreEqual(clsOrder.Email, email);
        }
        [TestMethod]
        public void PhoneNumberOK()
        {
            clsOrder clsOrder = new clsOrder();
            string phoneNumber = "12345678912";
            clsOrder.CustomerMobile = phoneNumber;
            Assert.AreEqual(clsOrder.CustomerMobile, phoneNumber);
        }
        [TestMethod]
        public void VoucherOK()
        {
            clsOrder clsOrder = new clsOrder();
            string voucher = "12345678912";
            clsOrder.Voucher = voucher;
            Assert.AreEqual(clsOrder.Voucher, voucher);
        }
      
        


   
       

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder cOrder = new clsOrder();
            Assert.IsNotNull(cOrder);
        }
        [TestMethod]
        public void OrderCardVoucherMaxBoundary()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            voucher="abcdefksieoasdfghuok";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress,deliveryTime,CustomerId,price,voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardVoucherMaxLessOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            voucher = "abcdefksieoasdfghuo";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardVoucherMaxPlusOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            voucher = "abcdefksieoasdfghuoka";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardVoucherMinBoundary()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            voucher = "abcdef";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardVoucherMinLessOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            voucher = "abcde";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardVoucherMinPlusOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            voucher = "abcdeef";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMaxBoundary()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            price = 500;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMaxLessOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            price = 499;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMaxPlusOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            price = 501;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMinBoundary()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            price = 10;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMinLessOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            price = 9;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardPriceMinPlusOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            price = 11;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMaxBoundary()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            CustomerId = "500";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMaxLessOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            CustomerId = "499";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMaxPlusOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            CustomerId = "501";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMinBoundary()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            CustomerId = null;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMinLessOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            CustomerId = "-1";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardCustomerIdMinPlusOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            CustomerId = "1";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMaxBoundary()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            deliveryTime = 120;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMaxLessOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            deliveryTime = 119;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMaxPlusOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            deliveryTime = 121;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMinBoundary()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            deliveryTime = 10;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMinLessOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            deliveryTime = 9;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardDeliveryTimeMinPlusOne()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            deliveryTime = 11;
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMaxBoundary()
        {
            //implement
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            cardExpiryDate = new DateTime(11/ 12 / 2010);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMaxLessOne()
        {
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            cardExpiryDate = new DateTime(9 / 12 / 2010);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMaxPlusOne()
        {
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            cardExpiryDate = new DateTime(11 / 12 / 2010);

            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMinBoundary()
        {
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            cardExpiryDate = new DateTime(9 / 12 / 2010);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMinLessOne()
        {
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            cardExpiryDate = new DateTime(9 / 12 / 2010);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardExpiryNumberMinPlusOne()
        {
            clsOrder clsOrder = new clsOrder();
            String Error = "";
            cardExpiryDate = new DateTime(9 / 12 / 2010);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderCardExpiryNumberOK()
        {
            clsOrder clsOrder = new clsOrder();
            string Error = "";

            DateTime cardExpiryNumber = new DateTime(2017, 1, 18);
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");

        }
        [TestMethod]      
        public void OrderCardNumberOK()
        {
            clsOrder clsOrder = new clsOrder();
            string Error = "";
            string cardNumber = "1234567891234567";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error,"");
        }
        [TestMethod]
        public void OrderCardNumberMaxBoundary()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string cardNumber = "1234567891234567";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberLessOne()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string cardNumber = "123456789123456";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberPlusOne()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string cardNumber = "12345678912345678";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMinBoundary()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string cardNumber = "1234567891234567";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMinLessOne()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string cardNumber = "123456789123456";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMinPlusOne()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string cardNumber = "12345678912345678";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMaxBoundary()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string customerMobile = "12345678912";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMaxLessOne()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string customerMobile = "1234567891";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMaxPlusOne()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string customerMobile = "123456789121";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMinBoundary()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string customerMobile = "12345678912";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMinLessOne()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string customerMobile = "1234567891";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardNumberMobileNumberMinPlusOne()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string customerMobile = "123456789122";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMaxBoundary()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string deliveryAddress = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghij";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMaxLessOne()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string deliveryAddress = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghi";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMaxPlusOne()
        {//fix
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string deliveryAddress = "abcdefghijabcdefghijabcdefghijabcdefghijabcdefghija";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMinBoundary()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string deliveryAddress = "abcde";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMinLessOne()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string deliveryAddress = "abcd";//fix
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressMinPlusOne()
        {
            string Error = "";
            clsOrder clsOrder = new clsOrder();
            string deliveryAddress = "abcdef";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCardSecurityCodeOK()
        {
            clsOrder clsOrder = new clsOrder();
            string Error = "";
            string cardSecurityCode = "123456";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderCustomerMobileOK()
        {
            clsOrder clsOrder = new clsOrder();
            string customerMobile = "12345678912";
            string Error = "";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryAddressOK()
        {
            clsOrder clsOrder = new clsOrder();
            string deliveryAddress = "123";
            string Error = "";
            Error = clsOrder.Valid(cardNumber, cardSecurityCode, cardExpiryDate, customerMobile, deliveryAddress, deliveryTime, CustomerId, price, voucher);//?? add methods
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDeliveryTimeOK()
        {
            clsOrder cOrder = new clsOrder();
            int deliveryTime = 60;
            cOrder.DeliveryTime = deliveryTime.ToString();
            Assert.AreEqual(cOrder.DeliveryTime, deliveryTime);
        }
        [TestMethod]
        public void OrderIDOK()
        {
            clsOrder cOrder = new clsOrder();
            string id = "1";
            cOrder.CustomerId = id;
            Assert.AreEqual(cOrder.CustomerId, id);
        }
        [TestMethod]
        public void OrderPriceOK()
        {
            clsOrder cOrder = new clsOrder();
            int price = 60;
            cOrder.Price = price;
            Assert.AreEqual(cOrder.Price, price);
        }
      
        [TestMethod]
        public void OrderVoucherOK()
        {
            clsOrder cOrder = new clsOrder();
            string voucher = "abcjhf23";
            cOrder.Voucher = voucher;
            Assert.AreEqual(cOrder.Voucher, voucher);
        }
        [TestMethod]
        public void FindIDOK()
        {
            clsOrder cOrder = new clsOrder();
            string Error = "";
            string ID = "2";
            Error = cOrder.FindID(ID);
            Assert.AreEqual(Error,"");
        }

      
    }
}
