using MefAction.Interface;
using SDK.IServices;
using SDK.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfClient.Lib;
using WpfClient.Lib.Dailog;
using WpfClient.Lib.Extenion;
using WpfClient.ViewModels.DailogViewModel;
using WpfClient.Views.DailogView;

namespace WpfClient.ViewModels.UserViewModels
{
    public class ViewUserViewModel : DialogViewModelBase<User>
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public IEnumerable<IExtention> UserExtenions { get; set; }
        public DateTime BirthDayDate { get; set; }
        public ICommand SaveCommand { get; set; }
        private User _user { get; set; }
        public ViewUserViewModel(User user,string title, ContentControl dailogcontent) : base(title, dailogcontent)
        {
            this._user = user;
            this.BirthDayDate = user.BirthDayDate;
            this.UserName = user.Usename;
            this.LastName = user.LastName;
            this.FirstName = user.FirstMidName;
            this.BirthDayDate = user.BirthDayDate;
            SaveCommand = new CommandByPar(CreateUser);
            var im = new InportManger();
            UserExtenions = im.ExtenionList;
            foreach(var ex in UserExtenions)
            {
                ex.DoAction<User>(_user);
                ex.


            }
        }
        public void CreateUser(object ob)
        {

            var passowrd = (ob as PasswordBox).Password;
            _user.BirthDayDate = this.BirthDayDate;
            _user.Usename = this.UserName;
            _user.LastName = this.LastName;
            _user.FirstMidName = this.FirstName;
            _user.BirthDayDate = this.BirthDayDate;
            _user.Date_Up = DateTime.Now;
            _user.Password = passowrd;
            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();
            channel.EditUser(_user);

            DialogService dialog = new DialogService();

            SuccessfullViewModel successfull = new SuccessfullViewModel("successfull", new SuccessfullView());
            dialog.OpenDialog<bool>(successfull);
            this.Close();
        }
    }
}
