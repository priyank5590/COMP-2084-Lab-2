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
            if (IsPostBack == false)
            {
                // check the url for an id so we know we are adding or editing
                if (!string.IsNullOrEmpty(Request.QueryString["StudentID"]))
                {
                    // get id from url
                    Int32 StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);


                    // connect
                    var conn = new contosoEntities1();


                    // lookup the selected student
                    var objStu = (from d in conn.Students
                                  where d.StudentID == StudentID
                                  select d).FirstOrDefault();


                    // populate the form
                    txtLast.Text = objStu.LastName;
                    txtFirst.Text = objStu.FirstName;
                    txtDate.Text = objStu.EnrollmentDate.ToString();
                }
            }
        }

        protected void saveStudent_Click(object sender, EventArgs e)
        {
            //check if we have an id to decide if we're adding or editing
            Int32 StudentID = 0;

            if (!string.IsNullOrEmpty(Request.QueryString["StudentID"]))
            {
                StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            }

            //connect to db
            var conn = new contosoEntities1();

            //use the Student class to create the new student object
            Student d = new Student();

            //fill the properties of the new student object
            d.LastName = txtLast.Text;
            d.FirstName = txtFirst.Text;
            d.EnrollmentDate = Convert.ToDateTime(txtDate.Text);

            //save the new object from database
            if (StudentID == 0)
            {
                conn.Students.Add(d);

            }

            else
            {
                d.StudentID = StudentID;
                conn.Students.Attach(d);
                conn.Entry(d).State = System.Data.Entity.EntityState.Modified;
            };
            conn.SaveChanges();

            //redirect to student page
            Response.Redirect("students.aspx");
        }
    }
}