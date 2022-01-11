using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktisuus
{
    abstract class Henkilö
    {
        public abstract string Nimi { get; set; }

        public abstract void Puhu(); // HUOM! Abstraktit metodit suljetaan ;. Aaltosulkuja ei käytetä

        public static int Instanssit = 0;

        public Henkilö()
        {
            Instanssit++;
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("Henkilöitä elossa: " + Instanssit);
        }
    }
}
