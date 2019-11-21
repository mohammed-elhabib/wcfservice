using SDK.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfClient.Lib;

namespace WpfClient.ViewModels.EmployeeViewModels.ViewType
{
 public  class TableViewModel:ViewModelBase, IViewType<Employee>

    {

        private ObservableCollection<Employee> _Employees;
        private Employee _EmployeeSelect;
        public ObservableCollection<Employee> Employees
        {
            get { return _Employees; }
            set
            {

                _Employees = value;
            }

        }
        public Employee EmployeeSelect
        {
            get { return _EmployeeSelect; }
            set
            {
                MessageBox.Show(value + "///////");
                ButtonVisibility((value != null));
                _EmployeeSelect = value;
            }

        }
        public Action<bool> ButtonVisibility { get; set; }
        public TableViewModel()
        {
        }

        public void UpdateView(ObservableCollection<Employee> _Employees)
        {
            Employees = _Employees;
        }

        public Employee SelectItem()
        {
            return _EmployeeSelect;
        }

        public void SetButtonVisibility(Action<bool> ButtonVisibility)
        {
            this.ButtonVisibility = ButtonVisibility;
        }
    }
}
