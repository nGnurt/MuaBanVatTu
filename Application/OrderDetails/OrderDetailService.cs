using Application.OrderDetails.Dtos;
using Data.EF;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.OrderDetails
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly ProjectDbContext _context;
        public OrderDetailService(ProjectDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(OrderDetailCreateRequest request)
        {
            var orderdetail = new OrderDetail()
            {
                OrderId = request.OrderId,
                ProductId = request.ProductId,
                OrderDate = request.OrderDate,
                OrderPrice = request.OrderPrice,
                OrderQuantities = request.OrderQuantities
            };
            _context.OrderDetails.Add(orderdetail);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int Id)
        {
            var orderdetail = await _context.OrderDetails.FindAsync(Id);
            if (orderdetail == null) throw new Exception("Cannot find the product");
            _context.OrderDetails.Remove(orderdetail);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(OrderDetailUpdateRequest request)
        {
            var orderdetail = await _context.OrderDetails.FindAsync(request.ProductId);
            if (orderdetail == null) throw new Exception("Cannot find the product");
            orderdetail.OrderDate = request.OrderDate;
            orderdetail.OrderPrice = request.OrderPrice;
            orderdetail.OrderQuantities = request.OrderQuantities;
            return await _context.SaveChangesAsync();
        }
    }
}
