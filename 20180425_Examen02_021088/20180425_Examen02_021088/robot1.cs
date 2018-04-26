using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_021088
{
    class robot1: iRobot
    {
        public robot1()
        {
            //t = new hacerPizza();
        }
        public override void realizarTarea()
        {
            t.realizarTarea();
            terminoTarea();
        }
        public override void terminoTarea()
        {
            t = null;
            c.terminoTarea(t, this);
        }
    }
}
