using Lab3_4.Classes;
using Lab3_4.Interfaces;

namespace Lab3_4
{
    public class XMLLogFormatter : ILogFormatter
    {
        public string Format(Event entry)
        {
            string xml = $"<log><Id>{entry.Id}</Id><time>{entry.Time:yyyy-MM-dd HH:mm:ss}</time><level>{entry.Level}</level><source>{entry.Source}</source><message>{entry.Message}</message></log>";
            return xml;
        }
    }
}
