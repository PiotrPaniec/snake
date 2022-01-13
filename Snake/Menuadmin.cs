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
    public partial class Menuadmin : Form
    {
        public Menuadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zarzadzanieadmin form8 = new Zarzadzanieadmin();
            form8.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Skrzynka form9 = new Skrzynka();
            zazalenia admin = new zazalenia("admin1");
            string[] tablicazgloszenia = admin.wyswietlanie();
            int dlugosc = tablicazgloszenia.Length;
           
                form9.richTextBox1.Text=tablicazgloszenia[0];
            
            form9.Show();
            this.Hide();
        }
    }
}
