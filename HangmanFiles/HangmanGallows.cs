using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_GUI_app
{
    class HangmanGallows
    {

        /// <summary>
        /// Returns the gallows image that corresponds to the stage integer passed.
        /// </summary>
        /// <param name="wrongGuesses">Indicates which stage of the Hangman gallows to draw</param>
        public static string GetGallowImage(int wrongGuesses)
        {
            
            

            switch (wrongGuesses)
            {
                case 0: return "./Resources/Stage0.png"; 
                case 1: return "./Resources/Stage1.png"; 
                case 2: return "./Resources/Stage2.png"; 
                case 3: return "./Resources/Stage3.png"; 
                case 4: return "./Resources/Stage4.png"; 
                case 5: return "./Resources/Stage5.png"; 
                case 6: return "./Resources/Stage6.png"; 
                case 7: return "./Resources/Stage7.png"; 
                case 8: return "./Resources/Stage8.png"; 
                case 9: return "./Resources/Stage9.png"; 
                case 10: return "./Resources/StageFinal.png";
                default:return "./Resources/Stage0.png"; 
            }
        }

       
    }
}

