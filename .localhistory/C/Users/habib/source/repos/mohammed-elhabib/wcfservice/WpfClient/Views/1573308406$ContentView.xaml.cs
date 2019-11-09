using System;
using System.Collections.Generic;
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
using WpfClient.ViewModels;

namespace WpfClient.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ContentView : Window
    {
       private ContentViewModel _viewModelBase;

        public ContentView(ContentViewModel _viewModelBase)
        {
            InitializeComponent();
            Task.Delay(5000);

            this._viewModelBase =  _viewModelBase;
            this.DataContext = this._viewModelBase;
         //   MessageBox.Show(this.DataContext+"");
        }
    }
}
