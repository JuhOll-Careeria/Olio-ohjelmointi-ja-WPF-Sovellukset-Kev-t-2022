using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_7
{
    class Hissi
    {
        private int minKerros; // hissi alin kerros
        private int maxKerros; // hissin ylin kerros

        private int nykyinenKerros; // hissin nykyinen kerros (private)

        public Hissi(int minKerros, int maxKerros) // Hissin konstruktori
        {
            this.minKerros = minKerros;
            this.maxKerros = maxKerros;

            NykyinenKerros = minKerros; // alussa asetetaan nykyiseksi kerrokseksi alin kerros (minKerros)
        }

        public int NykyinenKerros // Nykyisen kerroksen aksessori
        {
            get => nykyinenKerros; // Palautetaan nykyinenKerros hakijalle (program ohjelmassa)
            set // Yritetään asettaa uusi kerros
            {
                // Jos käyttäjän antama kerros on suurempi kuin maxKerros (ylin kerros)
                // TAI (|| merkit) pienempi kuin minKerros (alin kerros) niin annetaan virhe viesti
                if (value > maxKerros || value < minKerros)
                {
                    Console.WriteLine("Virheellinen Kerros!");
                }
                else
                {
                    // Jos kerros on min ja max:in välillä niin siirrytään kerrokseen
                    nykyinenKerros = value;
                }
            }
        }
    }
}
