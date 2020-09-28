using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        // ID продукта
        public int Id { get; set; }
        // Категория продукта
        public string Category { get; set; }
        // Имя продукта
        public string Name { get; set; }
        // Цена
        public int Price { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
    }
}