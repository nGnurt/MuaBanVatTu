using Data.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantities { get; set; }
        public decimal Price { get; set; }
        public string Desciption { get; set; }
        public List<ProductOrderDetail> ProductOrderDetail { get; set; }
    }
}
