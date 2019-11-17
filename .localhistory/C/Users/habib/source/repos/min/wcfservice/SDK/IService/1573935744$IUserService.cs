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
    public interface IUserService
    {
        [OperationContract]
        bool AddUser(User user);
        [OperationContract]
        bool EditUser(User user);
        [OperationContract]
        bool DeleteUser(User user);
        [OperationContract]
        User FindUser(int ID);
        [OperationContract]
        List<User> FindUsers(String key);
        [OperationContract]
        List<User> GetAllUsers();

    }
}
