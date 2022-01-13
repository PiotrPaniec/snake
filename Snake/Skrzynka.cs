using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Skrzynka : Form
    {
        int i = 0;
        public Skrzynka()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuadmin form7 = new Menuadmin();
            form7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i = 1;

        
            zazalenia admin = new zazalenia("admin1");
            string[] tablicazgloszenia = admin.wyswietlanie();
            if (i < ((tablicazgloszenia.Length)-1))
            {
                i++;
               

                richTextBox1.Text = tablicazgloszenia[i];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                zazalenia admin = new zazalenia("admin1");
                string[] tablicazgloszenia = admin.wyswietlanie();
               
                richTextBox1.Text = tablicazgloszenia[i];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zazalenia admin = new zazalenia("admin1");
           
            string[] tablicazgloszenia = admin.usun(i);
            if (i < ((tablicazgloszenia.Length) - 1))
            {
                i++;


                richTextBox1.Text = tablicazgloszenia[i];
            }
            else
            {
                i--;


                richTextBox1.Text = tablicazgloszenia[i];
            }
        }
    }
}
