using Date.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
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
using wcfservice.Services;

namespace wcfservice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // InitializeComponent();
        }
        ServiceHost hostUser;
        ServiceHost hostEmployee;
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            using (var context = new DBContext())
            {
                if (!context.Database.Exists())
                {
                    Database.SetInitializer(new DbInitializer());
                    context.Database.Initialize(true);
                }
            }

            hostUser = new ServiceHost(typeof(UserService));
            hostEmployee = new ServiceHost(typeof(EmployeeService));

            hostUser.Open();
            hostEmployee.Open();
            text.Text = "Opining";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            hostUser.Close();
            hostEmployee.Close();
            text.Text = "closing";

        }
    }
}
