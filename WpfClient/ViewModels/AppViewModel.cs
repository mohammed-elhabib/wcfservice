using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfClient.Lib;
using WpfClient.Views;
using WpfClient.Views.EmployeeViews;
using WpfClient.Views.UserViews;

namespace WpfClient.ViewModels
{
  public  class AppViewModel:ViewModelBase
    {

        private ContentControl _content= new UserView();
        public ContentControl Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
            }
        }
        public ICommand MinCommand { get; set; }
       public ICommand PowerCommand { get; set; }
        public ICommand ResizeCommand { get; set; }
        public ICommand UserCommand { get; set; }
        public ICommand EmployeeCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public AppViewModel() {
            this.PowerCommand = new Command(PowerAction);
            this.ResizeCommand = new Command(ResizeAction);
            this.MinCommand = new Command(MinAction);
            this.UserCommand = new Command(UserAction);
            this.EmployeeCommand = new Command(EmployeeAction);
            this.LogoutCommand = new Command(LogoutAction);


        }

        private void EmployeeAction()
        {
            Content = new EmployeeView();
        }

        private void UserAction()
        {
            Content = new UserView();
        }

        private void LogoutAction()
        {
            Ico.GetValue<ContentViewModel>().ContentControl = new LoginView();
            Ico.GetValue<Window>().WindowState ^= WindowState.Maximized;
        }

        public void PowerAction() => System.Windows.Application.Current.Shutdown();

        public void MinAction() => System.Windows.Application.Current.MainWindow.WindowState = WindowState.Minimized;

        public void ResizeAction() => System.Windows.Application.Current.MainWindow.WindowState ^= WindowState.Maximized;


    }
}
