using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Smalles_Largesr
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            int nSmallest;
            int nLargest;
            int nCurrent;
            string strEntry;

            //first integer
            Console.WriteLine("Enter an interger");
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another interger or Q to Quit");
            strEntry = Console.ReadLine();

            //loop
            while(strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);

                //check to see if input replace largest or smalles
                if(nCurrent>nLargest)
                {
                    nLargest = nCurrent;
                }
                else if(nCurrent<nSmallest)
                {
                    nSmallest = nCurrent;
                }

                Console.WriteLine("Enter another interger or Q to Quit ");
                strEntry = Console.ReadLine();
            }
            Console.WriteLine("The largest value you entered was " + nLargest + ".");
            Console.WriteLine("The smallest value you entered was " + nSmallest + ".");
            Console.ReadLine();
        }
    }
}
