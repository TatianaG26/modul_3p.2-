using System;

namespace modul_3p._2
{
    internal class Program
    {
        /*Задание 1
        Создайте приложение калькулятор для перевода числа из одной системы исчисления в другую. 
        Пользователь с помощью меню выбирает направление перевода. 
        Например, из десятичной в двоичную. 
        После выбора направления, пользователь вводит число в исходной системе исчисления.
        Приложение должно перевести число в требуемую систему. 
        Предусмотреть случай выхода за границы диапазона, определяемого типом int, неправильный ввод.*/

        static string DecimalToBinary(int decimalNumber) => Convert.ToString(decimalNumber, 2);
        static string DecimalToHexadecimal(int decimalNumber) => Convert.ToString(decimalNumber, 16);
        static int BinaryToDecimal(string binaryNumber) => Convert.ToInt32(binaryNumber, 2);
        static int HexadecimalToDecimal(string hexadecimalNumber) => Convert.ToInt32(hexadecimalNumber, 16);
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. Перевод из десятичной системы в двоичную");
                Console.WriteLine("2. Перевод из десятичной системы в шестнадцатеричную");
                Console.WriteLine("3. Перевод из двоичной системы в десятичную");
                Console.WriteLine("4. Перевод из шестнадцатеричной системы в десятичную");
                Console.WriteLine("5. Выход");
                Console.WriteLine("-----------------------");
                Console.Write("Введите действие: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный ввод! ");
                    continue;
                }
                if (choice == 5)
                {
                    Console.WriteLine("Выход из калькулятора...");
                    break;
                }
                if (choice < 1 || choice > 4)
                {
                    Console.WriteLine("Неверный выбор!");
                    continue;
                }
                Console.Write("Введите число для преобразования: ");
                string inputNumber = Console.ReadLine();
                int decimalNumber = 0;
                bool validInput = true;

                switch (choice)
                {
                    case 1:
                        try { decimalNumber = Convert.ToInt32(inputNumber); }
                        catch (FormatException)
                        {
                            Console.WriteLine("Неверный ввод! Пожалуйста, введите десятичное число");
                            validInput = false;
                        }
                        if (validInput && decimalNumber >= 0)
                            Console.WriteLine($"Двоичный эквивалент {decimalNumber} - {DecimalToBinary(decimalNumber)}");
                        else if (validInput)
                            Console.WriteLine("Десятичное число должно быть неотрицательным целым числом!");
                        break;

                    case 2:
                        try { decimalNumber = Convert.ToInt32(inputNumber); }
                        catch (FormatException)
                        {
                            Console.WriteLine("Неверный ввод! Пожалуйста, введите десятичное число.");
                            validInput = false;
                        }
                        if (validInput && decimalNumber >= 0)
                            Console.WriteLine($"Шестнадцатеричный эквивалент {decimalNumber} - {DecimalToHexadecimal(decimalNumber)}");
                        else if (validInput)
                            Console.WriteLine("Десятичное число должно быть неотрицательным целым числом!");
                        break;

                    case 3:
                        bool validBinaryInput = true;
                        foreach (char c in inputNumber)
                        {
                            if (c != '0' && c != '1')
                            {
                                Console.WriteLine("Неверный ввод! Пожалуйста, введите двоичное число.");
                                validBinaryInput = false;
                                break;
                            }
                        }
                        if (validBinaryInput)
                            Console.WriteLine($"Десятичный эквивалент {inputNumber} - {BinaryToDecimal(inputNumber)}");
                        break;

                    case 4:
                        bool validHexadecimalInput = true;
                        foreach (char c in inputNumber)
                        {
                            if (!Char.IsDigit(c) && c != 'A' && c != 'B' && c != 'C' && c != 'D' && c != 'E' && c != 'F' 
                                && c != 'a' && c != 'b' && c != 'c' && c != 'd' && c != 'e' && c != 'f')
                            {
                                Console.WriteLine("Неверный ввод! Пожалуйста, введите шестнадцатеричное число.");
                                validHexadecimalInput = false;
                                break;
                            }
                        }
                        if (validHexadecimalInput)
                            Console.WriteLine($"Десятичный эквивалент {inputNumber} - {HexadecimalToDecimal(inputNumber)}");
                        break;
                }
            } while (true);
        }
    }
}