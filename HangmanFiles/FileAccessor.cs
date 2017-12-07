using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_GUI_app
{
    class FileAccessor
    {
        StreamReader textIn;
        FileStream fileStream;
        /// <summary>
        /// Gets or sets the path to the file that is being accessed
        /// </summary>
        public string FilePath { get; set; }


        /// <summary>
        /// Creates an instance of a FileAccessor, setting
        /// the FilePath property to the passed value.
        /// </summary>
        /// <param name="filePath"></param>
        public FileAccessor(string filePath)
        {
            FilePath = filePath;
            fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            textIn = new StreamReader(fileStream);
        }



        /// <summary>
        /// Returns a random line from the file.
        /// </summary>
        /// <returns>Random line from file as a string.</returns>
        public string GetRandomLine()
        {
            
            //get random word
            Random myrandom = new Random();
            int randNum = myrandom.Next(1, GetUpperBounds());

            //read through file to get word
            for (int i = 0; i < randNum; i++)
            {
                textIn.ReadLine();
            }

            return textIn.ReadLine();

        }
        
        public int GetUpperBounds()
        {
            int fileUpperBounds = 0;
            fileStream.Position = 0;

            while(!textIn.EndOfStream)
            {
                textIn.ReadLine();
                fileUpperBounds++;
            }

            fileStream.Position = 0;
            //return number of lines
            return fileUpperBounds;

        }




    }
}
