using System;
using System.Collections.Generic;
using System.Text;

namespace Perintä
{
    class Henkilö
    {
        public string Nimi;
        public int Ikä;
        public int Henkilötunnus;

        private static int Instanssit = 0; // Henkilön staattinen muuttuja, jolla voidaan laskea kuinka monta Henkilöä ollaan luotu

        public Henkilö(string nimi, int ikä, int henkilötunnus)
        {
            Nimi = nimi;
            Ikä = ikä;
            Henkilötunnus = henkilötunnus;

            Instanssit++; // Instanssit = Instanssit + 1;
        }

        // Staattinen metodi, jota kutsumalla voidaan tulostaa konsoliin luotujen henkilöiden määrä
        public static void KuinkaMontaHenkilöä()
        {
            Console.WriteLine("Henkilöitä olemassa: " + Instanssit);
        }

        // virtuaalinen metodi jota voidaan ylilukea (override) aliluokissa
        public virtual void TulostaTiedot()
        {
            Console.WriteLine("Henkilö: " + Nimi + ". Ikä: " + Ikä + ". Henkilötunnus: " + Henkilötunnus);
        }

        public void Syö()
        {
            Console.WriteLine(Nimi + " syö ruokaa...");
        }

        public void Juo()
        {
            Console.WriteLine(Nimi + " juo vettä...");
        }
    }
}
