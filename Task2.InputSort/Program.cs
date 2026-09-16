using System;

class Program
{
    static void Main()
    {
        // 1. Запрос количества элементов N с проверкой (N > 0)
        int n = 0;
        while (n <= 0)
        {
            Console.Write("Введите количество элементов: ");
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Ошибка: количество элементов должно быть больше 0.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено не число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: число слишком большое или слишком маленькое.");
            }
        }

        int[] array = new int[n];

        // 2. Заполнение массива с обработкой исключений
        for (int i = 0; i < n; i++)
        {
            bool isCorrect = false;
            while (!isCorrect)
            {
                Console.Write($"Элемент [{i}]: ");
                try
                {
                    array[i] = int.Parse(Console.ReadLine());
                    isCorrect = true; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода! Ожидалось целое число. Повторите попытку.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка ввода! Число вышло за границы диапазона int. Повторите попытку.");
                }
            }
        }

        // 3. Вывод массива в прямом порядке
        Console.Write("Исходный массив: ");
        Console.WriteLine(string.Join(", ", array));

        // 4. Вывод массива в обратном порядке
        Console.Write("Обратный порядок: ");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(array[i] + (i > 0 ? ", " : ""));
        }
        Console.WriteLine();

        // 5. Поиск максимума и минимума (без LINQ)
        int min = array[0];
        int max = array[0];
        for (int i = 1; i < n; i++)
        {
            if (array[i] < min) min = array[i];
            if (array[i] > max) max = array[i];
        }

        // 6. Сортировка по возрастанию и вывод
        Array.Sort(array);
        Console.Write("Отсортированный: ");
        Console.WriteLine(string.Join(", ", array));

        // Вывод максимума и минимума
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Минимум: {min}");
    }
}