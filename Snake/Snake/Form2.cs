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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odczyt uzytkownik = new odczyt(textBox1.Text, textBox2.Text);
            if (uzytkownik.sprawdzanie())
            {
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }
            else if (textBox1.Text == "admin1" && textBox2.Text == "haslo1")
            {
                Form7 form7 = new Form7();
                form7.Show();
                this.Hide();
            }
            else
            {
                label4.Text = "wpisales zle haslo";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
