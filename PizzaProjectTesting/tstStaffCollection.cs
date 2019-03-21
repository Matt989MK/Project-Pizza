using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace StaffTestProject
{
    [TestClass]
    public class tstStaffCollection
    {

        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test date to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create an item of test data
            clsStaff TestItem = new clsStaff();
            //set the poperties
            TestItem.StaffNo = 8;
            TestItem.FirstName = "Mary";
            TestItem.LastName = "Wells";
            TestItem.Sex = "Female";
            TestItem.Address = "95 Guild Street";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNo = "07018048436";
            TestItem.EmailAddress = "mjewell@verizon.net";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see if the two values are identical
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffProperty()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffNo = 8;
            TestStaff.FirstName = "Mary";
            TestStaff.LastName = "Wells";
            TestStaff.Sex = "Female";
            TestStaff.Address = "95 Guild Street";
            TestStaff.DateOfBirth = DateTime.Now.Date;
            TestStaff.PhoneNo = "07018048436";
            TestStaff.EmailAddress = "mjewell@verizon.net";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are identical
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //and the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffNo = 8;
            TestItem.FirstName = "Mary";
            TestItem.LastName = "Wells";
            TestItem.Sex = "Female";
            TestItem.Address = "95 Guild Street";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNo = "07018048436";
            TestItem.EmailAddress = "mjewell@verizon.net";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are identical
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 8;
            TestItem.FirstName = "Mary";
            TestItem.LastName = "Wells";
            TestItem.Sex = "Female";
            TestItem.Address = "95 Guild Street";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNo = "07018048436";
            TestItem.EmailAddress = "mjewell@verizon.net";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record 
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMehodOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 8;
            TestItem.FirstName = "Mary";
            TestItem.LastName = "Wells";
            TestItem.Sex = "Female";
            TestItem.Address = "95 Guild Street";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNo = "07018048436";
            TestItem.EmailAddress = "mjewell@verizon.net";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //find the record 
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the values was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffNo = 8;
            TestItem.FirstName = "Mary";
            TestItem.LastName = "Wells";
            TestItem.Sex = "Female";
            TestItem.Address = "95 Guild Street";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNo = "07018048436";
            TestItem.EmailAddress = "mjewell@verizon.net";
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaff.Add();
            //set the prmary key of the test data
            TestItem.StaffNo = PrimaryKey;
            //modify the test data
            TestItem.StaffNo = 10;
            TestItem.FirstName = "James";
            TestItem.LastName = "Bond";
            TestItem.Sex = "Male";
            TestItem.Address = "007 Secret Street";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.PhoneNo = "07900707007";
            TestItem.EmailAddress = "JamesBond007@yahoo.co.uk";
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //Update the record
            AllStaff.Update();
            //find the record 
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            //create an instance of the class containing the unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records);
            FilteredStaff.ReportByLastName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByLastNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a last name that doesnt exist
            FilteredStaff.ReportByLastName("xxxx xxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByLastNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a Last Name that doesnt exist
            FilteredStaff.ReportByLastName("Warren");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that first record is ID 1
                if (FilteredStaff.StaffList[0].StaffNo != 1)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredStaff.StaffList[1].StaffNo != 47)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}

