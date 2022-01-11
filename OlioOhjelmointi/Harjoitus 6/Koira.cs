using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_6
{
    // Koira luokka joka on Eläin luokan aliluokka. Eläin luokka on Abstrakti luokka, joten "Ääntele()" toiminto ON PAKKO toteuttaa
    class Koira : Eläin 
    {
        public string Rotu; // Koiran rotu
        public int Ikä; // Koiran ikä

        // instanssi laskuri
        public static int instanssit = 0;

        // Koiran konstruktori
        public Koira(string rotu, int ikä)
        {
            Rotu = rotu;
            Ikä = ikä;

            instanssit++; // Aina kuin koira luodaan lisätään instansseihin 1 lisää
        }

        // Kutsumalla "Koira.KuinkaMonta()" saadaan tietoon kuinka monta Koiraa on olemassa
        public static new void KuinkaMonta() // new -avain sanalla korvataan Eläin luokan "KuinkaMonta" toiminto kokonaan
        {
            Console.WriteLine("Koiria on elossa: " + instanssit);
        }

        // Yliluetaan Eläimen "Ääntele" abstrakti luokka
        public override void Ääntele()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
