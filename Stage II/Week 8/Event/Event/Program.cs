using System;
using System.ComponentModel.Design;

namespace Event
{ 
    class Program
    {
        static void Main(string[] args)
        {
            IEvent newEvent = new Wedding();
            EventService event1 = new EventService(newEvent);
            event1.Cost();

            IEvent newEvent2 = new Graduation();
            EventService event2 = new EventService(newEvent2);
            event2.Cost();

            IEvent newEvent3 = new Retirement();
            EventService event3 = new EventService(newEvent3);
            event3.Cost();

            IEvent newEvent4 = new Birthday();
            EventService event4 = new EventService(newEvent4);
            event4.Cost();
        } // end class
    }// end class
 }// end namespace