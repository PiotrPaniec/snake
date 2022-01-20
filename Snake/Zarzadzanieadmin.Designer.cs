namespace Snake
{
    partial class Zarzadzanieadmin
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
            this.usunbutton = new System.Windows.Forms.Button();
            this.loginusuwanego = new System.Windows.Forms.TextBox();
            this.nowehaslolabel = new System.Windows.Forms.Label();
            this.nowehaslo = new System.Windows.Forms.Label();
            this.nowyloginwpisz = new System.Windows.Forms.TextBox();
            this.nowehaslowpisz = new System.Windows.Forms.TextBox();
            this.zmienbutton = new System.Windows.Forms.Button();
            this.loginzmienianego = new System.Windows.Forms.TextBox();
            this.wstecz = new System.Windows.Forms.Button();
            this.komunikat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usunbutton
            // 
            this.usunbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunbutton.Location = new System.Drawing.Point(21, 70);
            this.usunbutton.Name = "usunbutton";
            this.usunbutton.Size = new System.Drawing.Size(347, 41);
            this.usunbutton.TabIndex = 0;
            this.usunbutton.Text = "Usuń użytkownika o loginie";
            this.usunbutton.UseVisualStyleBackColor = true;
            this.usunbutton.Click += new System.EventHandler(this.usuwanieClick);
            // 
            // loginusuwanego
            // 
            this.loginusuwanego.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginusuwanego.Location = new System.Drawing.Point(394, 74);
            this.loginusuwanego.Name = "loginusuwanego";
            this.loginusuwanego.Size = new System.Drawing.Size(372, 32);
            this.loginusuwanego.TabIndex = 1;
            // 
            // nowehaslolabel
            // 
            this.nowehaslolabel.AutoSize = true;
            this.nowehaslolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowehaslolabel.Location = new System.Drawing.Point(242, 316);
            this.nowehaslolabel.Name = "nowehaslolabel";
            this.nowehaslolabel.Size = new System.Drawing.Size(126, 26);
            this.nowehaslolabel.TabIndex = 2;
            this.nowehaslolabel.Text = "Nowy Login";
            // 
            // nowehaslo
            // 
            this.nowehaslo.AutoSize = true;
            this.nowehaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowehaslo.Location = new System.Drawing.Point(236, 253);
            this.nowehaslo.Name = "nowehaslo";
            this.nowehaslo.Size = new System.Drawing.Size(132, 26);
            this.nowehaslo.TabIndex = 3;
            this.nowehaslo.Text = "Nowe hasło ";
            // 
            // nowyloginwpisz
            // 
            this.nowyloginwpisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowyloginwpisz.Location = new System.Drawing.Point(394, 316);
            this.nowyloginwpisz.Name = "nowyloginwpisz";
            this.nowyloginwpisz.Size = new System.Drawing.Size(372, 32);
            this.nowyloginwpisz.TabIndex = 4;
            // 
            // nowehaslowpisz
            // 
            this.nowehaslowpisz.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowehaslowpisz.Location = new System.Drawing.Point(394, 253);
            this.nowehaslowpisz.Name = "nowehaslowpisz";
            this.nowehaslowpisz.Size = new System.Drawing.Size(372, 32);
            this.nowehaslowpisz.TabIndex = 5;
            // 
            // zmienbutton
            // 
            this.zmienbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zmienbutton.Location = new System.Drawing.Point(21, 139);
            this.zmienbutton.Name = "zmienbutton";
            this.zmienbutton.Size = new System.Drawing.Size(347, 78);
            this.zmienbutton.TabIndex = 6;
            this.zmienbutton.Text = "Zmień hasło lub login użytkownika o loginie";
            this.zmienbutton.UseVisualStyleBackColor = true;
            this.zmienbutton.Click += new System.EventHandler(this.zamianaClick);
            // 
            // loginzmienianego
            // 
            this.loginzmienianego.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginzmienianego.Location = new System.Drawing.Point(394, 162);
            this.loginzmienianego.Name = "loginzmienianego";
            this.loginzmienianego.Size = new System.Drawing.Size(372, 32);
            this.loginzmienianego.TabIndex = 7;
            // 
            // wstecz
            // 
            this.wstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wstecz.Location = new System.Drawing.Point(21, 12);
            this.wstecz.Name = "wstecz";
            this.wstecz.Size = new System.Drawing.Size(75, 38);
            this.wstecz.TabIndex = 8;
            this.wstecz.Text = "<--";
            this.wstecz.UseVisualStyleBackColor = true;
            this.wstecz.Click += new System.EventHandler(this.wsteczClick);
            // 
            // komunikat
            // 
            this.komunikat.AutoSize = true;
            this.komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komunikat.ForeColor = System.Drawing.Color.Red;
            this.komunikat.Location = new System.Drawing.Point(293, 380);
            this.komunikat.Name = "komunikat";
            this.komunikat.Size = new System.Drawing.Size(0, 25);
            this.komunikat.TabIndex = 9;
            // 
            // Zarzadzanieadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.komunikat);
            this.Controls.Add(this.wstecz);
            this.Controls.Add(this.loginzmienianego);
            this.Controls.Add(this.zmienbutton);
            this.Controls.Add(this.nowehaslowpisz);
            this.Controls.Add(this.nowyloginwpisz);
            this.Controls.Add(this.nowehaslo);
            this.Controls.Add(this.nowehaslolabel);
            this.Controls.Add(this.loginusuwanego);
            this.Controls.Add(this.usunbutton);
            this.Name = "Zarzadzanieadmin";
            this.Text = "Zarządzanie kontami ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button usunbutton;
        private System.Windows.Forms.TextBox loginusuwanego;
        private System.Windows.Forms.Label nowehaslolabel;
        private System.Windows.Forms.Label nowehaslo;
        private System.Windows.Forms.TextBox nowyloginwpisz;
        private System.Windows.Forms.TextBox nowehaslowpisz;
        private System.Windows.Forms.Button zmienbutton;
        private System.Windows.Forms.TextBox loginzmienianego;
        private System.Windows.Forms.Button wstecz;
        private System.Windows.Forms.Label komunikat;
    }
}