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
            clstOrder cOrder = new clstOrder();
            Assert.IsNotNull(cOrder);
        }
        [TestMethod]
        public void OrderCardExpiryNumberOK()
        {
            clstOrder cOrder = new clstOrder();
            DateTime cardExpiryNumber= new DateTime(2017, 1, 18);
            cOrder.CardExpiryNumber = cardExpiryNumber;
            Assert.AreEqual(cOrder.CardExpiryNumber, cardExpiryNumber);
        }
        [TestMethod]
        public void OrderCardNumberOK()
        {
            clstOrder cOrder = new clstOrder();
            string cardNumber = "1234567891234567";
            cOrder.CardNumber = cardNumber;
            Assert.AreEqual(cOrder.CardNumber, cardNumber);
        }
        [TestMethod]
        public void OrderCardSecurityCodeOK()
        {
            clstOrder cOrder = new clstOrder();
            string cardSecurityCode = "123";
            cOrder.CardSecurityCode = cardSecurityCode;
            Assert.AreEqual(cOrder.CardSecurityCode, cardSecurityCode);
        }
        [TestMethod]
        public void OrderCustomerMobileOK()
        {
            clstOrder cOrder = new clstOrder();
            string customerMobile = "123";
            cOrder.CustomerMobile = customerMobile;
            Assert.AreEqual(cOrder.CustomerMobile, customerMobile);
        }
        [TestMethod]
        public void OrderDeliveryAddressOK()
        {
            clstOrder cOrder = new clstOrder();
            string deliveryAddress = "123";
            cOrder.DeliveryAddress = deliveryAddress;
            Assert.AreEqual(cOrder.DeliveryAddress, deliveryAddress);
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
            cOrder.ID = id;
            Assert.AreEqual(cOrder.ID, id);
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
        public void OrderStatusOK()
        {
            clstOrder cOrder = new clstOrder();
            string status = "ready";
            cOrder.Status = status;
            Assert.AreEqual(cOrder.Status, status);
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
            clstOrder cOrder = new clstOrder();
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
