using System;

namespace AbstractTask3.Model
{
    public class Cd : Medium
    {
        private string _interpret;
        private int _numberOfTracks;
        public Cd(string title, int duration, string interpret, int numberOfTracks) : base(title, duration)
        {
            Interpret = interpret;
            NumberOfTracks = numberOfTracks;
        }
        public string Interpret
        {
            get => _interpret;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _interpret = value;
                else
                    throw new ArgumentException("argument may not be null or empty!");
            }
        }
        public int NumberOfTracks
        {
            get => _numberOfTracks;
            set
            {
                if (value > 0)
                    _numberOfTracks = value;
                else
                    throw new ArgumentException("argument may not be empty!");
            }
        }
        public override string Print()
        {
            const string delimiter = " | ";
            var data = $"{GetType().Name}: {Title} ({Duration} Min){delimiter}";
            data += "Mine: " + (Mine ? "Mine" : "") + delimiter;
            data += $"Comment: {Comment}{delimiter}";
            data += $"Interpret {Interpret}{delimiter}";
            data += $"NumberOfTracks {NumberOfTracks}{delimiter}";
            return data;
        }
    }
}
