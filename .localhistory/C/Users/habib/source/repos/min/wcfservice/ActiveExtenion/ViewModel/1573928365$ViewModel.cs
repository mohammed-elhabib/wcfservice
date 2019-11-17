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

        public User _object { get;set; }
        public string ViewName { get; set; }
        public FrameworkElement View { get ; set ; }

        public void DoAction<T>(T _object)
        {
            MessageBox.Show(_object.ToString());
        }

         public ICommand command { get; set; }

          public  ViewModel( ) {
               //_object = user;
               ViewName = "Active";
            View = new View();
            View.DataContext = this;
               command = new Command(()=> { MessageBox.Show("alii"); }); ;
           }
         
    }
}
