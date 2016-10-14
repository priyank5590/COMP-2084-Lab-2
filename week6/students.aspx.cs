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
            //connect to db
            var conn = new contosoEntities1();

            //run the query using LINQ
            var Students = from d in conn.Students
                              select d;

            //display query result in gridview
            grdStudents.DataSource = Students.ToList();
            grdStudents.DataBind();
        }
    }
}