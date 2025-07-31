using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoja_de_trabajo_1.hoja_de_trabajo
{
    internal class Biblioteca
    {
        private string titulo;
        private string autor;
        private bool disponibilidad;
        private double identificador;
        private string usuarioPrestamo;

        public Biblioteca (string titulo, string autor, bool disponibilidad, double identificador, string usuarioPrestamo)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.disponibilidad = disponibilidad;
            this.identificador = identificador;
            this.usuarioPrestamo = usuarioPrestamo;
        }
         public void registrarLibros(string titulonuevo) 
        {
            if (titulo == titulonuevo)
            {
                Console.WriteLine("este libro ya esta registrado");
            }
            else
            {
                Console.WriteLine("libro registrado con el nombre de: ${titulo} con exito");
            }
        }
        public void prestamosdeLibros(bool ocupado= false, bool libre = true)
        {
            if (disponibilidad == ocupado) {
                Console.WriteLine("El libro que solicito, no esta disponible en este momento");
            }
            else if (disponibilidad == libre)
            {
                Console.WriteLine("El libro que solicito, si esta disponible en este momento");
            }
        }
        public 
    }
}
