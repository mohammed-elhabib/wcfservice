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
        private ContentControl _contentControl  ;
        public double with { get; set; }
        public double height { get; set; }

        public ContentControl ContentControl
        {
            get
            {
                return _contentControl;
            }
            set
            {
                _contentControl = value;
             with=   _contentControl.Width + 50;
             height=   _contentControl.Height + 50;
            }
        }
       public ContentViewModel(ContentControl contentControl) {
          this._contentControl = contentControl;
 }
    }
}
