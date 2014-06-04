using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_C_1
{
    class Kissa
    {
        public Kissa(string nimi) // Konstruktori
        {
            this.nimi = nimi;
        }

        public string getName() // Name getter
        {
            return this.nimi;
        }

        public void setName(string nimi) // Name setter
        {
            this.nimi=nimi;
        }

        private string nimi; // private property name

        public void puhuu()
        {
            Console.WriteLine("\n"+this.nimi+" maukuu!");
        }
    }
}
