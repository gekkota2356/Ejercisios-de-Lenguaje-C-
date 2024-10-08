using System;

namespace Ferreteria_1
{
    // Definición de la clase Herramienta
    public class Herramienta
    {
        public string Nombre { get; set; }      // Nombre del producto
        public string Codigo { get; set; }       // Código del producto
        public string Marca { get; set; }        // Marca del producto
        public double Precio { get; set; }       // Precio del producto

        // Método para leer los datos de la herramienta
        public void LeerDatos()
        {
            Console.Write("\tIngrese el nombre de la Herramienta: "); // Solicita el nombre
            Nombre = Console.ReadLine(); // Lee el nombre del producto

            Console.Write("\tIngrese el Código de la Herramienta: "); // Solicita el código
            Codigo = Console.ReadLine(); // Lee el código del producto

            Console.Write("\tIngrese la Marca de la Herramienta: "); // Solicita la marca
            Marca = Console.ReadLine(); // Lee la marca del producto

            Console.Write("\tIngrese el precio de la Herramienta: $"); // Solicita el precio
            Precio = double.Parse(Console.ReadLine()); // Lee el precio del producto
            Console.WriteLine(); // Línea en blanco para separar las entradas
        }

        // Método para imprimir los datos de la herramienta
        public void ImpriDatos()
        {
            // Impresión de los datos obtenidos
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Precio: $" + Precio + "\n");
        }
    }

    // Función para buscar herramientas por nombre
    public static void BusPorNom(Herramienta[] herramientas, string nomBus)
    {
        int encon = 0; // Contador de herramientas encontradas
        Console.WriteLine("\nResultados de búsqueda para el nombre \"" + nomBus + "\":");
        for (int i = 0; i < herramientas.Length; i++) // Ciclo for para recorrer el arreglo
        {
            if (herramientas[i].Nombre.Equals(nomBus, StringComparison.OrdinalIgnoreCase)) // Compara el nombre de la herramienta
            {
                herramientas[i].ImpriDatos(); // Imprime los datos si se encuentra
                encon++;
            }
        }

        if (encon == 0)
        {
            Console.WriteLine("No se encontraron Herramientas con el nombre ingresado \"" + nomBus + "\".\n");
        }
    }

    // Clase principal
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\n            *********** BIENVENIDO AL INVENTARIO DE LA FERRETERIA ***********");
            Console.Write("  Cuántas Herramientas Hay: ");
            int n = int.Parse(Console.ReadLine()); // Lee el número de herramientas
            Herramienta[] herramientas = new Herramienta[n]; // Asignación de memoria para el arreglo de herramientas

            // Leer los datos de las herramientas
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("\nIngrese los datos de la Herramienta " + (i + 1) + ":");
                herramientas[i] = new Herramienta(); // Inicializa una nueva instancia de Herramienta
                herramientas[i].LeerDatos(); // Llama al método para leer los datos
            }

            // Imprimir los datos de las herramientas
            Console.WriteLine("\n************ Lista de Herramientas ************");
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("Herramienta " + (i + 1) + ":");
                herramientas[i].ImpriDatos(); // Llama al método para imprimir los datos
            }

            // Buscar herramientas por nombre
            Console.Write("Ingrese el nombre de la Herramienta a buscar: ");
            string nomBus = Console.ReadLine(); // Lee el nombre a buscar
            BusPorNom(herramientas, nomBus); // Llama al método de búsqueda

            // No es necesario liberar memoria en C#, ya que la recolección de basura lo maneja automáticamente
        }
    }
}
