using ActiveExtenion.View;
using MefAction.Interface;
using SDK.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ActiveUserExtenion.ViewModel
{

    [Export(typeof(IExtention))]
    public class ViewModel : IExtention
    {
        public string Name => "Active User Extenion";

        public string ViewName { get; set; }
        public FrameworkElement View { get ; set ; }
        
        public ICommand command { get; set; }
        private object _object { get; set; }

        public  ViewModel( ) {
               //_object = user;
           ViewName = "Active";
            View = new View();
            View.DataContext = this;
            command = new Command(ActiveUser); ;
           }

        public void ActiveUser() {
            var user = (User)_object;

            MessageBox.Show(user.ID.ToString());
        }

        public void SetObject(object _object)
        {
            this._object = _object;
        }
    }
}
