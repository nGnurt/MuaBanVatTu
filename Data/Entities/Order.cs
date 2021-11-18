using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int DepartmentId { get; set; }
        public string SubcriberName { get; set; }
        public List<Department> Department { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
