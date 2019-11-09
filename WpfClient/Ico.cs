
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Unity;
using Unity.Injection;
using Unity.Resolution;
using WpfClient.ViewModels;
using WpfClient.Views;

namespace WpfClient
{
 public static class Ico
    {


      private static IUnityContainer _container  = new UnityContainer();
        

       public static void SetValue<TFrom, TTo>() where TTo : TFrom
        {
            _container.RegisterType<TFrom, TTo>();
        }

        internal static void Startup()
        {
           SetSingleton<ContentControl, LoginView>();
           SetSingleton<ContentViewModel, ContentViewModel>();
           SetSingleton<Window, ContentView>();

        }

        public static T GetValue<T>()
        {
          return  _container.Resolve<T>();
        }

        public static void SetSingleton<T,F> ()where F:T
        {
            _container.RegisterSingleton<T,F>();
        }


    }
}
