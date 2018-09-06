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
    public class VIPTicketController : ControllerBase
    {
        private readonly IDocumentStore _documentStore;

        public VIPTicketController(IDocumentStore documentStore)
        {
            _documentStore = documentStore;
        }

        // GET: api/VIPTicket
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/VIPTicket/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/VIPTicket
        [HttpPost]
        public void Post([FromBody] VIPTicket value)
        {
            using (var session = _documentStore.LightweightSession())
            {
                session.Store(value);
                session.SaveChanges();
            }
        }

        // PUT: api/VIPTicket/5
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
