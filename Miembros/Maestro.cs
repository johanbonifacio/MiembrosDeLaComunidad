using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
   public class Maestro : Docente
    {
        private string asignatura {  get; set; }
        
        public Maestro (string nombre, int edad, string puesto, string rama, string asignatura)
            : base(nombre, edad, puesto, rama)
        {
            this.asignatura = asignatura;
        }

        public override void mostrarInfo()
        {  
            base.mostrarInfo();
            Console.WriteLine("Asignatura: {0}", asignatura);
            Console.WriteLine();
        }
    }
}
