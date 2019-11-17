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
     //  public ICommand command { get; set; }
        public void DoAction()
        {
          
        }
     /*  public  ViewModel( ) {
            //_object = user;
            ViewName = "Active";
            command = new Command(DoAction); ;
        }
       */ public FrameworkElement GetGUI()
        {
            FrameworkElement gui;//= new View();
         //   gui.DataContext = this;
            return null;
        }
    }
}
