using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfClient.Lib;
using WpfClient.Lib.Dailog;

namespace WpfClient.ViewModels.DailogViewModel
{

    public abstract class DialogViewModelBase<T> : ViewModelBase
    {
        private IDialogWindow _currentWindow;


        public string Title { get; set; }
        public T DialogResult { get; set; }
        private ContentControl _dailogContent;

        public ContentControl DailogContent
        {
            get { return _dailogContent; }
            set { _dailogContent = value; }
        }
        public ICommand PowerCommand { get; set; }
        public DialogViewModelBase() : this(string.Empty, null) { }
        public DialogViewModelBase(string title) : this(title, null) { }
        public DialogViewModelBase(string title, ContentControl dailogcontent)
        {
            Title = title;
            _dailogContent = dailogcontent;
            PowerCommand = new Command(CloseDialogWithResult);
        }

        public void SetWindow(IDialogWindow window)
        {
            this._currentWindow = window;
        }
        public void CloseDialogWithResult()
        {

            if (_currentWindow != null)
            {
                _currentWindow.DialogResult = true;
                _currentWindow.Close();
            }
            Ico.GetValue<ContentViewModel>().GridVisibility = Visibility.Collapsed;
        }
        public void Close() {
            _currentWindow.Close();
            Ico.GetValue<ContentViewModel>().GridVisibility = Visibility.Collapsed;
        }
    }
}
