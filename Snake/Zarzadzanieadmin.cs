using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class Zarzadzanieadmin : Form
    {
        public Zarzadzanieadmin()
        {
            InitializeComponent();
        }

        private void zamianaClick(object sender, EventArgs e)
        {
            odczyt uzytkownikdozmiany = new odczyt(loginzmienianego.Text, "haslo");
            uzytkownikdozmiany.zamianaadmin(nowehaslowpisz.Text, nowyloginwpisz.Text);
            komunikat.Text = "Wprowadzono zmiany ";
        }

        private void wsteczClick(object sender, EventArgs e)
        {
            Menuadmin form7 = new Menuadmin();
            form7.Show();
            this.Hide();
        }

        private void usuwanieClick(object sender, EventArgs e)
        {
            odczyt uzytkownikdozmiany = new odczyt(loginusuwanego.Text, "haslo");
            uzytkownikdozmiany.usuwanie();
            komunikat.Text = "Usunieto uzytkownika ";
        }
    }
}
