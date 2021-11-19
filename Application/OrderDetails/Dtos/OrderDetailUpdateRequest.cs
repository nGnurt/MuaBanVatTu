using System;
using System.Collections.Generic;
using System.Text;

namespace Application.OrderDetails.Dtos
{
    public class OrderDetailUpdateRequest
    {
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderPrice { get; set; }
        public int OrderQuantities { get; set; }
    }
}
