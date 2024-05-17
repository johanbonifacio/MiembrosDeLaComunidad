
using Miembros;

// Instancias

MiembrosDeLaComunidad estudiante = new Estudiante( "Juan Pablo Perez Santana", 18, "Psicologia");
MiembrosDeLaComunidad exalumno = new ExAlumno("Ramon Alberto Peña Ramirez", 26, "Ingenieria Civil", 2020);
MiembrosDeLaComunidad docente = new Docente("Ana María Castillo Rodríguez", 32, "Docente", "Ciencias Sociales");
MiembrosDeLaComunidad administrativo = new Administrativo("Johan Alberto Bonifacio Reyes", 38, "Director", "Finanzas");
MiembrosDeLaComunidad maestro = new Maestro("Luis Alejandro Echevarria Soto", 25, "Docente", "Matemáticas", "Calculo Diferencial");
MiembrosDeLaComunidad administrador = new Administrador("Kimberlee Feliz Castro", 26, "Administrador", null, "Recursos Humanos");

//Impresiones

Console.WriteLine("Info del Estudiante\n");
estudiante.mostrarInfo(); Console.WriteLine("----------------------------");

Console.WriteLine("Info del Ex-Alumno\n");
exalumno.mostrarInfo(); Console.WriteLine("----------------------------");

Console.WriteLine("Info del Docente\n");
docente.mostrarInfo(); Console.WriteLine("----------------------------");

Console.WriteLine("Info del Administrativo\n");
administrativo.mostrarInfo(); Console.WriteLine("----------------------------");

Console.WriteLine("Info del Maestro\n");
maestro.mostrarInfo(); Console.WriteLine("----------------------------");

Console.WriteLine("Info del Administrador\n");
administrador.mostrarInfo(); Console.WriteLine("----------------------------");