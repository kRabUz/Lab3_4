using Lab3_4.Interfaces;
using System;

namespace Lab3_4.Commands
{
    public class DeleteEvent : ICommand
    {
        private readonly IReceiver receiver;

        public DeleteEvent(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            int index = int.Parse(Console.ReadLine());
            receiver.DeleteEvent(index);
        }
        public string GetCommandName()
        {
            return "Видалити подію";
        }
    }
}
