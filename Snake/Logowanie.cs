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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rejestracja Form3 = new Rejestracja();
            Form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menustart form1 = new Menustart();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odczyt uzytkownik = new odczyt(textBox1.Text, textBox2.Text);

            if (uzytkownik.sprawdzanie())
            {
               // uzytkownik.zamianarekordku(69);
                Menuuser form5 = new Menuuser();
                form5.Show();
                form5.label2.Text = uzytkownik.getlogin();
                form5.label3.Text = uzytkownik.getrekord().ToString();

                this.Hide();
            }
            else if (uzytkownik.sprawdzanieadmin())
            {
                Menuadmin form7 = new Menuadmin();
                form7.Show();
                this.Hide();
            }
            else
            {
                label4.Text = "wpisales zle haslo lub login";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
