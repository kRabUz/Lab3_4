using Lab3_4.Interfaces;

namespace Lab3_4.Commands
{
    public class CleanEventLog : ICommand
    {
        private readonly IReceiver receiver;

        public CleanEventLog(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.CleanEventLog();
        }
        public string GetCommandName()
        {
            return "Очистити журнал";
        }
    }
}
