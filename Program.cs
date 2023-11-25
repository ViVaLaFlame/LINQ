using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>
            {
                new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"),
                new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"),
                new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
                new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
                new Contact("Сергей", "Брин", 799900000013, "serg@example.com"),
                new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com")
            };

            // Сортируем контакты по имени и фамилии
            var sortedPhoneBook = phoneBook.OrderBy(contact => contact.Name)
                                           .ThenBy(contact => contact.LastName)
                                           .ToList();

            // Выводим отсортированные контакты
            foreach (var contact in sortedPhoneBook)
            {
                Console.WriteLine($"{contact.Name} {contact.LastName}, {contact.PhoneNumber}, {contact.Email}");
            }
        }
    }

    public class Contact // Модель класса
    {
        public Contact(string name, string lastName, long phoneNumber, string email) // Метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string Name { get; }
        public string LastName { get; }
        public long PhoneNumber { get; }
        public string Email { get; }
    }
}
