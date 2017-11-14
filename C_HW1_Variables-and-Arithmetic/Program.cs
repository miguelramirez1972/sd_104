using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW1_Variables_and_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne, numTwo, sum, product, difference, quotient;


            Console.WriteLine("Enter an integer");

            //Gathers the numbers to be clculated
            numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another integer");
            numTwo = Convert.ToInt32(Console.ReadLine());

            //Calculations
            sum = numOne + numTwo;
            product = numOne * numTwo;
            difference = numOne - numTwo;
            quotient = numTwo / numOne;

            //Prints out the results of the calculations
            Console.WriteLine("The sum of the two numbers entered is: "+sum);
            Console.WriteLine("The product of the two numbers entered is: " + product);
            Console.WriteLine("The difference of the two numbers entered is: " + difference);
            Console.WriteLine("The quotient of the two numbers entered is: " + quotient);
            Console.ReadLine();
        }
    }
}
