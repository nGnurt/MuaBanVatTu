using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    public class ProductOrderDetail 
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Id { get; set; }
        public OrderDetail OrderDetail { get; set; }
    }
}
