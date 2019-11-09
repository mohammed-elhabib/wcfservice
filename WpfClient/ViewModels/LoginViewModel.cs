using System;
using System.Collections.Generic;
using System.Linq;
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
       public ICommand loginCommand { get; set; }
       public ICommand PowerCommand { get; set; }

        public LoginViewModel()
        {
            loginCommand = new Command(LoginAction);
            PowerCommand = new Command(PowerAction);


        }
        public void PowerAction() => System.Windows.Application.Current.Shutdown();

        public void LoginAction() {
            Ico.GetValue<ContentViewModel>().ContentControl = new AppView();
          Ico.GetValue<Window>().WindowState = WindowState.Maximized;
            
        }
    }
}
