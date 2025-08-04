using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Hecho por Jorge Omar Chután Rosales - 240070*/

namespace hoja_de_trabajo_1.hoja_de_trabajo
{
    abstract class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        // Método abstracto que será implementado por las subclases
        public abstract void MostrarPerfil();
    }

    // Clase concreta: Estudiante
    class Estudiante : Persona
    {
        public string Grado { get; set; }

        public Estudiante(string nombre, string grado) : base(nombre)
        {
            Grado = grado;
        }

        public override void MostrarPerfil()
        {
            Console.WriteLine($"Estudiante: {Nombre} | Grado: {Grado}");
        }
    }

    // Clase concreta: Maestro
    class Maestro : Persona
    {
        public string Especialidad { get; set; }

        public Maestro(string nombre, string especialidad) : base(nombre)
        {
            Especialidad = especialidad;
        }

        public override void MostrarPerfil()
        {
            Console.WriteLine($"Maestro: {Nombre} | Especialidad: {Especialidad}");
        }
    }

    // Clase que representa la escuela
    class Escuela
    {
        private List<Persona> personas;

        public Escuela()
        {
            personas = new List<Persona>();
        }

        public void AgregarPersona(Persona persona)
        {
            personas.Add(persona);
        }

        public void MostrarPerfiles()
        {
            foreach (var persona in personas)
            {
                persona.MostrarPerfil(); // Polimorfismo
            }
        }
    }


}
