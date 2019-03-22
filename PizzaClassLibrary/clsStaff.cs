using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaClassLibrary
{
        public class clsStaff
        {
            //private data member
            private Int32 mStaffNo;
            private string mAddress;
            private string mEmailAddress;
            private string mFirstName;
            private string mLastName;
            private string mPhoneNo;
            private string mSex;
            private DateTime mDateOfBirth;

            public bool Find(int StaffNo)
            {
                //create an instance of data connection 
                clsDataConnection DB = new clsDataConnection();
                //add parameter for the staff no to search for
                DB.AddParameter("@StaffNo", StaffNo);
                //execute the stroed procedure
                DB.Execute("sproc_tblStaff_FilterByStaffNo");
                //if one record is found (there should be either one or zero)
                if (DB.Count == 1)
                {
                    //copt the data straight from the database to the private data members
                    mStaffNo = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNo"]);
                    mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                    mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                    mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                    mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                    mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                    mSex = Convert.ToString(DB.DataTable.Rows[0]["Sex"]);
                    mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                    //return that everything has worked
                    return true;
                }
                //if no record was found
                else
                {
                    //return false indicating a problem
                    return false;
                }
            }

            //public bool Find(string Address)
            //{
            //    //set the private member to the test data value

            //    //always return true
            //    return true;
            //}
            //You dont need all the comments above as you only need one find function.


            //public property for the staff number
            public int StaffNo
            {
                get
                {
                    //return the privat data
                    return mStaffNo;
                }
                set
                {
                    //set the value of the private data member
                    mStaffNo = value;
                }
            }

            //public property for the Address
            public string Address
            {
                get
                {
                    //return the private data
                    return mAddress;
                }
                set
                {
                    //set the value of the private data member
                    mAddress = value;
                }
            }

            //public property for the DateOfBirth
            public DateTime DateOfBirth
            {
                get
                {
                    //return the private data
                    return mDateOfBirth;
                }
                set
                {
                    //set the value of the private data member
                    mDateOfBirth = value;
                }
            }

            //public property for the First name
            public string FirstName
            {
                get
                {
                    //return the private data
                    return mFirstName;
                }
                set
                {
                    //set the value of the private data member
                    mFirstName = value;
                }
            }

            //public property for the Last name
            public string LastName
            {
                get
                {
                    return mLastName;
                }
                set
                {
                    mLastName = value;
                }
            }

            //public property for the PhoneNo
            public string PhoneNo
            {
                get
                {
                    //return the private data
                    return mPhoneNo;
                }
                set
                {
                    //set the value of the private data member
                    mPhoneNo = value;
                }
            }

            //public property for the Sex
            public string Sex
            {
                get
                {
                    //return the private data
                    return mSex;
                }
                set
                {
                    //set the value of the private data member
                    mSex = value;
                }
            }

            //public property for the Sex
            public string EmailAddress
            {
                get
                {
                    //return the private data
                    return mEmailAddress;
                }
                set
                {
                    //set the value of the private data member
                    mEmailAddress = value;
                }
            }

            public string Valid(string firstName, string lastName, string sex, string address, string dateOfBirth, string phoneNo, string emailAddress)
            {
                //create a string variable to store the error
                String Error = "";
                //create a temporary variable to store data values
                DateTime DateTemp;
                //if the FirstName is blank
                if (firstName.Length == 0)
                {
                    //record the error
                    Error = Error + "The First Name may not be blank : ";
                }
                //if the first name is greater than 50 characters
                if (firstName.Length > 50)
                {
                    //record the error
                    Error = Error + "The First Name must be less than 50 charcters : ";
                }
                if (lastName.Length == 0)
                {
                    Error = Error + "The Last Name may not be blank : ";
                }
                if (lastName.Length > 50)
                {
                    Error = Error + "The Last Name must be less than 50 charcters : ";
                }
                if (phoneNo.Length == 0)
                {
                    Error = Error + "The Phone number may not be blank : ";
                }
                if (phoneNo.Length > 11)
                {
                    Error = Error + "The Phone number can not be more than 11 digits : ";
                }
                if (emailAddress.Length == 0)
                {
                    Error = Error + "The E-mail address may not be blank : ";
                }
                if (emailAddress.Length > 319)
                {
                    Error = Error + "The E-mail address can not be more than 318 characters : ";
                }
                if (sex.Length == 0)
                {
                    Error = Error + "The sex can not be blank : ";
                }
                if (sex.Length > 6)
                {
                    Error = Error + "The sex can not be more than 6 characters : ";
                }
                if (address.Length == 0)
                {
                    Error = Error + "The sex can not be blank : ";
                }
                if (address.Length > 50)
                {
                    Error = Error + "The sex can not be more than 50 characters : ";
                }
                try
                { //copy the DateOfBirth value to the DateTemp variable
                    DateTemp = Convert.ToDateTime(dateOfBirth);
                    if (DateTemp < DateTime.Now.Date)
                    {
                        //record the error
                        Error = Error + "The date cannot be in the past : ";
                    }
                    //check to see if the date is greater than today's date
                    if (DateTemp > DateTime.Now.Date)
                    {
                        //record the error
                        Error = Error + "The date cannot be in the future : ";
                    }
                }
                catch
                {
                    //record the error
                    Error = Error + "The dat was not valid date : ";
                }

                //return any error messages
                return Error;
            }

        }
}
