using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    public class Docente : Empleado
    {
        private string rama {  get; set; }

        public Docente(string nombre, int edad, string puesto, string rama) 
            : base(nombre, edad, puesto)
        {
            this.rama = rama;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine("Rama: {0}", rama);
        }
    }
}
