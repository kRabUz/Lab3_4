using Lab3_4.Classes;
using System.Collections.Generic;

namespace Lab3_4.Interfaces
{
    public interface IReceiver
    {
        void CreateEventLog(ILogFormatter formatter);
        void AddEvent(Event _event);
        void DeleteEvent(int index);
        void CleanEventLog();
        IEnumerable<string> GetEvents();
    }
}
