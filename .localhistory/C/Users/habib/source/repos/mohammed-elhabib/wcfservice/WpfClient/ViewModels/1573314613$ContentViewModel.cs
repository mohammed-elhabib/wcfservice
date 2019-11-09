using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfClient.Views;

namespace WpfClient.ViewModels
{

    public class ContentViewModel : ViewModelBase
    {
        public double width { get { return _contentControl.Width; }  }
        public double height { get { return _contentControl.Height; } }
        private ContentControl _contentControl  ;
        public ContentControl ContentControl
        {
            get
            {
                return _contentControl;
            }
            set
            {
                _contentControl = value;
                OnPropertyChanged("height");
                OnPropertyChanged("width");
                MessageBox.Show(width + " "+ height);
            }
        }
       public ContentViewModel(ContentControl contentControl) {
          this._contentControl = contentControl;
        }
    }
}
