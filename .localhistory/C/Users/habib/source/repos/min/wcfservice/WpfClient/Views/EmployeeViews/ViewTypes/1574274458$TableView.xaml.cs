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
using WpfClient.ViewModels.EmployeeViewModels.ViewType;

namespace WpfClient.Views.EmployeeViews.ViewTypes
{
    /// <summary>
    /// Interaction logic for TableView.xaml
    /// </summary>
    public partial class TableView : UserControl
    {
        public TableView( ref ObservableCollection<Employee> _Employees, ref Employee _EmployeeSelect)
        {
            InitializeComponent();
            this.DataContext = new TableViewModel(ref _Employees,ref _EmployeeSelect);
        }
    }
}
