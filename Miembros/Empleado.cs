using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    public class Empleado : MiembrosDeLaComunidad
    {
        private string puesto {  get; set; }

        public Empleado (string nombre, int edad, string puesto)
            : base(nombre, edad)
        {
            this.puesto = puesto;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine("Puesto: {0}", puesto);
        }
    }
}
