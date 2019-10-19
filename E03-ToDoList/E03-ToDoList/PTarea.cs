using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_ToDoList
{
    class PTarea
    {
        private int id;
        private string nombre;
        private string tarea;
        private int hora;
        private DateTime dia;
        private string status;
        private string detalle;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Tarea
        {
            get { return tarea; }
            set { tarea = value; }
        }
        public int Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        public DateTime Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
