using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _8.MyScaffoldingMVC.Models
{
    public class Client
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }
        [Display(Name = "Created on")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YYYY-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }
        [Range(18, 75)]
        public int Age { get; set; }
    }

    public class EmpDBContext : DbContext
    {
        public EmpDBContext()
        { }

        public DbSet<Client> Clients { get; set; }
    }
}