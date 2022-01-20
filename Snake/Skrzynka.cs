using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class Skrzynka : Form
    {
        int i = 0;
        public Skrzynka()
        {
            InitializeComponent();
        }

        private void wsteczClick(object sender, EventArgs e)
        {
            Menuadmin form7 = new Menuadmin();
            form7.Show();
            this.Hide();
        }

        private void dalejClick(object sender, EventArgs e)
        {
            //int i = 1;

        
            zazalenia admin = new zazalenia("admin1");
            string[] tablicazgloszenia = admin.wyswietlanie();
            if (i < ((tablicazgloszenia.Length)-1))
            {
                i++;
               

                wiadomosci.Text = tablicazgloszenia[i];
            }
        }

        private void wstecz_wiadomoscClick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                zazalenia admin = new zazalenia("admin1");
                string[] tablicazgloszenia = admin.wyswietlanie();
               
                wiadomosci.Text = tablicazgloszenia[i];
            }
        }

        private void usunClick(object sender, EventArgs e)
        {
            zazalenia admin = new zazalenia("admin1");
           
            string[] tablicazgloszenia = admin.usun(i);
            if (i < ((tablicazgloszenia.Length) - 1))
            {
                i++;


                wiadomosci.Text = tablicazgloszenia[i];
            }
            else
            {
                i--;


                wiadomosci.Text = tablicazgloszenia[i];
            }
        }
    }
}
