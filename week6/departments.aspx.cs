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
    public partial class departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //get the departmenst & display in gridview
            getDepartments();
        }

        protected void getDepartments()
        {
            //connect to db
            var conn = new contosoEntities1();

            //run the query using LINQ
            var Departments = from d in conn.Departments
                              select d;

            //display query result in gridview
            grdDepartments.DataSource = Departments.ToList();
            grdDepartments.DataBind();
        }

        protected void grdDepartments_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // function to delete th edepartment from the gridview

            // 1. determine which row in the grid the user clicked

            Int32 gridIndex = e.RowIndex;

            // 2. find the department id value in the selected row
            Int32 DepartmentID = Convert.ToInt32(grdDepartments.DataKeys[gridIndex].Value);

            // 3. connect to the db
            var conn = new contosoEntities1();

            // 4. delete the department
            /* var objDep = (from d in conn.Departments
                             where d.DepartmentID == DepartmentID
                             select d).First();*/


            Department d = new Department();
            d.DepartmentID = DepartmentID;
            conn.Departments.Attach(d);
            conn.Departments.Remove(d);
            conn.SaveChanges();

            // 5. refresh the gridview
            getDepartments();
           
        }
    }
}