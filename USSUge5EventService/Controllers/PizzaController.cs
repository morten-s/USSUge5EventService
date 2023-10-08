using Microsoft.AspNetCore.Mvc;
using USSUge5EventService.EventFeed;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace USSUge5EventService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IEventStore _eventStore;

        public PizzaController(IEventStore eventStore)
        {
            this._eventStore = eventStore;
        }
        // GET: api/<PizzaController>
        /*[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PizzaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST api/<PizzaController>
        [HttpPost("CreateOrder")]
        public void Post([FromBody] Order order)
        {
            _eventStore.Raise("Pizzaorder", order );
        }
/*
        // PUT api/<PizzaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PizzaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
