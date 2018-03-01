using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_EXAMEN01_21088
{
    interface Protocolo
    {
        void transfer(Clasified c, Banco b);
        void verificacion(Clasified c, Banco b);
    }
}
