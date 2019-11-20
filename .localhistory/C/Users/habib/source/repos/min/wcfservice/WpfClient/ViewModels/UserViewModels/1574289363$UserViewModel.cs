using SDK.IServices;
using SDK.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfClient.Lib;
using WpfClient.Lib.Dailog;
using WpfClient.ViewModels.DailogViewModel;
using WpfClient.Views.DailogView;
using WpfClient.Views.UserViews;
using WpfClient.Views.UserViews.ViewTypes;

namespace WpfClient.ViewModels.UserViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private ContentControl _viewData { get; set; }
        private string _pageNum { get; set; } = "1";
        private string _numOfRow { get; set; } = "15";
        public string PageNum
        {
            get { return _pageNum; }
            set
            {
                var page = int.Parse(value);
                if (!(page < 0))
                {
                    this.UpdateUsers(int.Parse(value), int.Parse(_numOfRow));
                    _pageNum = value;
                }
                else
                {
                    _pageNum = 1 + "";
                }
            }
        }
        public string NumOfRow
        {
            get { return _numOfRow; }
            set
            {
                var row = int.Parse(value);
                if (!(row < 0))
                {
                    this.UpdateUsers(int.Parse(_pageNum), int.Parse(value));
                    _numOfRow = value;
                }
                else
                {
                    _numOfRow = 1 + "";
                }
            }

        }
        public ContentControl ViewData
        {
            get { return _viewData; }
            set
            {
                _viewData = value;
            }

        }

        public ICommand CreateCommand { get; private set; }
        public ICommand RemoveCommand { get; private set; }
        public ICommand EditCommand { get; private set; }
        public ICommand SearchCommand { get; private set; }
        public ICommand ViewCommand { get; private set; }
        public ICommand NextCommand { get; private set; }
        public ICommand PreviousCommand { get; private set; }
        public ICommand TableCommand { get; private set; }
        public ICommand CardCommand { get; private set; }

        public UserViewModel()
        {
            _viewData = new CradView();

            this.UpdateUsers(int.Parse(_pageNum), int.Parse(_numOfRow));
            CardCommand = new Command(CardAction);
            TableCommand = new Command(TableAction);
            NextCommand = new Command(NextAction);
            PreviousCommand = new Command(PreviousAction);
            CreateCommand = new Command(CreateUser);
            RemoveCommand = new Command(RemoveUser);
            EditCommand = new Command(EditUser);
            ViewCommand = new Command(ViewUser);
            SearchCommand = new CommandByPar(SearchUser);

        }

        private void CardAction()
        {
            if (!(_viewData is CradView))
            {
                _viewData = new CradView();
                this.UpdateUsers(int.Parse(_pageNum), int.Parse(_numOfRow));
            }
        }

        private void TableAction()
        {
            if (!(_viewData is TableView))
            {
                _viewData = new TableView();
                this.UpdateUsers(int.Parse(_pageNum), int.Parse(_numOfRow));
            }
        }

        private void PreviousAction()
        {
            var page = int.Parse(_pageNum) - 1;
            if (page > 0)
            {
                _pageNum = page + "";
                this.UpdateUsers(page, int.Parse(_numOfRow));
            }
        }

        private void NextAction()
        {
            var page = int.Parse(_pageNum) + 1;
            if (page > 0)
            {
                _pageNum = page + "";
                this.UpdateUsers(page, int.Parse(_numOfRow));
            }
        }


        private void SearchUser(object obj)
        {
            string text = (string)obj;

            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();

            (_viewData as IViewType<User>).UpdateView(new ObservableCollection<User>(channel.FindUsers(text)));
        }

        private void UpdateUsers(int page, int row)
        {

            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();
            (_viewData as IViewType<User>).UpdateView(new ObservableCollection<User>(channel.GetAllUsers(page, row)));


        }
        public void CreateUser()
        {
            DialogService dialog = new DialogService();

            CreateUserViewModel createUser = new CreateUserViewModel("create user", new CreateUserView());
            dialog.OpenDialog<User>(createUser);
            this.UpdateUsers(int.Parse(_pageNum), int.Parse(_numOfRow));

        }
        public void RemoveUser()
        {
            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();
            var _userSelect = (_viewData as IViewType<User>).SelectItem();

            if (_userSelect != null)
            {
                channel.DeleteUser(_userSelect);
                DialogService dialog = new DialogService();

                SuccessfullViewModel successfull = new SuccessfullViewModel("successfull", new SuccessfullView());
                dialog.OpenDialog<bool>(successfull);
                this.UpdateUsers(int.Parse(_pageNum), int.Parse(_numOfRow));

            }
        }
        public void EditUser()
        {
            var _userSelect = (_viewData as IViewType<User>).SelectItem();

            if (_userSelect != null)
            {

                DialogService dialog = new DialogService();
                EditUserViewModel editUser = new EditUserViewModel(_userSelect, "create user", new EditUserView());
                dialog.OpenDialog<User>(editUser);
                this.UpdateUsers(int.Parse(_pageNum), int.Parse(_numOfRow));
            }
        }
        public void ViewUser()
        {
            var _userSelect = (_viewData as IViewType<User>).SelectItem();

            if (_userSelect != null)
            {

                DialogService dialog = new DialogService();
                ViewUserViewModel vieweUser = new ViewUserViewModel(_userSelect, "create user", new ViewUserView());
                dialog.OpenDialog<User>(vieweUser);
                this.UpdateUsers(int.Parse(_pageNum), int.Parse(_numOfRow));
            }
        }
    }
}
