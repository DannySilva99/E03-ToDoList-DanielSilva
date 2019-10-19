using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_ToDoList
{
    class Menu
    {
        List<PTarea> ListaDeTareas;
        int Opc;
        RepoTareas RT = new RepoTareas();

        public void MenuDeInicio()
        {
            ListaDeTareas = new List<PTarea>();
            do
            {
                do
                {
                    Console.WriteLine("Elija la opcion que desee realizar: ");
                    Console.WriteLine("1.-Crear tarea ");
                    Console.WriteLine("2.-Lista de tareas ");
                    Console.WriteLine("3.-Lista de status ");
                    Console.WriteLine("4.-Cambiar status ");
                    Console.WriteLine("5.-Salir ");
                    Opc = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (Opc < 1 || Opc > 5)
                    {
                        Console.WriteLine("Introduzca una opcion valida ");
                    }
                } while (Opc < 1 || Opc > 5);

                switch (Opc)
                {
                    case 1:
                        {
                            RT.CrearTareas();
                            break;
                        }
                    case 2:
                        {
                            RT.ListarTareas();
                            break;
                        }
                    case 3:
                        {
                            RT.ListaDeStatus();
                            break;
                        }
                    case 4:
                        {
                            RT.CambiarStatus();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Gracias por utilizar el programa");
                            Console.ReadLine();
                            break;
                        }
                }
            } while (Opc != 5);
                     
        }
    }
}
