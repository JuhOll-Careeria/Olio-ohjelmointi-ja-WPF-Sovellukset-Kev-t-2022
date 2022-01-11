using System;

namespace Harjoitus_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kutsutaan jokaisen luokan KuinkaMonta toimintoa
            Koira.KuinkaMonta(); // Koiria 0 tässä kohtaan
            Kissa.KuinkaMonta(); // Kissoja 0 tässä kohtaan
            Eläin.KuinkaMonta(); // Eläimiä 0 tässä kohtaan

            // Luodaan muutama koira ja kissa
            Koira koira1 = new Koira("Mopsi", 4);
            Koira koira2 = new Koira("Saksanpaimenkoira", 6);
            Kissa kissa1 = new Kissa("Oranssi", 2);
            Kissa kissa2 = new Kissa("Musta", 5);

            // Äännellään kissalla ja koiralla
            kissa1.Ääntele();
            koira1.Ääntele();

            // Kutsutaan jokaisen luokan KuinkaMonta toimintoa
            Koira.KuinkaMonta(); // Koiria 2 tässä kohtaan
            Kissa.KuinkaMonta(); // Kissoja 2 tässä kohtaan
            Eläin.KuinkaMonta(); // Eläimiä 4 tässä kohtaan

            koira2.Ääntele();
            kissa2.Ääntele();
        }
    }
}
