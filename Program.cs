using Lab3_4.Commands;
using Lab3_4.Interfaces;
using System;

namespace Lab3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            IReceiver receiver = new Receiver();
            CommandInvoker invoker = new CommandInvoker();
            invoker.SetUpCommand(new CreateEventLog(receiver));
            invoker.SetUpCommand(new AddEvent(receiver));
            invoker.SetUpCommand(new DeleteEvent(receiver));
            invoker.SetUpCommand(new CleanEventLog(receiver));
            invoker.SetUpCommand(new GetEvents(receiver));
            Menu.GenerateMenu(invoker.GetCommands());
            Menu.PrintMenu();
            int commandCount = invoker.GetCommandsCount();
            Console.WriteLine("Для закриття консолі введіть 0\n");
            while (true)
            {
                Console.Write("Команда #");
                bool flag = int.TryParse(Console.ReadLine(), out int option);
                if (!flag)
                {
                    Console.WriteLine("Введіть число\n");
                    continue;
                }
                if (option == 0)
                {
                    return;
                }
                if (option < 1 || option > commandCount)
                {
                    Console.WriteLine($"Введіть число в межах від 1 до {commandCount}\n");
                    continue;
                }
                Console.WriteLine(invoker.GetCommandName(option - 1) + ":\n");
                try
                {
                    invoker.ExecuteCommand(option - 1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
