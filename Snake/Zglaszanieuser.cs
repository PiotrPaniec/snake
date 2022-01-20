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
    public partial class Zglaszanieuser : Form
    {
        public Zglaszanieuser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuuser form5 = new Menuuser();
            form5.Show();
            form5.uzytkownikmenu.Text = this.login.Text;
            form5.rekorduser.Text = this.rekordint.Text;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zazalenia zazalenie = new zazalenia(login.Text, zglaszanie.Text);
            zazalenie.dodajwiadomosc();
            komunikat.Text = "Wiadomość została wysłana";
        }
    }
}
