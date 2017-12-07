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
    public partial class frmHangman : Form
    {
        List<HangManGamer> gamers;
        HangmanGamerRepo gamerRepo = new HangmanGamerRepo();

        public frmHangman()
        {
            InitializeComponent();
           
        }

        private void btnCreatePlayer_Click(object sender, EventArgs e)
        {
            HangManGamer currentGamer = new HangManGamer(txtNewPlayer.Text);
            gamerRepo.AddGamer(currentGamer);
            gamerRepo.Save();
            PopulatePlayers();
            cbPlayer.SelectedIndex = cbPlayer.Items.Count -1;
            pnlCreatePlayer.Visible = false;
           
        }

        private void frmHangman_Load(object sender, EventArgs e)
        {
            PopulatePlayers();
        }

        public void PopulatePlayers()
        {
            cbPlayer.Items.Clear();
            cbPlayer.Items.Add("New Player");

            //get gamers from repo
            gamers = gamerRepo.GetHangManGamers();
            foreach (HangManGamer gamer in gamers) 
            {
                cbPlayer.Items.Add(gamer.Name);
            }
        }

        private void btnSelectPlayer_Click(object sender, EventArgs e)
        {
            if(cbPlayer.SelectedItem.ToString()=="New Player")
            {
                pnlCreatePlayer.Visible = true;
            }
            else
            {
               
                    frmMain hangman = new frmMain(gamerRepo.GetGamerByName(cbPlayer.SelectedItem.ToString()));
                    hangman.Show();
                    this.Hide();
            }
        }//end btnSelectPlayer_Click
    }
}
