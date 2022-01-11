using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus5
{
    // staattinen luokka, merkitään "static" avainsanalla ennen "class" määritettä
    static class Laskin
    {
        // Static metodi, joka palauttaa "float" arvon returnilla
        public static float Summa(float a, float b)
        {
            return a + b;
        }

        public static float Erotus(float a, float b)
        {
            return a - b;
        }

        public static float Kertolasku(float a, float b)
        {
            return a * b;
        }

        public static float Jakolasku(float a, float b)
        {
            return a / b;
        }


    }
}
