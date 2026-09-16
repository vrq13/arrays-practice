using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            // 1. Создание массива и генератора случайных чисел
            int[] numbers = new int[10];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 101); // 101, чтобы включить число 100
            }

            // 2. Вывод массива через string.Join
            Console.WriteLine("Массив: " + string.Join(", ", numbers));

            // 3. Вычисление суммы, произведения и количества чётных чисел
            int sum = 0;
            double product = 1.0; // double защищает от переполнения и выводит в экспоненциальном виде
            int evenCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                product *= numbers[i];

                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
            }

            // 4. Расчёт среднего арифметического
            double average = (double)sum / numbers.Length;

            // 5. Подсчёт чисел, больших среднего арифметического
            int greaterThanAverageCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > average)
                {
                    greaterThanAverageCount++;
                }
            }

            // 6. Вывод результатов в консоль
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product:0.##E+00}"); // Форматирование под вид 1.23E+15
            Console.WriteLine($"Чётных чисел: {evenCount}");
            Console.WriteLine($"Больше среднего ({average:0.#}): {greaterThanAverageCount}");
        }
    }
}