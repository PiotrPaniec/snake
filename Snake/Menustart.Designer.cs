namespace Snake
{
    partial class Menustart
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.duzysnake = new System.Windows.Forms.Label();
            this.zalogujsie = new System.Windows.Forms.Button();
            this.wyswietl = new System.Windows.Forms.Button();
            this.sponsored = new System.Windows.Forms.Label();
            this.sponsor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // duzysnake
            // 
            this.duzysnake.AutoSize = true;
            this.duzysnake.Font = new System.Drawing.Font("Wide Latin", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duzysnake.Location = new System.Drawing.Point(340, 57);
            this.duzysnake.Name = "duzysnake";
            this.duzysnake.Size = new System.Drawing.Size(301, 61);
            this.duzysnake.TabIndex = 0;
            this.duzysnake.Text = "Snake";
            // 
            // zalogujsie
            // 
            this.zalogujsie.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zalogujsie.Location = new System.Drawing.Point(335, 152);
            this.zalogujsie.Name = "zalogujsie";
            this.zalogujsie.Size = new System.Drawing.Size(315, 106);
            this.zalogujsie.TabIndex = 1;
            this.zalogujsie.Text = "Zaloguj sie ";
            this.zalogujsie.UseVisualStyleBackColor = true;
            this.zalogujsie.Click += new System.EventHandler(this.logowanieClick);
            // 
            // wyswietl
            // 
            this.wyswietl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyswietl.Location = new System.Drawing.Point(335, 264);
            this.wyswietl.Name = "wyswietl";
            this.wyswietl.Size = new System.Drawing.Size(315, 114);
            this.wyswietl.TabIndex = 2;
            this.wyswietl.Text = "Wyswietl rankingi ";
            this.wyswietl.UseVisualStyleBackColor = true;
            this.wyswietl.Click += new System.EventHandler(this.rankingiClick);
            // 
            // sponsored
            // 
            this.sponsored.AutoSize = true;
            this.sponsored.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sponsored.Location = new System.Drawing.Point(392, 446);
            this.sponsored.Name = "sponsored";
            this.sponsored.Size = new System.Drawing.Size(169, 29);
            this.sponsored.TabIndex = 4;
            this.sponsored.Text = "Sponsored by";
            // 
            // sponsor
            // 
            this.sponsor.AutoSize = true;
            this.sponsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sponsor.Location = new System.Drawing.Point(419, 494);
            this.sponsor.Name = "sponsor";
            this.sponsor.Size = new System.Drawing.Size(107, 29);
            this.sponsor.TabIndex = 5;
            this.sponsor.Text = "Sponsor";
            // 
            // Menustart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(940, 577);
            this.Controls.Add(this.sponsor);
            this.Controls.Add(this.sponsored);
            this.Controls.Add(this.wyswietl);
            this.Controls.Add(this.zalogujsie);
            this.Controls.Add(this.duzysnake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menustart";
            this.Text = "Snake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label duzysnake;
        private System.Windows.Forms.Button zalogujsie;
        private System.Windows.Forms.Button wyswietl;
        private System.Windows.Forms.Label sponsored;
        private System.Windows.Forms.Label sponsor;
    }
}

