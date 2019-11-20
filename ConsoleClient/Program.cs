using SDK.IServices;

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
               var channelFactory = new ChannelFactory<IEmployeeService>(new BasicHttpBinding(), "http://localhost:8733/Employee");
               var channel = channelFactory.CreateChannel();

            var es = channel.GetAllEmployees(1, 30);
            foreach (var e in es) {

                Console.WriteLine(e.ID);
            }

            /*   for(int i =0;i<12;i++){
              channel.AddUser(new SDK.Model.User()
              {
                  BirthDayDate = DateTime.Now,
                  FirstMidName = "ALI",
                  LastName = "kkkk",
                  Password = "DDD",
                  Date_At = DateTime.Now,
                  Usename = "AJAJ",
                  Date_Up = DateTime.Now

              });
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
