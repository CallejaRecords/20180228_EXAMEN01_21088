using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_021088
{
    abstract class Tarea
    {
        public int idTarea { get; set; }
        public DateTime inicio;
        public DateTime termino;
        

        public void tiempoInicio()
        {
            this.inicio = DateTime.Now;
        }
        public void tiempoFinal()
        {
            this.termino = DateTime.Now;
        }

        public abstract void realizarTarea();
    }
}
