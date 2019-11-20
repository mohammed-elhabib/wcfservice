using SDK.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfClient.Lib;
using WpfClient.ViewModels.UserViewModels.ViewType;

namespace WpfClient.Views.UserViews.ViewTypes
{
    /// <summary>
    /// Interaction logic for CradView.xaml
    /// </summary>
    public partial class CradView : UserControl,IViewType<User>
    {
        private CardViewModel viewmodel;
        public CradView( )
        {
            InitializeComponent();
             viewmodel=  new CardViewModel();
            this.DataContext = viewmodel;
        }
        
        
        public User SelectItem()
        {
            return viewmodel.SelectItem();
        }

        
        public void UpdateView(ObservableCollection<User> t)
        {
            viewmodel.UpdateView(t);
        }
    }
}
