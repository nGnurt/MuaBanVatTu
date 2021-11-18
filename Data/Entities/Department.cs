using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Leader{ get; set; }
        public DateTime FoundedDate{ get; set; }
        public Order Order { set; get; }

    }
}
