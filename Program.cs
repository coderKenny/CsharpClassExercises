using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_C_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa kisu = new Kissa("KisuMisu");

            Apuluokka.InsertLineSepatator();

            kisu.puhuu();

            Apuluokka.InsertLineSepatator();

            Apuluokka.Pause();
        }
    }
}
