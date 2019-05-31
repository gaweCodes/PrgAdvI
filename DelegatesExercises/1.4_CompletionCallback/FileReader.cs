using System.IO;
using System.Threading;

namespace _1._4_CompletionCallback
{
    public delegate void ReadCompleted(string filename, byte[] data);
    public delegate void ReadFailed(string filename, IOException ex);
    internal class FileReader
    {
        public static void ReadAsync(string filename, ReadCompleted client, ReadFailed fallback)
        {
            var my = new FileReaderAsync(filename, client, fallback);
            new Thread(my.DoRead).Start();
        }
        private class FileReaderAsync
        {
            private readonly string _fileName;
            private readonly ReadCompleted _completed;
            private readonly ReadFailed _failed;
            public FileReaderAsync(string filename, ReadCompleted client, ReadFailed fallback)
            {
                _fileName = filename;
                _completed = client;
                _failed = fallback;
            }
            public void DoRead()
            {
                var buffer = new byte[1024];
                try
                {
                    var fs = new FileStream(_fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    var r = new BinaryReader(fs);
                    buffer = r.ReadBytes(buffer.Length);
                    _completed?.Invoke(_fileName, buffer);
                }
                catch (IOException ex)
                {
                    _failed?.Invoke(_fileName, ex);
                }
            }
        }
    }
}