using System;
using System.Collections.Generic;
using System.Text;

namespace Perintä
{
    // Henkilö yliluokka
    class Henkilö
    {
        public string Nimi; //Henkilön nimi
        public int Ikä; // Henkilön Ikä
        public int Henkilötunnus; // Henkilön henkilötunnus

        private static int Instanssit = 0; // Henkilön staattinen muuttuja, jolla voidaan laskea kuinka monta Henkilöä ollaan luotu

        // Henkilön konstruktori
        public Henkilö(string nimi, int ikä, int henkilötunnus)
        {
            Nimi = nimi;
            Ikä = ikä;
            Henkilötunnus = henkilötunnus;

            Instanssit++; // Lisätään instanssi laskuriin yksi lisää aina kun uusi henkilö luodaan
        }

        // Staattinen metodi, jota kutsumalla voidaan tulostaa konsoliin luotujen henkilöiden määrä
        // Voidaan kutsua Program ohjelmasta "Henkilö.KuinkaMontaHenkilöä()"
        public static void KuinkaMontaHenkilöä()
        {
            Console.WriteLine("Henkilöitä olemassa: " + Instanssit);
        }

        // virtuaalinen metodi jota voidaan ylilukea (override) aliluokissa
        public virtual void TulostaTiedot()
        {
            Console.WriteLine("Henkilö: " + Nimi + ". Ikä: " + Ikä + ". Henkilötunnus: " + Henkilötunnus);
        }

        // random metodeja joita voidaan kutsua myös aliluokista
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
