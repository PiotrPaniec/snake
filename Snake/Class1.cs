using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
   public  class ankietaklasa
    {
        string tresc;
        public ankietaklasa(string tresc1)
        {
            tresc = tresc1;
        }
        public void dodajwiadomosc()
        {
            string path = @"ankieta.txt";
            StreamWriter sw;
            sw = new StreamWriter(path, true);
            sw.WriteLine("|" +":\n" + tresc + "\n" + "\n");
            sw.Close();
        }
    }
}
