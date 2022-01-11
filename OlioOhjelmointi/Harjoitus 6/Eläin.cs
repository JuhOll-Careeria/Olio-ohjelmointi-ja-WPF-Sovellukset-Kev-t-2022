using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_6
{
    abstract class Eläin // <-- Abstrakti luokka
    {
        private static int instanssit = 0; // instassi laskuri, eli kuinka monta eläintä on olemassa

        public Eläin()
        {
            instanssit++; // aina kun uusi eläin luodaan, lisätään instasseihin yksi lisää
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä on elossa: " + instanssit);
        }

        public abstract void Ääntele(); // Abstrakti metodi, eli pakotetaan aliluokat toteuttamaan tämä toiminto
    }
}
