using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfClient.ViewModels
{
    class AppViewModel
    {

        public void PowerAction() => System.Windows.Application.Current.Shutdown();

        public void MinAction() => System.Windows.Application.Current.MainWindow.WindowState = WindowState.Minimized; 

        public void ResizeAction() => System.Windows.Application.Current.MainWindow.WindowState ^= WindowState.Maximized;



    }
}
