using System;

namespace ejercico3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio3
            int n, resultado;
            float promedio;
            int contadorTotal = 0, contadorPrimos = 0;
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            while(n != 0) {

                resultado = primo(n);
                if(resultado == 1) {
                    contadorPrimos++;
                    contadorTotal += n;
                }

                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
            }

            promedio = (float)contadorTotal / contadorPrimos;
            Console.WriteLine("El promedio de números primos fue: " + promedio);

        }

        static int primo(int n) {
            int con = 0;
            for (int x = 1; x <= n; x++)
            {
                if(n % x == 0) {
                    con++;
                }
            }
            if(con == 2) {
                return 1;
            } else {
                return 0;
            }
        }


    }
}
