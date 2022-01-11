using System;

namespace Abstraktisuus
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija = new Opiskelija(); // luodaan opiskelija
            opiskelija.Nimi = "Pekka";
             
            opiskelija.Puhu(); // opiskelija puhuu

            Henkilö.KuinkaMonta(); // tulostetaan kuinka monta henkilöä on olemassa
        }
    }
}
