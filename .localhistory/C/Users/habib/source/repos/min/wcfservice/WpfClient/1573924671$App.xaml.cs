﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfClient.Lib.Extenion;
using WpfClient.Views;

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var im = new InportManger();
            

       //     Ico.Startup();
       //Current.MainWindow = Ico.GetValue<Window>();
       //   Current.MainWindow.Show();
        }
    }
}
