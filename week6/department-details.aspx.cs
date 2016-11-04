﻿using System;
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
            if (IsPostBack == false) { 
                    // check the url for an id so we know we are adding or editing
                    if (!string.IsNullOrEmpty(Request.QueryString["DepartmentID"]))
                    {
                        // get id from url
                        Int32 DepartmentID = Convert.ToInt32(Request.QueryString["departmentID"]);


                        // connect
                        var conn = new contosoEntities1();


                        // lookup the selected department
                        var objDep = (from d in conn.Departments
                                      where d.DepartmentID == DepartmentID
                                      select d).FirstOrDefault();


                        // populate the form
                        txtDepartment.Text = objDep.Name;
                        txtbudget.Text = objDep.Budget.ToString();
                    }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //check if we have an id to decide if we're adding or editing
            Int32 DepartmentID = 0;

            if(!string.IsNullOrEmpty(Request.QueryString["DepartmentID"]))
            {
                DepartmentID = Convert.ToInt32(Request.QueryString["departmentID"]);
            }

            //connect to db
            var conn = new contosoEntities1();

            //use teh depart ment class to create the new department object
            Department d = new Department();

            //fill the properties of the new department object
            d.Name = txtDepartment.Text;
            d.Budget = Convert.ToDecimal(txtbudget.Text);

            //save the new object from database
            if(DepartmentID == 0)
            {
                conn.Departments.Add(d);
                
            }

            else
            {
                d.DepartmentID = DepartmentID;
                conn.Departments.Attach(d);
                conn.Entry(d).State = System.Data.Entity.EntityState.Modified;
            };
            conn.SaveChanges();

            //redirect to department page
            Response.Redirect("departments.aspx");
        }
    }
}