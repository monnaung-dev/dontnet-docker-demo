using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderApiServices.Models;

namespace OrderApiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {

        // GET: OrderController
        [HttpGet]
        public IActionResult Get()
        {
            Order order = new Order();
            order.Id = 1;
            order.Name = "Dell";
            order.Price="$2000";
            return Ok(order);
        }

        // GET: OrderController/Details/5
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            Order order = new Order();
            if (id == 1)
            {
                order.Id = 1;
                order.Name = "Dell";
                order.Price = "$2000";
            }else if(id == 2)
            {
                order.Id = 2;
                order.Name = "Hp";
                order.Price = "$3000";
            }
            else
            {
                order.Name = "Nothing to show";
            }
            return Ok(order);
        }

        
    }
}
