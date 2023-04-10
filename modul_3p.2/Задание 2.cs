using System;

namespace modul_3p._2
{
    internal class Задание_2
    {
        /*Задание 2
        Пользователь вводит словами цифру от 0 до 9. 
        Приложение должно перевести слово в цифру. 
        Например, если пользователь ввёл five, приложение должно вывести на экран 5. */
        static void Main(string[] args)
        {
            Console.Write("Введите слово-цифру от 0 до 9: ");
            string input = Console.ReadLine();
            int number = ParseWord(input);
            Console.WriteLine("Вы ввели число: " + number);
        }
        static int ParseWord(string word)
        {
            switch (word.ToLower())
            {
                case "zero": return 0;
                case "one": return 1;
                case "two": return 2;
                case "three": return 3;
                case "four": return 4;
                case "five": return 5;
                case "six": return 6;
                case "seven": return 7;
                case "eight": return 8;
                case "nine": return 9;

                case "ноль": return 0;
                case "один": return 1;
                case "два": return 2;
                case "три": return 3;
                case "четыре": return 4;
                case "пять": return 5;
                case "шесть": return 6;
                case "семь": return 7;
                case "восемь": return 8;
                case "девять": return 9;
                default:
                    Console.WriteLine("Ошибка: неверное слово-число");
                    return -1;
            }
        }
    }
}
