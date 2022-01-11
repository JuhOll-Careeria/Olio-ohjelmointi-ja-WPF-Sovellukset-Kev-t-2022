using System;
using System.Collections.Generic;
using System.Text;

namespace Perintä
{
    class Opiskelija : Henkilö
    {
        public int opiskelijaID;
        public string koulu;

        public Opiskelija(string nimi, int ikä, int henkilötunnus, int _opiskelijaID, string _koulu) : base(nimi, ikä, henkilötunnus)
        {
            opiskelijaID = _opiskelijaID;
            koulu = _koulu;
        }

        // override ylilukee Henkilö -luokan "TulostaTiedot()" metodin
        public override void TulostaTiedot()
        {
            Console.WriteLine("Opiskelija: " + Nimi + ". Ikä: " + Ikä + ". Koulu: " + koulu + ". OpiskelijaID: " + opiskelijaID);
        }

        public void Opiskele()
        {
            Console.WriteLine(Nimi + " Opiskelee...");
        }
    }
}
