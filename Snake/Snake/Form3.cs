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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    if (textBox2.Text.Length != 0)
                    {
                        odczyt uzytwkowniknowy = new odczyt(textBox1.Text, textBox2.Text);
                        uzytwkowniknowy.rejestracja();
                        Form5 form5 = new Form5();
                        form5.Show();
                        this.Hide();
                    }
                    else
                    {
                        label4.Text = "nie podałęś hasla";
                    }
                }
                else
                {
                    label4.Text = "podałeś dwa różne hasła";
                }
            }
            else
            {
                label4.Text = "nie podałęś loginu";
            }
        }
    }
}
