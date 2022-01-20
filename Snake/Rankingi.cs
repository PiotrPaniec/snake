using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class Rankingi : Form
    {
        public Rankingi()
        {
            InitializeComponent();
        }

        private void wsteczClick(object sender, EventArgs e)
        {
            Menustart form1 = new Menustart();
            form1.Show();
            this.Hide();
        }
    }
}
