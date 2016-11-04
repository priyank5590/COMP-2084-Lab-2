using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


//add two references to access the database
using System.Web.ModelBinding;

namespace week6
{
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //get the students & display in gridview
            getStudents();
        }
        protected void getStudents()
        {
            //connect to db
            var conn = new contosoEntities1();

            //run the query using LINQ
            var Students = from d in conn.Students
                              select d;

            //display query result in gridview
            grdStudents.DataSource = Students.ToList();
            grdStudents.DataBind();
        }


        protected void grdStudents_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // function to delete the student from the gridview

            // 1. determine which row in the grid the user clicked

            Int32 gridIndex = e.RowIndex;

            // 2. find the student id value in the selected row
            Int32 StudentID = Convert.ToInt32(grdStudents.DataKeys[gridIndex].Value);

            // 3. connect to the db
            var conn = new contosoEntities1();

            Student d = new Student();
            d.StudentID = StudentID;
            conn.Students.Attach(d);
            conn.Students.Remove(d);
            conn.SaveChanges();

            // 5. refresh the gridview
            getStudents();
        }
    }
}