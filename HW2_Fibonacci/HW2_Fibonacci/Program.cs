using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework #2.  Write a program that prompts the user for which number in the Fibonacci 
            //sequence that they want to see, and then compute it for them.  Do this by writing a 
            //loop that will start with 1 and 1 as the previous two numbers, adds them, and then stores 
            //the result as the previous before the next loop iteration.

            
            Console.WriteLine("Enter Fibonacci number desired: ");
           int b;
           b=Convert.ToInt32(Console.ReadLine());
            
            int ans = fibonacci(b);
            Console.WriteLine(ans);
            Console.ReadLine();
            //fib [6] is equal to 8
           

        }
        static int fibonacci(int n)
        {
            int[] fib = new int[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i=2; i<=n;i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib[n];

        }
    }
}
