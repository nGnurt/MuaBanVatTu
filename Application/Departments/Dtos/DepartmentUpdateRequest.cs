using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Departments.Dtos
{
    public class DepartmentUpdateRequest
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Leader { get; set; }
    }
}
