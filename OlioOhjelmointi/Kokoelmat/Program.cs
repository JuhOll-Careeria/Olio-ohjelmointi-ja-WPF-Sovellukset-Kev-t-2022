using System;
using System.Collections.Generic;

namespace Kokoelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------LISTA--------");
            List<string> lista = new List<string>();
            lista.Add("Pekka"); //indeksi 0
            lista.Add("Matti"); //indeksi 1
            lista.Add("Juha"); //indeksi 2

            lista.Remove("Matti");
            // lista.RemoveAt(1);

            // Käydään läpi lista
            // tyyppi - nimi in kokoelma
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------PINO--------");
            Stack<string> pino = new Stack<string>();

            pino.Push("Kortti 1"); // Push:illa lisätään pinon päällimäiseksi uusi objekti
            pino.Push("Kortti 2");
            pino.Push("Kortti 3");

            Console.WriteLine("Pinossa on " + pino.Count + " objektia");
            Console.WriteLine(pino.Peek() + " on pinon päällä"); // Peek:in avulla saadaan tietoon mikä objekti on pinon päällimmäisenä

            pino.Pop(); // Poistetaan päällimäinen objekti pinosta

            Console.WriteLine("Pinossa on " + pino.Count + " objektia");
            Console.WriteLine(pino.Peek() + " on pinon päällä");

            Console.WriteLine("--------JONO--------");

            Queue<string> jono = new Queue<string>();

            jono.Enqueue("Matti"); // Jonoon lisätään Enqueue toiminnolla uusi objekti jonon perään
            jono.Enqueue("Pekka");
            jono.Enqueue("Juha");

            Console.WriteLine("Jonossa on " + jono.Count + " henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa"); // peek toiminnolla saadaan tietoon jonon ensimmäinen objekti

            jono.Dequeue(); // Dequeue poistaa jonon ensimmäisen objektin

            Console.WriteLine("Jonossa on " + jono.Count + " henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa");

            Console.WriteLine("--------SANAKIRJA--------");

            Dictionary<string, string> sanakirja = new Dictionary<string, string>();
            sanakirja.Add("151219-6012", "Matti"); // Matilla on oma uniikki avain
            sanakirja.Add("050616-5124", "Pekka"); // Pekalla on oma uniikki avain

            Console.WriteLine("Sanakirjassa on " + sanakirja.Count + " henkilöä");

            Console.WriteLine("Etsitään sanakirjasta avaimella '151219-6012', haettu henkilö on: " + sanakirja["151219-6012"]);

            foreach (string avain in sanakirja.Keys)
            {
                // Haetaan sanakirjasta AVAIMIEN perusteella. Jos halutaan tulostaa sanakirjan avaimeen liittyvä
                // value, käytetään sanakirja[avain] toimintoa
                Console.WriteLine("Sanakirjasta haettu avaimella: " + avain + ". Value: " + sanakirja[avain]);
            }

            foreach (string henkilö in sanakirja.Values)
            {
                Console.WriteLine("Sanakirjasta haettu valuella: " + henkilö);
            }

            // Alla olevista toiminnoista tulee virhe sovellukseen

            // Yritetään hakea henkilöä listalta virheellisellä henkilötunnuksella, joka EI ole sanakirjassa -> virhe!
            Console.WriteLine("Etsitään sanakirjasta avaimella '151219-5012', haettu henkilö on: " + sanakirja["151219-5012"]);
            // Yritetään lisätä uusi henkilö sanakirjaan jo olemassa olevalla henkilötunnuksella -> VIRHE
            sanakirja.Add("151219-6012", "Juha"); // Juhalla on sama henkilötunnus, eli avain, kuin Matilla
        }
    }
}
