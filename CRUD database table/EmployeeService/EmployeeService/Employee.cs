using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EmployeeService
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public DataTable EmployeeTable
        {
            get;
            set;
        }

    }
}