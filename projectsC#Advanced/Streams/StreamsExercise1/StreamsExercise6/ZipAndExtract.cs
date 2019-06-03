using System;
using System.IO;
using System.IO.Compression;

namespace StreamsExercise6
{
    class ZipAndExtract
    {
        static void Main(string[] args)
        {
            string picture = "../../../copyMe.png";
            string path = "result.zip";
            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (var archive = ZipFile.Open(path, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(picture, Path.GetFileName(picture));
            }
            using (var archive = ZipFile.OpenRead(path))
            {
                archive.ExtractToDirectory(pathDesktop);
            }



        }
    }
}
