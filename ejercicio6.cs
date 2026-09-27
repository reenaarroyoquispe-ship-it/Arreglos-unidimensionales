using System;

namespace ejercicio6 {
    internal class Program {
        static public void generar(int[] M) {
            Random rnd = new Random();
            for (int i = 0; i < M.Length; i++) M[i] = rnd.Next(25, 501);
        }
        static public void salida(int[] M) {
            for (int i = 0; i < M.Length; i++) Console.WriteLine("Monto[" + i + "]=" + M[i]);
        }
        static public void copiar(int[] origen, int[] destino) {
            for (int i = 0; i < origen.Length; i++) destino[i] = origen[i];
        }
        static public void ordenar(int[] M) {
            for (int i = 0; i < M.Length - 1; i++) 
            {
                for (int j = 0; j < M.Length - 1 - i; j++) {
                    if (M[j] > M[j + 1]) { int aux = M[j]; M[j] = M[j + 1]; M[j + 1] = aux; }
                }
            }
        }
        static public void contar100a300(int[] M) {
            int cont = 0;
            for (int i = 0; i < M.Length; i++) if (M[i] >= 100 && M[i] <= 300) 
              cont++;
            Console.WriteLine("Personas que gastaron entre 100 y 300 soles: " + cont);
        }
        static public void contarImpares(int[] M) {
            int cont = 0;
            for (int i = 0; i < M.Length; i++) if (M[i] % 2 != 0) 
              cont++;
            Console.WriteLine("Cantidad de montos impares: " + cont);
        }
        static void Main(string[] args) {
            Console.Write("Ingrese el numero de personas max 200: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 200) { n = 200; Console.WriteLine("Solo se tomaran 200 personas"); }
            int[] montos = new int[n]; generar(montos);
            Console.WriteLine("\n--- MONTOS GENERADOS ---"); 
            salida(montos);
            int[] ordenados = new int[n]; 
            copiar(montos, ordenados); 
            ordenar(ordenados);
            Console.WriteLine("\n--- MONTOS ORDENADOS ---"); 
            salida(ordenados);
            Console.WriteLine("\n--- RESULTADOS ---"); 
            contar100a300(montos); 
            contarImpares(montos); 
            Console.ReadKey();
        }
    }
}
