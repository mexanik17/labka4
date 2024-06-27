using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Примерные строки для проверки
        string[] input = {
            "a",
            "aaaaaa",
            "a aa a",
            "abcdef",
            "12345",
            "a@b.com",
            "test@test.test"
        };

        // Шаблоны для проверки
        string pattern1 = @"^a(\s*a)*$";
        string pattern2 = @"^[a-zA-Z0-9]{5,}$";
        string pattern3 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        // объекты Regex для каждого шаблона
        Regex regex1 = new Regex(pattern1);
        Regex regex2 = new Regex(pattern2);
        Regex regex3 = new Regex(pattern3);

        // Проверка каждой строки
        for (int i = 0; i < input.Length; ++i)
        {
            string line = input[i];
            Console.WriteLine($"Cтрока {i + 1}: {line}");

            // Проверяем строку на соответствие первому шаблону
            if (regex1.IsMatch(line))
            {
                Console.WriteLine($"Соответствует шаблону 1: {line}");
            }
            else
            {
                Console.WriteLine($"Не соответствует шаблону 1: {line}");
            }

            // Проверяем строку на соответствие второму шаблону
            if (regex2.IsMatch(line))
            {
                Console.WriteLine($"Соответствует шаблону 2: {line}");
            }
            else
            {
                Console.WriteLine($"Не соответствует шаблону 2: {line}");
            }

            // Проверяем строку на соответствие третьему шаблону
            if (regex3.IsMatch(line))
            {
                Console.WriteLine($"Соответствует шаблону: {line}");
            }
            else
            {
                Console.WriteLine($"Не соответствует шаблону 3: {line}");
            }

            Console.WriteLine(); // Пустая строка для разделения выводов между строками
        }
    }
}
