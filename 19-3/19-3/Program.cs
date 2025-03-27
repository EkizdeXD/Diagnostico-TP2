using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Seleccione un numero del 1 al 5");
            opcion = int.Parse(Console.ReadLine());
            int n = 0;
            string[] vector = new string[5];
            int[] vector2 = new int[5];
            int[] vector3 = new int[5];
            int[] vector4 = new int[5];
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese 5 nombres de canciones");
                    while (n < 5)
                    {
                        Console.WriteLine($"Ingrese nombre de la cancion nro {n + 1}");
                        vector[n] = Console.ReadLine();
                        n++;
                    }
                    n = 0;
                    while (n < 5)
                    {
                        Console.WriteLine(vector[n]);
                        n++;
                    }
                    break;
                case 2:
                    Console.WriteLine("Ingrese 5 nombres de canciones");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Ingrese nombre de la cancion nro {n + 1}");
                        vector[i] = Console.ReadLine();
                        n++;
                    }
                    n = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(vector[i]);
                        n++;
                    }
                    break;
                case 3:
                    Console.WriteLine("Ingrese un nombre y edad para 5 personas");
                    while (n < 5)
                    {
                        Console.WriteLine($"Ingrese nombre de la persona nro {n + 1}");
                        vector[n] = Console.ReadLine();
                        Console.WriteLine($"Ingrese edad de la persona nro {n + 1}");
                        vector2[n] = int.Parse(Console.ReadLine());
                        n++;
                    }
                    n = 0;
                    while (n < 5)
                    {
                        Console.WriteLine(vector[n]);
                        Console.WriteLine(vector2[n]);
                        n++;
                    }
                    break;
                case 4:
                    Console.WriteLine("Ingrese un nombre y edad para 5 personas");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Ingrese nombre de la persona nro {n + 1}");
                        vector[i] = Console.ReadLine();
                        Console.WriteLine($"Ingrese edad de la persona nro {n + 1}");
                        vector2[i] = int.Parse(Console.ReadLine());
                        n++;
                    }
                    n = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(vector[i]);
                        Console.WriteLine(vector2[i]);
                        n++;
                    }
                    break;
                case 5:
                    while (n < 5)
                    {
                        Console.WriteLine($"Ingrese un numero en cada vector para realizar la cuenta nro {n + 1}");
                        Console.WriteLine("Ingrese un numero para el vector 1");
                        vector2[n] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese un numero para el vector 2");
                        vector3[n] = int.Parse(Console.ReadLine());
                        n++;
                    }
                    n = 0;
                    while (n < 5)
                    {
                        Console.WriteLine($"{vector2[n]} + {vector3[n]} = {vector2[n] + vector3[n]}");
                        n++;
                    }
                    break;

            }
            Console.ReadKey();
        }
    }
}
