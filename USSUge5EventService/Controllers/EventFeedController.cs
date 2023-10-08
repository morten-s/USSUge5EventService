namespace USSUge5EventService.EventFeed
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class EventFeedController
    {
        private readonly IEventStore eventStore;

        public EventFeedController(IEventStore eventStore) => this.eventStore = eventStore;

        [HttpGet("")]
        public Event[] Get([FromQuery] long start, [FromQuery] long end = int.MaxValue) =>
          this.eventStore.GetEvents(start, end).ToArray(); 
        [HttpGet("GetLastEvent")]
        public Event? Get()
        {
            return this.eventStore.GetLastEvent();
        }
    }
}