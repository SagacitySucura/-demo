using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 线程池
{
    class Program
    {
        /// <summary>
        /// 使用Threadpool作为线程池的状态,调用的函数必须有参数
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("my id is 1");
            ThreadPool.QueueUserWorkItem(One);
            ThreadPool.QueueUserWorkItem(Two);
            ThreadPool.QueueUserWorkItem(Three);
            Console.ReadKey();

        }
        public static void One(object obj)
        {
            Console.WriteLine("my id is 2");
        }
        public static void Two(object obj)
        {
            Console.WriteLine("my id is 3");
        }
        public static void Three(object obj)
        {
            Console.WriteLine("my id is 4");
        }
    }
}
