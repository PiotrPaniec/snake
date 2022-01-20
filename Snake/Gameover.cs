using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class Gameover : Form
    {
        public Gameover()
        {
            InitializeComponent();
        }

        private void graj_od_nowaClick(object sender, EventArgs e)
        {
            Gra form10 = new Gra();
            form10.Show();
            form10.label1.Text = this.logingameover.Text;
            form10.label3.Text = this.rekordgameover.Text;
            this.Hide();
        }

        private void back_to_menuClick(object sender, EventArgs e)
        {
            Menuuser form5 = new Menuuser();
            form5.uzytkownikmenu.Text = this.logingameover.Text;
            form5.rekorduser.Text = this.rekordgameover.Text;
            form5.Show();
            this.Hide();
        }


    }
}
