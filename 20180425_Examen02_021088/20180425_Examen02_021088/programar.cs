using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_021088
{
    class programar: Tarea
    {
        public override void realizarTarea()
        {
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("Programar el examen");
        }
    }
}
