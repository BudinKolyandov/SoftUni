using PlayersAndMonsters.Core.Contracts;
using PlayersAndMonsters.IO.Contracts;
using System;
using System.Reflection;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(ICommandInterpreter commandInterpreter,
                      IReader reader,
                      IWriter writer)
        {
            this.commandInterpreter = commandInterpreter;
            this.writer = writer;
            this.reader = reader;
        }


        public void Run()
        {
            var sb = new StringBuilder();

            while (true)
            {
                string[] inputArgs = this.reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                if (inputArgs[0] == "Exit")
                {
                    break;
                }
                try
                {
                    string result = this.commandInterpreter.Read(inputArgs);
                    this.writer.Write(result);
                    sb.AppendLine(result);
                }
                catch (TargetInvocationException tie)
                {
                    Console.WriteLine(tie.InnerException.Message);
                    sb.AppendLine(tie.InnerException.Message);
                }
            }


        }
    }
}
