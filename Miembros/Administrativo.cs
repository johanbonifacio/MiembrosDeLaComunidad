using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    public class Administrativo : Empleado
    {
        private string departamento { get; set; }

        public Administrativo(string nombre, int edad, string puesto, string departamento)
            : base(nombre, edad, puesto)
        {
            this.departamento = departamento;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine("Departamento: {0}", departamento);
            Console.WriteLine();
        }
    }
}
