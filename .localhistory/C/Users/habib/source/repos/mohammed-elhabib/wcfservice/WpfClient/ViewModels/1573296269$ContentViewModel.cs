using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfClient.ViewModels
{

    public class ContentViewModel : ViewModelBase
    {

        private ContentControl _contentControl ;
        public ContentControl ContentControl
        {
            get
            {
                return _contentControl;
            }
            set
            {
                _contentControl = value;
            }
        }
       public ContentViewModel() {
         //   this._contentControl = contentControl;

        }
    }
}
