using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    class CommandInterpreter : ICommandInterpreter
    {
        private const string command = "Command";
        public string Read(string args)
        {
            string[] tokens = args
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string commandName = tokens[0] + command;
            string[] commandArgs = tokens.Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();
            Type[] types = assembly.GetTypes();
            Type typeToCreate = types.FirstOrDefault(t => t.Name == commandName);
            Object instance = Activator.CreateInstance(typeToCreate);
            ICommand currentCommand = (ICommand)instance;
            string result = currentCommand.Execute(commandArgs);
            return result;

        }
    }
}
