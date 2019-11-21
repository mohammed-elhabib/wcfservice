using SDK.IServices;
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
using WpfClient.Views;

namespace WpfClient.ViewModels
{
    public class LoginViewModel: ViewModelBase
    {
       public string Username { get; set; }
       public ICommand loginCommand { get; set; }
       public ICommand PowerCommand { get; set; }

        public LoginViewModel()
        {
            loginCommand = new CommandByPar(LoginAction);
            PowerCommand = new Command(PowerAction);
        }
        public void PowerAction() => System.Windows.Application.Current.Shutdown();

        public void LoginAction(object ob) {

            var passowrd = (ob as PasswordBox).Password;
            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();
            if (channel.LoginUser(Username, passowrd))
            {
                Ico.GetValue<ContentViewModel>().ContentControl = new AppView();
                Ico.GetValue<Window>().WindowState = WindowState.Maximized;
            }
        }
    }
}
