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
    public partial class Gameover : Form
    {
        public Gameover()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gra form10 = new Gra();
            form10.Show();
            form10.label1.Text = this.logingameover.Text;
            form10.label3.Text = this.rekordgameover.Text;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuuser form5 = new Menuuser();
            form5.uzytkownikmenu.Text = this.logingameover.Text;
            form5.rekorduser.Text = this.rekordgameover.Text;
            form5.Show();
            this.Hide();
        }


    }
}
