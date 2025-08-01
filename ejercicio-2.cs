using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoja_de_trabajo_1.hoja_de_trabajo
{
    internal class Usuario
    {
        public string Nombre;

        private string dpi;
        private string contrase�a;

        public string DPI
        {
            
        }

        public void AsignarContrase�a(string nuevaContrase�a)
        {
            if (nuevaContrase�a != null && nuevaContrase�a.Length >= 6)
            {
                contrase�a = nuevaContrase�a;
            }
            else
            {
                Console.WriteLine("La contrase�a debe tener al menos 6 caracteres.");
            }
        }

        public bool Autenticar(string input)
        {
            return contrase�a == input;
        }
    }
}
