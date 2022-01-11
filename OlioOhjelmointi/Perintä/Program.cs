using System;

namespace Perintä
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö.KuinkaMontaHenkilöä();
            Opiskelija.KuinkaMontaOpiskelijaa();

            Henkilö henkilö = new Henkilö("Matti", 20, 1042104); // Henkilö olio. Henkilö EI ole Opiskelija
            Opiskelija opiskelija = new Opiskelija("Pekka", 18, 2155821, 12345, "Careeria"); // Opiskelija olio. Opiskelija on Henkilö

            Henkilö.KuinkaMontaHenkilöä();
            Opiskelija.KuinkaMontaOpiskelijaa();

            henkilö.TulostaTiedot();
            opiskelija.TulostaTiedot();

            henkilö.Syö();
            henkilö.Juo();

            Console.WriteLine();

            opiskelija.Opiskele();
            opiskelija.Juo();
            opiskelija.Syö();
            opiskelija.Opiskele();
        }
    }
}
