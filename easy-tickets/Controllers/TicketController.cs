using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using easy_tickets.DataModels;
using Marten;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace easy_tickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly IDocumentStore _documentStore;

        public TicketController(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }

        // GET: api/Ticket
        [HttpGet]
        public IEnumerable<Ticket> Get()
        {
            using (var session = _documentStore.QuerySession())
            {
                return session.Query<Ticket>();
            }
        }

        // GET: api/Ticket/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(string Id)
        //{
        //    return "value";
        //}

        // POST: api/Ticket
        [HttpPost]
        public void Post([FromBody] Ticket value)
        {
            using (var session = _documentStore.LightweightSession())
            {
                session.Store(value);
                session.SaveChanges();
            }
        }

        // PUT: api/Ticket/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
