using SDK.IServices;
using SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfClient.Lib;
using WpfClient.Lib.Dailog;
using WpfClient.ViewModels.DailogViewModel;
using WpfClient.Views.DailogView;

namespace WpfClient.ViewModels.UserViewModels
{
    public class CreateUserViewModel : DialogViewModelBase<User>
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDayDate { get; set; }
        public ICommand CreateCommand { get; set; }
        public CreateUserViewModel(string title, ContentControl dailogcontent) : base(title, dailogcontent)
        {
            this.DialogResult = new User();
            CreateCommand = new CommandByPar(CreateUser);
        }
        public void CreateUser(object ob)
        {

            var passowrd = (ob as PasswordBox).Password;
            var newUser = new User()
            {
                Usename = UserName,
                Password = passowrd,
                BirthDayDate = BirthDayDate,
                FirstMidName = FirstName,
                LastName = LastName,
                Date_At = DateTime.Now,
                Date_Up = DateTime.Now
            };
            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();
            channel.AddUser(newUser);

            DialogService dialog = new DialogService();

            SuccessfullViewModel successfull = new SuccessfullViewModel("successfull", new SuccessfullView());
            dialog.OpenDialog<bool>(successfull);
            this.Close();
        }
    }
}
