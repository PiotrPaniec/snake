using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Snake
{
   public class odczyt
    {
        string login;
        string haslo;
        int rekord;

       public odczyt(string login1, string haslo1)
        {
            login = login1;
            haslo = haslo1;

        }

       public bool sprawdzanie()
      {
            bool wynik = false;
            string path = @"loginy.txt";
            StreamReader sr = File.OpenText(path);
            string s = "";
            while((s = sr.ReadLine()) != null)
            {
                string[] words = s.Split(':');
                if (words[0] == login&&words[1]==haslo)
                {
                    wynik = true;
                }
            }



            sr.Close();
            return wynik;
      }
        public void rejestracja()
        {
            string path = @"loginy.txt";
            StreamWriter sw;
            sw = new StreamWriter(path, true);
            rekord = 0;
            sw.WriteLine(login + ":" + haslo + ":" + rekord);
            sw.Close();

        }
        public void zamianarekordku()
        {

        }

    }
}
