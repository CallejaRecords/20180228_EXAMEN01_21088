using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_021088
{
    class hacerPizza: Tarea
    {
        public override void realizarTarea()
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Realice una pizza");
        }
    }
}
