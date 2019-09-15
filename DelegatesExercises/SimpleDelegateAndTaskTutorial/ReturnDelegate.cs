namespace SimpleDelegateAndTaskTutorial
{
    internal class ReturnDelegate
    {
        public delegate int Calculator(int x, int y);

        public int Process(Calculator calc, int x, int y)
        {
            var z = calc?.Invoke(x, y);
            return z ?? 0;
        }
    }
}
