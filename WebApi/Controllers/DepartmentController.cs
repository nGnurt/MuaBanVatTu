using Application.Departments;
using Application.Departments.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(DepartmentCreateRequest request)
        {
            var result = await _departmentService.Create(request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(DepartmentUpdateRequest request)
        {
            var result = await _departmentService.Update(request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _departmentService.Delete(Id);
            if (result == 0)
                return BadRequest();
            return Ok();
        }
    }
}
