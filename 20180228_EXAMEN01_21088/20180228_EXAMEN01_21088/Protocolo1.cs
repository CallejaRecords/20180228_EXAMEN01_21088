using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_EXAMEN01_21088
{
    class Protocolo1 : Protocolo
    {
        public void transfer(Clasified c, Banco b)
        {
            Console.WriteLine("Cobro de 100 pesucos, Protocolo 1");
            c.monto += 100;
            c.destino.reciveTransfer(c, b);
        }

        public void verificacion(Clasified c, Banco b)
        {
            b.verificado(c, b);
        }
    }
}
