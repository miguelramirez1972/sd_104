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
        /// <param name="stage">Indicates which stage of the Hangman gallows to draw</param>
        public static Image GetGallowImage(int stage)
        {
            
            

            switch (stage)
            {
                case 0: return Properties.Resources.Stage0; 
                case 1: return Properties.Resources.Stage1; 
                case 2: return Properties.Resources.Stage2; 
                case 3: return Properties.Resources.Stage3; 
                case 4: return Properties.Resources.Stage4; 
                case 5: return Properties.Resources.Stage5; 
                case 6: return Properties.Resources.Stage6; 
                case 7: return Properties.Resources.Stage7; 
                case 8: return Properties.Resources.Stage8; 
                case 9: return Properties.Resources.Stage9; 
                case 10: return Properties.Resources.StageFinal;
                default:return Properties.Resources.Stage0; 
            }
        }

       
    }
}

