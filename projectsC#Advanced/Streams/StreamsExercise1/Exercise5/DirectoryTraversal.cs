using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var filesinfo = new Dictionary<string, Dictionary<string, double>>();
            var directoryInfo = new DirectoryInfo(".");
            FileInfo [] files = directoryInfo.GetFiles();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";
            foreach (var file in files)
            {
                double size = file.Length / 1024d;
                string name = file.Name;
                string type = file.Extension;

                if (!filesinfo.ContainsKey(type))
                {
                    filesinfo.Add(type, new Dictionary<string, double>());
                }
                if (!filesinfo[type].ContainsKey(name))
                {
                    filesinfo[type].Add(name, size);
                }
            }

            foreach (var (type, value) in filesinfo.OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key))
            {
                File.AppendAllText(path, $"{type} {Environment.NewLine}");
                foreach (var (name, size) in value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path, $"--{name} - {size:f3}kb{Environment.NewLine}");
                }
            }
            

        }
    }
}
