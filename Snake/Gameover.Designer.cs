namespace Snake
{
    partial class Gameover
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
            this.Duzegameover = new System.Windows.Forms.Label();
            this.rekord = new System.Windows.Forms.Label();
            this.uzytkownik = new System.Windows.Forms.Label();
            this.rekordgameover = new System.Windows.Forms.Label();
            this.logingameover = new System.Windows.Forms.Label();
            this.playagain = new System.Windows.Forms.Button();
            this.backtomenu = new System.Windows.Forms.Button();
            this.whydead = new System.Windows.Forms.Label();
            this.sponsoredby = new System.Windows.Forms.Label();
            this.sponsor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Duzegameover
            // 
            this.Duzegameover.AutoSize = true;
            this.Duzegameover.Font = new System.Drawing.Font("Showcard Gothic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duzegameover.Location = new System.Drawing.Point(262, 128);
            this.Duzegameover.Name = "Duzegameover";
            this.Duzegameover.Size = new System.Drawing.Size(310, 62);
            this.Duzegameover.TabIndex = 0;
            this.Duzegameover.Text = "GAME OVER";
            // 
            // rekord
            // 
            this.rekord.AutoSize = true;
            this.rekord.Location = new System.Drawing.Point(653, 45);
            this.rekord.Name = "rekord";
            this.rekord.Size = new System.Drawing.Size(53, 17);
            this.rekord.TabIndex = 12;
            this.rekord.Text = "rekord:";
          
            // 
            // uzytkownik
            // 
            this.uzytkownik.AutoSize = true;
            this.uzytkownik.Location = new System.Drawing.Point(626, 18);
            this.uzytkownik.Name = "uzytkownik";
            this.uzytkownik.Size = new System.Drawing.Size(80, 17);
            this.uzytkownik.TabIndex = 11;
            this.uzytkownik.Text = "użytkownik:";
            // 
            // rekordgameover
            // 
            this.rekordgameover.AutoSize = true;
            this.rekordgameover.Location = new System.Drawing.Point(712, 45);
            this.rekordgameover.Name = "rekordgameover";
            this.rekordgameover.Size = new System.Drawing.Size(46, 17);
            this.rekordgameover.TabIndex = 10;
            this.rekordgameover.Text = "label3";
            // 
            // logingameover
            // 
            this.logingameover.AutoSize = true;
            this.logingameover.Location = new System.Drawing.Point(712, 18);
            this.logingameover.Name = "logingameover";
            this.logingameover.Size = new System.Drawing.Size(46, 17);
            this.logingameover.TabIndex = 9;
            this.logingameover.Text = "label2";
            // 
            // playagain
            // 
            this.playagain.Location = new System.Drawing.Point(210, 254);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(151, 47);
            this.playagain.TabIndex = 13;
            this.playagain.Text = "Graj od nowa";
            this.playagain.UseVisualStyleBackColor = true;
            this.playagain.Click += new System.EventHandler(this.button1_Click);
            // 
            // backtomenu
            // 
            this.backtomenu.Location = new System.Drawing.Point(447, 254);
            this.backtomenu.Name = "backtomenu";
            this.backtomenu.Size = new System.Drawing.Size(151, 47);
            this.backtomenu.TabIndex = 14;
            this.backtomenu.Text = "Powrót do menu";
            this.backtomenu.UseVisualStyleBackColor = true;
            this.backtomenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // whydead
            // 
            this.whydead.AutoSize = true;
            this.whydead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.whydead.ForeColor = System.Drawing.Color.Red;
            this.whydead.Location = new System.Drawing.Point(333, 206);
            this.whydead.Name = "whydead";
            this.whydead.Size = new System.Drawing.Size(70, 25);
            this.whydead.TabIndex = 15;
            this.whydead.Text = "label6";
            // 
            // sponsoredby
            // 
            this.sponsoredby.AutoSize = true;
            this.sponsoredby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sponsoredby.Location = new System.Drawing.Point(344, 342);
            this.sponsoredby.Name = "sponsoredby";
            this.sponsoredby.Size = new System.Drawing.Size(139, 25);
            this.sponsoredby.TabIndex = 16;
            this.sponsoredby.Text = "Sponsored by ";
            // 
            // sponsor
            // 
            this.sponsor.AutoSize = true;
            this.sponsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sponsor.Location = new System.Drawing.Point(223, 384);
            this.sponsor.Name = "sponsor";
            this.sponsor.Size = new System.Drawing.Size(155, 25);
            this.sponsor.TabIndex = 17;
            this.sponsor.Text = "nazwa sponosra";
            // 
            // Gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sponsor);
            this.Controls.Add(this.sponsoredby);
            this.Controls.Add(this.whydead);
            this.Controls.Add(this.backtomenu);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.rekord);
            this.Controls.Add(this.uzytkownik);
            this.Controls.Add(this.rekordgameover);
            this.Controls.Add(this.logingameover);
            this.Controls.Add(this.Duzegameover);
            this.Name = "Gameover";
            this.Text = "Game over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Duzegameover;
        private System.Windows.Forms.Label rekord;
        private System.Windows.Forms.Label uzytkownik;
        public System.Windows.Forms.Label rekordgameover;
        public System.Windows.Forms.Label logingameover;
        private System.Windows.Forms.Button playagain;
        private System.Windows.Forms.Button backtomenu;
        public System.Windows.Forms.Label whydead;
        private System.Windows.Forms.Label sponsoredby;
        public System.Windows.Forms.Label sponsor;
    }
}