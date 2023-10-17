using Lab3_4.Interfaces;
using System.Collections.Generic;

namespace Lab3_4
{
    public class CommandInvoker
    {
        private List<ICommand> commands = new List<ICommand>();
        public List<ICommand> GetCommands()
        {
            return commands;
        }
        public int GetCommandsCount()
        {
            return commands.Count;
        }
        public void SetUpCommand(ICommand command)
        {
            commands.Add(command);
        }
        public void ExecuteCommand(int commandNumber)
        {
            commands[commandNumber].Execute();
        }
        public string GetCommandName(int commandNumber)
        {
            return commands[commandNumber].GetCommandName();
        }
    }
}
