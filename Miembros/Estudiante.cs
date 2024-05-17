using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    public class Estudiante : MiembrosDeLaComunidad
    {
        private string carrera { get; set; }

        public Estudiante(string nombre, int edad, string carrera)
        : base(nombre, edad)
            {
                this.carrera = carrera;
            }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine("Carrera: {0}", carrera);
        }
    }
}
