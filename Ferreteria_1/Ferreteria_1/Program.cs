using System;

namespace Ferreteria_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n***********BIENVENIDO AL INVENTARIO DE LA FERRETERIA***********\n");

            // Lee Cuantas
            Console.Write("Cuantas Herramientas Hay: ");
            int n = int.Parse(Console.ReadLine());

            // Asignacion de memoria 
            Herramienta[] herramientas = new Herramienta[n];

            // Leer los datos 
            LeerHerramientas(herramientas, n);

            // Imprimir todos los datos 
            ImprimirHerramientas(herramientas, n);

            // Buscar herramientas 
            Console.Write("Ingrese el nombre de la Herramienta a buscar: ");
            string nombreBuscado = Console.ReadLine();
            BuscarPorNombre(herramientas, n, nombreBuscado);
        }
//***************************************************************************************************************************
        static void LeerHerramientas(Herramienta[] herramientas, int n)
        {
            for(int i=0;i<n;++i)
            {
                herramientas[i] =new Herramienta();

                Console.Write("\tIngrese el nombre de la Herramienta "+ (i + 1) +": ");
                herramientas[i].Nombre = Console.ReadLine();

                Console.Write("\tIngrese el Codigo de la Herramienta " + (i + 1) + ": ");
                herramientas[i].Codigo = Console.ReadLine();

                Console.Write("\tIngrese la Marca de la Herramienta " + (i + 1) + ": ");
                herramientas[i].Marca = Console.ReadLine();

                Console.Write("\tIngrese el precio de la Herramienta " + (i + 1) + ": $ ");
                herramientas[i].Precio = double.Parse(Console.ReadLine());

                Console.WriteLine();
            }
        }
//**************************************************************************************************************************
        static void ImprimirHerramientas(Herramienta[] herramientas, int n)
        {
            Console.WriteLine("\n************Lista de Herramientas************\n");
            for (int i=0;i<n;++i)
            {
                Console.WriteLine("Herramienta " + (i + 1) + ":");
                Console.WriteLine("Nombre: " + herramientas[i].Nombre);
                Console.WriteLine("Código: " + herramientas[i].Codigo);
                Console.WriteLine("Marca: " + herramientas[i].Marca);
                Console.WriteLine("Precio: $" + herramientas[i].Precio + "\n");
            }

        }
//***********************************************************************************************************************
        static void BuscarPorNombre(Herramienta[] herramientas, int n, string nombreBuscado)
        {
            int encontrados=0;
            Console.WriteLine("\nResultados de búsqueda para el nombre "+nombreBuscado +":\n");

            for(int i=0;i<n;++i)
            {
                if (herramientas[i].Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Herramienta "+(i + 1)+ ":");
                    Console.WriteLine("Nombre: "+herramientas[i].Nombre);
                    Console.WriteLine("Código: " + herramientas[i].Codigo);
                    Console.WriteLine("Marca: " +herramientas[i].Marca );
                    Console.WriteLine("Precio: " + herramientas[i].Precio + "\n");
                    encontrados++;
                }
            }

            if (encontrados==0)
            {
                Console.WriteLine("No se encontraron Herramientas con el nombre ingresado " + nombreBuscado + ".\n");
            }
        }
    }


    public class Herramienta
    {
        // Propiedad para almacenar el nombre 
        public string Nombre
        {
            get; // Obtiene el valor de la propiedad 
            set; // Establece el valor de la propiedad 
        }

        // Propiedad para almacenar el codigo
        public string Codigo
        {
            get; // Obtiene el valor de la propiedad 
            set; // Establece el valor de la propiedad 
        }

        // Propiedad para almacenar la marca 
        public string Marca
        {
            get; // Obtiene el valor de la propiedad 
            set; // Establece el valor de la propiedad 
        }

        // Propiedad para almacenar el precio 
        public double Precio
        {
            get; // Obtiene el valor de la propiedad 
            set; // Establece el valor de la propiedad 
        }
    }