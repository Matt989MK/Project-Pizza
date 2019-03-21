using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzaClassLibrary;
using PizzaLibraryClass;

namespace PizzaProjectTesting
{
    /// <summary>
    /// Summary description for clsOrderCollection
    /// </summary>
    [TestClass]
    public class tstclsOrderCollection
    {
        string cardNumber = "1234567891234567";
        DateTime cardExpiryDate = new DateTime(10 / 12 / 2010);
        string cardSecurityCode = "123456";
        string customerMobile = "12345678912";
        string deliveryAddress = "abc 25 street";
        int deliveryTime = 200;
        string CustomerId = "22";
        int price = 200;
        string voucher = "voucher";
        [TestMethod]
        public void clsOrderCollectionDeleteOK()
        {
            var Found1 = false;
            clsOrder testItem = new clsOrder();
            clsOrderCollection clstOrderCollection = new clsOrderCollection();
            Int32 PrimaryKey = 0;
            testItem.OrderId = 1;
            testItem.CardNumber = "1234567891234567";
            testItem.CardExpiryNumber = new DateTime(10 / 12 / 2010); ;
            testItem.CardSecurityCode = "123456";
            testItem.CustomerId = "22";
            testItem.CustomerMobile = "12345678912";
            testItem.DeliveryAddress = "abc 25 street";
            testItem.DeliveryTime = 200.ToString();
            testItem.Price = 200;
            testItem.Voucher = "voucher";
            clstOrderCollection.ThisOrder.OrderId = PrimaryKey;
            PrimaryKey = 1;
            testItem.OrderId = PrimaryKey;
            clstOrderCollection.FilterByOrderId(PrimaryKey.ToString());
            clstOrderCollection.Delete();
            string Found = "0";
            if (Found == "0") { Found1 = true; }
            Assert.IsFalse(Found1);
        }
        [TestMethod]
        public void clsOrderCollectionAddOK()
        {

            clsOrder testItem = new clsOrder();
            clsOrderCollection clstOrderCollection = new clsOrderCollection();
            Int32 PrimaryKey = 0;
            testItem.OrderId = 0;
            testItem.CardNumber = "1234567891234567";
            testItem.CardExpiryNumber = new DateTime(10 / 12 / 2010); ;
            testItem.CardSecurityCode = "123456";
            testItem.CustomerId = "22";
            testItem.CustomerMobile = "12345678912";
            testItem.DeliveryAddress = "abc 25 street";
            testItem.DeliveryTime = 200.ToString();
            testItem.Price = 200;
            testItem.Voucher = "voucher";
            clstOrderCollection.ThisOrder.OrderId = PrimaryKey;
            PrimaryKey = clstOrderCollection.Add();
            clstOrderCollection.ThisOrder.FindID(PrimaryKey.ToString());
            Assert.AreEqual(clstOrderCollection.ThisOrder.OrderId, testItem.OrderId);
        }
    }
}
