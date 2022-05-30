using Microsoft.AspNetCore.Mvc;
using ProductApiServices.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductApiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Product> list=new List<Product>();
            Product product1=new Product();
            product1.Id = 1;
            product1.Name = "Dell";
            product1.ProductId = 001;
            product1.Price= "$2000";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Hp";
            product2.ProductId = 002;
            product2.Price = "$3000";

            list.Add(product1);
            list.Add(product2);
            return Ok(list);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        
    }
}
