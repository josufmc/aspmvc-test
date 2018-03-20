using _9.MyWebApiMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _9.MyWebApiMVC.Controllers
{
    public class ProductController : ApiController
    {
        private Product[] products = new Product[]
        {
            new Product{ Id=1, Name="P1", Category="C1", Price=1},
            new Product{ Id=2, Name="P2", Category="C2", Price=2},
            new Product{ Id=3, Name="P3", Category="C3", Price=3},
            new Product{ Id=4, Name="P4", Category="C4", Price=4},
        };


        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
