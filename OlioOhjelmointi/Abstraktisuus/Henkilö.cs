using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktisuus
{
    abstract class Henkilö // abstrakti Henkilö luokka
    {
        public abstract string Nimi { get; set; } // Henkilön Nimi joka on Abstrakti, kun abstarkteja ominaisuuksia luodaan, tulee siihen laittaa { get; set; }

        public abstract void Puhu(); // HUOM! Abstraktit metodit suljetaan ;. Aaltosulkuja ei käytetä

        public static int Instanssit = 0; // Instanssit

        public Henkilö() // Henkilön konstruktori
        {
            Instanssit++; // Instanssi laskuri
        }

        // Staattinen metodi jota kutsumalla saadaan tietää monta henkilöä on olemassa
        public static void KuinkaMonta()
        {
            Console.WriteLine("Henkilöitä elossa: " + Instanssit);
        }
    }
}
