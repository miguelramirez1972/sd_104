using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program writes the binary equivalent of an integer entered by a user
            //intialize variables
            int x;
            string s = " ";
         
            //promps user for input

            Console.WriteLine("Only an interger can be entered");
            x = Convert.ToInt32(Console.ReadLine());
            int l = x;
            //Takes user input interger and uses it to calculate variable "s"
            //using a while loop.
            while (x > 0) 
            {

                s += x % 2;
                x = x / 2;

              
            }

            //Writes the results for user to see the binary equivalet to the number that was entered
            Console.WriteLine("The binary equivalent of "+l+" is: "+Reverse(s));
            Console.ReadLine();
            
        }
            //Method receives the data from s in the form of a string then converts to an array
            //The array is then reversed
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
            

        }
       
        
    }
    
}
