using System;
using System.Collections.Generic;
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
}