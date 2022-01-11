using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_6
{
    // kissa luokka joka on Eläin luokan aliluokka. Eläin luokka on Abstrakti luokka, joten "Ääntele()" toiminto ON PAKKO toteuttaa
    class Kissa : Eläin
    {
        public string Väri; // Kissan väri
        public int Ikä; // Kissan ikä

        // instanssi laskuri
        public static int instanssit = 0;

        // Kissan konstruktori
        public Kissa(string väri, int ikä)
        {
            Väri = väri;
            Ikä = ikä;

            instanssit++; // Aina kuin Kissa luodaan lisätään instansseihin 1 lisää
        }

        // Kutsumalla "Kissa.KuinkaMonta()" saadaan tietoon kuinka monta Kissaa on olemassa
        public static new void KuinkaMonta() // new -avain sanalla korvataan Eläin luokan "KuinkaMonta" toiminto kokonaan
        {
            Console.WriteLine("Kissoja on elossa: " + instanssit);
        }

        // Yliluetaan Eläimen "Ääntele" abstrakti luokka
        public override void Ääntele()
        {
            Console.WriteLine("Meow");
        }
    }
}
