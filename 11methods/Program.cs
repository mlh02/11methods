using System;

namespace _11methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumPrint(1000));
        }
        static int NumPrint(int userNumber)
        {
            int number = 0;
            for (int i = -1000; i <= userNumber; i++)
            {
                number = i;

            }
            return number;
   
        }
    }
}
