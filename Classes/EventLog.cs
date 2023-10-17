using Lab3_4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_4.Classes
{
    public class EventLog
    {
        private List<Event> eventLog;
        private static EventLog instance;
        private ILogFormatter logFormatter;

        private EventLog(ILogFormatter formatter)
        {
            eventLog = new List<Event>();
            logFormatter = formatter;
        }

        public static EventLog GetInstance(ILogFormatter formatter)
        {
            if (instance == null)
            {
                instance = new EventLog(formatter);
            }
            return instance;
        }
        public void AddEvent(Event _event)
        {
            eventLog.Add(_event);
        }

        public void DeleteEvent(int id)
        {
            var _event = eventLog.FirstOrDefault(e => e.Id == id);

            if (_event == null)
            {
                throw new Exception("Події не знайдено.");
            }
            eventLog.Remove(_event);
        }

        public void CleanEventLog()
        {
            eventLog.Clear();
        }

        public IEnumerable<string> GetEvents()
        {
            int count = Math.Min(10, eventLog.Count);
            var events = eventLog.Skip(eventLog.Count - count);
            var eventList = new List<string>();
            foreach (var item in events)
            {
                eventList.Add(logFormatter.Format(item));
            }
            return eventList;
        }
    }
}
