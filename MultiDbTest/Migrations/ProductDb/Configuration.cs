namespace MultiDbTest.Migrations.ProductDb
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MultiDbTest.ProductDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ProductDb";
        }

        protected override void Seed(MultiDbTest.ProductDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            MultiDbTest.ProductDb db = new MultiDbTest.ProductDb();
            List<Product> prodList = new List<Product>();
            
            Product p1 = new Product("Wookie");
            Product p2 = new Product("Droid");
            Product p3 = new Product("Sith");
            prodList.Add(p1);
            prodList.Add(p2);
            prodList.Add(p3);

            foreach (var p in prodList)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();
        }
    }
}
