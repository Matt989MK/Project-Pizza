using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzaProjectTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void TestMethod1()
        {
          
        }
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder cOrder = new clsOrder();
            Assert.IsNotNull(cOrder);
        }
        [TestMethod]
        public void OrderCardExpiryNumberOK()
        {
            clsOrder cOrder = new clsOrder();
            DateTime cardExpiryNumber= new DateTime(2017, 1, 18);
            cOrder.CardExpiryNumber = cardExpiryNumber;
            Assert.AreEqual(cOrder.CardExpiryNumber, cardExpiryNumber);
        }
        [TestMethod]
        public void OrderCardNumberOK()
        {
            clsOrder cOrder = new clsOrder();
            string cardNumber = "1234567891234567";
            cOrder.CardNumber = cardNumber;
            Assert.AreEqual(cOrder.CardNumber, cardNumber);
        }
        [TestMethod]
        public void OrderCardSecurityCodeOK()
        {
            clsOrder cOrder = new clsOrder();
            string cardSecurityCode = "123";
            cOrder.CardSecurityCode = cardSecurityCode;
            Assert.AreEqual(cOrder.CardSecurityCode, cardSecurityCode);
        }
        [TestMethod]
        public void OrderCustomerMobileOK()
        {
            clsOrder cOrder = new clsOrder();
            string customerMobile = "123";
            cOrder.CustomerMobile = customerMobile;
            Assert.AreEqual(cOrder.CustomerMobile, customerMobile);
        }
        [TestMethod]
        public void OrderDeliveryAddressOK()
        {
            clsOrder cOrder = new clsOrder();
            string deliveryAddress = "123";
            cOrder.DeliveryAddress = deliveryAddress;
            Assert.AreEqual(cOrder.DeliveryAddress, deliveryAddress);
        }
        [TestMethod]
        public void OrderDeliveryTimeOK()
        {
            clsOrder cOrder = new clsOrder();
            int deliveryTime = 60;
            cOrder.DeliveryTime = deliveryTime;
            Assert.AreEqual(cOrder.DeliveryTime, deliveryTime);
        }
        [TestMethod]
        public void OrderIDOK()
        {
            clsOrder cOrder = new clsOrder();
            string id = "1";
            cOrder.ID = id;
            Assert.AreEqual(cOrder.ID, id);
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
        public void OrderStatusOK()
        {
            clsOrder cOrder = new clsOrder();
            string status = "ready";
            cOrder.Status = status;
            Assert.AreEqual(cOrder.Status, status);
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
        [TestMethod]
        public void VoucherDiscountOK()
        {
            clsOrder cOrder = new clsOrder();
            string Error = "";
            string voucher = "absd2";
            Error = cOrder.VoucherDiscount(voucher);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ValidOK()
        {
            clsOrder cOrder = new clsOrder();
            string Error = "";
            string cardNumber="1234567891234567";
            string cardSecurityCode="123";
            DateTime cardExpiryDate=new DateTime(2017, 1, 18);
            string customerMobile="12345678912";
            string deliveryAddress="newyrsStreet";
            Error = cOrder.Valid(cardNumber,cardSecurityCode,cardExpiryDate,customerMobile,deliveryAddress);
            Assert.AreEqual(Error, "");
        }
    }
}
