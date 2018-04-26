using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_021088
{
    abstract class iRobot
    {
        public Tarea t;
        public Checador c { get; set; }
        public int ID { get; set; }
        public void setTarea(Tarea x, Checador c)
        {
            this.t = x;
            this.c = c;
            realizarTarea();
        }
        public abstract void realizarTarea();
        public abstract void terminoTarea();
    }
}
