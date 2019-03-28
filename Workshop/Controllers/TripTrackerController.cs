using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workshop.Models;

namespace Workshop.Controllers
{
    [Produces("application/json")]
    [Route("api/TripTracker")]
    public class TripTrackerController : Controller
    {
        public TripTrackerController(Repository repository)
        {
            _repository = repository;
        }
        private Repository _repository;
        // GET api/values
        [HttpGet]
        public IEnumerable<Models.Trip> Get()
        {
            return _repository.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
}
}