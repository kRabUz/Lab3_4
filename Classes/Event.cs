using Lab3_4.Enums;
using System;

namespace Lab3_4.Classes
{
    public class Event
    {
        public int Id { get; set; }
        public EventLevel Level { get; set; }
        public string Source { get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return $"{Time} [{Level}] {Source}: {Message}";
        }
    }
}
