using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AwaitAndaAsync
{
    class Program
    {
        static int i = 0;
        static SemaphoreSlim semap = new SemaphoreSlim(3);
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Task.Run(() => Test());
            }
            Console.WriteLine("我是主进程！");

            Console.ReadKey();

        }
        async static Task Test()
        {
            semap.Wait();
            var id = await Get();
            Console.WriteLine("my id is {0}", id);
            Thread.Sleep(1000);
            semap.Release();
        }
        async static Task<int> Get()
        {
            Console.WriteLine("my order is {0}",i);
            return Thread.CurrentThread.ManagedThreadId;
        }
    }
}
