using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_GUI_app
    {
    
    [Serializable]

    public class HangManGamer
    {



        public HangManGamer() { }
        public HangManGamer(string text)
        {
            this.Name = text;
            LongestWordSolved = "";
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Wins { get; set; }
        public int GamesPlayed { get; set; }
        public string LongestWordSolved { get; set; }
        public int LongestWinStreak { get; set; }
        public int CurrentWinStreak { get; set; }
        //<summary>
        ///Update a HangmanGamer's stats with a loss.  This includes updating GamesPlayed and resetting CurrentWinStreak.
        ///<summary>
        public void AddLoss()
        {
            GamesPlayed++;
            CurrentWinStreak = 0;
        }
        ///<summary>
        ///Updates a HangmanGamer's stats with a win.  This includes updating Wins, GamesPlayed, CurrentWinStreak, LongestWinStreak and LongestWordSolved properties.
        ///</summary>
        ///<param name = "word"></param>
        public void AddWin(string word)
        {
            GamesPlayed++;
            Wins++;
            CurrentWinStreak++;

            //update LongestWordSolved if necessary
            if (word.Length>LongestWordSolved.Length)
            {
                LongestWordSolved = word;
            }

            //update LongestWinStreak if necessary
            if (CurrentWinStreak > LongestWinStreak)
            {
                LongestWinStreak = CurrentWinStreak;
            }
        }
    }//end HangmanGamer class
}
