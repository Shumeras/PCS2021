using Data;
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
    public class ClientController : ControllerBase
    {
        private DataContext dataContext;

        public ClientController(DataContext data)
        {
            dataContext = data;
        }

        // GET: api/<ClientController>
        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            
            return Accepted(dataContext.Customers.ToList());
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var customer = dataContext.Customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
                return NoContent();

            return Ok(customer);
        }

        // POST api/<ClientController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PATCH api/<ClientController>/5
        [HttpPost("{id}/{key}")]
        public IActionResult Put(int id, string key, [FromBody] string value)
        {
            var target = dataContext.Customers.FirstOrDefault(c => c.Id == id);

            if (target == null)
                return BadRequest();

            if (key == nameof(target.FirstName))
                target.FirstName = value;
            else if (key == nameof(target.LastName))
                target.LastName = value;
            else if (key == nameof(target.Address))
                target.Address = value;
            else
                return BadRequest();

            dataContext.SaveChanges();
            return Ok();
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataContext.Customers.Remove(dataContext.Customers.FirstOrDefault((c) => c.Id == id));
            dataContext.SaveChanges();
        }
    }
}
