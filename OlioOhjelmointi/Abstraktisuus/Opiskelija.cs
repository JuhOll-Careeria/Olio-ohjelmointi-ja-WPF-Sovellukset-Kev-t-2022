using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktisuus
{
    class Opiskelija : Henkilö // Opiskelija perii Henkilön tiedot
    {
        public override string Nimi { get; set; } // Henkilön Abstraktin nimen takia Opiskelijan TÄYTYY toteuttaa nimi

        // Abstraktin Puhu toiminnon takia Opiskelijan TÄYTYY toteuttaa Puhu-metodi
        public override void Puhu()
        {
            Console.WriteLine(Nimi + " puhuu opiskelija luokassa");
        }
    }
}
