using Lab3_4.Interfaces;
using System;

namespace Lab3_4.Commands
{
    public class CreateEventLog : ICommand
    {
        private readonly IReceiver receiver;

        public CreateEventLog(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine("Введіть цифру: 1 - txt, 2 - XML");
            int format = int.Parse(Console.ReadLine());
            if (format == 1)
            {
                ILogFormatter formatter = new TXTLogFormatter();
                receiver.CreateEventLog(formatter);
            }
            if (format == 2)
            {
                ILogFormatter formatter = new XMLLogFormatter();
                receiver.CreateEventLog(formatter);
            }
        }
        public string GetCommandName()
        {
            return "Створити журнал подій(txt,XML)";
        }
    }
}
