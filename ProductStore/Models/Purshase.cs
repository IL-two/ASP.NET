using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Purshase
    {       
        // ID покупки
        public int PurshaseId { get; set; }
        // Имя и фамилия покупателя
        public string Person { get; set; }
        // Адрес покупателя
        public string Address { get; set; }
        // ID продукта
        public int ProductkId { get; set; }
        
    }
}