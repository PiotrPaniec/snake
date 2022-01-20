namespace Snake
{
    partial class Menuuser
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
            this.bigwonsz = new System.Windows.Forms.Label();
            this.graj = new System.Windows.Forms.Button();
            this.zglaszanie = new System.Windows.Forms.Button();
            this.backtomenu = new System.Windows.Forms.Button();
            this.uzytkownikmenu = new System.Windows.Forms.Label();
            this.rekorduser = new System.Windows.Forms.Label();
            this.uzytkownik = new System.Windows.Forms.Label();
            this.rekord = new System.Windows.Forms.Label();
            this.zarzadzanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bigwonsz
            // 
            this.bigwonsz.AutoSize = true;
            this.bigwonsz.BackColor = System.Drawing.Color.Lime;
            this.bigwonsz.Font = new System.Drawing.Font("Wide Latin", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigwonsz.Location = new System.Drawing.Point(234, 50);
            this.bigwonsz.Name = "bigwonsz";
            this.bigwonsz.Size = new System.Drawing.Size(301, 61);
            this.bigwonsz.TabIndex = 1;
            this.bigwonsz.Text = "Snake";
            // 
            // graj
            // 
            this.graj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.graj.Location = new System.Drawing.Point(304, 133);
            this.graj.Name = "graj";
            this.graj.Size = new System.Drawing.Size(174, 73);
            this.graj.TabIndex = 2;
            this.graj.Text = "GRAJ";
            this.graj.UseVisualStyleBackColor = true;
            this.graj.Click += new System.EventHandler(this.button1_Click);
            // 
            // zglaszanie
            // 
            this.zglaszanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zglaszanie.Location = new System.Drawing.Point(304, 212);
            this.zglaszanie.Name = "zglaszanie";
            this.zglaszanie.Size = new System.Drawing.Size(174, 73);
            this.zglaszanie.TabIndex = 3;
            this.zglaszanie.Text = "Zgłoś problem ";
            this.zglaszanie.UseVisualStyleBackColor = true;
            this.zglaszanie.Click += new System.EventHandler(this.button2_Click);
            // 
            // backtomenu
            // 
            this.backtomenu.Location = new System.Drawing.Point(23, 30);
            this.backtomenu.Name = "backtomenu";
            this.backtomenu.Size = new System.Drawing.Size(128, 23);
            this.backtomenu.TabIndex = 4;
            this.backtomenu.Text = "Wróc do menu głównego ";
            this.backtomenu.UseVisualStyleBackColor = true;
            this.backtomenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // uzytkownikmenu
            // 
            this.uzytkownikmenu.AutoSize = true;
            this.uzytkownikmenu.Location = new System.Drawing.Point(711, 9);
            this.uzytkownikmenu.Name = "uzytkownikmenu";
            this.uzytkownikmenu.Size = new System.Drawing.Size(46, 17);
            this.uzytkownikmenu.TabIndex = 5;
            this.uzytkownikmenu.Text = "label2";
            // 
            // rekorduser
            // 
            this.rekorduser.AutoSize = true;
            this.rekorduser.Location = new System.Drawing.Point(711, 36);
            this.rekorduser.Name = "rekorduser";
            this.rekorduser.Size = new System.Drawing.Size(46, 17);
            this.rekorduser.TabIndex = 6;
            this.rekorduser.Text = "label3";
            // 
            // uzytkownik
            // 
            this.uzytkownik.AutoSize = true;
            this.uzytkownik.Location = new System.Drawing.Point(625, 9);
            this.uzytkownik.Name = "uzytkownik";
            this.uzytkownik.Size = new System.Drawing.Size(80, 17);
            this.uzytkownik.TabIndex = 7;
            this.uzytkownik.Text = "użytkownik:";
            // 
            // rekord
            // 
            this.rekord.AutoSize = true;
            this.rekord.Location = new System.Drawing.Point(652, 36);
            this.rekord.Name = "rekord";
            this.rekord.Size = new System.Drawing.Size(53, 17);
            this.rekord.TabIndex = 8;
            this.rekord.Text = "rekord:";
            // 
            // zarzadzanie
            // 
            this.zarzadzanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zarzadzanie.Location = new System.Drawing.Point(304, 291);
            this.zarzadzanie.Name = "zarzadzanie";
            this.zarzadzanie.Size = new System.Drawing.Size(174, 73);
            this.zarzadzanie.TabIndex = 9;
            this.zarzadzanie.Text = "Zarządzaj kontem ";
            this.zarzadzanie.UseVisualStyleBackColor = true;
            this.zarzadzanie.Click += new System.EventHandler(this.button4_Click);
            // 
            // Menuuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.zarzadzanie);
            this.Controls.Add(this.rekord);
            this.Controls.Add(this.uzytkownik);
            this.Controls.Add(this.rekorduser);
            this.Controls.Add(this.uzytkownikmenu);
            this.Controls.Add(this.backtomenu);
            this.Controls.Add(this.zglaszanie);
            this.Controls.Add(this.graj);
            this.Controls.Add(this.bigwonsz);
            this.Name = "Menuuser";
            this.Text = "Ekran główny ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bigwonsz;
        private System.Windows.Forms.Button graj;
        private System.Windows.Forms.Button zglaszanie;
        private System.Windows.Forms.Button backtomenu;
        public System.Windows.Forms.Label uzytkownikmenu;
        public System.Windows.Forms.Label rekorduser;
        private System.Windows.Forms.Label uzytkownik;
        private System.Windows.Forms.Label rekord;
        private System.Windows.Forms.Button zarzadzanie;
    }
}