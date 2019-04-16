using System;

namespace AbstractTask3.Model
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
        public override string Print()
        {
            const string delimiter = " | ";
            var data = $"{GetType().Name}: {Title} ({Duration} Min){delimiter}";
            data += "Mine: " + (Mine ? "Mine" : "") + delimiter;
            data += $"Comment: {Comment}{delimiter}";
            data += $"Director: {_director}{delimiter}";
            return data;
        }
    }
}
