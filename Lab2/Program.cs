/*
 * Project: Lab 2 Calculate Batting Avwerage
 * Date: 11-16-2017
 * Author: M Ramirez
 * Notes: This program reads in a baseball player's name,
 * number of hits and number of at bats.
 * The player's batting average is calculated and displayed.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string strPlayerName;
            double nHits, nAtBats;
            double dblBattingAverage;

            //prompt for name and receive
            Console.WriteLine("This program calculates a baseball player's batting average");
            Console.WriteLine("<---------------------------------------------------------->");
            Console.WriteLine("");//we will learn other ways to do this in console programs
            Console.WriteLine("Enter the player's name: ");
            strPlayerName = Console.ReadLine();
            //promp for hits
            Console.WriteLine("Enter the player's # of hits: ");
            nHits = Convert.ToInt32(Console.ReadLine());
            //prompt for hits, walks and at bats
            Console.WriteLine("Enter the player's # of at bats: ");
            nAtBats = Convert.ToInt32(Console.ReadLine());
            //calculation
            dblBattingAverage = nHits / nAtBats;
            Console.WriteLine(strPlayerName + "'s batting average is " + dblBattingAverage);
            Console.ReadLine();
        }
    }
}
