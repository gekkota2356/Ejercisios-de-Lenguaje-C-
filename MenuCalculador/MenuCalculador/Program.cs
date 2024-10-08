//      Librerías incluidas en .NET:
using System;
using System.Numerics;
using System.IO;

// clase
public class Program
{

//////////////////////// Es un tipo Funcion Principal///////////////////////
    static void Main()
    {

         int opcion = MostrarMenu(out float X, out float Y, out float Z);

        // Declaracion de variable
        float R;

// Condicional general
 switch (opcion)
 {
    // Caso 1
         case 1:
        // Condicion if para proteger el programa
                if(X!=0)
                {
                    R = F_Calc(X);
                    Console.WriteLine(" Resultado = " + R );
                }
                else  Console.WriteLine(" Se indetermina");
                break;
                //Cierra
    // Caso2
            case 2:
             // Segunda Condicion If
                if(Y>0)
                {
                    // Operacion Matematica de Raiz de Y( tiene que tener float para proseguir)
                    R = (float)Math.Sqrt(Y);

                    // Resultado del valor Y
                    Console.WriteLine(" Resultado = " + R);
                }
                // Si no lo es, Imprime un Aviso
                else Console.WriteLine(" No existe, solo seria un numero imaginario, Raiz de menos= i");
                

                break;
                // Cierra
    // Caso 3
            case 3:
            // Impresion para la salida
                   if (Z != 0)
                {
                    Console.WriteLine("Resultado = " + Z);
                }
                

                break;

        // Precierre General Condicional
            default:
                Console.WriteLine("Opción no válida");
                break;
// Cierre General de la Condicion
 
 }
    }
    // Fin del tipo Funcion Principal

///////////////////////// Otra funcion u Objeto///////////////////////////
    static int MostrarMenu(out float X, out float Y, out float Z)
    {
// Impresion de seleccion de opciones
       Console.WriteLine("Menú:");
        Console.WriteLine("1. Opción 1");
        Console.WriteLine("2. Opción 2");
        Console.WriteLine("3. Opción 3 (Salida)");
        Console.Write("Selecciona una opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

    // Segunda Condicion General
        switch (opcion)
        {
            // Caso 1
            case 1:
                Console.Write("Ingresa el valor de X: ");
                X = float.Parse(Console.ReadLine());
                Y = Z = 0;
                break;
                //Cierra
            // Caso 2
            case 2:
                Console.Write("Ingresa el valor de Y: ");
                Y = float.Parse(Console.ReadLine());
                X = Z = 0;
                break;
                // Cierra
            // Caso 3
            case 3:
                Console.Write("Ingresa el valor de salida Z: ");
                Z = float.Parse(Console.ReadLine());
                X = Y = 0;
                break;
                // Cierra

        // Precierre General Condicional
            default:
            // Verificacion
                X = Y = Z = 0;
                break;

    }

// regresa Valor
    return opcion;
    }

// siguiente Funcion u Obejeto
    static float F_Calc(float X)
    {
        // Operacion Matematica
        return 1 / X;
    }
} //Cierre del programa

