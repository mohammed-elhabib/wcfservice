using System;
using System.Collections.Generic;
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
using wcfservice.Model;
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

            DBContext dB = new DBContext();
            dB.Users.Add(new Model.User() {
                ID=5,
                Date_At=  DateTime.Now,
                BirthDayDate=DateTime.Now,
                Date_Up = DateTime.Now,
FirstMidName="SSS",
LastName="SSSSS",
Password="SSSS",
Usename="SSSS"
 });

            dB.SaveChanges();
        }
        ServiceHost host;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        //    host = new ServiceHost(typeof(User));

            host.Open();
            text.Text = "Opining";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            host.Close();
            text.Text = "closing";

        }
    }
}
