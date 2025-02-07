using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 7, 5, };

        Console.WriteLine(array);("Array original:");
        PrintArray(array);

        InverArray(array);

        Console.WriteLine("Array Invertido");
        PrintArray(array);
    }

    static void InverArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right++;
        }
    }

    static void PrintArray(int[] arr)
    {
        Console:WriteLine(string.Join(", ", arr));  
    }

}