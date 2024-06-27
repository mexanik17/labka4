using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Примерные строки для проверки
        string[] input = {
            "ул. Высоцкого д. 20/3",
            "ул. Пушкина д. 12/34",
            "ул. Ленина д. 5/6",
            "Некорректный адрес",
            "ул. Некорректная 123"
        };

        // Регулярное выражение для проверки адреса
        string pattern = @"^ул\. ([\w\s]+) д\. (\d+\/\d+)$";

        // Создание объекта Regex
        Regex regex = new Regex(pattern);

        // Проверка каждой строки
        for (int i = 0; i < input.Length; ++i)
        {
            string line = input[i];
            Console.WriteLine($"Строка {i + 1}: {line}");

            // Проверяем строку на соответствие шаблону
            Match match = regex.Match(line);
            if (match.Success)
            {
                // Если строка соответствует шаблону, выводим название улицы и номер дома
                string streetName = match.Groups[1].Value;
                string houseNumber = match.Groups[2].Value;
                Console.WriteLine($"Улица: {streetName}, Номер дома: {houseNumber}");
            }
            else
            {
                // Если строка не соответствует шаблону, выводим "Не найдено"
                Console.WriteLine("Не найдено");
            }

            Console.WriteLine(); // Пустая строка для разделения выводов между строками
        }
    }
}
