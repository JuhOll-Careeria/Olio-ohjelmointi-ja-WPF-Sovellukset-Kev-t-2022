using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int integeri = 10;
            float floatti = 15.4f;

            string merkkijono = "50";

            float d = integeri;   // Implicit casting
            int c = (int)floatti; // Explicit casting
        }
    }
}
