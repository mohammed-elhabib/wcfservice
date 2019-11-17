using CommentExtenion.Views;
using MefAction.Interface;
using SDK.IServices;
using SDK.Lib;
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

namespace CommentExtenion.ViewModel
{

    [Export(typeof(IExtention))]
    public class ViewModel : ViewModelBase, IExtention
    {
        public string Name => "Active User Extenion";

        public string ViewName { get; set; } 
        public FrameworkElement View { get ; set ; }
        
        public ICommand command { get; set; }
        public object _objetc { get; set; }

        public  ViewModel( ) {
               //_object = user;
            View = new View();
            View.DataContext = this;
            ViewName = "Comment";
            command = new Command(CommnetAction); ;
           }

        public void CommnetAction() {
            var user = (User)_objetc;
            CommentView commentView = new CommentView();
            commentView.DataContext = new CommentViewModel(user);
            commentView.Show();
        }

        public void SetObject(object _object)
        {
            this._objetc = _object;
        }
    }
}
