using MefAction.Interface;
using SDK.IServices;
using SDK.Model;
using System;
using System.Collections;
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
using WpfClient.Lib.Extenion;
using WpfClient.ViewModels.DailogViewModel;
using WpfClient.ViewModels.ExtenionViewModels;
using WpfClient.Views.DailogView;

namespace WpfClient.ViewModels.EmployeeViewModels
{
    public class ViewEmployeeViewModel : DialogViewModelBase<Employee>
    {
        public string EmployeeName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Job { get; set; }
        public string Pay { get; set; }
        public IEnumerable<ExtentionViewModel> EmployeeExtenions { get; set; }
        public DateTime BirthDayDate { get; set; }
        private Employee _Employee { get; set; }
        public ViewEmployeeViewModel(Employee Employee,string title, ContentControl dailogcontent) : base(title, dailogcontent)
        {
            this._Employee = Employee;
             this.Job= Employee.Job;
             this.Pay= Employee.Pay.ToString();
            this.BirthDayDate = Employee.BirthDayDate;
            this.LastName = Employee.LastName;
            this.FirstName = Employee.FirstMidName;
            this.BirthDayDate = Employee.BirthDayDate;
          ///  var im = new InportManger();
          //  EmployeeExtenions = im.ExtenionList.ToList().Select((e) => new ExtentionViewModel(Employee,e));
            
        }
       
    }
}
