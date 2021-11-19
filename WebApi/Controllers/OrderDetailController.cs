using Application.OrderDetails;
using Application.OrderDetails.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _orderdetailService;
        public OrderDetailController(IOrderDetailService orderdetailService)
        {
            _orderdetailService = orderdetailService;
        }
        [HttpPost]
        public async Task<IActionResult> Create(OrderDetailCreateRequest request)
        {
            var result = await _orderdetailService.Create(request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(OrderDetailUpdateRequest request)
        {
            var result = await _orderdetailService.Update(request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _orderdetailService.Delete(Id);
            if (result == 0)
                return BadRequest();
            return Ok();
        }
    }
}
