using System;

namespace ejercicio7 {
    internal class Program {
        static public void lectura(int[] N) {
            for (int i = 0; i < N.Length; i++) {
                Console.Write("Nota[" + i + "]: "); N[i] = int.Parse(Console.ReadLine());
                if (N[i] < 0 || N[i] > 20) { Console.WriteLine("Error: la nota debe estar entre 0 y 20"); i--; }
            }
        }
        static public void salida(int[] N) 
        {
            for (int i = 0; i < N.Length; i++) Console.WriteLine("Nota[" + i + "]=" + N[i]);
        }
        static public void frecuencias(int[] N) 
        {
            int[] freq = new int[21];
            for (int i = 0; i < N.Length; i++) freq[N[i]]++;
            Console.WriteLine("Frecuencia de cada nota:");
            for (int i = 0; i <= 20; i++)
            {
              if (freq[i] > 0) Console.WriteLine("Nota " + i + ": " + freq[i] + " veces");
            }
            int max = freq[0];
            for (int i = 1; i <= 20; i++) 
            {
              if (freq[i] > max) max = freq[i];
            }
            Console.Write("La nota que mas se repitio es: ");
            for (int i = 0; i <= 20; i++)
            {
              if (freq[i] == max) Console.Write(i + " ");
            }
            Console.WriteLine("( " + max + " veces )");
        }
        static void Main(string[] args) {
            Console.Write("Ingrese el numero de alumnos: ");
            int[] notas = new int[int.Parse(Console.ReadLine());
            lectura(notas);
            Console.WriteLine("\n--- NOTAS INGRESADAS ---"); 
            salida(notas);
            Console.WriteLine("\n--- RESULTADOS ---"); 
            frecuencias(notas); 
            Console.ReadKey();
        }
    }
}
