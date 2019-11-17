using MefAction.Interface;
using SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfClient.ViewModels.ExtenionViewModels
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


        public ExtentionViewModel(User user, IExtention extention) {


            _extention = extention;
            _extention.SetObject(user);
        }
    }
}
