using Application.OrderDetails.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.OrderDetails
{
    public interface IOrderDetailService
    {
        Task<int> Create(OrderDetailCreateRequest request);
        Task<int> Update(OrderDetailUpdateRequest request);
        Task<int> Delete(int Id);
    }
}
