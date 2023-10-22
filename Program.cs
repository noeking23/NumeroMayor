using System;

class Program
{
    static void Main()
    {
        bool repetir = true;
        while (repetir)
        {
            double num1 = 0, num2 = 0; // Inicializamos las variables
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.WriteLine("Ingresa el primer número: ");
                if (double.TryParse(Console.ReadLine(), out num1))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingresa un número válido.");
                }
            }

            entradaValida = false;

            while (!entradaValida)
            {
                Console.WriteLine("Ingresa el segundo número: ");
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingresa un número válido.");
                }
            }

            if (num1 > num2)
            {
                Console.WriteLine($"El mayor número es {num1}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"El mayor número es {num2}");
            }
            else
            {
                Console.WriteLine("Ambos números son iguales.");
            }

            Console.WriteLine("¿Deseas ingresar otro par de números? (s para sí, cualquier otra tecla para salir)");
            if (Console.ReadLine().ToLower() != "s")
            {
                repetir = false;
            }
        }
    }
}
