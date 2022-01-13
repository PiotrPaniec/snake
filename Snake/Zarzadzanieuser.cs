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
    public partial class Zarzadzanieuser : Form
    {
        public Zarzadzanieuser()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menuuser form5 = new Menuuser();
            form5.Show();
            form5.label2.Text = this.label2.Text;
            form5.label3.Text = this.label3.Text;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0) {
                odczyt uzytkownik = new odczyt(label2.Text, textBox1.Text);
                if (uzytkownik.sprawdzanie() == true)
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        uzytkownik.zamianahaslalubloginu(textBox1.Text, textBox3.Text, textBox4.Text);
                        label2.Text = uzytkownik.getlogin();
                        label9.Text = "Wprowadzono zmiany ";
                    }
                    else
                    {
                        label9.Text = "Wprowadzono dwa rózne hasła ";
                    }
                }
                else 
                {
                    label9.Text = "Wpisałeś złe hasło ";
                }

             }
            else
            {
                label9.Text = "Nie wpisałeś starego hasła";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odczyt uzytkownik = new odczyt(label2.Text, textBox1.Text);
            if (uzytkownik.sprawdzanie() == true)
            {
                uzytkownik.usuwanie();
                Form1 ankieta1 = new Form1();
                ankieta1.Show();
                this.Hide();
            }
            else
            {
                label9.Text = "Wpisałeś złe hasło ";
            }

        }
    }
}
