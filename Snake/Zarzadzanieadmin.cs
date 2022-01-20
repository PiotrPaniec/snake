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
            odczyt uzytkownikdozmiany = new odczyt(loginzmienianego.Text, "haslo");
            uzytkownikdozmiany.zamianaadmin(nowehaslowpisz.Text, nowyloginwpisz.Text);
            komunikat.Text = "Wprowadzono zmiany ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menuadmin form7 = new Menuadmin();
            form7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odczyt uzytkownikdozmiany = new odczyt(loginusuwanego.Text, "haslo");
            uzytkownikdozmiany.usuwanie();
            komunikat.Text = "Usunieto uzytkownika ";
        }
    }
}
