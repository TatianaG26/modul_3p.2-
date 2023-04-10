using System;

namespace modul_3p._2
{
    internal class Задание_4
    {
        /*Задание 4
        Пользователь вводит в строку с клавиатуры логическое выражение. 
        Например, 3>2 или 7<3. 
        Программа должна посчитать результат введенного выражения и дать результат true или false. 
        В строке могут быть только целые числа и операторы: <, >, <=, >=, ==, !=. 
        Для обработки ошибок ввода используйте механизм исключений.*/
        static void Main()
        {
            Console.Write("Введите логическое выражение: \nНапример, 3 > 2 или 7 != 3 (обязательно через пробел)\n");
            Console.Write("Допустимые операции: <, >, <=, >=, ==, !=\n\n");
            string input = Console.ReadLine();

            try
            {
                // Разбиваем строку на левую часть, оператор и правую часть
                // используем метод Split, чтобы взять "входную" строку и разделить ее на отдельные части на основе заданного разделителя
                string[] parts = input.Split(' ');

                if (parts.Length != 3)
                {
                    throw new ArgumentException("Некорректное количество частей в выражении");
                }

                int left = int.Parse(parts[0]);
                int right = int.Parse(parts[2]);

                // Вычислить результат выражения
                bool result;
                switch (parts[1])
                {
                    case "<":
                        result = left < right;
                        break;
                    case ">":
                        result = left > right;
                        break;
                    case "<=":
                        result = left <= right;
                        break;
                    case ">=":
                        result = left >= right;
                        break;
                    case "==":
                        result = left == right;
                        break;
                    case "!=":
                        result = left != right;
                        break;
                    default:
                        throw new ArgumentException("Некорректный оператор в выражении");
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
