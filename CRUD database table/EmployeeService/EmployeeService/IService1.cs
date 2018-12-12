using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int AddEmployee(Emp e);
        [OperationContract]
        int UpdateEmployee(Emp e);
        [OperationContract]
        int DeleteEmployee(Emp e);
        
        [OperationContract]
        Employee RetriveAll();

    }
}
