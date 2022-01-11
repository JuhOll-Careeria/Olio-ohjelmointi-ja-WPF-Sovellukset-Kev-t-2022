using System;

namespace Harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 15;
            float b = 30;

            // Staattista luokkaa ja metodeja voidaan kutsua AINA ilman että siitä luodaan olio
            Console.WriteLine(a + " + " + b + " = " + Laskin.Summa(a, b));
            Console.WriteLine(a + " - " + b + " = " + Laskin.Erotus(a, b));
            Console.WriteLine(a + " * " + b + " = " + Laskin.Kertolasku(a, b));
            Console.WriteLine(a + " / " + b + " = " + Laskin.Jakolasku(a, b));
        }
    }
}
