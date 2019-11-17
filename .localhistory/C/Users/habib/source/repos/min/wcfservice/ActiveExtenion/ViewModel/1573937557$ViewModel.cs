using ActiveExtenion.View;
using MefAction.Interface;
using SDK.IServices;
using SDK.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ActiveUserExtenion.ViewModel
{

    [Export(typeof(IExtention))]
    public class ViewModel : IExtention
    {
        public string Name => "Active User Extenion";

        public string ViewName { get; set; }
        public FrameworkElement View { get ; set ; }
        
        public ICommand command { get; set; }
        public Brush Forground { get; set; }
        public object _objetc { get; set; }

        public  ViewModel( ) {
               //_object = user;
            View = new View();
            View.DataContext = this;
            command = new Command(ActiveUser); ;
           }

        public void ActiveUser() {
            var user = (User)_objetc;
             if (user.Active)
                user.Active = false;     
            else
                user.Active = true;
            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();
            channel.EditUser(user);

        }

        public void SetObject(object _object)
        {
            this._objetc = _object;
            var user = (User)_objetc;

            if (user.Active)
            {
                ViewName = "Disactive";
                Forground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                ViewName = "Active";
                Forground = new SolidColorBrush(Colors.Green);

            }

        }
    }
}
