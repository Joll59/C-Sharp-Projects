using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
            string input = Console.ReadLine();
            Console.WriteLine(AddToResult(input));
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Enter a Word to Reverse");
        }

        private static string AddToResult(string args)
        {
            Console.WriteLine("Adding to result");
            return Reverser(String.Concat(args));

        }

        private static string AddToResult(string args, string arg1, string arg2)
        {
            Console.WriteLine("Adding Words together result");
            return Reverser(String.Concat(args, arg1, arg2));
        }

        private static string Reverser(string zar)
        {
            char[] tryMe = zar.ToCharArray();
            Array.Reverse(tryMe);
            return String.Concat(tryMe);

        }


    }
}
