using InternationalBankSample.Interfaces;
using InternationalBankSample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InternationalBankSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrdersController(IOrderService _orderService)
        {
            orderService = _orderService;
        }


        [HttpPost("placeorder/{productId}")]
        public IActionResult PlaceOrder(int productId)
        {

            var orderData = orderService.PlaceOrder(productId);
            return Ok(orderData);
        }

        [HttpGet]
        public IActionResult Order(int id)
        {
            var order = orderService.GetOrder(id);

            return Ok(order);
        }
    }
}
