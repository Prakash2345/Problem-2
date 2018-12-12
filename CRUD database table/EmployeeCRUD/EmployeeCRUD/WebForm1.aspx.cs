using EmployeeCRUD.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeCRUD
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.EmpId = Convert.ToInt32(TextBox1.Text);
            emp.EmpName = TextBox2.Text;
            emp.EmpDesig = TextBox3.Text;
            emp.Salary = Convert.ToInt32(TextBox4.Text);
            Service1Client obj = new Service1Client();
            if (obj.AddEmployee(emp) == 1)
            {
                Response.Write("<script>alert('Employee Added Sucessfully');</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Emp emp = new Emp();
            emp.EmpId = Convert.ToInt32(TextBox1.Text);
            emp.EmpName = TextBox2.Text;
            emp.EmpDesig = TextBox3.Text;
            emp.Salary = Convert.ToInt32(TextBox4.Text);
            Service1Client obj = new Service1Client();
            if (obj.UpdateEmployee(emp) == 1)
            {
                Response.Write("<script>alert('Employee Updated Sucessfully');</script>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.EmpId = Convert.ToInt32(TextBox1.Text);
           
            Service1Client obj = new Service1Client();
            if (obj.DeleteEmployee(emp) == 1)
            {
                Response.Write("<script>alert('Employee Deleted Sucessfully');</script>");
            }
        }

        

        protected void Button4_Click(object sender, EventArgs e)
        {
            //Employee empl = new Employee();
            ServiceReference1.Employee emp = new ServiceReference1.Employee();
            Service1Client obj = new Service1Client();
            emp = obj.RetriveAll();
            DataTable dt = new DataTable();
            dt = emp.EmployeeTable;
            GridView1.DataSource = emp.EmployeeTable;
            GridView1.DataBind();
       }
    }
}