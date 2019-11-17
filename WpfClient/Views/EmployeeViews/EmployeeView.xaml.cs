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
using WpfClient.ViewModels.EmployeeViewModels;

namespace WpfClient.Views.EmployeeViews
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class EmployeeView : UserControl
    {
        public EmployeeView()
        {
            this.DataContext = new EmployeeViewModel();
            InitializeComponent();
        }
    }
}
