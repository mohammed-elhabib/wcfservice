using SDK.IServices;
using SDK.Lib;
using SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CommentExtenion.ViewModel
{
  public  class CommentViewModel:ViewModelBase
    {
        public String Comment { get; set; }
        public ICommand SaveCommand { get; set; }
        private User _user;
        public CommentViewModel(User user) {

            _user = user;
            Comment = user.Comment;
            SaveCommand = new Command(SaveComment);
        }

        private void SaveComment()
        {
            _user.Comment = Comment;
            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();
            channel.EditUser(_user);
            MessageBox.Show("DONNE");
        }
    }
}
