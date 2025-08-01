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
        private string contraseña;

        public string DPI
        {
            
        }

        public void AsignarContraseña(string nuevaContraseña)
        {
            if (nuevaContraseña != null && nuevaContraseña.Length >= 6)
            {
                contraseña = nuevaContraseña;
            }
            else
            {
                Console.WriteLine("La contraseña debe tener al menos 6 caracteres.");
            }
        }

        public bool Autenticar(string input)
        {
            return contraseña == input;
        }
    }
}
