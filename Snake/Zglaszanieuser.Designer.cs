namespace Snake
{
    partial class Zglaszanieuser
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
            this.zglaszanie = new System.Windows.Forms.RichTextBox();
            this.wyslij = new System.Windows.Forms.Button();
            this.wstecz = new System.Windows.Forms.Button();
            this.rekord = new System.Windows.Forms.Label();
            this.uzytkownik = new System.Windows.Forms.Label();
            this.rekordint = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.komunikat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zglaszanie
            // 
            this.zglaszanie.Location = new System.Drawing.Point(12, 66);
            this.zglaszanie.Name = "zglaszanie";
            this.zglaszanie.Size = new System.Drawing.Size(776, 319);
            this.zglaszanie.TabIndex = 0;
            this.zglaszanie.Text = "";
            // 
            // wyslij
            // 
            this.wyslij.Location = new System.Drawing.Point(653, 391);
            this.wyslij.Name = "wyslij";
            this.wyslij.Size = new System.Drawing.Size(135, 30);
            this.wyslij.TabIndex = 1;
            this.wyslij.Text = "Wyślij";
            this.wyslij.UseVisualStyleBackColor = true;
            this.wyslij.Click += new System.EventHandler(this.wyslij_zazalenieClick);
            // 
            // wstecz
            // 
            this.wstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wstecz.Location = new System.Drawing.Point(12, 11);
            this.wstecz.Name = "wstecz";
            this.wstecz.Size = new System.Drawing.Size(75, 38);
            this.wstecz.TabIndex = 8;
            this.wstecz.Text = "<--";
            this.wstecz.UseVisualStyleBackColor = true;
            this.wstecz.Click += new System.EventHandler(this.wsteczClick);
            // 
            // rekord
            // 
            this.rekord.AutoSize = true;
            this.rekord.Location = new System.Drawing.Point(623, 36);
            this.rekord.Name = "rekord";
            this.rekord.Size = new System.Drawing.Size(53, 17);
            this.rekord.TabIndex = 12;
            this.rekord.Text = "rekord:";
            // 
            // uzytkownik
            // 
            this.uzytkownik.AutoSize = true;
            this.uzytkownik.Location = new System.Drawing.Point(596, 9);
            this.uzytkownik.Name = "uzytkownik";
            this.uzytkownik.Size = new System.Drawing.Size(80, 17);
            this.uzytkownik.TabIndex = 11;
            this.uzytkownik.Text = "użytkownik:";
            // 
            // rekordint
            // 
            this.rekordint.AutoSize = true;
            this.rekordint.Location = new System.Drawing.Point(682, 36);
            this.rekordint.Name = "rekordint";
            this.rekordint.Size = new System.Drawing.Size(46, 17);
            this.rekordint.TabIndex = 10;
            this.rekordint.Text = "label3";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(682, 9);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(46, 17);
            this.login.TabIndex = 9;
            this.login.Text = "label2";
            // 
            // komunikat
            // 
            this.komunikat.AutoSize = true;
            this.komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komunikat.ForeColor = System.Drawing.Color.Red;
            this.komunikat.Location = new System.Drawing.Point(275, 396);
            this.komunikat.Name = "komunikat";
            this.komunikat.Size = new System.Drawing.Size(0, 25);
            this.komunikat.TabIndex = 13;
            // 
            // Zglaszanieuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.komunikat);
            this.Controls.Add(this.rekord);
            this.Controls.Add(this.uzytkownik);
            this.Controls.Add(this.rekordint);
            this.Controls.Add(this.login);
            this.Controls.Add(this.wstecz);
            this.Controls.Add(this.wyslij);
            this.Controls.Add(this.zglaszanie);
            this.Name = "Zglaszanieuser";
            this.Text = "Zgłaszanei błędu ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox zglaszanie;
        private System.Windows.Forms.Button wyslij;
        private System.Windows.Forms.Button wstecz;
        private System.Windows.Forms.Label rekord;
        private System.Windows.Forms.Label uzytkownik;
        public System.Windows.Forms.Label rekordint;
        public System.Windows.Forms.Label login;
        private System.Windows.Forms.Label komunikat;
    }
}