using System;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BPO.Core.Log4NetHelper.Info(nameof(Program), "Test");
            BPO.Core.Log4NetHelper.Log(BPO.Core.LoggerType.LogError, "Test SqlLog", new Exception("测试"));
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
