using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_GUI_app
{
    public partial class Form1 : Form
    {


        List<PictureBox> SecretWordTiles = new List<PictureBox>();
        string SecretWord;
        int WrongGuesses;


        public frmHangman()
        {
            InitializeComponent();
        }

        private void frmHangman_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGame()
        {
            WrongGuesses = 0;
            LoadSecretWord();
        }

        private void LoadSecretWord()
        {
           try
            {
                FileAccessor wordBank = new FileAccessor("wordbank.txt");
                SecretWord = wordBank.GetRandomLine();
                InitializeWordDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading a new word. " + ex.ToString(), "Sorry.  The game cannot continue");
                return;
            }
        }

        private void InitializeWordDisplay()
        {
            //create picture boxes for the secret word.
            for (int n = 0; n < SecretWord.Length; n++)
            {
                PictureBox nextLetter = new PictureBox();
                nextLetter.Name = "pbWord" + n;
                nextLetter.Image = Properties.Resources.BLANK;
                nextLetter.Size = new System.Drawing.Size(58,60);
                nextLetter.Location = new System.Drawing.Point(50 + (85 * n), 50);
                this.Controls.Add(nextLetter);
                SecretWordTiles.Add(nextLetter);
            }
        }
    }
}
