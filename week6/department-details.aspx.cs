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
    public partial class department_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //connect to db
            var conn = new contosoEntities1();

            //use teh depart ment class to create the new department object
            Department d = new Department();

            //fill the properties of the new department object
            d.Name = txtDepartment.Text;
            d.Budget = Convert.ToDecimal(txtbudget.Text);

            //save the new object from database
            conn.Departments.Add(d);
            conn.SaveChanges();

            //redirect to department page
            Response.Redirect("departments.aspx");
        }
    }
}