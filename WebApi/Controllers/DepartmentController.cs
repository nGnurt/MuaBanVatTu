using Application.Departments;
using Application.Departments.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        private readonly ILogger<DepartmentController> _logger;       
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [ActivatorUtilitiesConstructor]
        public DepartmentController( ILogger<DepartmentController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Create(DepartmentCreateRequest request)
        {
            var result = await _departmentService.Create(request);
            try
            {               
                if (result == 0)
                {
                    _logger.LogInformation("Request is not responed!");
                    return BadRequest();
                }
                else
                    _logger.LogInformation("Successful");
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Create request is not responed.");
            }
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(DepartmentUpdateRequest request)
        {
            var result = await _departmentService.Update(request);
            try
            {
                if (result == 0)
                {
                    _logger.LogInformation("Request is not responed!");
                    return BadRequest();
                }
                else
                    _logger.LogInformation("Successful");
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Create request is not responed.");
            }
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _departmentService.Delete(Id);
            try
            {
                if (result == 0)
                {
                    _logger.LogInformation("Request is not responed!");
                    return BadRequest();
                }
                else
                    _logger.LogInformation("Successful");
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "Create request is not responed.");
            }
            return Ok();
        }
    }
}
