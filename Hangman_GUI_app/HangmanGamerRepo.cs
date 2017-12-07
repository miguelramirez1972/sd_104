using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_GUI_app
{
    class HangmanGamerRepo
    {
        HangmanDbContext _db = new HangmanDbContext();
        /// <summary>
        /// Returns a list of all HangmanGamer objects in the database
        /// </summary>
        /// <returns></returns>

        public List<HangManGamer> GetHangManGamers()
        {
            return _db.HangManGamers.ToList();
        }

        /// <summary>
        /// Returns the first HangManGamer object from the db with a name equal to "string name"
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public HangManGamer GetGamerByName(string name)
        {
            return _db.HangManGamers.FirstOrDefault(g => g.Name == name);
        }

        /// <summary>
        /// Adds the passed Hangman gamer to the database.
        /// </summary>
        /// <param name="gamer"></param>
        public void AddGamer(HangManGamer gamer)
        {
            _db.HangManGamers.Add(gamer);
        }
        /// <summary>
        /// Mi=odifies the entity in the DbSet corresponding to the passed gamer.
        /// </summary>
        /// <param name="gamer"></param>
        public void UpdateGamer(HangManGamer gamer)
        {
            _db.Entry(gamer).State = System.Data.Entity.EntityState.Modified;
        }

        
        /// <summary>
        /// Saves all changes to the collection of games to the database.
        /// </summary>
        public void Save()
        {
            _db.SaveChanges();
        }


    }
}
