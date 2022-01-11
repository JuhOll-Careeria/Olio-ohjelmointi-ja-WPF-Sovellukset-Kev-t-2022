using System;
using System.Collections.Generic;
using System.Text;

namespace Perintä
{
    // Opiskeliaj luokka joka on Henkilö luokan aliluokka
    // Eli Opiskelija on Henkilö, mutta Henkilö EI ole opiskelija
    class Opiskelija : Henkilö
    {

        public int opiskelijaID;
        public string koulu;

        private static int Instanssit = 0;

        // Opiskelijan konstruktori
        // Kun konstruktori tehdään yliluokassa ja aliluokassa, tulee se näyttämään hieman erilaiselta
        
        //                                               Tämän alapuolella on opiskelijan konstruktori muuttujat /  base tarkoittaa sitä että se lähettää muuttujat Henkilö luokan konstruktoriin
        public Opiskelija(string nimi, int ikä, int henkilötunnus, int _opiskelijaID, string _koulu) : base(nimi, ikä, henkilötunnus)
        {
            opiskelijaID = _opiskelijaID; // asetetaan opiskelijalle luonti vaiheessa annettu id
            koulu = _koulu; // asetetaan opiskelijalle luonti vaiheessa annettu koulu

            Instanssit++;
        }

        // Staattinen metodi, jota kutsumalla voidaan tulostaa konsoliin luotujen opiskelijoiden määrä
        public static void KuinkaMontaOpiskelijaa()
        {
            Console.WriteLine("Opiskelijoita olemassa: " + Instanssit);
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
