using System;

namespace Harjoitus_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1, 6); // Luodaan hissi olio, jossa min kerros 1 ja max kerros 6
            string syöte; // käyttäjän antamaa syötettä varten

            while (true) // While silmukka 
            {
                Console.WriteLine("Olet kerroksessa " + hissi.NykyinenKerros); 
                Console.WriteLine("Mihin kerrokseen haluat siirtyä?");
                syöte = Console.ReadLine(); // kysytään käyttäjän syöte

                // Jos käyttäjä antaa syötteeksi "poistu" poistutaan hissistä käyttämällä "break" toimintoa
                if (syöte == "poistu")
                {
                    Console.WriteLine("Poistuit Hissistä");
                    break;
                }
                else
                {
                    // jos käyttäjä antaa kerroksen niin yritetään siirtyä kerrokseen
                    hissi.NykyinenKerros = int.Parse(syöte);
                }

                // Silmukka jatkuu niin kauan kuin käyttäjä antaa "poistu" komennon
            }
        }
    }
}
