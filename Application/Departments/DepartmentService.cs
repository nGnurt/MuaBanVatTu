using Application.Departments.Dtos;
using Data.EF;
using Data.Entities;
using System;
using System.Threading.Tasks;

namespace Application.Departments
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ProjectDbContext _context;
        public DepartmentService(ProjectDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(DepartmentCreateRequest request)
        {
            var department = new Department()
            {
                Name = request.Name,
                Leader = request.Leader,
                FoundedDate = request.FoundedDate
            };
            _context.Departments.Add(department);
           return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int departmentID)
        {
            var department = await _context.Departments.FindAsync(departmentID);
            if (department == null) throw new Exception("Cannot find the department");
            _context.Departments.Remove(department);
            return await _context.SaveChangesAsync();
        }
       
        public async Task<int> Update(DepartmentUpdateRequest request)
        {
            var department = await _context.Departments.FindAsync(request.DepartmentId);
            if (department == null) throw new Exception("Cannot find the department");
            department.Name = request.Name;
            department.Leader = request.Leader;
            return await _context.SaveChangesAsync();
        }

        
    }
}
