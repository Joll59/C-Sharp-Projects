using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //TimeSpan myString = DateTime.Now.Subtract(DateTime.Parse("11/09/1982"));
            TimeSpan myTest = new TimeSpan(1000000, 0, 0);

            Console.WriteLine(myTest.Days / 365);
            Console.ReadLine();

        }
    }
}
