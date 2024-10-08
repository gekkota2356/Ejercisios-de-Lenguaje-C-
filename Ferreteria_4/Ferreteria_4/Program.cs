using System;

namespace Ferreteria
{
    public class Herramienta
    {
        // Atributos privados
        private string nombre;
        private string codigo;
        private string marca;
        private float precio;

        // Constructor general
        public Herramienta(string N = "", string C = "", string M = "", float P = 0.0f)
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

        // Método para leer datos
        public void LeerDatos()
        {
            Console.Write("\tIngrese el nombre de la herramienta: ");
            nombre = Console.ReadLine();

            Console.Write("\tIngrese el codigo de la herramienta: ");
            codigo = Console.ReadLine();

            Console.Write("\tIngrese la marca de la herramienta: ");
            marca = Console.ReadLine();

            Console.Write("\tIngrese el precio de la herramienta: $");
            precio = float.Parse(Console.ReadLine());
        }

        // Método para imprimir datos
        public void ImprimirDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Codigo: " + codigo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Precio: $" + precio);
            Console.WriteLine();
        }

        // Métodos set
        public void SetNombre(string N) { nombre = N; }
        public void SetCodigo(string C) { codigo = C; }
        public void SetMarca(string M) { marca = M; }
        public void SetPrecio(float P) { precio = P; }

        // Métodos get
        public float GetPrecio() { return precio; }
        public string GetNombre() { return nombre; }
    }

///***********************************************************************************************************

    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            int n;

            // Lectura de datos
            Console.Write("Ingrese la cantidad de herramientas: ");
            n = int.Parse(Console.ReadLine());

            Herramienta[] herramientas = new Herramienta[n];

            // Leer datos
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n\t *********** Ingrese los datos de la herramienta {i + 1} *******************");
                herramientas[i] = new Herramienta(); // Crear instancia
                herramientas[i].LeerDatos();
            }

            // ***************************** MENU DE HERRAMIENTAS *******************************
            int opcion;
            do
            {
                // Impresión de opciones
                Console.Clear();
                Console.WriteLine("\n****************************************** MENU *************************************************");
                Console.WriteLine("\t1. Buscar herramienta por nombre");
                Console.WriteLine("\t2. Cambiar datos de una herramienta");
                Console.WriteLine("\t3. Calcular precio promedio de las herramientas");
                Console.WriteLine("\t4. Salir");

                // Lectura de datos
                Console.Write("\t\tSeleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                // Condición switch
                switch (opcion)
                {
                    // ****************** CASO 1 PARA BUSCAR ****************************
                    case 1:
                        {
                            // Declaración de variables
                            string busqueda;
                            bool encontrada = false;

                            // Lectura de datos
                            Console.Write("\n\tIngrese el nombre de la herramienta a buscar: ");
                            busqueda = Console.ReadLine();

                            // Ciclo for 
                            for (int i = 0; i < n; i++)
                            {
                                // Condición if para encontrar el nombre y sus datos
                                if (herramientas[i].GetNombre() == busqueda)
                                {
                                    herramientas[i].ImprimirDatos();
                                    encontrada = true;
                                    break;
                                }
                            }

                            // Condición if al no encontrar
                            if (!encontrada)
                            {
                                Console.WriteLine("Herramienta no encontrada.");
                            }
                            Console.WriteLine("Presione una tecla para continuar...");
                         
                            break;
                        }
                    // ****************** CASO 2 PARA CAMBIAR ****************************
                    case 2:
                        {
                            // Declaración de variables
                            int i;

                            // Lectura de datos
                            Console.Write("\n\t Ingrese el numero de la herramienta a modificar: ");
                            i = int.Parse(Console.ReadLine());

                            // Lectura de datos
                            Console.WriteLine($"\n\t Ingrese los nuevos datos de la herramienta {i}:");
                            herramientas[i - 1].LeerDatos();
                            Console.WriteLine("Presione una tecla para continuar...");
                            
                            break;
                        }
                    // ****************** CASO 3 PARA PROMEDIAR PRECIOS ****************************
                    case 3:
                        {
                            // Declaración de variables
                            float sumaPrecios = 0.0f;

                            // Ciclo for con operación matemática
                            for (int i = 0; i < n; i++)
                            {
                                sumaPrecios = sumaPrecios+herramientas[i].GetPrecio(); // Suma de precios
                            }

                            // Operación matemática para promedio
                            float promedio = sumaPrecios / n;

                            // Impresión de resultados
                            Console.WriteLine("El promedio de las herramientas es: $" + promedio);
                            Console.WriteLine("Presione una tecla para continuar...");
                          
                            break;
                        }
                    // ****************** CASO 4 PARA SALIR DEL PROGRAMA ****************************
                    case 4:
                        Console.WriteLine("Saliendo del programa.");
                        break;

                    // ****************** SI NO OCUPA UNA DE LAS ANTERIORES ****************************
                    default:
                        Console.WriteLine("Opcion invalida. Intente nuevamente.");
                        break;
                }
            } while (opcion != 4); // Terminar ciclo do

            // No es necesario un destructor en C# ya que la recolección de basura se encarga de liberar la memoria.
        }
    }
}
