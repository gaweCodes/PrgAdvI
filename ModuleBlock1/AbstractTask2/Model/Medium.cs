using System;

namespace AbstractTask2.Model
{
    public class Medium
    {
        private string _title;
        private int _duration;
        private string _comment;
        public string Title
        {
            get => _title;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _title = value;
                else
                    throw new ArgumentException("argument may not be null or empty!");
            }
        }
        public int Duration
        {
            get => _duration;
            set
            {
                if (value > 0)
                    _duration = value;
                else
                    throw new ArgumentException("argument may not be less than 0!");

            }
        }
        public string Comment
        {
            get => _comment;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _comment = value;
                else
                    throw new ArgumentException("argument may not be null or empty!");
            }
        }
        public Medium(string title, int duration)
        {
            Title = title;
            Duration = duration;
            Mine = false;
            Comment = "<No Comment>";
        }
        public bool Mine { get; set; }
        public virtual string Print()
        {
            const string delimiter = " | ";
            var data = $"{GetType().Name}: {_title} ({_duration} Min){delimiter}";
            data += Mine ? "Mine" + delimiter : "Not mine" + delimiter;
            data += $"Comment: {_comment}{delimiter}";
            return data;
        }
    }
}
