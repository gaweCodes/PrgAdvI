using System;
using System.IO;

namespace _1._4_CompletionCallback
{
    internal class FileReaderClient
    {
        public void ReadCompleted(string filename, byte[] data)
        {
            Console.WriteLine($"ReadCompleted {filename} / Bytes: {data.Length}");
        }
        public void ReadFailed(string filename, IOException ex)
        {
            Console.WriteLine("ReadFailed " + filename);
            Console.WriteLine(ex);
        }
        public void ActionRequiringFile(string filename)
        {
            FileReader.ReadAsync(filename, ReadCompleted, ReadFailed);
        }
        public void ActionRequiring2Files(string filename1, string filename2)
        {
            FileReader.ReadAsync(filename1, ReadCompleted, ReadFailed);
            FileReader.ReadAsync(filename2, ReadCompleted, ReadFailed);
        }
    }
}