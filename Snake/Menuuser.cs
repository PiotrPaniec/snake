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
    public partial class Menuuser : Form
    {
        public Menuuser()
        {
            InitializeComponent();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menustart form1 = new Menustart();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zglaszanieuser form6 = new Zglaszanieuser();
            form6.Show();
            form6.label2.Text = this.label2.Text;
            form6.label3.Text = this.label3.Text;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gra form10 = new Gra();
            form10.Show();
            form10.label1.Text = this.label2.Text;
            form10.label3.Text = this.label3.Text;
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zarzadzanieuser form12 = new Zarzadzanieuser();
            form12.Show();
            form12.label2.Text = this.label2.Text;
            form12.label3.Text = this.label3.Text;
            this.Hide();
        }
    }
}
