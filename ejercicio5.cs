using System;

namespace ejercicio5 {
    internal class Program {
        static public void lectura(int[] N) {
            for (int i = 0; i < N.Length; i++) {
                Console.Write("Nota[" + i + "]: "); N[i] = int.Parse(Console.ReadLine());
                if (N[i] < 0 || N[i] > 20) 
                { Console.WriteLine("Error: la nota debe estar entre 0 y 20"); i--; }
            }
        }
        static public void salida(int[] N) {
            for (int i = 0; i < N.Length; i++) Console.WriteLine("Nota[" + i + "]=" + N[i]);
        }
        static public void contar00(int[] N) {
            int cont = 0;
            for (int i = 0; i < N.Length; i++) if (N[i] == 0) cont++;
            Console.WriteLine("Cantidad de personas que obtuvieron 00: " + cont);
        }
        static public void contar20(int[] N) {
            int cont = 0;
            for (int i = 0; i < N.Length; i++) if (N[i] == 20) cont++;
            Console.WriteLine("Cantidad de personas que obtuvieron 20: " + cont);
        }
        static public void contarAprobados(int[] N) {
            int cont = 0;
            for (int i = 0; i < N.Length; i++) if (N[i] >= 13) cont++;
            Console.WriteLine("Cantidad de personas aprobadas: " + cont);
        }
        static public void contarDesaprobados(int[] N) {
            int cont = 0;
            for (int i = 0; i < N.Length; i++) if (N[i] < 13) cont++;
            Console.WriteLine("Cantidad de personas desaprobadas: " + cont);
        }
        static void Main(string[] args) {
            Console.Write("Ingrese la cantidad de alumnos max 40: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 40) { n = 40; Console.WriteLine("Solo se tomaran 40 alumnos"); }
            int[] notas = new int[n]; 
            lectura(notas);
            Console.WriteLine("\n*********************** Notas Ingresadas ***************************");
            salida(notas);
            Console.WriteLine("\n*********************** Resultados ***************************");
            contar00(notas); 
            contar20(notas); 
            contarAprobados(notas);  
            contarDesaprobados(notas); 
            Console.ReadKey();
        }
    }
}
