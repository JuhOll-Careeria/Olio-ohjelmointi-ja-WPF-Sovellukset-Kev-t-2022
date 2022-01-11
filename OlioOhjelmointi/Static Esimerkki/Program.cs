using System;

namespace Static_Esimerkki
{
    class Program
    {
        static void Main(string[] args)
        {

            float km = 154f; // 154 "kilometriä"
            // Muutetaan kilometrit maileiksi kutsumalla staattista Muuntaja -luokkaa
            float mailit = Muuntaja.KmToMiles(km); // <-- Tallennetaan muunnettu arvo "mailit" muuttujaan

            Console.WriteLine(km + " kilometriä on yhtä kuin " + mailit + " mailia");

        }
    }
}
