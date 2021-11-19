using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Departments.Dtos
{
    public class DepartmentCreateRequest
    {
        public string Name { get; set; }
        public string Leader { get; set; }
        public DateTime FoundedDate { get; set; }
    }
}
