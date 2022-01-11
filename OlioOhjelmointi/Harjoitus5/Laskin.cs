using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus5
{
    // staattinen luokka, merkitään "static" avainsanalla ennen "class" määritettä
    static class Laskin
    {
        // Static metodi, joka palauttaa "float" arvon returnilla ja ottaa sisään kaksi float arvoa
        // Esim pääohjelmassa kutsumalla "float a = Laskin.Summa(10, 15)" antaisi "a":lle arvoksi 25
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
