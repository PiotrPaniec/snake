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
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logowanie form2 = new Logowanie();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wpiszlogin.Text.Length != 0)
            {
                if (wpiszhaslo.Text == wpiszhasloznow.Text)
                {
                    if (wpiszhaslo.Text.Length != 0)
                    {
                        odczyt uzytwkowniknowy = new odczyt(wpiszlogin.Text, wpiszhaslo.Text);
                       bool wynik= uzytwkowniknowy.rejestracja();
                        if (wynik == false)
                        {
                            Menuuser form5 = new Menuuser();
                            form5.uzytkownikmenu.Text = wpiszlogin.Text;
                            form5.rekorduser.Text = "0";
                            form5.Show();
                            this.Hide();
                        }
                        else
                        {
                            zajety.Text = "nazwa uzytkownika jest zajeta";
                        }
                    }
                    else
                    {
                        blad.Text = "nie podałęś hasla";
                    }
                }
                else
                {
                    blad.Text = "podałeś dwa różne hasła";
                }
            }
            else
            {
                blad.Text = "nie podałęś loginu";
            }
        }
    }
}
