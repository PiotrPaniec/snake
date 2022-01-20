using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void rejestracjaClick(object sender, EventArgs e)
        {
            Rejestracja Form3 = new Rejestracja();
            Form3.Show();
            this.Hide();
        }

        private void wsteczClick(object sender, EventArgs e)
        {
            Menustart form1 = new Menustart();
            form1.Show();
            this.Hide();
        }

        private void logowanieClick(object sender, EventArgs e)
        {
            odczyt uzytkownik = new odczyt(wpiszlogin.Text, wpiszhaslo.Text);

            if (uzytkownik.sprawdzanie())
            {
               // uzytkownik.zamianarekordku(69);
                Menuuser form5 = new Menuuser();
                form5.Show();
                form5.uzytkownikmenu.Text = uzytkownik.getlogin();
                form5.rekorduser.Text = uzytkownik.getrekord().ToString();

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
                info.Text = "wpisales zle haslo lub login";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
