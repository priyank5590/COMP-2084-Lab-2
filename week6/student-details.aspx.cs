using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//reference the model binding library
using System.Web.ModelBinding;

namespace week6
{
    public partial class student_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveStudent_Click(object sender, EventArgs e)
        {
            //connect to db
            var conn = new contosoEntities1();

            //use the Student class to create the new department object
            Student d = new Student();

            //fill the properties of the new department object
            d.LastName = txtLast.Text;
            d.FirstName = txtFirst.Text;
            d.EnrollmentDate = Convert.ToDateTime(txtDate.Text);

            //save the new object from database
            conn.Students.Add(d);
            conn.SaveChanges();

            //redirect to department page
            Response.Redirect("students.aspx");
        }
    }
}