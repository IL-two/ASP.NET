using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class CategoryProduct
    {
        public List<Product> Products { get; set; }
        public SelectList CategoryProducts { get; set; }
        public string Category { get; set; }
        public string SearchString { get; set; }
    }
}