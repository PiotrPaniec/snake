namespace Snake
{
    partial class Form1
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
            this.zapytanie = new System.Windows.Forms.Label();
            this.oknodowpisaniaankiety = new System.Windows.Forms.RichTextBox();
            this.wysylanieankiety = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zapytanie
            // 
            this.zapytanie.AutoSize = true;
            this.zapytanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapytanie.Location = new System.Drawing.Point(13, 13);
            this.zapytanie.Name = "zapytanie";
            this.zapytanie.Size = new System.Drawing.Size(216, 25);
            this.zapytanie.TabIndex = 0;
            this.zapytanie.Text = "czemu usuwasz konto?";
            // 
            // oknodowpisaniaankiety
            // 
            this.oknodowpisaniaankiety.Location = new System.Drawing.Point(18, 77);
            this.oknodowpisaniaankiety.Name = "oknodowpisaniaankiety";
            this.oknodowpisaniaankiety.Size = new System.Drawing.Size(770, 317);
            this.oknodowpisaniaankiety.TabIndex = 2;
            this.oknodowpisaniaankiety.Text = "";
            // 
            // wysylanieankiety
            // 
            this.wysylanieankiety.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wysylanieankiety.Location = new System.Drawing.Point(713, 403);
            this.wysylanieankiety.Name = "wysylanieankiety";
            this.wysylanieankiety.Size = new System.Drawing.Size(75, 35);
            this.wysylanieankiety.TabIndex = 3;
            this.wysylanieankiety.Text = "Wyślij";
            this.wysylanieankiety.UseVisualStyleBackColor = true;
            this.wysylanieankiety.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wysylanieankiety);
            this.Controls.Add(this.oknodowpisaniaankiety);
            this.Controls.Add(this.zapytanie);
            this.Name = "Form1";
            this.Text = "Ankieta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zapytanie;
        private System.Windows.Forms.RichTextBox oknodowpisaniaankiety;
        private System.Windows.Forms.Button wysylanieankiety;
    }
}