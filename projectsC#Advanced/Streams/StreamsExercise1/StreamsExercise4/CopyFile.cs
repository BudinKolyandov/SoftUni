using System;
using System.IO;

namespace StreamsExercise4
{
    class CopyFile
    {
        static void Main(string[] args)
        {
            string picPath = "../../../copyMe.png";
            string copiedPicPath = "copyedPic.png";

            using (FileStream streamReader = new FileStream(picPath, FileMode.Open))
            {
                using (FileStream streamWriter = new FileStream(copiedPicPath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];
                        var readedBytes = streamReader.Read(byteArray, 0, byteArray.Length);
                        if (readedBytes == 0)
                        {
                            break;
                        }
                        streamWriter.Write(byteArray, 0, readedBytes);
                    }
                }
            }




        }
    }
}
