using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _13.EmployeesMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string Name { get; set; }

        [Required]
        [Range(1,40)]
        public int Antiquity { get; set; }

        [Required]
        [Range(18,65)]
        public int Age { get; set; }

        [Required]
        public string Category { get; set; }
    }


    public class EmployeeDBContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}