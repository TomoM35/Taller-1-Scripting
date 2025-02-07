using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Men� de Operaciones ---");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opci�n: ");

            string option = Console.ReadLine();

            if (option == "4")
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }

            double num1, num2;

            Console.Write("Ingrese el primer n�mero: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Entrada inv�lida. Intente nuevamente.");
                continue;
            }

            Console.Write("Ingrese el segundo n�mero: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Entrada inv�lida. Intente nuevamente.");
                continue;
            }

            double resultado = 0;

            switch (option)
            {
                case "1":
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado de la suma: {resultado}");
                    break;
                case "2":
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado de la resta: {resultado}");
                    break;
                case "3":
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado de la multiplicaci�n: {resultado}");
                    break;
                default:
                    Console.WriteLine("Opci�n inv�lida. Intente nuevamente.");
                    break;
            }
        }
    }
}
