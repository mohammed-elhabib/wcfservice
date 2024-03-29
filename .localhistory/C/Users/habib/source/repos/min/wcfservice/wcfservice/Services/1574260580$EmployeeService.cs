﻿using SDK.Model;
using SDK.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Date.Model;
using wcfservice.Pagination;

namespace wcfservice.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "User" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        DBContext db;

        public EmployeeService()
        {
            db = new DBContext();
        }
        public bool AddEmployee(Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;


            }
        }

        public bool DeleteEmployee(Employee employee)
        {
            try
            {
                db.Employees.Remove(db.Employees.Find(employee.ID));
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;


            }
        }

        public bool EditEmployee(Employee employee)
        {

            try
            {
                var us = db.Employees.Find(employee.ID);
                us.LastName = employee.LastName;
                us.FirstMidName = employee.FirstMidName;
                us.BirthDayDate = employee.BirthDayDate;
                us.Date_Up = DateTime.Now;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;


            }

        }


        public Employee FindEmployee(int ID)
        {
            return db.Employees.Find(ID);
        }

        public List<Employee> FindEmployees(string key)
        {
            key = key?.ToLower();
            return db.Employees.ToList().Where(e => (bool)e.job?.ToLower().Contains(key)
                                      || (bool)e.LastName.ToLower().Contains(key)
                                      || (bool)e.FirstMidName.ToLower().Contains(key)

             ).ToList();
        }

        public List<Employee> GetAllEmployees(int page, int pageSize)
        {
            return db.Employees.GetPaged(page, pageSize).Results.ToList();
        }

        
        /*    public List<Employee> FindEmployee(string key)
   {
       return db.Employees.ToList().Where(u =>
                                   u.LastName.Equals(key)
                                 || u.FirstMidName.Equals(key)

        ).ToList();
   }
   */
        /*  public List<Employee> GetAllEmployees()
          {
              return db.Employees.ToList();
          }*/
    }
}
