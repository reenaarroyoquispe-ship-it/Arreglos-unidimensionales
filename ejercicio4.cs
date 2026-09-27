using System;

namespace ejercicio4 {
    internal class Program {
        static public void lectura(int[] N) {
            for (int i = 0; i < N.Length; i++) {
                Console.Write("Nota[" + i + "]: "); N[i] = int.Parse(Console.ReadLine());
                if (N[i] < 0 || N[i] > 20) { Console.WriteLine("Error: la nota debe estar entre 0 y 20"); i--; }
            }
        }
        static public void promedio(int[] N) {
            double suma = 0;
            for (int i = 0; i < N.Length; i++) suma += N[i];
            Console.WriteLine("El promedio es: " + (suma / N.Length));
        }
        static public void maximo(int[] N) {
            int mayor = N[0];
            for (int i = 1; i < N.Length; i++) if (N[i] > mayor) mayor = N[i];
            Console.WriteLine("La maxima nota es: " + mayor);
        }
        static public void minimo(int[] N) {
            int menor = N[0];
            for (int i = 1; i < N.Length; i++) if (N[i] < menor) menor = N[i];
            Console.WriteLine("La minima nota es: " + menor);
        }
        static void Main(string[] args) {
            Console.Write("Ingrese el numero de alumnos: ");
            int[] notas = new int[int.Parse(Console.ReadLine())];
            lectura(notas); 
            Console.WriteLine("\n--- RESULTADOS ---");
            promedio(notas); 
            maximo(notas); 
            minimo(notas); 
            Console.ReadKey();
        }
    }
}
