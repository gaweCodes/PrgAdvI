using System;

namespace AbstractTask2.Model
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
        public new string Print()
        {
            var data = base.Print();
            const string delimiter = " | ";
            data += $"Interpret {_interpret}{delimiter}";
            data += $"NumberOfTracks {_numberOfTracks}{delimiter}";
            return data;
        }
    }
}
