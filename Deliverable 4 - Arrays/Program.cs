using System;

namespace Deliverable_4___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibNumbers = new int[25];
            fibNumbers[0] = 0;
            fibNumbers[1] = 1;

            for (int i = 2; i < 25; i++)
            {
                fibNumbers[i] = fibNumbers[i - 2] + fibNumbers[i - 1];
            }

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibNumbers[i]);
            }
            Console.ReadLine();
        }
    }
}


