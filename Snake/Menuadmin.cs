using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class Menuadmin : Form
    {
        public Menuadmin()
        {
            InitializeComponent();
        }

        private void zarzadzanieClick(object sender, EventArgs e)
        {
            Zarzadzanieadmin form8 = new Zarzadzanieadmin();
            form8.Show();
            this.Hide();
        }

        private void skrzynkaClick(object sender, EventArgs e)
        {

            Skrzynka form9 = new Skrzynka();
            zazalenia admin = new zazalenia("admin1");
            string[] tablicazgloszenia = admin.wyswietlanie();
            int dlugosc = tablicazgloszenia.Length;
           
                form9.wiadomosci.Text=tablicazgloszenia[0];
            
            form9.Show();
            this.Hide();
        }

        private void Menuadmin_Load(object sender, EventArgs e)
        {

        }
    }
}
