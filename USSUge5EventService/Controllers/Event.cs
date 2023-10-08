namespace USSUge5EventService.EventFeed
{
    using System;

    public record Event(long SequenceNumber, DateTimeOffset OccuredAt, string Name, object Content);
}