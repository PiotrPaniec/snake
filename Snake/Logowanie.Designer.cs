namespace Snake
{
    partial class Logowanie
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
            this.Login = new System.Windows.Forms.Label();
            this.wpiszlogin = new System.Windows.Forms.TextBox();
            this.wpiszhaslo = new System.Windows.Forms.TextBox();
            this.Haslo = new System.Windows.Forms.Label();
            this.pytanie = new System.Windows.Forms.Label();
            this.Zarejestruj = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.wstecz = new System.Windows.Forms.Button();
            this.Zalogujsie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Login.Location = new System.Drawing.Point(214, 116);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(82, 29);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login ";
            // 
            // wpiszlogin
            // 
            this.wpiszlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wpiszlogin.Location = new System.Drawing.Point(350, 109);
            this.wpiszlogin.Name = "wpiszlogin";
            this.wpiszlogin.Size = new System.Drawing.Size(343, 36);
            this.wpiszlogin.TabIndex = 1;
            // 
            // wpiszhaslo
            // 
            this.wpiszhaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wpiszhaslo.Location = new System.Drawing.Point(350, 190);
            this.wpiszhaslo.Name = "wpiszhaslo";
            this.wpiszhaslo.Size = new System.Drawing.Size(343, 36);
            this.wpiszhaslo.TabIndex = 2;
            // 
            // Haslo
            // 
            this.Haslo.AutoSize = true;
            this.Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Haslo.Location = new System.Drawing.Point(214, 190);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(85, 29);
            this.Haslo.TabIndex = 3;
            this.Haslo.Text = "Hasło ";
            // 
            // pytanie
            // 
            this.pytanie.AutoSize = true;
            this.pytanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pytanie.Location = new System.Drawing.Point(345, 331);
            this.pytanie.Name = "pytanie";
            this.pytanie.Size = new System.Drawing.Size(157, 25);
            this.pytanie.TabIndex = 4;
            this.pytanie.Text = "Nie masz konta?";
            // 
            // Zarejestruj
            // 
            this.Zarejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zarejestruj.Location = new System.Drawing.Point(350, 359);
            this.Zarejestruj.Name = "Zarejestruj";
            this.Zarejestruj.Size = new System.Drawing.Size(152, 61);
            this.Zarejestruj.TabIndex = 5;
            this.Zarejestruj.Text = "Zarejestruj sie ";
            this.Zarejestruj.UseVisualStyleBackColor = true;
            this.Zarejestruj.Click += new System.EventHandler(this.rejestracjaClick);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Lime;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.ForeColor = System.Drawing.Color.Red;
            this.info.Location = new System.Drawing.Point(214, 286);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 25);
            this.info.TabIndex = 6;
            // 
            // wstecz
            // 
            this.wstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wstecz.Location = new System.Drawing.Point(12, 12);
            this.wstecz.Name = "wstecz";
            this.wstecz.Size = new System.Drawing.Size(75, 38);
            this.wstecz.TabIndex = 7;
            this.wstecz.Text = "<--";
            this.wstecz.UseVisualStyleBackColor = true;
            this.wstecz.Click += new System.EventHandler(this.wsteczClick);
            // 
            // Zalogujsie
            // 
            this.Zalogujsie.Location = new System.Drawing.Point(350, 248);
            this.Zalogujsie.Name = "Zalogujsie";
            this.Zalogujsie.Size = new System.Drawing.Size(115, 35);
            this.Zalogujsie.TabIndex = 8;
            this.Zalogujsie.Text = "Zaloguj sie";
            this.Zalogujsie.UseVisualStyleBackColor = true;
            this.Zalogujsie.Click += new System.EventHandler(this.logowanieClick);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zalogujsie);
            this.Controls.Add(this.wstecz);
            this.Controls.Add(this.info);
            this.Controls.Add(this.Zarejestruj);
            this.Controls.Add(this.pytanie);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.wpiszhaslo);
            this.Controls.Add(this.wpiszlogin);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox wpiszlogin;
        private System.Windows.Forms.TextBox wpiszhaslo;
        private System.Windows.Forms.Label Haslo;
        private System.Windows.Forms.Label pytanie;
        private System.Windows.Forms.Button Zarejestruj;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button wstecz;
        private System.Windows.Forms.Button Zalogujsie;
    }
}