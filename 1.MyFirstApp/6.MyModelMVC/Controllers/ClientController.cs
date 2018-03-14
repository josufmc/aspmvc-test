using _6.MyModelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6.MyModelMVC.Controllers
{
    public class ClientController : Controller
    {
        private EmpDBContext db = new EmpDBContext();

        public static List<Client> clientList = new List<Client>() {
            new Client
            {
                Id = 1,
                Name = "Ángel",
                CreatedOn = new DateTime(),
                Age = 30
            },
            new Client
            {
                Id = 2,
                Name = "Patricia",
                CreatedOn = new DateTime(),
                Age = 35
            },
        };

        // GET: Client
        public ActionResult Index()
        {
            //var clients = from e in clientList orderby e.Id select e;
            var clients = from e in db.Clients orderby e.Id select e;
            return View(clients);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(Client client)
        {
            try
            {
                // clientList.Add(client);
                db.Clients.Add(client);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        /*
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Client client = new Client();
                client.Name = collection["name"];
                DateTime jDate;
                DateTime.TryParse(collection["DOB"], out jDate);
                client.CreatedOn = jDate;
                string age = collection["age"];
                client.Age = Int32.Parse(age);
                clientList.Add(client);
                client.Name = collection["name"];
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }*/

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            // List<Client> clientList = AllClients();
            // var client = clientList.Single(m => m.Id == id);
            var client = db.Clients.Single(m => m.Id == id);
            return View(client);
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // var client = clientList.Single(m => m.Id == id);
                var client = db.Clients.Single(m => m.Id == id);
                if (TryUpdateModel(client))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(client);
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Client> AllClients()
        {
            return new List<Client>() {
                new Client
                {
                    Id = 1,
                    Name = "Ángel",
                    CreatedOn = new DateTime(),
                    Age = 30
                },
                new Client
                {
                    Id = 2,
                    Name = "Patricia",
                    CreatedOn = new DateTime(),
                    Age = 35
                },
            };
        }

    }
}
