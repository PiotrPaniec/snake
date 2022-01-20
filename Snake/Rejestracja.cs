﻿using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        private void wsteczClick(object sender, EventArgs e)
        {
            Logowanie form2 = new Logowanie();
            form2.Show();
            this.Hide();
        }

        private void zarejestruj_sieClick(object sender, EventArgs e)
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
