using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfClient.Lib;

namespace WpfClient.ViewModels
{
  public  class AppViewModel:ViewModelBase
    {
       public ICommand MinCommand { get; set; }
       public ICommand PowerCommand { get; set; }
       public ICommand ResizeCommand { get; set; }
        public AppViewModel() {
            this.PowerCommand = new Command(PowerAction);
            this.ResizeCommand = new Command(ResizeAction);
            this.MinCommand = new Command(MinAction);


        }

        public void PowerAction() => System.Windows.Application.Current.Shutdown();

        public void MinAction() => System.Windows.Application.Current.MainWindow.WindowState = WindowState.Minimized;

        public void ResizeAction() => System.Windows.Application.Current.MainWindow.WindowState ^= WindowState.Maximized;


    }
}
