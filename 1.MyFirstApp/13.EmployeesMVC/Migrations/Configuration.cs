namespace _13.EmployeesMVC.Migrations
{
    using _13.EmployeesMVC.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<_13.EmployeesMVC.Models.EmployeeDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_13.EmployeesMVC.Models.EmployeeDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Employees.AddOrUpdate(i => i.Name, new Employee {
                Name = "Person 1",
                Antiquity = 15,
                Age = 38,
                Category = "A"
            }, new Employee
            {
                Name = "Person 2",
                Antiquity = 16,
                Age = 25,
                Category = "A"
            }, new Employee
            {
                Name = "Person 3",
                Antiquity = 5,
                Age = 30,
                Category = "B"
            }, new Employee
            {
                Name = "Person 4",
                Antiquity = 7,
                Age = 34,
                Category = "A"
            }
            );
        }
    }
}
