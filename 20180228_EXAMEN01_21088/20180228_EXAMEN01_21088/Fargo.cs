using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180228_EXAMEN01_21088
{
    class Fargo: Banco
    {
        public Fargo()
        {
            this.Nombre = "Fargo";
            Protocolo envioFargo = new Protocolo3();
            setProtocolo(envioFargo);
        }
        public override void getInfo(string cuenta, Banco destino, int monto)
        {
            Clasified informacion = new Clasified();
            informacion.cuenta = cuenta;
            informacion.destino = destino;
            informacion.monto = monto;
            envio.transfer(informacion, this);
        }
        public override void verificado(Clasified c, Banco b)
        {
            if (c.mensaje == "Exito")
            {
                Console.WriteLine("Banco " + b.Nombre + " transfirio un monto de: " + c.monto + " a la cuenta: " + c.cuenta + " del banco: " + c.destino.Nombre);
            }
            else if (c.mensaje == "Error")
            {
                Console.WriteLine("Transferencia Fallida");
            }
            //Console.WriteLine("Banco " + b.Nombre + " transfirio un monto de: " + c.monto + " a la cuenta: " + c.cuenta + " del banco Fargo");

        }
        public override void reciveTransfer(Clasified c, Banco b)
        {
            c.mensaje = "Exito";
            envio.verificacion(c,b);
        }
    }
}
