using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzaClassLibrary;

namespace PPFrontEnd
{
    public partial class DeletedStaff : System.Web.UI.Page
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffNo;

        protected void Page_Load(object sender, EventArgs e)
        {
            StaffNo = Convert.ToInt32(Session["StaffNo"]);    
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //delete the record
            DeleteStaff();
            //redirect back to the staff page
            Response.Redirect("Staff.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            //Cancelling the delete and takes user back to the staff page. 
            Response.Redirect("Staff.aspx");
        }

        void DeleteStaff()
        {
            //function to delete the selected record

            //create a new instance of the staff book
            clsStaffCollection StaffBook = new clsStaffCollection();
            //find the record to delete
            StaffBook.ThisStaff.Find(StaffNo);
            //delete the record 
            StaffBook.Delete();
        }
    }
}