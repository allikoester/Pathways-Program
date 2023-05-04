using System;

namespace Event
{
    public class EventService
    {
        private readonly IEvent _event;
        
        public EventService(IEvent eventer)
        {
            _event = eventer;
        }
        public void Cost()
        {
            _event.Cost();
        }
    }
}