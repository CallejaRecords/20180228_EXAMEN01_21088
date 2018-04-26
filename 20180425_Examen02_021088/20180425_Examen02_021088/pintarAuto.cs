using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_021088
{
    class pintarAuto: Tarea
    {
        public override void realizarTarea()
        {
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Lave tu auto");
        }
    }
}
