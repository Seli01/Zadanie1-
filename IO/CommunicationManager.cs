using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister_K63_2022.IO
{
    public class CommunicationManager
    {
        public static void MainLoop()
        {
            Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();
            var commandTypes = Assembly.GetExecutingAssembly()
                                       .GetTypes()
                                       .Where(type => typeof(ICommand).IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract);
            foreach (var commandType in commandTypes) 
            {
                var instance = (ICommand)Activator.CreateInstance(commandType);
                commands[instance.Label] = instance;
            }

            while (true)
            {
                Console.WriteLine("You can 'save', 'load', 'exit', 'add employee', 'delete employee' & 'list employees' ");
                Console.Write("#");

                var command = Console.ReadLine();
                if (!commands.ContainsKey(command))
                {
                    Console.WriteLine($"Command {command} is not supported!");
                    continue;
                }
                commands[command].Execute();
            }
        }
    }
}
