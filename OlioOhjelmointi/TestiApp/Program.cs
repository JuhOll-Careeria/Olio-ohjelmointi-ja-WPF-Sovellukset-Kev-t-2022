using System;
using System.Windows.Input;

namespace TestiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira koira1 = new Koira(); // Luodaan koira -olio
            koira1.nimi = "Rekku"; // Annetaan koiralle nimi
            koira1.ikä = 4; // Annetaan koiralle ikä
            koira1.rotu = "Saksanpaimenkoira"; // Annetaan koiralle rotu

            koira1.Hauku();
            koira1.TulostaData();

            // uusi koira Olio, jolle on määritelty nimi, ikä ja rotu luonti vaiheessa konstruktorin avulla
            Koira koira2 = new Koira("Urho", 5, "Mopsi"); // <-- Konstruktorin takia tiedot lisätään new Koira() sulkujen sisälle

        }
    }
}
