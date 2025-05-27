using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.Write("Masukkan target angka yang dicari: ");
        int target = int.Parse(Console.ReadLine());


        string result = FindTargetIndex(numbers, target);

        Console.WriteLine(result);

    }


    static string FindTargetIndex(int[] numbers, int target)
    {

        for (int i = 0; i < numbers.Length; i++)
        {

            if (numbers[i] == target)
            {
                return $"Angka {target} ada pada index {i}";
            }
        }

        return "Target tidak ditemukan";
    }
}
