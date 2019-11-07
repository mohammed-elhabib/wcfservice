using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfClient.ViewModels
{
    public class LoginViewModel
    {
        public void PowerAction() => System.Windows.Application.Current.Shutdown();

      public void LoginAction() {
          
        }
    }
}
