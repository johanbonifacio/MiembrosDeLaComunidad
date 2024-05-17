using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    public abstract class MiembrosDeLaComunidad
    {
        private string nombre { get; set; }
        private int edad { get; set; }

        public MiembrosDeLaComunidad(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public virtual void mostrarInfo ()
        {
            Console.WriteLine("Nombre(s) y Apellido(s): {0}\nEdad: {1}", nombre, edad);
        }
    }
}
