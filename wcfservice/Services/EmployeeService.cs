using SDK.Model;
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

        public EmployeeService()
        {
        }
        public bool AddEmployee(Employee employee)
        {
            try
            {
                using (var db = new DBContext())
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    return true;
                }
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
                using (var db = new DBContext())
                {
                    db.Employees.Remove(db.Employees.Find(employee.ID));
                    db.SaveChanges();
                    return true;
                }
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
                using (var db = new DBContext())
                {
                    var us = db.Employees.Find(employee.ID);
                    us.LastName = employee.LastName;
                    us.FirstMidName = employee.FirstMidName;
                    us.BirthDayDate = employee.BirthDayDate;
                    us.UpdateAt = DateTime.Now;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;


            }

        }


        public Employee FindEmployee(int ID)
        {
            using (var db = new DBContext())
            {
                return db.Employees.Find(ID);
            }
        }


        public List<Employee> FindEmployees(string key, int page, int pageSize)
        {
            key = key?.ToLower();
            using (var db = new DBContext())
            {
                return db.Employees.OrderBy(e => e.ID).Where(e => (bool)e.Job.ToLower().Contains(key)
                                      || (bool)e.LastName.ToLower().Contains(key)
                                      || (bool)e.FirstMidName.ToLower().Contains(key)

             ).GetPaged(page, pageSize).Results.ToList();
            }

        }

        public List<Employee> GetAllEmployees(int page, int pageSize)
        {
            using (var db = new DBContext())
            {
                return db.Employees.OrderBy(e => e.ID).GetPaged(page, pageSize).Results.ToList();
            }
        } 
    }
}
