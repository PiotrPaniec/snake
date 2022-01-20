namespace Snake
{
    partial class Rankingi
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
            this.wstecz = new System.Windows.Forms.Button();
            this.ranking = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // wstecz
            // 
            this.wstecz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wstecz.Location = new System.Drawing.Point(12, 12);
            this.wstecz.Name = "wstecz";
            this.wstecz.Size = new System.Drawing.Size(75, 38);
            this.wstecz.TabIndex = 8;
            this.wstecz.Text = "<--";
            this.wstecz.UseVisualStyleBackColor = true;
            this.wstecz.Click += new System.EventHandler(this.wsteczClick);
            // 
            // ranking
            // 
            this.ranking.FormattingEnabled = true;
            this.ranking.ItemHeight = 16;
            this.ranking.Location = new System.Drawing.Point(12, 56);
            this.ranking.Name = "ranking";
            this.ranking.Size = new System.Drawing.Size(731, 500);
            this.ranking.TabIndex = 9;
            // 
            // Rankingi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(776, 576);
            this.Controls.Add(this.ranking);
            this.Controls.Add(this.wstecz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Rankingi";
            this.Text = "Rankingi ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button wstecz;
        public System.Windows.Forms.ListBox ranking;
    }
}