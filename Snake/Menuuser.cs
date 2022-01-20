using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class Menuuser : Form
    {
        public Menuuser()
        {
            InitializeComponent();
           

        }

        private void back_to_menuClick(object sender, EventArgs e)
        {
            Menustart form1 = new Menustart();
            form1.Show();
            this.Hide();
        }

        private void zglaszanieClick(object sender, EventArgs e)
        {
            Zglaszanieuser form6 = new Zglaszanieuser();
            form6.Show();
            form6.login.Text = this.uzytkownikmenu.Text;
            form6.rekordint.Text = this.rekorduser.Text;
            this.Hide();
        }

        private void granieClick(object sender, EventArgs e)
        {
            Gra form10 = new Gra();
            form10.Show();
            form10.label1.Text = this.uzytkownikmenu.Text;
            form10.label3.Text = this.rekorduser.Text;
            this.Hide();
        }

        

        private void zarzadznie_userClick(object sender, EventArgs e)
        {
            Zarzadzanieuser form12 = new Zarzadzanieuser();
            form12.Show();
            form12.login.Text = this.uzytkownikmenu.Text;
            form12.rekordint.Text = this.rekorduser.Text;
            this.Hide();
        }
    }
}
