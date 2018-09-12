using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using easy_tickets.Data;
using easy_tickets.DataModels;
using easy_tickets.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace easy_tickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowDetailsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private IConnectionMultiplexer _connectionMultiplexer;

        public ShowDetailsController(ApplicationDbContext context, IConnectionMultiplexer multiplexer)
        {
            _context = context;
            _connectionMultiplexer = multiplexer;
        }

        // GET: api/ShowDetails
        //[HttpGet]
        //public IEnumerable<ShowDetails> Get()
        //{
        //    List<ShowDetails> showDetails = new List<ShowDetails>();

        //    var shows = _context.Shows;

        //    foreach (var show in shows)
        //    {
        //        var acts = _context.ShowActs.Where(sa => sa.ShowID == show.ShowID).Select(sa => sa.Act).ToList();

        //        ShowDetails sd = new ShowDetails(show, acts);
        //        showDetails.Add(sd);
        //    }

        //    return showDetails;
        //}

        //// GET: api/ShowDetails
        //// Redis Cache Example
        [HttpGet]
        public IEnumerable<ShowDetails> Get()
        {
            List<ShowDetails> showDetails = new List<ShowDetails>();

            var db = _connectionMultiplexer.GetDatabase();
            string cachedShowDetails = db.StringGet("showDetails");

            if (string.IsNullOrEmpty(cachedShowDetails))
            {
                var shows = _context.Shows;

                foreach (var show in shows)
                {
                    var acts = _context.ShowActs.Where(sa => sa.ShowID == show.ShowID).Select(sa => sa.Act).ToList();

                    ShowDetails sd = new ShowDetails(show, acts);
                    showDetails.Add(sd);
                }

                db.StringSet("showDetails", JsonConvert.SerializeObject(showDetails).ToString(), new TimeSpan(0, 0, 0, 10));
            }
            else
            {
                showDetails = JsonConvert.DeserializeObject<List<ShowDetails>>(cachedShowDetails);
            }

            return showDetails;
        }
    }
}
