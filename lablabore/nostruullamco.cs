using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int offset = 10;

        for (int i = 0; i < numbers.Length; i++)
        {
            int adjustedNumber = numbers[i] + offset;
            Console.WriteLine($"Adjusted number at index {i}: {adjustedNumber}");
        }

        // Rest of the code...
    }
}
