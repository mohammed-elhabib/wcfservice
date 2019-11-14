using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfClient.ViewModels;
using WpfClient.ViewModels.DailogViewModel;
using WpfClient.Views.DailogView;

namespace WpfClient.Lib.Dailog
{
    public interface IDialogService
    {
        T OpenDialog<T>(DialogViewModelBase<T> viewModel);
    }

    public class DialogService : IDialogService
    {
        public T OpenDialog<T>(DialogViewModelBase<T> viewModel)
        {
            Ico.GetValue<ContentViewModel>().GridVisibility = Visibility.Visible;
            IDialogWindow window = new DialogWindow();
             viewModel.SetWindow(window);
             window.DataContext = viewModel;
             window.ShowDialog();
             return viewModel.DialogResult;
        }
    }
}
