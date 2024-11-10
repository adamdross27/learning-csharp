using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; //declared but not used
            num1 = 27; //initialised now
            System.Console.WriteLine("Number1: " + num1); //prints num1 out.

            int num2 = 29;

            System.Console.WriteLine("Number2: " + num2); 

            System.Console.WriteLine("Number1 + Number2 = " + (num1+num2));

            double height = 195.4;
            System.Console.WriteLine("I am " + height + "cm tall!");

            bool isTall = false;

            if(height > 185)
            {
                isTall = true;
            }

            Console.WriteLine("Am i tall? " + isTall);

            char symbol = '@';

            Console.WriteLine("Your symbol is: " + symbol);

            String name = "Adam";

            Console.WriteLine("My name is " + name);

            String userName = symbol + name;
            Console.WriteLine("Your username is: " + userName);



            Console.ReadKey();
        }
    }
}