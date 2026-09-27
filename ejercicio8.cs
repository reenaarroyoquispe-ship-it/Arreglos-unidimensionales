using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static public int SUMADIG(int numero)
        {
            int suma = 0;
            if (numero < 0)
                numero = -numero;

            if (numero == 0)
                return 0;

            while (numero > 0)
            {
                suma += numero % 10;
                numero = numero / 10;
            }
            return suma;
        }

        static public void generar(int[] N)
        {
            Random rnd = new Random();
            for (int i = 0; i < N.Length; i++)
            {
                N[i] = rnd.Next(0, 200);
            }
        }

        static public void salida(int[] N)
        {
            Console.Write("Datos del vector: ");
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write(N[i] + " ");
            }
            Console.WriteLine();
        }

        static public void contarDivisibles(int[] N)
        {
            int cont = 0;
            for (int i = 0; i < N.Length; i++)
            {
                if (SUMADIG(N[i]) % 3 == 0)
                    cont++;
            }
            Console.WriteLine("Hay " + cont + " datos divisibles entre 3");
        }

        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            generar(numeros);
            salida(numeros);
            contarDivisibles(numeros);
            Console.ReadKey();
        }
    }
}
