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
    }
}