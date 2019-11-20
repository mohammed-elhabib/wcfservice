using SDK.IServices;
using SDK.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfClient.Lib;
using WpfClient.Lib.Dailog;
using WpfClient.ViewModels.DailogViewModel;
using WpfClient.Views.DailogView;
using WpfClient.Views.EmployeeViews;
using WpfClient.Views.EmployeeViews.ViewTypes;

namespace WpfClient.ViewModels.EmployeeViewModels
{
    public class EmployeeViewModel : ViewModelBase
    {
        private ContentControl _viewData { get; set; }
        private string _pageNum { get; set; } = "1";
        private string _numOfRow { get; set; } = "15";

     //   public  ObservableCollection<Employee> _Employees;
   //     public  Employee _EmployeeSelect;
    /*    public ObservableCollection<Employee> Employees
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

        }*/
        public string PageNum
        {
            get { return _pageNum; }
            set {
                var page = int.Parse(value);
                if (!(page < 0))
                {
                    this.UpdateEmployees(int.Parse(value), int.Parse(_numOfRow));
                    _pageNum = value;
                }
                else
                {
                    _pageNum = 1 + "";
                }
            }
        }
        public string NumOfRow
        {
            get { return _numOfRow; }
            set {
                var row = int.Parse(value);
                if (!(row < 0))
                {
                    this.UpdateEmployees(int.Parse(_pageNum), int.Parse(value));
                    _numOfRow = value;
                }
                else
                {
                    _numOfRow =1+"";
                }
 }

        }
        public ContentControl ViewData
        {
            get { return _viewData; }
            set {
                    _viewData = value; }

        }
        
        public ICommand CreateCommand { get; private set; }
        public ICommand RemoveCommand { get; private set; }
        public ICommand EditCommand { get; private set; }
        public ICommand SearchCommand { get; private set; }
        public ICommand ViewCommand { get; private set; }
        public ICommand NextCommand { get; private set; }
        public ICommand PreviousCommand { get; private set; }
        public ICommand TableCommand { get; private set; }
        public ICommand CardCommand { get; private set; }

        public EmployeeViewModel()
        {
            _viewData = new CradView();

            this.UpdateEmployees(int.Parse(_pageNum), int.Parse(_numOfRow));
            CardCommand = new Command(CardAction);
            TableCommand = new Command(TableAction);
            NextCommand = new Command(NextAction);
            PreviousCommand = new Command(PreviousAction);
            CreateCommand = new Command(CreateEmployee);
            RemoveCommand = new Command(RemoveEmployee);
            EditCommand = new Command(EditEmployee);
            ViewCommand = new Command(ViewEmployee);
            SearchCommand = new CommandByPar(SearchEmployee);
        
        }

        private void CardAction()
        {
            if (!(_viewData is CradView))
            {
                _viewData = new CradView();
                this.UpdateEmployees(int.Parse(_pageNum), int.Parse(_numOfRow));
            }
        }

        private void TableAction()
        {
            if (!(_viewData is TableView))
            {
                _viewData = new TableView();
                this.UpdateEmployees(int.Parse(_pageNum), int.Parse(_numOfRow));
            }
        }

        private void PreviousAction()
        { var page = int.Parse(_pageNum)-1;
            if (page > 0) {
                _pageNum = page+"";
                this.UpdateEmployees(page, int.Parse(_numOfRow));
}
        }

        private void NextAction()
        {
            var page = int.Parse(_pageNum) +1;
            if (page > 0)
            {
                _pageNum = page + "";
                this.UpdateEmployees(page, int.Parse(_numOfRow));
            }
        }

        private void SearchEmployee(object obj)
        {
            string text = (string)obj;

            var channelFactory = new ChannelFactory<IEmployeeService>(new BasicHttpBinding(), "http://localhost:8733/Employee");
            var channel = channelFactory.CreateChannel();
             
            (_viewData as IViewType<Employee>).UpdateView(new ObservableCollection<Employee>(channel.FindEmployees(text, int.Parse(_pageNum), int.Parse(_numOfRow))));
        }

        private void UpdateEmployees(int page,int row)
        {

            var channelFactory = new ChannelFactory<IEmployeeService>(new BasicHttpBinding(), "http://localhost:8733/Employee");
            var channel = channelFactory.CreateChannel();
            (_viewData as IViewType<Employee>).UpdateView(new ObservableCollection<Employee>(channel.GetAllEmployees(page, row)));


        }
        public void CreateEmployee()
        {
            DialogService dialog = new DialogService();

            CreateEmployeeViewModel createEmployee = new CreateEmployeeViewModel("create Employee", new CreateEmployeeView());
            dialog.OpenDialog<Employee>(createEmployee);
            this.UpdateEmployees(int.Parse(_pageNum), int.Parse(_numOfRow));

        }
        public void RemoveEmployee()
        {
            var channelFactory = new ChannelFactory<IEmployeeService>(new BasicHttpBinding(), "http://localhost:8733/Employee");
            var channel = channelFactory.CreateChannel();
            var _EmployeeSelect = (_viewData as IViewType<Employee>).SelectItem();
            if (_EmployeeSelect != null)
            {
                channel.DeleteEmployee(_EmployeeSelect);
                DialogService dialog = new DialogService();

                SuccessfullViewModel successfull = new SuccessfullViewModel("successfull", new SuccessfullView());
                dialog.OpenDialog<bool>(successfull);
                this.UpdateEmployees(int.Parse(_pageNum), int.Parse(_numOfRow));

            }
        }
        public void EditEmployee()
        {
            var _EmployeeSelect = (_viewData as IViewType<Employee>).SelectItem();

            if (_EmployeeSelect != null)
            {

                DialogService dialog = new DialogService();
                EditEmployeeViewModel editEmployee = new EditEmployeeViewModel(_EmployeeSelect, "create Employee", new EditEmployeeView());
                dialog.OpenDialog<Employee>(editEmployee);
                this.UpdateEmployees(int.Parse(_pageNum), int.Parse(_numOfRow));
            }
        }
        public void ViewEmployee()
        {
            var _EmployeeSelect = (_viewData as IViewType<Employee>).SelectItem();
            if (_EmployeeSelect != null)
            {

                DialogService dialog = new DialogService();
                ViewEmployeeViewModel vieweEmployee = new ViewEmployeeViewModel(_EmployeeSelect, "create Employee", new ViewEmployeeView());
                dialog.OpenDialog<Employee>(vieweEmployee);
                this.UpdateEmployees(int.Parse(_pageNum), int.Parse(_numOfRow));
            }
        }
    }
}
