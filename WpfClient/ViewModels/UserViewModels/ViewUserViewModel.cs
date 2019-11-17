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
using WpfClient.ViewModels.ExtenionViewModels;
using WpfClient.Views.DailogView;

namespace WpfClient.ViewModels.UserViewModels
{
    public class ViewUserViewModel : DialogViewModelBase<User>
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public IEnumerable<ExtentionViewModel> UserExtenions { get; set; }
        public DateTime BirthDayDate { get; set; }
        private User _user { get; set; }
        public ViewUserViewModel(User user,string title, ContentControl dailogcontent) : base(title, dailogcontent)
        {
            this._user = user;
            this.BirthDayDate = user.BirthDayDate;
            this.UserName = user.Usename;
            this.LastName = user.LastName;
            this.FirstName = user.FirstMidName;
            this.BirthDayDate = user.BirthDayDate;
            var im = new InportManger();
            UserExtenions = im.ExtenionList.ToList().Select((e) => new ExtentionViewModel(user,e));
            
        }
      
    }
}
