using System;

namespace Ferreteria_1
{
    // Definición de la clase Herramienta
    public class Herramienta
    {
        // Atributos privados (no se pueden manipular directamente)
        private string nombre;  // Nombre de la herramienta
        private string codigo;  // Código de la herramienta
        private string marca;   // Marca de la herramienta
        private double precio;  // Precio de la herramienta

        // Constructor general (con parámetros y sin parámetros)
        public Herramienta(string N = "", string C = "", string M = "", double P = 0.0)
        {
            nombre = N;
            codigo = C;
            marca = M;
            precio = P;
        }

        // Constructor de copia
        public Herramienta(Herramienta h)
        {
            nombre = h.nombre;
            codigo = h.codigo;
            marca = h.marca;
            precio = h.precio;
        }

        // Método para leer los datos de la herramienta
        public void LeerDatos()
        {
            Console.Write("\tIngrese el nombre de la herramienta: ");
            nombre = Console.ReadLine(); // Lee el nombre

            Console.Write("\tIngrese el codigo de la herramienta: ");
            codigo = Console.ReadLine(); // Lee el código

            Console.Write("\tIngrese la marca de la herramienta: ");
            marca = Console.ReadLine(); // Lee la marca

            Console.Write("\tIngrese el precio de la herramienta: $");
            precio = double.Parse(Console.ReadLine()); // Lee el precio
        }

        // Método para imprimir los datos de la herramienta
        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Codigo: " + codigo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Precio: $" + precio);
            Console.WriteLine(); // Línea en blanco
        }
    }

    // Clase principal
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("\n*********** BIENVENIDO AL INVENTARIO DE LA FERRETERIA ***********\n");
            Console.WriteLine("************ Lista de Herramientas ************\n");

            // Crear el primer objeto de Herramienta
            Herramienta h1 = new Herramienta();
            h1.LeerDatos(); // Lee los datos de la primera herramienta

            // Imprimir los datos de la primera herramienta
            Console.WriteLine("\nDatos de la herramienta creada:");
            h1.ImprimirDatos();

            // Crear otro objeto de Herramienta
            Herramienta h2 = new Herramienta();
            h2.LeerDatos(); // Lee los datos de la segunda herramienta

            // Imprimir los datos de la segunda herramienta
            Console.WriteLine("\nDatos de la herramienta creada:");
            h2.ImprimirDatos();
        }
    }
}
