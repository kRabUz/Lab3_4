using Lab3_4.Classes;
using Lab3_4.Interfaces;

namespace Lab3_4
{
    public class TXTLogFormatter : ILogFormatter
    {
        public string Format(Event entry)
        {
            string txt = $"id: {entry.Id} {entry.Time:yyyy-MM-dd HH:mm:ss} [{entry.Level}] [{entry.Source}]: {entry.Message}";
            return txt;
        }
    }
}
