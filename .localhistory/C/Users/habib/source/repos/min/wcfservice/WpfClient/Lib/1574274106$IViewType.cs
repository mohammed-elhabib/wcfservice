using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.Lib
{
 public  interface IViewType
    {
        void UpdateView<T>(T t); 
        T SelectItem<T>(); 

    }
}
