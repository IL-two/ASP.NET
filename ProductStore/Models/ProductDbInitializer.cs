using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class ProductDbInitializer : DropCreateDatabaseAlways<ProductCt>
    {
        protected override void Seed(ProductCt db)
        {
            db.Products.Add(new Product { Category = "Еда", Name = "Яблоки", Price = 120, Date = new DateTime(2015, 7, 20) });
            db.Products.Add(new Product { Category = "Еда", Name = "Торт", Price = 450, Date = new DateTime(2020, 9, 21) });
            db.Products.Add(new Product { Category = "Напитки", Name = "Кофе", Price = 95, Date = new DateTime(2005, 12, 7) });

            base.Seed(db);
        }
    }
}