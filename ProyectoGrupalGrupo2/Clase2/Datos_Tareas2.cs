using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGrupalGrupo2.Clase2
{
    public class Datos_Tareas2
    {
        //Atributos
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }

        public Datos_Tareas2(string nombre, string categoria, string descripcion, string fecha)
        {
            Nombre = nombre;
            Categoria = categoria;
            Descripcion = descripcion;
            Fecha = fecha;
        }

        public Datos_Tareas2() { }
    }
}
