using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssesmentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Fibonacci_Iterative();
        }

        // Method For Fibonacci Series
        public static void Fibonacci_Iterative()
        {
            int a = 0, b = 1, c = 0;
            long sum=0; 
            bool check = false;

            // Loop will print Fibonacci Series

            for (int i = 0; i < 4000000; i++)
            {
                c = a + b;
                check = Program.IsEven(c);

                // Condition that will check if number is even then add otherwise not
                if (check)
                {
                    sum += c;
                    check = false;
                }
                a = b;
                b = c;
            }
            Console.WriteLine("Sum of even numbers in fibonacci series  {0}", sum);
        }
        //Check wether number is even
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
