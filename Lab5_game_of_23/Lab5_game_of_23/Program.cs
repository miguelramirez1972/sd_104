using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_game_of_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string strPlayAgain;
            do
            {
                int nToothpicksLeft = 23;
                int nUserPick, nCpuPick ;
                

                Console.WriteLine("             Game of 23               ");
                Console.WriteLine("Pick either 1, 2 or 3 toothpicks from the pile.");
                Console.WriteLine("I will pick after you.  Last unitelligent entity to draw a toothpick looses.");
                do
                {


                    //display toothpick
                    for (int n = 0; n < nToothpicksLeft; n++)
                    {
                        if (n % 4 == 0)
                        {
                            Console.Write("/");
                        }
                        else if (n % 4 == 1)
                        {
                            Console.Write("|");
                        }
                        else if (n % 4 == 2)
                        {
                            Console.Write("_");
                        }
                        else
                        {
                            Console.Write("\\");
                        }
                    }
                    Console.WriteLine("<-- " + nToothpicksLeft + "toothpicks left.\n");
                    //promp user
                    Console.WriteLine("Pick 1, 2 or 3 toothpicks:");
                    while (!int.TryParse(Console.ReadLine(), out nUserPick) || (nUserPick < 1 || nUserPick > 3))
                    {
                        Console.WriteLine("Not a valid entry.  Must be a number from 1 to 3");
                        Console.WriteLine("Pick 1, 2 or 3 toothpicks:");

                    }

                    nToothpicksLeft -= nUserPick;



                    //Computer's choice
                    if (nToothpicksLeft > 4)
                    {
                        nCpuPick = 4 - nUserPick;
                        nToothpicksLeft -= nCpuPick;
                        Console.WriteLine("I pick " + nCpuPick);

                    }
                    else if (nToothpicksLeft > 1 && nToothpicksLeft < 4)
                    {
                        nCpuPick = nToothpicksLeft - 1;
                        nToothpicksLeft -= nCpuPick;
                        Console.WriteLine("I pick " + nCpuPick + " and I win!");
                    }
                    else if (nToothpicksLeft == 1)
                    {
                        nToothpicksLeft -= 1;
                        Console.WriteLine("Nice work.....you win!");
                    }
                   

                } while (nToothpicksLeft > 1);

                    Console.WriteLine("Play Again? Y for yes: ");
                    strPlayAgain = Console.ReadLine();
                

            } while (strPlayAgain == "Y"||strPlayAgain == "y");

            
        }
        
    }
}