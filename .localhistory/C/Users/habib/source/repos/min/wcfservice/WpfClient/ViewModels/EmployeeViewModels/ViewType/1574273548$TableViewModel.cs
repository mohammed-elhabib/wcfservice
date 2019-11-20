using SDK.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfClient.ViewModels.EmployeeViewModels.ViewType
{
 public  class TableViewModel:ViewModelBase
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
                _EmployeeSelect = value;
            }

        }
    public TableViewModel(ref ObservableCollection<Employee> _Employees, ref Employee _EmployeeSelect)
        {
            this.Employees = _Employees;
            this.EmployeeSelect = _EmployeeSelect;
        }
    }
}
