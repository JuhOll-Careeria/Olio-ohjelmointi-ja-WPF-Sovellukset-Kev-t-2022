using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Esimerkki
{
    // staattinen luokka merkitään "static" sanalla ennen class nimeä.
    // Tästä luokasa EI voida tehdä oliota (eli ei voidan Programmissa luoda "Muuntaja m = new Muuntaja()"
    static class Muuntaja
    {
        //Staattinen metodi jota voidaan kätevästi kutsua esim Program.cs "Muuntaja.KmToMiles(10)"
        public static float KmToMiles(float km)
        {
            float mailiArvo = 0.62137f;
            return km * mailiArvo;
        }
    }
}
