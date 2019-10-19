using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace E03_ToDoList
{
    class RepoTareas
    {

        int Opc;
        List<PTarea> ListaDeTareas =new List<PTarea>(); 

        public void CrearTareas()
        {
            PTarea NuevaTarea = new PTarea();
            Console.WriteLine("Nombre del encargado de la tarea: ");
            NuevaTarea.Nombre = Console.ReadLine();
            Console.WriteLine("Tarea a realizar: ");
            NuevaTarea.Tarea = Console.ReadLine();
            Console.WriteLine("Hora de realizar la tarea: ");
            NuevaTarea.Hora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dia en que se realizara la tarea: ");
            NuevaTarea.Dia = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Detalle de la tarea: ");
            NuevaTarea.Detalle = Console.ReadLine();
            NuevaTarea.Status = "Pendiente";
            ListaDeTareas.Add(NuevaTarea);
            Console.Clear();
        }
        public void ListarTareas()
        {
            foreach (PTarea NT in ListaDeTareas)
            {
                Console.WriteLine("Nombre del encargado de la tarea:" + NT.Nombre);
                Console.WriteLine("Tarea a realizar: " + NT.Tarea);
                Console.WriteLine("Hora a realizar la tarea: " + NT.Hora);
                Console.WriteLine("Dia en que se realizara la tarea: " + NT.Dia);
                Console.WriteLine("Detalle de la tarea: " + NT.Detalle);
                Console.WriteLine("Status de la tarea: " + NT.Status);
                Console.ReadKey();
            }            
        }
        private void Completada()
        {
            foreach (var item in ListaDeTareas)
            {
                if (item.Status == "Completada") ;
                {
                    Console.WriteLine("ID de la tarea: " + item.Id);
                    Console.WriteLine("Nombre del encargado de la tarea:" + item.Nombre);
                    Console.WriteLine("Tarea a realizar: " + item.Tarea);
                    Console.WriteLine("Hora a realizar la tarea: " + item.Hora);
                    Console.WriteLine("Dia en que se realizara la tarea: " + item.Dia);
                    Console.WriteLine("Detalle de la tarea: " + item.Detalle);
                    Console.WriteLine("Status de la tarea: " + item.Status);
                }
            }
        }
        private void Progreso()
        {
            foreach (var item in ListaDeTareas)
            {
                if (item.Status == "Progreso") ;
                {
                    Console.WriteLine("ID de la tarea: " + item.Id);
                    Console.WriteLine("Nombre del encargado de la tarea:" + item.Nombre);
                    Console.WriteLine("Tarea a realizar: " + item.Tarea);
                    Console.WriteLine("Hora a realizar la tarea: " + item.Hora);
                    Console.WriteLine("Dia en que se realizara la tarea: " + item.Dia);
                    Console.WriteLine("Detalle de la tarea: " + item.Detalle);
                    Console.WriteLine("Status de la tarea: " + item.Status);
                }
            }
        }
        private void Pendiente()
        {
            foreach (var item in ListaDeTareas)
            {
                if (item.Status == "Pendiente")
                {
                    Console.WriteLine("ID de la tarea: " + item.Id);
                    Console.WriteLine("Nombre del encargado de la tarea:" + item.Nombre);
                    Console.WriteLine("Tarea a realizar: " + item.Tarea);
                    Console.WriteLine("Hora a realizar la tarea: " + item.Hora);
                    Console.WriteLine("Dia en que se realizara la tarea: " + item.Dia);
                    Console.WriteLine("Detalle de la tarea: " + item.Detalle);
                    Console.WriteLine("Status de la tarea: " + item.Status);
                }
            }
        }
        public void ListaDeStatus()
        {
            Pendiente();
            Progreso();
            Pendiente();
        }
        public void CambiarStatus()
        {
            foreach(var item in ListaDeTareas)
            {
                Console.WriteLine(item.Id + "" + item);
            }
            Console.WriteLine("Elija el ID de la tarea a modificar ");
            Opc = Convert.ToInt32(Console.ReadLine());
            foreach(var item in ListaDeTareas)
            {
                if(Opc==item.Id)
                {
                    Console.WriteLine("Elija un nuevo status: ");
                    Console.WriteLine("1.-Pendiente " +
                        "2.-Progreso " +
                        "3.-Completa ");
                    Console.ReadLine();
                    switch (Console.ReadLine())
                    {
                        case "1":
                            item.Status = "Pendiente";
                            break;
                        case "2":
                            item.Status = "Progreso";
                            break;
                        case "3":
                            item.Status = "Completada";
                            break;                           
                    }
                }
            }
        }
    }
}
