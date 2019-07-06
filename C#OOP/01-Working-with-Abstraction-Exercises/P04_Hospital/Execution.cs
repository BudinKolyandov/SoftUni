using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital
{
    class Execution
    {

        public void Run()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();


            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] currentCommand = command.Split();
                var departament = currentCommand[0];
                var patientName = currentCommand[3];
                var doctorsName = currentCommand[1] + currentCommand[2];

                InitialisingDictionaries(doctors, departments, departament, doctorsName);

                bool isAvailable = departments[departament].SelectMany(x => x).Count() < 60;

                FillingRooms(doctors, departments, departament, patientName, doctorsName, isAvailable);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                command = GeneratingOutput(doctors, departments, command);
            }
        }

        private static string GeneratingOutput(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments, string command)
        {
            string[] departmentsToPrint = command.Split();

            if (departmentsToPrint.Length == 1)
            {
                Console.WriteLine(string.Join(Environment.NewLine, departments[departmentsToPrint[0]].Where(x => x.Count > 0).SelectMany(x => x)));
            }
            else if (departmentsToPrint.Length == 2 && int.TryParse(departmentsToPrint[1], out int room))
            {
                Console.WriteLine(string.Join(Environment.NewLine, departments[departmentsToPrint[0]][room - 1].OrderBy(x => x)));
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, doctors[departmentsToPrint[0] + departmentsToPrint[1]].OrderBy(x => x)));
            }
            command = Console.ReadLine();
            return command;
        }

        private static void FillingRooms(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments, string departament, string patientName, string doctorsName, bool isAvailable)
        {
            if (isAvailable)
            {
                int room = 0;
                doctors[doctorsName].Add(patientName);
                for (int availableRooms = 0; availableRooms < departments[departament].Count; availableRooms++)
                {
                    if (departments[departament][availableRooms].Count < 3)
                    {
                        room = availableRooms;
                        break;
                    }
                }
                departments[departament][room].Add(patientName);
            }
        }

        private static void InitialisingDictionaries(Dictionary<string, List<string>> doctors, Dictionary<string, List<List<string>>> departments, string departament, string doctorsName)
        {
            if (!doctors.ContainsKey(doctorsName))
            {
                doctors[doctorsName] = new List<string>();
            }
            if (!departments.ContainsKey(departament))
            {
                departments[departament] = new List<List<string>>();
                for (int stai = 0; stai < 20; stai++)
                {
                    departments[departament].Add(new List<string>());
                }
            }
        }
    }
}
