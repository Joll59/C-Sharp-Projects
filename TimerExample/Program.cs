using System;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);
            Timer my2ndTimer = new Timer(4000);
            myTimer.Elapsed += MyTimer_Elapsed;
            my2ndTimer.Elapsed += My2ndTimer_Elapsed;
            myTimer.Start();
            Console.ReadLine();
            my2ndTimer.Start();
            Console.ReadLine();
            my2ndTimer.Elapsed -= My2ndTimer_Elapsed;
            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(
            object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Elapsed Time: {0:HH:m:s.fff}", e.SignalTime);
        }

        private static void My2ndTimer_Elapsed(
            object sender, ElapsedEventArgs e)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed Time 2: {0:HH:m:s.fff}", e.SignalTime);
            Console.ResetColor();
        }
    }
}