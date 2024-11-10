using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hello! ");
            Console.Write("This doesn't start on a new line");
            Console.WriteLine("This will start on a new line");

            //Comment one line

            /* Comment
             * On
             * Multiple
             * Lines
             */

            Console.WriteLine("\tMy name is Adam with a tab at the front. This is a backspace so it will get rid of last letter\b");

            Console.ReadKey();
        }
    }
}