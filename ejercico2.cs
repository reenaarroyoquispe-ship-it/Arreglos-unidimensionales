using System;

namespace ejercicio2 {
    internal class Program {
        static public void lectura(double[] P) {
            for (int i = 0; i < P.Length; i++) {
                Console.Write("Peso: ");
                P[i] = double.Parse(Console.ReadLine());
            }
        }
        static public void salida(double[] P) {
            for (int i = 0; i < P.Length; i++) Console.WriteLine("Peso = " + P[i]);
        }
        static public void promedio(double[] P) {
            double suma = 0;
            for (int i = 0; i < P.Length; i++) suma += P[i];
            Console.WriteLine("El peso promedio es: " + (suma / P.Length));
        }
        static public void pesoMaximo(double[] P) {
            double mayor = P[0];
            for (int i = 1; i < P.Length; i++) if (P[i] > mayor) mayor = P[i];
            Console.WriteLine("El peso de la persona que pesa mas es: " + mayor);
        }
        static public void contexturaDelgada(double[] P) {
            int cont = 0;
            for (int i = 0; i < P.Length; i++) if (P[i] < 53) cont++;
            Console.WriteLine("Personas de contextura delgada: " + cont);
        }
        static public void contexturaMediana(double[] P) {
            int cont = 0;
            for (int i = 0; i < P.Length; i++) if (P[i] >= 53 && P[i] <= 60) cont++;
            Console.WriteLine("Personas de contextura mediana: " + cont);
        }
        static public void contexturaGruesa(double[] P) {
            int cont = 0;
            for (int i = 0; i < P.Length; i++) if (P[i] > 60) cont++;
            Console.WriteLine("Personas de contextura gruesa: " + cont);
        }
        static void Main(string[] args) {
            double[] pesos = new double[10];
            Console.WriteLine("***** Ingrese pesos *****"); 
            lectura(pesos);
            Console.WriteLine("\n--- PESOS INGRESADOS ---"); 
            salida(pesos);
            Console.WriteLine("\n--- RESULTADOS ---"); 
            promedio(pesos);
            pesoMaximo(pesos); 
            contexturaDelgada(pesos); 
            contexturaMediana(pesos); 
            contexturaGruesa(pesos);
            Console.ReadKey();
        }
    }
}
