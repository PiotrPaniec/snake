using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    public class zazalenia
    {
        string login;
        string tresc;
        public zazalenia(string login1, string tresc1)
        {
            login = login1;
            tresc = tresc1;
        }
        public zazalenia(string login1)
        {
            login = login1;
            
        }
        public void dodajwiadomosc()
        {
            string path = @"zazalenia.txt";
            StreamWriter sw;
            sw = new StreamWriter(path, true);
            sw.WriteLine("|"+login + ":\n" + tresc + "\n" + "\n");
            sw.Close();
        }
        public string[] wyswietlanie()
        {
            string path = @"zazalenia.txt";
            StreamReader sr = File.OpenText(path);
            string s = sr.ReadToEnd();
            string[] words = s.Split('|');
           
            sr.Close();
            return words;
         }
        public string[] usun(int elementdousuwania)
        {
            string path = @"zazalenia.txt";
            StreamReader sr = File.OpenText(path);
            string s = sr.ReadToEnd();
            string[] words = s.Split('|');
            int dlugosc = words.Length;
            sr.Close();
            if ((elementdousuwania - 1) < dlugosc)
            {
                int przechowanie = elementdousuwania;
                for (int i = elementdousuwania; i < (dlugosc-2); i++)
                {
                    words[przechowanie] = words[przechowanie + 1];
                    przechowanie++;
                }
                words[dlugosc-2] = "";
                string tekst = "";
                 for(int i=0; i < dlugosc - 1;i++)
                {
                    if (words[i] != "")
                    {
                        tekst = tekst + words[i] + "|";
                    }
                    
                }
                File.WriteAllText(path, tekst);
                StreamReader sr1 = File.OpenText(path);
                string s1 = sr1.ReadToEnd();
                string[] words1 = s.Split('|');
                sr1.Close();
                return words1;
            }
            else
            {
                words[elementdousuwania] = "";
                string tekst = "";
                for (int i = 0; i < dlugosc - 1; i++)
                {
                    if (words[i] != "")
                    {
                        tekst = tekst + words[i] + "|";
                    }
                }
                File.WriteAllText(path, tekst);
                
                StreamReader sr2 = File.OpenText(path);
                string s2 = sr2.ReadToEnd();
                string[] words2 = s.Split('|');
                sr2.Close();
                return words2;
            }
            
        }
           
        


    }
}
