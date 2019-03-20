using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTesting_Customer
{
    [TestClass]
    public class tstCustomer
    {
        private string mAddress = "19 BulkStreet";
        private string mEmailAddress = "johnsab@hotmail.com";
        private string mFirstName = "John";
        private string mLastName = "Sab";
        private string mPhoneNo = "2233556688997";


        public int CustomerID { get; private set; }
        public string Error { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "ABC";
            ACustomer.Address = TestData;
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "JohnSab@hotmail.com";
            ACustomer.EmailAddress = TestData;
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "John";
            ACustomer.FirstName = TestData;
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "Sab";
            ACustomer.LastName = TestData;
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String TestData = "7755886644";
            ACustomer.PhoneNo = TestData;
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 AddressNo = 1;
            Found = ACustomer.Find(AddressNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void CustomerIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void Address()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.Address != "15 street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void FirstName()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.FirstName != "John")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]

        public void LastName()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.LastName != "Sab")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void EmailAddress()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.EmailAddress != "JohnSab@hotmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PhoneNo()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.PhoneNo != "7755886644")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer Acustomer = new clsCustomer();
            string Error = "";
            Error = Acustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "adfadfa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "adfadfa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "adfadfadfsdgs";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "adfadfadfsdgs";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "aaa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailAddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string EmailAddress = "aaaaaaaaaa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string EmailAddress = "aaaaaaaaaa";            
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string EmailAddress = "aaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void FirstNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FirstName = "abgskjfeiuf";
            FirstName = "abgskjfeiuf";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FirstName = "abgskjfeiuf";
            FirstName = "abgskjfeiuf";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FirstName = "aaaaaaa";
            FirstName = "abcdefg";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FirstName = "";
            FirstName = "abcdefg";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string FirstName = "";
            FirstName = "abcdefg";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void LastNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string LastName = "aaaaaaaaa";
            
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string LastName = "aaaaaaa";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string LastName = "";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string LastName = "";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string PhoneNo = "0123456789";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string PhoneNo = "0";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string PhoneNo = "0123";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string PhoneNo = "0123456789";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string PhoneNo = "0123456";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNoMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string PhoneNo = "0";
            Error = ACustomer.Valid(CustomerID, FirstName, LastName, Address, EmailAddress, PhoneNo);
            Assert.AreEqual(Error, "");
        }
    }
}