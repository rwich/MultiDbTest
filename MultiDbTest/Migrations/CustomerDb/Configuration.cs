namespace MultiDbTest.Migrations.CustomerDb
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MultiDbTest.CustomerDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\CustomerDb";
        }

        protected override void Seed(MultiDbTest.CustomerDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            MultiDbTest.CustomerDb db = new MultiDbTest.CustomerDb();
            List<Customer> cList = new List<Customer>();

            Customer c1 = new Customer("Chewy");
            Customer c2 = new Customer("C3PO");
            Customer c3 = new Customer("Darth Vader");
            cList.Add(c1);
            cList.Add(c2);
            cList.Add(c3);

            foreach (var p in cList)
            {
                context.Customers.Add(p);
            }

            context.SaveChanges();
        }
    }
}
