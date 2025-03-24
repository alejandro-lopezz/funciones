using System;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1 funciones
            float precio, resultado;
            int cantidad;

            Console.WriteLine("Ingrese el precio del articulo: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());

            resultado = producto(precio, cantidad);
            Console.WriteLine("El total a pagar es: " + resultado);

        }

        static float producto(float a, int b) {
            return a * b;
        }

    }
}
