using SDK.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfClient.Lib;

namespace WpfClient.ViewModels.UserViewModels.ViewType
{
 public  class CardViewModel:ViewModelBase, IViewType<User>

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
                _UserSelect = value;
            }

        }
      public CardViewModel()
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
    }
}
