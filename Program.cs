using System;
using System.Collections.Generic;

namespace Ejercicios
{
    internal class Program
    {
        static void Main()
        {
       
            Console.WriteLine("Ingrese valores para el arreglo (separados por espacios):");
            string[] inputArray = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(inputArray, int.Parse);

            Console.WriteLine("Ingrese el elemento a buscar:");
            int elementoABuscar = int.Parse(Console.ReadLine());

            int[] posiciones = new int[array.Length];
            int contadorPosiciones = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elementoABuscar)
                {
                    posiciones[contadorPosiciones] = i;
                    contadorPosiciones++;
                    Console.WriteLine($"Elemento encontrado en la posición {i}.");
                }
            }

            if (contadorPosiciones > 0)
            {
                Console.WriteLine("Posiciones del elemento encontrado:");
                Array.Resize(ref posiciones, contadorPosiciones);
                Console.WriteLine(string.Join(" ", posiciones));
            }
            else
            {
                Console.WriteLine("Elemento no encontrado en el arreglo.");
            }

            Random random = new Random();
            int n = random.Next(1, 100) * 2 + 1;
            int[] arreglo = new int[n];

            for (int i = 0; i < n; i++)
            {
                arreglo[i] = random.Next(1, 1000);
            }

            Console.WriteLine("Arreglo generado:");
            Console.WriteLine(string.Join(", ", arreglo));

            int centro = n / 2;
            int valorCentro = arreglo[centro];
            Console.WriteLine($"El valor que ocupa el centro del arreglo es: {valorCentro}");

      
            Console.WriteLine("Ingrese la cantidad de notas:");
            int numNotas = int.Parse(Console.ReadLine());

            int sumaAprobados = 0;
            int cantidadAprobados = 0;
            int sumaDesaprobados = 0;
            int cantidadDesaprobados = 0;

            for (int i = 1; i <= numNotas; i++)
            {
                Console.WriteLine($"Ingrese la nota del alumno {i} (entre 0 y 20):");
                int nota = int.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 20)
                {
                    if (nota >= 12)
                    {
                        sumaAprobados += nota;
                        cantidadAprobados++;
                    }
                    else
                    {
                        sumaDesaprobados += nota;
                        cantidadDesaprobados++;
                    }
                }
                else
                {
                    Console.WriteLine("La nota ingresada no está en el rango válido. Ingrese nuevamente.");
                    i--;
                }
            }

            double promedioAprobados = cantidadAprobados > 0 ? (double)sumaAprobados / cantidadAprobados : 0;
            double promedioDesaprobados = cantidadDesaprobados > 0 ? (double)sumaDesaprobados / cantidadDesaprobados : 0;

            Console.WriteLine($"Promedio de aprobados: {promedioAprobados:F2}");
            Console.WriteLine($"Promedio de desaprobados: {promedioDesaprobados:F2}");
            Console.WriteLine($"Cantidad de aprobados: {cantidadAprobados}");
            Console.WriteLine($"Cantidad de desaprobados: {cantidadDesaprobados}");

     
            Console.WriteLine("Ingrese los IDs de alumnos para Álgebra (separados por espacios):");
            string[] inputAlgebra = Console.ReadLine().Split(' ');
            HashSet<string> algebraSet = new HashSet<string>(inputAlgebra);

            Console.WriteLine("Ingrese los IDs de alumnos para Análisis (separados por espacios):");
            string[] inputAnalisis = Console.ReadLine().Split(' ');
            HashSet<string> analisisSet = new HashSet<string>(inputAnalisis);

            HashSet<string> alumnosComunes = new HashSet<string>(algebraSet);
            alumnosComunes.IntersectWith(analisisSet);

            Console.WriteLine("Alumnos comunes en Álgebra y Análisis:");
            Console.WriteLine(string.Join(", ", alumnosComunes));

            int numAlumnosRepetidos = alumnosComunes.Count;
            Console.WriteLine($"Número de alumnos que se repiten: {numAlumnosRepetidos}");


            Console.WriteLine("Ingrese el tamaño del arreglo:");
            int tamaño = int.Parse(Console.ReadLine());

        
            int[] arregloUnico = new int[tamaño];

            HashSet<int> valoresUnicos = new HashSet<int>();

     
            for (int i = 0; i < tamaño; i++)
            {
                int valor;
                do
                {
                    Console.WriteLine($"Ingrese el valor para la posición {i}:");
                    valor = int.Parse(Console.ReadLine());

                
                    if (valoresUnicos.Contains(valor))
                    {
                        Console.WriteLine("¡El valor ya existe! Ingrese un valor único.");
                    }
                    else
                    {
                        valoresUnicos.Add(valor);
                        arregloUnico[i] = valor;
                    }
                } while (valoresUnicos.Contains(valor));
            }

         
            Console.WriteLine("Arreglo con valores únicos:");
            Console.WriteLine(string.Join(", ", arregloUnico));
        }
    }
}







