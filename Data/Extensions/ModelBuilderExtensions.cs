using Data.Configuration;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department() { DepartmentId = 1, Name = "Accounting", Leader = "John", FoundedDate = new DateTime(2020,4,12)},
                new Department() { DepartmentId = 2, Name = "Sales", Leader = "Tim", FoundedDate = new DateTime(2020, 4, 12)},
                new Department() { DepartmentId = 3, Name = "Administration", Leader = "Kate", FoundedDate = new DateTime(2020, 4, 12)}
                );
            modelBuilder.Entity<Order>().HasData(
                new Order() { OrderId = 1, DepartmentId = 2, SubcriberName = "Blake"},
                new Order() { OrderId = 2, DepartmentId = 1, SubcriberName = "John" },
                new Order() { OrderId = 3, DepartmentId = 3, SubcriberName = "Kate" },
                new Order() { OrderId = 4, DepartmentId = 1, SubcriberName = "Anna" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 1, ProductName = "Keyboard", Price = 200, Quantities = 50, Desciption=""},
                new Product() { ProductId = 2, ProductName = "Case", Price = 100, Quantities = 70, Desciption = "" },
                new Product() { ProductId = 3, ProductName = "Mouse", Price = 180, Quantities = 40, Desciption = "" },
                new Product() { ProductId = 4, ProductName = "Monitor", Price = 300, Quantities = 20, Desciption = "" },
                new Product() { ProductId = 5, ProductName = "Table", Price = 400, Quantities = 10, Desciption = "" }
                );
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail() { Id = 1, OrderId = 2, ProductId = 2, OrderDate = new DateTime(2021, 2, 1), OrderPrice = 95, OrderQuantities = 10},
                new OrderDetail() { Id = 2, OrderId = 1, ProductId = 5, OrderDate = new DateTime(2021, 3, 26), OrderPrice = 380, OrderQuantities = 2 },
                new OrderDetail() { Id = 3, OrderId = 3, ProductId = 3, OrderDate = new DateTime(2021, 1, 31), OrderPrice = 160, OrderQuantities = 5 }
                );
            
        }
    }
}
