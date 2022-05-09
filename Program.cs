using System;
using System.Threading;

namespace TimerClockAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(PrintDate);
            thread1.Start();
            Thread thread2 = new Thread(PrintDatesec);
            thread2.Start();


        }
        static void PrintDate()
        {
            Console.WriteLine($"printing present time :{DateTime.Now}");

        }
        static void PrintDatesec()
        {
            TimerCallback timercallback = new TimerCallback(PrintMessage);
            System.Threading.Timer timer = new System.Threading.Timer(timercallback, null, 1000, 1000);
            Console.ReadLine();
        }
        private static void PrintMessage(object msg)
        {
            Console.WriteLine($"printing time for every second:{DateTime.Now}");

        }
    }
}