using System;
using SimpleDelegateAndTaskTutorial.Event;
using EventHandler = System.EventHandler;

namespace SimpleDelegateAndTaskTutorial
{
    internal class Program
    {
        public delegate void BasicDelegate();
        private static void Main()
        {
            // Langform
            // var function = new BasicDelegate(Basic.BasicUsageFunction);

            // Kurzform
            BasicDelegate function = Basic.BasicUsageFunction;
            function?.Invoke();

            var retDel = new ReturnDelegate();
            ReturnDelegate.Calculator calculator = Add;
            calculator += delegate(int x, int y) { return x - y; };
            var res = retDel.Process(calculator, 5, 5);
            Console.WriteLine(res);

            var loggerDelegate = new StaticParam();
            StaticParam.StaticLogHandler myLogger = Logger;
            // StaticParam.StaticLogHandler myLogger = delegate(string msg) { Console.WriteLine(msg); };
            loggerDelegate.Process(myLogger);

            var fileLogger = new FileLogger(@"C:\Users\Gabriel\Desktop\test\abc.txt");
            var member = new MemberFunction();
            MemberFunction.LogHandlerMember myFileLogger = null;
            myFileLogger += fileLogger.Log;
            myFileLogger += Logger;
            member.Process(myFileLogger);
            fileLogger.Close();

            var acct = new Account(1000);
            // acct.OverDrawn += new EventHandler(OnOverDrawn);
            acct.OverDrawn += OnOverDrawn;
            acct.Debit(500);
            acct.Debit(600);
            acct.OverDrawn -= OnOverDrawn;
            Console.ReadLine();
        }
        private static void Logger(string message)
        {
            Console.WriteLine(message);
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static void OnOverDrawn(object sender, OverDrawnEventArgs e)
        {
            Console.WriteLine($"I'm overdrawn! Current balance = {e.Balance}.");
        }
    }
}
