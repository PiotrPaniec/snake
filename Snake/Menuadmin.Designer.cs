namespace Snake
{
    partial class Menuadmin
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
            this.Duzysnake = new System.Windows.Forms.Label();
            this.zarzadzanie = new System.Windows.Forms.Button();
            this.skrzynka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Duzysnake
            // 
            this.Duzysnake.AutoSize = true;
            this.Duzysnake.BackColor = System.Drawing.Color.Lime;
            this.Duzysnake.Font = new System.Drawing.Font("Wide Latin", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Duzysnake.Location = new System.Drawing.Point(249, 78);
            this.Duzysnake.Name = "Duzysnake";
            this.Duzysnake.Size = new System.Drawing.Size(301, 61);
            this.Duzysnake.TabIndex = 2;
            this.Duzysnake.Text = "Snake";
            // 
            // zarzadzanie
            // 
            this.zarzadzanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zarzadzanie.Location = new System.Drawing.Point(306, 178);
            this.zarzadzanie.Name = "zarzadzanie";
            this.zarzadzanie.Size = new System.Drawing.Size(176, 72);
            this.zarzadzanie.TabIndex = 3;
            this.zarzadzanie.Text = "Zarządzaj kontami ";
            this.zarzadzanie.UseVisualStyleBackColor = true;
            this.zarzadzanie.Click += new System.EventHandler(this.button1_Click);
            // 
            // skrzynka
            // 
            this.skrzynka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skrzynka.Location = new System.Drawing.Point(306, 265);
            this.skrzynka.Name = "skrzynka";
            this.skrzynka.Size = new System.Drawing.Size(176, 72);
            this.skrzynka.TabIndex = 4;
            this.skrzynka.Text = "Skrzynka odbiorcza";
            this.skrzynka.UseVisualStyleBackColor = true;
            this.skrzynka.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menuadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.skrzynka);
            this.Controls.Add(this.zarzadzanie);
            this.Controls.Add(this.Duzysnake);
            this.Name = "Menuadmin";
            this.Text = "Menu Administratora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Duzysnake;
        private System.Windows.Forms.Button zarzadzanie;
        private System.Windows.Forms.Button skrzynka;
    }
}