using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_EXAMEN01_21088
{
    class Program
    {
        static void Main(string[] args)
        {
            var Chase = new Chase();
            var Fargo = new Fargo();
            var Banamex = new Banamex();
            var Protocolo1 = new Protocolo1();
            var Protocolo2 = new Protocolo2();
            var Protocolo3 = new Protocolo3();

            Chase.getInfo("21088",Fargo,200);
            Fargo.getInfo("88012", Banamex, 420);
            Banamex.getInfo("8808132", Chase, 666);
            Console.ReadLine();
        }
    }
}
