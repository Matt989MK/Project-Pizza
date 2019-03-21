using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClassLibrary;


namespace PPFrontEnd
{
    public partial class AddStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Staff.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //adds the new staff record.
            Add();
            //all done so the redirect back to the staff page.
            Response.Redirect("Staff.aspx");

        }
      void Add()
        {
            //create an instance of the staff book
            PizzaClassLibrary.clsStaffCollection StaffBook = new PizzaClassLibrary.clsStaffCollection();
            //validate the data on the webform 
            String Error = StaffBook.ThisStaff.Valid(TxtFirstName.Text, txtLastName.Text, txtSex.Text, txtAddress.Text, txtDOB.Text, txtPhoneNo.Text, txtEmail.Text);
            //if the data is OK add it to the object
                if (Error == "")
                {
            //get data entered by the user
            StaffBook.ThisStaff.FirstName = TxtFirstName.Text;
            StaffBook.ThisStaff.LastName = txtLastName.Text;
            StaffBook.ThisStaff.Sex = txtSex.Text;
            StaffBook.ThisStaff.Address = txtAddress.Text;
            StaffBook.ThisStaff.DateOfBirth = Convert.ToDateTime(txtDOB.Text);
            StaffBook.ThisStaff.PhoneNo = txtPhoneNo.Text;
            StaffBook.ThisStaff.EmailAddress = txtEmail.Text;
            //add the record
                }
                else
                {
                //report an error
                lblError.Text = "There were problems with the data entered " + Error;
                }
        }  
    }

    
}