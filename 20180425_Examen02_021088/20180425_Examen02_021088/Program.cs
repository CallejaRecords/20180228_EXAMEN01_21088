using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_021088
{
    class Program
    {
        static void Main(string[] args)
        {
            iRobot robot1 = new robot1();
            iRobot robot2 = new robot2();
            iRobot robot3 = new Robot3();
            

            Tarea pizza1 = new hacerPizza();
            Tarea pintar1 = new pintarAuto();
            Tarea programar1 = new programar();
            Tarea pizza2 = new hacerPizza();
            Tarea pintar2 = new pintarAuto();
            Tarea programar2 = new programar();
            Tarea pizza3 = new hacerPizza();
            Tarea pintar3 = new pintarAuto();
            Tarea programar3 = new programar();
            
            Checador check = new Checador();

            check.agregarPendiente(pizza1);
            check.agregarPendiente(pintar1);
            check.agregarPendiente(programar1);
            check.agregarPendiente(pizza2);
            check.agregarPendiente(pintar2);
            check.agregarPendiente(programar3);
            check.agregarPendiente(pizza3);
            check.agregarPendiente(pintar3);
            check.agregarPendiente(programar3);

            check.agregarEsclavo(robot1);
            check.agregarEsclavo(robot2);
            check.agregarEsclavo(robot3);

            check.comenzar();
            Console.ReadLine();
        }
    }
}
