namespace USSUge5EventService.EventFeed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    public interface IEventStore
    {
        Event? GetLastEvent();
        IEnumerable<Event> GetEvents(long firstEventSequenceNumber, long lastEventSequenceNumber);
        void Raise(string eventName, object content);
    }

    public class EventStore : IEventStore
    {
        private static long currentSequenceNumber = 0;
        private static readonly IList<Event> Database = new List<Event>();

        public Event? GetLastEvent()
        {
            if(Database.Count == 0)return null;
            return Database.Last();
        }
        public IEnumerable<Event> GetEvents(
          long firstEventSequenceNumber,
          long lastEventSequenceNumber)
          => Database
            .Where(e =>
              e.SequenceNumber >= firstEventSequenceNumber &&
              e.SequenceNumber <= lastEventSequenceNumber)
            .OrderBy(e => e.SequenceNumber);

        public void Raise(string eventName, object content)
        {
            var seqNumber = Interlocked.Increment(ref currentSequenceNumber);
            Database.Add(
              new Event(
                seqNumber,
                DateTimeOffset.UtcNow,
                eventName,
                content));
        }
    }
}