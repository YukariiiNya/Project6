using System;

class Program
{
    // Метод для вычисления разности
    static int CalculateDifference(int n)
    {
        int difference = Math.Abs(n - 123); // Абсолютная разность

        // Если n больше 123, возвращаем тройную разность
        if (n > 123)
        {
            difference *= 3;
        }

        return difference;
    }

    static void Main()
    {
        Console.WriteLine("Введите число n:");
        int n = int.Parse(Console.ReadLine()); // Ввод числа n

        int result = CalculateDifference(n); // Вычисление разности
        Console.WriteLine($"Результат: {result}");
    }
}
