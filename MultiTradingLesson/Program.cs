using System;
using System.Collections.Generic;
using System.Threading;

namespace MultiTradingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var curretThread = Thread.CurrentThread;
            Console.WriteLine($"{curretThread.ManagedThreadId} - begin of potok");
            //var thread = new Thread(ProcessWork);
            //thread.IsBackground = false;
            var thread = new Thread(ProcessData);
            thread.Start(new List<object> { 
                new {Name = "asd"},
                new {Name = "bekzat"}
            });
            //ProcessWork();
            Console.WriteLine($"{curretThread.ManagedThreadId} - end of potok");
            //Console.ReadLine();                                 
             
        }
        static void ProcessWork()
        {
            var curretThread = Thread.CurrentThread;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{curretThread.ManagedThreadId} - {i}");
                Thread.Sleep(500);
            }
        }
        static void ProcessData(object data)
        {
            Thread.Sleep(3000);
            foreach(var item in data as List<object>)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(data);
        }
    }
}
