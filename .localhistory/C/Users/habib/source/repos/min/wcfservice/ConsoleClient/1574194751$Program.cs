using SDK.IServices;
using SDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.ReadKey();
               var channelFactory = new ChannelFactory<IEmployeeService>(new BasicHttpBinding(), "http://localhost:8733/User");
               var channel = channelFactory.CreateChannel();


            IList<Employee> ts = channel.GetAllEmployees(1, 30);

            Console.WriteLine(ts.Count);
            foreach (Employee u in ts) {
                Console.WriteLine($"id = {u.ID} firstname {u.FirstMidName}");
          }
               /*
                   Console.WriteLine(channel.FindUser("kkkk").ID);
               channel.DeleteUser(new SDK.Model.User()
               {
                   ID = 8

               });

    */
               Console.ReadKey();

     
        }
    }
}
