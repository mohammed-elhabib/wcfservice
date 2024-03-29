﻿using SDK.IServices;
using SDK.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfClient.Lib;
using WpfClient.Lib.Dailog;
using WpfClient.ViewModels.DailogViewModel;
using WpfClient.Views.DailogView;
using WpfClient.Views.UserViews;

namespace WpfClient.ViewModels.UserViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private ObservableCollection<User> _users;
        private User _userSelect;

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set { _users = value; }

        }
        public User UserSelect
        {
            get { return _userSelect; }
            set
            {
                _userSelect = value;
            }

        }
        public ICommand CreateCommand { get; private set; }
        public ICommand RemoveCommand { get; private set; }
        public ICommand EditCommand { get; private set; }
        public ICommand SearchCommand { get; private set; }
        public ICommand ViewCommand { get; private set; }
        public UserViewModel()
        {
            this.UpdateUsers();
            CreateCommand = new Command(CreateUser);
            RemoveCommand = new Command(RemoveUser);
            EditCommand = new Command(EditUser);
            ViewCommand = new Command(ViewUser);
            SearchCommand = new CommandByPar(SearchUser);

        }

        private void SearchUser(object obj)
        {
            string text = (string)obj;

            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();
            Users = new ObservableCollection<User>(channel.FindUsers(text));

        }

        private void UpdateUsers()
        {

            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();
            Users = new ObservableCollection<User>(channel.GetAllUsers());

        }
        public void CreateUser()
        {
            DialogService dialog = new DialogService();

            CreateUserViewModel createUser = new CreateUserViewModel("create user", new CreateUserView());
            dialog.OpenDialog<User>(createUser);
            this.UpdateUsers();

        }
        public void RemoveUser()
        {
            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();

            if (_userSelect != null)
            {
                channel.DeleteUser(_userSelect);
                DialogService dialog = new DialogService();

                SuccessfullViewModel successfull = new SuccessfullViewModel("successfull", new SuccessfullView());
                dialog.OpenDialog<bool>(successfull);
                this.UpdateUsers();

            }
        }
        public void EditUser()
        {

            if (_userSelect != null)
            {

                DialogService dialog = new DialogService();
                EditUserViewModel editUser = new EditUserViewModel(_userSelect, "create user", new EditUserView());
                dialog.OpenDialog<User>(editUser);
                this.UpdateUsers();
            }
        }
        public void ViewUser()
        {

            if (_userSelect != null)
            {

                DialogService dialog = new DialogService();
                ViewUserViewModel vieweUser = new ViewUserViewModel(_userSelect, "create user", new ViewUserView());
                dialog.OpenDialog<User>(vieweUser);
                this.UpdateUsers();
            }
        }
    }
}
