using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfClient.Lib;

namespace WpfClient.ViewModels.DailogViewModel
{
    public class SuccessfullViewModel : DialogViewModelBase<bool>
    {
        public ICommand CloseCommand { get; set; }

        public SuccessfullViewModel(string title, ContentControl dailogcontent) : base(title, dailogcontent)
        {
            CloseCommand = new Command(Close);
        }
    }
}
