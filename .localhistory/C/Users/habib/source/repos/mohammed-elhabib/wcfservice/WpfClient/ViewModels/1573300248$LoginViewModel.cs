﻿using System;
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
        public void PowerAction() => System.Windows.Application.Current.Shutdown();
        ICommand loginCommand;

        public LoginViewModel()
        {
            loginCommand = new Command(LoginAction);


        }
      public void LoginAction() {
            Ico.GetValue<ViewModelBase>("_contentControl",new AppView());
            Ico.GetValue<Window>().WindowState = WindowState.Maximized;
            
        }
    }
}