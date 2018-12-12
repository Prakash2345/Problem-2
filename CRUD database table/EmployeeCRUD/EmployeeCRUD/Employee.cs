using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCRUD
{
    public class Employee
    {
        int empId, salary;
        string empName, empDesig;

        public int EmpId
        {
            get
            {
                return empId;
            }
            set
            {
                empId = value;
            }
        }

        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }

        public string EmpDesig
        {
            get
            {
                return empDesig;
            }
            set
            {
                empDesig = value;
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
    }
}
