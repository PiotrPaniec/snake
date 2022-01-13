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
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logowanie form2 = new Logowanie();
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
                       bool wynik= uzytwkowniknowy.rejestracja();
                        if (wynik == false)
                        {
                            Menuuser form5 = new Menuuser();
                            form5.label2.Text = textBox1.Text;
                            form5.label3.Text = "0";
                            form5.Show();
                            this.Hide();
                        }
                        else
                        {
                            label5.Text = "nazwa uzytkownika jest zajeta";
                        }
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
