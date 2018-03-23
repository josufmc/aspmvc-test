using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _13.EmployeesMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Antiquity { get; set; }
        public int Age { get; set; }
    }


    public class EmployeeDBContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}