using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita2
{
    internal class Faktorialas
    {
        //kintamieji
        private int fact;
        private int a = 1;
       
        public void setFakt(int fact) //faktorialo reiksmes priskirimas kintamajam
        {
            this.fact = fact;
        }

        public int getFakt()
        {
            return fact;
        }
       
        public double Faktor() //faktorialo skaiciavimas
        {
            for (int x = 1; x <= this.fact; x++)
            {
                this.a *= x;

            }
            Console.WriteLine("Skaiciaus(" + this.fact + ") faktorialas yra lygus : " + this.a);
            return this.a;
        }

    }
}