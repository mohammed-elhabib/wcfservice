using MefAction.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfClient.ViewModels.ExtenionViewModel
{
  public  class ExtentionViewModel:ViewModelBase
    {
        private IExtention _extention;

        public ContentControl ItemExtenion
        {
            get
            {
                return (ContentControl) _extention.View;
            }
            
        }


        public ExtentionViewModel(IExtention extention) {


            _extention = extention;
        }
    }
}
