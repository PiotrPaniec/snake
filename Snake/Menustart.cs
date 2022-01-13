using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Snake
{
    public partial class Menustart : Form
    {
        public Menustart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logowanie Form2 = new Logowanie();

            Form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"loginy.txt";
            Rankingi form4 = new Rankingi();
            string[] s2 = File.ReadAllLines(path);
            int puste = 0;
            for (int i1 = 0; i1 < s2.Length; i1++)
            {
                if (s2[i1] == "")
                {
                    puste++;
                }
            }
            int[] tab = new int[s2.Length - puste];
            int i = 0;
            while (true)
            {
                string[] words = s2[i].Split(':');
                s2[i] = words[0] + ":" + words[2];
                tab[i] = Int32.Parse(words[2]);
                i++;
                if (i == (s2.Length - puste))
                {
                    break;
                }
            }

            Array.Sort(tab);
            int x = tab[1];


            i = tab.Length - 1;
            x = 0;
            while (true)
            {

                string[] words = s2[x].Split(':');
                if (tab[i] == Int32.Parse(words[1]))
                {

                    form4.listBox1.Items.Add(s2[x]);

                    s2[x] = "nwm:-1";

                    i--;
                    x = 0;

                }
                else
                {
                    x++;
                }
                //form4.listBox1.Items.Add(s2[i]);
                //i--;
                if (i == -1)
                {
                    break;
                }


            }
            //odczyt rankingi = new odczyt("", "");
            //Rankingi form4 = new Rankingi();
            //string[] tab = rankingi.wyswietlanierankingu();
            //int i = tab.Length-1;
            //while (i >= 0)
            //{
            //    form4.listBox1.Items.Add(tab[i]);
            //    i--;
            //}

            form4.Show();
            this.Hide();
        }
    }
}
