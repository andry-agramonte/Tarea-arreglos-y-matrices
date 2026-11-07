
using System;

class Program
{
    static void Main()
    {
        // Crear una matriz para guardar las calificaciones
        double[,] notas = new double[4, 3];

        string[] asignaturas = { "Matematicas", "Espanol", "Informatica" };

        double suma;
        double promedio;
        double mejorPromedio = -1;
        int mejorEstudiante = 0;

        // Solicitar las calificaciones de los estudiantes
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("\nEstudiante " + (i + 1));

            for (int j = 0; j < 3; j++)
            {
                Console.Write("Ingrese la nota de " + asignaturas[j] + ": ");
                notas[i, j] = Convert.ToDouble(Console.ReadLine());

                // Validar que la nota este entre 0 y 100
                while (notas[i, j] < 0 || notas[i, j] > 100)
                {
                    Console.Write("Nota invalida. Ingrese una nota entre 0 y 100: ");
                    notas[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        // Mostrar la matriz completa
        Console.WriteLine("\n--- MATRIZ DE CALIFICACIONES ---");

        Console.WriteLine("Estudiante\tMatematicas\tEspanol\tInformatica");

        for (int i = 0; i < 4; i++)
        {
            Console.Write("Estudiante " + (i + 1) + "\t");

            for (int j = 0; j < 3; j++)
            {
                Console.Write(notas[i, j] + "\t\t");
            }

            Console.WriteLine();
        }

        // Calcular el promedio de cada estudiante
        Console.WriteLine("\n--- PROMEDIO POR ESTUDIANTE ---");

        for (int i = 0; i < 4; i++)
        {
            suma = 0;

            for (int j = 0; j < 3; j++)
            {
                suma += notas[i, j];
            }

            promedio = suma / 3;

            Console.WriteLine("Estudiante " + (i + 1) + ": " + promedio);

            if (promedio > mejorPromedio)
            {
                mejorPromedio = promedio;
                mejorEstudiante = i + 1;
            }

            if (promedio >= 70)
            {
                Console.WriteLine("Estado: Aprobado");
            }
            else
            {
                Console.WriteLine("Estado: Reprobado");
            }
        }

        // Calcular el promedio de cada asignatura
        Console.WriteLine("\n--- PROMEDIO POR ASIGNATURA ---");

        for (int j = 0; j < 3; j++)
        {
            suma = 0;

            for (int i = 0; i < 4; i++)
            {
                suma += notas[i, j];
            }

            promedio = suma / 4;

            Console.WriteLine(asignaturas[j] + ": " + promedio);
        }

        // Mostrar el estudiante con mejor rendimiento
        Console.WriteLine("\n--- MEJOR RENDIMIENTO ACADEMICO ---");
        Console.WriteLine("Estudiante con mejor promedio: " + mejorEstudiante);
        Console.WriteLine("Promedio: " + mejorPromedio);

        Console.ReadKey();
    }
}
