using SDK.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Date.Model;
using SDK.IServices;
using SDK;

namespace wcfservice.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "User" in both code and config file together.
    public class UserService : IUserService
    {
        DBContext db;

        public UserService()
        {
            db = new DBContext();
        }

        public bool AddUser(User user)
        {

            db.Users.Add(user);
            db.SaveChanges();
            return true;
        }

        /*      public ServiceResult AddUser(User user)
     {
         try
         {
             if (string.IsNullOrEmpty(user.Usename))
             {
                 return new ServiceResult { Status = ResultState.Fail, Error = "duplicated user name" };
             }
             db.Users.Add(user);
             db.SaveChanges();
             return new ServiceResult { Status = ResultState.Success, ID = user.ID };
         }
         catch (Exception ex)
         {
             return new ServiceResult { Status = ResultState.Error, Error = ex.Message }; ;
         }
     }
     */
        public bool DeleteUser(User user)
        {
            try
            {
                db.Users.Remove(db.Users.Find(user.ID));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;


            }
        }

        public bool EditUser(User user)
        {

            try
            {
                var us = db.Users.Find(user.ID);
                us.LastName = user.LastName;
                us.FirstMidName = user.FirstMidName;
                us.BirthDayDate = user.BirthDayDate;
                us.Usename = user.Usename;
                us.Password = user.Password;
                us.Date_Up = DateTime.Now;
                us               db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;


            }

        }


        public User FindUser(int ID)
        {
            return db.Users.Find(ID);
        }
        public List<User> FindUsers(string key)
        {
            key = key?.ToLower();
            return db.Users.ToList().Where(u => u.Usename?.ToLower() == key
                                      || u.LastName.Equals(key)
                                      || u.FirstMidName.Equals(key)

             ).ToList();
        }

        public List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }
        
    }
}
