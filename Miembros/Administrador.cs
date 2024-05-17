using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    public class Administrador : Docente
    {
        private string area {  get; set; }

        public Administrador(string nombre, int edad, string puesto, string rama, string area)
            : base(nombre, edad, puesto, rama)
        {
            this.area = area;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine("Área: {0}", area);
        }
    }
}
