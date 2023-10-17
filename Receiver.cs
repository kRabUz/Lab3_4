using Lab3_4.Classes;
using Lab3_4.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab3_4
{
    public class Receiver : IReceiver
    {
        private EventLog eventLog;


        public void CreateEventLog(ILogFormatter formatter)
        {
            eventLog = EventLog.GetInstance(formatter);
        }

        public void AddEvent(Event _event)
        {
            if (eventLog == null)
            {
                throw new InvalidOperationException("Журнал подій не створено.");
            }
            eventLog.AddEvent(_event);
        }

        public void DeleteEvent(int index)
        {
            if (eventLog == null)
            {
                throw new InvalidOperationException("Журнал подій не створено.");
            }
            eventLog.DeleteEvent(index);
        }

        public void CleanEventLog()
        {
            if (eventLog == null)
            {
                throw new InvalidOperationException("Журнал подій не створено.");
            }
            eventLog.CleanEventLog();
        }

        public IEnumerable<string> GetEvents()
        {
            if (eventLog == null)
            {
                throw new InvalidOperationException("Журнал подій не створено.");
            }
            return eventLog.GetEvents();
        }
    }
}
