using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfClient.ViewModels
{
  public  class AppViewModel:ViewModelBase
    {
    public double height { get; set; } =SystemParameters.PrimaryScreenHeight;
     public double width { get; set; } =SystemParameters.PrimaryScreenWidth;
   
        public void PowerAction() => System.Windows.Application.Current.Shutdown();

        public void MinAction() => System.Windows.Application.Current.MainWindow.WindowState = WindowState.Minimized; 

        public void ResizeAction() => System.Windows.Application.Current.MainWindow.WindowState ^= WindowState.Maximized;
        public AppViewModel() {

            height = SystemParameters.PrimaryScreenHeight;
            width = SystemParameters.PrimaryScreenWidth;
        }


    }
}
