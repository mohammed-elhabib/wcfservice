using SDK.IServices;
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
       /*     Console.ReadKey();
            var channelFactory = new ChannelFactory<IUserService>(new BasicHttpBinding(), "http://localhost:8733/User");
            var channel = channelFactory.CreateChannel();
            channel.AddUser(new SDK.Model.User()
            {
                BirthDayDate= DateTime.Now,
                FirstMidName ="ALI",
                LastName="kkkk",
                Password="DDD",
                Date_At=DateTime.Now,
                Usename="AJAJ",
                Date_Up=DateTime.Now

            });
            foreach(var user in channel.GetAllUsers()){
                Console.WriteLine(user.ID);
           }
         
                Console.WriteLine(channel.FindUser("kkkk").ID);
            channel.DeleteUser(new SDK.Model.User()
            {
                ID = 8

            });

     
            Console.ReadKey();

    */
        }
    }
}
