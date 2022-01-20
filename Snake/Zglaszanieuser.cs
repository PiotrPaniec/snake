using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class Zglaszanieuser : Form
    {
        public Zglaszanieuser()
        {
            InitializeComponent();
        }

        private void wsteczClick(object sender, EventArgs e)
        {
            Menuuser form5 = new Menuuser();
            form5.Show();
            form5.uzytkownikmenu.Text = this.login.Text;
            form5.rekorduser.Text = this.rekordint.Text;
            this.Hide();
        }

        private void wyslij_zazalenieClick(object sender, EventArgs e)
        {
            zazalenia zazalenie = new zazalenia(login.Text, zglaszanie.Text);
            zazalenie.dodajwiadomosc();
            komunikat.Text = "Wiadomość została wysłana";
        }
    }
}
