using SDK.IServices;
using SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.ViewModels.UserViewModels
{
   public class UserViewModel:ViewModelBase
    {
        private List<User> _users;

        public List<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }
      public  UserViewModel() {
            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();
            _users=channel.GetAllUsers();

        }

    }
}
