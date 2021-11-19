using Data.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderPrice { get; set; }
        public int OrderQuantities { get; set; }
        public Order Order { get; set; }
        public List<ProductOrderDetail> ProductOrderDetail { get; set; }
    }
}
