using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeService
{
    [DataContract]
    public class Emp
    {
        int empId,salary;
        string empName, empDesig;
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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
        [DataMember]
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