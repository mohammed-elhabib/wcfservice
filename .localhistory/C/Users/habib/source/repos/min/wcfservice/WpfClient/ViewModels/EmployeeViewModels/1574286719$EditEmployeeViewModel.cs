using SDK.IServices;
using SDK.Model;
using System;
using System.Collections.Generic;
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

namespace WpfClient.ViewModels.EmployeeViewModels
{
    public class EditEmployeeViewModel : DialogViewModelBase<Employee>
    {
        public string employeeName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Job { get; set; }
        public string Pay { get; set; }
        public DateTime BirthDayDate { get; set; }
        public ICommand SaveCommand { get; set; }
        private Employee _employee { get; set; }
        public EditEmployeeViewModel(Employee employee,string title, ContentControl dailogcontent) : base(title, dailogcontent)
        {
            this._employee = employee;
            this.Pay = employee.Pay.ToString();
            this.Job = employee.job;
            this.BirthDayDate = employee.BirthDayDate;
            this.LastName = employee.LastName;
            this.FirstName = employee.FirstMidName;
            this.BirthDayDate = employee.BirthDayDate;
            SaveCommand = new Command(Createemployee);

        }
        public void Createemployee()
        {

            _employee.job = Job;
                _employee.Pay = int.Parse(Pay);
            _employee.BirthDayDate = this.BirthDayDate;
            _employee.LastName = this.LastName;
            _employee.FirstMidName = this.FirstName;
            _employee.BirthDayDate = this.BirthDayDate;
            _employee.Date_Up = DateTime.Now;
            var channelFactory = new ChannelFactory<IEmployeeService>(new BasicHttpBinding(), "http://localhost:8733/employee");
            var channel = channelFactory.CreateChannel();
            channel.EditEmployee(_employee);

            DialogService dialog = new DialogService();

            SuccessfullViewModel successfull = new SuccessfullViewModel("successfull", new SuccessfullView());
            dialog.OpenDialog<bool>(successfull);
            this.Close();
        }
    }
}
