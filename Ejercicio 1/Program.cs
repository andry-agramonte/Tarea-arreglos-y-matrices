
using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo para almacenar las calificaciones
        double[] notas = new double[10];

        double suma = 0;
        double promedio;
        double mayor = 0;
        double menor = 100;

        int aprobados = 0;
        int reprobados = 0;

        // Solicitar las calificaciones de los 10 estudiantes
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write("Ingrese la calificacion del estudiante " + (i + 1) + ": ");
            notas[i] = Convert.ToDouble(Console.ReadLine());

            // Validar que la nota este entre 0 y 100
            while (notas[i] < 0 || notas[i] > 100)
            {
                Console.Write("Nota invalida. Ingrese una nota entre 0 y 100: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            suma += notas[i];

            if (notas[i] > mayor)
            {
                mayor = notas[i];
            }

            if (notas[i] < menor)
            {
                menor = notas[i];
            }

            if (notas[i] >= 70)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        // Calcular el promedio general
        promedio = suma / notas.Length;

        // Mostrar todas las calificaciones
        Console.WriteLine("\n--- CALIFICACIONES REGISTRADAS ---");

        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine("Estudiante " + (i + 1) + ": " + notas[i]);
        }

        // Mostrar los resultados
        Console.WriteLine("\n--- REPORTE GENERAL ---");
        Console.WriteLine("Promedio general: " + promedio);
        Console.WriteLine("Calificacion mas alta: " + mayor);
        Console.WriteLine("Calificacion mas baja: " + menor);
        Console.WriteLine("Estudiantes aprobados: " + aprobados);
        Console.WriteLine("Estudiantes reprobados: " + reprobados);

        Console.ReadKey();
    }
}
