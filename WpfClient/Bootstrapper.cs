﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfClient.ViewModels;
using WpfClient.Views;

namespace WpfClient
{
    class Bootstrapper : BootstrapperBase
    {
      ///  private SimpleContainer _container = new SimpleContainer();

            public Bootstrapper() {
                 Initialize();

        //    _container.Singleton<IWindowManager,WindowManager>();
          //  _container.Singleton<ContentViewModel>();
           // _container.Singleton<ContentControl,LoginView>();

        }

        protected override void OnStartup(object sender, StartupEventArgs e)
            {
               DisplayRootViewFor<ContentViewModel>();

            }
          /* 
	       protected override object GetInstance(Type serviceType, string key)
            {
                return _container.GetInstance(serviceType, key);
            }

            protected override IEnumerable<object> GetAllInstances(Type serviceType)
            {
                return _container.GetAllInstances(serviceType);
            }

            protected override void BuildUp(object instance)
            {
                _container.BuildUp(instance);
            }

    */
    }
}
