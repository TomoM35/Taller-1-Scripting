using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un n�mero de m�ximo 8 cifras:");
        string input = Console.ReadLine();

        if (input.Length > 8 || !long.TryParse(input, out _))
        {
            Console.WriteLine("El n�mero debe tener m�ximo 8 cifras.");
            return;
        }

        int result = SumDigitsUntilSingleDigit(input);
        Console.WriteLine($"El valor de un solo d�gito es: {result}");
    }

    static int SumDigitsUntilSingleDigit(string number)
    {
        int sum = 0;

        foreach (char digit in number)
        {
            sum += digit - '0';
        }

        while (sum >= 10)
        {
            sum = SumDigits(sum.ToString());
        }

        return sum;
    }

    static int SumDigits(string number)
    {
        int sum = 0;
        foreach (char digit in number)
        {
            sum += digit - '0';
        }
        return sum;
    }
}
