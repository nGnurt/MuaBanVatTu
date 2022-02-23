using Application.OrderDetails;
using Application.OrderDetails.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _orderdetailService;
        private readonly ILogger<OrderDetailController> _logger;                      
        public OrderDetailController(IOrderDetailService orderdetailService, ILogger<OrderDetailController> logger)
        {
            _orderdetailService = orderdetailService;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderDetailCreateRequest request)
        {
            var result = await _orderdetailService.Create(request);
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
            catch(Exception ex)
            {              
                _logger.LogInformation(ex, "Create request is not responed.");
            }
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(OrderDetailUpdateRequest request)
        {
            var result = await _orderdetailService.Update(request);
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
                _logger.LogInformation(ex, "Update request is not responed.");
            }
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _orderdetailService.Delete(Id);
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
                _logger.LogInformation(ex, "Delete request is not responed.");
            }
            return Ok();
        }
    }
}
