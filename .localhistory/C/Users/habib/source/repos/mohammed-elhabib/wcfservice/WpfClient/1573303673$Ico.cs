
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Unity;
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
            _container.RegisterSingleton<ContentViewModel, ContentViewModel>();

        }

        public static T GetValue<T>()
        {
          return  _container.Resolve<T>();
        }

        public static T GetValue<T>(string name,object _oject)
        {
            return _container.Resolve<T>(new ParameterOverride(name,_oject));
        }
        public static void SetSingleton<T,F> ()where F:T
        {
            _container.RegisterSingleton<T,F>();
        }


    }
}
