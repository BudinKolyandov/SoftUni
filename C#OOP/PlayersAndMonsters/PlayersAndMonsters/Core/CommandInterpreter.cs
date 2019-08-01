using PlayersAndMonsters.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly IManagerController managerController;

        public CommandInterpreter(IManagerController managerController)
        {
            this.managerController = managerController;
        }

        public string Read(string[] inputArgs)
        {
            string command = inputArgs[0];
            string[] commandArgs = inputArgs.Skip(1).ToArray();

            var method = typeof(ManagerController)
                .GetMethod(command);
            List<object> requiredParams = new List<object>();
            foreach (var commandArg in commandArgs)
            {
                if (int.TryParse(commandArg, out int parsedParam))
                {
                    requiredParams.Add(parsedParam);
                    continue;
                }
                requiredParams.Add(commandArg);
            }

            string result = (string)method.Invoke(this.managerController, requiredParams.ToArray());
            return result;
        }
    }
}
