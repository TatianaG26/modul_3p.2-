using System;

namespace modul_3p._2
{
    internal class Задание_3
    {
        /*Задание 3
        Создайте класс «Заграничный паспорт». 
        Вам необходимо хранить информацию о номере паспорта, ФИО владельца, дате выдачи и т.д.
        Предусмотреть механизмы для инициализации полей класса. 
        Если значение для инициализации неверное, генерируйте исключение. */

        class Passport
        {
            private string passportNumber;
            private string ownerName;
            private DateTime issueDate;

            public string PassportNumber
            {
                get { return passportNumber; }
                set
                {   //Если передаваемое значение отсутствует или не является строкой длиной 8 символов, выбрасывается исключение.
                    if (string.IsNullOrEmpty(value) || value.Length != 8)
                        throw new Exception("Некорректный номер паспорта");
                    passportNumber = value;
                }
            }
            public string OwnerName
            {
                get { return ownerName; }
                set
                {   //Если передаваемое значение отсутствует, выбрасывается исключение.
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("Некорректное имя владельца");
                    ownerName = value;
                }
            }
            public DateTime IssueDate
            {
                get { return issueDate; }
                set
                {
                    //Если передаваемая дата равна значению по умолчанию для типа DateTime, выбрасывается исключение.
                    if (value == default(DateTime))
                        throw new Exception("Некорректная дата выдачи");
                    issueDate = value;
                }
            }
            public Passport(string passportNumber, string ownerName, DateTime issueDate)
            {
                PassportNumber = passportNumber;
                OwnerName = ownerName;
                IssueDate = issueDate;
            }
            public override string ToString()
            {
                return $"Заграничный паспорт {PassportNumber} выдан {IssueDate} на имя {OwnerName}";
            }
        }
        
        static void Main(string[] args)
        {
            var passport = new Passport("12345678", "Ivanov Ivan Ivanovich", new DateTime(2020, 01, 11));
            Console.WriteLine(passport);
        }
    }
}
