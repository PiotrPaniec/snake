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
       public odczyt(string login2,int rekord1)
        {
            login = login2;
            rekord = rekord1;
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
                    rekord = Int32.Parse(words[2]);
                }
            }



            sr.Close();
            return wynik;
      }
       public bool sprawdzanieadmin()
        {
            bool wynik = false;
            string path = @"admin.txt";
            StreamReader sr = File.OpenText(path);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] words = s.Split(':');
                if (words[0] == login && words[1] == haslo)
                {
                    wynik = true;
                    
                }
            }



            sr.Close();
            return wynik;
        }
       public bool rejestracja()
        {
            string path = @"loginy.txt";

            bool wynik = false;
            StreamReader sr = File.OpenText(path);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] words = s.Split(':');
                if (words[0] == login )
                {
                    wynik = true;
                }
            }
            sr.Close();
            if (wynik == false)
            {
                StreamWriter sw;
                sw = new StreamWriter(path, true);
                rekord = 0;
                sw.WriteLine(login + ":" + haslo + ":" + rekord);
                
                sw.Close();
            }
            return wynik;
        }
       public void zamianarekordku(int nowyrekord)
        {
            string path = @"loginy.txt";
            StreamReader sr0 = File.OpenText(path);
            string s0 = "";
            while ((s0 = sr0.ReadLine()) != null)
            {
                string[] words = s0.Split(':');
                if (words[0] == login)
                {

                    haslo = words[1];
                }
            }
               sr0.Close();
            bool czywiecej=false;
            rekord = nowyrekord;
            
            StreamReader sr = File.OpenText(path);
            int i = 0;
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] words = s.Split(':');
                if (words[0] == login)
                {
                    int oldrekord=Int32.Parse(words[2]);
                  
                    if (nowyrekord > oldrekord)
                    {
                        czywiecej = true;
                    }
                    else
                    {
                        rekord = oldrekord;
                    }
                    break;
                }
                i++;
            }
            sr.Close();
            if (czywiecej == true)
            {
                string[] s2 = File.ReadAllLines(path);
                s2[i] = login + ":" + haslo + ":" + rekord;
                File.WriteAllLines(path, s2);
            }
        }
       public void zamianahaslalubloginu(string oldhaslo,string newhaslo, string newlogin)
        {
            string path = @"loginy.txt";
            StreamReader sr = File.OpenText(path);
            int i = 0;
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] words = s.Split(':');
                if (words[1] == oldhaslo)
                {
                    rekord = Int32.Parse(words[2]);
                    login = words[0];
                    haslo = words[1];
                    break;
                    
                }
                i++;
                
            }
            sr.Close();
            string[] s2 = File.ReadAllLines(path);
            if (newhaslo != null && newlogin != null)
            {
                s2[i] = newlogin + ":" + newhaslo + ":" + rekord;
                login = newlogin;
                haslo =newhaslo;
            }
            else if (newhaslo != null && newlogin == null)
            {
                s2[i] = login + ":" + newhaslo + ":" + rekord;
                haslo = newhaslo;
            }
            else if (newhaslo == null && newlogin != null)
            {
                s2[i] = newlogin + ":" + haslo + ":" + rekord;
                login = newlogin;
            }

            File.WriteAllLines(path, s2);

        }
       public int getrekord()
        {
            return rekord;
        }
       public string getlogin()
        {
            return login;
        }
       public void zamianaadmin(string newhaslo, string newlogin)
        {
            string path = @"loginy.txt";
            StreamReader sr = File.OpenText(path);
            int i = 0;
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] words = s.Split(':');
                if (words[0] == login)
                {
                    rekord = Int32.Parse(words[2]);
                    login = words[0];
                    haslo = words[1];
                    break;

                }
                i++;

            }
            sr.Close();
            string[] s2 = File.ReadAllLines(path);
            if (newhaslo != null && newlogin != null)
            {
                s2[i] = newlogin + ":" + newhaslo + ":" + rekord;
                login = newlogin;
                haslo = newhaslo;
            }
            else if (newhaslo != null && newlogin == null)
            {
                s2[i] = login + ":" + newhaslo + ":" + rekord;
                haslo = newhaslo;
            }
            else if (newhaslo == null && newlogin != null)
            {
                s2[i] = newlogin + ":" + haslo + ":" + rekord;
                login = newlogin;
            }

            File.WriteAllLines(path, s2);

        }
       public void usuwanie()
        {
            string path = @"loginy.txt";
            StreamReader sr = File.OpenText(path);
            int i = 0;
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                string[] words = s.Split(':');
                if (words[0] == login)
                {
                    rekord = Int32.Parse(words[2]);
                    login = words[0];
                    haslo = words[1];
                    break;

                }
                i++;

            }
            sr.Close();
            string[] s2 = File.ReadAllLines(path);
            int dlugosc = s2.Length - 1;
            if (i == dlugosc)
            {
                s2[i] = "";
            }
            else
            {
                while (i < dlugosc)
                {
                    s2[i] = s2[i + 1];
                    i++;
                }
                s2[i] = "";
            }
            string[] s3 = new string[dlugosc];
            i = 0;
            while(i<dlugosc )
            {
                
                s3[i] = s2[i];
                i++;
            }
            File.WriteAllLines(path, s3);
            
        }

    }
}
