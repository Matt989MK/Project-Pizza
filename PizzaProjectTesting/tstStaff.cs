using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaffTestProject
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass to the method
        string FirstName = "James";
        string LastName = "Bond";
        string Sex = "Male";
        string Address = "007 Secret Street";
        string DateOfBirth = DateTime.Now.Date.ToString();
        string PhoneNo = "0790070700";
        string EmailAddress = "JamesBond007@yahoo.co.uk";

        [TestMethod]
        public void InstanceOK()
        {
            //creating an instance of the class
            clsStaff AnStaff = new clsStaff();
            //test to see if it exists
        }


        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the address 
            String TestData = "007 Secret Street";
            //assign the data to the address
            AnStaff.Address = TestData;
            //test to see that the two valuesare the same
            Assert.AreEqual(AnStaff.Address, TestData);

        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the address 
            String TestData = "JamesBond007@yahoo.co.uk";
            //assign the data to the address
            AnStaff.EmailAddress = TestData;
            //test to see that the two valuesare the same
            Assert.AreEqual(AnStaff.EmailAddress, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the address 
            String TestData = "James";
            //assign the data to the address
            AnStaff.FirstName = TestData;
            //test to see that the two valuesare the same
            Assert.AreEqual(AnStaff.FirstName, TestData);
        }
        public void LastNamePropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the address 
            String TestData = "Bond";
            //assign the data to the address
            AnStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.LastName, TestData);
        }
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the address 
            String TestData = "0790070700";
            //assign the data to the address
            AnStaff.PhoneNo = TestData;
            //test to see that the two valuesare the same
            Assert.AreEqual(AnStaff.PhoneNo, TestData);
        }

        public void SexPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the address 
            String TestData = "Male";
            //assign the data to the address
            AnStaff.Sex = TestData;
            //test to see that the two valuesare the same
            Assert.AreEqual(AnStaff.Sex, TestData);
        }
        public void DateOfBirthPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the address 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the address
            AnStaff.DateOfBirth = TestData;
            //test to see that the two valuesare the same
            Assert.AreEqual(AnStaff.DateOfBirth, TestData);
        }

        public void StaffNoPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the address 
            Int32 TestData = 123;
            //assign the data to the address
            AnStaff.StaffNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffNo = 10;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            //creating an instance of the class
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record  if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffNo = 10;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the Staff number
            if (AnStaff.StaffNo != 10)
            {
                OK = false;
            }
            //test to se that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 10;
            Found = AnStaff.Find(StaffNo);
            if (AnStaff.Address != "007 Secret Street")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 10;
            Found = AnStaff.Find(StaffNo);
            if (AnStaff.FirstName != "James")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 10;
            Found = AnStaff.Find(StaffNo);
            if (AnStaff.LastName != "Bond")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailAddressFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 10;
            Found = AnStaff.Find(StaffNo);
            if (AnStaff.EmailAddress != "JamesBond007@yahoo.co.uk")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNoFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 10;
            Found = AnStaff.Find(StaffNo);
            if (AnStaff.PhoneNo != "07900707007")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSexFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffNo = 10;
            Found = AnStaff.Find(StaffNo);
            if (AnStaff.Sex != "Male")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthDate()
        {
            //create an instance of the desired class
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use method
            Int32 StaffNo = 10;
            //invoke the method
            Found = AnStaff.Find(StaffNo);
            //check the property
            if (AnStaff.DateOfBirth != Convert.ToDateTime("21/03/2019"))
            {
                OK = false;
            }
            //test to notice if the test was right
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string  variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";//should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that he result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a";//should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa";//should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";//should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaa";//should trigger an error
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "";//should trigger an error
            FirstName = FirstName.PadRight(100, 'a');//this should fail
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string LastName = "";//should trigger an error
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string LastName = "a";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string LastName = "aa";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreNotEqual(Error, "aa");
        }

        [TestMethod]
        public void LastNameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FirstName = "";
            LastName = LastName.PadRight(100, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "1234512345";//should trigger an error
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMin()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "12345123451";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "123451234512";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "12345123451";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "123451";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string PhoneNo = "";
            PhoneNo = PhoneNo.PadRight(40, '1');
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "123451234512"; //this should fail
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailAddressLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string EmailAddress = "123451234";//should trigger an error
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string EmailAddress = "1234512345";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string EmailAddress = "12345123451";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string EmailAddress = "1234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234567891234";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string EmailAddress = "1234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(400, '1');
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SexMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Sex = "";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SexMin()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Sex = "aaa";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SexMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Sex = "aaaaa";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SexMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Sex = "aaaaaa";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SexMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Sex = "aaa";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SexExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Sex = "";
            Sex = Sex.PadRight(20, 'a');
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Address = "1234512345123451";//should trigger an error
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Address = "12345123451234512";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Address = "123451234512345123";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Address = "12345123451234512345123451234512345123451234512345";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Address = "1234512345123451234512345";
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(100, '1');
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //Convert the date to whatever the date is less 100 years
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //set the DateOfBirth to a non date value
            string DateOfBirth = "This is not a date!";
            //invoke the method
            Error = AnStaff.Valid(FirstName, LastName, Sex, Address, DateOfBirth, PhoneNo, EmailAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


    }
}