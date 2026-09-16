using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Создание массива из 10 случайных чисел в диапазоне [1, 100]
        Random random = new Random();
        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101); // 101 не включается
        }

        // 2. Расчет необходимых метрик
        long sum = numbers.Sum();
        
        // Для произведения используем double, чтобы избежать переполнения и получить вывод в экспоненциальном формате (E)
        double product = 1;
        foreach (int num in numbers)
        {
            product *= num;
        }

        double average = numbers.Average();
        int evenCount = numbers.Count(n => n % 2 == 0);
        int greaterThanAverageCount = numbers.Count(n => n > average);

        // 3. Вывод результатов в консоль
        Console.WriteLine($"Массив: {string.Join(", ", numbers)}");
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product:0.00E+00}");
        Console.WriteLine($"Чётных чисел: {evenCount}");
        Console.WriteLine($"Больше среднего ({average:0.0}): {greaterThanAverageCount}");
    }
}