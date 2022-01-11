using System;

namespace Harjoitus_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1, 6);
            string syöte;

            while (true)
            {
                Console.WriteLine("Olet kerroksessa " + hissi.NykyinenKerros);
                Console.WriteLine("Mihin kerrokseen haluat siirtyä?");
                syöte = Console.ReadLine();

                if (syöte == "poistu")
                {
                    Console.WriteLine("Poistuit Hissistä");
                    break;
                }
                else
                {
                    hissi.NykyinenKerros = int.Parse(syöte);
                }
            }
        }
    }
}
