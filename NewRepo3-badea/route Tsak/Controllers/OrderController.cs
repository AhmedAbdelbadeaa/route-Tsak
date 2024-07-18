using Microsoft.AspNetCore.Mvc;
using route_Tsak.Dto;
using route_Tsak.Services;

namespace route_Tsak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        public readonly IOrderService orderservice;
        public OrderController(IOrderService _orderservice) { 
            orderservice = _orderservice;
        }
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> NewOrder(UserOrderDto userorder)
        {
            await orderservice.AddOrderAsync(userorder);
            return Ok();
        }
        [HttpGet("GetOrder")]
        public IActionResult GetOrder(int id)
        { 
            return Ok(orderservice.GetOrderbyId(id));
        }
        [HttpGet("GetAllOrders")]
        public IActionResult GetAllOrders()
        {
            var result = orderservice.GetAllOrders();
            return Ok(result);
        }
        [HttpPut("UpdateOrder")]
        public async Task<IActionResult> EditOrder(AdminOrderDto editedorder)
        {
            await orderservice.UpdateOrderAsync(editedorder);
            return Ok();
        }
    }
}
