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
        object _objetc { get; set; }
        FrameworkElement View { get; set; }
        void SetObject(object _object);
    }
}
