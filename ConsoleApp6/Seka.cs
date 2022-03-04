using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita2
{
    internal class Matematika : Faktorialas
    {

        public int a = 2; // startinis skaicius
        public int r = 2; // Kas kiek didint
        public double n = 1000000000; // Iki kiek skaiciuot
        public double sk; //Skaiciuojamasis kintamasis
        public int k; //Kiek kartu ciklas sukas
        public DateTime start; //Nuo kur praded skaiciuot laika
        public DateTime end; //Nuo kur baig skaiciuot laika

        public void Seka()
        {
            start = DateTime.Now;

            for (int i = 0; sk < n; i++)
            {
                sk = a * (int)Math.Pow(r, i);

                k = i;

            }
            Console.WriteLine("Programoje skaiciuojamos sekos ciklas prasisuko: " + k + " kartu \n Maksimalus skaicius: " + sk + " \n");

        }
    }
}
