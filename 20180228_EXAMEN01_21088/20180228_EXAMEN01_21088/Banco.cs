using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_EXAMEN01_21088
{
    abstract class Banco
    {
        public Protocolo envio;
        public string Nombre;

        public virtual void getInfo(string cuenta, Banco destino, int monto) {
            Clasified informacion = new Clasified();
            informacion.cuenta = cuenta;
            informacion.destino = destino;
            informacion.monto = monto;
            envio.transfer(informacion, this);
        }
        public void setProtocolo(Protocolo p)
        {
            this.envio = p;
        }
        public virtual void reciveTransfer(Clasified c, Banco b) { }
        public virtual void verificado(Clasified c, Banco b) { }
    }
}
