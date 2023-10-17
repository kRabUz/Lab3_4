using Lab3_4.Interfaces;
using System;

namespace Lab3_4.Commands
{
    public class GetEvents : ICommand
    {
        private readonly IReceiver receiver;

        public GetEvents(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            foreach (var _event in receiver.GetEvents())
            {
                Console.WriteLine(_event);
            }
        }
        public string GetCommandName()
        {
            return "Надрукувати останніх 10 подій";
        }
    }
}
