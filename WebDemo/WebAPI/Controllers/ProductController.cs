using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private DataContext dataContext;
        public ProductController(DataContext dc)
        {
            dataContext = dc;
        }

        // GET: api/<ProductControllerController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return dataContext.Products.ToList();
        }

        // GET api/<ProductControllerController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return dataContext.Products.FirstOrDefault(p => p.Id == id);
        }

        // POST api/<ProductControllerController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            dataContext.Products.Add(value);
            dataContext.SaveChanges();
        }

        // PUT api/<ProductControllerController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Product value)
        {
            var target = dataContext.Products.FirstOrDefault(p => p.Id == value.Id);
            
            if (target == null)
                return BadRequest();

            dataContext.Products.Remove(target);
            dataContext.Products.Add(value);
            dataContext.SaveChanges();

            return Accepted();
        }

        // DELETE api/<ProductControllerController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var target = dataContext.Products.FirstOrDefault(p => p.Id == id);

            if (target == null)
                return BadRequest();

            dataContext.Products.Remove(target);
            dataContext.SaveChanges();

            return Accepted();

        }
    }
}
