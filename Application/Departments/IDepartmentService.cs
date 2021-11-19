﻿using Application.Departments.Dtos;
using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Departments
{
    public interface IDepartmentService
    {
        Task<int> Create(DepartmentCreateRequest request);
        Task<int> Update(DepartmentUpdateRequest request);
        Task<int> Delete(int departmentID);        
    }
}
