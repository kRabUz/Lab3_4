using Lab3_4.Classes;
using Lab3_4.Enums;
using Lab3_4.Interfaces;
using System;

namespace Lab3_4.Commands
{
    public class AddEvent : ICommand
    {
        private readonly IReceiver receiver;

        public AddEvent(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Введіть Id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть рівень важливості події (1 для нормальний, 2 для зауваження, 3 для помилка):");
            string level = Console.ReadLine();
            EventLevel _level = EventLevel.Normal;
            if (int.TryParse(level, out int levelNumber))
            {
                switch (levelNumber)
                {
                    case 1:
                        _level = EventLevel.Normal;
                        break;
                    case 2:
                        _level = EventLevel.Warning;
                        break;
                    case 3:
                        _level = EventLevel.Error;
                        break;
                    default:
                        _level = EventLevel.Normal;
                        break;
                }
            }
            Console.WriteLine("Введіть джерело події (назву модуля програми):");
            string source = Console.ReadLine();

            Console.WriteLine("Введіть текстове повідомлення події:");
            string message = Console.ReadLine();

            DateTime currentTime = DateTime.Now;

            Event _event = new Event
            {
                Id = id,
                Level = _level,
                Source = source,
                Time = currentTime,
                Message = message
            };

            receiver.AddEvent(_event);
        }
        public string GetCommandName()
        {
            return "Додати подію";
        }
    }
}