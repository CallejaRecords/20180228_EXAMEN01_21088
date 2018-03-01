using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_EXAMEN01_21088
{
    class Protocolo2 : Protocolo
    {
        public void transfer(Clasified c, Banco b)
        {
            Console.WriteLine("Cobro de 150 pesucos, Protocolo 2");
            c.monto += 150;
            c.destino.reciveTransfer(c, b);
        }

        public void verificacion(Clasified c, Banco b)
        {
            b.verificado(c, b);
        }
    }
}
