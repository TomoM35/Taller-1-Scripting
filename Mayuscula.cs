using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce una frase de al menos tres palabras:");
        string frase = Console.ReadLine();

        string[] palabras = frase.Split(' ');

        if (palabras.Length < 3)
        {
            Console.WriteLine("La frase debe tener al menos tres palabras.");
            return;
        }

        for (int i = 0; i < palabras.Length; i++)
        {
            palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
        }

        string fraseFinal = string.Join(" ", palabras);

        Console.WriteLine("Resultado:");
        Console.WriteLine(fraseFinal);
    }
}
