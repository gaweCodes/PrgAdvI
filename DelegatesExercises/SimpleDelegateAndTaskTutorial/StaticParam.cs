namespace SimpleDelegateAndTaskTutorial
{
    internal class StaticParam
    {
        public delegate void StaticLogHandler(string message);
        public void Process(StaticLogHandler logHanlder)
        {
            logHanlder?.Invoke("Aufurf 1");
            logHanlder?.Invoke("Aufurf 2");
        }
    }
}
