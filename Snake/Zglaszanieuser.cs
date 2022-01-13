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
    public partial class Zglaszanieuser : Form
    {
        public Zglaszanieuser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuuser form5 = new Menuuser();
            form5.Show();
            form5.label2.Text = this.label2.Text;
            form5.label3.Text = this.label3.Text;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zazalenia zazalenie = new zazalenia(label2.Text, richTextBox1.Text);
            zazalenie.dodajwiadomosc();
            label1.Text = "Wiadomość została wysłana";
        }
    }
}
