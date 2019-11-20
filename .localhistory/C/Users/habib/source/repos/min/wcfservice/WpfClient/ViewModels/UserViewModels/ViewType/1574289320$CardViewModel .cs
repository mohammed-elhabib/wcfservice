using SDK.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfClient.Lib;

namespace WpfClient.ViewModels.EmployeeViewModels.ViewType
{
 public  class CardViewModel:ViewModelBase, IViewType<Employee>

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
      public CardViewModel()
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
    }
}
