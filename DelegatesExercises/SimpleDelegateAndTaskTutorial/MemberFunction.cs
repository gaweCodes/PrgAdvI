namespace SimpleDelegateAndTaskTutorial
{
    internal class MemberFunction
    {
        public delegate void LogHandlerMember(string message);
        public void Process(LogHandlerMember logHandler)
        {
            logHandler?.Invoke("Process() begin");
            logHandler?.Invoke("Process() end");
        }
    }
}
