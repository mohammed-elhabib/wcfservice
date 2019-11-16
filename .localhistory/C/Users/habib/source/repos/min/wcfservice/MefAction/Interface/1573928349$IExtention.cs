using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MefAction.Interface
{
  public  interface IExtention
    {
        string Name { get; }
        string ViewName { get; set; }
        void DoAction<T>(T _object);

        FrameworkElement View { get; set; }
    }
}
