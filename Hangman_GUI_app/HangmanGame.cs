using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_GUI_app
{
    class HangmanGame
    {
        static string strSecretWord;
        static int nWrongGuess = 0;
        static string[] WordDisplay;
        static bool guesedIt = false;
        static string strlettersGuessed;

        public HangmanGame()
        {

            guesedIt = false;
            nWrongGuess = 0;
            strlettersGuessed = "";
            FileAccessor wordBank = new FileAccessor("wordbank.txt");
            strSecretWord = wordBank.GetRandomLine();
            WordDisplay = InitializeWordDisplay(strSecretWord);

        }

        /// <summary>
        /// Play the game of hangman
        /// </summary>

        public void Play()
        {

            //display all gallows
            while (!guesedIt && nWrongGuess < 10)
            {
                HangmanGallows.GetGallowImage(nWrongGuess);
                //Print wordDisplay
                PrintSecretWord(WordDisplay);
                Console.WriteLine("Letters guessed: " + strlettersGuessed);

                nWrongGuess += PlayerGuess(WordDisplay, strSecretWord);
                guesedIt = GuessWord(WordDisplay);



            }

            if (guesedIt)
            {
                Console.WriteLine("You got it!! " + strSecretWord);
            }
            else
            {
                Console.WriteLine("Executed!!  The word was " + strSecretWord);
            }

           
        }



        private static bool GuessWord(string[] WordDisplay)
        {
            //loop through WordDisplay and see if the word is guessed correcly
            for (int i = 0; i < WordDisplay.Length; i++)
            {
                if (WordDisplay[i] == " _ ")
                {
                    return false;
                }//end if

            }//end for loop
            return true;
        }
        private static int PlayerGuess(string[] WordDisplay, string strSecretWord)
        {
            string strUserGuess;
            int nWrongGuess = 1;
            //promp user

            Console.Write("\nGuess a letter: ");
            strUserGuess = Console.ReadLine();
            strlettersGuessed += strUserGuess;

            //process guess
            for (int n = 0; n < strSecretWord.Length; n++)
            {
                if (strSecretWord[n].ToString() == strUserGuess)
                {
                    WordDisplay[n] = strUserGuess;
                    nWrongGuess = 0;
                }

            }

            return nWrongGuess;


        }

        private static void PrintSecretWord(string[] wordDisplay)
        {
            //print word
            for (int i = 0; i < wordDisplay.Length; i++)
            {
                Console.Write(wordDisplay[i]);

            }

            Console.WriteLine();

        }

        private static string[] InitializeWordDisplay(string strSecretWord)
        {
            string[] wordDisplay = new string[strSecretWord.Length];

            //fill wordDisplay array with _
            for (int i = 0; i < wordDisplay.Length; i++)
            {
                wordDisplay[i] = " _ ";
            }

            return wordDisplay;

        }
    }

    
}
