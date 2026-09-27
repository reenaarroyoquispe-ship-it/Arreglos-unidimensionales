using System;

namespace ejercicio3 {
    internal class Program {
        static public void generar(int[] E) {
            Random rnd = new Random();
            for (int i = 0; i < E.Length; i++) E[i] = rnd.Next(1, 91);
        }
        static public void salida(int[] E) {
            for (int i = 0; i < E.Length; i++) Console.WriteLine("Edad = " + E[i]);
        }
        static public void menorEdad(int[] E) {
            int pos = 0;
            for (int i = 1; i < E.Length; i++) if (E[i] < E[pos]) pos = i;
            Console.WriteLine("La menor edad es: " + E[pos]);
            Console.WriteLine("Su posicion en el arreglo es: " + pos);
        }
        static public void contar30a50(int[] E) {
            int cont = 0;
            for (int i = 0; i < E.Length; i++) if (E[i] >= 30 && E[i] <= 50) cont++;
            Console.WriteLine("Personas entre 30 y 50 anios: " + cont);
        }
        static public void buscar(int[] E, int edad) {
            int pos = -1;
            for (int i = 0; i < E.Length; i++) if (E[i] == edad) { pos = i; break; }
            if (pos >= 0) Console.WriteLine("La edad " + edad + " SI se encontro en la posicion " + pos);
            else Console.WriteLine("La edad " + edad + " NO se encontro en el arreglo");
        }
        static void Main(string[] args) {
            Console.Write("Ingrese la cantidad de personas max 100: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 100) { n = 100; Console.WriteLine("Solo se tomaran 100 personas"); }
            int[] edades = new int[n]; generar(edades);
            Console.WriteLine("\n--- EDADES GENERADAS ---");
            salida(edades);
            Console.WriteLine("\n--- RESULTADOS ---"); 
            menorEdad(edades); 
            contar30a50(edades);
            Console.Write("\nIngrese la edad a buscar: "); 
            int edadBuscada = int.Parse(Console.ReadLine());
            buscar(edades, edadBuscada); Console.ReadKey();
        }
    }
}
