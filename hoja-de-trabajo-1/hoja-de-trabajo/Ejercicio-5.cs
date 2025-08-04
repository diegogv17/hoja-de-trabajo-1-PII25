using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoja_de_trabajo_1.hoja_de_trabajo

/*Hecho por Jorge Omar Chután Rosales - 240070*/

{
    abstract class Vehiculo
    {
        public string Marca { get; set; }

        public Vehiculo(string marca)
        {
            Marca = marca;
        }

        public abstract void Encender();
        public abstract void Conducir();
    }

    // Clase concreta: Carro
    class Carro : Vehiculo
    {
        public Carro(string marca) : base(marca) { }

        public override void Encender()
        {
            Console.WriteLine($"El carro {Marca} está encendido.");
        }

        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo el carro {Marca} por la carretera.");
        }
    }

    // Clase concreta: Motocicleta
    class Motocicleta : Vehiculo
    {
        public Motocicleta(string marca) : base(marca) { }

        public override void Encender()
        {
            Console.WriteLine($"La motocicleta {Marca} está encendida.");
        }

        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo la motocicleta {Marca} entre el tráfico.");
        }
    }

    // Clase principal (Main)
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Carro("Toyota"),
            new Motocicleta("Yamaha"),
            new Carro("Ford"),
            new Motocicleta("Honda")
        };

            foreach (var vehiculo in vehiculos)
            {
                vehiculo.Encender();
                vehiculo.Conducir();
                Console.WriteLine(); // Separador visual
            }

            Console.ReadKey();
        }
    }

}
