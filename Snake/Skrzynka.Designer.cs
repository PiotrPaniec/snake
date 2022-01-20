namespace Snake
{
    partial class Skrzynka
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
            this.Domenu = new System.Windows.Forms.Button();
            this.wiadomosci = new System.Windows.Forms.RichTextBox();
            this.dalej = new System.Windows.Forms.Button();
            this.wstecz = new System.Windows.Forms.Button();
            this.usun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Domenu
            // 
            this.Domenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Domenu.Location = new System.Drawing.Point(23, 12);
            this.Domenu.Name = "Domenu";
            this.Domenu.Size = new System.Drawing.Size(75, 38);
            this.Domenu.TabIndex = 8;
            this.Domenu.Text = "<--";
            this.Domenu.UseVisualStyleBackColor = true;
            this.Domenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // wiadomosci
            // 
            this.wiadomosci.Location = new System.Drawing.Point(23, 72);
            this.wiadomosci.Name = "wiadomosci";
            this.wiadomosci.Size = new System.Drawing.Size(741, 356);
            this.wiadomosci.TabIndex = 9;
            this.wiadomosci.Text = "";
            // 
            // dalej
            // 
            this.dalej.Location = new System.Drawing.Point(659, 450);
            this.dalej.Name = "dalej";
            this.dalej.Size = new System.Drawing.Size(75, 29);
            this.dalej.TabIndex = 10;
            this.dalej.Text = "Dalej";
            this.dalej.UseVisualStyleBackColor = true;
            this.dalej.Click += new System.EventHandler(this.button1_Click);
            // 
            // wstecz
            // 
            this.wstecz.Location = new System.Drawing.Point(497, 450);
            this.wstecz.Name = "wstecz";
            this.wstecz.Size = new System.Drawing.Size(75, 29);
            this.wstecz.TabIndex = 11;
            this.wstecz.Text = "Wstecz";
            this.wstecz.UseVisualStyleBackColor = true;
            this.wstecz.Click += new System.EventHandler(this.button3_Click);
            // 
            // usun
            // 
            this.usun.Location = new System.Drawing.Point(578, 450);
            this.usun.Name = "usun";
            this.usun.Size = new System.Drawing.Size(75, 29);
            this.usun.TabIndex = 12;
            this.usun.Text = "Usuń";
            this.usun.UseVisualStyleBackColor = true;
            this.usun.Click += new System.EventHandler(this.button4_Click);
            // 
            // Skrzynka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.usun);
            this.Controls.Add(this.wstecz);
            this.Controls.Add(this.dalej);
            this.Controls.Add(this.wiadomosci);
            this.Controls.Add(this.Domenu);
            this.Name = "Skrzynka";
            this.Text = "Skrzynka odbiorcza";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Domenu;
        public System.Windows.Forms.RichTextBox wiadomosci;
        private System.Windows.Forms.Button dalej;
        private System.Windows.Forms.Button wstecz;
        private System.Windows.Forms.Button usun;
    }
}