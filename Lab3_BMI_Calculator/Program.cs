using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            double dblHeight;
            double dblWeight;
            double dblBMI;

            //user input
            Console.WriteLine("Enter your Height in inches: ");
            dblHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Weight in pounds: ");
            dblWeight = Convert.ToInt32(Console.ReadLine());

            //calculations
            dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);
            //issue result and message

            if (dblBMI < 18.5)
            {
                Console.WriteLine("BMI < 18.5 - Underweight");
            }
            else if(dblBMI<=24.9)
            {
                Console.WriteLine("BMI between 18.5 and 24.9 - Normal");
            }
            else if (dblBMI <= 29.9)
            {
                Console.WriteLine("BMI between 25 and 29.99 - Overweight");
            }
            else
            {
                Console.WriteLine("BMI >= 30 - Obese");
            }
            Console.ReadLine();


        }
    }
}
