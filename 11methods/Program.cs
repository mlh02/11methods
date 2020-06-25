using System;

namespace _11methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter first Number Hint(1000)");
            //// get input
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //// get second input
            //int num2 = int.Parse(Console.ReadLine());
            //// invok

            //Console.WriteLine("start 3 number");
            //int randomsStart = int.Parse(Console.ReadLine());
            //Console.WriteLine("end number");
            //int randomsEnd = int.Parse(Console.ReadLine());

            Console.WriteLine("choose compare first number");
            int firstCompare = int.Parse(Console.ReadLine());
            Console.WriteLine("choose compare second number");
            int secondCompare = int.Parse(Console.ReadLine());

            //NumPrint(num1, num2);
            //NumByThrees(randomsStart, randomsEnd);
            ComapreNums(firstCompare, secondCompare);
        }
        static void NumPrint(int num1, int num2)
        {
            //loop through given 2 numbers
            for (int i = num1; i >= num2; i--)
            {
                //print out numbers
                Console.WriteLine(i);
            }
        }

        static void NumByThrees(int num, int num2)
            {
                //loop through given 2 numbers
                for (int i = num; i < num2; i = i + 3)
                {
                    //print out numbers
                    Console.WriteLine(i);
                }
            }
        static void ComapreNums(int num, int num2)
        {
            //loop through given 2 numbers
            if (num == num2)
            {
                //print out numbers
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}


