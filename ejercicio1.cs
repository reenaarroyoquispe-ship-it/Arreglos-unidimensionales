using System;

namespace EJERCICIO_1 {
    internal class Program {
        static public void lectura(int[] N) {
            for (int i = 0; i < N.Length; i++) {
                Console.Write("Nota [" + i + "]:");
                N[i] = int.Parse(Console.ReadLine());
                if (N[i] < 0 || N[i] > 20) {
                    Console.WriteLine("Error: la nota debe estar entre 0 y 20");
                    i--;
                }
            }
        }
        static public void salida(int[] N) {
            for (int i = 0; i < N.Length; i++) Console.WriteLine("Nota[" + i + "]=" + N[i]);
        }
        static public int minimo(int[] N) {
            int menor = N[0];
            for (int i = 1; i < N.Length; i++) if (N[i] < menor) menor = N[i];
            return menor;
        }
        static public void promedio(int[] N) {
            int menor = minimo(N), quitada = 0; double suma = 0;
            for (int i = 0; i < N.Length; i++) {
                if (N[i] == menor && quitada == 0) quitada = 1;
                else suma += N[i];
            }
            Console.WriteLine("La menor nota es: " + menor);
            Console.WriteLine("El promedio es: " + (suma / (N.Length - 1)));
        }
        static void Main(string[] args) {
            int[] notas = new int[6];
            Console.WriteLine("***** Ingrese las Notas del Alumno *****"); 
            lectura(notas);
            Console.WriteLine("***** Notas Ingresadas *****"); 
            salida(notas);
            Console.WriteLine("***** Resultados *****"); 
            promedio(notas);
            Console.ReadKey();
        }
    }
}
