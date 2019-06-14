namespace _1._2_CounterLib
{
    public delegate void CounterEventHandler(Counter c, CounterEventArgs args);
    public class Counter
    {
        private int _count;
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                CountValueChanged?.Invoke(this, new CounterEventArgs(_count));
            }
        }
        public event CounterEventHandler CountValueChanged;
        public Counter(int count) => Count = count;
        public Counter() : this(0)
        {
        }
        public void Increment() => ++Count;
        public void Decrement() => --Count;
        public void Reset() => Count = 0;
        public void Reset(int value) => Count = value;
    }
}
