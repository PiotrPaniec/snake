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
    public partial class Zarzadzanieadmin : Form
    {
        public Zarzadzanieadmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odczyt uzytkownikdozmiany = new odczyt(textBox4.Text, "haslo");
            uzytkownikdozmiany.zamianaadmin(textBox3.Text, textBox2.Text);
            label3.Text = "Wprowadzono zmiany ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menuadmin form7 = new Menuadmin();
            form7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odczyt uzytkownikdozmiany = new odczyt(textBox1.Text, "haslo");
            uzytkownikdozmiany.usuwanie();
            label3.Text = "Usunieto uzytkownika ";
        }
    }
}
