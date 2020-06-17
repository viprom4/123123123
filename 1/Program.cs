using System;
using System.Threading;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime time1 =new DateTime(2019, 12, 05, 09, 53, 00);
            Console.WriteLine(time1);

            while (time1>DateTime.Now)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine(DateTime.Now);
            }

            Console.Beep();
            Console.ReadKey();

        }
    }
}
