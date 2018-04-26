using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180425_Examen02_021088
{
    class Checador
    {
        List<Tarea> pendientes = new List<Tarea>();
        List<Tarea> terminadas = new List<Tarea>();
        List<iRobot> esperando = new List<iRobot>();
        List<iRobot> operando = new List<iRobot>();

        public void agregarPendiente(Tarea t)
        {
            pendientes.Add(t);
        }
        public void agregarEsclavo(iRobot r)
        {
            esperando.Add(r);
        }
        public void comenzar()
        {
            asignarTarea();
        }
        public void asignarTarea()
        {
            //foreach (iRobot robot in esperando)
            //{
            for (int x = esperando.Count - 1; x >= 0; x--) {
                for (int i = pendientes.Count - 1; i >= 0; i--){
                    try
                    {
                        esperando[x].setTarea(pendientes[i], this);
                        esperando.Remove(esperando[x]);
                        operando.Add(esperando[x]);
                        pendientes[i].tiempoInicio();
                        string inicio = pendientes[i].inicio.ToString() + " " + esperando[x].ID + " Realizando" + Environment.NewLine;
                        using (StreamWriter writer = new StreamWriter(@"C:\Users\Brian\OneDrive\CETYS Drive\Programacion Objetos\20180425_Examen02_021088\Log.txt", true))
                        {
                            writer.WriteLine(inicio);
                        }
                        //File.WriteAllText(@"C:\Users\Brian\OneDrive\CETYS Drive\Programacion Objetos\20180425_Examen02_021088\Log.txt", inicio);
                        pendientes.Remove(pendientes[i]);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("An error occurred: '{0}'", e);
                    }
                }
            }

                    //foreach (Tarea ta in pendientes)
                    //{
                    //    try{
                    //        robot.setTarea(ta, this);
                    //        esperando.Remove(robot);
                    //        operando.Add(robot);
                    //        pendientes.Remove(ta);
                    //        ta.tiempoInicio();
                    //        string inicio = ta.inicio.ToString() + " " + ta.idTarea + " Realizando" + Environment.NewLine;
                    //        File.WriteAllText(@"C:\Users\Brian\OneDrive\CETYS Drive\Programacion Objetos\20180425_Examen02_021088\Log.txt", inicio);
                    //    }
                    //    catch (Exception e)
                    //    {
                    //        Console.WriteLine("An error occurred: '{0}'", e);
                    //    }

                    //}
                  
            //}
            
        }
        public void terminoTarea(Tarea x, iRobot r)
        {
            terminadas.Add(x);
            for (int i = operando.Count - 1; i >= 0; i--) {
                for (int y = terminadas.Count - 1; y >= 0; y--)
                {
                    if (operando[i].ID == r.ID)
                    {
                        string final = terminadas[y].termino.ToString() + " " + operando[i].ID + " Termino" + Environment.NewLine;
                        using (StreamWriter writer = new StreamWriter(@"C:\Users\Brian\OneDrive\CETYS Drive\Programacion Objetos\20180425_Examen02_021088\Log.txt", true))
                        {
                            writer.WriteLine(final);
                        }
                        //File.WriteAllText(@"C:\Users\Brian\OneDrive\CETYS Drive\Programacion Objetos\20180425_Examen02_021088\Log.txt", final);
                        operando.Remove(r);
                        esperando.Add(r);
                        Console.WriteLine("Remove");
                    }
                }
            }
            
            //foreach (iRobot robot in operando)
            //{
            //    if (robot.ID == r.ID)
            //    {
            //        operando.Remove(r);
            //    }
            //}
            esperando.Add(r);
            terminoTodo();
        }
        public void terminoTodo()
        {
            if (pendientes == null && operando == null) {
                Console.WriteLine("Se termino");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
