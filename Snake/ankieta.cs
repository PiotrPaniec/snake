using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wyslij_ankieteClick(object sender, EventArgs e)
        {
            ankietaklasa ankieta = new ankietaklasa(oknodowpisaniaankiety.Text);
            ankieta.dodajwiadomosc();
            Menustart menu1 = new Menustart();
            menu1.Show();
            this.Hide();
        }
    }
}
