using SDK.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfClient.Lib;

namespace WpfClient.ViewModels.UserViewModels.ViewType
{
 public  class TableViewModel:ViewModelBase, IViewType<User>

    {

        private ObservableCollection<User> _Users;
        private User _UserSelect;
       
        public ObservableCollection<User> Users
        {
            get { return _Users; }
            set
            {

                _Users = value;
            }

        }
        public User UserSelect
        {
            get { return _UserSelect; }
            set
            {
                MessageBox.Show(value + "///////");
                 ButtonVisibility((value != null));
                _UserSelect = value;
            }

        }

        public Action<bool> ButtonVisibility { get ; set ; }

        public TableViewModel()
        {
        }

        public void UpdateView(ObservableCollection<User> _Users)
        {
            Users = _Users;
        }

        public User SelectItem()
        {
            return _UserSelect;
        }

        public void SetButtonVisibility(Action<bool> ButtonVisibility)
        {
            this.ButtonVisibility = ButtonVisibility;
        }
    }
}
