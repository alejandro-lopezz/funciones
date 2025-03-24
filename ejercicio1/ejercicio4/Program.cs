using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio4 funciones
            int n;
            int resultado = 0; 
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            positivioNegativoCero(n,ref resultado);
            Console.WriteLine(resultado);

        }

        static void positivioNegativoCero(int n, ref int resultado) {
            if(n > 0) {
                resultado = 1;
            } else if(n < 0) {
                resultado = -1;
            } else {
                resultado = 0;
            }
        }

    }
}
