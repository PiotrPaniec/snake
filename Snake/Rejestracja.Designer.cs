namespace Snake
{
    partial class Rejestracja
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
            this.username = new System.Windows.Forms.Label();
            this.podajhaslo = new System.Windows.Forms.Label();
            this.powtorzhaslo = new System.Windows.Forms.Label();
            this.wpiszlogin = new System.Windows.Forms.TextBox();
            this.wpiszhaslo = new System.Windows.Forms.TextBox();
            this.wpiszhasloznow = new System.Windows.Forms.TextBox();
            this.wstecz = new System.Windows.Forms.Button();
            this.zarejestruj = new System.Windows.Forms.Button();
            this.blad = new System.Windows.Forms.Label();
            this.zajety = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.username.Location = new System.Drawing.Point(103, 137);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(236, 25);
            this.username.TabIndex = 0;
            this.username.Text = "Podaj nazwę użytkownika";
            // 
            // podajhaslo
            // 
            this.podajhaslo.AutoSize = true;
            this.podajhaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.podajhaslo.Location = new System.Drawing.Point(220, 191);
            this.podajhaslo.Name = "podajhaslo";
            this.podajhaslo.Size = new System.Drawing.Size(119, 25);
            this.podajhaslo.TabIndex = 1;
            this.podajhaslo.Text = "Podaj hasło ";
            // 
            // powtorzhaslo
            // 
            this.powtorzhaslo.AutoSize = true;
            this.powtorzhaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powtorzhaslo.Location = new System.Drawing.Point(200, 243);
            this.powtorzhaslo.Name = "powtorzhaslo";
            this.powtorzhaslo.Size = new System.Drawing.Size(139, 25);
            this.powtorzhaslo.TabIndex = 2;
            this.powtorzhaslo.Text = "Powtórz hasło ";
            // 
            // wpiszlogin
            // 
            this.wpiszlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wpiszlogin.Location = new System.Drawing.Point(417, 132);
            this.wpiszlogin.Name = "wpiszlogin";
            this.wpiszlogin.Size = new System.Drawing.Size(182, 30);
            this.wpiszlogin.TabIndex = 3;
            // 
            // wpiszhaslo
            // 
            this.wpiszhaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wpiszhaslo.Location = new System.Drawing.Point(417, 186);
            this.wpiszhaslo.Name = "wpiszhaslo";
            this.wpiszhaslo.Size = new System.Drawing.Size(182, 30);
            this.wpiszhaslo.TabIndex = 4;
            // 
            // wpiszhasloznow
            // 
            this.wpiszhasloznow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wpiszhasloznow.Location = new System.Drawing.Point(417, 238);
            this.wpiszhasloznow.Name = "wpiszhasloznow";
            this.wpiszhasloznow.Size = new System.Drawing.Size(182, 30);
            this.wpiszhasloznow.TabIndex = 5;
            // 
            // wstecz
            // 
            this.wstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wstecz.Location = new System.Drawing.Point(24, 12);
            this.wstecz.Name = "wstecz";
            this.wstecz.Size = new System.Drawing.Size(75, 38);
            this.wstecz.TabIndex = 8;
            this.wstecz.Text = "<--";
            this.wstecz.UseVisualStyleBackColor = true;
            this.wstecz.Click += new System.EventHandler(this.button2_Click);
            // 
            // zarejestruj
            // 
            this.zarejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zarejestruj.Location = new System.Drawing.Point(285, 338);
            this.zarejestruj.Name = "zarejestruj";
            this.zarejestruj.Size = new System.Drawing.Size(221, 53);
            this.zarejestruj.TabIndex = 9;
            this.zarejestruj.Text = "Zarejestruj sie";
            this.zarejestruj.UseVisualStyleBackColor = true;
            this.zarejestruj.Click += new System.EventHandler(this.button1_Click);
            // 
            // blad
            // 
            this.blad.AutoSize = true;
            this.blad.Location = new System.Drawing.Point(371, 292);
            this.blad.Name = "blad";
            this.blad.Size = new System.Drawing.Size(0, 17);
            this.blad.TabIndex = 10;
            // 
            // zajety
            // 
            this.zajety.AutoSize = true;
            this.zajety.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zajety.ForeColor = System.Drawing.Color.Red;
            this.zajety.Location = new System.Drawing.Point(302, 285);
            this.zajety.Name = "zajety";
            this.zajety.Size = new System.Drawing.Size(0, 25);
            this.zajety.TabIndex = 11;
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zajety);
            this.Controls.Add(this.blad);
            this.Controls.Add(this.zarejestruj);
            this.Controls.Add(this.wstecz);
            this.Controls.Add(this.wpiszhasloznow);
            this.Controls.Add(this.wpiszhaslo);
            this.Controls.Add(this.wpiszlogin);
            this.Controls.Add(this.powtorzhaslo);
            this.Controls.Add(this.podajhaslo);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Rejestracja";
            this.Text = "Rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label podajhaslo;
        private System.Windows.Forms.Label powtorzhaslo;
        private System.Windows.Forms.TextBox wpiszlogin;
        private System.Windows.Forms.TextBox wpiszhaslo;
        private System.Windows.Forms.TextBox wpiszhasloznow;
        private System.Windows.Forms.Button wstecz;
        private System.Windows.Forms.Button zarejestruj;
        private System.Windows.Forms.Label blad;
        private System.Windows.Forms.Label zajety;
    }
}