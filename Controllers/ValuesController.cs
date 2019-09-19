using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testCrm.API.Model;
using testCrm.API.Persistence;

namespace testCrm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public ValuesController(DataContext context)
        {
            _dataContext = context;
        }
        // GET api/values
        [HttpGet]
        public IActionResult GetTickets()
        {
            List<Ticket> tickets = _dataContext.Tickets.ToList();

            return Ok(tickets);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult getTicket(int id)
        {
            var ticket = _dataContext.Tickets.FirstOrDefault(t => t.Id == id);

            return Ok(ticket);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
