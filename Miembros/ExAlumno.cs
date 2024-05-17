using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miembros
{
    public class ExAlumno : MiembrosDeLaComunidad
    {
        private string carrera {  get; set; }
        private int graduacion {  get; set; }

        public ExAlumno(string nombre, int edad, string carrera, int graduacion)
        : base (nombre, edad)
        {
            this.carrera = carrera;
            this.graduacion = graduacion;
        }

        public override void mostrarInfo()
        {
            base.mostrarInfo();
            Console.WriteLine("Carrera: {0}\nAño en que se graduó: {1}", carrera, graduacion);
        }
    }
}
