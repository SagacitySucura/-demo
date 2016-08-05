using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task的多线程
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                Task.Run(()=>Print(i));
            }
            Console.ReadKey();
        }
        public static void Print(object obj)
        {
         //   Console.WriteLine(obj.ToString());
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
