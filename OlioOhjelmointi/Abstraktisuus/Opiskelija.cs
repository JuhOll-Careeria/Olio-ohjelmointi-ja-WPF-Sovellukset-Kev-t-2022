using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktisuus
{
    class Opiskelija : Henkilö
    {
        public override string Nimi { get; set; }

        public override void Puhu()
        {
            Console.WriteLine(Nimi + " puhuu opiskelija luokassa");
        }
    }
}
