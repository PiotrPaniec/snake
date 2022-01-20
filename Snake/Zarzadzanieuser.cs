﻿using System;
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
    public partial class Zarzadzanieuser : Form
    {
        public Zarzadzanieuser()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menuuser form5 = new Menuuser();
            form5.Show();
            form5.uzytkownikmenu.Text = this.login.Text;
            form5.rekorduser.Text = this.rekordint.Text;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oldhaslowpisz.Text.Length != 0) {
                odczyt uzytkownik = new odczyt(login.Text, oldhaslowpisz.Text);
                if (uzytkownik.sprawdzanie() == true)
                {
                    if (newhaslowpisz.Text == newhaslopowtorz.Text)
                    {
                        uzytkownik.zamianahaslalubloginu(oldhaslowpisz.Text, newhaslopowtorz.Text, newloginwpisz.Text);
                        login.Text = uzytkownik.getlogin();
                        komunikat.Text = "Wprowadzono zmiany ";
                    }
                    else
                    {
                        komunikat.Text = "Wprowadzono dwa rózne hasła ";
                    }
                }
                else 
                {
                    komunikat.Text = "Wpisałeś złe hasło ";
                }

             }
            else
            {
                komunikat.Text = "Nie wpisałeś starego hasła";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odczyt uzytkownik = new odczyt(login.Text, oldhaslowpisz.Text);
            if (uzytkownik.sprawdzanie() == true)
            {
                uzytkownik.usuwanie();
                Form1 ankieta1 = new Form1();
                ankieta1.Show();
                this.Hide();
            }
            else
            {
                komunikat.Text = "Wpisałeś złe hasło ";
            }

        }
    }
}
