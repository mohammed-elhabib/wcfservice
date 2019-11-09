﻿
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
 public static class Ico
    {


      private static IUnityContainer _container  = new UnityContainer();
        

       public static void SetValue<TFrom, TTo>() where TTo : TFrom
        {
            _container.RegisterType<TFrom, TTo>();
        }


        public static void GetValue<T>()
        {
            _container.Resolve<T>();
        }
        public static void SetSingleton<T>(T _object)
        {
            _container.RegisterSingleton<T>();
        }


    }
}
