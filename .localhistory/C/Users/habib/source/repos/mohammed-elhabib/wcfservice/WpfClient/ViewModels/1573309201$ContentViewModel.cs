using System;
using System.Collections.Generic;
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

        public string txt { get; set; } = "Aaaaaaaaaaa";
        public double with { get { return _contentControl.Width + 50; } set { value= _contentControl.Width + 50; } }
        public  double height { get { return _contentControl.Height+50; } set { value = _contentControl.Height + 50; } }
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
            }
        }
       public ContentViewModel(ContentControl contentControl) {
          this._contentControl = contentControl;
 }
    }
}
