using System;

namespace AbstractTask2.Model
{
    public class Dvd : Medium
    {
        private string _director;
        public string Director
        {
            get => _director;
            set {
                if (!string.IsNullOrEmpty(value))
                    _director = value;
                else
                    throw new ArgumentException("argument may not be null or empty!");
            }
        }
        public Dvd(string title, int duration, string director) : base(title, duration)
        {
            Director = director;
        }
        public new string Print()
        {
            var data = base.Print();
            const string delimiter = " | ";
            data += $"Director: {_director}{delimiter}";
            return data;
        }
    }
}
