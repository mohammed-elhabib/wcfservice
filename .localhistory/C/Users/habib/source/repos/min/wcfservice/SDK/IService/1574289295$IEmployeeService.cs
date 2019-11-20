using SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SDK.IServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUser" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        bool AddEmployee(Employee employee);
        [OperationContract]
        bool EditEmployee(Employee employee);
        [OperationContract]
        bool DeleteEmployee(Employee employee);
        [OperationContract]
        List<Employee> GetAllEmployees(int page, int pageSize);
        Employee FindEmployee(int ID);
        [OperationContract]
        List<Employee> FindEmployees(String key);
      
    }
}
