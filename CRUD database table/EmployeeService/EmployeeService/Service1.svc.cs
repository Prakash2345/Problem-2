using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection con = new SqlConnection("Data Source=PC355689\\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter cmd = new SqlDataAdapter();
        DataTable dt;
       

        public int AddEmployee(Emp e)
        {
            try
            {
                cmd.InsertCommand = new SqlCommand("Insert into Emp values (@EmpId,@EmpName,@EmpDesig,@Salary)", con);
                cmd.InsertCommand.Parameters.AddWithValue("EmpId", e.EmpId);
                cmd.InsertCommand.Parameters.AddWithValue("EmpName", e.EmpName);
                cmd.InsertCommand.Parameters.AddWithValue("EmpDesig", e.EmpDesig);
                cmd.InsertCommand.Parameters.AddWithValue("Salary", e.Salary);
                con.Open();
                return cmd.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public int UpdateEmployee(Emp e)
        {
            try
            {
                cmd.InsertCommand = new SqlCommand("Update Emp set EmpName=@EmpName,EmpDesig=@EmpDesig,Salary=@Salary where EmpId=@EmpId", con);
                cmd.InsertCommand.Parameters.AddWithValue("EmpId", e.EmpId);
                cmd.InsertCommand.Parameters.AddWithValue("EmpName", e.EmpName);
                cmd.InsertCommand.Parameters.AddWithValue("EmpDesig", e.EmpDesig);
                cmd.InsertCommand.Parameters.AddWithValue("Salary", e.Salary);
                con.Open();
                return cmd.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        public int DeleteEmployee(Emp e)
        {
            try
            {
                cmd.InsertCommand = new SqlCommand("Delete Emp where EmpId=@EmpId", con);
                cmd.InsertCommand.Parameters.AddWithValue("EmpId", e.EmpId);
                con.Open();
                return cmd.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        

        public Employee RetriveAll()
        {
            try
            {
                Employee empl = new Employee();
                
                con.Open();
                com = new SqlCommand("select EmpId,EmpName,EmpDesig,Salary from Emp", con);
                cmd = new SqlDataAdapter(com);
              
                dt = new DataTable("Paging");
                cmd.Fill(dt);
                empl.EmployeeTable = dt;
                return empl;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
