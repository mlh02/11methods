using System;

namespace _11methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number Hint(1000)");
            // get input
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            // get second input
            int num2 = int.Parse(Console.ReadLine());
            // invoke
            NumPrint(num1, num2);
        }
        static void NumPrint(int num1, int num2)
        {
            //loop through given 2 numbers
            for (int i = num1; i >= num2 ; i--)
            {
                //print out numbers
                Console.WriteLine(i);
            }
        }
    }
}
