
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Unity;
using WpfClient.ViewModels;
using WpfClient.Views;

namespace WpfClient
{
 public  class Ico
    {


       private IUnityContainer _container;
       public Ico() {
            _container = new UnityContainer();
       }

       public void SetValue<TFrom, TTo>() where TTo : TFrom
        {
            _container.RegisterType<TFrom, TTo>();
        }


        public void GetValue<T>()
        {
            _container.Resolve<T>();
        }
        public void SetSingleton<T>(T _object)
        {
            _container.RegisterSingleton<T>();
        }


    }
}
