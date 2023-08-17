using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            while (true)
            {
                Console.WriteLine("===== Calculadora Científica =====");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz Cuadrada");
                Console.WriteLine("7. Salir");

                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RealizarOperacion("Suma", (x, y) => x + y);
                        break;
                    case 2:
                        RealizarOperacion("Resta", (x, y) => x - y);
                        break;
                    case 3:
                        RealizarOperacion("Multiplicación", (x, y) => x * y);
                        break;
                    case 4:
                        RealizarOperacion("División", (x, y) => x / y);
                        break;
                    case 5:
                        RealizarOperacion("Potencia", (x, y) => Math.Pow(x, y));
                        break;
                    case 6:
                        RealizarOperacion("Raíz Cuadrada", (x, y) => Math.Sqrt(x));
                        break;
                    case 7:
                        Console.WriteLine("Saliendo de la calculadora...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }

        static void RealizarOperacion(string nombreOperacion, Func<double, double, double> operacion)
        {
            Console.WriteLine($"===== {nombreOperacion} =====");
            Console.Write("Ingrese la cantidad de números: ");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            if (cantidadNumeros < 2)
            {
                Console.WriteLine("Se necesitan al menos 2 números para realizar la operación.");
                return;
            }

            double resultado = 0.0;

            for (int i = 1; i <= cantidadNumeros; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                double numero = Convert.ToDouble(Console.ReadLine());

                if (i == 1)
                {
                    resultado = numero;
                }
                else
                {
                    resultado = operacion(resultado, numero);
                }
            }

            Console.WriteLine($"El resultado de la {nombreOperacion} es: {resultado}");
        }
    }
}
