﻿using SDK.IServices;
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
    public class CreateEmployeeViewModel : DialogViewModelBase<Employee>
    {
        public string EmployeeName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Job { get; set; }
        public string Pay { get; set; }
        public DateTime BirthDayDate { get; set; }
        public ICommand CreateCommand { get; set; }
        public CreateEmployeeViewModel(string title, ContentControl dailogcontent) : base(title, dailogcontent)
        {
            CreateCommand = new Command(CreateEmployee);
        }
        public void CreateEmployee()
        {
            
            var newEmployee = new Employee()
            {
                job=Job,
                Pay= int.Parse(Pay),
                BirthDayDate = BirthDayDate,
                FirstMidName = FirstName,
                LastName = LastName,
                Date_At = DateTime.Now,
                Date_Up = DateTime.Now
            };
            var channelFactory = new ChannelFactory<IEmployeeService>(new BasicHttpBinding(), "http://localhost:8733/Employee");
            var channel = channelFactory.CreateChannel();
            channel.AddEmployee(newEmployee);

            DialogService dialog = new DialogService();

            SuccessfullViewModel successfull = new SuccessfullViewModel("successfull", new SuccessfullView());
            dialog.OpenDialog<bool>(successfull);
            this.Close();
        }
    }
}
