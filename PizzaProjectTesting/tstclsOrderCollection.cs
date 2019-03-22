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
        DateTime cardExpiryDate = DateTime.Today;
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
            
            clsOrder testItem = new clsOrder();
            clsOrderCollection clstOrderCollection = new clsOrderCollection();
            Int32 PrimaryKey = 0;
            testItem.OrderId = 5;
            testItem.CardNumber = "1234567891234567";
            testItem.CardExpiryNumber = DateTime.Today;
            testItem.CardSecurityCode = "123456";
            testItem.CustomerId = "22";
            testItem.CustomerMobile = "12345678912";
            testItem.DeliveryAddress = "abc 25 street";
            testItem.Email = "abc@gmail.com";
            testItem.DeliveryTime = 200.ToString();
            testItem.Price = 200;
            testItem.Voucher = "voucher";
            testItem.OrderDescription = "Pizza 1";
            clstOrderCollection.ThisOrder = testItem;
            PrimaryKey = clstOrderCollection.Add();
            testItem.OrderId = PrimaryKey;
            clstOrderCollection.ThisOrder.FindID(PrimaryKey);
            clstOrderCollection.Delete();
             clstOrderCollection.ThisOrder.FindID(PrimaryKey);
            Assert.AreEqual(PrimaryKey,clstOrderCollection.ThisOrder.FindID(PrimaryKey));
        }
        [TestMethod]
        public void clsOrderCollectionAddOK()
        {

            clsOrder testItem = new clsOrder();
            clsOrderCollection clstOrderCollection = new clsOrderCollection();
            Int32 PrimaryKey = 0;
            testItem.OrderId = 0;
            testItem.CardNumber = "1234567891234567";
            testItem.CardExpiryNumber = DateTime.Today ;
            testItem.CardSecurityCode = "123456";
            testItem.CustomerId = "22";
            testItem.CustomerMobile = "12345678912";
            testItem.DeliveryAddress = "abc 25 street";
            testItem.DeliveryTime = 200.ToString();
            testItem.Price = 200;
            testItem.Voucher = "voucher";
            testItem.Email = "ac@gmail.com";
            testItem.OrderDescription = "Pizza 1";
            clstOrderCollection.ThisOrder = testItem;
            PrimaryKey = clstOrderCollection.Add();
            testItem.OrderId = PrimaryKey;
            clstOrderCollection.ThisOrder.FindID(PrimaryKey);
            Assert.AreEqual(clstOrderCollection.ThisOrder, testItem);
        }
    }
}
