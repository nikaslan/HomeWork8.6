using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();            

            while (true) // цикл по добавлению записей в записную книжку
            {
                Console.Clear();
                phoneBook = AddNewEntry(phoneBook);
                
                Console.WriteLine("Для завершения добавления записей нажмите Enter.");
                Console.WriteLine("Для добавления еще одной записи, нажмите любую другую кнопку.");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;
                
            }

            while (true) // цикл по выводу значений по запросу
            {
                Console.WriteLine("Для продолжения нажмите Enter. Для выхода нажмите Esc.");
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape) break;
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    FindContact(phoneBook);
                }
            }


        }
        /// <summary>
        /// Добавление новой записи в словарь
        /// </summary>
        /// <param name="phoneBook">Принимаем словарь в текущем состоянии</param>
        /// <returns>Возвращаем обновленный словарь</returns>
        static Dictionary<string, string> AddNewEntry(Dictionary<string, string> phoneBook)
        {
            string[] newEntry = new string[2];

            Console.WriteLine("Введите номер телефона");
            newEntry[0] = Console.ReadLine();
            Console.WriteLine("Введите номер Фамилию владельца телефона");
            newEntry[1] = Console.ReadLine();
            if (phoneBook.ContainsKey(newEntry[0]))
            {
                Console.WriteLine("Такой номер телефона уже зарегистрирован");
            }
            else
            {
                Console.WriteLine($"В записную книжку добавлена запись: {newEntry[0]} - {newEntry[1]}.");
                phoneBook.Add(newEntry[0], newEntry[1]);
            }

            return phoneBook;
        }
        /// <summary>
        /// Нахождение имени контакта по введенному номеру телефона
        /// </summary>
        /// <param name="phoneBook">передаем телефонную книгу в ее текущем состоянии</param>
        static void FindContact(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Введите номер телефона, для отображения соответствующего контакта.");
            string phoneNum = Console.ReadLine();

            if (phoneBook.TryGetValue(phoneNum, out string name))
            {
                Console.WriteLine($"Владелец телефона {phoneNum} - {name}");
                return;
            }
            else Console.WriteLine("Такого номера нет в записной книжке");
        }

    }
}
