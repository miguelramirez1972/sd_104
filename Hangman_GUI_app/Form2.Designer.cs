namespace Hangman_GUI_app
{
    partial class frmHangman
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.txtNewPlayer = new System.Windows.Forms.TextBox();
            this.btnCreatePlayer = new System.Windows.Forms.Button();
            this.ssGamerStats = new System.Windows.Forms.StatusStrip();
            this.tsslName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslWins = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStreak = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerStatsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCreatePlayer = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPlayer = new System.Windows.Forms.Button();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.ssGamerStats.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlCreatePlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(19, 22);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(163, 24);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // txtNewPlayer
            // 
            this.txtNewPlayer.Location = new System.Drawing.Point(210, 26);
            this.txtNewPlayer.Name = "txtNewPlayer";
            this.txtNewPlayer.Size = new System.Drawing.Size(327, 20);
            this.txtNewPlayer.TabIndex = 1;
            // 
            // btnCreatePlayer
            // 
            this.btnCreatePlayer.BackColor = System.Drawing.Color.Blue;
            this.btnCreatePlayer.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlayer.Location = new System.Drawing.Point(296, 91);
            this.btnCreatePlayer.Name = "btnCreatePlayer";
            this.btnCreatePlayer.Size = new System.Drawing.Size(149, 38);
            this.btnCreatePlayer.TabIndex = 2;
            this.btnCreatePlayer.Text = "Create Player";
            this.btnCreatePlayer.UseVisualStyleBackColor = false;
            this.btnCreatePlayer.Click += new System.EventHandler(this.btnCreatePlayer_Click);
            // 
            // ssGamerStats
            // 
            this.ssGamerStats.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslName,
            this.tsslWins,
            this.tsslStreak});
            this.ssGamerStats.Location = new System.Drawing.Point(0, 402);
            this.ssGamerStats.Name = "ssGamerStats";
            this.ssGamerStats.Size = new System.Drawing.Size(673, 22);
            this.ssGamerStats.TabIndex = 3;
            this.ssGamerStats.Text = "ssGamerStats";
            // 
            // tsslName
            // 
            this.tsslName.Name = "tsslName";
            this.tsslName.Size = new System.Drawing.Size(56, 17);
            this.tsslName.Text = "tsslName";
            // 
            // tsslWins
            // 
            this.tsslWins.Name = "tsslWins";
            this.tsslWins.Size = new System.Drawing.Size(50, 17);
            this.tsslWins.Text = "tsslWins";
            // 
            // tsslStreak
            // 
            this.tsslStreak.Name = "tsslStreak";
            this.tsslStreak.Size = new System.Drawing.Size(56, 17);
            this.tsslStreak.Text = "tsslStreak";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerStatsToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerStatsToolStrip
            // 
            this.playerStatsToolStrip.Name = "playerStatsToolStrip";
            this.playerStatsToolStrip.Size = new System.Drawing.Size(79, 20);
            this.playerStatsToolStrip.Text = "Player Stats";
            // 
            // pnlCreatePlayer
            // 
            this.pnlCreatePlayer.Controls.Add(this.btnCancel);
            this.pnlCreatePlayer.Controls.Add(this.btnCreatePlayer);
            this.pnlCreatePlayer.Controls.Add(this.lblPlayerName);
            this.pnlCreatePlayer.Controls.Add(this.txtNewPlayer);
            this.pnlCreatePlayer.Location = new System.Drawing.Point(56, 197);
            this.pnlCreatePlayer.Name = "pnlCreatePlayer";
            this.pnlCreatePlayer.Size = new System.Drawing.Size(571, 158);
            this.pnlCreatePlayer.TabIndex = 5;
            this.pnlCreatePlayer.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(33, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 38);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Who\'s Playing";
            // 
            // btnSelectPlayer
            // 
            this.btnSelectPlayer.BackColor = System.Drawing.Color.LightGray;
            this.btnSelectPlayer.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPlayer.Location = new System.Drawing.Point(266, 153);
            this.btnSelectPlayer.Name = "btnSelectPlayer";
            this.btnSelectPlayer.Size = new System.Drawing.Size(81, 38);
            this.btnSelectPlayer.TabIndex = 7;
            this.btnSelectPlayer.Text = "OK";
            this.btnSelectPlayer.UseVisualStyleBackColor = false;
            this.btnSelectPlayer.Click += new System.EventHandler(this.btnSelectPlayer_Click);
            // 
            // cbPlayer
            // 
            this.cbPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(252, 97);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(292, 21);
            this.cbPlayer.TabIndex = 8;
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(673, 424);
            this.Controls.Add(this.cbPlayer);
            this.Controls.Add(this.btnSelectPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCreatePlayer);
            this.Controls.Add(this.ssGamerStats);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHangman";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmHangman_Load);
            this.ssGamerStats.ResumeLayout(false);
            this.ssGamerStats.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlCreatePlayer.ResumeLayout(false);
            this.pnlCreatePlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.TextBox txtNewPlayer;
        private System.Windows.Forms.Button btnCreatePlayer;
        private System.Windows.Forms.StatusStrip ssGamerStats;
        private System.Windows.Forms.ToolStripStatusLabel tsslName;
        private System.Windows.Forms.ToolStripStatusLabel tsslWins;
        private System.Windows.Forms.ToolStripStatusLabel tsslStreak;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerStatsToolStrip;
        private System.Windows.Forms.Panel pnlCreatePlayer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectPlayer;
        private System.Windows.Forms.ComboBox cbPlayer;
    }
}