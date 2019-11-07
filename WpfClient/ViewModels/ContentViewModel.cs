using Caliburn.Micro;
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

    public class ContentViewModel : Screen
    {

        private  _contentControl =;
        public ContentControl ContentControl
        {
            get
            {
                return _contentControl;
            }
            set
            {
                _contentControl = value;
              NotifyOfPropertyChange(() => _contentControl);
            }
        }
       public ContentViewModel() {
         //   this._contentControl = contentControl;

        }
    }
}
