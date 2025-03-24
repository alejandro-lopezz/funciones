using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio2 funciones
            int n;
            int cont = 0;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                if(parOno(n)) {
                    cont++;
                }
            }

            Console.WriteLine("La cantidad de números pares es: " + cont);

        }

        static bool parOno(int a) {
            if(a % 2 == 0) {
                return true;
            } else {
                return false;
            }
        }
    }
}
