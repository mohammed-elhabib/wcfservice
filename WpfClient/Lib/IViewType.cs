using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.Lib
{
 public  interface IViewType<T>
    {
        void UpdateView(ObservableCollection<T> t); 
        T SelectItem();
      
        void SetButtonVisibility(Action<bool> ButtonVisibility);
    }
}
