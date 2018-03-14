using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _6.MyModelMVC.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Age { get; set; }
    }

    public class EmpDBContext: DbContext {
        public EmpDBContext()
        { }

        public DbSet<Client> Clients { get; set; }
    }
}