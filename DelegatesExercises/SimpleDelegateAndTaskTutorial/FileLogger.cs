using System.IO;

namespace SimpleDelegateAndTaskTutorial
{
    internal class FileLogger
    {
        private readonly FileStream _fileStream;
        private readonly StreamWriter _streamWriter;
        public FileLogger(string filename)
        {
            _fileStream = new FileStream(filename, FileMode.OpenOrCreate);
            _streamWriter = new StreamWriter(_fileStream);
        }
        public void Log(string s)
        {
            _streamWriter.WriteLine(s);
        }
        public void Close()
        {
            _streamWriter.Close();
            _fileStream.Close();
        }

    }
}
